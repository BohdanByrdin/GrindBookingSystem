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
        public DateTime newSelectedDate;
        public string newStartTimeString;
        public string newEndTimeString;
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

            if (tutorIndex >= 0 && roomIndex >= 0)
            {
                cbTutors.SelectedIndex = tutorIndex;
                cbRooms.SelectedIndex = roomIndex;
            }
            cbSubjects.SelectedIndex = subjectID - 1;

            DateTime classDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["ClassDate"].Value);
            DateTime start = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["startTime"].Value);
            DateTime end = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["endTime"].Value);
            date.SelectionStart = classDate;

            startTime.Value = start;
            endTime.Value = end;


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

        private void saveTimeAndDate_Click(object sender, EventArgs e)
        {
            Update.Enabled = true;
            newSelectedDate = date.SelectionStart;
            newStartTimeString = startTime.Value.ToString("HH:mm");
            newEndTimeString = endTime.Value.ToString("HH:mm");
            date.Enabled = false;
            startTime.Enabled = false;
            endTime.Enabled = false;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            int classID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ClassID"].Value);
            int subjectID = cbSubjects.SelectedIndex + 1;
            Tutors selectedTutor = (Tutors)cbTutors.SelectedItem;

            int tutorId = selectedTutor.TutorID;
            string selectedRoom = cbRooms.SelectedItem.ToString()!;
            string roomID = selectedRoom.Split('-')[0].Trim();
            if (Classes.CheckClassOverlapForUpdate(classID, tutorId, roomID, newSelectedDate, newStartTimeString, newEndTimeString))
            {
                MessageBox.Show("The selected tutor or room is already booked for this time slot. Please choose a different time or tutor/room.");
                date.Enabled = true;
                startTime.Enabled = true;
                endTime.Enabled = true;
                return;
            }
            Classes updateClass = new Classes(subjectID, tutorId, roomID, newSelectedDate, newStartTimeString, newEndTimeString);
            updateClass.UpdateClass(classID, subjectID, tutorId, roomID, newSelectedDate, newStartTimeString, newEndTimeString);
            MessageBox.Show("Class updated successfully!");
            refreshTheTable();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbDetails.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
