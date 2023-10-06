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

namespace VCMS.Forms
{
    public partial class LoginForm : KryptonForm
    {
        MaterialSkinManager skinManager { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.Blue400, TextShade.BLACK);
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
            closeButton.IconColor = Color.Red;
        }
        private void OnMouseLeaveButton(object sender, EventArgs e)
        {
            closeButton.IconColor = Color.Black;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new MainForm();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }
    }
}
