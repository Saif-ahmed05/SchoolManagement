using schoolmenagment.data;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmenagment.controller
{
    internal class Lecturecontroller
    {
        public void AddLecture(Lecture lecture)
        {
            using (var conn = datacon.GetConnection())
            {
               
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Lectures (Name, Age, Adress)
                                    VALUES (@name, @age, @adress)";
                cmd.Parameters.AddWithValue("@name", lecture.Name);
                cmd.Parameters.AddWithValue("@age", lecture.Age);
                cmd.Parameters.AddWithValue("@adress", lecture.Adress);
                cmd.ExecuteNonQuery();
            }
        }



        // ✅ Update a lecture
        public void UpdateLecture(Lecture lecture)
            {
                using (var conn = datacon.GetConnection())
                {
                    
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"UPDATE Lectures SET
                                    Name = @name,
                                    Age = @age,
                                    Adress = @adress
                                    WHERE LectureID = @id";
                    cmd.Parameters.AddWithValue("@name", lecture.Name);
                    cmd.Parameters.AddWithValue("@age", lecture.Age);
                    cmd.Parameters.AddWithValue("@adress", lecture.Adress);
                    cmd.Parameters.AddWithValue("@id", lecture.LectureID);
                    cmd.ExecuteNonQuery();
                }
            }

            // ✅ Delete a lecture
            public void DeleteLecture(int id)
            {
                using (var conn = datacon.GetConnection())
                {
                    
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM Lectures WHERE LectureID = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            // ✅ Get all lectures
            public List<Lecture> GetAllLectures()
            {
                var list = new List<Lecture>();
                using (var conn = datacon.GetConnection())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Lectures";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Lecture
                            {
                                LectureID = Convert.ToInt32(reader["LectureID"]),
                                Name = reader["Name"].ToString(),
                                Age = reader["Age"].ToString(),
                                Adress = reader["Adress"].ToString()
                            });
                        }
                    }
                }
                return list;
            }
    }
}

