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
    public partial class StudentMainPage : Form
    {
        public StudentMainPage()
        {
            InitializeComponent();
        }

        private void checkMyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkMyProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentDetailsPage studentDetails = new StudentDetailsPage();
            studentDetails.Show();
        }

        private void StudentMainPage_Load(object sender, EventArgs e)
        {

        }

        private void bookForClassToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MakeBooking makeBooking = new MakeBooking();
            makeBooking.Show();

        }

        private void checkMyBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBookings checkBookings = new CheckBookings();
            checkBookings.Show();
        }
    }
}
