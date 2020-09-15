/********************************************************************
 * *
 * * 使本项目源码或本项目生成的DLL前请仔细阅读以下协议内容，如果你同意以下协议才能使用本项目所有的功能，
 * * 否则如果你违反了以下协议，有可能陷入法律纠纷和赔偿，作者保留追究法律责任的权利。
 * *
 * * 1、你可以在开发的软件产品中使用和修改本项目的源码和DLL，但是请保留所有相关的版权信息。
 * * 2、不能将本项目源码与作者的其他项目整合作为一个单独的软件售卖给他人使用。
 * * 3、不能传播本项目的源码和DLL，包括上传到网上、拷贝给他人等方式。
 * * 4、以上协议暂时定制，由于还不完善，作者保留以后修改协议的权利。
 * *
 * * Copyright (C) 2013-? cskin Corporation All rights reserved.
 * * 网站：CSkin界面库 http://www.cskin.net
 * * 作者： 乔克斯 QQ：345015918 .Net项目技术组群：306485590
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2014-02-06
 * * 说明：FrmMain.cs
 * *
********************************************************************/

using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin.SkinControl;
using LCSClientApplication.Forms;
using Lcs.Entity;

namespace LCSClientApplication
{
    public partial class FrmMain : Skin_DevExpress
    {
        public FrmMain()
        {
            InitializeComponent();
            func_tab.SelectedIndex = 0;
            timer1.Start();
            // Init();
        }

        //void Init()
        //{
        //    foreach (TabPage page in func_tab.TabPages)
        //    {
        //        foreach (var ctr in page.Controls)
        //        {
        //            if (ctr is SkinButton)
        //            {
        //                SkinButton button = ((SkinButton)ctr);
        //                button.NormlBack = Image.FromFile("Images/b1.png");
        //                button.DownBack = Image.FromFile("Images/b2.png");
        //                button.MouseBack = Image.FromFile("Images/b3.png");
        //            }
        //        }
        //    }
        //}
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLab.Text = "系统时间:" + DateTime.Now.ToString("yy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 历史订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton4_Click(object sender, EventArgs e)
        {
            FrmHistotyOrder frmHistotyOrder = new FrmHistotyOrder();
            frmHistotyOrder.Icon = this.Icon;
            frmHistotyOrder.Show();
        }

        /// <summary>
        /// 产品管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton12_Click_1(object sender, EventArgs e)
        {
            FrmProductManage frmProductManage = new FrmProductManage();
            frmProductManage.Icon = this.Icon;
            frmProductManage.Show();
        }

       
        private void tabShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabShow.SelectedIndex)
            {
                case 2:
                    FrmExcelImportGuid frmGuid1 = new FrmExcelImportGuid();
                    frmGuid1.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
