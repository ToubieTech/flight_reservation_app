using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace flight_reservation_app
{
    class DBConnection
    {
        public static MySqlConnection DBConnect()
        {
            string server = "localhost";
            string username = "root";
            string password = "mysql";
            string db = "flight_reservation_app";

            string conn = "SERVER=" + server + ";" + "DATABASE=" + db + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection connection = new MySqlConnection(conn);
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Connection to database failed!");
                        break;
                    case 1045:
                        Console.WriteLine("Server error!");
                        break;
                    default:
                        break;
                }
            }
            return connection;
        }
    }
}
