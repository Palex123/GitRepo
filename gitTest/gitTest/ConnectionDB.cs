using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace gitTest
{
    public static class ConnectionDB
    {
        public static string ConnectionString1()
        {
            return ConnectionString("localhost");
        }
        public static string ConnectionString(string Server)
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder["Server"] = Server;
            stringBuilder.IntegratedSecurity = true;
            return stringBuilder.ConnectionString;
        }

        public static SqlConnection Connection()
        {
            return new SqlConnection(ConnectionString1());
        }
    }
}
