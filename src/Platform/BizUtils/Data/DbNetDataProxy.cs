using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Data;

namespace BizUtils.Data
{
    public class DbNetDataProxy
    {
        private static ConcurrentDictionary<string, ObjectPool<DbNetData>> pool = new ConcurrentDictionary<string, ObjectPool<DbNetData>>();
        ObjectPool<DbNetData> dbp = null;

        public DbNetDataProxy(string connStr)
        {
            this.dbp = pool.GetOrAdd(connStr, new ObjectPool<DbNetData>(
                () =>
                {
                    DbNetData db = new DbNetData(connStr);
                    db.CloseConnectionOnError = false;
                    db.Open();
                    return db;
                }
                ));
        }

        public DbNetData GetDb()
        {
            return dbp.GetObject();
        }

        public void PutDb(DbNetData db)
        {
            if (db != null)
            {
                dbp.PutObject(db);
            }
        }

        public long ExecuteInsert(CommandConfig CmdConfig)
        {
            return this.ExecuteInsert(CmdConfig, false);
        }

        public long ExecuteInsert(CommandConfig CmdConfig, bool returnVal)
        {
            DbNetData db = dbp.GetObject();
            try
            {
                if (returnVal)
                {
                    db.ReturnAutoIncrementValue = true;
                }
                long r = db.ExecuteInsert(CmdConfig);
                if (returnVal)
                {
                    db.ReturnAutoIncrementValue = false;
                }
                return r;
            }
            catch
            {
                throw;
            }
            finally
            {
                dbp.PutObject(db);
            }
        }

        public int ExecuteNonQuery(CommandConfig CmdConfig)
        {
            DbNetData db = dbp.GetObject();
            try
            {
                int r = db.ExecuteNonQuery(CmdConfig);
                return r;
            }
            catch
            {
                throw;
            }
            finally
            {
                dbp.PutObject(db);
            }
        }

        public DataTable GetDataTable(QueryCommandConfig CmdConfig)
        {
            DbNetData db = dbp.GetObject();
            try
            {
                DataTable r = db.GetDataTable(CmdConfig);
                return r;
            }
            catch
            {
                throw;
            }
            finally
            {
                dbp.PutObject(db);
            }
        }

        public void Dispose()
        {

        }

        public DataTable GetDataTable(string sql)
        {
            DbNetData db = dbp.GetObject();
            try
            {
                DataTable r = db.GetDataTable(sql);
                return r;
            }
            catch
            {
                throw;
            }
            finally
            {
                dbp.PutObject(db);
            }
        }

        public long ExecuteUpdate(UpdateCommandConfig UpCmdConfig)
        {
            DbNetData db = dbp.GetObject();
            try
            {
                long r = db.ExecuteUpdate(UpCmdConfig);
                return r;
            }
            catch
            {
                throw;
            }
            finally
            {
                dbp.PutObject(db);
            }
        }

        public long ExecuteDelete(CommandConfig CmdConfig)
        {
            DbNetData db = dbp.GetObject();
            try
            {
                long r = db.ExecuteDelete(CmdConfig);
                return r;
            }
            catch
            {
                throw;
            }
            finally
            {
                dbp.PutObject(db);
            }
        }

        public object ExecuteScalar(QueryCommandConfig QryCmd)
        {
            DbNetData db = dbp.GetObject();
            try
            {
                object r = db.ExecuteScalar(QryCmd);
                return r;
            }
            catch
            {
                throw;
            }
            finally
            {
                dbp.PutObject(db);
            }
        }
    }
}
