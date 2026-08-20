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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GrindBookingSystem
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }
        public int number;
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            tbEmail.Text = tbEmail.Text.Trim();
            DataSet ds = Student.Students.SelectStudentByEmail(tbEmail.Text);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    // TODO: validate password here too, if not already done inside SelectStudentByEmail
                    int studentID = Convert.ToInt32(row["StudentID"]);
                    string FirstName = row["FirstName"].ToString();
                    string LastName = row["LastName"].ToString();
                    string Email = row["Email"].ToString();
                    string Phone = row["Phone"].ToString();
                    string dateOfBirth = row["DateOfBirth"].ToString();
                    Session.CurrentStudent = new Students(studentID,FirstName,LastName,Email,Phone, dateOfBirth);
                    
                    string firstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                    string lastName = ds.Tables[0].Rows[0]["LastName"].ToString();
                    Random random = new Random();

                    number = random.Next(1, 101);

                    string senderEmail = "longnon1983@gmail.com";
                    string appPassword = "irks mjyr pemr fgjp";
                    string recipientEmail = tbEmail.Text;
                    string emailSubject = "You are added to the System";
                    string emailBody = $"<h1>Hello! {firstName + " " + lastName}</h1><p>This is your number to enter to the system:{number}</p>";

                    GmailSender.SendEmail(senderEmail, appPassword, recipientEmail, emailSubject, emailBody);

                    label2.Visible = true;
                    tbNumber.Visible = true;
                    submitbtn.Visible = true;
                }
                else
                {
                    // Student does not exist, show error message
                    MessageBox.Show("Student with the provided email does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            tbNumber.Text = tbNumber.Text.Trim();
            int enteredNumber = Convert.ToInt32(tbNumber.Text);
            if (enteredNumber == number)
            {
                StudentMainPage studentMainPage = new StudentMainPage();
                studentMainPage.Show();
            }
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNumber.Text) && !tbNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNumber.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}
