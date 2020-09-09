﻿using CCWin;
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
            InitGrid();
        }

        GoodsDel goodsDel = new GoodsDel();
        List<articulo> Goods;

        private void InitGrid()
        {
            product_grid.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewCheckBoxColumn{Name="status",HeaderText="可用",DataPropertyName="status",ValueType=typeof(bool)},
                new DataGridViewImageColumn{Name="image",HeaderText="图片",DataPropertyName="image",ValueType=typeof(Image)},
                new DataGridViewTextBoxColumn{Name="weizhi",HeaderText="位置",DataPropertyName="weizhi",ValueType=typeof(string)},
                new DataGridViewTextBoxColumn{Name="bianhao",HeaderText="编号",DataPropertyName="bianhao",ValueType=typeof(string)},
                new DataGridViewTextBoxColumn{Name="tiaoxing",HeaderText="条形",DataPropertyName="tiaoxing",ValueType=typeof(string)},
                new DataGridViewTextBoxColumn{Name="zhongwenpingming",HeaderText="中文品名",DataPropertyName="zhongwenpingming",ValueType=typeof(string)},
                new DataGridViewTextBoxColumn{Name="baozhuangshu",HeaderText="包装数",DataPropertyName="baozhuangshu",ValueType=typeof(string)},
                new DataGridViewTextBoxColumn{Name="zhuangxiangshu",HeaderText="装箱数",DataPropertyName="zhuangxiangshu",ValueType=typeof(decimal)},
                new DataGridViewTextBoxColumn{Name="shijia",HeaderText="实价",DataPropertyName="shijia",ValueType=typeof(decimal)},
                new DataGridViewTextBoxColumn{Name="kucun",HeaderText="库存",DataPropertyName="kucun",ValueType=typeof(decimal)},
                new DataGridViewTextBoxColumn{Name="beizhu",HeaderText="备注",DataPropertyName="beizhu",ValueType=typeof(string)}
            });
        }

        private void FrmProductManage_Load(object sender, EventArgs e)
        {
            SplashScreenHelper.ShowLoadingScreen();
            Goods = goodsDel.GetGoodsList();
            try
            {
                foreach (var item in Goods)
                {
                    //DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    //dataGridViewRow.Cells["status"].Value = ;
                    //dataGridViewRow.Cells["image"].Value = ;
                    //dataGridViewRow.Cells["weizhi"].Value = ;
                    //dataGridViewRow.Cells["bianhao"].Value = ;
                    //dataGridViewRow.Cells["tiaoxing"].Value = ;
                    //dataGridViewRow.Cells["zhongwenpingming"].Value = item.namecn;
                    //dataGridViewRow.Cells["baozhuangshu"].Value = item.baozhuangshu;
                    //dataGridViewRow.Cells["zhuangxiangshu"].Value = item.zhuangxiangshu;
                    //dataGridViewRow.Cells["shijia"].Value = item.maijia;
                    //dataGridViewRow.Cells["kucun"].Value = item.kucun;
                    //dataGridViewRow.Cells["beizhu"].Value = item.beizhu;
                    product_grid.Rows.Add(item.status == 0 ? true : false, Image.FromFile(@"Images\logo.jpg"),item.weizhi,
                        item.bianhao, item.codigo, item.namecn, item.baozhuangshu, item.zhuangxiangshu,item.maijia, item.kucun, item.beizhu);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                SplashScreenHelper.CloseForm();
            }

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            ActionProductCtr addProductCtr = new ActionProductCtr(ActoinType.add);
            addProductCtr.StartPosition = FormStartPosition.CenterScreen;
            addProductCtr.Text = "增加产品";
            addProductCtr.Icon = this.Icon;
            addProductCtr.ShowDialog();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            ActionProductCtr addProductCtr = new ActionProductCtr(ActoinType.modify);
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
