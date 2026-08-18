namespace GrindBookingSystem
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addtutor_btn_Click(object sender, EventArgs e)
        {
            AddTutor addTutorForm = new AddTutor();
            addTutorForm.Show();
        }

        private void displayTutorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayTutorDetails displayTutorDetailsForm = new DisplayTutorDetails();
            displayTutorDetailsForm.Show();
        }

        private void updateTutorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTutor updateTutorForm = new UpdateTutor();
            updateTutorForm.Show();
        }

        private void removeTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTutor removeTutorForm = new DeleteTutor();
            removeTutorForm.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent();
            addStudentForm.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent removeStudentForm = new RemoveStudent();
            removeStudentForm.Show();
        }

        private void displayStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails studentDetailsForm = new StudentDetails();
            studentDetailsForm.Show();
        }

        private void updateStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.UpdateStudent updateStudentForm = new Student.UpdateStudent();
            updateStudentForm.Show();
        }

        private void addClassToScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule.AddClass addClassForm = new Schedule.AddClass();
            addClassForm.Show();
        }

        private void removeClassFromScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule.RemoveClass removeClassForm = new Schedule.RemoveClass();
            removeClassForm.Show();
        }

        private void displayRoomScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule.DisplayShedule displayShedule = new Schedule.DisplayShedule();
            displayShedule.Show();
        }

        private void updateClassDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule.UpdateClassDetails updateClassDetails = new Schedule.UpdateClassDetails();
            updateClassDetails.Show();
        }

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking.Booking makeBookingForm = new Booking.Booking();
            makeBookingForm.Show();
        }

        private void manageBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking.ManageBooking manageBookingForm = new Booking.ManageBooking();
            manageBookingForm.Show();
        }
    }
}
