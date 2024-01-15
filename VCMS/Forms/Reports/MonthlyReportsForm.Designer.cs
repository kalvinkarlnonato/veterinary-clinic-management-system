namespace VCMS.Forms.Reports
{
    partial class MonthlyReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyReportsForm));
            this.printBillsPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.payTitle = new System.Windows.Forms.Label();
            this.paySubTitle = new System.Windows.Forms.Label();
            this.payAddressTitle = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.div1 = new System.Windows.Forms.Label();
            this.invoiceNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.petName = new System.Windows.Forms.Label();
            this.petTitle1 = new System.Windows.Forms.Label();
            this.petTitle2 = new System.Windows.Forms.Label();
            this.petTitle3 = new System.Windows.Forms.Label();
            this.petTitle4 = new System.Windows.Forms.Label();
            this.petTitle5 = new System.Windows.Forms.Label();
            this.petData1 = new System.Windows.Forms.Label();
            this.petData2 = new System.Windows.Forms.Label();
            this.petData3 = new System.Windows.Forms.Label();
            this.petData4 = new System.Windows.Forms.Label();
            this.petData5 = new System.Windows.Forms.Label();
            this.printBills = new System.Drawing.Printing.PrintDocument();
            this.previewBills = new System.Windows.Forms.PrintPreviewDialog();
            this.printBillsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // printBillsPanel
            // 
            this.printBillsPanel.BackColor = System.Drawing.Color.White;
            this.printBillsPanel.Controls.Add(this.mainPanel);
            this.printBillsPanel.Location = new System.Drawing.Point(1, 2);
            this.printBillsPanel.Name = "printBillsPanel";
            this.printBillsPanel.Size = new System.Drawing.Size(1050, 780);
            this.printBillsPanel.TabIndex = 3;
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 5;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.Controls.Add(this.payTitle, 0, 0);
            this.mainPanel.Controls.Add(this.paySubTitle, 0, 1);
            this.mainPanel.Controls.Add(this.payAddressTitle, 0, 2);
            this.mainPanel.Controls.Add(this.clientLabel, 0, 3);
            this.mainPanel.Controls.Add(this.div1, 0, 4);
            this.mainPanel.Controls.Add(this.invoiceNum, 0, 5);
            this.mainPanel.Controls.Add(this.label1, 0, 6);
            this.mainPanel.Controls.Add(this.petName, 0, 7);
            this.mainPanel.Controls.Add(this.petTitle1, 0, 8);
            this.mainPanel.Controls.Add(this.petTitle2, 1, 8);
            this.mainPanel.Controls.Add(this.petTitle3, 2, 8);
            this.mainPanel.Controls.Add(this.petTitle4, 3, 8);
            this.mainPanel.Controls.Add(this.petTitle5, 4, 8);
            this.mainPanel.Controls.Add(this.petData1, 0, 9);
            this.mainPanel.Controls.Add(this.petData2, 1, 9);
            this.mainPanel.Controls.Add(this.petData3, 2, 9);
            this.mainPanel.Controls.Add(this.petData4, 3, 9);
            this.mainPanel.Controls.Add(this.petData5, 4, 9);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 10;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.Size = new System.Drawing.Size(1050, 780);
            this.mainPanel.TabIndex = 0;
            // 
            // payTitle
            // 
            this.payTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.payTitle.AutoSize = true;
            this.mainPanel.SetColumnSpan(this.payTitle, 5);
            this.payTitle.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payTitle.Location = new System.Drawing.Point(3, 0);
            this.payTitle.Name = "payTitle";
            this.payTitle.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.payTitle.Size = new System.Drawing.Size(1044, 53);
            this.payTitle.TabIndex = 1;
            this.payTitle.Text = "SNIFFS && LICKS";
            this.payTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paySubTitle
            // 
            this.paySubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paySubTitle.AutoSize = true;
            this.mainPanel.SetColumnSpan(this.paySubTitle, 5);
            this.paySubTitle.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paySubTitle.Location = new System.Drawing.Point(3, 53);
            this.paySubTitle.Name = "paySubTitle";
            this.paySubTitle.Size = new System.Drawing.Size(1044, 22);
            this.paySubTitle.TabIndex = 2;
            this.paySubTitle.Text = "VETERINARY CLINIC";
            this.paySubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payAddressTitle
            // 
            this.payAddressTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.payAddressTitle.AutoSize = true;
            this.mainPanel.SetColumnSpan(this.payAddressTitle, 5);
            this.payAddressTitle.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payAddressTitle.Location = new System.Drawing.Point(3, 75);
            this.payAddressTitle.Name = "payAddressTitle";
            this.payAddressTitle.Size = new System.Drawing.Size(1044, 32);
            this.payAddressTitle.TabIndex = 3;
            this.payAddressTitle.Text = "#44 Maxlen Bld. Maharlika Highway,\r\nTanza, Tuguegarao City";
            this.payAddressTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientLabel
            // 
            this.clientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clientLabel.AutoSize = true;
            this.mainPanel.SetColumnSpan(this.clientLabel, 5);
            this.clientLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.Gray;
            this.clientLabel.Location = new System.Drawing.Point(3, 107);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(1044, 16);
            this.clientLabel.TabIndex = 4;
            this.clientLabel.Text = "Report form";
            // 
            // div1
            // 
            this.div1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.SetColumnSpan(this.div1, 5);
            this.div1.ForeColor = System.Drawing.Color.Gray;
            this.div1.Location = new System.Drawing.Point(3, 123);
            this.div1.Name = "div1";
            this.div1.Size = new System.Drawing.Size(1044, 15);
            this.div1.TabIndex = 7;
            this.div1.Text = "――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――";
            this.div1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoiceNum
            // 
            this.mainPanel.SetColumnSpan(this.invoiceNum, 5);
            this.invoiceNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNum.Location = new System.Drawing.Point(3, 138);
            this.invoiceNum.Name = "invoiceNum";
            this.invoiceNum.Size = new System.Drawing.Size(1044, 32);
            this.invoiceNum.TabIndex = 8;
            this.invoiceNum.Text = "January";
            this.invoiceNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.SetColumnSpan(this.label1, 5);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1044, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petName
            // 
            this.petName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.petName.AutoSize = true;
            this.mainPanel.SetColumnSpan(this.petName, 5);
            this.petName.Location = new System.Drawing.Point(3, 185);
            this.petName.Name = "petName";
            this.petName.Size = new System.Drawing.Size(1044, 13);
            this.petName.TabIndex = 26;
            this.petName.Text = "Printed date:";
            // 
            // petTitle1
            // 
            this.petTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTitle1.AutoSize = true;
            this.petTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petTitle1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTitle1.ForeColor = System.Drawing.Color.Gray;
            this.petTitle1.Location = new System.Drawing.Point(3, 198);
            this.petTitle1.Name = "petTitle1";
            this.petTitle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.petTitle1.Size = new System.Drawing.Size(204, 28);
            this.petTitle1.TabIndex = 28;
            this.petTitle1.Text = "Date";
            this.petTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petTitle2
            // 
            this.petTitle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTitle2.AutoSize = true;
            this.petTitle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petTitle2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTitle2.ForeColor = System.Drawing.Color.Gray;
            this.petTitle2.Location = new System.Drawing.Point(213, 198);
            this.petTitle2.Name = "petTitle2";
            this.petTitle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.petTitle2.Size = new System.Drawing.Size(204, 28);
            this.petTitle2.TabIndex = 29;
            this.petTitle2.Text = "Service";
            this.petTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petTitle3
            // 
            this.petTitle3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTitle3.AutoSize = true;
            this.petTitle3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petTitle3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTitle3.ForeColor = System.Drawing.Color.Gray;
            this.petTitle3.Location = new System.Drawing.Point(423, 198);
            this.petTitle3.Name = "petTitle3";
            this.petTitle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.petTitle3.Size = new System.Drawing.Size(204, 28);
            this.petTitle3.TabIndex = 30;
            this.petTitle3.Text = "WT/Complaint";
            this.petTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petTitle4
            // 
            this.petTitle4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTitle4.AutoSize = true;
            this.petTitle4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petTitle4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTitle4.ForeColor = System.Drawing.Color.Gray;
            this.petTitle4.Location = new System.Drawing.Point(633, 198);
            this.petTitle4.Name = "petTitle4";
            this.petTitle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.petTitle4.Size = new System.Drawing.Size(204, 28);
            this.petTitle4.TabIndex = 31;
            this.petTitle4.Text = "Against/Findings";
            this.petTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petTitle5
            // 
            this.petTitle5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTitle5.AutoSize = true;
            this.petTitle5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.petTitle5.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTitle5.ForeColor = System.Drawing.Color.Gray;
            this.petTitle5.Location = new System.Drawing.Point(843, 198);
            this.petTitle5.Name = "petTitle5";
            this.petTitle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.petTitle5.Size = new System.Drawing.Size(204, 28);
            this.petTitle5.TabIndex = 32;
            this.petTitle5.Text = "Manufacturer/Results";
            this.petTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petData1
            // 
            this.petData1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petData1.AutoSize = true;
            this.petData1.Location = new System.Drawing.Point(3, 226);
            this.petData1.Name = "petData1";
            this.petData1.Size = new System.Drawing.Size(204, 13);
            this.petData1.TabIndex = 33;
            // 
            // petData2
            // 
            this.petData2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petData2.AutoSize = true;
            this.petData2.Location = new System.Drawing.Point(213, 226);
            this.petData2.Name = "petData2";
            this.petData2.Size = new System.Drawing.Size(204, 13);
            this.petData2.TabIndex = 34;
            this.petData2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // petData3
            // 
            this.petData3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petData3.AutoSize = true;
            this.petData3.Location = new System.Drawing.Point(423, 226);
            this.petData3.Name = "petData3";
            this.petData3.Size = new System.Drawing.Size(204, 13);
            this.petData3.TabIndex = 35;
            this.petData3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // petData4
            // 
            this.petData4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petData4.AutoSize = true;
            this.petData4.Location = new System.Drawing.Point(633, 226);
            this.petData4.Name = "petData4";
            this.petData4.Size = new System.Drawing.Size(204, 13);
            this.petData4.TabIndex = 36;
            this.petData4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // petData5
            // 
            this.petData5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petData5.AutoSize = true;
            this.petData5.Location = new System.Drawing.Point(843, 226);
            this.petData5.Name = "petData5";
            this.petData5.Size = new System.Drawing.Size(204, 13);
            this.petData5.TabIndex = 37;
            this.petData5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // MonthlyReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 782);
            this.Controls.Add(this.printBillsPanel);
            this.Name = "MonthlyReportsForm";
            this.Text = "MonthlyReportsForm";
            this.Load += new System.EventHandler(this.MonthlyReportsForm_Load);
            this.printBillsPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel printBillsPanel;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Label payTitle;
        private System.Windows.Forms.Label paySubTitle;
        private System.Windows.Forms.Label payAddressTitle;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label div1;
        private System.Windows.Forms.Label invoiceNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label petName;
        private System.Windows.Forms.Label petTitle1;
        private System.Windows.Forms.Label petTitle2;
        private System.Windows.Forms.Label petTitle3;
        private System.Windows.Forms.Label petTitle4;
        private System.Windows.Forms.Label petTitle5;
        private System.Windows.Forms.Label petData1;
        private System.Windows.Forms.Label petData2;
        private System.Windows.Forms.Label petData3;
        private System.Windows.Forms.Label petData4;
        private System.Windows.Forms.Label petData5;
        private System.Drawing.Printing.PrintDocument printBills;
        private System.Windows.Forms.PrintPreviewDialog previewBills;
    }
}