using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCMS.Forms.Bills;
using VCMS.Library.Models;
using MaterialSkin.Controls;
using VCMS.Library.Models;
using System.Runtime.ConstrainedExecution;

namespace VCMS.Forms.Services
{
    public partial class BillingForm : MaterialForm
    {
        private List<OwnerModel> Owners { get; set; }
        private List<ServiceModel> Services { get; set; }
        public BillingForm()
        {
            InitializeComponent();
            Library.Controller.Clients clients = new Library.Controller.Clients();
            Owners = clients.AllClients();


            Services = new List<ServiceModel>();
            Library.Controller.Services services = new Library.Controller.Services();
            Services = services.AllUnpaidService();
            var asd = Services.GroupBy(c => c.OwnerID).Select(s => new ServiceModel { OwnerID = s.Key, PetID = s.Last().PetID, Service = String.Join(",", s.Where(n => n.Service != string.Empty).Select(x => x.Service)), Test = String.Join(",", s.Where(n => n.Test != string.Empty).Select(x => x.Test)), Bills = 0 });
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            billsList.Columns.Add("ID", 30);
            billsList.Columns.Add("Customer", 190);
            billsList.Columns.Add("Service", 410);
            billsList.Columns.Add("Checkup", 410);
            billsList.Columns.Add("Phone No.", 200);
            billsList.Columns.Add("Address", 270);
            billsList.Columns.Add("Amount Payed", 200);
            LoadBillingView();
        }
        private void PaymentButton_Click(object sender, EventArgs e)
        {
            if (billsList.SelectedItems.Count == 0) return;
            string fn1 = billsList.SelectedItems[0].SubItems[1].Text;
            string fn2 = billsList.SelectedItems[0].SubItems[2].Text;
            string fn3 = billsList.SelectedItems[0].SubItems[3].Text;
            string fn4 = billsList.SelectedItems[0].SubItems[4].Text;
            string fn5 = billsList.SelectedItems[0].SubItems[5].Text;
            string fn6 = billsList.SelectedItems[0].SubItems[0].Text;
            string fn7 = "";
            PaymentForm form = new PaymentForm();
            form.toPrint = new List<string> { fn1,fn2,fn3,fn4,fn5,fn6,fn7 };
            form.ShowDialog();
        }
        private void LoadBillingView()
        {
            billsList.Items.Clear();

            foreach (var service in Services.GroupBy(c => c.OwnerID).Select(s => new ServiceModel { OwnerID = s.Key, PetID = s.Last().PetID, Service = String.Join(",", s.Where(n => n.Service != string.Empty).Select(x => x.Service)), Test = String.Join(",", s.Where(n => n.Test != string.Empty).Select(x => x.Test)), Bills = 0 }))
            {
                OwnerModel client = Owners.Where(i => i.ID == service.OwnerID).First();
                var item = billsList.Items.Add(service.PetID.ToString());
                item.SubItems.Add(client.FullName);
                item.SubItems.Add(service.Service);
                item.SubItems.Add(service.Test);
                item.SubItems.Add(client.Cellphone);
                item.SubItems.Add(client.Address);
                item.SubItems.Add(service.Bills.ToString());
            }

        }
    }
}
