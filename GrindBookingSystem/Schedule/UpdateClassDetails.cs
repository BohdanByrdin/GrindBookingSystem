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

namespace GrindBookingSystem.Schedule
{
    public partial class UpdateClassDetails : Form
    {
        public UpdateClassDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           gbDetails.Visible = true;
            int subjectID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SubjectID"].Value);
            int tutorID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["TutorID"].Value);

            DataSet tutor = Tutor.Tutors.SelectTutorByID(tutorID);

            DataRow row = tutor.Tables[0].Rows[0];
            string tutorName = row["FirstName"].ToString() + " " + row["LastName"].ToString();

            
            int tutorIndex = cbTutors.FindStringExact(tutorName);
            int roomIndex = cbRooms.FindString(dataGridView1.Rows[e.RowIndex].Cells["RoomNo"].Value.ToString());

            if (tutorIndex >= 0 && roomIndex>=0)
            {
                cbTutors.SelectedIndex = tutorIndex;
                cbRooms.SelectedIndex = roomIndex;
            }
            cbSubjects.SelectedIndex = subjectID - 1;
        }
        
        private void UpdateClassDetails_Load(object sender, EventArgs e)
        {
            refreshTheTable();
            List<Subjects> subjects = Subjects.GetSubjects();
            List<Tutor.Tutors> tutors = Tutor.Tutors.GetTutors();
            List<Rooms> rooms = Rooms.GetRooms();
            foreach (Subjects subject in subjects)
            {
                cbSubjects.Items.Add(subject.Description);
            }
            foreach (Tutors tutor in tutors)
            {
                cbTutors.Items.Add(tutor);
            }
            foreach (Rooms room in rooms)
            {
                cbRooms.Items.Add(room);
            }
        }
        private void refreshTheTable()
        {
            DateTime date = calendar.SelectionStart;
            int month = date.Month;
            int year = date.Year;
            string status = "Active";
            DataSet ds = Classes.selectAllClassesWithMonthAndStatus(month, year, status);
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            refreshTheTable();
        }
    }
}
