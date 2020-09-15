using CCWin;
using System;
using System.Windows.Forms;

namespace LCSClientApplication.Forms
{
    public partial class FrmExcelImportGuid : Form
    {
        public FrmExcelImportGuid()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            actiontype_cmb.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Global.ExcelFilePath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmExcelGuidSaveDB().Show();
        }
    }
}
