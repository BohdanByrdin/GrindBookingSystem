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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string pattern = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";

            Regex rg = new Regex(pattern);

            string firstName = fname.Text.Trim();
            string lastName = lname.Text.Trim();
            string emailAddress = email.Text.Trim();
            string phoneNumber = phone.Text.Trim();
            string dateofbirth = date.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please fill in all fields", "Error");
                return;
            }
            if (!rg.IsMatch(emailAddress))
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
            DateTime birthDate = DateTime.ParseExact(dateofbirth,"yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture);

            int age = DateTime.Today.Year - birthDate.Year;

            if (birthDate.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            if (age < 6)
            {
                MessageBox.Show("Student must be at least 6 years old", "Error");
                return;
            }


            DataSet ds = Students.SelectStudent(firstName, lastName, emailAddress, phoneNumber, dateofbirth);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                Students student = new Students(firstName, lastName, emailAddress, phoneNumber, dateofbirth);
                student.AddStudent(firstName, lastName, emailAddress, phoneNumber, dateofbirth);
                MessageBox.Show("Student added successfully!");
            }
            else
            {
                MessageBox.Show("Student already exists", "Error");
                return;
            }

            email.Clear();
            fname.Clear();
            lname.Clear();
            phone.Clear();
        }

        private bool isSpecialCharacter(string input)
        {
            return Regex.IsMatch(input, @"[!@#$%^&*(),.?""':{}|<>]");
        }
    }
}
