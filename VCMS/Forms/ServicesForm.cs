using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCMS.Forms.Services.Forms;

namespace VCMS.Forms
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        private void MedicationButton_Click(object sender, EventArgs e)
        {
            Form medicationForm = new MedicationForm();
            medicationForm.ShowDialog();
        }
    }
}
