using CommonFunction;
using System;
using System.Collections;
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
    public partial class FrmExcelSelectSheet : Form
    {
        public FrmExcelSelectSheet(string excelpath)
        {
            InitializeComponent();
            excelPath = excelpath;

            ArrayList array = helper.GetSheetName(excelPath);
            sheets_cmb.Items.AddRange(array.ToArray());
            sheets_cmb.SelectedIndex = 0;
        }
        string excelPath = "";
        ExcelHelper helper = new ExcelHelper();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmExcelSelect().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sheetName = sheets_cmb.Text;
            this.Close();
            new FrmExcelImportView(excelPath, sheetName).Show();
        }
    }
}
