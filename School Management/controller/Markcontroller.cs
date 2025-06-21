using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using schoolmenagment.data;
using schoolmenagment.models;

namespace schoolmenagment.controller
{
    internal class Markcontroller
    {
        public void AddMark(Mark mark)
        {
            using (var conn = datacon.GetConnection())
            {
            
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO Marks (StudentID, ExamID, Score)
                    VALUES (@studentId, @examId, @score)";
                cmd.Parameters.AddWithValue("@studentId", mark.StudentId);
                cmd.Parameters.AddWithValue("@examId", mark.ExamId);
                cmd.Parameters.AddWithValue("@score", mark.Score);

                cmd.ExecuteNonQuery();
            }
        }

        // Get all marks
        public List<Mark> GetAllMarks()
        {
            var marks = new List<Mark>();
            using (var conn = datacon.GetConnection())
            {
                
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT MarkID, StudentID, ExamID, Score FROM Marks";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        marks.Add(new Mark
                        {
                            MarkId = Convert.ToInt32(reader["MarkID"]),
                            StudentId = Convert.ToInt32(reader["StudentID"]),
                            ExamId = Convert.ToInt32(reader["ExamID"]),
                            Score = Convert.ToInt32(reader["Score"])
                        });
                    }
                }
            }
            return marks;
        }

        // Update mark
        public void UpdateMark(Mark mark)
        {
            using (var conn = datacon.GetConnection())
            {
              
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    UPDATE Marks
                    SET StudentID = @studentId, ExamID = @examId, Score = @score
                    WHERE MarkID = @markId";
                cmd.Parameters.AddWithValue("@studentId", mark.StudentId);
                cmd.Parameters.AddWithValue("@examId", mark.ExamId);
                cmd.Parameters.AddWithValue("@score", mark.Score);
                cmd.Parameters.AddWithValue("@markId", mark.MarkId);

                cmd.ExecuteNonQuery();
            }
        }

        // Delete mark
        public void DeleteMark(int markId)
        {
            using (var conn = datacon.GetConnection())
            {
               
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Marks WHERE MarkID = @markId";
                cmd.Parameters.AddWithValue("@markId", markId);

                cmd.ExecuteNonQuery();
            }
        }

        // Get a single mark by ID
        public Mark GetMarkById(int markId)
        {
            using (var conn = datacon.GetConnection())
            {
              
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT MarkID, StudentID, ExamID, Score FROM Marks WHERE MarkID = @markId";
                cmd.Parameters.AddWithValue("@markId", markId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Mark
                        {
                            MarkId = Convert.ToInt32(reader["MarkID"]),
                            StudentId = Convert.ToInt32(reader["StudentID"]),
                            ExamId = Convert.ToInt32(reader["ExamID"]),
                            Score = Convert.ToInt32(reader["Score"])
                        };
                    }
                }
            }
            return null;
        }
    }

}
