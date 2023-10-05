using MaterialSkin;
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

namespace VCMS.Forms
{
    public partial class CustomersForm : MaterialForm
    {
        public CustomersForm()
        {
            InitializeComponent();

            var clients = new[] {
                new { id = 0, owner = "Juan  Dela Cruz", pet = "elephant", address="Tuguegarao City", phone = "09987654321", nextVisit = DateTime.Now },
                new { id = 1, owner = "Nathaniel  Dela Cruz", pet = "dog", address = "Tuguegarao City", phone = "09987654321", nextVisit = DateTime.Now },
                new { id = 2, owner = "Jacob  Dela Cruz", pet = "cat", address = "Tuguegarao City", phone = "09987654321", nextVisit = DateTime.Now },
                new { id = 3, owner = "Gabriel  Dela Cruz", pet = "mouse", address = "Tuguegarao City", phone = "09987654321", nextVisit = DateTime.Now },
                new { id = 4, owner = "Joshua  Dela Cruz", pet = "chicken", address = "Tuguegarao City", phone = "09987654321", nextVisit = DateTime.Now },
                new { id = 5, owner = "Angelo  Dela Cruz", pet = "pig", address = "Tuguegarao City", phone = "09987654321", nextVisit = DateTime.Now }
            };

            clientsList.Columns.Add("ID", 80);
            clientsList.Columns.Add("Owner", 350);
            clientsList.Columns.Add("Pet", 250);
            clientsList.Columns.Add("Phone No.", 200);
            clientsList.Columns.Add("Address", 400);
            clientsList.Columns.Add("Next Visit", 200);

            foreach (var client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = client.id.ToString();
                item.SubItems.Add(client.owner.ToString());
                item.SubItems.Add(client.pet.ToString());
                item.SubItems.Add(client.phone.ToString());
                item.SubItems.Add(client.address.ToString());
                item.SubItems.Add(client.nextVisit.ToString());
                clientsList.Items.Add(item);
            }

        }



    }
}
