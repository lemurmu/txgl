using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Export
{
	/// <summary>
	/// ViewGRDForm ��ժҪ˵����
	/// </summary>
	public class ViewGRDForm : System.Windows.Forms.Form
	{
        public string FileName;
        private Axgregn6Lib.AxGRPrintViewer axGRPrintViewer1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ViewGRDForm()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewGRDForm));
            this.axGRPrintViewer1 = new Axgregn6Lib.AxGRPrintViewer();
            ((System.ComponentModel.ISupportInitialize)(this.axGRPrintViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axGRPrintViewer1
            // 
            this.axGRPrintViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axGRPrintViewer1.Enabled = true;
            this.axGRPrintViewer1.Location = new System.Drawing.Point(0, 0);
            this.axGRPrintViewer1.Name = "axGRPrintViewer1";
            this.axGRPrintViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGRPrintViewer1.OcxState")));
            this.axGRPrintViewer1.Size = new System.Drawing.Size(616, 502);
            this.axGRPrintViewer1.TabIndex = 0;
            // 
            // ViewGRDForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(616, 502);
            this.Controls.Add(this.axGRPrintViewer1);
            this.Name = "ViewGRDForm";
            this.Text = "�鿴Grid++Report�ĵ��ļ�";
            this.Load += new System.EventHandler(this.ViewGRDForm_Load);
            this.Closed += new System.EventHandler(this.ViewGRDForm_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.axGRPrintViewer1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void ViewGRDForm_Load(object sender, System.EventArgs e)
		{
			axGRPrintViewer1.LoadFromDocumentFile(FileName);
		}

		private void ViewGRDForm_Closed(object sender, System.EventArgs e)
		{
		}
	}
}
