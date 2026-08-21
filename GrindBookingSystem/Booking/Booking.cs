using GrindBookingSystem.Schedule;
using GrindBookingSystem.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindBookingSystem.Booking
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        public int studentID;
        public DateTime dob;
        public int classID;
        public DateTime bookingDate;


        private void searchStudent_TextChanged(object sender, EventArgs e)
        {
            String name = searchStudent.Text.Trim();
            DataSet ds = Student.Students.searchStudent(name);
            if (ds.Tables.Count > 0)
            {
                studentData.DataSource = ds.Tables[0];
            }
        }

        private void studentData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = studentData.Rows[e.RowIndex];

            if (MessageBox.Show("Are you sure you want to choose this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                studentID = Convert.ToInt32(row.Cells["StudentID"].Value.ToString());
                dob = Convert.ToDateTime(row.Cells["DateOfBirth"].Value.ToString());
                gbStudent.Enabled = false;
                gbClass.Enabled = true;
                refreshTheTable();
            }
            return;
        }
        private static int calculateAge(DateTime dob)
        {
            int age = DateTime.Today.Year - dob.Year;

            if (dob.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
        private void refreshTheTable()
        {
            DateTime date = calendar.SelectionStart;
            int month = date.Month;
            int year = date.Year;
            if (calculateAge(dob) < 18)
            {
                DataSet ds = Classes.SelectClassesForUnder18(month, year);
                if (ds.Tables.Count > 0)
                {
                    dataGridView2.DataSource = ds.Tables[0];
                }
            }
            else
            {
                DataSet ds = Classes.selectAllClassesWithMonth(month, year);
                if (ds.Tables.Count > 0)
                {
                    dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            refreshTheTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            if (MessageBox.Show("Are you sure you want to choose this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView2.Enabled = false;
                classID = Convert.ToInt32(row.Cells["ClassID"].Value.ToString());
                bookingDate = Convert.ToDateTime(row.Cells["ClassDate"].Value.ToString());
            }
            else { return; }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                Bookings bookings = new Bookings(studentID, classID, bookingDate);

                
                bool bookingSuccessful = Bookings.AddBooking(studentID,classID,bookingDate);

                
                if (!bookingSuccessful)
                {
                    MessageBox.Show(
                        "This student have already booked this lesson.",
                        "Booking Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    dataGridView2.Enabled = true;

                    return;
                }

                
                DataSet ds = Student.Students.SelectStudentByID(studentID);

                
                DataSet ds2 = Schedule.Classes.SelectClassName(classID);

                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Student information could not be found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                if (ds2.Tables.Count == 0 || ds2.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Class information could not be found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                string firstName = ds.Tables[0].Rows[0]["FirstName"].ToString()!;
                string lastName = ds.Tables[0].Rows[0]["LastName"].ToString()!;
                string emailAddress = ds.Tables[0].Rows[0]["Email"].ToString()!;
                string className = ds2.Tables[0].Rows[0]["Description"].ToString()!;

                
                MessageBox.Show(
                    "Booking successful!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                
                string senderEmail = "longnon1983@gmail.com";
                string appPassword = "irks mjyr pemr fgjp";
                string recipientEmail = emailAddress.ToString();

                string emailSubject = "You were booked for the lesson!";

                string emailBody =
                    $"<h1>Hello! {firstName} {lastName}</h1>" +
                    $"<br><p>This is your booking confirmation:</p>" +
                    $"<p><b>Subject:</b> {className}</p>" +
                    $"<p><b>Booking Date:</b> {bookingDate:dd/MM/yyyy}</p>";

                GmailSender.SendEmail(senderEmail, appPassword, recipientEmail, emailSubject, emailBody);

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while creating the booking:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
