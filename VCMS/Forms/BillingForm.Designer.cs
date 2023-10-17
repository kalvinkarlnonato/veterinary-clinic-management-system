namespace VCMS.Forms.Services
{
    partial class BillingForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.balanceTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.paymentTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.changeTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.printButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.billsList = new MaterialSkin.Controls.MaterialListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Balance";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(298, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Payment";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(593, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Change";
            // 
            // balanceTextbox
            // 
            this.balanceTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceTextbox.AnimateReadOnly = false;
            this.balanceTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balanceTextbox.Depth = 0;
            this.balanceTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.balanceTextbox.LeadingIcon = null;
            this.balanceTextbox.Location = new System.Drawing.Point(3, 22);
            this.balanceTextbox.MaxLength = 50;
            this.balanceTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.balanceTextbox.Multiline = false;
            this.balanceTextbox.Name = "balanceTextbox";
            this.balanceTextbox.ReadOnly = true;
            this.balanceTextbox.Size = new System.Drawing.Size(289, 50);
            this.balanceTextbox.TabIndex = 2;
            this.balanceTextbox.Text = "";
            this.balanceTextbox.TrailingIcon = null;
            // 
            // paymentTextbox
            // 
            this.paymentTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentTextbox.AnimateReadOnly = false;
            this.paymentTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentTextbox.Depth = 0;
            this.paymentTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.paymentTextbox.LeadingIcon = null;
            this.paymentTextbox.Location = new System.Drawing.Point(298, 22);
            this.paymentTextbox.MaxLength = 50;
            this.paymentTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.paymentTextbox.Multiline = false;
            this.paymentTextbox.Name = "paymentTextbox";
            this.paymentTextbox.Size = new System.Drawing.Size(289, 50);
            this.paymentTextbox.TabIndex = 2;
            this.paymentTextbox.Text = "";
            this.paymentTextbox.TrailingIcon = null;
            // 
            // changeTextbox
            // 
            this.changeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeTextbox.AnimateReadOnly = false;
            this.changeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changeTextbox.Depth = 0;
            this.changeTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.changeTextbox.LeadingIcon = null;
            this.changeTextbox.Location = new System.Drawing.Point(593, 22);
            this.changeTextbox.MaxLength = 50;
            this.changeTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.changeTextbox.Multiline = false;
            this.changeTextbox.Name = "changeTextbox";
            this.changeTextbox.Size = new System.Drawing.Size(289, 50);
            this.changeTextbox.TabIndex = 2;
            this.changeTextbox.Text = "";
            this.changeTextbox.TrailingIcon = null;
            // 
            // printButton
            // 
            this.printButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.printButton.AutoSize = false;
            this.printButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.printButton.Depth = 0;
            this.printButton.HighEmphasis = true;
            this.printButton.Icon = null;
            this.printButton.Location = new System.Drawing.Point(1021, 29);
            this.printButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.printButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.printButton.Name = "printButton";
            this.printButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.printButton.Size = new System.Drawing.Size(158, 36);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "PRINT";
            this.printButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.printButton.UseAccentColor = false;
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.balanceTextbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.changeTextbox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.paymentTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.printButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.billsList, 0, 2);
            this.tableLayoutPanel1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1183, 581);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // billsList
            // 
            this.billsList.AutoSizeTable = false;
            this.billsList.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.billsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.billsList, 4);
            this.billsList.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.billsList.Depth = 0;
            this.billsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billsList.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsList.FullRowSelect = true;
            this.billsList.HideSelection = false;
            this.billsList.Location = new System.Drawing.Point(3, 78);
            this.billsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.billsList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.billsList.MouseState = MaterialSkin.MouseState.OUT;
            this.billsList.Name = "billsList";
            this.billsList.OwnerDraw = true;
            this.billsList.Size = new System.Drawing.Size(1177, 500);
            this.billsList.TabIndex = 4;
            this.billsList.UseCompatibleStateImageBehavior = false;
            this.billsList.View = System.Windows.Forms.View.Details;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 581);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BillingForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "Billings";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox balanceTextbox;
        private MaterialSkin.Controls.MaterialTextBox paymentTextbox;
        private MaterialSkin.Controls.MaterialTextBox changeTextbox;
        private MaterialSkin.Controls.MaterialButton printButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialListView billsList;
    }
}