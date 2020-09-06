using Lcs.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCSClientApplication
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DbConfig.ConnectionString= ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

            Application.Run(new FrmMain());
        }
    }
}
