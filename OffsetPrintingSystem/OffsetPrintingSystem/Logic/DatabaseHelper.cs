using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OffsetPrintingSystem.Logic
{
    public class DatabaseHelper
    {
        private string serverName = "127.0.0.1";
        private string port = "3306";
        private string databaseName = "offsetprintingdb";
        private string databaseUser = "root";
        private string databasePassword = "601598#123";

        private DatabaseHelper() { }

        private static DatabaseHelper _instance;
        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseHelper();
                return _instance;
            }
        }

        public MySqlConnection getConnection()
        {
            string cs = $"server={serverName};port={port};user={databaseUser};database={databaseName};password={databasePassword};SslMode=Required;";
            MySqlConnection conn = new MySqlConnection(cs);
            conn.Open();
            return conn;
        }

        public MySqlDataReader getData(string query)
        {
            MySqlConnection conn = getConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        public int Update(string query)
        {
            using (MySqlConnection conn = getConnection())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                return cmd.ExecuteNonQuery();
            }
        }
    }
}