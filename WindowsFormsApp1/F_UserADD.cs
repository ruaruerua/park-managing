using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class F_UserADD : Form
    {
        DataClass.MyMeans MyDataClass = new WindowsFormsApp1.DataClass.MyMeans();
        public F_UserADD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(text_Name.Text==""||text_Pass.Text==""||text_idc.Text==""||text_age.Text==""||text_nam.Text=="")
            {
                MessageBox.Show("请将用户信息添加完整。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(Convert.ToDouble(text_age.Text)<=0)
            {
                MessageBox.Show("请添加正确的信息。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlDataReader temDR = MyDataClass.Getcom("select userid from tb_user where userid='" + text_Name.Text + "'");
            bool ifcom = temDR.Read();
            if(ifcom)
            {
                MessageBox.Show("当前用户已存在，请重新输入。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text_Name.Text = "";
                text_Pass.Text = "";
                return;
            }
            else
            {
                int a = 0;
                MyDataClass.getsqlcom("insert into tb_user (userid,name,userage,password,IDcard,userpower) values('" + text_Name.Text + "','" + text_nam.Text + "','" + text_age.Text + "','" + text_Pass.Text + "','" + text_idc.Text + "','"+a+"')");
                MessageBox.Show("添加成功~", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void text_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_UserADD_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
