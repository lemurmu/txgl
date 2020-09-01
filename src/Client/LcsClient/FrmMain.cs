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
    }
}