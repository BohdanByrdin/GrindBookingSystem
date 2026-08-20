using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrindBookingSystem.Schedule
{
    internal class Classes
    {
        public int ClassID { get; set; }
        public int SubjectID { get; set; }
        public int TutorID { get; set; }
        public string RoomNo { get; set; }
        public DateTime ClassDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public string Status { get; set; } = "Active";

        public Classes(int classID, int subject, int tutor, string room, DateTime date, string startTime, string endTime)
        {
            ClassID = classID;
            SubjectID = subject;
            TutorID = tutor;
            RoomNo = room;
            ClassDate = date;
            StartTime = startTime;
            EndTime = endTime;
        }
        public Classes(int subject, int tutor, string room, DateTime date, string startTime, string endTime)
        {
            SubjectID = subject;
            TutorID = tutor;
            RoomNo = room;
            ClassDate = date;
            StartTime = startTime;
            EndTime = endTime;
        }

        public void AddClass(int subject, int tutor, string room, DateTime date, string startTime, string endTime)
        {
            string query =
    $"INSERT INTO Classes " +
    $"(SubjectID, TutorID, RoomNo, ClassDate, StartTime, EndTime,Status) " +
    $"VALUES " +
    $"({subject}, {tutor}, '{room}', " +
    $"TO_DATE('{date:yyyy-MM-dd}', 'YYYY-MM-DD'), " +
    $"'{startTime}', '{endTime}', '{Status}')";


            Database.ExecuteNonQuery(query);
        }
        public static Boolean checkClassOverlap(string tutorID, string roomNo, DateTime date, string startTime, string endTime)
        {
            string query = $"SELECT * FROM Classes WHERE (TutorID = '{tutorID}' OR RoomNo = '{roomNo}') AND ClassDate = TO_DATE('{date:yyyy-MM-dd}', 'YYYY-MM-DD') AND ((StartTime < '{endTime}' AND EndTime > '{startTime}'))";
            DataSet ds = Database.ExecuteMultiRowQuery(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static bool CheckClassOverlapForUpdate(int classID,int tutorID,string roomNo,DateTime date,string startTime,string endTime)
        {
            string query = $@"
        SELECT ClassID
        FROM Classes
        WHERE ClassID <> {classID}
          AND (TutorID = {tutorID} OR RoomNo = '{roomNo}')
          AND ClassDate = TO_DATE('{date:yyyy-MM-dd}', 'YYYY-MM-DD')
          AND StartTime < '{endTime}'
          AND EndTime > '{startTime}'";

            DataSet ds = Database.ExecuteMultiRowQuery(query);

            return ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0;
        }
        public static DataSet selectAllClassesWithMonth(int month, int year)
        {
            string query =
         $"SELECT * FROM Classes " +
         $"WHERE TO_CHAR(ClassDate, 'MM') = '{month:00}' " +
         $"AND TO_CHAR(ClassDate, 'YYYY') = '{year}' " +
         $"AND Status = 'Active'";

            return Database.ExecuteMultiRowQuery(query);
        }
        public static void RemoveClass(int classID)
        {
            string query = $"UPDATE Classes SET Status = 'Inactive' WHERE ClassID = {classID}";
            Database.ExecuteNonQuery(query);
        }
        public static DataSet selectAllClassesWithMonthAndRoom(int month, int year, string roomNo, string status)
        {
            string query =
         $"SELECT * FROM Classes " +
         $"WHERE TO_CHAR(ClassDate, 'MM') = '{month:00}' " +
         $"AND TO_CHAR(ClassDate, 'YYYY') = '{year}' " +
         $"AND RoomNo = '{roomNo}' " +
         $"AND Status = '{status}'";
            return Database.ExecuteMultiRowQuery(query);
        }
        public static DataSet selectAllClassesWithMonthAndStatus(int month, int year, string status)
        {
            string query =
         $"SELECT * FROM Classes " +
         $"WHERE TO_CHAR(ClassDate, 'MM') = '{month:00}' " +
         $"AND TO_CHAR(ClassDate, 'YYYY') = '{year}' " +
         $"AND Status = '{status}'";
            return Database.ExecuteMultiRowQuery(query);
        }
        public void UpdateClass(int classID, int subject, int tutor, string room, DateTime date, string startTime, string endTime)
        {
            string query = $"UPDATE Classes SET SubjectID = {subject}, TutorID = {tutor}, RoomNo = '{room}', ClassDate = TO_DATE('{date:yyyy-MM-dd}', 'YYYY-MM-DD'), StartTime = '{startTime}', EndTime = '{endTime}' WHERE ClassID = {classID}";
            Database.ExecuteNonQuery(query);
        }
        public static DataSet SelectClassesForUnder18(int month,int year)
        {
            string query =
        $"SELECT s.Description, t.FirstName, t.LastName,c.*  " +
        $"FROM Classes c " +
        $"JOIN Subjects s ON c.SubjectID = s.SubjectID " +
        $"JOIN Tutors t ON c.TutorID = t.TutorID " +   
        $"WHERE TO_CHAR(c.ClassDate, 'MM') = '{month:00}' " +
        $"AND TO_CHAR(c.ClassDate, 'YYYY') = '{year}' " +
        $"AND c.Status = 'Active' " +
        $"AND s.Category = 'LC'";
            return Database.ExecuteMultiRowQuery(query);
        }
        public static DataSet SelectClassName(int classId)
        {
            string query = $"SELECT c.*, s.Description FROM Classes c JOIN Subjects s ON c.SubjectID = s.SubjectID WHERE c.ClassID = {classId}";
            return Database.ExecuteMultiRowQuery(query);
        }
    }
}
