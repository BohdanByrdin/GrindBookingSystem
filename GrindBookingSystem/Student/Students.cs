using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindBookingSystem.Student
{
    internal class Students
    {
        int StudentID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string DateOfBirth { get; set; }
        string Status { get; set; } = "Active";

        public Students(string firstName, string lastName, string email, string phoneNumber, string dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
        }
        public Students(int studentID, string firstName, string lastName, string email, string phoneNumber, string dateOfBirth)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
        }

        public static DataSet SelectStudent(string firstName, string lastName, string email, string phoneNumber, string dateOfBirth)
        {
            //Select a student from the database
            string query = $"SELECT * FROM Students WHERE FirstName = '{firstName}' AND LastName = '{lastName}' AND Phone = '{phoneNumber}' AND Email = '{email}' AND DateOfBirth = '{dateOfBirth}' AND Status = 'Active'";
            return Database.ExecuteMultiRowQuery(query);
        }
        public static DataSet SelectAllStudents()
        {
            //Select all students from the database
            string query = "SELECT * FROM Students WHERE Status = 'Active'";
            return Database.ExecuteMultiRowQuery(query);
        }

        public void AddStudent(string firstName, string lastName, string email, string phoneNumber, string dateOfBirth)
        {
            //Insert a new student into the database
            string query = $@"
INSERT INTO Students
(FirstName, LastName, Phone, Email, DateOfBirth, Status)
VALUES
('{firstName}',
 '{lastName}',
 '{phoneNumber}',
 '{email}',
 TO_DATE('{dateOfBirth}', 'YYYY-MM-DD'),
 '{Status}')";
            Database.ExecuteNonQuery(query);
        }

        public static void RemoveStudent(int StudentID)
        {
            //Remove a student from the database
            string query = $"UPDATE Students SET Status = 'Inactive' WHERE StudentID = '{StudentID}'";
            Database.ExecuteNonQuery(query);
        }
        public void UpdateStudent(int studentID, string firstName, string lastName, string email, string phoneNumber, string dateOfBirth)
        {
            //Update a student in the database
            string query = $@"UPDATE Students SET FirstName = '{firstName}', LastName = '{lastName}', Phone = '{phoneNumber}', Email = '{email}', DateOfBirth = TO_DATE('{dateOfBirth}', 'YYYY-MM-DD') WHERE StudentID = {studentID}";
            Database.ExecuteNonQuery(query);
        }
        public static  DataSet searchStudent(string Name)
        {
            string query = $@"
    SELECT *
    FROM Students
    WHERE Status = 'Active'
      AND (
          UPPER(FirstName) LIKE UPPER('%{Name}%')
          OR UPPER(LastName) LIKE UPPER('%{Name}%')
      )";
            return Database.ExecuteMultiRowQuery(query);
        }
    }
}
