using schoolmenagment.data;
using schoolmenagment.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmenagment.controller
{
    internal class Logincontroller
    {
        public User Authenticate(string username, string password)
        {
            using (var conn = datacon.GetConnection())
            {
                string query = "SELECT UserID, Username, Role FROM Users WHERE Username = @username AND Password = @password;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserId = reader.GetInt32(0),
                                UserName = reader.GetString(1),
                                Role = reader.GetString(2)
                            };
                        }
                        else
                        {
                            return null; // Authentication failed
                        }
                    }
                }
            }
        }
    }
}
