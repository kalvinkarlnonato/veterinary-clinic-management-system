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

namespace VCMS.Forms.Services
{
    public partial class CheckupForm : MaterialForm
    {
        public CheckupForm()
        {
            InitializeComponent();
            nextVisitDatetime.StateCommon.Content.Color1 = Properties.Settings.Default.GlobalFontColor;
            nextVisitDatetime.StateCommon.Back.Color1 = Properties.Settings.Default.GlobalControlBack;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
