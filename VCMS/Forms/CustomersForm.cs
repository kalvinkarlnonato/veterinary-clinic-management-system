using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using VCMS.Library.Models;
using VCMS.Forms.Customers;
using MaterialSkin.Controls;

namespace VCMS.Forms
{
    public partial class CustomersForm : MaterialForm
    {

        private List<OwnerModel> Owners { get; set; }
        public CustomersForm()
        {
            InitializeComponent();
            Owners = new List<OwnerModel>() {
                new OwnerModel() { ID = 0, FirstName = "Juan",LastName= "Dela Cruz", Address = "Tuguegarao City", Cellphone = "0998-765-4321", DateRegistered = DateTime.Now ,
                    Pets = new List<PetModel>{
                        new PetModel { ID = 0, Name="Elphi", Breed="Askal", Species="Dog", Birthday = DateTime.Parse("9/1/2023"), ColorMarking="Black White", Sex="Male", NextVisit=DateTime.Parse("9/9/2023 10:00AM")},
                        new PetModel { ID = 1, Name="Lukas", Breed="Askal", Species="Dog", Birthday = DateTime.Now, ColorMarking="Black White", Sex="Male", NextVisit=DateTime.Parse("9/7/2023 9:00AM")},
                        new PetModel { ID = 2, Name="Mika", Breed="Askal", Species="Dog", Birthday = DateTime.Now, ColorMarking="Black White", Sex="Female", NextVisit=DateTime.Parse("9/7/2023 9:00AM")}
                    }
                },
                new OwnerModel() { ID = 1, FirstName = "Nathaniel", LastName = "Dela Cruz", Address = "Tuguegarao City", Cellphone = "0998-765-4321", DateRegistered = DateTime.Now,
                    Pets = new List<PetModel>{
                        new PetModel { ID = 3, Name="Charlie", Breed="German Shepherd", Species="Dog", Birthday = DateTime.Now, ColorMarking="Black White", Sex="Male", NextVisit=DateTime.Parse("10/1/2023 9:00AM")} }
                },
                new OwnerModel() { ID = 2, FirstName = "Jacob", LastName = "Dela Cruz", Address = "Tuguegarao City", Cellphone = "0998-765-4321", DateRegistered = DateTime.Now,
                    Pets = new List<PetModel>{
                        new PetModel { ID = 4, Name="Romy", Breed="Siamese cat", Species="Cat", Birthday = DateTime.Now, ColorMarking="Black White", Sex="Male", NextVisit=DateTime.Parse("10/2/2023 9:00AM")} }
                },
                new OwnerModel() { ID = 3, FirstName = "Coquette", LastName = "Dela Cruz", Address = "Tuguegarao City", Cellphone = "0998-765-4321", DateRegistered = DateTime.Now,
                    Pets = new List<PetModel>{
                        new PetModel { ID = 5, Name="Kierra", Breed="Holland Lop", Species="Rabbit", Birthday = DateTime.Now, ColorMarking="Black White", Sex="Male", NextVisit=DateTime.Parse("10/3/2023 9:00AM")} }
                },
                new OwnerModel() { ID = 4, FirstName = "Joshua", LastName = "Dela Cruz", Address = "Tuguegarao City", Cellphone = "0998-765-4321", DateRegistered = DateTime.Now,
                    Pets = new List<PetModel>{
                        new PetModel { ID = 6, Name="Mickey", Breed="Silkie", Species="Chicken", Birthday = DateTime.Now, ColorMarking="Black White", Sex="Male", NextVisit=DateTime.Parse("10/4/2023 9:00AM")} }
                },
                new OwnerModel() { ID = 5, FirstName = "Angelo", LastName = "Dela Cruz", Address = "Tuguegarao City", Cellphone = "0998-765-4321", DateRegistered = DateTime.Now,
                    Pets = new List<PetModel>{
                        new PetModel { ID = 7, Name="Tazzie", Breed="Kunekune", Species="Pig", Birthday = DateTime.Now, ColorMarking="Black White", Sex="Male", NextVisit=DateTime.Parse("10/5/2023 9:00AM")} }
                }
            };
        }
        private void LoadCustomerView()
        {
            clientsList.Columns.Add("ID", 80);
            clientsList.Columns.Add("Owner", 350);
            clientsList.Columns.Add("Pet", 250);
            clientsList.Columns.Add("Phone No.", 200);
            clientsList.Columns.Add("Address", 400);
            clientsList.Columns.Add("Next Visit", 200);

            foreach (var Owner in Owners)
            {
                var item = clientsList.Items.Add(Owner.ID.ToString());
                item.SubItems.Add(Owner.FullName.ToString());
                item.SubItems.Add(Owner.PetSpecies.ToString());
                item.SubItems.Add(Owner.Cellphone.ToString());
                item.SubItems.Add(Owner.Address.ToString());
                item.SubItems.Add(Owner.Pets.Last().NextVisit.ToString());
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchTextbox.Visible = !searchTextbox.Visible;
            searchTextbox.Focus();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(clientsList.SelectedItems.Count == 0) { return; }
            string message = $"A record about {clientsList.SelectedItems[0].SubItems[1].Text} will all be deleted permanently. Please consider this before clicking yes, We are not responsible of any lose about this record.";
            System.Windows.MessageBox.Show(message, "Are you sure?",MessageBoxButton.YesNo,MessageBoxImage.Warning);
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomerView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OwnerModel owner = new OwnerModel();
            ManageForm form = new ManageForm { owner = owner };
            form.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (clientsList.SelectedItems.Count == 0) { return; }
            int ownerId = int.Parse(clientsList.SelectedItems[0].Text);
            OwnerModel owner = Owners.Where(o => o.ID == ownerId).First();
            ManageForm form = new ManageForm { owner = owner };
            form.ShowDialog();
        }

        private void AddPetButton_Click(object sender, EventArgs e)
        {
            if (clientsList.SelectedItems.Count == 0) { return; }
            int ownerId = int.Parse(clientsList.SelectedItems[0].Text);
            OwnerModel owner = Owners.Where(o => o.ID == ownerId).First();
            PetsForm form = new PetsForm { owner = owner };
            form.ShowDialog();
        }

        private void ClientsList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DeleteButton_Click(sender, e);
            }
        }
    }
}
