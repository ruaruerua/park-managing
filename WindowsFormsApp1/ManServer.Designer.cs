namespace WindowsFormsApp1
{
    partial class ManServer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butSev = new System.Windows.Forms.Button();
            this.butChaXun = new System.Windows.Forms.Button();
            this.butTianJia = new System.Windows.Forms.Button();
            this.butXiuGai = new System.Windows.Forms.Button();
            this.butShanChu = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textSno = new System.Windows.Forms.TextBox();
            this.textSnam = new System.Windows.Forms.TextBox();
            this.textWcost = new System.Windows.Forms.TextBox();
            this.textPcost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(626, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // butSev
            // 
            this.butSev.Location = new System.Drawing.Point(250, 46);
            this.butSev.Name = "butSev";
            this.butSev.Size = new System.Drawing.Size(153, 36);
            this.butSev.TabIndex = 1;
            this.butSev.Text = "查询服务类型信息";
            this.butSev.UseVisualStyleBackColor = true;
            this.butSev.Click += new System.EventHandler(this.butSev_Click);
            // 
            // butChaXun
            // 
            this.butChaXun.Location = new System.Drawing.Point(77, 349);
            this.butChaXun.Name = "butChaXun";
            this.butChaXun.Size = new System.Drawing.Size(75, 32);
            this.butChaXun.TabIndex = 2;
            this.butChaXun.Text = "查询";
            this.butChaXun.UseVisualStyleBackColor = true;
            this.butChaXun.Click += new System.EventHandler(this.butChaXun_Click);
            // 
            // butTianJia
            // 
            this.butTianJia.Location = new System.Drawing.Point(200, 348);
            this.butTianJia.Name = "butTianJia";
            this.butTianJia.Size = new System.Drawing.Size(75, 33);
            this.butTianJia.TabIndex = 3;
            this.butTianJia.Text = "添加";
            this.butTianJia.UseVisualStyleBackColor = true;
            this.butTianJia.Click += new System.EventHandler(this.butTianJia_Click);
            // 
            // butXiuGai
            // 
            this.butXiuGai.Location = new System.Drawing.Point(306, 348);
            this.butXiuGai.Name = "butXiuGai";
            this.butXiuGai.Size = new System.Drawing.Size(75, 33);
            this.butXiuGai.TabIndex = 4;
            this.butXiuGai.Text = "修改";
            this.butXiuGai.UseVisualStyleBackColor = true;
            this.butXiuGai.Click += new System.EventHandler(this.butXiuGai_Click);
            // 
            // butShanChu
            // 
            this.butShanChu.Location = new System.Drawing.Point(429, 348);
            this.butShanChu.Name = "butShanChu";
            this.butShanChu.Size = new System.Drawing.Size(75, 33);
            this.butShanChu.TabIndex = 5;
            this.butShanChu.Text = "删除";
            this.butShanChu.UseVisualStyleBackColor = true;
            this.butShanChu.Click += new System.EventHandler(this.butShanChu_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(571, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 6;
            this.button5.Text = "返回";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textSno
            // 
            this.textSno.Location = new System.Drawing.Point(122, 75);
            this.textSno.Name = "textSno";
            this.textSno.Size = new System.Drawing.Size(100, 25);
            this.textSno.TabIndex = 7;
            // 
            // textSnam
            // 
            this.textSnam.Location = new System.Drawing.Point(122, 138);
            this.textSnam.Name = "textSnam";
            this.textSnam.Size = new System.Drawing.Size(100, 25);
            this.textSnam.TabIndex = 8;
            // 
            // textWcost
            // 
            this.textWcost.Location = new System.Drawing.Point(122, 197);
            this.textWcost.Name = "textWcost";
            this.textWcost.Size = new System.Drawing.Size(100, 25);
            this.textWcost.TabIndex = 9;
            // 
            // textPcost
            // 
            this.textPcost.Location = new System.Drawing.Point(122, 249);
            this.textPcost.Name = "textPcost";
            this.textPcost.Size = new System.Drawing.Size(100, 25);
            this.textPcost.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "服务编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "服务类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "洗车价格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "停车时价：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "服务编号",
            "服务类型",
            "洗车单价",
            "停车时价"});
            this.comboBox1.Location = new System.Drawing.Point(545, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "查询条件：";
            // 
            // ManServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 402);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPcost);
            this.Controls.Add(this.textWcost);
            this.Controls.Add(this.textSnam);
            this.Controls.Add(this.textSno);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.butShanChu);
            this.Controls.Add(this.butXiuGai);
            this.Controls.Add(this.butTianJia);
            this.Controls.Add(this.butChaXun);
            this.Controls.Add(this.butSev);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManServer";
            this.Text = "服务类型信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butSev;
        private System.Windows.Forms.Button butChaXun;
        private System.Windows.Forms.Button butTianJia;
        private System.Windows.Forms.Button butXiuGai;
        private System.Windows.Forms.Button butShanChu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textSno;
        private System.Windows.Forms.TextBox textSnam;
        private System.Windows.Forms.TextBox textWcost;
        private System.Windows.Forms.TextBox textPcost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}