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
    }
}
