using MaterialSkin.Controls;
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
using VCMS.Library;
using VCMS.Library.Models;

namespace VCMS.Forms.Services
{
    public partial class ServiceForm: MaterialForm
    {
        private List<OwnerModel> customers = new List<OwnerModel>();
        private List<PetModel> pets = new List<PetModel>();
        private List<ServiceModel> services = new List<ServiceModel>();
        public ServiceForm()
        {
            InitializeComponent();
            nextVisitDatetime.StateCommon.Content.Color1 = Properties.Settings.Default.GlobalFontColor;
            nextVisitDatetime.StateCommon.Back.Color1 = Properties.Settings.Default.GlobalControlBack;
            serviceList.Columns.Add("ID", 32);
            serviceList.Columns.Add("Date", 170);
            serviceList.Columns.Add("Service", 150);
            serviceList.Columns.Add("Weight", 110);
            serviceList.Columns.Add("Temp", 120);
            serviceList.Columns.Add("Against", 200);
            serviceList.Columns.Add("Manufacturer", 200);
            serviceList.Columns.Add("Next Visit", 170);
            Library.Controller.Clients clients = new Library.Controller.Clients();
            customers = clients.AllClients();
        }

        private void TestCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(serviceCombobox.SelectedIndex != 0)
            {
                againstTextbox.Enabled = true;
                manufacturerTextbox.Enabled = true;
                return;
            }
            againstTextbox.Text = string.Empty;
            manufacturerTextbox.Text = string.Empty;
            againstTextbox.Enabled = false;
            manufacturerTextbox.Enabled = false;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            foreach (OwnerModel customer in customers)
            {
                customerCombobox.Items.Add(customer.FullName);
            }
        }

        private void customerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            petCombobox.Items.Clear();
            Library.Controller.Pets cpets = new Library.Controller.Pets();
            pets = cpets.FindPetsByClientID(customers[customerCombobox.SelectedIndex].ID);
            foreach (PetModel pet in pets)
            {
                petCombobox.Items.Add(pet.PetName);
            }
        }

        private void petCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadServiceView();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (serviceList.Enabled)
            {
                Library.Controller.Services services = new Library.Controller.Services();
                DateTime? emptyDate = null;
                services.Create(new ServiceModel()
                {
                    DocID = Config.CurrentUser.DocID,
                    OwnerID = customers[customerCombobox.SelectedIndex].ID,
                    PetID = pets[petCombobox.SelectedIndex].ID,
                    Service = serviceCombobox.Text,
                    Weight = weightTextbox.Text,
                    Temperature = temperatureTextbox.Text,
                    Against = againstTextbox.Text,
                    Manufacturer = manufacturerTextbox.Text,
                    Complaint = "",
                    Findings = "",
                    Test = "",
                    LaboratoryResult = "",
                    NextVisit = nextVisitDatetime.Checked ? nextVisitDatetime.Value : emptyDate
                });
                LoadServiceView();
            }
        }

        private void LoadServiceView()
        {
            Library.Controller.Services cservices = new Library.Controller.Services();
            services = cservices.GetServicesByPet(pets[petCombobox.SelectedIndex].ID);
            serviceList.Items.Clear();
            foreach (var service in services.Where(s => s.Service != ""))
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = service.ID.ToString();
                item.SubItems.Add(service.DateServed.ToString());
                item.SubItems.Add(service.Service.ToString());
                item.SubItems.Add(service.Weight.ToString());
                item.SubItems.Add(service.Temperature.ToString());
                item.SubItems.Add(service.Against.ToString());
                item.SubItems.Add(service.Manufacturer.ToString());
                item.SubItems.Add(service.NextVisit.ToString());
                serviceList.Items.Add(item);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (serviceList.SelectedItems.Count > 0)
            {
                if (editButton.Text == "Edit")
                {
                    serviceCombobox.SelectedIndex = serviceCombobox.Items.IndexOf(serviceList.SelectedItems[0].SubItems[2].Text);

                    weightTextbox.Text = serviceList.SelectedItems[0].SubItems[3].Text;
                    temperatureTextbox.Text = serviceList.SelectedItems[0].SubItems[4].Text;
                    againstTextbox.Text = serviceList.SelectedItems[0].SubItems[5].Text;
                    manufacturerTextbox.Text = serviceList.SelectedItems[0].SubItems[6].Text;

                    if (serviceList.SelectedItems[0].SubItems[7].Text != string.Empty)
                    {
                        nextVisitDatetime.Checked = true;
                        nextVisitDatetime.Value = DateTime.Parse(serviceList.SelectedItems[0].SubItems[7].Text);
                    }
                    customerCombobox.Enabled = false;
                    petCombobox.Enabled = false;
                    serviceCombobox.Enabled = false;
                    serviceList.Enabled = false;
                    editButton.Text = "Save";
                    return;
                }
                if (editButton.Text == "Save")
                {
                    DateTime? emptyDate = null;
                    Library.Controller.Services services = new Library.Controller.Services();
                    services.UpdateService(new ServiceModel()
                    {
                        ID = Convert.ToInt32(serviceList.SelectedItems[0].SubItems[0].Text),
                        Weight = weightTextbox.Text,
                        Temperature = temperatureTextbox.Text,
                        Against = againstTextbox.Text,
                        Manufacturer = manufacturerTextbox.Text,
                        NextVisit = nextVisitDatetime.Checked ? nextVisitDatetime.Value : emptyDate
                    });
                    serviceCombobox.SelectedIndex = serviceCombobox.Items.IndexOf(string.Empty);
                    weightTextbox.Text = string.Empty;
                    temperatureTextbox.Text = string.Empty;
                    againstTextbox.Text = string.Empty;
                    manufacturerTextbox.Text = string.Empty;
                    nextVisitDatetime.Checked = false;
                    customerCombobox.Enabled = true;
                    petCombobox.Enabled = true;
                    serviceCombobox.Enabled = true;
                    serviceList.Enabled = true;
                    editButton.Text = "Edit";
                    LoadServiceView();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (serviceList.Enabled)
            {
                if (serviceList.SelectedItems.Count == 0) return;
                string message = $"A record about {serviceList.SelectedItems[0].SubItems[1].Text} will all be deleted permanently. Please consider this before clicking yes, We are not responsible of any lose about this record.";
                MessageBoxResult x = System.Windows.MessageBox.Show(message, "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.No) return;
                Library.Controller.Services services = new Library.Controller.Services();
                int thisid = Convert.ToInt32(serviceList.SelectedItems[0].SubItems[0].Text);
                services.Delete(thisid);
                LoadServiceView();
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
