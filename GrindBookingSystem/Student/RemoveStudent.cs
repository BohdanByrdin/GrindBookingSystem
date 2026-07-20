using GrindBookingSystem.Student;
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
    public partial class RemoveStudent : Form
    {
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            DataSet ds = Students.SelectAllStudents();

            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbDetails.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                studentIDtxt.Text = row.Cells["StudentID"].Value.ToString()!;
                fnametxt.Text = row.Cells["FirstName"].Value.ToString()!;
                lnametxt.Text = row.Cells["LastName"].Value.ToString()!;
                emailtxt.Text = row.Cells["Email"].Value.ToString()!;
                phonetxt.Text = row.Cells["Phone"].Value.ToString()!;
                dobtxt.Text = row.Cells["DateOfBirth"].Value.ToString()!;
            }
        }

        private void tutorIDtxt_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentIDtxt != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this Student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int studentID = Convert.ToInt32(studentIDtxt.Text);
                    Students.RemoveStudent(studentID);
                    MessageBox.Show("Student deleted successfully", "Success");
                }
                else
                {
                    MessageBox.Show("Student deletion cancelled", "Cancelled");
                }
                gbDetails.Visible = false;
                fnametxt.Clear();
                lnametxt.Clear();
                emailtxt.Clear();
                phonetxt.Clear();
                DataSet ds = Students.SelectAllStudents();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCloseUpdate_Click(object sender, EventArgs e)
        {
            gbDetails.Visible = false;
            fnametxt.Clear();
            lnametxt.Clear();
            emailtxt.Clear();
            phonetxt.Clear();
        }
    }
}
