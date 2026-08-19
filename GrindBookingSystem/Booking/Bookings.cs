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

        public void AddBooking(int studentID, int classID, DateTime bookingDate)
        {
            string query = $"INSERT INTO Bookings (StudentID, ClassID, BookingDate, Status) VALUES ({studentID}, {classID}, TO_DATE('{bookingDate:yyyy-MM-dd}', 'YYYY-MM-DD'), '{Status}')";
            Database.ExecuteNonQuery(query);
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
    }
}
