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
using MaterialSkin;
using MaterialSkin.Controls;
using ComponentFactory.Krypton.Toolkit;

namespace VCMS.Forms
{
    public partial class LoginForm : KryptonForm
    {
        MaterialSkinManager SkinThemeManager { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            SkinThemeManager = MaterialSkinManager.Instance;
            SkinThemeManager.Theme = Properties.Settings.Default.GlobalTheme ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            SkinThemeManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.Teal100, Primary.Teal500, Primary.Teal500, Accent.LightBlue700, TextShade.BLACK);
            this.StateCommon.Border.Color1 = Properties.Settings.Default.GlobalBackColor;
        }

        private void MoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Config.MoveForm(Handle);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            //closeButton.IconColor = Color.Red;
        }
        private void OnMouseLeaveButton(object sender, EventArgs e)
        {
            closeButton.IconColor = Properties.Settings.Default.GlobalFontColor;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new MainForm();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }
    }
}
