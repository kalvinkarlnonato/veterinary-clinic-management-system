namespace VCMS.Forms
{
    partial class CustomersForm
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
            this.deleteButton = new FontAwesome.Sharp.IconButton();
            this.editButton = new FontAwesome.Sharp.IconButton();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.searchButton = new FontAwesome.Sharp.IconButton();
            this.containerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.clientsList = new MaterialSkin.Controls.MaterialListView();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deleteButton.IconColor = System.Drawing.Color.Black;
            this.deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteButton.IconSize = 37;
            this.deleteButton.Location = new System.Drawing.Point(1111, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 56);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete (DEL)";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editButton.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.editButton.IconColor = System.Drawing.Color.Black;
            this.editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editButton.IconSize = 37;
            this.editButton.Location = new System.Drawing.Point(1005, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 56);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit (F3)";
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.addButton.IconColor = System.Drawing.Color.Black;
            this.addButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addButton.IconSize = 37;
            this.addButton.Location = new System.Drawing.Point(899, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 56);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add (F2)";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchButton.IconColor = System.Drawing.Color.Black;
            this.searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchButton.IconSize = 37;
            this.searchButton.Location = new System.Drawing.Point(793, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 56);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search (F1)";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.containerPanel.Controls.Add(this.clientsList, 0, 1);
            this.containerPanel.Controls.Add(this.clientsLabel, 0, 0);
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.RowCount = 2;
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerPanel.Size = new System.Drawing.Size(1214, 554);
            this.containerPanel.TabIndex = 0;
            // 
            // clientsList
            // 
            this.clientsList.AutoSizeTable = false;
            this.clientsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.containerPanel.SetColumnSpan(this.clientsList, 5);
            this.clientsList.Depth = 0;
            this.clientsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsList.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsList.FullRowSelect = true;
            this.clientsList.HideSelection = false;
            this.clientsList.Location = new System.Drawing.Point(3, 65);
            this.clientsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.clientsList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.clientsList.MouseState = MaterialSkin.MouseState.OUT;
            this.clientsList.Name = "clientsList";
            this.clientsList.OwnerDraw = true;
            this.clientsList.Size = new System.Drawing.Size(1208, 486);
            this.clientsList.TabIndex = 3;
            this.clientsList.UseCompatibleStateImageBehavior = false;
            this.clientsList.View = System.Windows.Forms.View.Details;
            // 
            // clientsLabel
            // 
            this.clientsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsLabel.Location = new System.Drawing.Point(3, 18);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(204, 25);
            this.clientsLabel.TabIndex = 4;
            this.clientsLabel.Text = "Client\'s Informations";
            // 
            // Costumers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(1214, 554);
            this.ControlBox = false;
            this.Controls.Add(this.containerPanel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Costumers";
            this.Text = "Costumers";
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton deleteButton;
        private FontAwesome.Sharp.IconButton editButton;
        private FontAwesome.Sharp.IconButton addButton;
        private FontAwesome.Sharp.IconButton searchButton;
        private System.Windows.Forms.TableLayoutPanel containerPanel;
        private MaterialSkin.Controls.MaterialListView clientsList;
        private System.Windows.Forms.Label clientsLabel;
    }
}