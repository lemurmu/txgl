using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IniConfigHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            //string value = OperateIniFile.ReadIniData("Server", "Release", "", @"config\DBServer.ini");

            //Config config = new Config(@"config\DBServer.ini");

            IniConfigHelper config = new IniConfigHelper(@"config\DBServer.ini");
            IniConfigHelper.Section server = config["Server"];
            IniConfigHelper.Section db = config["DB"];
            IniConfigHelper.Section user = config["User"];
            server["Test"] = "192.168.100.56";
            db["Devlop"] = "sqlite3";

            IniConfigHelper.Section section = new IniConfigHelper.Section();
            section.KeyValuePairs.Add("test", "127.0.0.1");
            config["Server"] = section;

            Console.WriteLine("---------------------------------------");
            foreach (var item in server.KeyValuePairs)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

            Console.WriteLine("---------------------------------------");
            foreach (var item in db.KeyValuePairs)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

            Console.WriteLine("---------------------------------------");
            foreach (var item in user.KeyValuePairs)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

            Console.ReadKey();

        }
    }


}
