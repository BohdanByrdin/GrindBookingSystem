using GrindBookingSystem.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindBookingSystem
{
    public partial class StudentDetailsPage : Form
    {
        public StudentDetailsPage()
        {
            InitializeComponent();
        }
        private void StudentDetailsPage_Load(object sender, EventArgs e)
        {
            DataSet ds = Student.Students.SelectStudentByID(Session.CurrentStudent.StudentID);
            if (ds != null)
            {
                studentIDtxt.Text = ds.Tables[0].Rows[0]["StudentID"].ToString();
                fnametxt.Text = ds.Tables[0].Rows[0]["FirstName"].ToString();
                lnametxt.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
                emailtxt.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                phonetxt.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["dateofbirth"]);
            }
        }

        private void btnCloseUpdate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            string pattern = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";

            Regex rg = new Regex(pattern);
            DataSet ds = Student.Students.SelectStudentByID(Session.CurrentStudent.StudentID);
            int studentID = int.Parse(studentIDtxt.Text);
            string firstName = fnametxt.Text.Trim();
            string lastName = lnametxt.Text.Trim();
            string email = emailtxt.Text.Trim();
            string phoneNumber = phonetxt.Text.Trim();
            string dateofbirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please fill in all fields", "Error");
                return;
            }
            if (!rg.IsMatch(email))
            {
                MessageBox.Show("Please enter a valid email address", "Error");
                return;
            }
            if (isSpecialCharacter(firstName) || isSpecialCharacter(lastName))
            {
                MessageBox.Show("First name and last name cannot contain special characters", "Error");
                return;
            }
            if (phoneNumber.Length != 10)
            {
                MessageBox.Show("Phone number must be 10 digits long", "Error");
                return;
            }
            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit))
            {
                MessageBox.Show("First name and last name cannot contain numbers", "Error");
                return;
            }
            if (isSpecialCharacter(phoneNumber))
            {
                MessageBox.Show("Please enter a valid phone number", "Error");
                return;
            }
            if (!phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain only digits", "Error");
                return;
            }

            Students student = new Students(studentID, firstName, lastName, email, phoneNumber, dateofbirth);
            student.UpdateStudent(studentID, firstName, lastName, email, phoneNumber, dateofbirth);

            MessageBox.Show("Student status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool isSpecialCharacter(string input)
        {
            return Regex.IsMatch(input, @"[!@#$%^&*(),.?""':{}|<>]");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
        }
    }
}
