namespace VCMS.Forms
{
    partial class DoctorsForm
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
            this.containerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new FontAwesome.Sharp.IconButton();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.editButton = new FontAwesome.Sharp.IconButton();
            this.deleteButton = new FontAwesome.Sharp.IconButton();
            this.doctorsList = new MaterialSkin.Controls.MaterialListView();
            this.doctorsLabel = new System.Windows.Forms.Label();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.ColumnCount = 5;
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.containerPanel.Controls.Add(this.searchButton, 1, 0);
            this.containerPanel.Controls.Add(this.addButton, 2, 0);
            this.containerPanel.Controls.Add(this.editButton, 3, 0);
            this.containerPanel.Controls.Add(this.deleteButton, 4, 0);
            this.containerPanel.Controls.Add(this.doctorsList, 0, 1);
            this.containerPanel.Controls.Add(this.doctorsLabel, 0, 0);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.RowCount = 2;
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerPanel.Size = new System.Drawing.Size(933, 554);
            this.containerPanel.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchButton.IconColor = System.Drawing.Color.Black;
            this.searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchButton.IconSize = 37;
            this.searchButton.Location = new System.Drawing.Point(512, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 56);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search (F1)";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.addButton.IconColor = System.Drawing.Color.Black;
            this.addButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addButton.IconSize = 37;
            this.addButton.Location = new System.Drawing.Point(618, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 56);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add (F2)";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editButton.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.editButton.IconColor = System.Drawing.Color.Black;
            this.editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editButton.IconSize = 37;
            this.editButton.Location = new System.Drawing.Point(724, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 56);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit (F3)";
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deleteButton.IconColor = System.Drawing.Color.Black;
            this.deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteButton.IconSize = 37;
            this.deleteButton.Location = new System.Drawing.Point(830, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 56);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete (DEL)";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // doctorsList
            // 
            this.doctorsList.AutoSizeTable = false;
            this.doctorsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.doctorsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.containerPanel.SetColumnSpan(this.doctorsList, 5);
            this.doctorsList.Depth = 0;
            this.doctorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorsList.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsList.FullRowSelect = true;
            this.doctorsList.HideSelection = false;
            this.doctorsList.Location = new System.Drawing.Point(3, 65);
            this.doctorsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.doctorsList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.doctorsList.MouseState = MaterialSkin.MouseState.OUT;
            this.doctorsList.Name = "doctorsList";
            this.doctorsList.OwnerDraw = true;
            this.doctorsList.Size = new System.Drawing.Size(927, 486);
            this.doctorsList.TabIndex = 3;
            this.doctorsList.UseCompatibleStateImageBehavior = false;
            this.doctorsList.View = System.Windows.Forms.View.Details;
            // 
            // doctorsLabel
            // 
            this.doctorsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.doctorsLabel.AutoSize = true;
            this.doctorsLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsLabel.Location = new System.Drawing.Point(3, 18);
            this.doctorsLabel.Name = "doctorsLabel";
            this.doctorsLabel.Size = new System.Drawing.Size(212, 25);
            this.doctorsLabel.TabIndex = 4;
            this.doctorsLabel.Text = "Doctor\'s Informations";
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.ControlBox = false;
            this.Controls.Add(this.containerPanel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoctorsForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "Doctors";
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel containerPanel;
        private FontAwesome.Sharp.IconButton searchButton;
        private FontAwesome.Sharp.IconButton addButton;
        private FontAwesome.Sharp.IconButton editButton;
        private FontAwesome.Sharp.IconButton deleteButton;
        private MaterialSkin.Controls.MaterialListView doctorsList;
        private System.Windows.Forms.Label doctorsLabel;
    }
}