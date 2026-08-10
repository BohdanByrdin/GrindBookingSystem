using GrindBookingSystem.Tutor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindBookingSystem.Schedule
{
    public partial class DisplayShedule : Form
    {
        public DisplayShedule()
        {
            InitializeComponent();
        }

        private void DisplayShedule_Load(object sender, EventArgs e)
        {
            List<Rooms> rooms = Rooms.GetRooms();

            foreach (Rooms room in rooms)
            {
                cbrooms.Items.Add(room);
            }
            cbrooms.SelectedIndex = 0;
            string selectedroom = cbrooms.SelectedItem.ToString();
            string roomNo = selectedroom.Split(' ')[0];
            DateTime date = calendar.SelectionStart;
            int month = date.Month;
            int year = date.Year;
            string status = "Active";
            DataSet ds = Classes.selectAllClassesWithMonthAndRoom(month, year, roomNo, status);
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void refreshTheTable()
        {
            string selectedroom = cbrooms.SelectedItem.ToString();
            string roomNo = selectedroom.Split(' ')[0];
            DateTime date = calendar.SelectionStart;
            int month = date.Month;
            int year = date.Year;
            string status = "Active";
            if (rbActive.Checked)
            {
                status = "Active";
            }
            if (rbInactive.Checked)
            {
                status = "Inactive";
            }
            DataSet ds = Classes.selectAllClassesWithMonthAndRoom(month, year, roomNo, status);
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            refreshTheTable();
        }

        private void rbInactive_Click(object sender, EventArgs e)
        {
            refreshTheTable();
        }

        private void rbActive_Click(object sender, EventArgs e)
        {
            refreshTheTable();
        }

        private void cbrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTheTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
