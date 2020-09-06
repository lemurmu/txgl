using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BizUtils.Data
{
    public class DbNetDataUtil
    {
        public static CommandConfig PackCommandConfig(string sql, DataRow data)
        {
            CommandConfig CmdConfig = new CommandConfig(sql);

            foreach (DataColumn col in data.Table.Columns)
            {
                //if (data[col] != null)
                CmdConfig.Params[col.ColumnName] = data[col];
            }
            return CmdConfig;
        }

        public static UpdateCommandConfig PackUpdateCommandConfig(string sql, DataRow data, string[] keys)
        {
            UpdateCommandConfig CmdConfig = new UpdateCommandConfig(sql);

            foreach (DataColumn col in data.Table.Columns)
            {
                //if (data[col] != null)
                if (Array.IndexOf<string>(keys, col.ColumnName) >= 0)
                {
                    CmdConfig.FilterParams[col.ColumnName] = data[col];
                }
                else
                {
                    CmdConfig.Params[col.ColumnName] = data[col];
                }
            }
            return CmdConfig;
        }
    }
}
