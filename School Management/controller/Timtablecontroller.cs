using schoolmenagment.data;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmenagment.controller
{
    internal class Timtablecontroller
    {
        public static void AddTimetable(Timtable timetable)
        {
            using (var conn = datacon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Timetables (TimeSlot, RoomID, CourseID) 
                                    VALUES (@TimeSlot, @RoomID, @CourseID)";
                cmd.Parameters.AddWithValue("@TimeSlot", timetable.Timeslot);
                cmd.Parameters.AddWithValue("@RoomID", timetable.Roomid);
                cmd.Parameters.AddWithValue("@CourseID", timetable.CourseId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateTimetable(Timtable timetable)
        {
            using (var conn = datacon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE Timetables 
                                    SET TimeSlot = @TimeSlot, RoomID = @RoomID, CourseID = @CourseID 
                                    WHERE TimetableID = @TimetableID";
                cmd.Parameters.AddWithValue("@TimeSlot", timetable.Timeslot);
                cmd.Parameters.AddWithValue("@RoomID", timetable.Roomid);
                cmd.Parameters.AddWithValue("@CourseID", timetable.CourseId);
                cmd.Parameters.AddWithValue("@TimetableID", timetable.TimtableId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteTimetable(int id)
        {
            using (var conn = datacon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Timetables WHERE TimetableID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Timtable> GetAllTimetables()
        {
            var list = new List<Timtable>();
            using (var conn = datacon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Timetables";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Timtable
                        {
                            TimtableId = Convert.ToInt32(reader["TimetableID"]),
                            Timeslot = reader["TimeSlot"].ToString(),
                            Roomid = Convert.ToInt32(reader["RoomID"]),
                            CourseId = Convert.ToInt32(reader["CourseID"])
                        });
                    }
                }
            }
            return list;
        }
    }
}

