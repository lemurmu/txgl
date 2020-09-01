using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using Library.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LcsClient
{
    public class StyleHelper
    {
        public static void InitStyle(RibbonGalleryBarItem btns)
        {
            SkinHelper.InitSkinGallery(btns);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged += new EventHandler(Default_StyleChanged);
        }

        static void Default_StyleChanged(object sender, EventArgs e)
        {
           string skinName = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName;
            ToolConfig.SetAppSetting("SkinName", skinName);
        }
    }
}
