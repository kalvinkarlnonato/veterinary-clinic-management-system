namespace VCMS.Forms.Services
{
    partial class ServiceForm
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
            this.costumerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.petLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nextVisitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.customerCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.petCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.weightTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.weightLabel = new MaterialSkin.Controls.MaterialLabel();
            this.temperatureLabel = new MaterialSkin.Controls.MaterialLabel();
            this.nextVisitDatetime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.serviceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.serviceCombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.submitButton = new MaterialSkin.Controls.MaterialButton();
            this.againstTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.containerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.serviceList = new MaterialSkin.Controls.MaterialListView();
            this.temperatureTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.manufacturerTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.editButton = new MaterialSkin.Controls.MaterialButton();
            this.finishButton = new MaterialSkin.Controls.MaterialButton();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // costumerLabel
            // 
            this.costumerLabel.AutoSize = true;
            this.costumerLabel.Depth = 0;
            this.costumerLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.costumerLabel.Location = new System.Drawing.Point(4, 0);
            this.costumerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.petLabel.Location = new System.Drawing.Point(291, 0);
            this.petLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.nextVisitLabel.Location = new System.Drawing.Point(865, 0);
            this.nextVisitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextVisitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextVisitLabel.Name = "nextVisitLabel";
            this.nextVisitLabel.Size = new System.Drawing.Size(68, 19);
            this.nextVisitLabel.TabIndex = 2;
            this.nextVisitLabel.Text = "Next Visit";
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
            this.customerCombobox.Location = new System.Drawing.Point(4, 24);
            this.customerCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerCombobox.MaxDropDownItems = 4;
            this.customerCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.customerCombobox.Name = "customerCombobox";
            this.customerCombobox.Size = new System.Drawing.Size(279, 49);
            this.customerCombobox.StartIndex = 0;
            this.customerCombobox.TabIndex = 0;
            this.customerCombobox.SelectedIndexChanged += new System.EventHandler(this.customerCombobox_SelectedIndexChanged);
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
            this.petCombobox.Location = new System.Drawing.Point(291, 24);
            this.petCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.petCombobox.MaxDropDownItems = 4;
            this.petCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.petCombobox.Name = "petCombobox";
            this.petCombobox.Size = new System.Drawing.Size(279, 49);
            this.petCombobox.StartIndex = 0;
            this.petCombobox.TabIndex = 0;
            this.petCombobox.SelectedIndexChanged += new System.EventHandler(this.petCombobox_SelectedIndexChanged);
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
            this.weightTextbox.Location = new System.Drawing.Point(4, 102);
            this.weightTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.weightTextbox.MaxLength = 50;
            this.weightTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.weightTextbox.Multiline = false;
            this.weightTextbox.Name = "weightTextbox";
            this.weightTextbox.Size = new System.Drawing.Size(279, 50);
            this.weightTextbox.TabIndex = 3;
            this.weightTextbox.Text = "";
            this.weightTextbox.TrailingIcon = null;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Depth = 0;
            this.weightLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.weightLabel.Location = new System.Drawing.Point(4, 78);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weightLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(50, 19);
            this.weightLabel.TabIndex = 2;
            this.weightLabel.Text = "Weight";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Depth = 0;
            this.temperatureLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.temperatureLabel.Location = new System.Drawing.Point(291, 78);
            this.temperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(91, 19);
            this.temperatureLabel.TabIndex = 2;
            this.temperatureLabel.Text = "Temperature";
            // 
            // nextVisitDatetime
            // 
            this.nextVisitDatetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nextVisitDatetime.Checked = false;
            this.nextVisitDatetime.CustomFormat = "MM/dd/yy hh:mm tt";
            this.nextVisitDatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nextVisitDatetime.Location = new System.Drawing.Point(865, 31);
            this.nextVisitDatetime.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.nextVisitDatetime.Name = "nextVisitDatetime";
            this.nextVisitDatetime.ShowCheckBox = true;
            this.nextVisitDatetime.Size = new System.Drawing.Size(279, 41);
            this.nextVisitDatetime.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.nextVisitDatetime.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.nextVisitDatetime.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextVisitDatetime.TabIndex = 5;
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Depth = 0;
            this.serviceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.serviceLabel.Location = new System.Drawing.Point(578, 0);
            this.serviceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serviceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(52, 19);
            this.serviceLabel.TabIndex = 2;
            this.serviceLabel.Text = "Service";
            // 
            // serviceCombobox
            // 
            this.serviceCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceCombobox.AutoResize = false;
            this.serviceCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serviceCombobox.Depth = 0;
            this.serviceCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.serviceCombobox.DropDownHeight = 174;
            this.serviceCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceCombobox.DropDownWidth = 121;
            this.serviceCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.serviceCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serviceCombobox.FormattingEnabled = true;
            this.serviceCombobox.Hint = "[Select service]";
            this.serviceCombobox.IntegralHeight = false;
            this.serviceCombobox.ItemHeight = 43;
            this.serviceCombobox.Items.AddRange(new object[] {
            "Grooming",
            "Vaccination",
            "Deworming",
            "Anti-tick and Flea Preventives",
            "Confinement"});
            this.serviceCombobox.Location = new System.Drawing.Point(578, 24);
            this.serviceCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.serviceCombobox.MaxDropDownItems = 4;
            this.serviceCombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.serviceCombobox.Name = "serviceCombobox";
            this.serviceCombobox.Size = new System.Drawing.Size(279, 49);
            this.serviceCombobox.StartIndex = 0;
            this.serviceCombobox.TabIndex = 6;
            this.serviceCombobox.SelectedIndexChanged += new System.EventHandler(this.TestCombobox_SelectedIndexChanged);
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
            this.submitButton.Location = new System.Drawing.Point(983, 634);
            this.submitButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.submitButton.Size = new System.Drawing.Size(175, 44);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit";
            this.submitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitButton.UseAccentColor = false;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // againstTextbox
            // 
            this.againstTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.againstTextbox.AnimateReadOnly = false;
            this.againstTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.againstTextbox.Depth = 0;
            this.againstTextbox.Enabled = false;
            this.againstTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.againstTextbox.Hint = "e.g. Alergy";
            this.againstTextbox.LeadingIcon = null;
            this.againstTextbox.Location = new System.Drawing.Point(578, 102);
            this.againstTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.againstTextbox.MaxLength = 50;
            this.againstTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.againstTextbox.Multiline = false;
            this.againstTextbox.Name = "againstTextbox";
            this.againstTextbox.Size = new System.Drawing.Size(279, 50);
            this.againstTextbox.TabIndex = 3;
            this.againstTextbox.Text = "";
            this.againstTextbox.TrailingIcon = null;
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.ColumnCount = 4;
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.containerPanel.Controls.Add(this.serviceList, 0, 4);
            this.containerPanel.Controls.Add(this.costumerLabel, 0, 0);
            this.containerPanel.Controls.Add(this.petLabel, 1, 0);
            this.containerPanel.Controls.Add(this.customerCombobox, 0, 1);
            this.containerPanel.Controls.Add(this.petCombobox, 1, 1);
            this.containerPanel.Controls.Add(this.againstTextbox, 2, 3);
            this.containerPanel.Controls.Add(this.nextVisitLabel, 3, 0);
            this.containerPanel.Controls.Add(this.nextVisitDatetime, 3, 1);
            this.containerPanel.Controls.Add(this.serviceLabel, 2, 0);
            this.containerPanel.Controls.Add(this.serviceCombobox, 2, 1);
            this.containerPanel.Controls.Add(this.weightLabel, 0, 2);
            this.containerPanel.Controls.Add(this.weightTextbox, 0, 3);
            this.containerPanel.Controls.Add(this.temperatureLabel, 1, 2);
            this.containerPanel.Controls.Add(this.temperatureTextbox, 1, 3);
            this.containerPanel.Controls.Add(this.materialLabel1, 2, 2);
            this.containerPanel.Controls.Add(this.materialLabel2, 3, 2);
            this.containerPanel.Controls.Add(this.manufacturerTextbox, 3, 3);
            this.containerPanel.Location = new System.Drawing.Point(14, 72);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.RowCount = 5;
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerPanel.Size = new System.Drawing.Size(1148, 557);
            this.containerPanel.TabIndex = 12;
            // 
            // serviceList
            // 
            this.serviceList.AutoSizeTable = false;
            this.serviceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serviceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.containerPanel.SetColumnSpan(this.serviceList, 4);
            this.serviceList.Depth = 0;
            this.serviceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceList.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceList.FullRowSelect = true;
            this.serviceList.HideSelection = false;
            this.serviceList.Location = new System.Drawing.Point(4, 161);
            this.serviceList.Margin = new System.Windows.Forms.Padding(4);
            this.serviceList.MinimumSize = new System.Drawing.Size(233, 123);
            this.serviceList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.serviceList.MouseState = MaterialSkin.MouseState.OUT;
            this.serviceList.Name = "serviceList";
            this.serviceList.OwnerDraw = true;
            this.serviceList.Size = new System.Drawing.Size(1140, 392);
            this.serviceList.TabIndex = 7;
            this.serviceList.UseCompatibleStateImageBehavior = false;
            this.serviceList.View = System.Windows.Forms.View.Details;
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
            this.temperatureTextbox.Location = new System.Drawing.Point(291, 102);
            this.temperatureTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.temperatureTextbox.MaxLength = 50;
            this.temperatureTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.temperatureTextbox.Multiline = false;
            this.temperatureTextbox.Name = "temperatureTextbox";
            this.temperatureTextbox.Size = new System.Drawing.Size(279, 50);
            this.temperatureTextbox.TabIndex = 3;
            this.temperatureTextbox.Text = "";
            this.temperatureTextbox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(578, 78);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Against";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(865, 78);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(97, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Manufacturer";
            // 
            // manufacturerTextbox
            // 
            this.manufacturerTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manufacturerTextbox.AnimateReadOnly = false;
            this.manufacturerTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.manufacturerTextbox.Depth = 0;
            this.manufacturerTextbox.Enabled = false;
            this.manufacturerTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.manufacturerTextbox.Hint = "e.g. Ceva";
            this.manufacturerTextbox.LeadingIcon = null;
            this.manufacturerTextbox.Location = new System.Drawing.Point(865, 102);
            this.manufacturerTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manufacturerTextbox.MaxLength = 50;
            this.manufacturerTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.manufacturerTextbox.Multiline = false;
            this.manufacturerTextbox.Name = "manufacturerTextbox";
            this.manufacturerTextbox.Size = new System.Drawing.Size(279, 50);
            this.manufacturerTextbox.TabIndex = 3;
            this.manufacturerTextbox.Text = "";
            this.manufacturerTextbox.TrailingIcon = null;
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
            this.deleteButton.Location = new System.Drawing.Point(203, 634);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(175, 44);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteButton.UseAccentColor = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.editButton.Location = new System.Drawing.Point(18, 634);
            this.editButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.editButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.editButton.Name = "editButton";
            this.editButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editButton.Size = new System.Drawing.Size(175, 44);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editButton.UseAccentColor = false;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
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
            this.finishButton.Location = new System.Drawing.Point(799, 634);
            this.finishButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.finishButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.finishButton.Name = "finishButton";
            this.finishButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.finishButton.Size = new System.Drawing.Size(175, 44);
            this.finishButton.TabIndex = 14;
            this.finishButton.Text = "Close";
            this.finishButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.finishButton.UseAccentColor = false;
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(1165, 689);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.containerPanel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServiceForm";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel costumerLabel;
        private MaterialSkin.Controls.MaterialLabel petLabel;
        private MaterialSkin.Controls.MaterialLabel nextVisitLabel;
        private MaterialSkin.Controls.MaterialComboBox customerCombobox;
        private MaterialSkin.Controls.MaterialComboBox petCombobox;
        private MaterialSkin.Controls.MaterialTextBox weightTextbox;
        private MaterialSkin.Controls.MaterialLabel weightLabel;
        private MaterialSkin.Controls.MaterialLabel temperatureLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker nextVisitDatetime;
        private MaterialSkin.Controls.MaterialLabel serviceLabel;
        private MaterialSkin.Controls.MaterialComboBox serviceCombobox;
        private MaterialSkin.Controls.MaterialButton submitButton;
        private MaterialSkin.Controls.MaterialTextBox againstTextbox;
        private System.Windows.Forms.TableLayoutPanel containerPanel;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialButton editButton;
        private MaterialSkin.Controls.MaterialListView serviceList;
        private MaterialSkin.Controls.MaterialTextBox temperatureTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox manufacturerTextbox;
        private MaterialSkin.Controls.MaterialButton finishButton;
    }
}