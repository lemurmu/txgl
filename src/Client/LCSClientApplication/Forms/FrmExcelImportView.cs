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
    public partial class FrmExcelImportView : Form
    {
        public FrmExcelImportView(string excelPath, string sheetName)
        {
            InitializeComponent();
            InitParams();
        }

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
        }
    }


    internal class DataSetParams
    {
        public string DataName { set; get; }

        public Position position { set; get; }
    }

    internal enum Position
    {
        A,
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
    }
}
