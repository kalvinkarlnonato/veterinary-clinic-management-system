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
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace VCMS
{
    public partial class Main : Form
    {

        #region FormUI
        //Fields
        private readonly int sizePanelSize = 150;
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void SizeButon_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                sizeButon.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                sizeButon.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Config.MoveForm(Handle);
            }
        }
        private void BurgerButton_Click(object sender, EventArgs e)
        {
            if (logoLabel.Visible)
            {
                costumersButton.Text = String.Empty;
                doctorsButton.Text = String.Empty;
                servicesButton.Text = String.Empty;
                receptionistButton.Text = String.Empty;
                logoutButton.Text = String.Empty;
                burgerButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
                sidePanel.Width = burgerButton.Width;
                logoLabel.Visible = false;
            }
            else
            {
                costumersButton.Text = costumersButton.Tag.ToString();
                doctorsButton.Text = doctorsButton.Tag.ToString();
                servicesButton.Text = servicesButton.Tag.ToString();
                receptionistButton.Text = receptionistButton.Tag.ToString();
                logoutButton.Text = logoutButton.Tag.ToString();
                burgerButton.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
                sidePanel.Width = sizePanelSize;
                logoLabel.Visible = true;
            }
        }
        //Windows form saving status
        private void LoadSizeResolution()
        {
            if (Properties.Settings.Default.GlobalWindowSize.Width == 0) Properties.Settings.Default.Upgrade();
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = Properties.Settings.Default.GlobalWindowState;
            this.Location = Properties.Settings.Default.GlobalWindowLocation;
            this.Size = Properties.Settings.Default.GlobalWindowSize;
        }
        private void SaveSizeRosolution()
        {
            Properties.Settings.Default.GlobalWindowState = this.WindowState == FormWindowState.Minimized? FormWindowState.Normal : this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.GlobalWindowLocation = this.Location;
                Properties.Settings.Default.GlobalWindowSize = this.Size;
            }
            else
            {
                Properties.Settings.Default.GlobalWindowLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.GlobalWindowSize = this.RestoreBounds.Size;
            }
            Properties.Settings.Default.Save();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSizeRosolution();
        }
        #endregion
        public Main()
        {
            InitializeComponent();
            LoadSizeResolution();
        }
        
        private void LogoPicture_Click(object sender, EventArgs e)
        {
            // TODO: Open home form here
        }
        private void CostumersButton_Click(object sender, EventArgs e)
        {
            // TODO: Open costumer form here
        }
        private void ServicesButton_Click(object sender, EventArgs e)
        {

            // TODO: Open services form here
        }
        private void ReceptionistButton_Click(object sender, EventArgs e)
        {
            // TODO: Open receptionist form here
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // TODO: Logout a form in here
        }


    }
}
