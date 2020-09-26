using Ionic.Zip;
using Lcs.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
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

           
            //string mysqlPath = AppDomain.CurrentDomain.BaseDirectory + @"MySQL Server 5.7\";
            //Process.Start("cmd.exe", mysqlPath);
            //Process p = new Process();
            //p.StartInfo.FileName = "cmd.exe";
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardInput = true;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.RedirectStandardError = true;
            ////  p.StartInfo.CreateNoWindow = true;

            //string cmd = "cd /d " + mysqlPath;

            ////指定MySql程序的bin 目录
            //// p.StartInfo.WorkingDirectory = mysqlPath + "\\bin";
            //p.StartInfo.Arguments = mysqlPath;
            //p.Start();

            //p.StandardInput.WriteLine("cd /d " + mysqlPath);

            ///*************
            //* 备份命令
            //**************/
            ////简单格式
            ////string strSql = "mysqldump --quick --host=localhost -u root -p123 test > d:\\test_20151227110010.sql";
            ///*命令指定格式*/
            ////String command = "mysqldump --quick --host=localhost --default-character-set=gb2312 --lock-tables --verbose  --force --port=端口号 --user=用户名 --password=密码 数据库名 -r 备份到的地址";
            ////string strSql = "mysqldump --quick --host=localhost  --default-character-set=gb2312 --lock-tables --verbose  --force --port=3306 --user=root --password=123 test -r d:\\one.sql";

            ///*************
            //* 还原命令
            //**************/
            ////简单格式
            ////string strSql = "mysql  --host=localhost -u root -p123 test < d:\\test_20151227110010.sql";
            ///**还原命令格式**/
            ////string s = "mysql --host=localhost --default-character-set=gbk --port=端口号 --user=用户名 --password=密码 数据库名<还原文件所在路径";
            //// string strSql = "mysql  --host=localhost --port=3306 --user=root --password=123 test < d:\\test_20151227110010.sql";

            ////p.StandardInput.WriteLine("net start mysql-admin" + " &exit");
            ////p.StandardInput.AutoFlush = true;


            ////p.WaitForExit();
            ////p.Close();


            Application.Run(new FrmMain());
        }

    }
}
