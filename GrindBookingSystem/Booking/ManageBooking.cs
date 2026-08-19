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
        public int bookID;
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
            DataSet ds = Bookings.selectBookingWithMonthYearAndStatus(month, year, status);
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void ManageBooking_Load(object sender, EventArgs e)
        {
            refreshTheTable();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex <= 0 || e.RowIndex >= dataGridView1.Rows.Count)
                {

                    bookID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BookingID"].Value);
                    int classID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ClassID"].Value);
                    int studentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value);
                    DataSet ds = Classes.SelectClassName(classID);
                    DataSet ds1 = Student.Students.SelectStudentByID(studentID);

                    if (ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0)
                    {
                        DataRow row1 = ds1.Tables[0].Rows[0];
                        studentName.Text = row1["FirstName"].ToString() + " " + row1["LastName"].ToString();
                    }
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        className.Text = row["Description"].ToString();
                    }
                    bookingID.Text = bookID.ToString();
                    bookingDate.Text = dataGridView1.Rows[e.RowIndex].Cells["BookingDate"].Value.ToString();
                    status.Text = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                }
                gbDetails.Visible = true;
                gbMonth.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving booking details: " + ex.Message);
                return;

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbDetails.Visible = false;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Bookings booking = new Bookings(0, 0, DateTime.Now);
            booking.CancelBooking(bookID);
            MessageBox.Show("Booking cancelled successfully.");
            gbDetails.Visible = false;
            refreshTheTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
