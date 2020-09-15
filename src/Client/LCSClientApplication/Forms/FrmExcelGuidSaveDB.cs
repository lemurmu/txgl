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
    public partial class FrmExcelGuidSaveDB : Form
    {
        public FrmExcelGuidSaveDB()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmExcelSelect().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmExcelImportGuid().Show();
        }
    }
}
