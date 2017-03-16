using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Diver_Contest
{
    public static class Mysql_db
    {
        public static string server;
        public static string username;
        public static string password;
        public static string database;
        public static string port;
        public static string connectionString;

        public static MySql.Data.MySqlClient.MySqlConnection connection;
        public static MySql.Data.MySqlClient.MySqlConnection connection2;
        /// <summary>
        /// Connect to the MySql database.
        /// </summary>
        /// <returns>True if connection established.</returns>
        public static bool connect()
        {
            // Authentication credentials for the database.
            server = "gonimble.net";
            port = "3306";
            database = "gonimble_dreamteam";
            username = "gonimble_dtuser";
            password = "9cUJ-d.9?ZDp";

            // Create connection string.
            connectionString = "Server=" + server + ";Port=" + port + ";Database=" + database + ";Uid=" + username + ";Pwd=" + password + ";";

            // Try connection
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                connection2 = new MySqlConnection(connectionString);
                connection2.Open();
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                return false;
            }
        }

        /// <summary>
        /// Execute a command to the database.
        /// </summary>
        /// <param name="sqlCommand">The SQL command to execute.</param>
        /// /// <returns>True if command executed.</returns>
        public static MySqlCommand execute(string sqlCommand)
        {
            //Create command and assign the sqlCommand plus connection.
            MySqlCommand cmd = new MySqlCommand(sqlCommand, connection);

            try
            {
                //Execute command
                cmd.ExecuteNonQuery();
                return cmd;
            }
            catch (MySqlException e)
            {
                // Command failed
                throw e;
            }
        }
    }
}