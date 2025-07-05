using schoolmenagment.data;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmenagment.controller
{
    internal class Usercontroller
    {
        
        
            // ✅ Add a new user
            public void AddUser(User user)
            {
                using (var conn = datacon.GetConnection())
                {
                   
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"INSERT INTO Users (Username, Password, Role)
                                    VALUES (@username, @password, @role)";
                    cmd.Parameters.AddWithValue("@username", user.UserName);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    cmd.ExecuteNonQuery();
                }
            }

            // ✅ Update existing user
            public void UpdateUser(User user)
            {
                using (var conn = datacon.GetConnection())
                {
                    
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = @"UPDATE Users SET
                                    Username = @username,
                                    Password = @password,
                                    Role = @role
                                    WHERE UserID = @id";
                    cmd.Parameters.AddWithValue("@username", user.UserName);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    cmd.Parameters.AddWithValue("@id", user.UserId);
                    cmd.ExecuteNonQuery();
                }
            }

            // ✅ Delete user
            public void DeleteUser(int id)
            {
                using (var conn = datacon.GetConnection())
                {
                    
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM Users WHERE UserID = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            // ✅ Get all users
            public List<User> GetAllUsers()
            {
                List<User> users = new List<User>();
                using (var conn = datacon.GetConnection())
                {
                    
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Users";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                UserId = Convert.ToInt32(reader["UserID"]),
                                UserName = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = reader["Role"].ToString()
                            });
                        }
                    }
                }
                return users;
            }

            // ✅ Optional: Login check
            public bool Authenticate(string username, string password, out string role)
            {
                role = null;
                using (var conn = datacon.GetConnection())
                {
                    
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT Role FROM Users WHERE Username = @u AND Password = @p";
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = reader["Role"].ToString();
                            return true;
                        }
                    }
                }
                return false;
            }
        
    }
}
