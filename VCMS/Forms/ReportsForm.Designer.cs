namespace VCMS.Forms
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.reportsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.reportsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.printButton = new MaterialSkin.Controls.MaterialButton();
            this.printBills = new System.Drawing.Printing.PrintDocument();
            this.previewBills = new System.Windows.Forms.PrintPreviewDialog();
            this.printBillsPanel = new System.Windows.Forms.Panel();
            this.reportsList = new MaterialSkin.Controls.MaterialListView();
            this.printBillsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportsComboBox
            // 
            this.reportsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportsComboBox.AutoResize = false;
            this.reportsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reportsComboBox.Depth = 0;
            this.reportsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.reportsComboBox.DropDownHeight = 174;
            this.reportsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportsComboBox.DropDownWidth = 121;
            this.reportsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.reportsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reportsComboBox.FormattingEnabled = true;
            this.reportsComboBox.IntegralHeight = false;
            this.reportsComboBox.ItemHeight = 43;
            this.reportsComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.reportsComboBox.Location = new System.Drawing.Point(177, 12);
            this.reportsComboBox.MaxDropDownItems = 4;
            this.reportsComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.reportsComboBox.Name = "reportsComboBox";
            this.reportsComboBox.Size = new System.Drawing.Size(810, 49);
            this.reportsComboBox.StartIndex = 0;
            this.reportsComboBox.TabIndex = 2;
            this.reportsComboBox.SelectedIndexChanged += new System.EventHandler(this.ReportsComboBox_SelectedIndexChanged);
            // 
            // reportsLabel
            // 
            this.reportsLabel.AutoSize = true;
            this.reportsLabel.Depth = 0;
            this.reportsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.reportsLabel.Location = new System.Drawing.Point(12, 27);
            this.reportsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.reportsLabel.Name = "reportsLabel";
            this.reportsLabel.Size = new System.Drawing.Size(99, 19);
            this.reportsLabel.TabIndex = 4;
            this.reportsLabel.Text = "List of reports";
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.AutoSize = false;
            this.printButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.printButton.Depth = 0;
            this.printButton.HighEmphasis = true;
            this.printButton.Icon = null;
            this.printButton.Location = new System.Drawing.Point(994, 17);
            this.printButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.printButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.printButton.Name = "printButton";
            this.printButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.printButton.Size = new System.Drawing.Size(120, 36);
            this.printButton.TabIndex = 5;
            this.printButton.Text = "Print";
            this.printButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.printButton.UseAccentColor = false;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // previewBills
            // 
            this.previewBills.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.previewBills.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.previewBills.ClientSize = new System.Drawing.Size(400, 300);
            this.previewBills.Enabled = true;
            this.previewBills.Icon = ((System.Drawing.Icon)(resources.GetObject("previewBills.Icon")));
            this.previewBills.Name = "previewBills";
            this.previewBills.Visible = false;
            // 
            // printBillsPanel
            // 
            this.printBillsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printBillsPanel.Controls.Add(this.reportsList);
            this.printBillsPanel.Location = new System.Drawing.Point(1, 67);
            this.printBillsPanel.Name = "printBillsPanel";
            this.printBillsPanel.Size = new System.Drawing.Size(1126, 653);
            this.printBillsPanel.TabIndex = 6;
            // 
            // reportsList
            // 
            this.reportsList.AutoSizeTable = false;
            this.reportsList.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.reportsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportsList.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.reportsList.Depth = 0;
            this.reportsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsList.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsList.FullRowSelect = true;
            this.reportsList.HideSelection = false;
            this.reportsList.Location = new System.Drawing.Point(0, 0);
            this.reportsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.reportsList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.reportsList.MouseState = MaterialSkin.MouseState.OUT;
            this.reportsList.Name = "reportsList";
            this.reportsList.OwnerDraw = true;
            this.reportsList.Size = new System.Drawing.Size(1126, 653);
            this.reportsList.TabIndex = 4;
            this.reportsList.UseCompatibleStateImageBehavior = false;
            this.reportsList.View = System.Windows.Forms.View.Details;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(1127, 721);
            this.ControlBox = false;
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.reportsLabel);
            this.Controls.Add(this.reportsComboBox);
            this.Controls.Add(this.printBillsPanel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportsForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Sizable = false;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.printBillsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox reportsComboBox;
        private MaterialSkin.Controls.MaterialLabel reportsLabel;
        private MaterialSkin.Controls.MaterialButton printButton;
        private System.Drawing.Printing.PrintDocument printBills;
        private System.Windows.Forms.PrintPreviewDialog previewBills;
        private System.Windows.Forms.Panel printBillsPanel;
        private MaterialSkin.Controls.MaterialListView reportsList;
    }
}