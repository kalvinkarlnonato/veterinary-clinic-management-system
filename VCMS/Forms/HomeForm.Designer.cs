namespace VCMS.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.bannerPictureBox = new System.Windows.Forms.PictureBox();
            this.servicesPanel = new System.Windows.Forms.Panel();
            this.servicesCountLabel = new System.Windows.Forms.Label();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.servicesPicture = new System.Windows.Forms.PictureBox();
            this.doctorsPanel = new System.Windows.Forms.Panel();
            this.doctorsCountLabel = new System.Windows.Forms.Label();
            this.doctorsLabel = new System.Windows.Forms.Label();
            this.doctorsPicture = new System.Windows.Forms.PictureBox();
            this.costumersPanel = new System.Windows.Forms.Panel();
            this.costumersCountLabel = new System.Windows.Forms.Label();
            this.costumersLabel = new System.Windows.Forms.Label();
            this.costumersPicture = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.darkThemeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.aboutButton = new MaterialSkin.Controls.MaterialButton();
            this.librariesButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).BeginInit();
            this.servicesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesPicture)).BeginInit();
            this.doctorsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsPicture)).BeginInit();
            this.costumersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costumersPicture)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bannerPictureBox
            // 
            this.bannerPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.bannerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("bannerPictureBox.Image")));
            this.bannerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.bannerPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.bannerPictureBox.Name = "bannerPictureBox";
            this.bannerPictureBox.Size = new System.Drawing.Size(943, 231);
            this.bannerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bannerPictureBox.TabIndex = 12;
            this.bannerPictureBox.TabStop = false;
            // 
            // servicesPanel
            // 
            this.servicesPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.servicesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.servicesPanel.Controls.Add(this.servicesCountLabel);
            this.servicesPanel.Controls.Add(this.servicesLabel);
            this.servicesPanel.Controls.Add(this.servicesPicture);
            this.servicesPanel.Location = new System.Drawing.Point(602, 3);
            this.servicesPanel.Name = "servicesPanel";
            this.servicesPanel.Size = new System.Drawing.Size(250, 100);
            this.servicesPanel.TabIndex = 17;
            // 
            // servicesCountLabel
            // 
            this.servicesCountLabel.AutoSize = true;
            this.servicesCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.servicesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesCountLabel.ForeColor = System.Drawing.Color.Purple;
            this.servicesCountLabel.Location = new System.Drawing.Point(78, 40);
            this.servicesCountLabel.Name = "servicesCountLabel";
            this.servicesCountLabel.Size = new System.Drawing.Size(30, 24);
            this.servicesCountLabel.TabIndex = 13;
            this.servicesCountLabel.Text = "00";
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.servicesLabel.Location = new System.Drawing.Point(78, 16);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(53, 24);
            this.servicesLabel.TabIndex = 12;
            this.servicesLabel.Text = "Visits";
            // 
            // servicesPicture
            // 
            this.servicesPicture.Image = ((System.Drawing.Image)(resources.GetObject("servicesPicture.Image")));
            this.servicesPicture.Location = new System.Drawing.Point(12, 16);
            this.servicesPicture.Name = "servicesPicture";
            this.servicesPicture.Size = new System.Drawing.Size(60, 60);
            this.servicesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.servicesPicture.TabIndex = 11;
            this.servicesPicture.TabStop = false;
            // 
            // doctorsPanel
            // 
            this.doctorsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.doctorsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.doctorsPanel.Controls.Add(this.doctorsCountLabel);
            this.doctorsPanel.Controls.Add(this.doctorsLabel);
            this.doctorsPanel.Controls.Add(this.doctorsPicture);
            this.doctorsPanel.Location = new System.Drawing.Point(346, 3);
            this.doctorsPanel.Name = "doctorsPanel";
            this.doctorsPanel.Size = new System.Drawing.Size(250, 100);
            this.doctorsPanel.TabIndex = 16;
            // 
            // doctorsCountLabel
            // 
            this.doctorsCountLabel.AutoSize = true;
            this.doctorsCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.doctorsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsCountLabel.ForeColor = System.Drawing.Color.Purple;
            this.doctorsCountLabel.Location = new System.Drawing.Point(74, 40);
            this.doctorsCountLabel.Name = "doctorsCountLabel";
            this.doctorsCountLabel.Size = new System.Drawing.Size(30, 24);
            this.doctorsCountLabel.TabIndex = 13;
            this.doctorsCountLabel.Text = "01";
            // 
            // doctorsLabel
            // 
            this.doctorsLabel.AutoSize = true;
            this.doctorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.doctorsLabel.Location = new System.Drawing.Point(74, 16);
            this.doctorsLabel.Name = "doctorsLabel";
            this.doctorsLabel.Size = new System.Drawing.Size(65, 24);
            this.doctorsLabel.TabIndex = 12;
            this.doctorsLabel.Text = "Doctor";
            // 
            // doctorsPicture
            // 
            this.doctorsPicture.Image = ((System.Drawing.Image)(resources.GetObject("doctorsPicture.Image")));
            this.doctorsPicture.Location = new System.Drawing.Point(8, 16);
            this.doctorsPicture.Name = "doctorsPicture";
            this.doctorsPicture.Size = new System.Drawing.Size(60, 60);
            this.doctorsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doctorsPicture.TabIndex = 11;
            this.doctorsPicture.TabStop = false;
            // 
            // costumersPanel
            // 
            this.costumersPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.costumersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.costumersPanel.Controls.Add(this.costumersCountLabel);
            this.costumersPanel.Controls.Add(this.costumersLabel);
            this.costumersPanel.Controls.Add(this.costumersPicture);
            this.costumersPanel.Location = new System.Drawing.Point(90, 3);
            this.costumersPanel.Name = "costumersPanel";
            this.costumersPanel.Size = new System.Drawing.Size(250, 100);
            this.costumersPanel.TabIndex = 15;
            // 
            // costumersCountLabel
            // 
            this.costumersCountLabel.AutoSize = true;
            this.costumersCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.costumersCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costumersCountLabel.ForeColor = System.Drawing.Color.Purple;
            this.costumersCountLabel.Location = new System.Drawing.Point(73, 40);
            this.costumersCountLabel.Name = "costumersCountLabel";
            this.costumersCountLabel.Size = new System.Drawing.Size(30, 24);
            this.costumersCountLabel.TabIndex = 13;
            this.costumersCountLabel.Text = "00";
            // 
            // costumersLabel
            // 
            this.costumersLabel.AutoSize = true;
            this.costumersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costumersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.costumersLabel.Location = new System.Drawing.Point(73, 16);
            this.costumersLabel.Name = "costumersLabel";
            this.costumersLabel.Size = new System.Drawing.Size(100, 24);
            this.costumersLabel.TabIndex = 12;
            this.costumersLabel.Text = "Customers";
            // 
            // costumersPicture
            // 
            this.costumersPicture.Image = ((System.Drawing.Image)(resources.GetObject("costumersPicture.Image")));
            this.costumersPicture.Location = new System.Drawing.Point(10, 16);
            this.costumersPicture.Name = "costumersPicture";
            this.costumersPicture.Size = new System.Drawing.Size(60, 60);
            this.costumersPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.costumersPicture.TabIndex = 11;
            this.costumersPicture.TabStop = false;
            // 
            // containerPanel
            // 
            this.containerPanel.ColumnCount = 5;
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerPanel.Controls.Add(this.servicesPanel, 3, 1);
            this.containerPanel.Controls.Add(this.costumersPanel, 1, 1);
            this.containerPanel.Controls.Add(this.doctorsPanel, 2, 1);
            this.containerPanel.Controls.Add(this.label1, 0, 2);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 231);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.RowCount = 3;
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerPanel.Size = new System.Drawing.Size(943, 316);
            this.containerPanel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.SetColumnSpan(this.label1, 5);
            this.label1.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(937, 210);
            this.label1.TabIndex = 18;
            this.label1.Text = "WELCOME!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // darkThemeSwitch
            // 
            this.darkThemeSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkThemeSwitch.AutoSize = true;
            this.darkThemeSwitch.Depth = 0;
            this.darkThemeSwitch.Location = new System.Drawing.Point(799, 64);
            this.darkThemeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.darkThemeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.darkThemeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkThemeSwitch.Name = "darkThemeSwitch";
            this.darkThemeSwitch.Ripple = true;
            this.darkThemeSwitch.Size = new System.Drawing.Size(131, 37);
            this.darkThemeSwitch.TabIndex = 19;
            this.darkThemeSwitch.Text = "Darkmode";
            this.darkThemeSwitch.UseVisualStyleBackColor = true;
            this.darkThemeSwitch.Click += new System.EventHandler(this.DarkThemeSwitch_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.AutoSize = false;
            this.aboutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aboutButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.aboutButton.Depth = 0;
            this.aboutButton.HighEmphasis = true;
            this.aboutButton.Icon = null;
            this.aboutButton.Location = new System.Drawing.Point(799, 15);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aboutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.aboutButton.Size = new System.Drawing.Size(131, 36);
            this.aboutButton.TabIndex = 20;
            this.aboutButton.Text = "About";
            this.aboutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.aboutButton.UseAccentColor = false;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // librariesButton
            // 
            this.librariesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.librariesButton.AutoSize = false;
            this.librariesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.librariesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.librariesButton.Depth = 0;
            this.librariesButton.HighEmphasis = true;
            this.librariesButton.Icon = null;
            this.librariesButton.Location = new System.Drawing.Point(799, 93);
            this.librariesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.librariesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.librariesButton.Name = "librariesButton";
            this.librariesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.librariesButton.Size = new System.Drawing.Size(131, 36);
            this.librariesButton.TabIndex = 21;
            this.librariesButton.Text = "Libraries";
            this.librariesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.librariesButton.UseAccentColor = false;
            this.librariesButton.UseVisualStyleBackColor = true;
            this.librariesButton.Visible = false;
            this.librariesButton.Click += new System.EventHandler(this.LibrariesButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(943, 547);
            this.ControlBox = false;
            this.Controls.Add(this.librariesButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.darkThemeSwitch);
            this.Controls.Add(this.bannerPictureBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "SNIFFS AND LICKS CLINIC";
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).EndInit();
            this.servicesPanel.ResumeLayout(false);
            this.servicesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesPicture)).EndInit();
            this.doctorsPanel.ResumeLayout(false);
            this.doctorsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsPicture)).EndInit();
            this.costumersPanel.ResumeLayout(false);
            this.costumersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costumersPicture)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bannerPictureBox;
        private System.Windows.Forms.Panel servicesPanel;
        private System.Windows.Forms.Label servicesCountLabel;
        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.PictureBox servicesPicture;
        private System.Windows.Forms.Panel doctorsPanel;
        private System.Windows.Forms.Label doctorsCountLabel;
        private System.Windows.Forms.Label doctorsLabel;
        private System.Windows.Forms.PictureBox doctorsPicture;
        private System.Windows.Forms.Panel costumersPanel;
        private System.Windows.Forms.Label costumersCountLabel;
        private System.Windows.Forms.Label costumersLabel;
        private System.Windows.Forms.PictureBox costumersPicture;
        private System.Windows.Forms.TableLayoutPanel containerPanel;
        private MaterialSkin.Controls.MaterialSwitch darkThemeSwitch;
        private MaterialSkin.Controls.MaterialButton aboutButton;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton librariesButton;
    }
}