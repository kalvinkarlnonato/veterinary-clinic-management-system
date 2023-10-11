namespace VCMS.Forms
{
    partial class ServicesForm
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.medicationButton = new FontAwesome.Sharp.IconButton();
            this.containerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.checkupButton = new FontAwesome.Sharp.IconButton();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicationButton
            // 
            this.medicationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.medicationButton.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.medicationButton.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.medicationButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.medicationButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.medicationButton.Location = new System.Drawing.Point(21, 3);
            this.medicationButton.Name = "medicationButton";
            this.medicationButton.Size = new System.Drawing.Size(211, 549);
            this.medicationButton.TabIndex = 0;
            this.medicationButton.Text = "Medication";
            this.medicationButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.medicationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.medicationButton.UseVisualStyleBackColor = true;
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.containerPanel.ColumnCount = 2;
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerPanel.Controls.Add(this.medicationButton, 0, 0);
            this.containerPanel.Controls.Add(this.checkupButton, 1, 0);
            this.containerPanel.Location = new System.Drawing.Point(270, 12);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.RowCount = 1;
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerPanel.Size = new System.Drawing.Size(508, 555);
            this.containerPanel.TabIndex = 1;
            // 
            // checkupButton
            // 
            this.checkupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkupButton.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkupButton.IconChar = FontAwesome.Sharp.IconChar.Stethoscope;
            this.checkupButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkupButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.checkupButton.Location = new System.Drawing.Point(275, 3);
            this.checkupButton.Name = "checkupButton";
            this.checkupButton.Size = new System.Drawing.Size(211, 549);
            this.checkupButton.TabIndex = 0;
            this.checkupButton.Text = "Checkup";
            this.checkupButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkupButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkupButton.UseVisualStyleBackColor = true;
            this.checkupButton.Click += new System.EventHandler(this.CheckupButton_Click);
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(1048, 579);
            this.ControlBox = false;
            this.Controls.Add(this.containerPanel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServicesForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "Services";
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private FontAwesome.Sharp.IconButton medicationButton;
        private System.Windows.Forms.TableLayoutPanel containerPanel;
        private FontAwesome.Sharp.IconButton checkupButton;
    }
}