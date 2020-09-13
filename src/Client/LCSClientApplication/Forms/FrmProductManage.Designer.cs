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
            this.skinButton12 = new CCWin.SkinControl.SkinButton();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.skinButton5 = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
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
            this.product_grid.Location = new System.Drawing.Point(1, 111);
            this.product_grid.Name = "product_grid";
            this.product_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.product_grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.product_grid.RowTemplate.Height = 50;
            this.product_grid.Size = new System.Drawing.Size(1155, 624);
            this.product_grid.TabIndex = 0;
            this.product_grid.TitleBack = null;
            this.product_grid.TitleBackColorBegin = System.Drawing.Color.White;
            this.product_grid.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // skinButton12
            // 
            this.skinButton12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinButton12.BackColor = System.Drawing.Color.Transparent;
            this.skinButton12.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton12.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton12.DownBack")));
            this.skinButton12.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton12.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton12.ForeColor = System.Drawing.Color.White;
            this.skinButton12.Location = new System.Drawing.Point(7, 30);
            this.skinButton12.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton12.MouseBack")));
            this.skinButton12.Name = "skinButton12";
            this.skinButton12.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton12.NormlBack")));
            this.skinButton12.Size = new System.Drawing.Size(57, 54);
            this.skinButton12.TabIndex = 37;
            this.skinButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.skinButton12.UseVisualStyleBackColor = false;
            this.skinButton12.Click += new System.EventHandler(this.skinButton12_Click);
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
            this.skinButton4.Location = new System.Drawing.Point(171, 30);
            this.skinButton4.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton4.MouseBack")));
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton4.NormlBack")));
            this.skinButton4.Size = new System.Drawing.Size(57, 54);
            this.skinButton4.TabIndex = 38;
            this.skinButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.skinButton4.UseVisualStyleBackColor = false;
            this.skinButton4.Click += new System.EventHandler(this.skinButton4_Click);
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
            this.skinButton5.Location = new System.Drawing.Point(87, 30);
            this.skinButton5.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton5.MouseBack")));
            this.skinButton5.Name = "skinButton5";
            this.skinButton5.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton5.NormlBack")));
            this.skinButton5.Size = new System.Drawing.Size(57, 54);
            this.skinButton5.TabIndex = 39;
            this.skinButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.skinButton5.UseVisualStyleBackColor = false;
            this.skinButton5.Click += new System.EventHandler(this.skinButton5_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(23, 88);
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
            this.skinLabel2.Location = new System.Drawing.Point(94, 88);
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
            this.skinLabel3.Location = new System.Drawing.Point(182, 88);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(37, 20);
            this.skinLabel3.TabIndex = 42;
            this.skinLabel3.Text = "删除";
            // 
            // FrmProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 740);
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
    }
}