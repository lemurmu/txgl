namespace LCSClientApplication.Forms
{
    partial class FrmProductManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductManage));
            this.product_grid = new CCWin.SkinControl.SkinDataGridView();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.leibie_cmb = new CCWin.SkinControl.SkinComboBox();
            this.jinyong_cmb = new CCWin.SkinControl.SkinComboBox();
            this.maijia_cmb = new CCWin.SkinControl.SkinComboBox();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.report_cmb = new CCWin.SkinControl.SkinComboBox();
            this.skinPanel = new CCWin.SkinControl.SkinPanel();
            this.query_txt = new CCWin.SkinControl.SkinTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton5 = new CCWin.SkinControl.SkinButton();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.skinButton12 = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // product_grid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.product_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.product_grid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.product_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product_grid.ColumnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.product_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.product_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_grid.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.product_grid.EnableHeadersVisualStyles = false;
            this.product_grid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.product_grid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.product_grid.HeadFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.product_grid.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.product_grid.Location = new System.Drawing.Point(-1, 131);
            this.product_grid.Name = "product_grid";
            this.product_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.product_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.product_grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.product_grid.RowTemplate.Height = 50;
            this.product_grid.Size = new System.Drawing.Size(1146, 577);
            this.product_grid.TabIndex = 0;
            this.product_grid.TitleBack = null;
            this.product_grid.TitleBackColorBegin = System.Drawing.Color.White;
            this.product_grid.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(13, 76);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(37, 20);
            this.skinLabel1.TabIndex = 40;
            this.skinLabel1.Text = "添加";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(94, 76);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(37, 20);
            this.skinLabel2.TabIndex = 41;
            this.skinLabel2.Text = "编辑";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(173, 76);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(37, 20);
            this.skinLabel3.TabIndex = 42;
            this.skinLabel3.Text = "删除";
            // 
            // leibie_cmb
            // 
            this.leibie_cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.leibie_cmb.FormattingEnabled = true;
            this.leibie_cmb.Location = new System.Drawing.Point(318, 102);
            this.leibie_cmb.Name = "leibie_cmb";
            this.leibie_cmb.Size = new System.Drawing.Size(121, 22);
            this.leibie_cmb.TabIndex = 45;
            this.leibie_cmb.WaterText = "";
            // 
            // jinyong_cmb
            // 
            this.jinyong_cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.jinyong_cmb.FormattingEnabled = true;
            this.jinyong_cmb.Items.AddRange(new object[] {
            "全部产品",
            "未禁用产品",
            "禁用产品"});
            this.jinyong_cmb.Location = new System.Drawing.Point(637, 103);
            this.jinyong_cmb.Name = "jinyong_cmb";
            this.jinyong_cmb.Size = new System.Drawing.Size(121, 22);
            this.jinyong_cmb.TabIndex = 46;
            this.jinyong_cmb.WaterText = "";
            this.jinyong_cmb.SelectedIndexChanged += new System.EventHandler(this.jinyong_cmb_SelectedIndexChanged);
            // 
            // maijia_cmb
            // 
            this.maijia_cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.maijia_cmb.FormattingEnabled = true;
            this.maijia_cmb.Items.AddRange(new object[] {
            "卖价1",
            "卖价2",
            "卖价3"});
            this.maijia_cmb.Location = new System.Drawing.Point(479, 102);
            this.maijia_cmb.Name = "maijia_cmb";
            this.maijia_cmb.Size = new System.Drawing.Size(121, 22);
            this.maijia_cmb.TabIndex = 47;
            this.maijia_cmb.WaterText = "";
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(1063, 41);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(75, 23);
            this.skinButton2.TabIndex = 48;
            this.skinButton2.Text = "导出预览";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // report_cmb
            // 
            this.report_cmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.report_cmb.FormattingEnabled = true;
            this.report_cmb.Items.AddRange(new object[] {
            "当前列表",
            "全部类型"});
            this.report_cmb.Location = new System.Drawing.Point(974, 41);
            this.report_cmb.Name = "report_cmb";
            this.report_cmb.Size = new System.Drawing.Size(83, 22);
            this.report_cmb.TabIndex = 49;
            this.report_cmb.WaterText = "";
            // 
            // skinPanel
            // 
            this.skinPanel.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel.DownBack = null;
            this.skinPanel.Location = new System.Drawing.Point(-1, 707);
            this.skinPanel.MouseBack = null;
            this.skinPanel.Name = "skinPanel";
            this.skinPanel.NormlBack = null;
            this.skinPanel.Size = new System.Drawing.Size(1146, 35);
            this.skinPanel.TabIndex = 50;
            // 
            // query_txt
            // 
            this.query_txt.BackColor = System.Drawing.Color.Transparent;
            this.query_txt.DownBack = null;
            this.query_txt.Icon = null;
            this.query_txt.IconIsButton = false;
            this.query_txt.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.query_txt.IsPasswordChat = '\0';
            this.query_txt.IsSystemPasswordChar = false;
            this.query_txt.Lines = new string[0];
            this.query_txt.Location = new System.Drawing.Point(7, 96);
            this.query_txt.Margin = new System.Windows.Forms.Padding(0);
            this.query_txt.MaxLength = 32767;
            this.query_txt.MinimumSize = new System.Drawing.Size(28, 28);
            this.query_txt.MouseBack = null;
            this.query_txt.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.query_txt.Multiline = false;
            this.query_txt.Name = "query_txt";
            this.query_txt.NormlBack = null;
            this.query_txt.Padding = new System.Windows.Forms.Padding(5);
            this.query_txt.ReadOnly = false;
            this.query_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.query_txt.Size = new System.Drawing.Size(212, 28);
            // 
            // 
            // 
            this.query_txt.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.query_txt.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.query_txt.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.query_txt.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.query_txt.SkinTxt.Name = "BaseText";
            this.query_txt.SkinTxt.Size = new System.Drawing.Size(202, 18);
            this.query_txt.SkinTxt.TabIndex = 0;
            this.query_txt.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.query_txt.SkinTxt.WaterText = "请输入查询内容...";
            this.query_txt.TabIndex = 43;
            this.query_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.query_txt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.query_txt.WaterText = "请输入查询内容...";
            this.query_txt.WordWrap = true;
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.DownBack")));
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.White;
            this.skinButton1.Location = new System.Drawing.Point(222, 96);
            this.skinButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.MouseBack")));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.NormlBack")));
            this.skinButton1.Size = new System.Drawing.Size(29, 28);
            this.skinButton1.TabIndex = 44;
            this.skinButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton5
            // 
            this.skinButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinButton5.BackColor = System.Drawing.Color.Transparent;
            this.skinButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton5.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton5.DownBack")));
            this.skinButton5.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton5.ForeColor = System.Drawing.Color.White;
            this.skinButton5.Location = new System.Drawing.Point(82, 31);
            this.skinButton5.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton5.MouseBack")));
            this.skinButton5.Name = "skinButton5";
            this.skinButton5.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton5.NormlBack")));
            this.skinButton5.Size = new System.Drawing.Size(49, 42);
            this.skinButton5.TabIndex = 39;
            this.skinButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.skinButton5.UseVisualStyleBackColor = false;
            this.skinButton5.Click += new System.EventHandler(this.skinButton5_Click);
            // 
            // skinButton4
            // 
            this.skinButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton4.DownBack")));
            this.skinButton4.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton4.ForeColor = System.Drawing.Color.White;
            this.skinButton4.Location = new System.Drawing.Point(166, 31);
            this.skinButton4.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton4.MouseBack")));
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton4.NormlBack")));
            this.skinButton4.Size = new System.Drawing.Size(44, 42);
            this.skinButton4.TabIndex = 38;
            this.skinButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.skinButton4.UseVisualStyleBackColor = false;
            this.skinButton4.Click += new System.EventHandler(this.skinButton4_Click);
            // 
            // skinButton12
            // 
            this.skinButton12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinButton12.AutoEllipsis = true;
            this.skinButton12.BackColor = System.Drawing.Color.Transparent;
            this.skinButton12.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.skinButton12.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton12.DownBack")));
            this.skinButton12.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skinButton12.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton12.ForeColor = System.Drawing.Color.White;
            this.skinButton12.Location = new System.Drawing.Point(7, 31);
            this.skinButton12.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton12.MouseBack")));
            this.skinButton12.Name = "skinButton12";
            this.skinButton12.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton12.NormlBack")));
            this.skinButton12.Size = new System.Drawing.Size(43, 42);
            this.skinButton12.TabIndex = 37;
            this.skinButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.skinButton12.UseVisualStyleBackColor = false;
            this.skinButton12.Click += new System.EventHandler(this.skinButton12_Click);
            // 
            // FrmProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 742);
            this.Controls.Add(this.skinPanel);
            this.Controls.Add(this.report_cmb);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.maijia_cmb);
            this.Controls.Add(this.jinyong_cmb);
            this.Controls.Add(this.leibie_cmb);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.query_txt);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinButton5);
            this.Controls.Add(this.skinButton4);
            this.Controls.Add(this.skinButton12);
            this.Controls.Add(this.product_grid);
            this.MaximizeBox = false;
            this.Name = "FrmProductManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品资料";
            this.Load += new System.EventHandler(this.FrmProductManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView product_grid;
        private CCWin.SkinControl.SkinButton skinButton12;
        private CCWin.SkinControl.SkinButton skinButton4;
        private CCWin.SkinControl.SkinButton skinButton5;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinComboBox leibie_cmb;
        private CCWin.SkinControl.SkinComboBox jinyong_cmb;
        private CCWin.SkinControl.SkinComboBox maijia_cmb;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinComboBox report_cmb;
        private CCWin.SkinControl.SkinPanel skinPanel;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinTextBox query_txt;
    }
}