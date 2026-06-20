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
    public partial class UpdateTutor : Form
    {
        public UpdateTutor()
        {
            InitializeComponent();
        }

        private void UpdateTutor_Load(object sender, EventArgs e)
        {
            DataSet ds = Tutors.SelectAllTutors();

            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseUpdate_Click(object sender, EventArgs e)
        {
            gbDetails.Visible = false;
            fnametxt.Clear();
            lnametxt.Clear();
            emailtxt.Clear();
            phonetxt.Clear();
            cbSubjects.SelectedIndex = -1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                gbDetails.Visible = true;
                tutorIDtxt.Text = row.Cells["TutorID"].Value.ToString()!;
                fnametxt.Text = row.Cells["FirstName"].Value.ToString()!;
                lnametxt.Text = row.Cells["LastName"].Value.ToString()!;
                emailtxt.Text = row.Cells["Email"].Value.ToString()!;
                phonetxt.Text = row.Cells["Phone"].Value.ToString()!;

                cbSubjects.Items.Clear();
                List<Subjects> subjects = Subjects.GetSubjects();
                foreach (Subjects subject in subjects)
                {
                    cbSubjects.Items.Add(subject.Description);
                }
                cbSubjects.SelectedItem = row.Cells["SubjectName"].Value.ToString()!;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string pattern = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";

            Regex rg = new Regex(pattern);

            int tutorID = int.Parse(tutorIDtxt.Text);
            string firstName = fnametxt.Text.Trim();
            string lastName = lnametxt.Text.Trim();
            string email = emailtxt.Text.Trim();
            string phoneNumber = phonetxt.Text.Trim();
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

            Tutors tutor = new Tutors(firstName, lastName, email, phoneNumber, subjectID);
            if (tutor != null)
            {
                tutor.UpdateTutor(tutorID, firstName, lastName, email, phoneNumber, subjectID);
                MessageBox.Show("Tutor updated successfully", "Success");
                gbDetails.Visible = false;
                fnametxt.Clear();
                lnametxt.Clear();
                emailtxt.Clear();
                phonetxt.Clear();
                cbSubjects.SelectedIndex = -1;
                DataSet ds = Tutors.SelectAllTutors();
                if (ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            else
            {
                MessageBox.Show("Error updating tutor", "Error");
            }
        }
        private bool isSpecialCharacter(string input)
        {
            return Regex.IsMatch(input, @"[!@#$%^&*(),.?""':{}|<>]");
        }
    }
}
