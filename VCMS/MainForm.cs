﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCMS.Library;
using VCMS.Forms;

namespace VCMS
{
    public partial class MainForm : Form
    {

        #region Others
        //Fields
        private const int cGrip = 16;
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
        private void ToogleMenu(bool isShow)
        {
            if (isShow)
            {
                costumersButton.Text = costumersButton.Tag.ToString();
                doctorsButton.Text = doctorsButton.Tag.ToString();
                servicesButton.Text = servicesButton.Tag.ToString();
                receptionistButton.Text = receptionistButton.Tag.ToString();
                logoutButton.Text = logoutButton.Tag.ToString();
                reservationsButton.Text = reservationsButton.Tag.ToString();
                reportsButton.Text = reportsButton.Tag.ToString();
                burgerButton.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
                sidePanel.Width = sizePanelSize;
                logoLabel.Visible = true;
            }
            else
            {
                costumersButton.Text = String.Empty;
                doctorsButton.Text = String.Empty;
                servicesButton.Text = String.Empty;
                receptionistButton.Text = String.Empty;
                logoutButton.Text = String.Empty;
                reservationsButton.Text = String.Empty;
                reportsButton.Text = String.Empty;
                burgerButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
                sidePanel.Width = burgerButton.Width;
                logoLabel.Visible = false;
            }
            titleLabel.Left = sidePanel.Width;
            titleLabel.Width = this.Width - (sidePanel.Width);
            formPanel.Left = sidePanel.Width;
            formPanel.Width = this.Width - sidePanel.Width;
        }
        private void BurgerButton_Click(object sender, EventArgs e)
        {
            ToogleMenu(!logoLabel.Visible);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        //Windows form saving status
        private void LoadSizeResolution()
        {
            if (Properties.Settings.Default.GlobalWindowSize.Width == 0) Properties.Settings.Default.Upgrade();
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = Properties.Settings.Default.GlobalWindowState;
            this.Location = Properties.Settings.Default.GlobalWindowLocation;
            this.Size = Properties.Settings.Default.GlobalWindowSize;
            ToogleMenu(Properties.Settings.Default.GlobalMenuBar);

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
            Properties.Settings.Default.GlobalMenuBar = logoLabel.Visible;
            Properties.Settings.Default.Save();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSizeRosolution();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            formPanel.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.BackColor = Color.White;
            childForm.Show();
            titleLabel.Text = childForm.Text;
        }
        #endregion
        private Form currentChildForm;
        public MainForm()
        {
            InitializeComponent();
            LoadSizeResolution();
            OpenChildForm(new HomeForm());
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void LogoPicture_Click(object sender, EventArgs e)
        {
            // TODO: Open home form here
            OpenChildForm(new HomeForm());
        }
        private void CostumersButton_Click(object sender, EventArgs e)
        {
            // TODO: Open costumer form here
            OpenChildForm(new CostumersForm());
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