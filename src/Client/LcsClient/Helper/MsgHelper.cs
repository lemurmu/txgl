using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LcsClient
{
    public static class MsgHelper
    {
        public static void ShowMsg(string msg, string title = "消息提示")
        {
            XtraMessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool ShowConfirm(string msg, string title = "确认提示")
        {
            var dlgRes = XtraMessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dlgRes == DialogResult.Yes;
        }

        public static void ShowError(string msg, string title = "错误提示")
        {
            XtraMessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
