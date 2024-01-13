using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCMS.Forms.Services;
using MaterialSkin.Controls;

namespace VCMS.Forms
{
    public partial class ServicesForm : MaterialForm
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        private void CheckupButton_Click(object sender, EventArgs e)
        {
            CheckupForm checkupForm = new CheckupForm();
            checkupForm.ShowDialog();
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            serviceForm.ShowDialog();
        }
    }
}
