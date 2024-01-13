namespace VCMS.Forms.Services
{
    partial class CheckupForm
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
            this.submitButton = new MaterialSkin.Controls.MaterialButton();
            this.nextVisitDatetime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.complaintDiagnosisLabel = new MaterialSkin.Controls.MaterialLabel();
            this.petCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.treatmentLabel = new MaterialSkin.Controls.MaterialLabel();
            this.customerCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.complaintTextbox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.nextVisitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.findingsTextbox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.petLabel = new MaterialSkin.Controls.MaterialLabel();
            this.costumerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.containerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.checkupList = new MaterialSkin.Controls.MaterialListView();
            this.resultTextbox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.testLabel = new MaterialSkin.Controls.MaterialLabel();
            this.testCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.editButton = new MaterialSkin.Controls.MaterialButton();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.finishButton = new MaterialSkin.Controls.MaterialButton();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.submitButton.Location = new System.Drawing.Point(1344, 799);
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
            // nextVisitDatetime
            // 
            this.nextVisitDatetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nextVisitDatetime.Checked = false;
            this.nextVisitDatetime.CustomFormat = "MM/dd/yy hh:mm tt";
            this.nextVisitDatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nextVisitDatetime.Location = new System.Drawing.Point(992, 29);
            this.nextVisitDatetime.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.nextVisitDatetime.Name = "nextVisitDatetime";
            this.nextVisitDatetime.ShowCheckBox = true;
            this.nextVisitDatetime.Size = new System.Drawing.Size(490, 41);
            this.nextVisitDatetime.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.nextVisitDatetime.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.nextVisitDatetime.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextVisitDatetime.TabIndex = 5;
            // 
            // complaintDiagnosisLabel
            // 
            this.complaintDiagnosisLabel.AutoSize = true;
            this.complaintDiagnosisLabel.Depth = 0;
            this.complaintDiagnosisLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.complaintDiagnosisLabel.Location = new System.Drawing.Point(3, 76);
            this.complaintDiagnosisLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.complaintDiagnosisLabel.Name = "complaintDiagnosisLabel";
            this.complaintDiagnosisLabel.Size = new System.Drawing.Size(74, 19);
            this.complaintDiagnosisLabel.TabIndex = 2;
            this.complaintDiagnosisLabel.Text = "Complaint";
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
            this.petCombobox.Location = new System.Drawing.Point(497, 23);
            this.petCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.petCombobox.MaxDropDownItems = 4;
            this.petCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.petCombobox.Name = "petCombobox";
            this.petCombobox.Size = new System.Drawing.Size(489, 49);
            this.petCombobox.StartIndex = 0;
            this.petCombobox.TabIndex = 0;
            this.petCombobox.SelectedIndexChanged += new System.EventHandler(this.petCombobox_SelectedIndexChanged);
            // 
            // treatmentLabel
            // 
            this.treatmentLabel.AutoSize = true;
            this.treatmentLabel.Depth = 0;
            this.treatmentLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.treatmentLabel.Location = new System.Drawing.Point(497, 76);
            this.treatmentLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.treatmentLabel.Name = "treatmentLabel";
            this.treatmentLabel.Size = new System.Drawing.Size(62, 19);
            this.treatmentLabel.TabIndex = 2;
            this.treatmentLabel.Text = "Findings";
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
            this.customerCombobox.Size = new System.Drawing.Size(488, 49);
            this.customerCombobox.StartIndex = 0;
            this.customerCombobox.TabIndex = 0;
            this.customerCombobox.SelectedIndexChanged += new System.EventHandler(this.CustomerCombobox_SelectedIndexChanged);
            // 
            // complaintTextbox
            // 
            this.complaintTextbox.AnimateReadOnly = false;
            this.complaintTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.complaintTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.complaintTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.complaintTextbox.Depth = 0;
            this.complaintTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complaintTextbox.HideSelection = true;
            this.complaintTextbox.Hint = "Write your complaint here";
            this.complaintTextbox.Location = new System.Drawing.Point(3, 99);
            this.complaintTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.complaintTextbox.MaxLength = 32767;
            this.complaintTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.complaintTextbox.Name = "complaintTextbox";
            this.complaintTextbox.PasswordChar = '\0';
            this.complaintTextbox.ReadOnly = false;
            this.containerPanel.SetRowSpan(this.complaintTextbox, 2);
            this.complaintTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.complaintTextbox.SelectedText = "";
            this.complaintTextbox.SelectionLength = 0;
            this.complaintTextbox.SelectionStart = 0;
            this.complaintTextbox.ShortcutsEnabled = true;
            this.complaintTextbox.Size = new System.Drawing.Size(488, 207);
            this.complaintTextbox.TabIndex = 4;
            this.complaintTextbox.TabStop = false;
            this.complaintTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.complaintTextbox.UseSystemPasswordChar = false;
            // 
            // nextVisitLabel
            // 
            this.nextVisitLabel.AutoSize = true;
            this.nextVisitLabel.Depth = 0;
            this.nextVisitLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nextVisitLabel.Location = new System.Drawing.Point(992, 0);
            this.nextVisitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextVisitLabel.Name = "nextVisitLabel";
            this.nextVisitLabel.Size = new System.Drawing.Size(68, 19);
            this.nextVisitLabel.TabIndex = 2;
            this.nextVisitLabel.Text = "Next Visit";
            // 
            // findingsTextbox
            // 
            this.findingsTextbox.AnimateReadOnly = false;
            this.findingsTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.findingsTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.findingsTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.findingsTextbox.Depth = 0;
            this.findingsTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findingsTextbox.HideSelection = true;
            this.findingsTextbox.Hint = "Write your findings to the pet here";
            this.findingsTextbox.Location = new System.Drawing.Point(497, 99);
            this.findingsTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.findingsTextbox.MaxLength = 32767;
            this.findingsTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.findingsTextbox.Name = "findingsTextbox";
            this.findingsTextbox.PasswordChar = '\0';
            this.findingsTextbox.ReadOnly = false;
            this.containerPanel.SetRowSpan(this.findingsTextbox, 2);
            this.findingsTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.findingsTextbox.SelectedText = "";
            this.findingsTextbox.SelectionLength = 0;
            this.findingsTextbox.SelectionStart = 0;
            this.findingsTextbox.ShortcutsEnabled = true;
            this.findingsTextbox.Size = new System.Drawing.Size(489, 207);
            this.findingsTextbox.TabIndex = 4;
            this.findingsTextbox.TabStop = false;
            this.findingsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.findingsTextbox.UseSystemPasswordChar = false;
            // 
            // petLabel
            // 
            this.petLabel.AutoSize = true;
            this.petLabel.Depth = 0;
            this.petLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.petLabel.Location = new System.Drawing.Point(497, 0);
            this.petLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.petLabel.Name = "petLabel";
            this.petLabel.Size = new System.Drawing.Size(24, 19);
            this.petLabel.TabIndex = 2;
            this.petLabel.Text = "Pet";
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
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.ColumnCount = 3;
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.containerPanel.Controls.Add(this.checkupList, 0, 5);
            this.containerPanel.Controls.Add(this.resultTextbox, 2, 4);
            this.containerPanel.Controls.Add(this.costumerLabel, 0, 0);
            this.containerPanel.Controls.Add(this.petLabel, 1, 0);
            this.containerPanel.Controls.Add(this.findingsTextbox, 1, 3);
            this.containerPanel.Controls.Add(this.nextVisitLabel, 2, 0);
            this.containerPanel.Controls.Add(this.complaintTextbox, 0, 3);
            this.containerPanel.Controls.Add(this.customerCombobox, 0, 1);
            this.containerPanel.Controls.Add(this.petCombobox, 1, 1);
            this.containerPanel.Controls.Add(this.nextVisitDatetime, 2, 1);
            this.containerPanel.Controls.Add(this.testLabel, 2, 2);
            this.containerPanel.Controls.Add(this.testCombobox, 2, 3);
            this.containerPanel.Controls.Add(this.treatmentLabel, 1, 2);
            this.containerPanel.Controls.Add(this.complaintDiagnosisLabel, 0, 2);
            this.containerPanel.Location = new System.Drawing.Point(9, 74);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.RowCount = 6;
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerPanel.Size = new System.Drawing.Size(1485, 719);
            this.containerPanel.TabIndex = 5;
            // 
            // checkupList
            // 
            this.checkupList.AutoSizeTable = false;
            this.checkupList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkupList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.containerPanel.SetColumnSpan(this.checkupList, 4);
            this.checkupList.Depth = 0;
            this.checkupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkupList.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkupList.FullRowSelect = true;
            this.checkupList.HideSelection = false;
            this.checkupList.Location = new System.Drawing.Point(4, 314);
            this.checkupList.Margin = new System.Windows.Forms.Padding(4);
            this.checkupList.MinimumSize = new System.Drawing.Size(233, 123);
            this.checkupList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkupList.MouseState = MaterialSkin.MouseState.OUT;
            this.checkupList.Name = "checkupList";
            this.checkupList.OwnerDraw = true;
            this.checkupList.Size = new System.Drawing.Size(1477, 401);
            this.checkupList.TabIndex = 8;
            this.checkupList.UseCompatibleStateImageBehavior = false;
            this.checkupList.View = System.Windows.Forms.View.Details;
            // 
            // resultTextbox
            // 
            this.resultTextbox.AnimateReadOnly = false;
            this.resultTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resultTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.resultTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultTextbox.Depth = 0;
            this.resultTextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultTextbox.HideSelection = true;
            this.resultTextbox.Hint = "Write all selected results here.";
            this.resultTextbox.Location = new System.Drawing.Point(992, 155);
            this.resultTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultTextbox.MaxLength = 32767;
            this.resultTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.PasswordChar = '\0';
            this.resultTextbox.ReadOnly = false;
            this.resultTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resultTextbox.SelectedText = "";
            this.resultTextbox.SelectionLength = 0;
            this.resultTextbox.SelectionStart = 0;
            this.resultTextbox.ShortcutsEnabled = true;
            this.resultTextbox.Size = new System.Drawing.Size(490, 150);
            this.resultTextbox.TabIndex = 7;
            this.resultTextbox.TabStop = false;
            this.resultTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.resultTextbox.UseSystemPasswordChar = false;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Depth = 0;
            this.testLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.testLabel.Location = new System.Drawing.Point(992, 76);
            this.testLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(32, 19);
            this.testLabel.TabIndex = 2;
            this.testLabel.Text = "Test";
            // 
            // testCombobox
            // 
            this.testCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testCombobox.AutoResize = false;
            this.testCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testCombobox.Depth = 0;
            this.testCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.testCombobox.DropDownHeight = 174;
            this.testCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testCombobox.DropDownWidth = 121;
            this.testCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.testCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.testCombobox.FormattingEnabled = true;
            this.testCombobox.Hint = "[Select laboratory test]";
            this.testCombobox.IntegralHeight = false;
            this.testCombobox.ItemHeight = 43;
            this.testCombobox.Location = new System.Drawing.Point(992, 99);
            this.testCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.testCombobox.MaxDropDownItems = 4;
            this.testCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.testCombobox.Name = "testCombobox";
            this.testCombobox.Size = new System.Drawing.Size(490, 49);
            this.testCombobox.StartIndex = 0;
            this.testCombobox.TabIndex = 6;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Checked = true;
            this.materialCheckbox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "dsa";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Checked = true;
            this.materialCheckbox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "asd\r\nasd\r\nasd";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Checked = true;
            this.materialCheckbox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.Checked = true;
            this.materialCheckbox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.ReadOnly = false;
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox4.TabIndex = 0;
            this.materialCheckbox4.Text = "materialCheckbox4";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox5
            // 
            this.materialCheckbox5.Checked = true;
            this.materialCheckbox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox5.Depth = 0;
            this.materialCheckbox5.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox5.Name = "materialCheckbox5";
            this.materialCheckbox5.ReadOnly = false;
            this.materialCheckbox5.Ripple = true;
            this.materialCheckbox5.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox5.TabIndex = 0;
            this.materialCheckbox5.Text = "materialCheckbox5";
            this.materialCheckbox5.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.AutoSize = false;
            this.editButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editButton.Depth = 0;
            this.editButton.HighEmphasis = true;
            this.editButton.Icon = null;
            this.editButton.Location = new System.Drawing.Point(9, 799);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.editButton.Name = "editButton";
            this.editButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editButton.Size = new System.Drawing.Size(150, 36);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editButton.UseAccentColor = false;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.AutoSize = false;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(167, 799);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(150, 36);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteButton.UseAccentColor = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishButton.AutoSize = false;
            this.finishButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.finishButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.finishButton.Depth = 0;
            this.finishButton.HighEmphasis = true;
            this.finishButton.Icon = null;
            this.finishButton.Location = new System.Drawing.Point(1186, 799);
            this.finishButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.finishButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.finishButton.Name = "finishButton";
            this.finishButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.finishButton.Size = new System.Drawing.Size(150, 36);
            this.finishButton.TabIndex = 6;
            this.finishButton.Text = "CLOSE";
            this.finishButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.finishButton.UseAccentColor = false;
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // CheckupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(1500, 846);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.containerPanel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CheckupForm";
            this.Padding = new System.Windows.Forms.Padding(3, 71, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkup";
            this.Load += new System.EventHandler(this.CheckupForm_Load);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton submitButton;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker nextVisitDatetime;
        private MaterialSkin.Controls.MaterialLabel complaintDiagnosisLabel;
        private MaterialSkin.Controls.MaterialComboBox petCombobox;
        private MaterialSkin.Controls.MaterialLabel treatmentLabel;
        private MaterialSkin.Controls.MaterialComboBox customerCombobox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 complaintTextbox;
        private MaterialSkin.Controls.MaterialLabel nextVisitLabel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 findingsTextbox;
        private MaterialSkin.Controls.MaterialLabel petLabel;
        private MaterialSkin.Controls.MaterialLabel costumerLabel;
        private System.Windows.Forms.TableLayoutPanel containerPanel;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialLabel testLabel;
        private MaterialSkin.Controls.MaterialComboBox testCombobox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 resultTextbox;
        private MaterialSkin.Controls.MaterialListView checkupList;
        private MaterialSkin.Controls.MaterialButton editButton;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialButton finishButton;
    }
}