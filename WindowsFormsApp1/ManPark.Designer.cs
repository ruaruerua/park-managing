namespace WindowsFormsApp1
{
    partial class ManPark
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNo = new System.Windows.Forms.TextBox();
            this.textNam = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textNum = new System.Windows.Forms.TextBox();
            this.butChaxun = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butChange = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(291, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(514, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // butAll
            // 
            this.butAll.Location = new System.Drawing.Point(343, 12);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(161, 37);
            this.butAll.TabIndex = 1;
            this.butAll.Text = "查询所有停车场信息";
            this.butAll.UseVisualStyleBackColor = true;
            this.butAll.Click += new System.EventHandler(this.butAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "停车场编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "停车场名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "停车场地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "停车位数量：";
            // 
            // textNo
            // 
            this.textNo.Location = new System.Drawing.Point(140, 56);
            this.textNo.Name = "textNo";
            this.textNo.Size = new System.Drawing.Size(100, 25);
            this.textNo.TabIndex = 6;
            // 
            // textNam
            // 
            this.textNam.Location = new System.Drawing.Point(140, 134);
            this.textNam.Name = "textNam";
            this.textNam.Size = new System.Drawing.Size(100, 25);
            this.textNam.TabIndex = 7;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(140, 190);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 25);
            this.textAddress.TabIndex = 8;
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(140, 239);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(100, 25);
            this.textNum.TabIndex = 9;
            // 
            // butChaxun
            // 
            this.butChaxun.Location = new System.Drawing.Point(69, 324);
            this.butChaxun.Name = "butChaxun";
            this.butChaxun.Size = new System.Drawing.Size(75, 33);
            this.butChaxun.TabIndex = 10;
            this.butChaxun.Text = "查询";
            this.butChaxun.UseVisualStyleBackColor = true;
            this.butChaxun.Click += new System.EventHandler(this.butChaxun_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(179, 323);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 33);
            this.butAdd.TabIndex = 11;
            this.butAdd.Text = "添加";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(429, 325);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 33);
            this.butDelete.TabIndex = 12;
            this.butDelete.Text = "删除";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(538, 323);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 33);
            this.butClose.TabIndex = 14;
            this.butClose.Text = "返回";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "停车场编号",
            "停车场名称",
            "停车场地址",
            "停车位数量"});
            this.comboBox1.Location = new System.Drawing.Point(598, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "查询条件：";
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(291, 323);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(86, 35);
            this.butChange.TabIndex = 17;
            this.butChange.Text = "修改";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // ManPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 403);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butChaxun);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textNam);
            this.Controls.Add(this.textNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManPark";
            this.Text = "停车场信息管理";
            this.Load += new System.EventHandler(this.ManPark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNo;
        private System.Windows.Forms.TextBox textNam;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Button butChaxun;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butChange;
    }
}