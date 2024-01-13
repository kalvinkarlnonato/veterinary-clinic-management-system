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
using VCMS.Forms.Doctors;
using VCMS.Library.Models;

namespace VCMS.Forms
{
    public partial class DoctorsForm : MaterialForm
    {
        private List<DoctorModel> Doctors { get; set; }
        public DoctorsForm()
        {
            InitializeComponent();
            doctorsList.Columns.Add("ID", 80);
            doctorsList.Columns.Add("Name", 350);
            doctorsList.Columns.Add("Gender", 150);
            doctorsList.Columns.Add("Phone No.", 200);
            doctorsList.Columns.Add("Age", 200);
            doctorsList.Columns.Add("Birthday", 200);
            doctorsList.Columns.Add("Address", 400);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchTextbox.Visible = !searchTextbox.Visible;
            searchTextbox.Focus();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ManageForm form = new ManageForm();
            form.ShowDialog();
            LoadDoctorView();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (doctorsList.SelectedItems.Count == 0) { return; }
            int id = int.Parse(doctorsList.SelectedItems[0].Text);
            DoctorModel doctor = Doctors.Where(d => d.ID == id).First();
            ManageForm form = new ManageForm() { Doctor = doctor };
            form.ShowDialog();
            LoadDoctorView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (doctorsList.SelectedItems.Count == 0) return;
            string message = $"A record about {doctorsList.SelectedItems[0].SubItems[1].Text} will all be deleted permanently. Please consider this before clicking yes, We are not responsible of any lose about this record.";
            MessageBoxResult x = System.Windows.MessageBox.Show(message, "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (x == MessageBoxResult.No) return;
            Library.Controller.Doctors doctors = new Library.Controller.Doctors();
            int thisid = Convert.ToInt32(doctorsList.SelectedItems[0].SubItems[0].Text);
            doctors.Delete(thisid);
            LoadDoctorView();
        }

        private void LoadDoctorView()
        {
            doctorsList.Items.Clear();
            Library.Controller.Doctors doctors = new Library.Controller.Doctors();
            Doctors = doctors.AllDoctors();
            foreach (var doctor in Doctors)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = doctor.ID.ToString();
                item.SubItems.Add(doctor.FullName.ToString());
                item.SubItems.Add(doctor.Sex.ToString());
                item.SubItems.Add(doctor.Cellphone.ToString());
                item.SubItems.Add(doctor.Age.ToString());
                item.SubItems.Add(doctor.Birthday.ToString("MMM dd,yyyy"));
                item.SubItems.Add(doctor.Address.ToString());
                doctorsList.Items.Add(item);
            }
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            LoadDoctorView();
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                doctorsList.Items.Clear();
                Library.Controller.Doctors doctors = new Library.Controller.Doctors();
                Doctors = doctors.Find(searchTextbox.Text);
                foreach (var doctor in Doctors)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems[0].Text = doctor.ID.ToString();
                    item.SubItems.Add(doctor.FullName.ToString());
                    item.SubItems.Add(doctor.Sex.ToString());
                    item.SubItems.Add(doctor.Cellphone.ToString());
                    item.SubItems.Add(doctor.Age.ToString());
                    item.SubItems.Add(doctor.Birthday.ToString("MMM dd,yyyy"));
                    item.SubItems.Add(doctor.Address.ToString());
                    doctorsList.Items.Add(item);
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                searchTextbox.Text = String.Empty;
                searchTextbox.Visible = false;
            }
        }
    }
}
