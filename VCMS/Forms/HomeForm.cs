using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using VCMS.Forms.Libraries;
using VCMS.Library;

namespace VCMS.Forms
{
    public partial class HomeForm : MaterialForm
    {
        MaterialSkinManager SkinThemeManager { get; set; }

        public HomeForm()
        {
            InitializeComponent();
            SkinThemeManager = MaterialSkinManager.Instance;
            darkThemeSwitch.Checked = Properties.Settings.Default.GlobalTheme;
            label1.Text += "\n"+Config.CurrentUser.Name;
        }

        private void DarkThemeSwitch_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.GlobalTheme)
            {
                SkinThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
                Properties.Settings.Default.GlobalControlBack = Color.FromArgb(230, 230, 230);
                Properties.Settings.Default.GlobalBackColor = Color.FromArgb(240, 240, 240);
                Properties.Settings.Default.GlobalFontColor = Color.FromArgb(64, 64, 64);
                Properties.Settings.Default.GlobalTheme = false;
            }
            else
            {
                SkinThemeManager.Theme = MaterialSkinManager.Themes.DARK;
                Properties.Settings.Default.GlobalControlBack = Color.FromArgb(58, 58, 58);
                Properties.Settings.Default.GlobalBackColor = Color.FromArgb(50, 50, 50);
                Properties.Settings.Default.GlobalFontColor = Color.White;
                Properties.Settings.Default.GlobalTheme = true;
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void LibrariesButton_Click(object sender, EventArgs e)
        {
            LibrariesForm form = new LibrariesForm();
            form.ShowDialog();
        }
    }
}
