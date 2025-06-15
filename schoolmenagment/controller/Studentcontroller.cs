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
    internal class Studentcontroller
    {

        public void AddStudent(Student student)
        {
            using (var conn = datacon.GetConnection())
            {
                
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Students (Name, Address, Age, Gender, CourseId) VALUES (@name, @address, @age, @gender, @courseId)";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@age", student.Age);
                cmd.Parameters.AddWithValue("@gender", student.Gender);
                cmd.Parameters.AddWithValue("@courseId", student.CourseId);

            }
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (var conn = datacon.GetConnection())
            {
                
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Students";
                
                using (var reader = cmd.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            Age = reader.GetInt32(3),
                            Gender = reader.GetString(4),
                            CourseId = reader.GetInt32(5),
                        });

                    }
                }
            }
            return students;
        }

        public void UpdateStudent(Student student)
        {
            using (var conn = datacon.GetConnection())
            {
                
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Students SET Name = @name, Address = @address WHERE Id = @id";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@id", student.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int id)
        {
            using (var conn = datacon.GetConnection())
            {
                
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Students WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        //    // Load all students with course name (for DataGridView)
        //    public static List<dynamic> GetAllStudentsWithCourse()
        //    {
        //        List<dynamic> students = new List<dynamic>();

        //        using (var conn = datacon.GetConnection())
        //        {
        //            string query = @"
        //                SELECT s.Id, s.Name, s.Age, s.Gender, s.CourseId, c.Name AS CourseName
        //                FROM Students s
        //                INNER JOIN Courses c ON s.CourseId = c.Id";

        //            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
        //            using (SQLiteDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    students.Add(new
        //                    {
        //                        Id = reader.GetInt32(0),
        //                        Name = reader.GetString(1),
        //                        Age = reader.GetInt32(2),
        //                        Gender = reader.GetString(3),
        //                        CourseId = reader.GetInt32(4),
        //                        CourseName = reader.GetString(5)
        //                    });
        //                }
        //            }
        //        }

        //        return students;
        //    }

        //    // Add new student
        //    public static void AddStudent(Student student)
        //    {
        //        using (var conn = datacon.GetConnection())
        //        {
        //            string query = "INSERT INTO Students (Name, Age, Gender, CourseId) VALUES (@Name, @Age, @Gender, @CourseId)";
        //            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@Name", student.Name);
        //                cmd.Parameters.AddWithValue("@Age", student.Age);
        //                cmd.Parameters.AddWithValue("@Gender", student.Gender);
        //                cmd.Parameters.AddWithValue("@CourseId", student.CourseId);
        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //    }

        //    // Update existing student
        //    public static void UpdateStudent(Student student)
        //    {
        //        using (var conn = datacon.GetConnection())
        //        {
        //            string query = "UPDATE Students SET Name = @Name, Age = @Age, Gender = @Gender, CourseId = @CourseId WHERE Id = @Id";
        //            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@Name", student.Name);
        //                cmd.Parameters.AddWithValue("@Age", student.Age);
        //                cmd.Parameters.AddWithValue("@Gender", student.Gender);
        //                cmd.Parameters.AddWithValue("@CourseId", student.CourseId);
        //                cmd.Parameters.AddWithValue("@Id", student.Id);
        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //    }

        //    // Delete student by ID
        //    public static void DeleteStudent(int id)
        //    {
        //        using (var conn = datacon.GetConnection())
        //        {
        //            string query = "DELETE FROM Students WHERE Id = @Id";
        //            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@Id", id);
        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //    }
    }

}

        
       




