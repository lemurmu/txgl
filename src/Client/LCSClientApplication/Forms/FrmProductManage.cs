using CCWin;
using CCWin.SkinControl;
using gregn6Lib;
using Lcs.DataAccess;
using Lcs.Entity;
using LcsClient;
using LCSClientApplication.CommonToolKit;
using LCSClientApplication.Controls;
using PagerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            LoadGoodsImageFiles();

            pagerControl = new PagerControl();
            pagerControl.Parent = skinPanel;
            pagerControl.Dock = DockStyle.Fill;
            pagerControl.PageChange += PagerControlTest_PageChange;
            pagerControl.PageChangeWithObject += PagerControlTest_PageChangeWithObject;
            skinPanel.Controls.Add(pagerControl);

            report_cmb.SelectedIndex = 0;
            // leibie_cmb.SelectedIndex = 0;
            jinyong_cmb.SelectedIndex = 0;
            maijia_cmb.SelectedIndex = 0;
        }

        GoodsDel goodsDel = new GoodsDel();
        PagerControl pagerControl;
        GridppReport Report;

        private List<articulo> Goods { set; get; }

        private void InitGrid()
        {
            product_grid.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewCheckBoxColumn{Name="status",HeaderText="可用",DataPropertyName="status",ValueType=typeof(bool)},
                new DataGridViewImageColumn{Name="image",HeaderText="图片",DataPropertyName="image",ValueType=typeof(Image),AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill},
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

        private void LoadGoodsImageFiles()
        {
            string folder = Global.IniConfig["GoodsImageFilePath"]["imagefile"];
            if (!Directory.Exists(folder))
            {
                return;
            }
            DirectoryInfo theFolder = new DirectoryInfo(folder);
            DirectoryInfo[] dirInfo = theFolder.GetDirectories();
            foreach (DirectoryInfo Imagefoler in dirInfo)
            {
                leibie_cmb.Items.Add(Imagefoler.Name);
            }
            leibie_cmb.SelectedIndex = 0;
        }

        private void FrmProductManage_Load(object sender, EventArgs e)
        {
            //设置当前页
            pagerControl.CurrentPage = 1;
            //设置每页显示的记录数
            pagerControl.RowsPerPage = 10;

        }

        private void skinButton12_Click(object sender, EventArgs e)
        {
            ActionProductCtr addProductCtr = new ActionProductCtr(ActoinType.add);
            addProductCtr.StartPosition = FormStartPosition.CenterScreen;
            addProductCtr.Text = "增加产品";
            addProductCtr.Icon = this.Icon;
            addProductCtr.ShowDialog();
        }

        private void skinButton5_Click(object sender, EventArgs e)
        {
            ActionProductCtr addProductCtr = new ActionProductCtr(ActoinType.modify);
            addProductCtr.StartPosition = FormStartPosition.CenterScreen;
            addProductCtr.Text = "修改产品";
            addProductCtr.Icon = this.Icon;

            DataGridViewRow gridViewRow = product_grid.CurrentRow;
            addProductCtr.SetGoodTextValue(Goods[gridViewRow.Index]);

            addProductCtr.ShowDialog();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定删除选中行？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                try
                {
                    DataGridViewRow gridViewRow = product_grid.CurrentRow;
                    goodsDel.Delete(Goods[gridViewRow.Index].id);
                    Goods.Remove(Goods[gridViewRow.Index]);
                    product_grid.Rows.Remove(gridViewRow);
                    MessageBox.Show("删除成功！");
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    MessageBox.Show("删除失败！");
                }

            }
        }

        #region 分页
        /// <summary>
        /// 事件处理
        /// </summary>
        /// <param name="obj"></param>
        void PagerControlTest_PageChangeWithObject(object obj)
        {
            PagerLib.PagerControl pager = obj as PagerLib.PagerControl;
            //if (pager != null)
            //{
            //    Console.WriteLine(pager.Name);
            //}
        }

        /// <summary>
        /// 事件处理
        /// </summary>
        void PagerControlTest_PageChange()
        {
            GetSource();
        }

        /// <summary>
        /// 处理分页
        /// </summary>
        private void GetSource()
        {
            SplashScreenHelper.ShowLoadingScreen();
            //获得当前页
            int cur = pagerControl.CurrentPage;
            //获得每页显示的记录数
            int rows = pagerControl.RowsPerPage;
            int totalCount = 10;

            Goods = goodsDel.PageQuery(cur, rows, ref totalCount);
            pagerControl.RecordCount = totalCount;
            pagerControl.TotalPage = totalCount / pagerControl.RowsPerPage + 1;
            try
            {
                product_grid.Rows.Clear();
                foreach (var item in Goods)
                {
                    Image image = Image.FromFile(@"Images\1.png");
                    product_grid.RowTemplate.Height = image.Height;
                    product_grid.Rows.Add(item.status == 0 ? true : false, image, item.weizhi,
                        item.bianhao, item.codigo, item.namecn, item.baozhuangshu, item.zhuangxiangshu, item.maijia, item.kucun, item.beizhu);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
            finally
            {
                SplashScreenHelper.CloseForm();
            }
        }
        #endregion

        private void skinButton1_Click(object sender, EventArgs e)
        {
            string quetyStr = query_txt.Text;
            if (quetyStr.IsNullOrEmpty())
            {
                MessageBox.Show("查询条件为空！");
                return;
            }
            try
            {
                //linq模糊查询语句
                var query = from x in Goods
                            let temp = Goods.Select(t => new
                            {
                                ID = t.id,
                                all = t.id + "," + t.weizhi + "," + t.bianhao + "," + t.codigo + "," +
                            t.namecn + "," + t.baozhuangshu + "," + t.zhuangxiangshu + "," + t.maijia + "," + t.kucun + "," + t.beizhu
                            })
                            .Where(t => t.all.Contains(quetyStr)).Select(t => t.ID)
                            where temp.Contains(x.id)
                            select x;
                List<articulo> articulos = query.ToList();
                product_grid.Rows.Clear();
                foreach (var item in articulos)
                {
                    Image image = Image.FromFile(@"Images\1.png");
                    product_grid.RowTemplate.Height = image.Height;
                    product_grid.Rows.Add(item.status == 0 ? true : false, image, item.weizhi,
                        item.bianhao, item.codigo, item.namecn, item.baozhuangshu, item.zhuangxiangshu, item.maijia, item.kucun, item.beizhu);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("模糊查询错误:" + ex.Message);
            }


        }

        /// <summary>
        /// 导出预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton2_Click(object sender, EventArgs e)
        {
            if (Goods == null)
            {
                MessageBox.Show("无产品数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //从对应文件中载入报表模板数据
            Report = new GridppReport();
            // Report.DetailGrid.Recordset.ConnectionString = GridppReportDemo.Utility.GetDatabaseConnectionString();
            //Report.ExportBegin += new _IGridppReportEvents_ExportBeginEventHandler(ReportExportBegin);
            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Grid\\产品管理列表.grf");
            Report.LoadFromFile(reportPath);
            Report.FetchRecord += ReportList_FetchRecord;

            Report.PrintPreview(true);
        }

        private void ReportList_FetchRecord()
        {
            GridReportHelper.FillRecordToReport<articulo>(Report, Goods);
        }

        private void jinyong_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<articulo> articulos = null;
            switch (jinyong_cmb.SelectedIndex)
            {
                case 0://全部产品
                    articulos = Goods;
                    break;
                case 1://未禁用
                   articulos= Goods.Where(t => t.status == 0).ToList();
                    break;
                case 2://禁用
                    articulos= Goods.Where(t => t.status != 0).ToList();
                    break;
                default:
                    break;
            }
            if (articulos == null) { return; }
            product_grid.Rows.Clear();
            foreach (var item in articulos)
            {
                Image image = Image.FromFile(@"Images\1.png");
                product_grid.RowTemplate.Height = image.Height;
                product_grid.Rows.Add(item.status == 0 ? true : false, image, item.weizhi,
                    item.bianhao, item.codigo, item.namecn, item.baozhuangshu, item.zhuangxiangshu, item.maijia, item.kucun, item.beizhu);
            }
        }
    }


}
