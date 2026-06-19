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
    public partial class AddTutor : Form
    {
        public AddTutor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddTutor_Load(object sender, EventArgs e)
        {
            cbSubjects.Items.Clear();
            List<Subjects> subjects = Subjects.GetSubjects();
            foreach (Subjects subject in subjects)
            {
                cbSubjects.Items.Add(subject.Description);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string pattern = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";

            Regex rg = new Regex(pattern);

            string firstName = tb_FirstName.Text.Trim();
            string lastName = tb_LastName.Text.Trim();
            string email = tb_Email.Text.Trim();
            string phoneNumber = tb_Phone.Text.Trim();
            int subjectID = cbSubjects.SelectedIndex + 1;

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
            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit)) { 
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

           
            DataSet ds = Tutors.SelectTutor(firstName, lastName, email, phoneNumber, subjectID);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                Tutors tutor = new Tutors(firstName, lastName, email, phoneNumber, subjectID);

                tutor.AddTutor(firstName, lastName, email, phoneNumber, subjectID);

                MessageBox.Show("Tutor added successfully!");
            }
            else
            {
                MessageBox.Show("Tutor already exists", "Error");
                return;
            }

            tb_Email.Clear();
            tb_FirstName.Clear();
            tb_LastName.Clear();
            tb_Phone.Clear();
        }

        private bool isSpecialCharacter(string input)
        {
            return Regex.IsMatch(input, @"[!@#$%^&*(),.?""':{}|<>]");
        }
    }
}
