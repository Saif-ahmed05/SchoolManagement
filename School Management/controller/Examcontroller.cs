using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using schoolmenagment.data;
using schoolmenagment.models;

namespace schoolmenagment.controller
{
    internal class ExamController
    {
        // Add Exam
        public void AddExam(Exams exam)
        {
            using (var conn = datacon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                        INSERT INTO Exams (ExamName, CourseId)
                        VALUES (@examName, @courseId)";
                cmd.Parameters.AddWithValue("@examName", exam.ExamName);
                cmd.Parameters.AddWithValue("@courseId", exam.CourseId);
                cmd.ExecuteNonQuery();
            }
        }

        // Get all Exams
        public List<Exams> GetAllExams()
        {
            var exams = new List<Exams>();
            using (var conn = datacon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ExamID, ExamName, CourseId FROM Exams";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exams.Add(new Exams
                        {
                            ExamId = Convert.ToInt32(reader["ExamID"]),
                            ExamName = reader["ExamName"]?.ToString() ?? string.Empty,
                            CourseId = Convert.ToInt32(reader["CourseId"])
                        });
                    }
                }
            }
            return exams;
        }

        // Update Exam
        public void UpdateExam(Exams exam)
        {
            using (var conn = datacon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                        UPDATE Exams
                        SET ExamName = @examName, CourseId = @courseId
                        WHERE ExamID = @examId";
                cmd.Parameters.AddWithValue("@examName", exam.ExamName);
                cmd.Parameters.AddWithValue("@courseId", exam.CourseId);
                cmd.Parameters.AddWithValue("@examId", exam.ExamId);
                cmd.ExecuteNonQuery();
            }
        }

        // Delete Exam
        public void DeleteExam(int examId)
        {
            using (var conn = datacon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Exams WHERE ExamID = @examId";
                cmd.Parameters.AddWithValue("@examId", examId);
                cmd.ExecuteNonQuery();
            }
        }

        // Get single Exam by ID
        public Exams? GetExamById(int examId)
        {
            using (var conn = datacon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ExamID, ExamName, CourseId FROM Exams WHERE ExamID = @examId";
                cmd.Parameters.AddWithValue("@examId", examId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Exams
                        {
                            ExamId = Convert.ToInt32(reader["ExamID"]),
                            ExamName = reader["ExamName"]?.ToString() ?? string.Empty,
                            CourseId = Convert.ToInt32(reader["CourseId"])
                        };
                    }
                }
            }

            return null;
        }
    }
}
