using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using VCMS.Library.Models;

namespace VCMS.Forms
{
    public partial class SchedulesForm : MaterialForm
    {
        List<ScheduleModel> Schedules { get; set; }
        public SchedulesForm()
        {
            InitializeComponent();
            //// TODO: Trap the year only view the year today in settings
            Schedules = new List<ScheduleModel>
            {
                new ScheduleModel(){ ID = 0, DoctorId = 0, Schedule = DateTime.Parse("1/1/2023 08:00:00 am")},
                new ScheduleModel(){ ID = 0, DoctorId = 0, Schedule = DateTime.Parse("1/2/2023 09:00:00 am")},
                new ScheduleModel(){ ID = 0, DoctorId = 0, Schedule = DateTime.Parse("1/3/2023 10:00:00 am")},
                new ScheduleModel(){ ID = 0, DoctorId = 1, Schedule = DateTime.Parse("2/1/2023 08:00:00 am")},
                new ScheduleModel(){ ID = 0, DoctorId = 1, Schedule = DateTime.Parse("2/2/2023 09:00:00 am")},
                new ScheduleModel(){ ID = 0, DoctorId = 1, Schedule = DateTime.Parse("2/3/2023 10:00:00 am")},
                new ScheduleModel(){ ID = 0, DoctorId = 2, Schedule = DateTime.Parse("3/1/2023 08:00:00 am")},
                new ScheduleModel(){ ID = 0, DoctorId = 2, Schedule = DateTime.Parse("3/2/2023 09:00:00 am")},
                new ScheduleModel(){ ID = 0, DoctorId = 2, Schedule = DateTime.Parse("3/3/2023 10:00:00 am")},
                new ScheduleModel(){ ID = 0, DoctorId = 3, Schedule = DateTime.Parse("4/1/2023 08:00:00 am")},
                new ScheduleModel(){ ID = 0, DoctorId = 3, Schedule = DateTime.Parse("4/2/2023 09:00:00 am")},
                new ScheduleModel(){ ID = 0, DoctorId = 3, Schedule = DateTime.Parse("4/3/2023 10:00:00 am")}
            };
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(Schedules[0].Schedule.ToString("MMMM"));*/
            //// MONTH ONLY USING LINQ
            /*List<String> mont = Schedules.Select(d => d.Schedule.ToString("MMMM")).Distinct().ToList();*/
            List<String> mont = Schedules.Select(d => d.Schedule.ToString("MMMM")).ToList();
            foreach (var mon in mont)
            {
                Label label = new Label();
                label.Name = mon;
                label.Text = mon;
                label.Dock = DockStyle.Top;
                label.Cursor = Cursors.Hand;
                label.DoubleClick += new EventHandler(this.Label_Click);
                panel1.Controls.Add(label);
            }
            /*Label label = new Label();
            label.Name = "hello" + 1;
            label.Text = "hello" + 1;
            label.Dock = DockStyle.Top;
            panel1.Controls.Add(label);*/

        }
        private void Label_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            if (label.BackColor == Color.Red) {
                label.BackColor = Color.Transparent;
                return;
            }
            label.BackColor = Color.Red;
        }

    }
}
