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
    }
}
