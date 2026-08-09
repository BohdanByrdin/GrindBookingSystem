using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrindBookingSystem.Schedule
{
    internal class Rooms
    {
        public string RoomNo { get; set; }
        public string Description { get; set; }
        public int capacity { get; set; }

        public Rooms(string roomNo, string description, int capacity)
        {
            RoomNo = roomNo;
            Description = description;
            this.capacity = capacity;
        }

        public static DataSet SelectRooms()
        {
            //Select all rooms from the database
            string query = "SELECT * FROM Rooms";
            return Database.ExecuteMultiRowQuery(query);
        }
        public static List<Rooms> GetRooms()
            {
                
                DataSet ds = SelectRooms();
            List<Rooms> rooms = new List<Rooms>();
    
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    rooms.Add(new Rooms(
                        row["RoomNo"].ToString()!,
                        row["Description"].ToString()!,
                        Convert.ToInt32(row["Capacity"])
                    ));
                }
    
                return rooms;
        }
        public override string ToString()
        {
            return RoomNo + " - " + Description;
        }
    }
}
