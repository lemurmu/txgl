using CommonFunction;
using Lcs.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace LCSClientApplication.Forms
{
    public partial class FrmExcelImportView : Form
    {
        public FrmExcelImportView(string excelPath, string sheetName)
        {
            InitializeComponent();
            this.excelName = excelPath;
            this.sheetName = sheetName;
            InitParams();
        }

        string excelName = "";
        string sheetName = "";
        private ExcelHelper helper = new ExcelHelper();
        private List<pedidokehu> orderList = new List<pedidokehu>();
        private void InitParams()
        {
            DataGridViewTextBoxColumn dataGridViewTextBox = new DataGridViewTextBoxColumn();
            dataGridViewTextBox.DataPropertyName = "DataName";
            dataGridViewTextBox.HeaderText = "数据名称";

            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = Enum.GetValues(typeof(Position));
            combo.DataPropertyName = "Position";
            combo.Name = "position";
            combo.HeaderText = "位置";
            dataset_grid.Columns.Add(dataGridViewTextBox);
            dataset_grid.Columns.Add(combo);
            List<DataSetParams> dataSetParams = new List<DataSetParams>
            {
                new DataSetParams{DataName="编号" ,position=Position.A},
                new DataSetParams{DataName="条形" ,position=Position.B},
                new DataSetParams{DataName="中文名" ,position=Position.C},
                new DataSetParams{DataName="西文名" ,position=Position.D},
                new DataSetParams{DataName="包装数" ,position=Position.E},
                new DataSetParams{DataName="装箱数" ,position=Position.F},
                new DataSetParams{DataName="进价" ,position=Position.G},
                new DataSetParams{DataName="卖价" ,position=Position.H},
                new DataSetParams{DataName="折扣" ,position=Position.I},
                new DataSetParams{DataName="折扣" ,position=Position.J},
                new DataSetParams{DataName="库存" ,position=Position.K},
                new DataSetParams{DataName="最低库存" ,position=Position.L},
                new DataSetParams{DataName="位置" ,position=Position.M},
                new DataSetParams{DataName="备注" ,position=Position.N},
            };
            dataset_grid.DataSource = dataSetParams;

             dt = helper.ImportExceltoDt(excelName, sheetName, 0);
            this.pre_grid.DataSource = dt;
        }
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isok_check.Checked)
            {
                MessageBox.Show("请选择确定后导入");
                return;
            }
            List<DataSetParams> dataSetParams = dataset_grid.DataSource as List<DataSetParams>;
            orderList.Clear();
            foreach (var item in dataSetParams)
            {
                int ColumnIndex = (int)item.position;
            }

          

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            import_preview_grid.DataSource = dt;
            import_preview_grid.Columns.AddRange(new DataGridViewColumn[] {
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
    }


    internal class DataSetParams
    {
        public string DataName { set; get; }

        public Position position { set; get; }
    }

    internal enum Position
    {
        A = 0,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        J,
        K,
        L,
        M,
        N,
        O,
        P,
        Q,
        R,
        S,
        T,
        U,
        V,
        W,
        X,
        Y,
        Z,
        Null,
    }
}
