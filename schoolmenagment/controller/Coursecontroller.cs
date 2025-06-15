using schoolmenagment.data;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmenagment.controller
{
    internal class Coursecontroller
    {
        
        
            // Get all courses
            public static List<Course> GetAllCourses()
            {
            List<Course> coures = new List<Course>();
            using (var conn = datacon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Courses";

                using (var reader = cmd.ExecuteReader())
                {
                   
                    while (reader.Read())
                    {
                        coures.Add(new Course
                        {
                            CourseId = reader.GetInt32(0),
                            CourseName = reader.GetString(1),
                            
                        });
                    }
                }
            }
            return coures;
        }

            // Add a new course
            public static void AddCourse(string name)
            {
                using (var conn = datacon.GetConnection())
                {
                
                string query = "INSERT INTO Courses (Name) VALUES (@Name)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // Update a course
            public static void UpdateCourse(int id, string name)
            {
                using (var conn = datacon.GetConnection())
                {
               
                string query = "UPDATE Courses SET Name = @Name WHERE Id = @Id";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // Delete a course
            public static void DeleteCourse(int id)
            {
                using (var conn = datacon.GetConnection())
                {
                
                string query = "DELETE FROM Courses WHERE Id = @Id";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
   
            

