using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmenagment.data
{
    /*internal class Migration
    {
        public static void InitializeDatabase()
        {
            using (var conn = datacon.GetConnection())
            {
                string createtablequeries = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Courses (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Students (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Age INTEGER,
                    Address TEXT,
                    Gender TEXT
                );

                CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ExamName TEXT NOT NULL,
                    CourseId INTEGER NOT NULL,
                    FOREIGN KEY(CourseId) REFERENCES Courses(CourseID)
                );

                CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER NOT NULL,
                    ExamID INTEGER NOT NULL,
                    Score INTEGER NOT NULL,
                    FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                    FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
                );

                CREATE TABLE IF NOT EXISTS Timetables (
                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                    TimeSlot TEXT NOT NULL,
                    RoomID INTEGER NOT NULL,
                    CourseID INTEGER NOT NULL,
                    FOREIGN KEY(RoomID) REFERENCES Rooms(RoomID),
                    FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                );

               CREATE TABLE IF NOT EXISTS Lectures (
                     LectureID INTEGER PRIMARY KEY AUTOINCREMENT,
                     Name TEXT NOT NULL,
                     Age TEXT NOT NULL,
                     Adress TEXT NOT NULL
          
                );";

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = createtablequeries;
                    command.ExecuteNonQuery();
                }
                using (var insertCmd = conn.CreateCommand())
                {
                    insertCmd.CommandText = @"
                        INSERT INTO Users (Username, Password, Role)
                        SELECT 'Admin', 'Admin123', 'Admin'
                        WHERE NOT EXISTS (
                            SELECT 1 FROM Users
                        );";
                    insertCmd.ExecuteNonQuery();
                }

            }

        }
    
    }*/

    internal class Migration
    {
        public static void InitializeDatabase()
        {
            using (var conn = datacon.GetConnection())
            {
                string createTableQueries = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Courses (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Students (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Age INTEGER,
                    Address TEXT,
                    Gender TEXT
                );

                CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ExamName TEXT NOT NULL,
                    CourseID INTEGER NOT NULL,
                    FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                );

                CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER NOT NULL,
                    ExamID INTEGER NOT NULL,
                    Score INTEGER NOT NULL,
                    FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                    FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
                );

                CREATE TABLE IF NOT EXISTS Rooms (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT NOT NULL,
                    RoomType TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Timetables (
                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                    TimeSlot TEXT NOT NULL,
                    RoomID INTEGER NOT NULL,
                    CourseID INTEGER NOT NULL,
                    FOREIGN KEY(RoomID) REFERENCES Rooms(RoomID),
                    FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                );

                CREATE TABLE IF NOT EXISTS Lectures (
                    LectureID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Age TEXT NOT NULL,
                    Adress TEXT NOT NULL
                );
                ";

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = createTableQueries;
                    command.ExecuteNonQuery();
                }

                // Insert default Admin user if Users table is empty
                using (var insertCmd = conn.CreateCommand())
                {
                    insertCmd.CommandText = @"
                        INSERT INTO Users (Username, Password, Role)
                        SELECT 'Admin', 'Admin123', 'Admin'
                        WHERE NOT EXISTS (
                            SELECT 1 FROM Users
                        );";
                    insertCmd.ExecuteNonQuery();
                }
            }
        }
    }

}
    




