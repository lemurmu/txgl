using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using LcsClient.Forms;
using DevExpress.XtraBars.Docking;
using Library.Basic;
using LcsClient.Control;

namespace LcsClient
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            SplashScreenManager.ShowForm(this, typeof(FrmSplashScreen), true, true);
            InitializeComponent();
            ShowManager.It.Init(documentManager, tabbedView, dockManager);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            StyleHelper.InitStyle(skinRibbonGalleryBarItem);
            SplashScreenManager.CloseForm();
        }

        private void dockManager_ClosedPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            dockManager.RemovePanel(e.Panel);
        }

        private void ShowModule(string caption, DockingStyle dockingStyle, Func<UserControl> getUserControl)
        {
            var olHandle = SplashScreenManager.ShowOverlayForm(this);
            try
            {
                ShowManager.It.Show(caption, dockingStyle, getUserControl);
                olHandle.Close();
            }
            catch (Exception ex)
            {
                olHandle.Close();
                MsgHelper.ShowError("加载{0}出错！错误消息：{1}".FormatWith(caption, ex.Message));
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MsgHelper.ShowConfirm("您确定要重启应用程序吗"))
            {
                Application.Restart();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MsgHelper.ShowConfirm("您确定要退出应用程序吗？"))
            {
                Application.Exit();
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowModule("历史订单", DockingStyle.Fill, () =>
            {
                return new OrderHistoryCtrl();
            });
        }
    }
}