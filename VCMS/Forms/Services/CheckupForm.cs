using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCMS.Library;
using MaterialSkin.Controls;
using VCMS.Library.Models;
using VCMS.Library.Controller;
using System.Windows;

namespace VCMS.Forms.Services
{
    public partial class CheckupForm : MaterialForm
    {
        private List<ServiceModel> services = new List<ServiceModel>();
        private List<OwnerModel> customers = new List<OwnerModel>();
        private List<PetModel> pets = new List<PetModel>();
        public CheckupForm()
        {
            InitializeComponent();
            nextVisitDatetime.StateCommon.Content.Color1 = Properties.Settings.Default.GlobalFontColor;
            nextVisitDatetime.StateCommon.Back.Color1 = Properties.Settings.Default.GlobalControlBack;
            Library.Controller.Clients clients = new Library.Controller.Clients();
            customers = clients.AllClients();
            checkupList.Columns.Add("ID", 30);
            checkupList.Columns.Add("Date", 150);
            checkupList.Columns.Add("Complaint", 370);
            checkupList.Columns.Add("Findings", 340);
            checkupList.Columns.Add("Test", 220);
            checkupList.Columns.Add("Result", 220);
            checkupList.Columns.Add("Next Visit", 140);
            string[] tests = { "CBC", "Fecalysis", "Blood Chem", "Skin Scraph", "Blood Smear", "Viginal Smear", "Urinalysis", "Ultrasound", "X-Ray"};
            foreach (string test in tests)
            {
                testCombobox.Items.Add(test);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (checkupList.Enabled)
            {
                Library.Controller.Services services = new Library.Controller.Services();
                DateTime? emptyDate = null;
                services.Create(new ServiceModel()
                {
                    DocID = Config.CurrentUser.DocID,
                    OwnerID = customers[customerCombobox.SelectedIndex].ID,
                    PetID = pets[petCombobox.SelectedIndex].ID,
                    Service = "",
                    Weight="",
                    Temperature="",
                    Against="",
                    Manufacturer="",
                    Complaint = complaintTextbox.Text,
                    Findings = findingsTextbox.Text,
                    Test = testCombobox.Text,
                    LaboratoryResult = resultTextbox.Text,
                    NextVisit = nextVisitDatetime.Checked ? nextVisitDatetime.Value : emptyDate
                });
                LoadCheckupView();
            }
        }

        private void CheckupForm_Load(object sender, EventArgs e)
        {
            foreach(OwnerModel customer in customers)
            {
                customerCombobox.Items.Add(customer.FullName);
            }
        }

        private void CustomerCombobox_SelectedIndexChanged(object sender, EventArgs e)
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
            LoadCheckupView();
        }
        private void LoadCheckupView()
        {
            checkupList.Items.Clear();
            Library.Controller.Services cservices = new Library.Controller.Services();
            services = cservices.GetServicesByPet(pets[petCombobox.SelectedIndex].ID);
            foreach (var service in services.Where(s => s.Test != ""))
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = service.ID.ToString();
                item.SubItems.Add(service.DateServed.ToString());
                item.SubItems.Add(service.Complaint.ToString());
                item.SubItems.Add(service.Findings.ToString());
                item.SubItems.Add(service.Test.ToString());
                item.SubItems.Add(service.LaboratoryResult.ToString());
                item.SubItems.Add(service.NextVisit.ToString());
                checkupList.Items.Add(item);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(checkupList.SelectedItems.Count > 0)
            {
                if(editButton.Text == "Edit")
                {
                    testCombobox.SelectedIndex = testCombobox.Items.IndexOf(checkupList.SelectedItems[0].SubItems[4].Text);
                    complaintTextbox.Text = checkupList.SelectedItems[0].SubItems[2].Text;
                    findingsTextbox.Text = checkupList.SelectedItems[0].SubItems[3].Text;
                    resultTextbox.Text = checkupList.SelectedItems[0].SubItems[5].Text;
                    if (checkupList.SelectedItems[0].SubItems[6].Text != string.Empty)
                    {
                        nextVisitDatetime.Checked = true;
                        nextVisitDatetime.Value = DateTime.Parse(checkupList.SelectedItems[0].SubItems[6].Text);
                    }
                    customerCombobox.Enabled = false;
                    petCombobox.Enabled = false;
                    testCombobox.Enabled = false;
                    checkupList.Enabled = false;
                    editButton.Text = "Save";
                    return;
                }
                if(editButton.Text == "Save")
                {
                    DateTime? emptyDate = null;
                    Library.Controller.Services services = new Library.Controller.Services();
                    services.UpdateCheckup(new ServiceModel()
                    {
                        ID = Convert.ToInt32(checkupList.SelectedItems[0].SubItems[0].Text),
                        Complaint = complaintTextbox.Text,
                        Findings = findingsTextbox.Text,
                        LaboratoryResult = resultTextbox.Text,
                        NextVisit = nextVisitDatetime.Checked ? nextVisitDatetime.Value : emptyDate
                    });
                    testCombobox.SelectedIndex = testCombobox.Items.IndexOf(string.Empty);
                    complaintTextbox.Text = string.Empty;
                    findingsTextbox.Text = string.Empty;
                    resultTextbox.Text = string.Empty;
                    nextVisitDatetime.Checked = false;
                    customerCombobox.Enabled = true;
                    petCombobox.Enabled = true;
                    testCombobox.Enabled = true;
                    checkupList.Enabled = true;
                    editButton.Text = "Edit";
                    LoadCheckupView();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (checkupList.Enabled)
            {
                if (checkupList.SelectedItems.Count == 0) return;
                string message = $"A record about {checkupList.SelectedItems[0].SubItems[1].Text} will all be deleted permanently. Please consider this before clicking yes, We are not responsible of any lose about this record.";
                MessageBoxResult x = System.Windows.MessageBox.Show(message, "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (x == MessageBoxResult.No) return;
                Library.Controller.Services services = new Library.Controller.Services();
                int thisid = Convert.ToInt32(checkupList.SelectedItems[0].SubItems[0].Text);
                services.Delete(thisid);
                LoadCheckupView();
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
