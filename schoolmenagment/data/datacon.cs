using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmenagment.data
{
    internal class datacon
    {
        private static string ConnectionString = "Data Source=School.DB.db;version=3;";

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}

