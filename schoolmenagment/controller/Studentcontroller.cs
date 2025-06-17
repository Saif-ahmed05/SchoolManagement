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
                cmd.CommandText = @"INSERT INTO Students (Name, Age, Address, Gender)
                                    VALUES (@name, @age, @address, @gender)";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@age", student.Age);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@gender", student.Gender);
                cmd.ExecuteNonQuery();
            }
        }

        // ✅ Update Student
        public void UpdateStudent(Student student)
        {
            using (var conn = datacon.GetConnection())
            {
             
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE Students SET 
                                    Name = @name,
                                    Age = @age,
                                    Address = @address,
                                    Gender = @gender
                                    WHERE StudentID = @id";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@age", student.Age);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@gender", student.Gender);
                cmd.Parameters.AddWithValue("@id", student.StudentId);
                cmd.ExecuteNonQuery();
            }
        }

        // ✅ Delete Student
        public void DeleteStudent(int id)
        {
            using (var conn = datacon.GetConnection())
            {
             
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Students WHERE StudentID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ✅ Get All Students for DataGridView
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
                            StudentId = reader["StudentID"] != DBNull.Value ? Convert.ToInt32(reader["StudentID"]) : 0,
                            Name = reader["Name"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            Address = reader["Address"].ToString(),
                            Gender = reader["Gender"].ToString()
                        });

                    }
                }
            }

            return students;
        }
    }
}
       