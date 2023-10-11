namespace VCMS.Forms.Services
{
    partial class MedicationForm
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
            this.customerCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.petCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.costumerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.petLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nextVisitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.weightLabel = new MaterialSkin.Controls.MaterialLabel();
            this.weightTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.temperatureTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.complaintDiagnosisTextbox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.temperatureLabel = new MaterialSkin.Controls.MaterialLabel();
            this.treatmentTextbox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.notesTextbox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.complaintDiagnosisLabel = new MaterialSkin.Controls.MaterialLabel();
            this.treatmentLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.containerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.notesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nextVisitDatetime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.submitButton = new MaterialSkin.Controls.MaterialButton();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerCombobox
            // 
            this.customerCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerCombobox.AutoResize = false;
            this.customerCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customerCombobox.Depth = 0;
            this.customerCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.customerCombobox.DropDownHeight = 174;
            this.customerCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerCombobox.DropDownWidth = 121;
            this.customerCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.customerCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customerCombobox.FormattingEnabled = true;
            this.customerCombobox.Hint = "[Choose customer]";
            this.customerCombobox.IntegralHeight = false;
            this.customerCombobox.ItemHeight = 43;
            this.customerCombobox.Location = new System.Drawing.Point(3, 23);
            this.customerCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerCombobox.MaxDropDownItems = 4;
            this.customerCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.customerCombobox.Name = "customerCombobox";
            this.customerCombobox.Size = new System.Drawing.Size(373, 49);
            this.customerCombobox.StartIndex = 0;
            this.customerCombobox.TabIndex = 0;
            // 
            // petCombobox
            // 
            this.petCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petCombobox.AutoResize = false;
            this.petCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.petCombobox.Depth = 0;
            this.petCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.petCombobox.DropDownHeight = 174;
            this.petCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.petCombobox.DropDownWidth = 121;
            this.petCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.petCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.petCombobox.FormattingEnabled = true;
            this.petCombobox.Hint = "[Choose customer\'s pet]";
            this.petCombobox.IntegralHeight = false;
            this.petCombobox.ItemHeight = 43;
            this.petCombobox.Location = new System.Drawing.Point(382, 23);
            this.petCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.petCombobox.MaxDropDownItems = 4;
            this.petCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.petCombobox.Name = "petCombobox";
            this.petCombobox.Size = new System.Drawing.Size(374, 49);
            this.petCombobox.StartIndex = 0;
            this.petCombobox.TabIndex = 0;
            // 
            // costumerLabel
            // 
            this.costumerLabel.AutoSize = true;
            this.costumerLabel.Depth = 0;
            this.costumerLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.costumerLabel.Location = new System.Drawing.Point(3, 0);
            this.costumerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.costumerLabel.Name = "costumerLabel";
            this.costumerLabel.Size = new System.Drawing.Size(69, 19);
            this.costumerLabel.TabIndex = 2;
            this.costumerLabel.Text = "Customer";
            // 
            // petLabel
            // 
            this.petLabel.AutoSize = true;
            this.petLabel.Depth = 0;
            this.petLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.petLabel.Location = new System.Drawing.Point(382, 0);
            this.petLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.petLabel.Name = "petLabel";
            this.petLabel.Size = new System.Drawing.Size(24, 19);
            this.petLabel.TabIndex = 2;
            this.petLabel.Text = "Pet";
            // 
            // nextVisitLabel
            // 
            this.nextVisitLabel.AutoSize = true;
            this.nextVisitLabel.Depth = 0;
            this.nextVisitLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nextVisitLabel.Location = new System.Drawing.Point(762, 0);
            this.nextVisitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextVisitLabel.Name = "nextVisitLabel";
            this.nextVisitLabel.Size = new System.Drawing.Size(68, 19);
            this.nextVisitLabel.TabIndex = 2;
            this.nextVisitLabel.Text = "Next Visit";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Depth = 0;
            this.weightLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.weightLabel.Location = new System.Drawing.Point(3, 76);
            this.weightLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(50, 19);
            this.weightLabel.TabIndex = 2;
            this.weightLabel.Text = "Weight";
            // 
            // weightTextbox
            // 
            this.weightTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightTextbox.AnimateReadOnly = false;
            this.weightTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weightTextbox.Depth = 0;
            this.weightTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.weightTextbox.Hint = "kg";
            this.weightTextbox.LeadingIcon = null;
            this.weightTextbox.Location = new System.Drawing.Point(3, 99);
            this.weightTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.weightTextbox.MaxLength = 50;
            this.weightTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.weightTextbox.Multiline = false;
            this.weightTextbox.Name = "weightTextbox";
            this.weightTextbox.Size = new System.Drawing.Size(373, 50);
            this.weightTextbox.TabIndex = 3;
            this.weightTextbox.Text = "";
            this.weightTextbox.TrailingIcon = null;
            // 
            // temperatureTextbox
            // 
            this.temperatureTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temperatureTextbox.AnimateReadOnly = false;
            this.temperatureTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temperatureTextbox.Depth = 0;
            this.temperatureTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.temperatureTextbox.Hint = "°Celsius ";
            this.temperatureTextbox.LeadingIcon = null;
            this.temperatureTextbox.Location = new System.Drawing.Point(382, 99);
            this.temperatureTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.temperatureTextbox.MaxLength = 50;
            this.temperatureTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.temperatureTextbox.Multiline = false;
            this.temperatureTextbox.Name = "temperatureTextbox";
            this.temperatureTextbox.Size = new System.Drawing.Size(374, 50);
            this.temperatureTextbox.TabIndex = 3;
            this.temperatureTextbox.Text = "";
            this.temperatureTextbox.TrailingIcon = null;
            // 
            // complaintDiagnosisTextbox
            // 
            this.complaintDiagnosisTextbox.AnimateReadOnly = false;
            this.complaintDiagnosisTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.complaintDiagnosisTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.complaintDiagnosisTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.complaintDiagnosisTextbox.Depth = 0;
            this.complaintDiagnosisTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complaintDiagnosisTextbox.HideSelection = true;
            this.complaintDiagnosisTextbox.Hint = "Write your complaint or diagnosis here";
            this.complaintDiagnosisTextbox.Location = new System.Drawing.Point(3, 176);
            this.complaintDiagnosisTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.complaintDiagnosisTextbox.MaxLength = 32767;
            this.complaintDiagnosisTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.complaintDiagnosisTextbox.Name = "complaintDiagnosisTextbox";
            this.complaintDiagnosisTextbox.PasswordChar = '\0';
            this.complaintDiagnosisTextbox.ReadOnly = false;
            this.complaintDiagnosisTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.complaintDiagnosisTextbox.SelectedText = "";
            this.complaintDiagnosisTextbox.SelectionLength = 0;
            this.complaintDiagnosisTextbox.SelectionStart = 0;
            this.complaintDiagnosisTextbox.ShortcutsEnabled = true;
            this.complaintDiagnosisTextbox.Size = new System.Drawing.Size(373, 391);
            this.complaintDiagnosisTextbox.TabIndex = 4;
            this.complaintDiagnosisTextbox.TabStop = false;
            this.complaintDiagnosisTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.complaintDiagnosisTextbox.UseSystemPasswordChar = false;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Depth = 0;
            this.temperatureLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.temperatureLabel.Location = new System.Drawing.Point(382, 76);
            this.temperatureLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(91, 19);
            this.temperatureLabel.TabIndex = 2;
            this.temperatureLabel.Text = "Temperature";
            // 
            // treatmentTextbox
            // 
            this.treatmentTextbox.AnimateReadOnly = false;
            this.treatmentTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.treatmentTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.treatmentTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.treatmentTextbox.Depth = 0;
            this.treatmentTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treatmentTextbox.HideSelection = true;
            this.treatmentTextbox.Hint = "Write your treatment to the pet here";
            this.treatmentTextbox.Location = new System.Drawing.Point(382, 176);
            this.treatmentTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treatmentTextbox.MaxLength = 32767;
            this.treatmentTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.treatmentTextbox.Name = "treatmentTextbox";
            this.treatmentTextbox.PasswordChar = '\0';
            this.treatmentTextbox.ReadOnly = false;
            this.treatmentTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.treatmentTextbox.SelectedText = "";
            this.treatmentTextbox.SelectionLength = 0;
            this.treatmentTextbox.SelectionStart = 0;
            this.treatmentTextbox.ShortcutsEnabled = true;
            this.treatmentTextbox.Size = new System.Drawing.Size(374, 391);
            this.treatmentTextbox.TabIndex = 4;
            this.treatmentTextbox.TabStop = false;
            this.treatmentTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.treatmentTextbox.UseSystemPasswordChar = false;
            // 
            // notesTextbox
            // 
            this.notesTextbox.AnimateReadOnly = false;
            this.notesTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.notesTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.notesTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.notesTextbox.Depth = 0;
            this.notesTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesTextbox.HideSelection = true;
            this.notesTextbox.Hint = "Write some additional notes for customer to do here";
            this.notesTextbox.Location = new System.Drawing.Point(762, 176);
            this.notesTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notesTextbox.MaxLength = 32767;
            this.notesTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.notesTextbox.Name = "notesTextbox";
            this.notesTextbox.PasswordChar = '\0';
            this.notesTextbox.ReadOnly = false;
            this.notesTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.notesTextbox.SelectedText = "";
            this.notesTextbox.SelectionLength = 0;
            this.notesTextbox.SelectionStart = 0;
            this.notesTextbox.ShortcutsEnabled = true;
            this.notesTextbox.Size = new System.Drawing.Size(375, 391);
            this.notesTextbox.TabIndex = 4;
            this.notesTextbox.TabStop = false;
            this.notesTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.notesTextbox.UseSystemPasswordChar = false;
            // 
            // complaintDiagnosisLabel
            // 
            this.complaintDiagnosisLabel.AutoSize = true;
            this.complaintDiagnosisLabel.Depth = 0;
            this.complaintDiagnosisLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.complaintDiagnosisLabel.Location = new System.Drawing.Point(3, 153);
            this.complaintDiagnosisLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.complaintDiagnosisLabel.Name = "complaintDiagnosisLabel";
            this.complaintDiagnosisLabel.Size = new System.Drawing.Size(152, 19);
            this.complaintDiagnosisLabel.TabIndex = 2;
            this.complaintDiagnosisLabel.Text = "Complaint/Diagnosis";
            // 
            // treatmentLabel
            // 
            this.treatmentLabel.AutoSize = true;
            this.treatmentLabel.Depth = 0;
            this.treatmentLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.treatmentLabel.Location = new System.Drawing.Point(382, 153);
            this.treatmentLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.treatmentLabel.Name = "treatmentLabel";
            this.treatmentLabel.Size = new System.Drawing.Size(74, 19);
            this.treatmentLabel.TabIndex = 2;
            this.treatmentLabel.Text = "Treatment";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(618, 462);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(107, 19);
            this.materialLabel8.TabIndex = 2;
            this.materialLabel8.Text = "materialLabel1";
            // 
            // containerPanel
            // 
            this.containerPanel.ColumnCount = 3;
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.containerPanel.Controls.Add(this.costumerLabel, 0, 0);
            this.containerPanel.Controls.Add(this.notesTextbox, 2, 5);
            this.containerPanel.Controls.Add(this.petLabel, 1, 0);
            this.containerPanel.Controls.Add(this.treatmentTextbox, 1, 5);
            this.containerPanel.Controls.Add(this.nextVisitLabel, 2, 0);
            this.containerPanel.Controls.Add(this.complaintDiagnosisTextbox, 0, 5);
            this.containerPanel.Controls.Add(this.customerCombobox, 0, 1);
            this.containerPanel.Controls.Add(this.temperatureTextbox, 1, 3);
            this.containerPanel.Controls.Add(this.treatmentLabel, 1, 4);
            this.containerPanel.Controls.Add(this.petCombobox, 1, 1);
            this.containerPanel.Controls.Add(this.complaintDiagnosisLabel, 0, 4);
            this.containerPanel.Controls.Add(this.weightTextbox, 0, 3);
            this.containerPanel.Controls.Add(this.weightLabel, 0, 2);
            this.containerPanel.Controls.Add(this.temperatureLabel, 1, 2);
            this.containerPanel.Controls.Add(this.notesLabel, 2, 4);
            this.containerPanel.Controls.Add(this.nextVisitDatetime, 2, 1);
            this.containerPanel.Location = new System.Drawing.Point(9, 74);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.RowCount = 6;
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerPanel.Size = new System.Drawing.Size(1140, 571);
            this.containerPanel.TabIndex = 5;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Depth = 0;
            this.notesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.notesLabel.Location = new System.Drawing.Point(762, 153);
            this.notesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(42, 19);
            this.notesLabel.TabIndex = 2;
            this.notesLabel.Text = "Notes";
            // 
            // nextVisitDatetime
            // 
            this.nextVisitDatetime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nextVisitDatetime.CustomFormat = "MM/dd/yy hh:mm tt";
            this.nextVisitDatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nextVisitDatetime.Location = new System.Drawing.Point(762, 30);
            this.nextVisitDatetime.Name = "nextVisitDatetime";
            this.nextVisitDatetime.ShowCheckBox = true;
            this.nextVisitDatetime.Size = new System.Drawing.Size(375, 35);
            this.nextVisitDatetime.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextVisitDatetime.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.AutoSize = false;
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitButton.Depth = 0;
            this.submitButton.HighEmphasis = true;
            this.submitButton.Icon = null;
            this.submitButton.Location = new System.Drawing.Point(999, 654);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.submitButton.Size = new System.Drawing.Size(150, 36);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitButton.UseAccentColor = false;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // MedicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(1155, 698);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.materialLabel8);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MedicationForm";
            this.Padding = new System.Windows.Forms.Padding(3, 71, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medication";
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox customerCombobox;
        private MaterialSkin.Controls.MaterialComboBox petCombobox;
        private MaterialSkin.Controls.MaterialLabel costumerLabel;
        private MaterialSkin.Controls.MaterialLabel petLabel;
        private MaterialSkin.Controls.MaterialLabel nextVisitLabel;
        private MaterialSkin.Controls.MaterialLabel weightLabel;
        private MaterialSkin.Controls.MaterialTextBox weightTextbox;
        private MaterialSkin.Controls.MaterialTextBox temperatureTextbox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 complaintDiagnosisTextbox;
        private MaterialSkin.Controls.MaterialLabel temperatureLabel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 treatmentTextbox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 notesTextbox;
        private MaterialSkin.Controls.MaterialLabel complaintDiagnosisLabel;
        private MaterialSkin.Controls.MaterialLabel treatmentLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.TableLayoutPanel containerPanel;
        private MaterialSkin.Controls.MaterialLabel notesLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker nextVisitDatetime;
        private MaterialSkin.Controls.MaterialButton submitButton;
    }
}