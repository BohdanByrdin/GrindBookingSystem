using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    $"(SubjectID, TutorID, RoomNo, ClassDate, StartTime, EndTime) " +
    $"VALUES " +
    $"({subject}, {tutor}, '{room}', " +
    $"TO_DATE('{date:yyyy-MM-dd}', 'YYYY-MM-DD'), " +
    $"'{startTime}', '{endTime}')";


            Database.ExecuteNonQuery(query);
        }
        public static Boolean checkClassOverlap(string tutorID, string roomNo, DateTime date, string startTime, string endTime)
        {
            string query = $"SELECT * FROM Classes WHERE (TutorID = '{tutorID}' OR RoomNo = '{roomNo}') AND ClassDate = TO_DATE('{date:yyyy-MM-dd}', 'YYYY-MM-DD') AND ((StartTime < '{endTime}' AND EndTime > '{startTime}'))";
            var ds = Database.ExecuteMultiRowQuery(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
