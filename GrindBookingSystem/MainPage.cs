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
    }
}
