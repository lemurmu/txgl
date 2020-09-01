using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library.Basic
{
    public static class WinformExtensions
    {
        public static void Invoke(this Control ctrl, Action action)
        {
            if (ctrl == null || ctrl.IsDisposed || !ctrl.IsHandleCreated) return;
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(action);
            }
            else
            {
                action();
            }
        }

        public static void BeginInvoke(this Control ctrl, Action action)
        {
            if (ctrl == null || ctrl.IsDisposed || !ctrl.IsHandleCreated) return;
            if (ctrl.InvokeRequired)
            {
                ctrl.BeginInvoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
