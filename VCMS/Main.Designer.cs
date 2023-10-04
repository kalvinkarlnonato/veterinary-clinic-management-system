namespace VCMS
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.burgerButton = new FontAwesome.Sharp.IconButton();
            this.logoLabel = new System.Windows.Forms.Label();
            this.logoutButton = new FontAwesome.Sharp.IconButton();
            this.receptionistButton = new FontAwesome.Sharp.IconButton();
            this.servicesButton = new FontAwesome.Sharp.IconButton();
            this.doctorsButton = new FontAwesome.Sharp.IconButton();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.costumersButton = new FontAwesome.Sharp.IconButton();
            this.formPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.sizeButon = new FontAwesome.Sharp.IconButton();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.PowderBlue;
            this.sidePanel.Controls.Add(this.burgerButton);
            this.sidePanel.Controls.Add(this.logoLabel);
            this.sidePanel.Controls.Add(this.logoutButton);
            this.sidePanel.Controls.Add(this.receptionistButton);
            this.sidePanel.Controls.Add(this.servicesButton);
            this.sidePanel.Controls.Add(this.doctorsButton);
            this.sidePanel.Controls.Add(this.logoPicture);
            this.sidePanel.Controls.Add(this.costumersButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(150, 455);
            this.sidePanel.TabIndex = 1;
            // 
            // burgerButton
            // 
            this.burgerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.burgerButton.FlatAppearance.BorderSize = 0;
            this.burgerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.burgerButton.IconChar = FontAwesome.Sharp.IconChar.EllipsisVertical;
            this.burgerButton.IconColor = System.Drawing.Color.Black;
            this.burgerButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.burgerButton.IconSize = 25;
            this.burgerButton.Location = new System.Drawing.Point(110, 0);
            this.burgerButton.Name = "burgerButton";
            this.burgerButton.Size = new System.Drawing.Size(40, 27);
            this.burgerButton.TabIndex = 19;
            this.burgerButton.UseVisualStyleBackColor = true;
            this.burgerButton.Click += new System.EventHandler(this.BurgerButton_Click);
            this.burgerButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            // 
            // logoLabel
            // 
            this.logoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(0, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(113, 26);
            this.logoLabel.TabIndex = 15;
            this.logoLabel.Text = "VCMS";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoLabel.DoubleClick += new System.EventHandler(this.BurgerButton_Click);
            this.logoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logoutButton.IconColor = System.Drawing.Color.Red;
            this.logoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutButton.IconSize = 30;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(0, 411);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(150, 44);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Tag = "Logout";
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // receptionistButton
            // 
            this.receptionistButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receptionistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receptionistButton.FlatAppearance.BorderSize = 0;
            this.receptionistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.receptionistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.receptionistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receptionistButton.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.receptionistButton.IconColor = System.Drawing.Color.Magenta;
            this.receptionistButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.receptionistButton.IconSize = 30;
            this.receptionistButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.receptionistButton.Location = new System.Drawing.Point(0, 263);
            this.receptionistButton.Name = "receptionistButton";
            this.receptionistButton.Size = new System.Drawing.Size(150, 44);
            this.receptionistButton.TabIndex = 6;
            this.receptionistButton.Tag = "Receptionist";
            this.receptionistButton.Text = "Receptionist";
            this.receptionistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.receptionistButton.UseVisualStyleBackColor = true;
            this.receptionistButton.Click += new System.EventHandler(this.ReceptionistButton_Click);
            // 
            // servicesButton
            // 
            this.servicesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servicesButton.FlatAppearance.BorderSize = 0;
            this.servicesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.servicesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.servicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesButton.IconChar = FontAwesome.Sharp.IconChar.ShieldDog;
            this.servicesButton.IconColor = System.Drawing.Color.Green;
            this.servicesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.servicesButton.IconSize = 30;
            this.servicesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicesButton.Location = new System.Drawing.Point(0, 216);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(150, 44);
            this.servicesButton.TabIndex = 5;
            this.servicesButton.Tag = "Services";
            this.servicesButton.Text = "Services";
            this.servicesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.servicesButton.UseVisualStyleBackColor = true;
            this.servicesButton.Click += new System.EventHandler(this.ServicesButton_Click);
            // 
            // doctorsButton
            // 
            this.doctorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doctorsButton.FlatAppearance.BorderSize = 0;
            this.doctorsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.doctorsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.doctorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorsButton.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.doctorsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.doctorsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.doctorsButton.IconSize = 30;
            this.doctorsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorsButton.Location = new System.Drawing.Point(0, 169);
            this.doctorsButton.Name = "doctorsButton";
            this.doctorsButton.Size = new System.Drawing.Size(150, 44);
            this.doctorsButton.TabIndex = 4;
            this.doctorsButton.Tag = "Doctors";
            this.doctorsButton.Text = "Doctors";
            this.doctorsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.doctorsButton.UseVisualStyleBackColor = true;
            // 
            // logoPicture
            // 
            this.logoPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(0, 26);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(150, 39);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 3;
            this.logoPicture.TabStop = false;
            this.logoPicture.Click += new System.EventHandler(this.LogoPicture_Click);
            this.logoPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            // 
            // costumersButton
            // 
            this.costumersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costumersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.costumersButton.FlatAppearance.BorderSize = 0;
            this.costumersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.costumersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.costumersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costumersButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.costumersButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.costumersButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.costumersButton.IconSize = 30;
            this.costumersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.costumersButton.Location = new System.Drawing.Point(0, 122);
            this.costumersButton.Name = "costumersButton";
            this.costumersButton.Size = new System.Drawing.Size(150, 44);
            this.costumersButton.TabIndex = 2;
            this.costumersButton.Tag = "Costumers";
            this.costumersButton.Text = "Costumers";
            this.costumersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.costumersButton.UseVisualStyleBackColor = true;
            this.costumersButton.Click += new System.EventHandler(this.CostumersButton_Click);
            // 
            // formPanel
            // 
            this.formPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formPanel.Location = new System.Drawing.Point(150, 64);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(742, 376);
            this.formPanel.TabIndex = 19;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.Black;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 30;
            this.minimizeButton.Location = new System.Drawing.Point(67, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 24);
            this.minimizeButton.TabIndex = 18;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.minimizeButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            // 
            // sizeButon
            // 
            this.sizeButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeButon.FlatAppearance.BorderSize = 0;
            this.sizeButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeButon.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.sizeButon.IconColor = System.Drawing.Color.Black;
            this.sizeButon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sizeButon.IconSize = 30;
            this.sizeButon.Location = new System.Drawing.Point(95, 3);
            this.sizeButon.Name = "sizeButon";
            this.sizeButon.Size = new System.Drawing.Size(24, 24);
            this.sizeButon.TabIndex = 17;
            this.sizeButon.UseVisualStyleBackColor = true;
            this.sizeButon.Click += new System.EventHandler(this.SizeButon_Click);
            this.sizeButon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.closeButton.IconColor = System.Drawing.Color.Black;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 30;
            this.closeButton.Location = new System.Drawing.Point(123, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 16;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(150, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(591, 65);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "SNIFFS AND LICKS CLINIC";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.DoubleClick += new System.EventHandler(this.SizeButon_Click);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.Controls.Add(this.closeButton);
            this.buttonsPanel.Controls.Add(this.sizeButon);
            this.buttonsPanel.Controls.Add(this.minimizeButton);
            this.buttonsPanel.Location = new System.Drawing.Point(742, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(150, 65);
            this.buttonsPanel.TabIndex = 0;
            this.buttonsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(892, 455);
            this.ControlBox = false;
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.titleLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 70);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidePanel;
        private FontAwesome.Sharp.IconButton costumersButton;
        private System.Windows.Forms.PictureBox logoPicture;
        private FontAwesome.Sharp.IconButton logoutButton;
        private FontAwesome.Sharp.IconButton receptionistButton;
        private FontAwesome.Sharp.IconButton servicesButton;
        private FontAwesome.Sharp.IconButton doctorsButton;
        private System.Windows.Forms.Label logoLabel;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private FontAwesome.Sharp.IconButton sizeButon;
        private FontAwesome.Sharp.IconButton closeButton;
        private System.Windows.Forms.Label titleLabel;
        private FontAwesome.Sharp.IconButton burgerButton;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Panel buttonsPanel;
    }
}

