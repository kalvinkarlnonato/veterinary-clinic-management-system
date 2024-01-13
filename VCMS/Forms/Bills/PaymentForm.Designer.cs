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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.amountTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.printButton = new MaterialSkin.Controls.MaterialButton();
            this.closeButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 80);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Payment";
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
            this.amountTextbox.Location = new System.Drawing.Point(9, 110);
            this.amountTextbox.MaxLength = 50;
            this.amountTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.amountTextbox.Multiline = false;
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(348, 50);
            this.amountTextbox.TabIndex = 0;
            this.amountTextbox.Text = "";
            this.amountTextbox.TrailingIcon = null;
            this.amountTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTextbox_KeyPress);
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
            this.printButton.Location = new System.Drawing.Point(238, 175);
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
            this.closeButton.Location = new System.Drawing.Point(9, 175);
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
            this.ClientSize = new System.Drawing.Size(367, 225);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.materialLabel2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::VCMS.Properties.Settings.Default, "GlobalBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox amountTextbox;
        private MaterialSkin.Controls.MaterialButton printButton;
        private MaterialSkin.Controls.MaterialButton closeButton;
    }
}