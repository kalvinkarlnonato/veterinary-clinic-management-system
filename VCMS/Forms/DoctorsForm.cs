using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCMS.Forms
{
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();

            var doctors = new[] {
                new { id = 0, name = "Juan  Dela Cruz", sex = "Male", address="Tuguegarao City", phone = "09987654321", birthday = DateTime.Now },
                new { id = 1, name = "Nathaniel  Dela Cruz", sex = "Male", address = "Tuguegarao City", phone = "09987654321", birthday = DateTime.Now },
                new { id = 2, name = "Jacob  Dela Cruz", sex = "Male", address = "Tuguegarao City", phone = "09987654321", birthday = DateTime.Now },
                new { id = 3, name = "Gabriel  Dela Cruz", sex = "Male", address = "Tuguegarao City", phone = "09987654321", birthday = DateTime.Now },
                new { id = 4, name = "Joshua  Dela Cruz", sex = "Male", address = "Tuguegarao City", phone = "09987654321", birthday = DateTime.Now },
                new { id = 5, name = "Angelo  Dela Cruz", sex = "Male", address = "Tuguegarao City", phone = "09987654321", birthday = DateTime.Now }
            };

            doctorsList.Columns.Add("ID", 80);
            doctorsList.Columns.Add("Name", 350);
            doctorsList.Columns.Add("Gender", 250);
            doctorsList.Columns.Add("Phone No.", 200);
            doctorsList.Columns.Add("Address", 400);
            doctorsList.Columns.Add("Birthday", 200);

            foreach (var doctor in doctors)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = doctor.id.ToString();
                item.SubItems.Add(doctor.name.ToString());
                item.SubItems.Add(doctor.sex.ToString());
                item.SubItems.Add(doctor.phone.ToString());
                item.SubItems.Add(doctor.address.ToString());
                item.SubItems.Add(doctor.birthday.ToString());
                doctorsList.Items.Add(item);
            }
        }
    }
}
