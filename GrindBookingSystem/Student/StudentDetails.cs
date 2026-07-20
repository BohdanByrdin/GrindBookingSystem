using GrindBookingSystem.Student;
using GrindBookingSystem.Tutor;
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
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
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
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                groupBox2.Visible = true;
                fnametxt.Text = row.Cells["FirstName"].Value.ToString()!;
                lnametxt.Text = row.Cells["LastName"].Value.ToString()!;
                emailtxt.Text = row.Cells["Email"].Value.ToString()!;
                phonetxt.Text = row.Cells["Phone"].Value.ToString()!;
                dobtxt.Text = row.Cells["DateofBirth"].Value.ToString()!;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            fnametxt.Clear();
            lnametxt.Clear();
            emailtxt.Clear();
            phonetxt.Clear();
        }
    }
}
