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
    public partial class AddTutor : Form
    {
        public AddTutor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddTutor_Load(object sender, EventArgs e)
        {
            cbSubjects.Items.Clear();
            List<Subjects> subjects = Subjects.GetSubjects();
            foreach (Subjects subject in subjects)
            {
                cbSubjects.Items.Add(subject.Description);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = tb_FirstName.Text;
            string lastName = tb_LastName.Text;
            string email = tb_Email.Text;
            string phoneNumber = tb_Phone.Text;  
            int subjectID = cbSubjects.SelectedIndex + 1;

            Tutors tutor = new Tutors(firstName, lastName, email, phoneNumber, subjectID);

            tutor.AddTutor(firstName, lastName, email, phoneNumber, subjectID);

            MessageBox.Show("Tutor added successfully!");
        }
    }
}
