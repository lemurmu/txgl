using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using gregn6Lib;

namespace Export
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private GridppReport Report = new GridppReport(); //定义Grid++Report报表主对象
        private bool m_ExportToEmail = false;

        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnCallExportDirect;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnPrintPreview;
		private System.Windows.Forms.CheckBox ckbShowOptionDlg;
		private System.Windows.Forms.ComboBox cmbExportType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox ckbSupressEmptyLines;
        private System.Windows.Forms.CheckBox ckbOnlyDetailGrid;
		private System.Windows.Forms.Button btnSaveAsGDR;
		private System.Windows.Forms.Button btnViewGDRFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btnExportMail;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
			//载入报表模板数据
			Report.LoadFromFile(GridppReportDemo.Utility.GetReportTemplatePath() + "1a.简单表格.grf");

			//设置与数据源的连接串，因为在设计时指定的数据库路径是绝对路径。
			Report.DetailGrid.Recordset.ConnectionString = GridppReportDemo.Utility.GetDatabaseConnectionString();

			Report.ExportBegin += new _IGridppReportEvents_ExportBeginEventHandler(ReportExportBegin);

			cmbExportType.Items.Add( new ExportInfo("Excel", "xls", GRExportType.gretXLS) );
			cmbExportType.Items.Add( new ExportInfo("RTF", "rtf", GRExportType.gretRTF) );
			cmbExportType.Items.Add( new ExportInfo("PDF", "pdf", GRExportType.gretPDF) );
			cmbExportType.Items.Add( new ExportInfo("Html", "htm", GRExportType.gretHTM) );
			cmbExportType.Items.Add( new ExportInfo("Image", "tif", GRExportType.gretIMG) );
			cmbExportType.Items.Add( new ExportInfo("Text", "txt", GRExportType.gretTXT) );
			cmbExportType.Items.Add( new ExportInfo("CSV", "csv", GRExportType.gretCSV) );
			cmbExportType.SelectedIndex = 0;
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportMail = new System.Windows.Forms.Button();
            this.ckbSupressEmptyLines = new System.Windows.Forms.CheckBox();
            this.ckbOnlyDetailGrid = new System.Windows.Forms.CheckBox();
            this.ckbShowOptionDlg = new System.Windows.Forms.CheckBox();
            this.cmbExportType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCallExportDirect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnViewGDRFile = new System.Windows.Forms.Button();
            this.btnSaveAsGDR = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportMail);
            this.groupBox1.Controls.Add(this.ckbSupressEmptyLines);
            this.groupBox1.Controls.Add(this.ckbOnlyDetailGrid);
            this.groupBox1.Controls.Add(this.ckbShowOptionDlg);
            this.groupBox1.Controls.Add(this.cmbExportType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCallExportDirect);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据导出";
            // 
            // btnExportMail
            // 
            this.btnExportMail.Location = new System.Drawing.Point(24, 157);
            this.btnExportMail.Name = "btnExportMail";
            this.btnExportMail.Size = new System.Drawing.Size(224, 23);
            this.btnExportMail.TabIndex = 9;
            this.btnExportMail.Text = "方式三: 导出并发送电子邮件";
            this.btnExportMail.Click += new System.EventHandler(this.btnExportMail_Click);
            // 
            // ckbSupressEmptyLines
            // 
            this.ckbSupressEmptyLines.Location = new System.Drawing.Point(16, 96);
            this.ckbSupressEmptyLines.Name = "ckbSupressEmptyLines";
            this.ckbSupressEmptyLines.Size = new System.Drawing.Size(104, 24);
            this.ckbSupressEmptyLines.TabIndex = 7;
            this.ckbSupressEmptyLines.Text = "压缩空白行";
            // 
            // ckbOnlyDetailGrid
            // 
            this.ckbOnlyDetailGrid.Location = new System.Drawing.Point(16, 72);
            this.ckbOnlyDetailGrid.Name = "ckbOnlyDetailGrid";
            this.ckbOnlyDetailGrid.Size = new System.Drawing.Size(112, 24);
            this.ckbOnlyDetailGrid.TabIndex = 6;
            this.ckbOnlyDetailGrid.Text = "只导出明细网格";
            // 
            // ckbShowOptionDlg
            // 
            this.ckbShowOptionDlg.Checked = true;
            this.ckbShowOptionDlg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbShowOptionDlg.Location = new System.Drawing.Point(16, 48);
            this.ckbShowOptionDlg.Name = "ckbShowOptionDlg";
            this.ckbShowOptionDlg.Size = new System.Drawing.Size(160, 24);
            this.ckbShowOptionDlg.TabIndex = 5;
            this.ckbShowOptionDlg.Text = "显示选项对话框";
            // 
            // cmbExportType
            // 
            this.cmbExportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExportType.Location = new System.Drawing.Point(80, 16);
            this.cmbExportType.Name = "cmbExportType";
            this.cmbExportType.Size = new System.Drawing.Size(104, 20);
            this.cmbExportType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "文件类型：";
            // 
            // btnCallExportDirect
            // 
            this.btnCallExportDirect.Location = new System.Drawing.Point(24, 128);
            this.btnCallExportDirect.Name = "btnCallExportDirect";
            this.btnCallExportDirect.Size = new System.Drawing.Size(224, 23);
            this.btnCallExportDirect.TabIndex = 0;
            this.btnCallExportDirect.Text = "方式一: Call ExportDirect";
            this.btnCallExportDirect.Click += new System.EventHandler(this.btnCallExportDirect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnViewGDRFile);
            this.groupBox2.Controls.Add(this.btnSaveAsGDR);
            this.groupBox2.Location = new System.Drawing.Point(16, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 88);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid++Report 文档文件";
            // 
            // btnViewGDRFile
            // 
            this.btnViewGDRFile.Location = new System.Drawing.Point(24, 56);
            this.btnViewGDRFile.Name = "btnViewGDRFile";
            this.btnViewGDRFile.Size = new System.Drawing.Size(224, 24);
            this.btnViewGDRFile.TabIndex = 1;
            this.btnViewGDRFile.Text = "载入并查看...";
            this.btnViewGDRFile.Click += new System.EventHandler(this.btnViewGDRFile_Click);
            // 
            // btnSaveAsGDR
            // 
            this.btnSaveAsGDR.Location = new System.Drawing.Point(24, 24);
            this.btnSaveAsGDR.Name = "btnSaveAsGDR";
            this.btnSaveAsGDR.Size = new System.Drawing.Size(224, 24);
            this.btnSaveAsGDR.TabIndex = 0;
            this.btnSaveAsGDR.Text = "保存为...";
            this.btnSaveAsGDR.Click += new System.EventHandler(this.btnSaveAsGDR_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(200, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(16, 314);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPrintPreview.TabIndex = 5;
            this.btnPrintPreview.Text = "打印预览";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "grd";
            this.openFileDialog1.Filter = "grd files (*.grd)|*.grd|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "grd";
            this.saveFileDialog1.Filter = "grd files (*.grd)|*.grd|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(304, 347);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		void ReportExportBegin(IGRExportOption Sender)
		{
            //ExportBegin 事件在将报表导出之前会触发到，无论是调用 ExportDirect 与 Export 方法，
            //还是从打印预览窗口等地方执行导出，都会触发到 ExportBegin 事件。
            //通常在 ExportBegin 事件中设置导出选项参数，改变默认导出行为

            Sender.AbortOpenFile = true;  //导出后不用关联程序打开导出文件，如导出Excel文件之后不用Excel打开
            Sender.AbortShowOptionDlg = !ckbShowOptionDlg.Checked;  //导出之前不显示导出选项设置对话框

            //指定导出文件的完整路径与文件名称
            string FileName = GetExportFileName(false);
            Sender.FileName = FileName; //"d:\\export\\my.dat";

            //根据导出类型设置其特有的选项参数，有关选项参数的具体信息清参考帮助文档。
            //IGRExportOption是导出选项的基类，其它具体导出选项的接口名称都以IGRE2为前缀
            bool OnlyExportDetailGrid = ckbOnlyDetailGrid.Checked;
            bool SupressEmptyLines = ckbSupressEmptyLines.Checked;
            switch (Sender.ExportType)
            {
                case GRExportType.gretXLS:
                    Sender.AsE2XLSOption.OnlyExportDetailGrid = OnlyExportDetailGrid;
                    Sender.AsE2XLSOption.SupressEmptyLines = SupressEmptyLines;

                    Sender.AsE2XLSOption.ExportPageHeaderFooter = false;
                    Sender.AsE2XLSOption.SameAsPrint = false;
                    Sender.AsE2XLSOption.ExportPageBreak = false;
                    break;
                case GRExportType.gretRTF:
                    Sender.AsE2RTFOption.OnlyExportDetailGrid = OnlyExportDetailGrid;
                    Sender.AsE2RTFOption.SupressEmptyLines = SupressEmptyLines;
                    break;
                case GRExportType.gretPDF:
                    Sender.AsE2PDFOption.Author = "My Author";
                    Sender.AsE2PDFOption.Subject = "My Subject";
                    break;
                case GRExportType.gretHTM:
                    Sender.AsE2HTMOption.OnlyExportDetailGrid = OnlyExportDetailGrid;
                    Sender.AsE2HTMOption.SupressEmptyLines = SupressEmptyLines;
                    break;
                case GRExportType.gretIMG:
                    Sender.AsE2IMGOption.DPI = 300;
                    Sender.AsE2IMGOption.ImageType = GRExportImageType.greitPNG;
                    break;
                case GRExportType.gretTXT:
                    Sender.AsE2TXTOption.OnlyExportDetailGrid = OnlyExportDetailGrid;
                    Sender.AsE2TXTOption.SupressEmptyLines = SupressEmptyLines;
                    break;
                default:
                    Sender.AsE2CSVOption.OnlyExportDetailGrid = OnlyExportDetailGrid;
                    Sender.AsE2CSVOption.SupressEmptyLines = SupressEmptyLines;
                    break;
            }

            if ( m_ExportToEmail )
            {
                //指定导出后发送EMail并设定发送EMail的参数
                Sender.MailExportFile = true;
                Sender.MailTo = "name@domain.com";
                Sender.MailSubject = "报表导出并发送Email";
                Sender.MailText = "报表导出并发送Email的相关说明...";
            }
        }

		//得到选择的导出文件类型
		GRExportType GetExportType()
		{
			return ((ExportInfo)cmbExportType.SelectedItem).ExportType;
		}

		//得到本程序默认的导出文件
		string GetExportFileName(bool IsDirect)
		{
			string ExtFileName = ((ExportInfo)cmbExportType.SelectedItem).ExtFileName;
			string FileName = IsDirect? "ExportDircet" : "Export";
			return FileName + "." + ExtFileName;
		}

		private void btnCallExportDirect_Click(object sender, System.EventArgs e)
		{
            m_ExportToEmail = false;

			GRExportType ExportType = GetExportType();
			bool ShowOptionDlg = ckbShowOptionDlg.Checked;
			string FileName = GetExportFileName(true);

			//直接调用ExportDirect方法执行导出任务
			Report.ExportDirect(ExportType, FileName, ShowOptionDlg, true);		
		}

		private void btnExportMail_Click(object sender, System.EventArgs e)
		{
            m_ExportToEmail = true;

            //GRExportType ExportType = GetExportType();

            //IGRExportOption Sender = Report.PrepareExport(ExportType);

            ////指定导出后发送EMail并设定发送EMail的参数
            //Sender.MailExportFile = true;
            //Sender.MailTo = "name@domain.com";
            //Sender.MailSubject = "报表导出并发送Email";
            //Sender.MailText = "报表导出并发送Email的相关说明...";

            ////导出后不打开文件查看
            //Report.Export(false);

            ////最后一定要记得调用 UnprepareExport 释放导出过程中占据的资源
            //Report.UnprepareExport();
            GRExportType ExportType = GetExportType();
            bool ShowOptionDlg = ckbShowOptionDlg.Checked;
            string FileName = GetExportFileName(true);

            //直接调用ExportDirect方法执行导出任务
            Report.ExportDirect(ExportType, FileName, ShowOptionDlg, true);
        }

		private void btnPrintPreview_Click(object sender, System.EventArgs e)
		{
			//在打印查看器的工具条上有一个导出按钮，可以执行导出任务
			Report.PrintPreview(true);
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnSaveAsGDR_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.FileName = "Grid++Report.grd";
			if ( saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Report.GenerateDocumentFile( saveFileDialog1.FileName  );
			}
		}

		private void btnViewGDRFile_Click(object sender, System.EventArgs e)
		{
			if ( openFileDialog1.ShowDialog() == DialogResult.OK )
			{
				ViewGRDForm theForm = new ViewGRDForm();
				theForm.FileName = openFileDialog1.FileName;
				theForm.ShowDialog();
			}
		}
	}

	public class ExportInfo
	{
		private GRExportType m_ExportType;
		private string m_DisplayText;
		private string m_ExtFileName;

		public ExportInfo(string DisplayText, string ExtFileName, GRExportType ExportType)
		{
			this.m_DisplayText = DisplayText;
			this.m_ExtFileName = ExtFileName;
			this.m_ExportType = ExportType;
		}

		public string DisplyText
		{
			get
			{
				return m_DisplayText;
			}
		}

		public string ExtFileName
		{
			get
			{
				return m_ExtFileName;
			}
		}

		public GRExportType ExportType
		{
			get
			{
				return m_ExportType;
			}
		}

		public override string ToString()
		{
			return m_DisplayText;
		}
	}
}
