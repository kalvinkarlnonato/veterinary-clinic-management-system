using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCMS.Library.Models;
using MaterialSkin.Controls;
using VCMS.Library;
using VCMS.Library.Controller;
using System.Security.Cryptography;

namespace VCMS.Forms.Customers
{
    public partial class ManageForm : MaterialForm
    {
        public OwnerModel owner { get; set; }
        public PetModel pet { get; set; }
        public ManageForm()
        {
            InitializeComponent();
            
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            sexCombobox.SelectedIndex = -1;
            breedCombobox.SelectedIndex = -1;
            birthdayDatepicker.StateCommon.Content.Color1 = Properties.Settings.Default.GlobalFontColor;
            birthdayDatepicker.StateCommon.Back.Color1 = Properties.Settings.Default.GlobalControlBack;
            speciesCombobox.SelectedIndex = -1;
            if (owner != null)
            {
                if(owner.FirstName == null)
                {
                    this.Text = "Add";
                    clientsInfoPanel.Visible = true;
                    patientsInfoPanel.Visible = true;
                    patientsInfoPanel.Top = 286;
                    this.Height = 555;
                }
                else
                    {
                    this.Text = "Edit";
                    firstNameTextbox.Text = owner.FirstName;
                    lastNameTextbox.Text = owner.LastName;
                    contactTextbox.Text = owner.Cellphone;
                    addressTextbox.Text = owner.Address;
                    clientsInfoPanel.Visible = true;
                    patientsInfoPanel.Visible = false;
                    patientsInfoPanel.Top = 286;
                    this.Height = 360;
                }
            }
            if (pet != null)
            {
                if(pet.PetName != null)
                {
                    petNameTextbox.Text = pet.PetName;
                    speciesCombobox.SelectedIndex = speciesCombobox.Items.IndexOf(pet.Species);
                    breedCombobox.SelectedIndex = breedCombobox.Items.IndexOf(pet.Breed);
                    birthdayDatepicker.Value = pet.Birthday;
                    colormarkingTextbox.Text = pet.ColorMarking;
                    sexCombobox.SelectedIndex = sexCombobox.Items.IndexOf(pet.Sex);
                }
                clientsInfoPanel.Visible = false;
                patientsInfoPanel.Visible = true;
                patientsInfoPanel.Top = 67;
                this.Height = 360;
            }
            speciesCombobox.DataSource = null;
            Library.Controller.Libraries lib = new Library.Controller.Libraries();
            List<LibraryModel> species = lib.FinstLibrariesByCategory("Species");
            speciesCombobox.DataSource = species;
            speciesCombobox.DisplayMember = "Description";


        }
        private void ContactTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ContactTextbox_Leave(object sender, EventArgs e)
        {
            contactTextbox.Text = Config.FormatPhoneNumber(contactTextbox.Text);
        }

        private void ContactTextbox_Enter(object sender, EventArgs e)
        {
            contactTextbox.Text = contactTextbox.Text.Replace("-", "");
        }

        private void SpeciesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            breedCombobox.DataSource = null;
            Library.Controller.Libraries lib = new Library.Controller.Libraries();
            List<LibraryModel> species = lib.FinstLibrariesByCategory(speciesCombobox.Text);
            breedCombobox.DataSource = species;
            breedCombobox.DisplayMember = "Description";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (clientsInfoPanel.Visible)
            {
                Library.Controller.Clients clients = new Library.Controller.Clients();
                if (owner.ID == 0)
                {
                    OwnerModel client = new OwnerModel()
                    {
                        FirstName = firstNameTextbox.Text,
                        LastName = lastNameTextbox.Text,
                        Address = addressTextbox.Text,
                        Cellphone = contactTextbox.Text,
                    };
                    owner = clients.Create(client);
                    pet = new PetModel();
                    pet.OwnerID = owner.ID;
                    pet.PetName = petNameTextbox.Text;
                    pet.Species = speciesCombobox.Text;
                    pet.Breed = breedCombobox.Text;
                    pet.ColorMarking = colormarkingTextbox.Text;
                    pet.Birthday = birthdayDatepicker.Value;
                    pet.Sex = sexCombobox.Text;
                    Library.Controller.Pets pets = new Library.Controller.Pets();
                    pets.Create(pet);
                }
                else
                {
                    OwnerModel client = new OwnerModel()
                    {
                        ID = owner.ID,
                        FirstName = firstNameTextbox.Text,
                        LastName = lastNameTextbox.Text,
                        Address = addressTextbox.Text,
                        Cellphone = contactTextbox.Text,
                    };
                    clients.Update(client);
                }
            }
            else
            {
                pet.PetName = petNameTextbox.Text;
                pet.Species = speciesCombobox.Text;
                pet.Breed = breedCombobox.Text;
                pet.ColorMarking = colormarkingTextbox.Text;
                pet.Birthday = birthdayDatepicker.Value;
                pet.Sex = sexCombobox.Text;
                Library.Controller.Pets pets = new Library.Controller.Pets();
                if (pet.ID>0)
                    pets.Update(pet);
                else
                    pets.Create(pet);
                
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
