using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarHelpTool
{
    public class SQLTableToEntity
    {
        #region 数据库连接
        /// <summary>
        /// 数据库实例
        /// </summary>
        private SqlSugarClient _db;
        //数据库连接字符串
        private string _connstr = "server=h5.lisboa.tk;uid=h5_lisboa_tk;pwd=74EpHAZtfJ;database=h5_lisboa_tk";
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="connstr"></param>
        public void ConnectDb()
        {
            _db = new SqlSugarClient(
                new ConnectionConfig()
                {
                    ConnectionString = _connstr,
                    DbType = SqlSugar.DbType.MySql,//设置数据库类型
                    IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                    InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
                });

            //用来打印Sql方便你调式    
            _db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql);
                // Console.WriteLine(_db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
            };
        }

        #endregion

        /// <summary>
        /// 生成实体类
        /// </summary>
        public void CreateEntityCSFiles()
        {
            try
            {
                string entityFile = @"F:\vs2017Project\txgl\txgl\EntityCSFiles";
                //string[] files = Directory.GetFiles(entityFile, "*.cs");
                //if (files.Length != 0)
                //{
                //    for (int i = 0; i < files.Length; i++)
                //    {
                //        File.Delete(files[i]);
                //    }
                //}

                //_db.DbFirst.IsCreateDefaultValue().
                //    CreateClassFile(entityFile, "Lcs.Entity");
                _db.DbFirst.Where(SqlSugar.DbObjectType.Table).CreateClassFile(entityFile, "Lcs.Entity");
                Console.WriteLine("实体类生成成功");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
