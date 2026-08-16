using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindBookingSystem
{
    internal class Subjects
    {
        public int SubjectID { get; set; }
        public string Description { get; set; }
        public string SubjectLevel { get; set; }
        public string Category { get; set; }
        public Subjects(int subjectID, string description,string subjectLevel,string category)
        {
            SubjectID = subjectID;
            Description = description;
            this.SubjectLevel = subjectLevel;
            this.Category = category;
        }

        public static DataSet SelectSubjects()
        {
                       //Select a subject from the database
            string query = $"SELECT * FROM Subjects";
            DataSet ds = Database.ExecuteMultiRowQuery(query);
            return ds;
        }
        public static List<Subjects> GetSubjects()
        {
            DataSet ds = SelectSubjects();
            List<Subjects> subjects = new List<Subjects>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                subjects.Add(new Subjects(
                    Convert.ToInt32(row["SubjectID"]),
                    row["Description"].ToString()!,
                    row["SubjectLevel"].ToString()!,
                    row["Category"].ToString()!
                ));
            }

            return subjects;
        }

    }
}
