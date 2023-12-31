<<<<<<< HEAD
﻿using System;
=======
﻿using MaterialSkin.Controls;
using System;
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using VCMS.Forms.Bills;
using VCMS.Library.Models;
using MaterialSkin.Controls;
=======
using VCMS.Library.Models;
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258

namespace VCMS.Forms.Services
{
    public partial class BillingForm : MaterialForm
    {
        private List<OwnerModel> Owners { get; set; }
        public BillingForm()
        {
            InitializeComponent();
            Owners = new List<OwnerModel>() {
                new OwnerModel() { ID = 0, FirstName = "Juan",LastName= "Dela Cruz", Address = "Tuguegarao City", Cellphone = "0998-765-4321", DateRegistered = DateTime.Now ,
                    Pets = new List<PetModel>{
                        new PetModel { ID = 0, Name="Elphi", Breed="Askal", Species="Dog", Birthday = DateTime.Parse("9/1/2023"), ColorMarking="Black White", Sex="Male", NextVisit=DateTime.Parse("9/9/2023 10:00AM"),
                            Checkups = new List<CheckupModel>(){
                                new CheckupModel { ID=0,PetID = 0,
<<<<<<< HEAD
                                    Bill=new BillModel(){ ID=0,ServiceID=0,InvoiceNumber=0001,TotalAmount=300,PaidAmount=0,Date=DateTime.Now.Date}
=======
                                    Bill=new BillModel(){ ID=0,ServiceID=0,InvoiceNumber=0001,TotalAmount=100,PaidAmount=0,Date=DateTime.Now.Date}
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
                                }
                            }
                        }
                    }
                }
            };
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            billsList.Columns.Add("Invoice", 80);
            billsList.Columns.Add("Customer", 350);
            billsList.Columns.Add("Pet", 250);
            billsList.Columns.Add("Phone No.", 200);
            billsList.Columns.Add("Address", 400);
            billsList.Columns.Add("Amount", 200);

            foreach (var Owner in Owners)
            {
                var item = billsList.Items.Add(Owner.Pets[0].Checkups[0].Bill.InvoiceNumber.ToString());
                item.SubItems.Add(Owner.FullName.ToString());
                item.SubItems.Add(Owner.PetSpecies.ToString());
                item.SubItems.Add(Owner.Cellphone.ToString());
                item.SubItems.Add(Owner.Address.ToString());
                item.SubItems.Add(Owner.Pets.Last().Checkups.Last().Bill.TotalAmount.ToString());
            }
        }
<<<<<<< HEAD

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            if (billsList.SelectedItems.Count == 0) return;
            string fn = billsList.SelectedItems[0].SubItems[1].Text;
            PaymentForm form = new PaymentForm();
            form.Bill = Owners.Where(o => o.FullName == fn).First().Pets.Last().Checkups.Last().Bill;
            form.ShowDialog();
        }
=======
>>>>>>> b4311dad8232edc7f9e95a451515e1e6447ec258
    }
}
