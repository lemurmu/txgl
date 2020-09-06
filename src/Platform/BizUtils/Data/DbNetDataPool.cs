using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizUtils.Data
{
    public sealed class DbNetDataPool
    {
        private static ObjectPool<DbNetData> pool = null;
        private DbNetDataPool() { }

        public static readonly DbNetDataPool Instance =
            new DbNetDataPool();

        private string connectionString =
            @"server=127.0.0.1;user id=nxkj;password=nxkj_bird;database=nxkj;DataProvider=MySql;";

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }

        protected override object Create()
        {
            DbNetData db = new DbNetData(connectionString);
            db.CloseConnectionOnError = false; 
            db.Open();
            return db;
        }

        protected override bool Validate(object o)
        {
            try
            {
                DbNetData db = (DbNetData)o;
                return !db.Conn.State.Equals(System.Data.ConnectionState.Closed);
            }
            catch (Exception ex)
            {
                DC.DCLogger.LogError(ex.Message);
                return false;
            }
        }

        protected override void Expire(object o)
        {
            try
            {
                DbNetData db = (DbNetData)o;
                db.Close();
            }
            catch (Exception ex)
            {
                DC.DCLogger.LogError(ex.Message);
            }
        }

        public DbNetData BorrowDB()
        {
            try
            {
                return (DbNetData)base.GetObjectFromPool();
            }
            catch (Exception ex)
            {
                DC.DCLogger.LogError(ex.Message);
                throw ex;
            }
        }

        public void ReturnDB(DbNetData db)
        {
            base.ReturnObjectToPool(db);
        }

        public void Dispose()
        {

        }
    }
}
