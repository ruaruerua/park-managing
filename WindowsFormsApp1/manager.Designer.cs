namespace WindowsFormsApp1
{
    partial class manager
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.GrideViewMan = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butparkUpdate = new System.Windows.Forms.Button();
            this.butServer = new System.Windows.Forms.Button();
            this.butUser = new System.Windows.Forms.Button();
            this.butSpace = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butSheZhi = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrideViewMan)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(874, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(298, 20);
            this.toolStripStatusLabel1.Text = "                           ||欢迎使用停车场管理系统||";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(99, 20);
            this.toolStripStatusLabel2.Text = "当前管理员：";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 20);
            // 
            // GrideViewMan
            // 
            this.GrideViewMan.AllowUserToAddRows = false;
            this.GrideViewMan.AllowUserToDeleteRows = false;
            this.GrideViewMan.AllowUserToResizeColumns = false;
            this.GrideViewMan.AllowUserToResizeRows = false;
            this.GrideViewMan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrideViewMan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrideViewMan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrideViewMan.Location = new System.Drawing.Point(231, 70);
            this.GrideViewMan.Name = "GrideViewMan";
            this.GrideViewMan.ReadOnly = true;
            this.GrideViewMan.RowTemplate.Height = 27;
            this.GrideViewMan.Size = new System.Drawing.Size(618, 238);
            this.GrideViewMan.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "停车场信息",
            "停车位信息",
            "用户基本信息",
            "服务类型",
            "账单信息",
            "订单信息",
            "汽车信息"});
            this.comboBox1.Location = new System.Drawing.Point(326, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "查询内容：";
            // 
            // butparkUpdate
            // 
            this.butparkUpdate.Location = new System.Drawing.Point(58, 135);
            this.butparkUpdate.Name = "butparkUpdate";
            this.butparkUpdate.Size = new System.Drawing.Size(147, 38);
            this.butparkUpdate.TabIndex = 4;
            this.butparkUpdate.Text = "停车场信息管理";
            this.butparkUpdate.UseVisualStyleBackColor = true;
            this.butparkUpdate.Click += new System.EventHandler(this.butparkUpdate_Click);
            // 
            // butServer
            // 
            this.butServer.Location = new System.Drawing.Point(58, 195);
            this.butServer.Name = "butServer";
            this.butServer.Size = new System.Drawing.Size(147, 36);
            this.butServer.TabIndex = 5;
            this.butServer.Text = "服务类型信息管理";
            this.butServer.UseVisualStyleBackColor = true;
            this.butServer.Click += new System.EventHandler(this.butServer_Click);
            // 
            // butUser
            // 
            this.butUser.Location = new System.Drawing.Point(58, 70);
            this.butUser.Name = "butUser";
            this.butUser.Size = new System.Drawing.Size(147, 41);
            this.butUser.TabIndex = 6;
            this.butUser.Text = "用户基本信息管理";
            this.butUser.UseVisualStyleBackColor = true;
            this.butUser.Click += new System.EventHandler(this.butUser_Click);
            // 
            // butSpace
            // 
            this.butSpace.Location = new System.Drawing.Point(58, 247);
            this.butSpace.Name = "butSpace";
            this.butSpace.Size = new System.Drawing.Size(147, 37);
            this.butSpace.TabIndex = 7;
            this.butSpace.Text = "停车位信息管理";
            this.butSpace.UseVisualStyleBackColor = true;
            this.butSpace.Click += new System.EventHandler(this.butSpace_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(512, 338);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(243, 35);
            this.butClose.TabIndex = 8;
            this.butClose.Text = "退出";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butSheZhi
            // 
            this.butSheZhi.Location = new System.Drawing.Point(107, 338);
            this.butSheZhi.Name = "butSheZhi";
            this.butSheZhi.Size = new System.Drawing.Size(253, 35);
            this.butSheZhi.TabIndex = 9;
            this.butSheZhi.Text = "设置";
            this.butSheZhi.UseVisualStyleBackColor = true;
            this.butSheZhi.Click += new System.EventHandler(this.butSheZhi_Click);
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 424);
            this.Controls.Add(this.butSheZhi);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butSpace);
            this.Controls.Add(this.butUser);
            this.Controls.Add(this.butServer);
            this.Controls.Add(this.butparkUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GrideViewMan);
            this.Controls.Add(this.statusStrip1);
            this.Name = "manager";
            this.Text = "管理员";
            this.Load += new System.EventHandler(this.manager_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrideViewMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.DataGridView GrideViewMan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butparkUpdate;
        private System.Windows.Forms.Button butServer;
        private System.Windows.Forms.Button butUser;
        private System.Windows.Forms.Button butSpace;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butSheZhi;
    }
}