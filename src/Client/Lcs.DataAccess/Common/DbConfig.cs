using MySql.Data.MySqlClient;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using DbType = SqlSugar.DbType;

namespace Lcs.DataAccess
{
    public class DbConfig
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

#if Dapper
        public static IDbConnection GetConnection()
        {
            var con = new MySqlConnection(ConnectionString);
            if (con.State != ConnectionState.Open) con.Open();
            return con;
        }
#endif
        static SqlSugarClient db = null;

        public static SqlSugarClient DB
        {
            get
            {
                if (db == null)
                {
                    db = new SqlSugarClient(
                             new ConnectionConfig()
                             {
                                 ConnectionString = ConnectionString,
                                 DbType = DbType.MySql,//设置数据库类型
                                 IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                                 InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
                             });
                }
                return db;
            }
        }


    }
}
