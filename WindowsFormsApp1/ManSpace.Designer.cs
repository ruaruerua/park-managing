namespace WindowsFormsApp1
{
    partial class ManSpace
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
            this.butAll = new System.Windows.Forms.Button();
            this.butChaXun = new System.Windows.Forms.Button();
            this.butTianJia = new System.Windows.Forms.Button();
            this.butXiuGai = new System.Windows.Forms.Button();
            this.butShanChu = new System.Windows.Forms.Button();
            this.butFanHui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textSpaceNo = new System.Windows.Forms.TextBox();
            this.textParkid = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butAll
            // 
            this.butAll.Location = new System.Drawing.Point(326, 59);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(123, 28);
            this.butAll.TabIndex = 0;
            this.butAll.Text = "查询停车位信息";
            this.butAll.UseVisualStyleBackColor = true;
            this.butAll.Click += new System.EventHandler(this.butAll_Click);
            // 
            // butChaXun
            // 
            this.butChaXun.Location = new System.Drawing.Point(101, 362);
            this.butChaXun.Name = "butChaXun";
            this.butChaXun.Size = new System.Drawing.Size(75, 33);
            this.butChaXun.TabIndex = 1;
            this.butChaXun.Text = "查询";
            this.butChaXun.UseVisualStyleBackColor = true;
            this.butChaXun.Click += new System.EventHandler(this.butChaXun_Click);
            // 
            // butTianJia
            // 
            this.butTianJia.Location = new System.Drawing.Point(206, 363);
            this.butTianJia.Name = "butTianJia";
            this.butTianJia.Size = new System.Drawing.Size(75, 32);
            this.butTianJia.TabIndex = 2;
            this.butTianJia.Text = "添加";
            this.butTianJia.UseVisualStyleBackColor = true;
            this.butTianJia.Click += new System.EventHandler(this.butTianJia_Click);
            // 
            // butXiuGai
            // 
            this.butXiuGai.Location = new System.Drawing.Point(326, 362);
            this.butXiuGai.Name = "butXiuGai";
            this.butXiuGai.Size = new System.Drawing.Size(75, 32);
            this.butXiuGai.TabIndex = 3;
            this.butXiuGai.Text = "修改";
            this.butXiuGai.UseVisualStyleBackColor = true;
            this.butXiuGai.Click += new System.EventHandler(this.butXiuGai_Click);
            // 
            // butShanChu
            // 
            this.butShanChu.Location = new System.Drawing.Point(437, 363);
            this.butShanChu.Name = "butShanChu";
            this.butShanChu.Size = new System.Drawing.Size(75, 32);
            this.butShanChu.TabIndex = 4;
            this.butShanChu.Text = "删除";
            this.butShanChu.UseVisualStyleBackColor = true;
            this.butShanChu.Click += new System.EventHandler(this.butShanChu_Click);
            // 
            // butFanHui
            // 
            this.butFanHui.Location = new System.Drawing.Point(574, 363);
            this.butFanHui.Name = "butFanHui";
            this.butFanHui.Size = new System.Drawing.Size(75, 32);
            this.butFanHui.TabIndex = 5;
            this.butFanHui.Text = "返回";
            this.butFanHui.UseVisualStyleBackColor = true;
            this.butFanHui.Click += new System.EventHandler(this.butFanHui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "查询类型：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "停车位号",
            "停车场号",
            "车位状态"});
            this.comboBox1.Location = new System.Drawing.Point(528, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 7;
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
            this.dataGridView1.Location = new System.Drawing.Point(327, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(525, 239);
            this.dataGridView1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "停车位号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "停车场号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "车位状态：";
            // 
            // textSpaceNo
            // 
            this.textSpaceNo.Location = new System.Drawing.Point(181, 108);
            this.textSpaceNo.Name = "textSpaceNo";
            this.textSpaceNo.Size = new System.Drawing.Size(100, 25);
            this.textSpaceNo.TabIndex = 12;
            // 
            // textParkid
            // 
            this.textParkid.Location = new System.Drawing.Point(181, 175);
            this.textParkid.Name = "textParkid";
            this.textParkid.Size = new System.Drawing.Size(100, 25);
            this.textParkid.TabIndex = 13;
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(181, 244);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(100, 25);
            this.textState.TabIndex = 14;
            // 
            // ManSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 439);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textParkid);
            this.Controls.Add(this.textSpaceNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butFanHui);
            this.Controls.Add(this.butShanChu);
            this.Controls.Add(this.butXiuGai);
            this.Controls.Add(this.butTianJia);
            this.Controls.Add(this.butChaXun);
            this.Controls.Add(this.butAll);
            this.Name = "ManSpace";
            this.Text = "ManSpace";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAll;
        private System.Windows.Forms.Button butChaXun;
        private System.Windows.Forms.Button butTianJia;
        private System.Windows.Forms.Button butXiuGai;
        private System.Windows.Forms.Button butShanChu;
        private System.Windows.Forms.Button butFanHui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSpaceNo;
        private System.Windows.Forms.TextBox textParkid;
        private System.Windows.Forms.TextBox textState;
    }
}