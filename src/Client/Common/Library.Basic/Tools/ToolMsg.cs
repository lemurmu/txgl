using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library.Basic
{
    public class ToolMsg
    {
        public static void ShowMsg(string text, string caption = "提示消息")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string text, string caption = "错误消息")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ShowConfirm(string text, string caption = "确认消息")
        {
            var dlgRes = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dlgRes == DialogResult.Yes;
        }
    }
}
