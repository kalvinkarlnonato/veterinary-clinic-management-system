using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCMS.Library.Models;
using MaterialSkin.Controls;
using VCMS.Forms.Reports;

namespace VCMS.Forms.Bills
{
    public partial class PaymentForm : MaterialForm
    {
        public List<string> toPrint {  get; set; }
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            //balanceTextbox.Text = Bill.TotalAmount.ToString();
        }

        private void AmountTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if (amountTextbox.Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            var invoice = new InvoiceForm();
            invoice.toPrint = toPrint;
            invoice.toPrint[6] = amountTextbox.Text;
            invoice.ShowDialog();
        }
    }
}
