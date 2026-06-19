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
    public partial class DisplayTutorDetails : Form
    {
        public DisplayTutorDetails()
        {
            InitializeComponent();
        }

        private void DisplayTutorDetails_Load(object sender, EventArgs e)
        {
            DataSet ds = Tutors.SelectAllTutors();

            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                Tutors selectedTutor = new Tutors(
                    row.Cells["FirstName"].Value.ToString()!,
                    row.Cells["LastName"].Value.ToString()!,
                    row.Cells["Email"].Value.ToString()!,
                    row.Cells["Phone"].Value.ToString()!,
                    row.Cells["SubjectName"].Value.ToString()!
                );

                ProperDetails form = new ProperDetails();
                form.SelectedTutor = selectedTutor;

                form.ShowDialog();
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
