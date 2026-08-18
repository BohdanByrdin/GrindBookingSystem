using GrindBookingSystem.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindBookingSystem.Booking
{
    public partial class ManageBooking : Form
    {
        public ManageBooking()
        {
            InitializeComponent();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            refreshTheTable();
        }
        private void refreshTheTable()
        {
            DateTime date = calendar.SelectionStart;
            int month = date.Month;
            int year = date.Year;
            string status = "Active";
            DataSet ds = Bookings.selectBookingWithMonthYearAndStatus(month,year,status) ;
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void ManageBooking_Load(object sender, EventArgs e)
        {
            refreshTheTable();
        }
    }
}
