using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCSClientApplication
{
    public static class Global
    {
        /// <summary>
        /// webApi路径
        /// </summary>
        public static string ClouldWebAPI = ConfigurationManager.AppSettings["ClouldWebAPI"];

        /// <summary>
        /// 全局config文件路径
        /// </summary>
        public static string ConfigFile = @"Config\config.ini";

        /// <summary>
        /// 全局config对象
        /// </summary>
        public static IniConfigHelper.IniConfigHelper IniConfig = new IniConfigHelper.IniConfigHelper(ConfigFile);

        public static string ExcelFilePath = "Excel\\GERIMPORT-2020-08-26.xls";

        public static string MysqlPassword = "123456";

    }
}
