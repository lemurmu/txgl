using CCWin;
using Lcs.DataAccess;
using Lcs.Entity;
using LCSClientApplication.CommonToolKit;
using LCSClientApplication.Controls;
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
    public partial class FrmProductManage : CCSkinMain
    {
        public FrmProductManage()
        {
            InitializeComponent();
        }

        GoodsDel goodsDel = new GoodsDel();
        List<lcs_goods> Goods;

        private void FrmProductManage_Load(object sender, EventArgs e)
        {
            //SplashScreenHelper.ShowLoadingScreen();
            //Goods = goodsDel.GetGoodsList();
            //product_grid.DataSource = Goods;
            //SplashScreenHelper.CloseForm();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            AddProductCtr addProductCtr = new AddProductCtr();
            addProductCtr.StartPosition = FormStartPosition.CenterScreen;
            addProductCtr.Text = "增加产品";
            addProductCtr.Icon = this.Icon;
            addProductCtr.ShowDialog();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            AddProductCtr addProductCtr = new AddProductCtr();
            addProductCtr.StartPosition = FormStartPosition.CenterScreen;
            addProductCtr.Text = "修改产品";
            addProductCtr.Icon = this.Icon;
            addProductCtr.ShowDialog();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定删除选中行？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                DataGridViewRow gridViewRow = product_grid.CurrentRow;
            }
        }
    }
}
