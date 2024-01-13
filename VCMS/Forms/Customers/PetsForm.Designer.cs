namespace VCMS.Forms.Customers
{
    partial class PetsForm
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
            this.petsList = new MaterialSkin.Controls.MaterialListView();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.editButton = new MaterialSkin.Controls.MaterialButton();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.searchButton = new MaterialSkin.Controls.MaterialButton();
            this.searchTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.finishButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // petsList
            // 
            this.petsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petsList.AutoSizeTable = false;
            this.petsList.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.petsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.petsList.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.petsList.Depth = 0;
            this.petsList.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petsList.FullRowSelect = true;
            this.petsList.HideSelection = false;
            this.petsList.Location = new System.Drawing.Point(6, 123);
            this.petsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.petsList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.petsList.MouseState = MaterialSkin.MouseState.OUT;
            this.petsList.Name = "petsList";
            this.petsList.OwnerDraw = true;
            this.petsList.Size = new System.Drawing.Size(1010, 440);
            this.petsList.TabIndex = 4;
            this.petsList.UseCompatibleStateImageBehavior = false;
            this.petsList.View = System.Windows.Forms.View.Details;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(942, 78);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(73, 36);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteButton.UseAccentColor = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editButton.Depth = 0;
            this.editButton.HighEmphasis = true;
            this.editButton.Icon = null;
            this.editButton.Location = new System.Drawing.Point(870, 78);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.editButton.Name = "editButton";
            this.editButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editButton.Size = new System.Drawing.Size(64, 36);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "EDIT";
            this.editButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editButton.UseAccentColor = false;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(798, 78);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(64, 36);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "ADD";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchButton.Depth = 0;
            this.searchButton.HighEmphasis = true;
            this.searchButton.Icon = null;
            this.searchButton.Location = new System.Drawing.Point(7, 78);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchButton.Name = "searchButton";
            this.searchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchButton.Size = new System.Drawing.Size(78, 36);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "SEARCH";
            this.searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchButton.UseAccentColor = false;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.AnimateReadOnly = false;
            this.searchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextbox.Depth = 0;
            this.searchTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextbox.Hint = "Search";
            this.searchTextbox.LeadingIcon = null;
            this.searchTextbox.Location = new System.Drawing.Point(92, 67);
            this.searchTextbox.MaxLength = 50;
            this.searchTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchTextbox.Multiline = false;
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(430, 50);
            this.searchTextbox.TabIndex = 7;
            this.searchTextbox.Text = "";
            this.searchTextbox.TrailingIcon = null;
            this.searchTextbox.Visible = false;
            // 
            // finishButton
            // 
            this.finishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.finishButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.finishButton.Depth = 0;
            this.finishButton.HighEmphasis = true;
            this.finishButton.Icon = null;
            this.finishButton.Location = new System.Drawing.Point(948, 572);
            this.finishButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.finishButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.finishButton.Name = "finishButton";
            this.finishButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.finishButton.Size = new System.Drawing.Size(68, 36);
            this.finishButton.TabIndex = 6;
            this.finishButton.Text = "FINISH";
            this.finishButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.finishButton.UseAccentColor = false;
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(1022, 617);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.petsList);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PetsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pets";
            this.Load += new System.EventHandler(this.PetsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView petsList;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialButton editButton;
        private MaterialSkin.Controls.MaterialButton addButton;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialTextBox searchTextbox;
        private MaterialSkin.Controls.MaterialButton finishButton;
    }
}