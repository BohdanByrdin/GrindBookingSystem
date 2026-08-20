using GrindBookingSystem.Booking;
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

namespace GrindBookingSystem
{
    public partial class CheckBookings : Form
    {
        public CheckBookings()
        {
            InitializeComponent();
        }
        public DataSet currentStudent = Student.Students.SelectStudentByID(Session.CurrentStudent.StudentID);
        public int studentID = Session.CurrentStudent.StudentID;
        public int bookID;
        private void Closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckBookings_Load(object sender, EventArgs e)
        {
            refreshTheTable();
        }

        private void refreshTheTable()
        {
            DateTime date = calendar.SelectionStart;
            int month = date.Month;
            int year = date.Year;

            DataSet ds = Bookings.SelectBookingByStudentID(studentID, month, year);
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            gbDetails.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {

                    bookID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BookingID"].Value);

                    bookingID.Text = bookID.ToString();
                    bookingDate.Text = dataGridView1.Rows[e.RowIndex].Cells["BookingDate"].Value.ToString();
                    className.Text = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                    status.Text = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                }
                gbDetails.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving booking details: " + ex.Message);
                return;

            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Bookings.CancelBooking(bookID);
            MessageBox.Show("Booking cancelled successfully.");
            gbDetails.Visible = false;
            refreshTheTable();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            refreshTheTable();
        }
    }
}
