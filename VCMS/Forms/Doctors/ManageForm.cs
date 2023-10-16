using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCMS.Library.Models;
using VCMS.Library;
using System.Windows.Media;

namespace VCMS.Forms.Doctors
{
    public partial class ManageForm : MaterialForm
    {
        public DoctorModel Doctor { get; set; }
        public ManageForm()
        {
            InitializeComponent();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            sexCombobox.SelectedIndex = -1;
            birthdayDatepicker.StateCommon.Content.Color1 = Properties.Settings.Default.GlobalFontColor;
            birthdayDatepicker.StateCommon.Back.Color1 = Properties.Settings.Default.GlobalControlBack;
            if (Doctor != null)
            {
                this.Text = "Edit";
                firstNameTextbox.Text = Doctor.FirstName;
                lastNameTextbox.Text = Doctor.LastName;
                contactTextbox.Text = Doctor.Cellphone;
                addressTextbox.Text = Doctor.Address;
                birthdayDatepicker.Value = Doctor.Birthday;
                sexCombobox.SelectedIndex = sexCombobox.Items.IndexOf(Doctor.Sex);
                return;
            }
            this.Text = "Add";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
