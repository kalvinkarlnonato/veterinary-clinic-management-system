using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MaterialSkin.Controls;
using VCMS.Library.Models;

namespace VCMS.Forms.Customers
{
    public partial class PetsForm : MaterialForm
    {
        public OwnerModel owner { get; set; }

        public PetsForm()
        {
            InitializeComponent();

            petsList.Columns.Add("ID", 50);
            petsList.Columns.Add("Name", 120);
            petsList.Columns.Add("Species", 200);
            petsList.Columns.Add("Breed", 200);
            petsList.Columns.Add("Color Marking", 170);
            petsList.Columns.Add("Birthday", 170);
            petsList.Columns.Add("Sex", 100);

        }

        private void PetsForm_Load(object sender, EventArgs e)
        {
            foreach (PetModel pet in owner.Pets)
            {
                ListViewItem item = petsList.Items.Add(pet.ID.ToString());
                item.SubItems.Add(pet.Name);
                item.SubItems.Add(pet.Species);
                item.SubItems.Add(pet.Breed);
                item.SubItems.Add(pet.ColorMarking);
                item.SubItems.Add(pet.Birthday.ToString());
                item.SubItems.Add(pet.Sex);
            }
            this.Text = owner.FullName + "'s Pets";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchTextbox.Visible = !searchTextbox.Visible;
            searchTextbox.Focus();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PetModel pet = new PetModel();
            ManageForm form = new ManageForm { pet = pet };
            form.Text = "Add " + owner.FullName + "'s Pet";
            form.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (petsList.SelectedItems.Count == 0) { return; }
            int petId = int.Parse(petsList.SelectedItems[0].Text);
            PetModel pet = owner.Pets.Where(p => p.ID == petId).First();
            ManageForm form = new ManageForm { pet = pet };
            form.Text = "Edit " + owner.FullName + "'s Pet";
            form.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (petsList.SelectedItems.Count == 0) { return; }
            string message = $"All checkups and medications about {petsList.SelectedItems[0].SubItems[1].Text} will be deleted permanently. Are you sure to continue?.";
            System.Windows.MessageBox.Show(message, "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
        }
    }
}
