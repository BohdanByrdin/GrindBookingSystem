using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindBookingSystem
{
    public class Tutors
    {
        public int TutorID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int SubjectID { get; set; }

        public string SubjectName { get; set; }

        public Tutors(string firstName, string lastName, string email, string phoneNumber, int subjectID)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            SubjectID = subjectID;
        }
        public Tutors(string firstName, string lastName, string email, string phoneNumber, string subjectName)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            SubjectName = subjectName;
        }

        public void AddTutor(string firstName, string lastName, string email, string phoneNumber, int subjectID)
        {
            //Insert a new tutor into the database
            string query = $"INSERT INTO Tutors (FirstName, LastName, Phone, Email, SubjectID) VALUES ('{firstName}', '{lastName}', '{phoneNumber}', '{email}', {subjectID})";
            Database.ExecuteNonQuery(query);
        }

        public static DataSet SelectTutor(string firstName, string lastName, string email, string phoneNumber, int subjectID)
        {
            //Select a tutor from the database
            string query = $"SELECT * FROM Tutors WHERE FirstName = '{firstName}' AND LastName = '{lastName}' AND Phone = '{phoneNumber}' AND Email = '{email}' AND SubjectID = {subjectID}";
            return Database.ExecuteMultiRowQuery(query);
        }

        public static DataSet SelectAllTutors()
        {

            string query = @"
SELECT t.TutorID,
       t.FirstName,
       t.LastName,
       t.Email,
       t.Phone,
       t.SubjectID,
       s.Description AS SubjectName
FROM Tutors t
JOIN Subjects s ON t.SubjectID = s.SubjectID";

            return Database.ExecuteMultiRowQuery(query);
        }
        public void UpdateTutor(int tutorID, string firstName, string lastName, string email, string phoneNumber, int subjectID)
        {
            //Update a tutor in the database
            string query = $"UPDATE Tutors SET FirstName = '{firstName}', LastName = '{lastName}', Phone = '{phoneNumber}', Email = '{email}', SubjectID = {subjectID} WHERE TutorID = {tutorID}";
            Database.ExecuteNonQuery(query);
        }


    }
}
