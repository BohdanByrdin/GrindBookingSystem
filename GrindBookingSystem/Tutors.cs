using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindBookingSystem
{
    internal class Tutors
    {
        public int TutorID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int SubjectID { get; set; }

        public Tutors(string firstName, string lastName, string email, string phoneNumber, int subjectID)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            SubjectID = subjectID;
        }

        public void AddTutor(string firstName, string lastName, string email, string phoneNumber, int subjectID)
        {
            //Insert a new tutor into the database
            string query = $"INSERT INTO Tutors (FirstName, LastName, Phone, Email, SubjectID) VALUES ('{firstName}', '{lastName}', '{phoneNumber}', '{email}', {subjectID})";
            Database.ExecuteNonQuery(query);
        }


    }
}
