using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork.DB
{
    public class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "enterprise";
            string username = "root";
            string password = "Zhenya2002VerB123_";

            return DBMySQL.GetDBConnection(host, port, database, username, password);
        }

    }
}
