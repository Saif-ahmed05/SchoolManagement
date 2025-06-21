using schoolmenagment.data;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;


namespace schoolmenagment.controller
{
    internal class Coursecontroller
    {
        public static List<Course> GetAll()
        {
            List<Course> list = new List<Course>();
            using (var conn = datacon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Courses", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Course
                    {
                        CourseId = reader.GetInt32(0),
                        CourseName = reader.GetString(1)
                    });
                }
            }
            return list;
        }

        public static void Add(string name)
        {
            using (var conn = datacon.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Courses (CourseName) VALUES (@name)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Update(int id, string name)
        {
            using (var conn = datacon.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Courses SET CourseName = @name WHERE CourseId = @id", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(int id)
        {
            using (var conn = datacon.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Courses WHERE CourseId = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
