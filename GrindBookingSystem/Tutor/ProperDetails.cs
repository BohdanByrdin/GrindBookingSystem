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

namespace GrindBookingSystem
{
    public partial class ProperDetails : Form
    {
        public Tutors SelectedTutor { get; set; }
        public ProperDetails()
        {
            InitializeComponent();
        }

        private void ProperDetails_Load(object sender, EventArgs e)
        {
            fnametxt.Text = SelectedTutor.FirstName;
            lnametxt.Text = SelectedTutor.LastName;
            emailtxt.Text = SelectedTutor.Email;
            phonetxt.Text = SelectedTutor.PhoneNumber;
            subNametxt.Text = SelectedTutor.SubjectName;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
