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
using MaterialSkin.Controls;
using VCMS.Forms.Reports;
using VCMS.Library.Models;

namespace VCMS.Forms
{
    public partial class ReportsForm : MaterialForm
    {
        private List<ServiceModel> Services = new List<ServiceModel>();
        public ReportsForm()
        {
            InitializeComponent();
            reportsList.Columns.Add("Date", 200);
            reportsList.Columns.Add("Service/Test", 370);
            reportsList.Columns.Add("Weight/Temp/Complaint", 370);
            reportsList.Columns.Add("Against/Findings", 370);
            reportsList.Columns.Add("Manufacturer/Lab Results", 370);
        }
        private void LoadReportView(int month)
        {
            reportsList.Items.Clear();
            Library.Controller.Services services = new Library.Controller.Services();
            Services = services.AllServices();
            foreach (var service in Services.Where(p => p.DateServed.Month == month))
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = service.DateServed.ToString();
                item.SubItems.Add(service.Service + service.Test);
                item.SubItems.Add(service.Weight+"/"+service.Temperature+service.Complaint);
                item.SubItems.Add(service.Against + service.Findings);
                item.SubItems.Add(service.Manufacturer + service.LaboratoryResult);
                reportsList.Items.Add(item);
            }
        }
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadReportView(DateTime.Now.Month);
        }
        private void ReportsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportView(reportsComboBox.SelectedIndex+1);
        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            MonthlyReportsForm form = new MonthlyReportsForm();
            form.Services = Services;
            form.month = reportsComboBox.SelectedIndex + 1;
            form.ShowDialog();
        }
    }
}
