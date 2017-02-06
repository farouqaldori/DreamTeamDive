using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver_Contest
{
    public static class Mysql_db
    {
        public static string host;
        public static string username;
        public static string password;
        public static string table;

        public static void init()
        {
            host = "localhost";
            username = "db_username";
            password = "db_pass";
            table = "db_table";
        }

        public static bool connect()
        {
            // If connection is successful
            return true;
        }

        public static void execute()
        {
        }

        public static void get()
        {
        }
    }
}
