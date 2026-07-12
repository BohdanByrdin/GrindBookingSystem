using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GrindBookingSystem
{
    public partial class DeleteTutor : Form
    {
        public DeleteTutor()
        {
            InitializeComponent();
        }

        private void DeleteTutor_Load(object sender, EventArgs e)
        {
            DataSet ds = Tutors.SelectAllTutors();

            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
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
                Subject.Text = row.Cells["SubjectName"].Value.ToString()!;
            }
        }

        private void btnCloseUpdate_Click(object sender, EventArgs e)
        {
            gbDetails.Visible = false;
            fnametxt.Clear();
            lnametxt.Clear();
            emailtxt.Clear();
            phonetxt.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            tutorIDtxt.Text = dataGridView1.CurrentRow.Cells["TutorID"].Value.ToString()!;
            if (tutorIDtxt != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this tutor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int tutorID = Convert.ToInt32(tutorIDtxt.Text);
                    Tutors.DeleteTutor(tutorID);
                    MessageBox.Show("Tutor deleted successfully", "Success");
                }
                else
                {
                    MessageBox.Show("Tutor deletion cancelled", "Cancelled");
                }
                gbDetails.Visible = false;
                fnametxt.Clear();
                lnametxt.Clear();
                emailtxt.Clear();
                phonetxt.Clear();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

