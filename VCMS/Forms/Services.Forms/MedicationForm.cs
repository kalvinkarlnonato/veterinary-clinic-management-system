using ComponentFactory.Krypton.Toolkit;
using MaterialSkin;
using MaterialSkin.Controls;
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

namespace VCMS.Forms.Services.Forms
{
    public partial class MedicationForm : MaterialForm
    {
        MaterialSkinManager skinManager { get; set; }
        public MedicationForm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.Blue400, Primary.Blue900, Primary.Blue900, Accent.Blue400, TextShade.BLACK);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
