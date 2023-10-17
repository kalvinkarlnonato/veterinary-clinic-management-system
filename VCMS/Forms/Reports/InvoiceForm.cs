using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCMS.Forms.Reports
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }
        private void PrintPanel(Panel panel)
        {
            //PrinterSettings printerSettings = new PrinterSettings();
            //printBillsPanel = panel;
            //ImgMemmory = new Bitmap(panel.Width, panel.Height);
            //panel.DrawToBitmap(ImgMemmory, new Rectangle(0, 0, panel.Width, panel.Height));
            //printBills.PrintPage += new PrintPageEventHandler(printBills_PrintPage);
            //previewBills.Document = printBills;
            //((Form)previewBills).Size = new Size(700, 900);
            //((Form)previewBills).StartPosition = FormStartPosition.CenterParent;
            //previewBills.ShowDialog();
        }
        private void printBills_PrintPage(object sender, PrintPageEventArgs e)
        {

        }
    }
}
