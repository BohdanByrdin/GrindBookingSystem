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
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            cbSubjects.Items.Clear();
            cbTutors.Items.Clear();
            cbRooms.Items.Clear();
            List<Subjects> subjects = Subjects.GetSubjects();
            List<Tutor.Tutors> tutors = Tutor.Tutors.GetTutors();
            List<Rooms> rooms = Rooms.GetRooms();
            foreach (Subjects subject in subjects)
            {
                cbSubjects.Items.Add(subject.Description);
            }
            foreach (Tutors tutor in tutors)
            {
                cbTutors.Items.Add(tutor.FirstName + " " + tutor.LastName);
            }
            foreach (Rooms room in rooms)
            {
                cbRooms.Items.Add(room.RoomNo + " - " + room.Description);
            }

        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
