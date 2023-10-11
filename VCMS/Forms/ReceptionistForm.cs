using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace VCMS.Forms
{
    public partial class ReceptionistForm : MaterialForm
    {
        public ReceptionistForm()
        {
            InitializeComponent();

            var receptionists = new[] {
                new { id = 0, name = "Juan  Dela Cruz",address="Tuguegarao City", phone = "09987654321" },
                new { id = 1, name = "Nathaniel  Dela Cruz",address = "Tuguegarao City", phone = "09987654321" },
                new { id = 2, name = "Jacob  Dela Cruz",address = "Tuguegarao City", phone = "09987654321" },
                new { id = 3, name = "Gabriel  Dela Cruz",address = "Tuguegarao City", phone = "09987654321" },
                new { id = 4, name = "Joshua  Dela Cruz",address = "Tuguegarao City", phone = "09987654321" },
                new { id = 5, name = "Angelo  Dela Cruz",address = "Tuguegarao City", phone = "09987654321" }
            };

            receptionistsList.Columns.Add("ID", 80);
            receptionistsList.Columns.Add("Name", 400);
            receptionistsList.Columns.Add("Phone No.", 200);
            receptionistsList.Columns.Add("Address", 500);

            foreach (var receptionist in receptionists)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = receptionist.id.ToString();
                item.SubItems.Add(receptionist.name.ToString());
                item.SubItems.Add(receptionist.phone.ToString());
                item.SubItems.Add(receptionist.address.ToString());
                receptionistsList.Items.Add(item);
            }
        }
    }
}
