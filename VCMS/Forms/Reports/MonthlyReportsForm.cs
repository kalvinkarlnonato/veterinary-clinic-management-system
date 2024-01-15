using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using VCMS.Library.Models;

namespace VCMS.Forms.Reports
{
    public partial class MonthlyReportsForm : Form
    {
        public List<ServiceModel> Services = new List<ServiceModel>();
        public int month;
        public MonthlyReportsForm()
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
            printBills.DefaultPageSettings.Landscape = true;
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

        private void MonthlyReportsForm_Load(object sender, EventArgs e)
        {
            foreach (var service in Services.Where(p => p.DateServed.Month == month))
            {
                petData1.Text += service.DateServed.ToString() + "\n";
                petData2.Text += service.Service + service.Test + "\n";
                petData3.Text += service.Weight + (service.Weight==string.Empty? "" :"/") + service.Temperature + service.Complaint + "\n";
                petData4.Text += service.Against + service.Findings + "\n";
                petData5.Text += service.Manufacturer + service.LaboratoryResult + "\n";
            }
            petName.Text = "Printed date: "+DateTime.Now.ToString("M/d/yy");
            invoiceNum.Text = new DateTime(2024,month,1).ToString("MMMM");
            PrintPanel(printBillsPanel);
        }
    }
}
