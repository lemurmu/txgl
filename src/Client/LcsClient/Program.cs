using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using Library.Basic;

namespace LcsClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //设置默认字体
            DevExpress.Utils.AppearanceObject.DefaultFont = new System.Drawing.Font("微软雅黑", 9);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(ToolConfig.GetAppSetting("SkinName").IfNullOrWhitespace("Office 2019"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
