﻿namespace VCMS.Forms.Reports
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
<<<<<<< HEAD
            this.previewBills = new System.Windows.Forms.PrintPreviewDialog();
            this.printBills = new System.Drawing.Printing.PrintDocument();
            this.printBillsPanel = new System.Windows.Forms.Panel();
            this.payLTable = new System.Windows.Forms.TableLayoutPanel();
            this.terms = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.Label();
            this.termsLabel = new System.Windows.Forms.Label();
            this.notesTitle = new System.Windows.Forms.Label();
            this.payRTable = new System.Windows.Forms.TableLayoutPanel();
            this.paymentTitle = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.div4 = new System.Windows.Forms.Label();
            this.ammountsTitle = new System.Windows.Forms.Label();
            this.ammounts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
=======
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.payBodyTable = new System.Windows.Forms.TableLayoutPanel();
            this.petHead = new System.Windows.Forms.TableLayoutPanel();
            this.petTitle1 = new System.Windows.Forms.Label();
            this.petTitle2 = new System.Windows.Forms.Label();
            this.petTitle3 = new System.Windows.Forms.Label();
            this.petTitle5 = new System.Windows.Forms.Label();
            this.petTitle4 = new System.Windows.Forms.Label();
            this.invoicePanel = new System.Windows.Forms.TableLayoutPanel();
            this.invoicePrice = new System.Windows.Forms.Label();
            this.invoiceNum = new System.Windows.Forms.Label();
            this.petSex = new System.Windows.Forms.Label();
            this.div3 = new System.Windows.Forms.Label();
            this.petName = new System.Windows.Forms.Label();
            this.div2 = new System.Windows.Forms.Label();
            this.invoiceDate = new System.Windows.Forms.Label();
            this.petLabel = new System.Windows.Forms.Label();
            this.div1 = new System.Windows.Forms.Label();
            this.payTitle = new System.Windows.Forms.Label();
            this.paySubTitle = new System.Windows.Forms.Label();
            this.payAddressTitle = new System.Windows.Forms.Label();
            this.clientAddress = new System.Windows.Forms.Label();
            this.clientNum = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.Label();
            this.clientPic = new System.Windows.Forms.PictureBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.petTable = new System.Windows.Forms.TableLayoutPanel();
            this.petData5 = new System.Windows.Forms.Label();
            this.petData4 = new System.Windows.Forms.Label();
            this.petData2 = new System.Windows.Forms.Label();
            this.petData1 = new System.Windows.Forms.Label();
            this.petData3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.printBillsPanel.SuspendLayout();
            this.payLTable.SuspendLayout();
            this.payRTable.SuspendLayout();
=======
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.payBodyTable.SuspendLayout();
            this.petHead.SuspendLayout();
            this.invoicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPic)).BeginInit();
            this.petTable.SuspendLayout();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
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
            this.printBillsPanel.Controls.Add(this.payLTable);
            this.printBillsPanel.Controls.Add(this.payRTable);
            this.printBillsPanel.Controls.Add(this.payBodyTable);
            this.printBillsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printBillsPanel.Location = new System.Drawing.Point(0, 0);
            this.printBillsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.printBillsPanel.Name = "printBillsPanel";
            this.printBillsPanel.Size = new System.Drawing.Size(606, 815);
            this.printBillsPanel.TabIndex = 11;
            // 
            // payLTable
            // 
            this.payLTable.ColumnCount = 1;
            this.payLTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.payLTable.Controls.Add(this.terms, 0, 2);
            this.payLTable.Controls.Add(this.Notes, 0, 4);
            this.payLTable.Controls.Add(this.termsLabel, 0, 1);
            this.payLTable.Controls.Add(this.notesTitle, 0, 3);
            this.payLTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payLTable.Location = new System.Drawing.Point(0, 414);
            this.payLTable.Name = "payLTable";
            this.payLTable.RowCount = 6;
            this.payLTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.payLTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payLTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payLTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payLTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payLTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.payLTable.Size = new System.Drawing.Size(437, 401);
            this.payLTable.TabIndex = 10;
            // 
            // terms
            // 
            this.terms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.terms.AutoSize = true;
            this.terms.Location = new System.Drawing.Point(3, 33);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(431, 13);
            this.terms.TabIndex = 17;
            this.terms.Text = "Payment due upon reciept.";
            // 
            // Notes
            // 
            this.Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(3, 59);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(431, 13);
            this.Notes.TabIndex = 28;
            this.Notes.Text = "Welcome to the Sniffs && Licks. Glad you\'re with us";
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(3, 20);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(39, 13);
            this.termsLabel.TabIndex = 16;
            this.termsLabel.Text = "Terms:";
            // 
            // notesTitle
            // 
            this.notesTitle.AutoSize = true;
            this.notesTitle.Location = new System.Drawing.Point(3, 46);
            this.notesTitle.Name = "notesTitle";
            this.notesTitle.Size = new System.Drawing.Size(38, 13);
            this.notesTitle.TabIndex = 27;
            this.notesTitle.Text = "Notes:";
            // 
            // payRTable
            // 
            this.payRTable.AutoSize = true;
            this.payRTable.ColumnCount = 2;
            this.payRTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.payRTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.payRTable.Controls.Add(this.paymentTitle, 0, 4);
            this.payRTable.Controls.Add(this.payment, 1, 4);
            this.payRTable.Controls.Add(this.div4, 0, 3);
            this.payRTable.Controls.Add(this.ammountsTitle, 0, 1);
            this.payRTable.Controls.Add(this.ammounts, 1, 1);
            this.payRTable.Controls.Add(this.label1, 0, 2);
            this.payRTable.Controls.Add(this.label2, 1, 2);
            this.payRTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.payRTable.Location = new System.Drawing.Point(437, 414);
            this.payRTable.Name = "payRTable";
            this.payRTable.RowCount = 6;
            this.payRTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.payRTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payRTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payRTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payRTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payRTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.payRTable.Size = new System.Drawing.Size(169, 401);
            this.payRTable.TabIndex = 11;
            // 
            // paymentTitle
            // 
            this.paymentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentTitle.AutoSize = true;
            this.paymentTitle.Location = new System.Drawing.Point(3, 80);
            this.paymentTitle.Name = "paymentTitle";
            this.paymentTitle.Size = new System.Drawing.Size(71, 26);
            this.paymentTitle.TabIndex = 30;
            this.paymentTitle.Text = "Paid amount:\r\nChange:";
            // 
            // payment
            // 
            this.payment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payment.AutoSize = true;
            this.payment.Location = new System.Drawing.Point(80, 80);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(86, 26);
            this.payment.TabIndex = 31;
            this.payment.Text = "₱ 300.00\r\n₱ 0.00";
            this.payment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // div4
            // 
            this.div4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.div4.AutoSize = true;
            this.payRTable.SetColumnSpan(this.div4, 2);
            this.div4.ForeColor = System.Drawing.Color.Gray;
            this.div4.Location = new System.Drawing.Point(3, 67);
            this.div4.Name = "div4";
            this.div4.Size = new System.Drawing.Size(163, 13);
            this.div4.TabIndex = 29;
            this.div4.Text = "――――――――――――――――――――";
            this.div4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ammountsTitle
            // 
            this.ammountsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ammountsTitle.AutoSize = true;
            this.ammountsTitle.Location = new System.Drawing.Point(3, 20);
            this.ammountsTitle.Name = "ammountsTitle";
            this.ammountsTitle.Size = new System.Drawing.Size(71, 26);
            this.ammountsTitle.TabIndex = 18;
            this.ammountsTitle.Text = "Transactions:\r\nSubtotal:";
            // 
            // ammounts
            // 
            this.ammounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ammounts.AutoSize = true;
            this.ammounts.Location = new System.Drawing.Point(80, 20);
            this.ammounts.Name = "ammounts";
            this.ammounts.Size = new System.Drawing.Size(86, 26);
            this.ammounts.TabIndex = 19;
            this.ammounts.Text = "1\r\n₱ 300.00";
            this.ammounts.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "₱ 300.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
=======
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            // payBodyTable
            // 
            this.payBodyTable.AutoSize = true;
            this.payBodyTable.ColumnCount = 1;
            this.payBodyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.payBodyTable.Controls.Add(this.petHead, 0, 16);
            this.payBodyTable.Controls.Add(this.invoicePanel, 0, 10);
            this.payBodyTable.Controls.Add(this.petSex, 0, 15);
            this.payBodyTable.Controls.Add(this.div3, 0, 17);
            this.payBodyTable.Controls.Add(this.petName, 0, 14);
            this.payBodyTable.Controls.Add(this.div2, 0, 13);
            this.payBodyTable.Controls.Add(this.invoiceDate, 0, 11);
            this.payBodyTable.Controls.Add(this.petLabel, 0, 12);
            this.payBodyTable.Controls.Add(this.div1, 0, 9);
            this.payBodyTable.Controls.Add(this.payTitle, 0, 1);
            this.payBodyTable.Controls.Add(this.paySubTitle, 0, 2);
            this.payBodyTable.Controls.Add(this.payAddressTitle, 0, 3);
            this.payBodyTable.Controls.Add(this.clientAddress, 0, 8);
            this.payBodyTable.Controls.Add(this.clientNum, 0, 7);
            this.payBodyTable.Controls.Add(this.clientName, 0, 6);
            this.payBodyTable.Controls.Add(this.clientPic, 0, 5);
            this.payBodyTable.Controls.Add(this.clientLabel, 0, 4);
            this.payBodyTable.Controls.Add(this.petTable, 0, 18);
            this.payBodyTable.Controls.Add(this.label3, 0, 19);
            this.payBodyTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.payBodyTable.Location = new System.Drawing.Point(0, 0);
            this.payBodyTable.Name = "payBodyTable";
            this.payBodyTable.RowCount = 20;
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.payBodyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
<<<<<<< HEAD
            this.payBodyTable.Size = new System.Drawing.Size(606, 414);
            this.payBodyTable.TabIndex = 6;
=======
            this.payBodyTable.Size = new System.Drawing.Size(581, 414);
            this.payBodyTable.TabIndex = 7;
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            // 
            // petHead
            // 
            this.petHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.petHead.AutoSize = true;
            this.petHead.ColumnCount = 5;
            this.petHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.petHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.petHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.petHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.petHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.petHead.Controls.Add(this.petTitle1, 0, 0);
            this.petHead.Controls.Add(this.petTitle2, 1, 0);
            this.petHead.Controls.Add(this.petTitle3, 2, 0);
            this.petHead.Controls.Add(this.petTitle5, 4, 0);
            this.petHead.Controls.Add(this.petTitle4, 3, 0);
            this.petHead.Location = new System.Drawing.Point(3, 341);
            this.petHead.Name = "petHead";
            this.petHead.RowCount = 1;
            this.petHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
<<<<<<< HEAD
            this.petHead.Size = new System.Drawing.Size(600, 16);
=======
            this.petHead.Size = new System.Drawing.Size(575, 16);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petHead.TabIndex = 10;
            // 
            // petTitle1
            // 
            this.petTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTitle1.AutoSize = true;
            this.petTitle1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTitle1.ForeColor = System.Drawing.Color.Gray;
            this.petTitle1.Location = new System.Drawing.Point(3, 0);
            this.petTitle1.Name = "petTitle1";
<<<<<<< HEAD
            this.petTitle1.Size = new System.Drawing.Size(84, 16);
=======
            this.petTitle1.Size = new System.Drawing.Size(80, 16);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petTitle1.TabIndex = 7;
            this.petTitle1.Text = "Pet";
            this.petTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petTitle2
            // 
            this.petTitle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTitle2.AutoSize = true;
            this.petTitle2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTitle2.ForeColor = System.Drawing.Color.Gray;
<<<<<<< HEAD
            this.petTitle2.Location = new System.Drawing.Point(93, 0);
            this.petTitle2.Name = "petTitle2";
            this.petTitle2.Size = new System.Drawing.Size(144, 16);
=======
            this.petTitle2.Location = new System.Drawing.Point(89, 0);
            this.petTitle2.Name = "petTitle2";
            this.petTitle2.Size = new System.Drawing.Size(137, 16);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petTitle2.TabIndex = 25;
            this.petTitle2.Text = "Complaint/Diagnosis";
            this.petTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petTitle3
            // 
            this.petTitle3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTitle3.AutoSize = true;
            this.petTitle3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTitle3.ForeColor = System.Drawing.Color.Gray;
<<<<<<< HEAD
            this.petTitle3.Location = new System.Drawing.Point(243, 0);
            this.petTitle3.Name = "petTitle3";
            this.petTitle3.Size = new System.Drawing.Size(144, 16);
=======
            this.petTitle3.Location = new System.Drawing.Point(232, 0);
            this.petTitle3.Name = "petTitle3";
            this.petTitle3.Size = new System.Drawing.Size(137, 16);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petTitle3.TabIndex = 8;
            this.petTitle3.Text = "Treatment";
            this.petTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petTitle5
            // 
            this.petTitle5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTitle5.AutoSize = true;
            this.petTitle5.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTitle5.ForeColor = System.Drawing.Color.Gray;
<<<<<<< HEAD
            this.petTitle5.Location = new System.Drawing.Point(513, 0);
            this.petTitle5.Name = "petTitle5";
            this.petTitle5.Size = new System.Drawing.Size(84, 16);
=======
            this.petTitle5.Location = new System.Drawing.Point(490, 0);
            this.petTitle5.Name = "petTitle5";
            this.petTitle5.Size = new System.Drawing.Size(82, 16);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petTitle5.TabIndex = 10;
            this.petTitle5.Text = "Total";
            this.petTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petTitle4
            // 
            this.petTitle4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTitle4.AutoSize = true;
            this.petTitle4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petTitle4.ForeColor = System.Drawing.Color.Gray;
<<<<<<< HEAD
            this.petTitle4.Location = new System.Drawing.Point(393, 0);
            this.petTitle4.Name = "petTitle4";
            this.petTitle4.Size = new System.Drawing.Size(114, 16);
=======
            this.petTitle4.Location = new System.Drawing.Point(375, 0);
            this.petTitle4.Name = "petTitle4";
            this.petTitle4.Size = new System.Drawing.Size(109, 16);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petTitle4.TabIndex = 9;
            this.petTitle4.Text = "Followup";
            this.petTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoicePanel
            // 
            this.invoicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.invoicePanel.AutoSize = true;
            this.invoicePanel.ColumnCount = 2;
            this.invoicePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.invoicePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.invoicePanel.Controls.Add(this.invoicePrice, 1, 0);
            this.invoicePanel.Controls.Add(this.invoiceNum, 0, 0);
            this.invoicePanel.Location = new System.Drawing.Point(3, 231);
            this.invoicePanel.Name = "invoicePanel";
            this.invoicePanel.RowCount = 1;
            this.invoicePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
<<<<<<< HEAD
            this.invoicePanel.Size = new System.Drawing.Size(600, 25);
=======
            this.invoicePanel.Size = new System.Drawing.Size(575, 25);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.invoicePanel.TabIndex = 10;
            // 
            // invoicePrice
            // 
            this.invoicePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invoicePrice.AutoSize = true;
            this.invoicePrice.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.invoicePrice.Location = new System.Drawing.Point(498, 0);
=======
            this.invoicePrice.Location = new System.Drawing.Point(473, 0);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.invoicePrice.Name = "invoicePrice";
            this.invoicePrice.Size = new System.Drawing.Size(99, 25);
            this.invoicePrice.TabIndex = 7;
            this.invoicePrice.Text = "₱ 300.00";
            this.invoicePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // invoiceNum
            // 
            this.invoiceNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.invoiceNum.AutoSize = true;
            this.invoiceNum.Location = new System.Drawing.Point(3, 12);
            this.invoiceNum.Name = "invoiceNum";
            this.invoiceNum.Size = new System.Drawing.Size(94, 13);
            this.invoiceNum.TabIndex = 6;
            this.invoiceNum.Text = "Invoice #: 000001";
            // 
            // petSex
            // 
            this.petSex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.petSex.AutoSize = true;
            this.petSex.Location = new System.Drawing.Point(3, 325);
            this.petSex.Name = "petSex";
<<<<<<< HEAD
            this.petSex.Size = new System.Drawing.Size(600, 13);
=======
            this.petSex.Size = new System.Drawing.Size(575, 13);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petSex.TabIndex = 21;
            this.petSex.Text = "Sex: Male";
            // 
            // div3
            // 
            this.div3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.div3.ForeColor = System.Drawing.Color.Gray;
            this.div3.Location = new System.Drawing.Point(3, 360);
            this.div3.Name = "div3";
<<<<<<< HEAD
            this.div3.Size = new System.Drawing.Size(600, 15);
=======
            this.div3.Size = new System.Drawing.Size(575, 15);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.div3.TabIndex = 6;
            this.div3.Text = "―――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――";
            this.div3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // petName
            // 
            this.petName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.petName.AutoSize = true;
            this.petName.Location = new System.Drawing.Point(3, 312);
            this.petName.Name = "petName";
<<<<<<< HEAD
            this.petName.Size = new System.Drawing.Size(600, 13);
=======
            this.petName.Size = new System.Drawing.Size(575, 13);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petName.TabIndex = 20;
            this.petName.Text = "Pet name: Blaki";
            // 
            // div2
            // 
            this.div2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.div2.ForeColor = System.Drawing.Color.Gray;
            this.div2.Location = new System.Drawing.Point(3, 297);
            this.div2.Name = "div2";
<<<<<<< HEAD
            this.div2.Size = new System.Drawing.Size(600, 15);
=======
            this.div2.Size = new System.Drawing.Size(575, 15);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.div2.TabIndex = 23;
            this.div2.Text = "―――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――";
            this.div2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoiceDate
            // 
            this.invoiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceDate.AutoSize = true;
            this.invoiceDate.Location = new System.Drawing.Point(3, 259);
            this.invoiceDate.Name = "invoiceDate";
<<<<<<< HEAD
            this.invoiceDate.Size = new System.Drawing.Size(600, 13);
=======
            this.invoiceDate.Size = new System.Drawing.Size(575, 13);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.invoiceDate.TabIndex = 5;
            this.invoiceDate.Text = "March 22, 2022 10:25am";
            // 
            // petLabel
            // 
            this.petLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.petLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petLabel.ForeColor = System.Drawing.Color.Gray;
            this.petLabel.Location = new System.Drawing.Point(3, 272);
            this.petLabel.Name = "petLabel";
<<<<<<< HEAD
            this.petLabel.Size = new System.Drawing.Size(600, 25);
=======
            this.petLabel.Size = new System.Drawing.Size(575, 25);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petLabel.TabIndex = 24;
            this.petLabel.Text = "Patient";
            this.petLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // div1
            // 
            this.div1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.div1.ForeColor = System.Drawing.Color.Gray;
            this.div1.Location = new System.Drawing.Point(3, 213);
            this.div1.Name = "div1";
<<<<<<< HEAD
            this.div1.Size = new System.Drawing.Size(600, 15);
=======
            this.div1.Size = new System.Drawing.Size(575, 15);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.div1.TabIndex = 2;
            this.div1.Text = "―――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――";
            this.div1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payTitle
            // 
            this.payTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.payTitle.AutoSize = true;
            this.payTitle.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payTitle.Location = new System.Drawing.Point(3, 10);
            this.payTitle.Name = "payTitle";
<<<<<<< HEAD
            this.payTitle.Size = new System.Drawing.Size(600, 38);
=======
            this.payTitle.Size = new System.Drawing.Size(575, 38);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.payTitle.TabIndex = 0;
            this.payTitle.Text = "SNIFFS && LICKS";
            this.payTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paySubTitle
            // 
            this.paySubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paySubTitle.AutoSize = true;
            this.paySubTitle.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paySubTitle.Location = new System.Drawing.Point(3, 48);
            this.paySubTitle.Name = "paySubTitle";
<<<<<<< HEAD
            this.paySubTitle.Size = new System.Drawing.Size(600, 22);
=======
            this.paySubTitle.Size = new System.Drawing.Size(575, 22);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.paySubTitle.TabIndex = 0;
            this.paySubTitle.Text = "VETERINARY CLINIC";
            this.paySubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payAddressTitle
            // 
            this.payAddressTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.payAddressTitle.AutoSize = true;
            this.payAddressTitle.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payAddressTitle.Location = new System.Drawing.Point(3, 70);
            this.payAddressTitle.Name = "payAddressTitle";
<<<<<<< HEAD
            this.payAddressTitle.Size = new System.Drawing.Size(600, 32);
=======
            this.payAddressTitle.Size = new System.Drawing.Size(575, 32);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.payAddressTitle.TabIndex = 0;
            this.payAddressTitle.Text = "#44 Maxlen Bld. Maharlika Highway,\r\nTanza, Tuguegarao City";
            this.payAddressTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientAddress
            // 
            this.clientAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clientAddress.AutoSize = true;
            this.clientAddress.Location = new System.Drawing.Point(3, 200);
            this.clientAddress.Name = "clientAddress";
<<<<<<< HEAD
            this.clientAddress.Size = new System.Drawing.Size(600, 13);
=======
            this.clientAddress.Size = new System.Drawing.Size(575, 13);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.clientAddress.TabIndex = 0;
            this.clientAddress.Text = "#44 Maxlen Bld. Maharlika Highway, Tanza, Tuguegarao City";
            // 
            // clientNum
            // 
            this.clientNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clientNum.AutoSize = true;
            this.clientNum.Location = new System.Drawing.Point(3, 187);
            this.clientNum.Name = "clientNum";
<<<<<<< HEAD
            this.clientNum.Size = new System.Drawing.Size(600, 13);
            this.clientNum.TabIndex = 0;
            this.clientNum.Text = "09987654321";
=======
            this.clientNum.Size = new System.Drawing.Size(575, 13);
            this.clientNum.TabIndex = 0;
            this.clientNum.Text = "09876543210";
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            // 
            // clientName
            // 
            this.clientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clientName.AutoSize = true;
            this.clientName.Location = new System.Drawing.Point(3, 174);
            this.clientName.Name = "clientName";
<<<<<<< HEAD
            this.clientName.Size = new System.Drawing.Size(600, 13);
            this.clientName.TabIndex = 0;
            this.clientName.Text = "Juan A. Dela Cruz";
=======
            this.clientName.Size = new System.Drawing.Size(575, 13);
            this.clientName.TabIndex = 0;
            this.clientName.Text = "Kalvin Karl C. Nonato";
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            // 
            // clientPic
            // 
            this.clientPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientPic.BackgroundImage")));
            this.clientPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientPic.Location = new System.Drawing.Point(3, 121);
            this.clientPic.Name = "clientPic";
            this.clientPic.Size = new System.Drawing.Size(50, 50);
            this.clientPic.TabIndex = 1;
            this.clientPic.TabStop = false;
            // 
            // clientLabel
            // 
            this.clientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.Gray;
            this.clientLabel.Location = new System.Drawing.Point(3, 102);
            this.clientLabel.Name = "clientLabel";
<<<<<<< HEAD
            this.clientLabel.Size = new System.Drawing.Size(600, 16);
=======
            this.clientLabel.Size = new System.Drawing.Size(575, 16);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "Bill to";
            // 
            // petTable
            // 
            this.petTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTable.AutoSize = true;
            this.petTable.ColumnCount = 5;
            this.petTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.petTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.petTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.petTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.petTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.petTable.Controls.Add(this.petData5, 4, 0);
            this.petTable.Controls.Add(this.petData4, 3, 0);
            this.petTable.Controls.Add(this.petData2, 1, 0);
            this.petTable.Controls.Add(this.petData1, 0, 0);
            this.petTable.Controls.Add(this.petData3, 2, 0);
            this.petTable.Location = new System.Drawing.Point(3, 378);
            this.petTable.Name = "petTable";
            this.petTable.RowCount = 1;
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.petTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
<<<<<<< HEAD
            this.petTable.Size = new System.Drawing.Size(600, 13);
=======
            this.petTable.Size = new System.Drawing.Size(575, 13);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petTable.TabIndex = 10;
            // 
            // petData5
            // 
            this.petData5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petData5.AutoSize = true;
<<<<<<< HEAD
            this.petData5.Location = new System.Drawing.Point(513, 0);
            this.petData5.Name = "petData5";
            this.petData5.Size = new System.Drawing.Size(84, 13);
=======
            this.petData5.Location = new System.Drawing.Point(490, 0);
            this.petData5.Name = "petData5";
            this.petData5.Size = new System.Drawing.Size(82, 13);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petData5.TabIndex = 14;
            this.petData5.Text = "₱ 300.00";
            this.petData5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // petData4
            // 
            this.petData4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petData4.AutoSize = true;
<<<<<<< HEAD
            this.petData4.Location = new System.Drawing.Point(393, 0);
            this.petData4.Name = "petData4";
            this.petData4.Size = new System.Drawing.Size(114, 13);
=======
            this.petData4.Location = new System.Drawing.Point(375, 0);
            this.petData4.Name = "petData4";
            this.petData4.Size = new System.Drawing.Size(109, 13);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petData4.TabIndex = 13;
            this.petData4.Text = "March 25, 2022";
            // 
            // petData2
            // 
            this.petData2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petData2.AutoSize = true;
<<<<<<< HEAD
            this.petData2.Location = new System.Drawing.Point(93, 0);
            this.petData2.Name = "petData2";
            this.petData2.Size = new System.Drawing.Size(144, 13);
=======
            this.petData2.Location = new System.Drawing.Point(89, 0);
            this.petData2.Name = "petData2";
            this.petData2.Size = new System.Drawing.Size(137, 13);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petData2.TabIndex = 11;
            this.petData2.Text = "Dizzy and gave sugar";
            // 
            // petData1
            // 
            this.petData1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petData1.AutoSize = true;
            this.petData1.Location = new System.Drawing.Point(3, 0);
            this.petData1.Name = "petData1";
<<<<<<< HEAD
            this.petData1.Size = new System.Drawing.Size(84, 13);
=======
            this.petData1.Size = new System.Drawing.Size(80, 13);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petData1.TabIndex = 11;
            this.petData1.Text = "Dog(Askal)";
            // 
            // petData3
            // 
            this.petData3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petData3.AutoSize = true;
<<<<<<< HEAD
            this.petData3.Location = new System.Drawing.Point(243, 0);
            this.petData3.Name = "petData3";
            this.petData3.Size = new System.Drawing.Size(144, 13);
=======
            this.petData3.Location = new System.Drawing.Point(232, 0);
            this.petData3.Name = "petData3";
            this.petData3.Size = new System.Drawing.Size(137, 13);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.petData3.TabIndex = 12;
            this.petData3.Text = "Vaccined 3011";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(3, 397);
            this.label3.Name = "label3";
<<<<<<< HEAD
            this.label3.Size = new System.Drawing.Size(600, 13);
=======
            this.label3.Size = new System.Drawing.Size(575, 13);
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.label3.TabIndex = 6;
            this.label3.Text = "―――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――――";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(606, 815);
            this.Controls.Add(this.printBillsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceForm";
            this.printBillsPanel.ResumeLayout(false);
            this.printBillsPanel.PerformLayout();
            this.payLTable.ResumeLayout(false);
            this.payLTable.PerformLayout();
            this.payRTable.ResumeLayout(false);
            this.payRTable.PerformLayout();
=======
            this.ClientSize = new System.Drawing.Size(581, 659);
            this.Controls.Add(this.payBodyTable);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
            this.payBodyTable.ResumeLayout(false);
            this.payBodyTable.PerformLayout();
            this.petHead.ResumeLayout(false);
            this.petHead.PerformLayout();
            this.invoicePanel.ResumeLayout(false);
            this.invoicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPic)).EndInit();
            this.petTable.ResumeLayout(false);
            this.petTable.PerformLayout();
            this.ResumeLayout(false);
<<<<<<< HEAD
=======
            this.PerformLayout();
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258

        }

        #endregion
<<<<<<< HEAD
        private System.Windows.Forms.PrintPreviewDialog previewBills;
        private System.Drawing.Printing.PrintDocument printBills;
        private System.Windows.Forms.Panel printBillsPanel;
        private System.Windows.Forms.TableLayoutPanel payLTable;
        private System.Windows.Forms.Label terms;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.Label notesTitle;
        private System.Windows.Forms.TableLayoutPanel payRTable;
        private System.Windows.Forms.Label paymentTitle;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label div4;
        private System.Windows.Forms.Label ammountsTitle;
        private System.Windows.Forms.Label ammounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
=======

>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
        private System.Windows.Forms.TableLayoutPanel payBodyTable;
        private System.Windows.Forms.TableLayoutPanel petHead;
        private System.Windows.Forms.Label petTitle1;
        private System.Windows.Forms.Label petTitle2;
        private System.Windows.Forms.Label petTitle3;
        private System.Windows.Forms.Label petTitle5;
        private System.Windows.Forms.Label petTitle4;
        private System.Windows.Forms.TableLayoutPanel invoicePanel;
        private System.Windows.Forms.Label invoicePrice;
        private System.Windows.Forms.Label invoiceNum;
        private System.Windows.Forms.Label petSex;
        private System.Windows.Forms.Label div3;
        private System.Windows.Forms.Label petName;
        private System.Windows.Forms.Label div2;
        private System.Windows.Forms.Label invoiceDate;
        private System.Windows.Forms.Label petLabel;
        private System.Windows.Forms.Label div1;
        private System.Windows.Forms.Label payTitle;
        private System.Windows.Forms.Label paySubTitle;
        private System.Windows.Forms.Label payAddressTitle;
        private System.Windows.Forms.Label clientAddress;
        private System.Windows.Forms.Label clientNum;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.PictureBox clientPic;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.TableLayoutPanel petTable;
        private System.Windows.Forms.Label petData5;
        private System.Windows.Forms.Label petData4;
        private System.Windows.Forms.Label petData2;
        private System.Windows.Forms.Label petData1;
        private System.Windows.Forms.Label petData3;
        private System.Windows.Forms.Label label3;
    }
}