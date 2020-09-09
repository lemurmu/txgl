using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Lcs.DataAccess;
using Lcs.Entity;
using DevExpress.XtraPrinting;

namespace LcsClient.Control
{
    public partial class OrderHistoryCtrl : DevExpress.XtraEditors.XtraUserControl
    {
        public OrderHistoryCtrl()
        {
            InitializeComponent();
        }

        OrderDel _orderDel = new OrderDel();

        private void OrderHistoryCtrol_Load(object sender, EventArgs e)
        {
           // List<lcs_order_info> orderList = _orderDel.GetHistoricalOrders();
            //orderGrid.DataSource = orderList;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //if (DevExpress.XtraPrinting.PrintHelper.IsPrintingAvailable)
            //{
                PrintingSystem ps = new PrintingSystem();
            
                PrintableComponentLink link = new PrintableComponentLink(ps);
                link.Component = orderGrid;
                link.Landscape = true;
                PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
                phf.Header.Content.Clear();
                phf.Header.Content.AddRange(new string[] {"", "订单明细列表", ""});
                phf.Header.Font = new System.Drawing.Font("宋体", 16, System.Drawing.FontStyle.Regular);
                phf.Header.LineAlignment = BrickAlignment.Center;
                phf.Footer.Content.Clear();
                phf.Footer.Content.AddRange(new string[] { "", String.Format("打印时间: {0:g}", DateTime.Now), "" });
                link.CreateDocument();
                link.ShowPreview();
            //}
            //else
            //{
            //    XtraMessageBox.Show("打印机不可用...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
