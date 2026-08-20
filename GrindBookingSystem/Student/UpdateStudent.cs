using GrindBookingSystem.Tutor;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GrindBookingSystem.Student
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            DataSet ds = Students.SelectAllStudents();

            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                gbDetails.Visible = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                studentIDtxt.Text = row.Cells["StudentID"].Value.ToString()!;
                fnametxt.Text = row.Cells["FirstName"].Value.ToString()!;
                lnametxt.Text = row.Cells["LastName"].Value.ToString()!;
                emailtxt.Text = row.Cells["Email"].Value.ToString()!;
                phonetxt.Text = row.Cells["Phone"].Value.ToString()!;
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["dateofbirth"].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string pattern = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";

            Regex rg = new Regex(pattern);

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

            MessageBox.Show("Student updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Refresh the DataGridView
            DataSet ds = Students.SelectAllStudents();
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }


        }
        private bool isSpecialCharacter(string input)
        {
            return Regex.IsMatch(input, @"[!@#$%^&*(),.?""':{}|<>]");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
        }

        private void btnCloseUpdate_Click(object sender, EventArgs e)
        {
            gbDetails.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gbDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
