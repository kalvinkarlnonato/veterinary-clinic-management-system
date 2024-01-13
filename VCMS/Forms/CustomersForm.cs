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
            clientsList.Columns.Add("ID", 80);
            clientsList.Columns.Add("Owner", 350);
            clientsList.Columns.Add("Pet(s)", 250);
            clientsList.Columns.Add("Phone No.", 200);
            clientsList.Columns.Add("Address", 400);
            clientsList.Columns.Add("Registered Date", 400);
            clientsList.Columns.Add("Next Visit", 200);
        }
        private void LoadCustomerView()
        {
            clientsList.Items.Clear();

            Library.Controller.Clients clients = new Library.Controller.Clients();
            Owners = clients.AllClients();

            Library.Controller.Pets pets = new Library.Controller.Pets();
            foreach (var Owner in Owners)
            {
                var item = clientsList.Items.Add(Owner.ID.ToString());
                item.SubItems.Add(Owner.FullName.ToString());
                List<string> petNames = pets.FindPetsByClientID(Owner.ID).Select(p => p.PetName).ToList();
                string cPetNames = String.Join(",",petNames);
                item.SubItems.Add(cPetNames);
                item.SubItems.Add(Owner.Cellphone.ToString());
                item.SubItems.Add(Owner.Address.ToString());
                item.SubItems.Add(Owner.DateRegistered.ToString());
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchTextbox.Visible = !searchTextbox.Visible;
            searchTextbox.Focus();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(clientsList.SelectedItems.Count == 0) return;
            string message = $"A record about {clientsList.SelectedItems[0].SubItems[1].Text} will all be deleted permanently. Please consider this before clicking yes, We are not responsible of any lose about this record.";
            MessageBoxResult x= System.Windows.MessageBox.Show(message, "Are you sure?",MessageBoxButton.YesNo,MessageBoxImage.Warning);
            if(x == MessageBoxResult.No) return;
            Library.Controller.Clients clients = new Library.Controller.Clients();
            int thisid = Convert.ToInt32(clientsList.SelectedItems[0].SubItems[0].Text);
            clients.Delete(thisid);
            LoadCustomerView();
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
            LoadCustomerView();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (clientsList.SelectedItems.Count == 0) { return; }
            int ownerId = int.Parse(clientsList.SelectedItems[0].Text);
            OwnerModel owner = Owners.Where(o => o.ID == ownerId).First();
            ManageForm form = new ManageForm { owner = owner };
            form.ShowDialog();
            LoadCustomerView();
        }

        private void AddPetButton_Click(object sender, EventArgs e)
        {
            if (clientsList.SelectedItems.Count == 0) { return; }
            int ownerId = int.Parse(clientsList.SelectedItems[0].Text);
            OwnerModel owner = Owners.Where(o => o.ID == ownerId).First();
            PetsForm form = new PetsForm { owner = owner };
            form.ShowDialog();
            LoadCustomerView();
        }

        private void ClientsList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DeleteButton_Click(sender, e);
            }
            if(e.KeyCode == Keys.F1)
            {
                SearchButton_Click(sender, e);
            }
            if(e.KeyCode == Keys.F2)
            {
                AddButton_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                AddPetButton_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                EditButton_Click(sender, e);
            }
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Enter))
            {
                if(searchTextbox.Text.Length > 0)
                {
                    Library.Controller.Clients clients = new Library.Controller.Clients();
                    Owners = clients.Find(searchTextbox.Text);
                    clientsList.Items.Clear();
                    foreach (var Owner in Owners)
                    {
                        var item = clientsList.Items.Add(Owner.ID.ToString());
                        item.SubItems.Add(Owner.FullName.ToString());
                        item.SubItems.Add(Owner.PetSpecies.ToString());
                        item.SubItems.Add(Owner.Cellphone.ToString());
                        item.SubItems.Add(Owner.Address.ToString());
                        item.SubItems.Add(Owner.DateRegistered.ToString());
                    }
                }
                else
                {
                    LoadCustomerView();
                }
            }
            if(e.KeyCode == Keys.Escape)
            {
                searchTextbox.Text = String.Empty;
                searchTextbox.Visible = false;
            }
        }
    }
}
