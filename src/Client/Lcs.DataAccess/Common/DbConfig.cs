using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace Lcs.DataAccess
{
    public class DbConfig
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

        public  static IDbConnection GetConnection()
        {
            var con = new MySqlConnection(ConnectionString);
            if (con.State != ConnectionState.Open) con.Open();
            return con;
        }
    }
}
