using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindBookingSystem
{
    internal class Students
    {
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

        public static DataSet SelectStudent(string firstName, string lastName, string email, string phoneNumber, string dateOfBirth)
        {
            //Select a student from the database
            string query = $"SELECT * FROM Students WHERE FirstName = '{firstName}' AND LastName = '{lastName}' AND Phone = '{phoneNumber}' AND Email = '{email}' AND DateOfBirth = '{dateOfBirth}' AND Status = 'Active'";
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
    }
}
