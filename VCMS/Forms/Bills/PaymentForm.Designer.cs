namespace VCMS.Forms.Bills
{
    partial class PaymentForm
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
            this.amountTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.changeTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.printButton = new MaterialSkin.Controls.MaterialButton();
            this.closeButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 86);
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
            this.materialLabel2.Location = new System.Drawing.Point(6, 161);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Amount";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 236);
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
            this.balanceTextbox.Location = new System.Drawing.Point(9, 108);
            this.balanceTextbox.MaxLength = 50;
            this.balanceTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.balanceTextbox.Multiline = false;
            this.balanceTextbox.Name = "balanceTextbox";
            this.balanceTextbox.ReadOnly = true;
            this.balanceTextbox.Size = new System.Drawing.Size(348, 50);
            this.balanceTextbox.TabIndex = 2;
            this.balanceTextbox.Text = "";
            this.balanceTextbox.TrailingIcon = null;
            // 
            // amountTextbox
            // 
            this.amountTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextbox.AnimateReadOnly = false;
            this.amountTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountTextbox.Depth = 0;
            this.amountTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.amountTextbox.LeadingIcon = null;
            this.amountTextbox.Location = new System.Drawing.Point(9, 183);
            this.amountTextbox.MaxLength = 50;
            this.amountTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.amountTextbox.Multiline = false;
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(348, 50);
            this.amountTextbox.TabIndex = 0;
            this.amountTextbox.Text = "";
            this.amountTextbox.TrailingIcon = null;
            this.amountTextbox.TextChanged += new System.EventHandler(this.AmountTextbox_TextChanged);
            this.amountTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTextbox_KeyPress);
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
            this.changeTextbox.Location = new System.Drawing.Point(9, 258);
            this.changeTextbox.MaxLength = 50;
            this.changeTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.changeTextbox.Multiline = false;
            this.changeTextbox.Name = "changeTextbox";
            this.changeTextbox.ReadOnly = true;
            this.changeTextbox.Size = new System.Drawing.Size(348, 50);
            this.changeTextbox.TabIndex = 1;
            this.changeTextbox.Text = "";
            this.changeTextbox.TrailingIcon = null;
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
            this.printButton.Location = new System.Drawing.Point(238, 317);
            this.printButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.printButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.printButton.Name = "printButton";
            this.printButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.printButton.Size = new System.Drawing.Size(119, 36);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "Print";
            this.printButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.printButton.UseAccentColor = false;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = false;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeButton.Depth = 0;
            this.closeButton.HighEmphasis = true;
            this.closeButton.Icon = null;
            this.closeButton.Location = new System.Drawing.Point(9, 317);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeButton.Size = new System.Drawing.Size(119, 36);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeButton.UseAccentColor = false;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.ClientSize = new System.Drawing.Size(364, 366);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeTextbox);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.balanceTextbox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox balanceTextbox;
        private MaterialSkin.Controls.MaterialTextBox amountTextbox;
        private MaterialSkin.Controls.MaterialTextBox changeTextbox;
        private MaterialSkin.Controls.MaterialButton printButton;
        private MaterialSkin.Controls.MaterialButton closeButton;
    }
}