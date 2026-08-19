using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindBookingSystem.Booking
{
    internal class Bookings
    {
        public int BookingID { get; set; }
        public int StudentID { get; set; }
        public int ClassID { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; } = "Active";
        public Bookings(int studentID, int classID, DateTime bookingDate)
        {
            StudentID = studentID;
            ClassID = classID;
            BookingDate = bookingDate;
        }

        public static bool AddBooking(int studentID, int classID, DateTime bookingDate)
        {
            if (HasExistingBooking(studentID, classID))
            {
                return false;
            }

            string query = $"INSERT INTO Bookings " +
                           $"(StudentID, ClassID, BookingDate, Status) " +
                           $"VALUES ({studentID}, {classID}, " +
                           $"TO_DATE('{bookingDate:yyyy-MM-dd}', 'YYYY-MM-DD'), " +
                           $"'Active')";

            Database.ExecuteNonQuery(query);

            return true;
        }

        public static DataSet selectBookingWithMonthYearAndStatus(int month, int year,string status)
        {
            string query = $"SELECT * FROM Bookings WHERE EXTRACT(MONTH FROM BookingDate) = {month} AND EXTRACT(YEAR FROM BookingDate) = {year} AND Status = '{status}'";
            return Database.ExecuteMultiRowQuery(query);
        }
        public void CancelBooking(int bookingID)
        {
            string query = $"UPDATE Bookings SET Status = 'Cancelled' WHERE BookingID = {bookingID}";
            Database.ExecuteNonQuery(query);
        }
        public static bool HasExistingBooking(int studentID, int classID)
        {
            string query = $"SELECT COUNT(*) FROM Bookings " +
                           $"WHERE StudentID = {studentID} " +
                           $"AND ClassID = {classID} " +
                           $"AND Status = 'Active'";

            DataSet ds = Database.ExecuteMultiRowQuery(query);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                return count > 0;
            }

            return false;
        }
    }
}
