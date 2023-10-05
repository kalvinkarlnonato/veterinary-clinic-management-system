namespace VCMS.Forms
{
    partial class ReceptionistForm
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
            this.receptionistsLabel = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new FontAwesome.Sharp.IconButton();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.editButton = new FontAwesome.Sharp.IconButton();
            this.deleteButton = new FontAwesome.Sharp.IconButton();
            this.receptionistsList = new MaterialSkin.Controls.MaterialListView();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // receptionistsLabel
            // 
            this.receptionistsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.receptionistsLabel.AutoSize = true;
            this.receptionistsLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receptionistsLabel.Location = new System.Drawing.Point(3, 18);
            this.receptionistsLabel.Name = "receptionistsLabel";
            this.receptionistsLabel.Size = new System.Drawing.Size(195, 25);
            this.receptionistsLabel.TabIndex = 4;
            this.receptionistsLabel.Text = "Staff\'s Informations";
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
            this.containerPanel.Controls.Add(this.receptionistsList, 0, 1);
            this.containerPanel.Controls.Add(this.receptionistsLabel, 0, 0);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.RowCount = 2;
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerPanel.Size = new System.Drawing.Size(816, 456);
            this.containerPanel.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchButton.IconColor = System.Drawing.Color.Black;
            this.searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchButton.IconSize = 37;
            this.searchButton.Location = new System.Drawing.Point(395, 3);
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
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.addButton.IconColor = System.Drawing.Color.Black;
            this.addButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addButton.IconSize = 37;
            this.addButton.Location = new System.Drawing.Point(501, 3);
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
            this.editButton.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.editButton.IconColor = System.Drawing.Color.Black;
            this.editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editButton.IconSize = 37;
            this.editButton.Location = new System.Drawing.Point(607, 3);
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
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deleteButton.IconColor = System.Drawing.Color.Black;
            this.deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteButton.IconSize = 37;
            this.deleteButton.Location = new System.Drawing.Point(713, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 56);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete (DEL)";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // receptionistsList
            // 
            this.receptionistsList.AutoSizeTable = false;
            this.receptionistsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.receptionistsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.containerPanel.SetColumnSpan(this.receptionistsList, 5);
            this.receptionistsList.Depth = 0;
            this.receptionistsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receptionistsList.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receptionistsList.FullRowSelect = true;
            this.receptionistsList.HideSelection = false;
            this.receptionistsList.Location = new System.Drawing.Point(3, 65);
            this.receptionistsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.receptionistsList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.receptionistsList.MouseState = MaterialSkin.MouseState.OUT;
            this.receptionistsList.Name = "receptionistsList";
            this.receptionistsList.OwnerDraw = true;
            this.receptionistsList.Size = new System.Drawing.Size(810, 388);
            this.receptionistsList.TabIndex = 3;
            this.receptionistsList.UseCompatibleStateImageBehavior = false;
            this.receptionistsList.View = System.Windows.Forms.View.Details;
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(816, 456);
            this.Controls.Add(this.containerPanel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReceptionistForm";
            this.Text = "ReceptionistForm";
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label receptionistsLabel;
        private System.Windows.Forms.TableLayoutPanel containerPanel;
        private FontAwesome.Sharp.IconButton searchButton;
        private FontAwesome.Sharp.IconButton addButton;
        private FontAwesome.Sharp.IconButton editButton;
        private FontAwesome.Sharp.IconButton deleteButton;
        private MaterialSkin.Controls.MaterialListView receptionistsList;
    }
}