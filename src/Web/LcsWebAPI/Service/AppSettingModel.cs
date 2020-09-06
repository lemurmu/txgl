using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LcsWebAPI.Service
{
    /// <summary>
    /// 配置文件类
    /// </summary>
    public class AppSettingModel
    {
        public string ConnectionString { get; set; }
        public string Port { get; set; }
        public string ReportDir { get; set; }
        public string EntityFilePath { get; set; }
        public string IrcsId { get; set; }
        public string Level { get; set; }
    }
}
