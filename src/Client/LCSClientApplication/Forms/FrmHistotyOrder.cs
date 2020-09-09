using CCWin;
using gregn6Lib;
using GridppReportDemo;
using Lcs.DataAccess;
using Lcs.Entity;
using LCSClientApplication.CommonToolKit;
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
    public partial class FrmHistotyOrder : CCSkinMain
    {
        public FrmHistotyOrder()
        {
            InitializeComponent();
            skinDataGridView.Columns.AddRange(new DataGridViewColumn[] {
            new DataGridViewTextBoxColumn { HeaderText="订单编号",DataPropertyName="bianhao"},
            new DataGridViewTextBoxColumn  { HeaderText="订单日期",DataPropertyName="fecha_c"},
            new DataGridViewTextBoxColumn { HeaderText="客户名称",DataPropertyName="name"},
            new DataGridViewTextBoxColumn { HeaderText="联系人",DataPropertyName="lianxiren"},
            new DataGridViewTextBoxColumn { HeaderText="业务员",DataPropertyName="rate"},
            new DataGridViewTextBoxColumn { HeaderText="备注",DataPropertyName="beizhu"},
            });
            this.skinDataGridView.AutoGenerateColumns = false;
        }

        private OrderDel _orderDel = new OrderDel();
        private GridppReport Report; //定义Grid++Report报表主对象
        List<pedidokehu> orderList;

        /// <summary>
        /// 加载时查询数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHistotyOrder_Load(object sender, EventArgs e)
        {
            SplashScreenHelper.ShowLoadingScreen();
            orderList = _orderDel.GetHistoricalOrders();
            skinDataGridView.DataSource = orderList;
            SplashScreenHelper.CloseForm();
        }


        void ReportExportBegin(IGRExportOption Sender)
        {
            //ExportBegin 事件在将报表导出之前会触发到，无论是调用 ExportDirect 与 Export 方法，
            //还是从打印预览窗口等地方执行导出，都会触发到 ExportBegin 事件。
            //通常在 ExportBegin 事件中设置导出选项参数，改变默认导出行为

            Sender.AbortOpenFile = true;  //导出后不用关联程序打开导出文件，如导出Excel文件之后不用Excel打开
                                          // Sender.AbortShowOptionDlg = !ckbShowOptionDlg.Checked;  //导出之前不显示导出选项设置对话框
        }

        private void ReportList_FetchRecord()
        {
            GridReportHelper.FillRecordToReport<pedidokehu>(Report, orderList);
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (orderList == null)
            {
                MessageBox.Show("无历史订单！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //从对应文件中载入报表模板数据
            Report = new GridppReport();
            // Report.DetailGrid.Recordset.ConnectionString = GridppReportDemo.Utility.GetDatabaseConnectionString();
            Report.ExportBegin += new _IGridppReportEvents_ExportBeginEventHandler(ReportExportBegin);
            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Grid\\订单明细列表.grf");
            Report.LoadFromFile(reportPath);
            Report.FetchRecord += ReportList_FetchRecord;

            Report.PrintPreview(true);
        }
    }
}


