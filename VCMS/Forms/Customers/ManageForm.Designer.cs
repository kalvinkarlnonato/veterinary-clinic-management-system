namespace VCMS.Forms.Customers
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contactTextbox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lastNameTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.firstNameTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.addressTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.patientLabel = new System.Windows.Forms.Label();
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.petNameTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.birthdayDatepicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.colormarkingTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.sexCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.speciesCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.breedCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.contactTextbox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lastNameTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.firstNameTextbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.addressTextbox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 123);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(937, 157);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // contactTextbox
            // 
            this.contactTextbox.AllowPromptAsInput = true;
            this.contactTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactTextbox.AnimateReadOnly = false;
            this.contactTextbox.AsciiOnly = false;
            this.contactTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contactTextbox.BeepOnError = false;
            this.contactTextbox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.contactTextbox.Depth = 0;
            this.contactTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contactTextbox.HidePromptOnLeave = false;
            this.contactTextbox.HideSelection = true;
            this.contactTextbox.Hint = "e.g. 09876543210";
            this.contactTextbox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.contactTextbox.LeadingIcon = null;
            this.contactTextbox.Location = new System.Drawing.Point(3, 97);
            this.contactTextbox.Mask = "00000000000";
            this.contactTextbox.MaxLength = 32767;
            this.contactTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.contactTextbox.Name = "contactTextbox";
            this.contactTextbox.PasswordChar = '\0';
            this.contactTextbox.PrefixSuffixText = null;
            this.contactTextbox.PromptChar = ' ';
            this.contactTextbox.ReadOnly = false;
            this.contactTextbox.RejectInputOnFirstFailure = false;
            this.contactTextbox.ResetOnPrompt = true;
            this.contactTextbox.ResetOnSpace = true;
            this.contactTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contactTextbox.SelectedText = "";
            this.contactTextbox.SelectionLength = 0;
            this.contactTextbox.SelectionStart = 0;
            this.contactTextbox.ShortcutsEnabled = true;
            this.contactTextbox.Size = new System.Drawing.Size(462, 48);
            this.contactTextbox.SkipLiterals = true;
            this.contactTextbox.TabIndex = 4;
            this.contactTextbox.TabStop = false;
            this.contactTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contactTextbox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.contactTextbox.TrailingIcon = null;
            this.contactTextbox.UseSystemPasswordChar = false;
            this.contactTextbox.ValidatingType = null;
            this.contactTextbox.Click += new System.EventHandler(this.ContactTextbox_Click);
            this.contactTextbox.Enter += new System.EventHandler(this.ContactTextbox_Enter);
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
            this.lastNameTextbox.Location = new System.Drawing.Point(471, 22);
            this.lastNameTextbox.MaxLength = 50;
            this.lastNameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.lastNameTextbox.Multiline = false;
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(463, 50);
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
            this.firstNameTextbox.Location = new System.Drawing.Point(3, 22);
            this.firstNameTextbox.MaxLength = 50;
            this.firstNameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.firstNameTextbox.Multiline = false;
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(462, 50);
            this.firstNameTextbox.TabIndex = 2;
            this.firstNameTextbox.Text = "";
            this.firstNameTextbox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
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
            this.materialLabel2.Location = new System.Drawing.Point(471, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Last name";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(3, 75);
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
            this.materialLabel4.Location = new System.Drawing.Point(471, 75);
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
            this.addressTextbox.Location = new System.Drawing.Point(471, 97);
            this.addressTextbox.MaxLength = 50;
            this.addressTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.addressTextbox.Multiline = false;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(463, 50);
            this.addressTextbox.TabIndex = 5;
            this.addressTextbox.Text = "";
            this.addressTextbox.TrailingIcon = null;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientLabel.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientLabel.Location = new System.Drawing.Point(5, 67);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(334, 56);
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "Client\'s Information";
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientLabel.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patientLabel.Location = new System.Drawing.Point(5, 286);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(354, 56);
            this.patientLabel.TabIndex = 1;
            this.patientLabel.Text = "Patient\'s information";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.AutoSize = false;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(797, 523);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveButton.Size = new System.Drawing.Size(155, 36);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = false;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelButton.Depth = 0;
            this.cancelButton.HighEmphasis = true;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(15, 523);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelButton.Size = new System.Drawing.Size(155, 36);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.petNameTextbox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel9, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel10, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.birthdayDatepicker, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.colormarkingTextbox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.sexCombobox, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.speciesCombobox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.breedCombobox, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 342);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(937, 172);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // petNameTextbox
            // 
            this.petNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petNameTextbox.AnimateReadOnly = false;
            this.petNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.petNameTextbox.Depth = 0;
            this.petNameTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.petNameTextbox.Hint = "e.g. Fluffy";
            this.petNameTextbox.LeadingIcon = null;
            this.petNameTextbox.Location = new System.Drawing.Point(3, 22);
            this.petNameTextbox.MaxLength = 50;
            this.petNameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.petNameTextbox.Multiline = false;
            this.petNameTextbox.Name = "petNameTextbox";
            this.petNameTextbox.Size = new System.Drawing.Size(306, 50);
            this.petNameTextbox.TabIndex = 6;
            this.petNameTextbox.Text = "";
            this.petNameTextbox.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(3, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(43, 19);
            this.materialLabel5.TabIndex = 1;
            this.materialLabel5.Text = "Name";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(315, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(56, 19);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "Species";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(627, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(41, 19);
            this.materialLabel7.TabIndex = 1;
            this.materialLabel7.Text = "Breed";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(3, 75);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(60, 19);
            this.materialLabel8.TabIndex = 1;
            this.materialLabel8.Text = "Birthday";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(315, 75);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(100, 19);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "Color marking";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(627, 75);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(27, 19);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = "Sex";
            // 
            // birthdayDatepicker
            // 
            this.birthdayDatepicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayDatepicker.CalendarTodayDate = new System.DateTime(2023, 10, 11, 0, 0, 0, 0);
            this.birthdayDatepicker.CustomFormat = "MM/dd/yyyy";
            this.birthdayDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayDatepicker.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.birthdayDatepicker.Location = new System.Drawing.Point(3, 103);
            this.birthdayDatepicker.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.birthdayDatepicker.Name = "birthdayDatepicker";
            this.birthdayDatepicker.Size = new System.Drawing.Size(306, 41);
            this.birthdayDatepicker.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.birthdayDatepicker.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.birthdayDatepicker.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.birthdayDatepicker.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayDatepicker.TabIndex = 9;
            // 
            // colormarkingTextbox
            // 
            this.colormarkingTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colormarkingTextbox.AnimateReadOnly = false;
            this.colormarkingTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colormarkingTextbox.Depth = 0;
            this.colormarkingTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.colormarkingTextbox.Hint = "e.g. Black and white";
            this.colormarkingTextbox.LeadingIcon = null;
            this.colormarkingTextbox.Location = new System.Drawing.Point(315, 97);
            this.colormarkingTextbox.MaxLength = 50;
            this.colormarkingTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.colormarkingTextbox.Multiline = false;
            this.colormarkingTextbox.Name = "colormarkingTextbox";
            this.colormarkingTextbox.Size = new System.Drawing.Size(306, 50);
            this.colormarkingTextbox.TabIndex = 10;
            this.colormarkingTextbox.Text = "";
            this.colormarkingTextbox.TrailingIcon = null;
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
            this.sexCombobox.Location = new System.Drawing.Point(627, 97);
            this.sexCombobox.MaxDropDownItems = 4;
            this.sexCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.sexCombobox.Name = "sexCombobox";
            this.sexCombobox.Size = new System.Drawing.Size(307, 49);
            this.sexCombobox.StartIndex = 0;
            this.sexCombobox.TabIndex = 11;
            // 
            // speciesCombobox
            // 
            this.speciesCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speciesCombobox.AutoResize = false;
            this.speciesCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.speciesCombobox.Depth = 0;
            this.speciesCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.speciesCombobox.DropDownHeight = 174;
            this.speciesCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciesCombobox.DropDownWidth = 121;
            this.speciesCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.speciesCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.speciesCombobox.FormattingEnabled = true;
            this.speciesCombobox.Hint = "[Select]";
            this.speciesCombobox.IntegralHeight = false;
            this.speciesCombobox.ItemHeight = 43;
            this.speciesCombobox.Items.AddRange(new object[] {
            "Dog",
            "Cat"});
            this.speciesCombobox.Location = new System.Drawing.Point(315, 22);
            this.speciesCombobox.MaxDropDownItems = 4;
            this.speciesCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.speciesCombobox.Name = "speciesCombobox";
            this.speciesCombobox.Size = new System.Drawing.Size(306, 49);
            this.speciesCombobox.StartIndex = 0;
            this.speciesCombobox.TabIndex = 7;
            this.speciesCombobox.SelectedIndexChanged += new System.EventHandler(this.SpeciesCombobox_SelectedIndexChanged);
            // 
            // breedCombobox
            // 
            this.breedCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.breedCombobox.AutoResize = false;
            this.breedCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.breedCombobox.Depth = 0;
            this.breedCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.breedCombobox.DropDownHeight = 174;
            this.breedCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.breedCombobox.DropDownWidth = 121;
            this.breedCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.breedCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.breedCombobox.FormattingEnabled = true;
            this.breedCombobox.Hint = "[Select]";
            this.breedCombobox.IntegralHeight = false;
            this.breedCombobox.ItemHeight = 43;
            this.breedCombobox.Location = new System.Drawing.Point(627, 22);
            this.breedCombobox.MaxDropDownItems = 4;
            this.breedCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.breedCombobox.Name = "breedCombobox";
            this.breedCombobox.Size = new System.Drawing.Size(307, 49);
            this.breedCombobox.StartIndex = 0;
            this.breedCombobox.TabIndex = 8;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 575);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.clientLabel);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEdit";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label clientLabel;
        private MaterialSkin.Controls.MaterialTextBox lastNameTextbox;
        private MaterialSkin.Controls.MaterialTextBox firstNameTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox addressTextbox;
        private System.Windows.Forms.Label patientLabel;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialTextBox petNameTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox speciesCombobox;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker birthdayDatepicker;
        private MaterialSkin.Controls.MaterialTextBox colormarkingTextbox;
        private MaterialSkin.Controls.MaterialComboBox sexCombobox;
        private MaterialSkin.Controls.MaterialMaskedTextBox contactTextbox;
        private MaterialSkin.Controls.MaterialComboBox breedCombobox;
    }
}