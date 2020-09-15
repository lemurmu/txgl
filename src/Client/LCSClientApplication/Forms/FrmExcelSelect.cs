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
    public partial class FrmExcelSelect : Form
    {
        public FrmExcelSelect()
        {
            InitializeComponent();
            excelFile_txt.Text = Global.ExcelFilePath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Global.ExcelFilePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmExcelGuidSaveDB().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string excelFile = excelFile_txt.Text;
            this.Close();
            new FrmExcelSelectSheet(excelFile).Show();
        }
    }
}
