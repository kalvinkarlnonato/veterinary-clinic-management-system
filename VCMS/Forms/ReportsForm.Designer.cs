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
            this.reportsList = new MaterialSkin.Controls.MaterialListView();
            this.reportsLabel = new System.Windows.Forms.Label();
            this.reportsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // reportsList
            // 
            this.reportsList.AutoSizeTable = false;
            this.reportsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reportsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportsList.Depth = 0;
            this.reportsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportsList.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsList.FullRowSelect = true;
            this.reportsList.HideSelection = false;
            this.reportsList.Location = new System.Drawing.Point(0, 67);
            this.reportsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.reportsList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.reportsList.MouseState = MaterialSkin.MouseState.OUT;
            this.reportsList.Name = "reportsList";
            this.reportsList.OwnerDraw = true;
            this.reportsList.Size = new System.Drawing.Size(811, 373);
            this.reportsList.TabIndex = 3;
            this.reportsList.UseCompatibleStateImageBehavior = false;
            this.reportsList.View = System.Windows.Forms.View.Details;
            // 
            // reportsLabel
            // 
            this.reportsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reportsLabel.AutoSize = true;
            this.reportsLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsLabel.Location = new System.Drawing.Point(2, 22);
            this.reportsLabel.Name = "reportsLabel";
            this.reportsLabel.Size = new System.Drawing.Size(141, 25);
            this.reportsLabel.TabIndex = 4;
            this.reportsLabel.Text = "List of reports";
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
            this.reportsComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.reportsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reportsComboBox.FormattingEnabled = true;
            this.reportsComboBox.Hint = "[Select report]";
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
            this.reportsComboBox.Size = new System.Drawing.Size(622, 49);
            this.reportsComboBox.StartIndex = 0;
            this.reportsComboBox.TabIndex = 2;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(811, 440);
            this.ControlBox = false;
            this.Controls.Add(this.reportsList);
            this.Controls.Add(this.reportsComboBox);
            this.Controls.Add(this.reportsLabel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::VCMS.Properties.Settings.Default, "GlobalFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::VCMS.Properties.Settings.Default, "GlobalFontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::VCMS.Properties.Settings.Default.GlobalFontStyle;
            this.ForeColor = global::VCMS.Properties.Settings.Default.GlobalFontColor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportsForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "ReportsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialListView reportsList;
        private System.Windows.Forms.Label reportsLabel;
        private MaterialSkin.Controls.MaterialComboBox reportsComboBox;
    }
}