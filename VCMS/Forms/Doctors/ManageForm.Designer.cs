namespace VCMS.Forms.Doctors
{
    partial class ManageForm
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
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.clientsInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.birthdayDatepicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lastNameTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.firstNameTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.clientLabel = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.addressTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.sexCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.contactTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.clientsInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.AutoSize = false;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelButton.Depth = 0;
            this.cancelButton.HighEmphasis = true;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(4, 317);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelButton.Size = new System.Drawing.Size(155, 36);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.AutoSize = false;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(829, 317);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveButton.Size = new System.Drawing.Size(155, 36);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // clientsInfoPanel
            // 
            this.clientsInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsInfoPanel.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.clientsInfoPanel.ColumnCount = 2;
            this.clientsInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clientsInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clientsInfoPanel.Controls.Add(this.birthdayDatepicker, 0, 6);
            this.clientsInfoPanel.Controls.Add(this.saveButton, 1, 7);
            this.clientsInfoPanel.Controls.Add(this.cancelButton, 0, 7);
            this.clientsInfoPanel.Controls.Add(this.lastNameTextbox, 1, 2);
            this.clientsInfoPanel.Controls.Add(this.firstNameTextbox, 0, 2);
            this.clientsInfoPanel.Controls.Add(this.materialLabel1, 0, 1);
            this.clientsInfoPanel.Controls.Add(this.materialLabel2, 1, 1);
            this.clientsInfoPanel.Controls.Add(this.clientLabel, 0, 0);
            this.clientsInfoPanel.Controls.Add(this.materialLabel3, 0, 3);
            this.clientsInfoPanel.Controls.Add(this.materialLabel4, 1, 3);
            this.clientsInfoPanel.Controls.Add(this.addressTextbox, 1, 4);
            this.clientsInfoPanel.Controls.Add(this.materialLabel8, 0, 5);
            this.clientsInfoPanel.Controls.Add(this.materialLabel10, 1, 5);
            this.clientsInfoPanel.Controls.Add(this.sexCombobox, 1, 6);
            this.clientsInfoPanel.Controls.Add(this.contactTextbox, 0, 4);
            this.clientsInfoPanel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.clientsInfoPanel.Location = new System.Drawing.Point(6, 67);
            this.clientsInfoPanel.MinimumSize = new System.Drawing.Size(500, 330);
            this.clientsInfoPanel.Name = "clientsInfoPanel";
            this.clientsInfoPanel.RowCount = 8;
            this.clientsInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.clientsInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.clientsInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.clientsInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.clientsInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.clientsInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.clientsInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.clientsInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.clientsInfoPanel.Size = new System.Drawing.Size(988, 359);
            this.clientsInfoPanel.TabIndex = 14;
            // 
            // birthdayDatepicker
            // 
            this.birthdayDatepicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayDatepicker.BackColor = global::VCMS.Properties.Settings.Default.GlobalControlBack;
            this.birthdayDatepicker.CalendarTodayDate = new System.DateTime(2023, 10, 11, 0, 0, 0, 0);
            this.birthdayDatepicker.CustomFormat = "MM/dd/yyyy";
            this.birthdayDatepicker.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.birthdayDatepicker.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalControlBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.birthdayDatepicker.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.birthdayDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayDatepicker.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.birthdayDatepicker.Location = new System.Drawing.Point(3, 234);
            this.birthdayDatepicker.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.birthdayDatepicker.Name = "birthdayDatepicker";
            this.birthdayDatepicker.Size = new System.Drawing.Size(488, 41);
            this.birthdayDatepicker.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.birthdayDatepicker.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.birthdayDatepicker.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.birthdayDatepicker.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayDatepicker.TabIndex = 10;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextbox.AnimateReadOnly = false;
            this.lastNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTextbox.Depth = 0;
            this.lastNameTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lastNameTextbox.Hint = "e.g. Dela Cruz";
            this.lastNameTextbox.LeadingIcon = null;
            this.lastNameTextbox.Location = new System.Drawing.Point(497, 78);
            this.lastNameTextbox.MaxLength = 50;
            this.lastNameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.lastNameTextbox.Multiline = false;
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(488, 50);
            this.lastNameTextbox.TabIndex = 3;
            this.lastNameTextbox.Text = "";
            this.lastNameTextbox.TrailingIcon = null;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextbox.AnimateReadOnly = false;
            this.firstNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTextbox.Depth = 0;
            this.firstNameTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.firstNameTextbox.Hint = "e.g. Juan";
            this.firstNameTextbox.LeadingIcon = null;
            this.firstNameTextbox.Location = new System.Drawing.Point(3, 78);
            this.firstNameTextbox.MaxLength = 50;
            this.firstNameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.firstNameTextbox.Multiline = false;
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(488, 50);
            this.firstNameTextbox.TabIndex = 2;
            this.firstNameTextbox.Text = "";
            this.firstNameTextbox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 56);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "First name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(497, 56);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Last name";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientsInfoPanel.SetColumnSpan(this.clientLabel, 2);
            this.clientLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.clientLabel.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.clientLabel.Location = new System.Drawing.Point(3, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(439, 56);
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "Veterinarian\'s Information";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(3, 131);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(114, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Contact number";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(497, 131);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Address";
            // 
            // addressTextbox
            // 
            this.addressTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextbox.AnimateReadOnly = false;
            this.addressTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextbox.Depth = 0;
            this.addressTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressTextbox.Hint = "e.g. Tuguegarao City, Cagayan";
            this.addressTextbox.LeadingIcon = null;
            this.addressTextbox.Location = new System.Drawing.Point(497, 153);
            this.addressTextbox.MaxLength = 50;
            this.addressTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.addressTextbox.Multiline = false;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(488, 50);
            this.addressTextbox.TabIndex = 5;
            this.addressTextbox.Text = "";
            this.addressTextbox.TrailingIcon = null;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(3, 206);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(60, 19);
            this.materialLabel8.TabIndex = 6;
            this.materialLabel8.Text = "Birthday";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(497, 206);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(27, 19);
            this.materialLabel10.TabIndex = 11;
            this.materialLabel10.Text = "Sex";
            // 
            // sexCombobox
            // 
            this.sexCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sexCombobox.AutoResize = false;
            this.sexCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sexCombobox.Depth = 0;
            this.sexCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sexCombobox.DropDownHeight = 174;
            this.sexCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexCombobox.DropDownWidth = 121;
            this.sexCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sexCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sexCombobox.FormattingEnabled = true;
            this.sexCombobox.Hint = "[Male/Female]";
            this.sexCombobox.IntegralHeight = false;
            this.sexCombobox.ItemHeight = 43;
            this.sexCombobox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexCombobox.Location = new System.Drawing.Point(497, 228);
            this.sexCombobox.MaxDropDownItems = 4;
            this.sexCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.sexCombobox.Name = "sexCombobox";
            this.sexCombobox.Size = new System.Drawing.Size(488, 49);
            this.sexCombobox.StartIndex = 0;
            this.sexCombobox.TabIndex = 12;
            // 
            // contactTextbox
            // 
            this.contactTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactTextbox.AnimateReadOnly = false;
            this.contactTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactTextbox.Depth = 0;
            this.contactTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contactTextbox.Hint = "e.g. 09876543210";
            this.contactTextbox.LeadingIcon = null;
            this.contactTextbox.Location = new System.Drawing.Point(3, 153);
            this.contactTextbox.MaxLength = 11;
            this.contactTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.contactTextbox.Multiline = false;
            this.contactTextbox.Name = "contactTextbox";
            this.contactTextbox.Size = new System.Drawing.Size(488, 50);
            this.contactTextbox.TabIndex = 4;
            this.contactTextbox.Text = "";
            this.contactTextbox.TrailingIcon = null;
            this.contactTextbox.Enter += new System.EventHandler(this.ContactTextbox_Enter);
            this.contactTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactTextbox_KeyPress);
            this.contactTextbox.Leave += new System.EventHandler(this.ContactTextbox_Leave);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 434);
            this.Controls.Add(this.clientsInfoPanel);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.clientsInfoPanel.ResumeLayout(false);
            this.clientsInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton cancelButton;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private System.Windows.Forms.TableLayoutPanel clientsInfoPanel;
        private MaterialSkin.Controls.MaterialTextBox lastNameTextbox;
        private MaterialSkin.Controls.MaterialTextBox firstNameTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label clientLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox addressTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker birthdayDatepicker;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox sexCombobox;
        private MaterialSkin.Controls.MaterialTextBox contactTextbox;
    }
}