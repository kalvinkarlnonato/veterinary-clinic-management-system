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

            Doctors = new List<DoctorModel>() {
                new DoctorModel() { ID = 0, FirstName = "Juan", LastName="  Dela Cruz", Sex = "Male", Address="Tuguegarao City", Cellphone = "0998-765-4321", Birthday = DateTime.Parse("1/9/1997") },
                new DoctorModel() { ID = 1, FirstName = "Nathaniel", LastName="  Dela Cruz", Sex = "Male", Address = "Tuguegarao City", Cellphone = "0998-765-4321", Birthday = DateTime.Parse("2/9/1998") },
                new DoctorModel() { ID = 2, FirstName = "Jacob", LastName="  Dela Cruz", Sex = "Male", Address = "Tuguegarao City", Cellphone = "0998-765-4321", Birthday = DateTime.Parse("3/9/1999") },
                new DoctorModel() { ID = 3, FirstName = "Gabriel", LastName="  Dela Cruz", Sex = "Male", Address = "Tuguegarao City", Cellphone = "0998-765-4321", Birthday = DateTime.Parse("4/9/2000") },
                new DoctorModel() { ID = 4, FirstName = "Joshua", LastName="  Dela Cruz", Sex = "Male", Address = "Tuguegarao City", Cellphone = "0998-765-4321", Birthday = DateTime.Parse("5/9/2005") },
                new DoctorModel() { ID = 5, FirstName = "Angelo", LastName="  Dela Cruz", Sex = "Male", Address = "Tuguegarao City", Cellphone = "0998-765-4321", Birthday = DateTime.Parse("6/9/2015") }
            };

            doctorsList.Columns.Add("ID", 80);
            doctorsList.Columns.Add("Name", 350);
            doctorsList.Columns.Add("Gender", 150);
            doctorsList.Columns.Add("Phone No.", 200);
            doctorsList.Columns.Add("Age", 200);
            doctorsList.Columns.Add("Birthday", 200);
            doctorsList.Columns.Add("Address", 400);

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchTextbox.Visible = !searchTextbox.Visible;
            searchTextbox.Focus();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ManageForm form = new ManageForm();
            form.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (doctorsList.SelectedItems.Count == 0) { return; }
            int id = int.Parse(doctorsList.SelectedItems[0].Text);
            DoctorModel doctor = Doctors.Where(d => d.ID == id).First();
            ManageForm form = new ManageForm() { Doctor = doctor };
            form.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (doctorsList.SelectedItems.Count == 0) { return; }
            string message = $"A record about {doctorsList.SelectedItems[0].SubItems[1].Text} will all be deleted permanently. Please consider this before clicking yes, We are not responsible of any lose about this record.";
            System.Windows.MessageBox.Show(message, "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
        }
    }
}
