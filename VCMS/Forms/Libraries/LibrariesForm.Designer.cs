namespace VCMS.Forms.Libraries
{
    partial class LibrariesForm
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
            this.speciesList = new System.Windows.Forms.ListBox();
            this.speciesTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.servicesTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.servicesList = new System.Windows.Forms.ListBox();
            this.breedList = new System.Windows.Forms.ListBox();
            this.breedTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.addSpeciesButton = new MaterialSkin.Controls.MaterialButton();
            this.addBreedButton = new MaterialSkin.Controls.MaterialButton();
            this.addServicesButton = new MaterialSkin.Controls.MaterialButton();
            this.doneButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // speciesList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.speciesList, 2);
            this.speciesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speciesList.FormattingEnabled = true;
            this.speciesList.ItemHeight = 16;
            this.speciesList.Location = new System.Drawing.Point(3, 59);
            this.speciesList.Name = "speciesList";
            this.speciesList.Size = new System.Drawing.Size(269, 350);
            this.speciesList.TabIndex = 0;
            this.speciesList.SelectedIndexChanged += new System.EventHandler(this.SpeciesList_SelectedIndexChanged);
            this.speciesList.DoubleClick += new System.EventHandler(this.SpeciesList_DoubleClick);
            this.speciesList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpeciesList_KeyDown);
            // 
            // speciesTextbox
            // 
            this.speciesTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.speciesTextbox.AnimateReadOnly = false;
            this.speciesTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.speciesTextbox.Depth = 0;
            this.speciesTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.speciesTextbox.Hint = "Species";
            this.speciesTextbox.LeadingIcon = null;
            this.speciesTextbox.Location = new System.Drawing.Point(3, 3);
            this.speciesTextbox.MaxLength = 50;
            this.speciesTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.speciesTextbox.Multiline = false;
            this.speciesTextbox.Name = "speciesTextbox";
            this.speciesTextbox.Size = new System.Drawing.Size(201, 50);
            this.speciesTextbox.TabIndex = 1;
            this.speciesTextbox.Tag = "Species";
            this.speciesTextbox.Text = "";
            this.speciesTextbox.TrailingIcon = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.Controls.Add(this.speciesList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.speciesTextbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.servicesTextbox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.servicesList, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.breedList, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.breedTextbox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addSpeciesButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addBreedButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.addServicesButton, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 412);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // servicesTextbox
            // 
            this.servicesTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesTextbox.AnimateReadOnly = false;
            this.servicesTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicesTextbox.Depth = 0;
            this.servicesTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.servicesTextbox.Hint = "Services";
            this.servicesTextbox.LeadingIcon = null;
            this.servicesTextbox.Location = new System.Drawing.Point(553, 3);
            this.servicesTextbox.MaxLength = 50;
            this.servicesTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.servicesTextbox.Multiline = false;
            this.servicesTextbox.Name = "servicesTextbox";
            this.servicesTextbox.Size = new System.Drawing.Size(201, 50);
            this.servicesTextbox.TabIndex = 1;
            this.servicesTextbox.Text = "";
            this.servicesTextbox.TrailingIcon = null;
            // 
            // servicesList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.servicesList, 2);
            this.servicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesList.FormattingEnabled = true;
            this.servicesList.ItemHeight = 16;
            this.servicesList.Location = new System.Drawing.Point(553, 59);
            this.servicesList.Name = "servicesList";
            this.servicesList.Size = new System.Drawing.Size(272, 350);
            this.servicesList.TabIndex = 0;
            this.servicesList.DoubleClick += new System.EventHandler(this.ServicesList_DoubleClick);
            this.servicesList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ServicesList_KeyDown);
            // 
            // breedList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.breedList, 2);
            this.breedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breedList.FormattingEnabled = true;
            this.breedList.ItemHeight = 16;
            this.breedList.Location = new System.Drawing.Point(278, 59);
            this.breedList.Name = "breedList";
            this.breedList.Size = new System.Drawing.Size(269, 350);
            this.breedList.TabIndex = 0;
            this.breedList.DoubleClick += new System.EventHandler(this.BreedList_DoubleClick);
            this.breedList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BreedList_KeyDown);
            // 
            // breedTextbox
            // 
            this.breedTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.breedTextbox.AnimateReadOnly = false;
            this.breedTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.breedTextbox.Depth = 0;
            this.breedTextbox.Enabled = false;
            this.breedTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.breedTextbox.Hint = "Breed";
            this.breedTextbox.LeadingIcon = null;
            this.breedTextbox.Location = new System.Drawing.Point(278, 3);
            this.breedTextbox.MaxLength = 50;
            this.breedTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.breedTextbox.Multiline = false;
            this.breedTextbox.Name = "breedTextbox";
            this.breedTextbox.Size = new System.Drawing.Size(201, 50);
            this.breedTextbox.TabIndex = 1;
            this.breedTextbox.Text = "";
            this.breedTextbox.TrailingIcon = null;
            // 
            // addSpeciesButton
            // 
            this.addSpeciesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addSpeciesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addSpeciesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addSpeciesButton.Depth = 0;
            this.addSpeciesButton.HighEmphasis = true;
            this.addSpeciesButton.Icon = null;
            this.addSpeciesButton.Location = new System.Drawing.Point(211, 10);
            this.addSpeciesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addSpeciesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addSpeciesButton.Name = "addSpeciesButton";
            this.addSpeciesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addSpeciesButton.Size = new System.Drawing.Size(60, 36);
            this.addSpeciesButton.TabIndex = 4;
            this.addSpeciesButton.Text = "add";
            this.addSpeciesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addSpeciesButton.UseAccentColor = false;
            this.addSpeciesButton.UseVisualStyleBackColor = true;
            this.addSpeciesButton.Click += new System.EventHandler(this.AddSpeciesButton_Click);
            // 
            // addBreedButton
            // 
            this.addBreedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addBreedButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBreedButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addBreedButton.Depth = 0;
            this.addBreedButton.Enabled = false;
            this.addBreedButton.HighEmphasis = true;
            this.addBreedButton.Icon = null;
            this.addBreedButton.Location = new System.Drawing.Point(486, 10);
            this.addBreedButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addBreedButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBreedButton.Name = "addBreedButton";
            this.addBreedButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addBreedButton.Size = new System.Drawing.Size(60, 36);
            this.addBreedButton.TabIndex = 4;
            this.addBreedButton.Text = "add";
            this.addBreedButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addBreedButton.UseAccentColor = false;
            this.addBreedButton.UseVisualStyleBackColor = true;
            this.addBreedButton.Click += new System.EventHandler(this.AddBreedButton_Click);
            // 
            // addServicesButton
            // 
            this.addServicesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addServicesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addServicesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addServicesButton.Depth = 0;
            this.addServicesButton.HighEmphasis = true;
            this.addServicesButton.Icon = null;
            this.addServicesButton.Location = new System.Drawing.Point(761, 10);
            this.addServicesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addServicesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addServicesButton.Name = "addServicesButton";
            this.addServicesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addServicesButton.Size = new System.Drawing.Size(63, 36);
            this.addServicesButton.TabIndex = 4;
            this.addServicesButton.Text = "add";
            this.addServicesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addServicesButton.UseAccentColor = false;
            this.addServicesButton.UseVisualStyleBackColor = true;
            this.addServicesButton.Click += new System.EventHandler(this.AddServicesButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.AutoSize = false;
            this.doneButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.doneButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.doneButton.Depth = 0;
            this.doneButton.HighEmphasis = true;
            this.doneButton.Icon = null;
            this.doneButton.Location = new System.Drawing.Point(714, 503);
            this.doneButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.doneButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.doneButton.Name = "doneButton";
            this.doneButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.doneButton.Size = new System.Drawing.Size(121, 36);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "done";
            this.doneButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.doneButton.UseAccentColor = false;
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // LibrariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(842, 547);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(628, 389);
            this.Name = "LibrariesForm";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libraries";
            this.Load += new System.EventHandler(this.LibrariesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox speciesList;
        private MaterialSkin.Controls.MaterialTextBox speciesTextbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox breedTextbox;
        private MaterialSkin.Controls.MaterialTextBox servicesTextbox;
        private System.Windows.Forms.ListBox breedList;
        private System.Windows.Forms.ListBox servicesList;
        private MaterialSkin.Controls.MaterialButton addSpeciesButton;
        private MaterialSkin.Controls.MaterialButton addBreedButton;
        private MaterialSkin.Controls.MaterialButton addServicesButton;
        private MaterialSkin.Controls.MaterialButton doneButton;
    }
}