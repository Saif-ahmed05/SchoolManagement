using schoolmenagment.data;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmenagment.controller
{
    internal class Roomcontroller
    {
        public void AddRoom(Room room)
        {
            using (var conn = datacon.GetConnection())
            {
                
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@name, @type)";
                cmd.Parameters.AddWithValue("@name", room.Roomname);
                cmd.Parameters.AddWithValue("@type", room.Roomtype);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateRoom(Room room)
        {
            using (var conn = datacon.GetConnection())
            {
               
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Rooms SET RoomName = @name, RoomType = @type WHERE RoomID = @id";
                cmd.Parameters.AddWithValue("@name", room.Roomname);
                cmd.Parameters.AddWithValue("@type", room.Roomtype);
                cmd.Parameters.AddWithValue("@id", room.Roomid);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRoom(int id)
        {
            using (var conn = datacon.GetConnection())
            {
               
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Rooms WHERE RoomID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Room> GetAllRooms()
        {
            var list = new List<Room>();
            using (var conn = datacon.GetConnection())
            {
                
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Rooms";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Room
                        {
                            Roomid = Convert.ToInt32(reader["RoomID"]),
                            Roomname = reader["RoomName"].ToString(),
                            Roomtype = reader["RoomType"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}

