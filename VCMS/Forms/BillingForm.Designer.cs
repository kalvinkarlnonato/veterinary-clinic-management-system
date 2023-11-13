﻿namespace VCMS.Forms.Services
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
            this.paymentButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.billsList = new MaterialSkin.Controls.MaterialListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentButton
            // 
            this.paymentButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.paymentButton.AutoSize = false;
            this.paymentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paymentButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.paymentButton.Depth = 0;
            this.paymentButton.HighEmphasis = true;
            this.paymentButton.Icon = null;
            this.paymentButton.Location = new System.Drawing.Point(1021, 6);
            this.paymentButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.paymentButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.paymentButton.Size = new System.Drawing.Size(158, 36);
            this.paymentButton.TabIndex = 3;
            this.paymentButton.Text = "Payment";
            this.paymentButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.paymentButton.UseAccentColor = false;
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = global::VCMS.Properties.Settings.Default.GlobalBackColor;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.paymentButton, 3, 1);
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
            this.billsList.Location = new System.Drawing.Point(3, 51);
            this.billsList.MinimumSize = new System.Drawing.Size(200, 100);
            this.billsList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.billsList.MouseState = MaterialSkin.MouseState.OUT;
            this.billsList.Name = "billsList";
            this.billsList.OwnerDraw = true;
            this.billsList.Size = new System.Drawing.Size(1177, 527);
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
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton paymentButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialListView billsList;
    }
}