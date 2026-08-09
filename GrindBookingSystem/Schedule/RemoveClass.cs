using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindBookingSystem.Schedule
{
    public partial class RemoveClass : Form
    {
        public RemoveClass()
        {
            InitializeComponent();
        }

        private void RemoveClass_Load(object sender, EventArgs e)
        {
            DateTime date = calendar.SelectionStart;
            int month = date.Month;
            int year = date.Year;
            DataSet ds = Classes.selectAllClassesWithMonth(month, year);
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataGridView1.DataSource = null;
            DateTime date = calendar.SelectionStart;
            int month = date.Month;
            int year = date.Year;
            DataSet ds = Classes.selectAllClassesWithMonth(month, year);
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            details.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                classIDlbl.Text = row.Cells["ClassID"].Value.ToString()!;
                subjectIDlbl.Text = row.Cells["SubjectID"].Value.ToString()!;
                tutorIDlbl.Text = row.Cells["TutorID"].Value.ToString()!;
                roomtxt.Text = row.Cells["RoomNo"].Value.ToString()!;
                datelbl.Text = row.Cells["ClassDate"].Value.ToString()!;
                startTimelbl.Text = row.Cells["StartTime"].Value.ToString()!;
                endTimelbl.Text = row.Cells["EndTime"].Value.ToString()!;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classes.RemoveClass(Convert.ToInt32(classIDlbl.Text));
            MessageBox.Show("Class removed successfully.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            details.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
