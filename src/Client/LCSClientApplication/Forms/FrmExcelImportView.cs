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
using System.Web.Configuration;
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
        DataTable dt;
        int index = 0;

        private void InitParams()
        {
            DataGridViewTextBoxColumn dataGridViewTextBox = new DataGridViewTextBoxColumn();
            dataGridViewTextBox.DataPropertyName = "DataName";
            dataGridViewTextBox.HeaderText = "数据名称";

            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.FlatStyle = FlatStyle.Flat;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isok_check.Checked)
            {
                MessageBox.Show("请选择确定后导入");
                return;
            }


            MessageBox.Show("导入成功！");

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                
                List<DataSetParams> dataSetParams = dataset_grid.DataSource as List<DataSetParams>;

                foreach (var item in dataSetParams)
                {
                    string addr = item.position.ToString();
                    string dataName = item.DataName;
                    if (item.position == Position.Null)
                    {
                        continue;
                    }

                    if (index == 0)
                    {
                        DataGridViewTextBoxColumn datacolumn = new DataGridViewTextBoxColumn { HeaderText = dataName + "[" + addr + "]", ValueType = typeof(string) };
                        import_preview_grid.Columns.Add(datacolumn);
                    }
                }

                var list = dataSetParams.Where(t => t.position != Position.Null).ToList();

                List<DataColumn> Columnlist = new List<DataColumn>();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    DataColumn column = dt.Columns[i];
                    Columnlist.Add(column);
                }


                List<DataColumn> Columnlist2 = new List<DataColumn>();
                foreach (var item in list)
                {
                    string addr = item.position.ToString();
                    var list2 = Columnlist.Where(t => t.ColumnName.Contains(addr)).ToList();
                    if (list2.Count == 0)
                    {
                        continue;
                    }
                    DataColumn column = list2[0];
                    Columnlist2.Add(column);
                }

                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    DataRow dr = dt.Rows[r];
                    string[] values = new string[Columnlist2.Count];
                    for (int i = 0; i < Columnlist2.Count; i++)
                    {
                        string value = dr[Columnlist2[i].ColumnName].ToString();
                        values[i] = value;
                    }
                    import_preview_grid.Rows.Add(values);
                }
                index++;
            }
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
