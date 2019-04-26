namespace WindowsFormsApp1
{
    partial class ManUser
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
            this.butAll = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butChaXun = new System.Windows.Forms.Button();
            this.butTianJia = new System.Windows.Forms.Button();
            this.butXiuGai = new System.Windows.Forms.Button();
            this.butShanChu = new System.Windows.Forms.Button();
            this.butFanHui = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textNo = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(293, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(462, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // butAll
            // 
            this.butAll.Location = new System.Drawing.Point(302, 44);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(122, 38);
            this.butAll.TabIndex = 1;
            this.butAll.Text = "查询用户表";
            this.butAll.UseVisualStyleBackColor = true;
            this.butAll.Click += new System.EventHandler(this.butAll_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "用户账号",
            "用户姓名",
            "用户年龄",
            "登录密码",
            "身份证号"});
            this.comboBox1.Location = new System.Drawing.Point(587, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "查询类型：";
            // 
            // butChaXun
            // 
            this.butChaXun.Location = new System.Drawing.Point(103, 362);
            this.butChaXun.Name = "butChaXun";
            this.butChaXun.Size = new System.Drawing.Size(75, 38);
            this.butChaXun.TabIndex = 4;
            this.butChaXun.Text = "查询";
            this.butChaXun.UseVisualStyleBackColor = true;
            this.butChaXun.Click += new System.EventHandler(this.butChaXun_Click);
            // 
            // butTianJia
            // 
            this.butTianJia.Location = new System.Drawing.Point(258, 362);
            this.butTianJia.Name = "butTianJia";
            this.butTianJia.Size = new System.Drawing.Size(75, 39);
            this.butTianJia.TabIndex = 5;
            this.butTianJia.Text = "添加";
            this.butTianJia.UseVisualStyleBackColor = true;
            this.butTianJia.Click += new System.EventHandler(this.butTianJia_Click);
            // 
            // butXiuGai
            // 
            this.butXiuGai.Location = new System.Drawing.Point(403, 361);
            this.butXiuGai.Name = "butXiuGai";
            this.butXiuGai.Size = new System.Drawing.Size(75, 39);
            this.butXiuGai.TabIndex = 6;
            this.butXiuGai.Text = "修改";
            this.butXiuGai.UseVisualStyleBackColor = true;
            this.butXiuGai.Click += new System.EventHandler(this.butXiuGai_Click);
            // 
            // butShanChu
            // 
            this.butShanChu.Location = new System.Drawing.Point(540, 361);
            this.butShanChu.Name = "butShanChu";
            this.butShanChu.Size = new System.Drawing.Size(75, 39);
            this.butShanChu.TabIndex = 7;
            this.butShanChu.Text = "删除";
            this.butShanChu.UseVisualStyleBackColor = true;
            this.butShanChu.Click += new System.EventHandler(this.butShanChu_Click);
            // 
            // butFanHui
            // 
            this.butFanHui.Location = new System.Drawing.Point(680, 360);
            this.butFanHui.Name = "butFanHui";
            this.butFanHui.Size = new System.Drawing.Size(75, 39);
            this.butFanHui.TabIndex = 8;
            this.butFanHui.Text = "返回";
            this.butFanHui.UseVisualStyleBackColor = true;
            this.butFanHui.Click += new System.EventHandler(this.butFanHui_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "用户账号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "用户姓名：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "用户年龄：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "登录密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "身份证号：";
            // 
            // textNo
            // 
            this.textNo.Location = new System.Drawing.Point(158, 46);
            this.textNo.Name = "textNo";
            this.textNo.Size = new System.Drawing.Size(100, 25);
            this.textNo.TabIndex = 14;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(158, 102);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 25);
            this.textName.TabIndex = 15;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(158, 164);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 25);
            this.textAge.TabIndex = 16;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(158, 224);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(100, 25);
            this.textPass.TabIndex = 17;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(158, 276);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 25);
            this.textID.TabIndex = 18;
            // 
            // ManUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butFanHui);
            this.Controls.Add(this.butShanChu);
            this.Controls.Add(this.butXiuGai);
            this.Controls.Add(this.butTianJia);
            this.Controls.Add(this.butChaXun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.butAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManUser";
            this.Text = "用户信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butAll;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butChaXun;
        private System.Windows.Forms.Button butTianJia;
        private System.Windows.Forms.Button butXiuGai;
        private System.Windows.Forms.Button butShanChu;
        private System.Windows.Forms.Button butFanHui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNo;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textID;
    }
}