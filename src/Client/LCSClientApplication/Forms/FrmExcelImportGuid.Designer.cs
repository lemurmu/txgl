namespace LCSClientApplication.Forms
{
    partial class FrmExcelImportGuid
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
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.actiontype_cmb = new System.Windows.Forms.ComboBox();
            this.skinGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.Black;
            this.skinLabel1.Location = new System.Drawing.Point(44, 19);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(164, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "请选择你要导入的数据类型，";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.Black;
            this.skinLabel2.Location = new System.Drawing.Point(44, 48);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(272, 17);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "相应的数据类型可以在设置里面进行详细的设置。";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.Blue;
            this.skinLabel3.Location = new System.Drawing.Point(44, 118);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(229, 17);
            this.skinLabel3.TabIndex = 2;
            this.skinLabel3.Text = "参考范例，请严格按照以下Excel表格导入";
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Controls.Add(this.actiontype_cmb);
            this.skinGroupBox1.Controls.Add(this.button1);
            this.skinGroupBox1.Controls.Add(this.skinLabel1);
            this.skinGroupBox1.Controls.Add(this.skinLabel2);
            this.skinGroupBox1.Controls.Add(this.skinLabel3);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Location = new System.Drawing.Point(7, 37);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(542, 220);
            this.skinGroupBox1.TabIndex = 5;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.Black;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(47, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "产品表格";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(280, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "上一步";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(379, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 21);
            this.button3.TabIndex = 7;
            this.button3.Text = "下一步";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(474, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 21);
            this.button4.TabIndex = 8;
            this.button4.Text = "退出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // actiontype_cmb
            // 
            this.actiontype_cmb.FormattingEnabled = true;
            this.actiontype_cmb.Items.AddRange(new object[] {
            "导入产品资料"});
            this.actiontype_cmb.Location = new System.Drawing.Point(47, 79);
            this.actiontype_cmb.Name = "actiontype_cmb";
            this.actiontype_cmb.Size = new System.Drawing.Size(226, 20);
            this.actiontype_cmb.TabIndex = 6;
            // 
            // FrmExcelImportGuid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 294);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.skinGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExcelImportGuid";
            this.Text = "Excel导入向导";
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox actiontype_cmb;
    }
}