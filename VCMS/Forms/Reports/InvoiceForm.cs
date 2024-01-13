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
using VCMS.Library.Models;

namespace VCMS.Forms.Reports
{
    public partial class InvoiceForm : Form
    {

        public List<string> toPrint { get; set; }
        public InvoiceForm()
        {
            InitializeComponent();
        }
        private Bitmap ImgMemmory;
        private void PrintPanel(Panel panel)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            printBillsPanel = panel;
            ImgMemmory = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(ImgMemmory, new Rectangle(0, 0, panel.Width, panel.Height));
            printBills.PrintPage += new PrintPageEventHandler(PrintBills_PrintPage);
            previewBills.Document = printBills;
            ((Form)previewBills).Size = new Size(700, 900);
            ((Form)previewBills).StartPosition = FormStartPosition.CenterParent;
            previewBills.ShowDialog();
            this.Close();

        }
        private void PrintBills_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle PageArea = e.PageBounds;
            e.Graphics.DrawImage(ImgMemmory, (PageArea.Width / 2) - ((mainPanel.Width + 40) / 2), mainPanel.Location.Y);
        }
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            clientName.Text = toPrint[0].ToString() + "\n" + toPrint[3].ToString() + "\n" + toPrint[4].ToString();
            string[] sers = toPrint[1].ToString().Split(',');
            foreach (string ser in sers) petData2.Text += ser + "\n";
            string[] ches = toPrint[2].ToString().Split(',');
            foreach (string che in ches) petData3.Text += che + "\n";
            petData5.Text = "₱ " + toPrint[6].ToString() + ".00";
            invoicePrice.Text = "₱ " + toPrint[6].ToString()+".00";
            Library.Controller.Pets pets = new Library.Controller.Pets();
            List<PetModel> pepet = pets.FindPetsByID(Convert.ToInt32(toPrint[5]));
            petName.Text = "Pet name: " + pepet.Last().PetName + "\n" + "Pet Breed: " + pepet.Last().Breed;
            petData1.Text = pepet.Last().Species;
            invoiceDate.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");
            PrintPanel(printBillsPanel);
        }
    }
}
