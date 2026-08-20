using GrindBookingSystem.Tutor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrindBookingSystem.Schedule
{
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }
        public DateTime selectedDate;
        public string startTimeString;
        public string endTimeString;
        private void AddClass_Load(object sender, EventArgs e)
        {
            cbSubjects.Items.Clear();
            cbTutors.Items.Clear();
            cbRooms.Items.Clear();
            List<Subjects> subjects = Subjects.GetSubjects();
            
            List<Rooms> rooms = Rooms.GetRooms();
            foreach (Subjects subject in subjects)
            {
                cbSubjects.Items.Add(subject.Description);
            }
            foreach (Rooms room in rooms)
            {
                cbRooms.Items.Add(room);
            }

        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            int subjectID = cbSubjects.SelectedIndex+1;
            List<Tutor.Tutors> tutors = Tutor.Tutors.GetTutorsBySubgectID(subjectID);
            if (tutors.Count == 0)
            {
                MessageBox.Show("No tutors available for the selected subject.");
                return;
            }
            cbTutors.Enabled = true;
            foreach (Tutors tutor in tutors)
            {
                cbTutors.Items.Add(tutor);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            selectedDate = date.SelectionStart;

            DateTime start = startTime.Value;
            DateTime end = endTime.Value;
            if (start >= end)
            {
                MessageBox.Show("End time must be later than start time.");
                return;
            }

            if ((end - start).TotalMinutes < 59)
            {
                MessageBox.Show("The session must be at least 59 minutes.");
                return;
            }

            startTimeString = startTime.Value.ToString("HH:mm");
            endTimeString = endTime.Value.ToString("HH:mm");

            if (MessageBox.Show("Are you sure you want to leave this date and time?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                date.Enabled = false;
                startTime.Enabled = false;
                endTime.Enabled = false;
            }
            if (cbTutors.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a tutor.");
                return;
            }

            if (cbSubjects.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            if (cbRooms.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room.");
                return;
            }


            string tutor = cbTutors.Text;
            string subject = cbSubjects.Text;
            string room = cbRooms.Text;

            dataGridView1.Rows.Add(
                tutor,
                subject,
                room,
                selectedDate.ToString("dd/MM/yyyy"),
                start.ToString("HH:mm"),
                end.ToString("HH:mm")
            );
            saveTheClass.Enabled = true;
        }

        private void saveTheClass_Click(object sender, EventArgs e)
        {
            if (cbSubjects.SelectedIndex == -1 || cbTutors.SelectedIndex == -1 || cbRooms.SelectedIndex==-1) { 
            MessageBox.Show("Please select a subject, tutor, or room before saving the class.");
                return;
            }
            int subjectID = cbSubjects.SelectedIndex + 1;
            Tutors selectedTutor = (Tutors)cbTutors.SelectedItem;

            int tutorId = selectedTutor.TutorID;
            string selectedRoom = cbRooms.SelectedItem.ToString()!;
            string roomID = selectedRoom.Split('-')[0].Trim();
            if (Classes.checkClassOverlap(tutorId.ToString(), roomID, selectedDate, startTimeString, endTimeString))
            {
                MessageBox.Show("The selected tutor or room is already booked for this time slot. Please choose a different time or tutor/room.");
                date.Enabled = true;
                startTime.Enabled = true;
                endTime.Enabled = true;
                return;
            }
            Classes newClass = new Classes(subjectID, tutorId, roomID, selectedDate, startTimeString, endTimeString);
            newClass.AddClass(subjectID, tutorId, roomID, selectedDate, startTimeString, endTimeString);
            MessageBox.Show("Class added successfully!");
            return;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
