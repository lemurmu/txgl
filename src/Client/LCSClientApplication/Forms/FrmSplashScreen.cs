using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCSClientApplication.Forms
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        //private static FrmSplashScreen splashScreen = new FrmSplashScreen();
        //private static BackgroundWorker bgworker;

        //public static void ShowScreen(Control ctr)
        //{
        //    splashScreen.Parent = ctr;
        //    bgworker = new BackgroundWorker();
        //    bgworker.DoWork += (s, e) => {
        //        splashScreen = new FrmSplashScreen();
        //        splashScreen.Show();
        //    };
        //    bgworker.RunWorkerCompleted += (s, e) => { 

        //    };

        //    bgworker.RunWorkerAsync();
        //}

        //public static void CloseScreen()
        //{
        //    splashScreen.Close();
        //}

        /// <summary>
        /// 关闭命令
        /// </summary>
        public void CloseOrder()
        {
            if (this.InvokeRequired)
            {
                //这里利用委托进行窗体的操作，避免跨线程调用时抛异常，后面给出具体定义
                CONSTANTDEFINE.SetUISomeInfo UIinfo = new CONSTANTDEFINE.SetUISomeInfo(new Action(() =>
                {
                    while (!this.IsHandleCreated)
                    {
                        ;
                    }
                    if (this.IsDisposed)
                        return;
                    if (!this.IsDisposed)
                    {
                        this.Dispose();
                    }

                }));
                this.Invoke(UIinfo);
            }
            else
            {
                if (this.IsDisposed)
                    return;
                if (!this.IsDisposed)
                {
                    this.Dispose();
                }
            }
        }

        private void LoaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.IsDisposed)
            {
                this.Dispose(true);
            }

        }
    }
    class CONSTANTDEFINE
    {
        public delegate void SetUISomeInfo();


    }
}
