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
            this.animalsPanel = new System.Windows.Forms.Panel();
            this.animalsCountLabel = new System.Windows.Forms.Label();
            this.animalsLabel = new System.Windows.Forms.Label();
            this.animalsPicture = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).BeginInit();
            this.animalsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsPicture)).BeginInit();
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
            // animalsPanel
            // 
            this.animalsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.animalsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.animalsPanel.Controls.Add(this.animalsCountLabel);
            this.animalsPanel.Controls.Add(this.animalsLabel);
            this.animalsPanel.Controls.Add(this.animalsPicture);
            this.animalsPanel.Location = new System.Drawing.Point(346, 3);
            this.animalsPanel.Name = "animalsPanel";
            this.animalsPanel.Size = new System.Drawing.Size(250, 100);
            this.animalsPanel.TabIndex = 14;
            // 
            // animalsCountLabel
            // 
            this.animalsCountLabel.AutoSize = true;
            this.animalsCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.animalsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalsCountLabel.ForeColor = System.Drawing.Color.Purple;
            this.animalsCountLabel.Location = new System.Drawing.Point(75, 42);
            this.animalsCountLabel.Name = "animalsCountLabel";
            this.animalsCountLabel.Size = new System.Drawing.Size(30, 24);
            this.animalsCountLabel.TabIndex = 13;
            this.animalsCountLabel.Text = "##";
            // 
            // animalsLabel
            // 
            this.animalsLabel.AutoSize = true;
            this.animalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.animalsLabel.Location = new System.Drawing.Point(74, 18);
            this.animalsLabel.Name = "animalsLabel";
            this.animalsLabel.Size = new System.Drawing.Size(119, 24);
            this.animalsLabel.TabIndex = 12;
            this.animalsLabel.Text = "Parvo Patient";
            // 
            // animalsPicture
            // 
            this.animalsPicture.Image = ((System.Drawing.Image)(resources.GetObject("animalsPicture.Image")));
            this.animalsPicture.Location = new System.Drawing.Point(8, 18);
            this.animalsPicture.Name = "animalsPicture";
            this.animalsPicture.Size = new System.Drawing.Size(60, 60);
            this.animalsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.animalsPicture.TabIndex = 11;
            this.animalsPicture.TabStop = false;
            // 
            // servicesPanel
            // 
            this.servicesPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.servicesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.servicesPanel.Controls.Add(this.servicesCountLabel);
            this.servicesPanel.Controls.Add(this.servicesLabel);
            this.servicesPanel.Controls.Add(this.servicesPicture);
            this.servicesPanel.Location = new System.Drawing.Point(602, 109);
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
            this.servicesCountLabel.Text = "##";
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.servicesLabel.Location = new System.Drawing.Point(78, 16);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(82, 24);
            this.servicesLabel.TabIndex = 12;
            this.servicesLabel.Text = "Services";
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
            this.doctorsPanel.Location = new System.Drawing.Point(346, 109);
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
            this.doctorsCountLabel.Text = "##";
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
            this.costumersPanel.Location = new System.Drawing.Point(90, 109);
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
            this.costumersCountLabel.Text = "##";
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
            this.containerPanel.Controls.Add(this.animalsPanel, 2, 0);
            this.containerPanel.Controls.Add(this.servicesPanel, 3, 1);
            this.containerPanel.Controls.Add(this.costumersPanel, 1, 1);
            this.containerPanel.Controls.Add(this.doctorsPanel, 2, 1);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 231);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.RowCount = 3;
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerPanel.Size = new System.Drawing.Size(943, 316);
            this.containerPanel.TabIndex = 18;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(943, 547);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.bannerPictureBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "SNIFFS AND LICKS CLINIC";
            ((System.ComponentModel.ISupportInitialize)(this.bannerPictureBox)).EndInit();
            this.animalsPanel.ResumeLayout(false);
            this.animalsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsPicture)).EndInit();
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

        }

        #endregion

        private System.Windows.Forms.PictureBox bannerPictureBox;
        private System.Windows.Forms.Panel animalsPanel;
        private System.Windows.Forms.Label animalsCountLabel;
        private System.Windows.Forms.Label animalsLabel;
        private System.Windows.Forms.PictureBox animalsPicture;
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
    }
}