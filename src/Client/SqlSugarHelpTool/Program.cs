using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarHelpTool
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLTableToEntity sQLTableToEntity = new SQLTableToEntity();
            sQLTableToEntity.ConnectDb();
            sQLTableToEntity.CreateEntityCSFiles();

        }
    }
}
