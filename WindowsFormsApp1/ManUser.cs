using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ManUser : Form
    {
        DataClass.MyMeans MyClass = new WindowsFormsApp1.DataClass.MyMeans();
        public ManUser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void butFanHui_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAll_Click(object sender, EventArgs e)
        {
            DataSet xinxi = MyClass.getDataSet("select userid as'用户账号',name as'用户姓名',userage as'用户年龄',password as'登录密码',idcard as'身份证号' from tb_user where userpower=0", "tb_user");
            dataGridView1.DataSource = xinxi.Tables["tb_user"];
        }

        private void butChaXun_Click(object sender, EventArgs e)
        {
            if (textNo.Text != "" && comboBox1.Text == "用户账号")
            {
                DataSet xinxi1 = MyClass.getDataSet("select userid as'用户账号',name as'用户姓名',userage as'用户年龄',password as'登录密码',idcard as'身份证号' from tb_user where userid='" + textNo.Text.Trim() + "'", "tb_user");
                dataGridView1.DataSource = xinxi1.Tables["tb_user"];
            }
            else if (textName.Text != "" && comboBox1.Text == "用户姓名")
            {
                DataSet xinxi2 = MyClass.getDataSet("select userid as'用户账号',name as'用户姓名',userage as'用户年龄',password as'登录密码',idcard as'身份证号' from tb_user where name='" + textName.Text.Trim() + "'", "tb_user");
                dataGridView1.DataSource = xinxi2.Tables["tb_user"];
            }
            else if (textAge.Text != "" && comboBox1.Text == "用户年龄")
            {
                DataSet xinxi3 = MyClass.getDataSet("select userid as'用户账号',name as'用户姓名',userage as'用户年龄',password as'登录密码',idcard as'身份证号' from tb_user where userage='" + textAge.Text.Trim() + "'", "tb_user");
                dataGridView1.DataSource = xinxi3.Tables["tb_user"];
            }
            else if (comboBox1.Text == "登录密码" && textPass.Text != "")
            {
                DataSet xinxi4 = MyClass.getDataSet("select userid as'用户账号',name as'用户姓名',userage as'用户年龄',password as'登录密码',idcard as'身份证号' from tb_user where password='" + textPass.Text.Trim() + "'", "tb_user");
                dataGridView1.DataSource = xinxi4.Tables["tb_user"];
            }
            else if (textID.Text != "" && comboBox1.Text == "身份证号")
            {
                DataSet xinxi5 = MyClass.getDataSet("select userid as'用户账号',name as'用户姓名',userage as'用户年龄',password as'登录密码',idcard as'身份证号' from tb_user where idcord='" + textID.Text.Trim() + "'", "tb_user");
                dataGridView1.DataSource = xinxi5.Tables["tb_user"];
            }
            else
            {
                MessageBox.Show("请选择正确的查询条件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butTianJia_Click(object sender, EventArgs e)
        {
            SqlDataReader tcc = MyClass.Getcom("select*from tb_user where userid='" + textNo.Text.Trim() + "'");
            if (tcc.Read())
            {
                MessageBox.Show("该用户已经在库中，请输入其他用户账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textNo.Text != "" && textName.Text != "" && textAge.Text != "" && textPass.Text != ""&& textID.Text !="")
                {
                    MyClass.getsqlcom("insert into tb_user values('" + textNo.Text.Trim() + "','" + textName.Text.Trim() + "','" + textAge.Text.Trim() + "','" + textPass.Text.Trim() + "','"+textID.Text.Trim()+"',0)");
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    butAll.PerformClick();
                }
                else
                {
                    MessageBox.Show("请将信息输入完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butXiuGai_Click(object sender, EventArgs e)
        {
            SqlDataReader tcc1 = MyClass.Getcom("select*from tb_user where userid='" + textNo.Text.Trim() + "'");
            if (tcc1.Read() == false)
            {
                MessageBox.Show("库中没有该用户，请修改已有的用户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textNo.Text != "" && textName.Text != "" && textAge.Text != "" && textPass.Text != "" && textID.Text != "")
                {
                    MyClass.getsqlcom("update tb_user set name='" + textName.Text.Trim() + "',userage='" + textAge.Text.Trim() + "',password='" + textPass.Text.Trim() + "',idcard='"+ textID.Text.Trim()+"' where userid='" + textNo.Text.Trim() + "'");
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    butAll.PerformClick();
                }
                else
                {
                    MessageBox.Show("请将信息输入完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butShanChu_Click(object sender, EventArgs e)
        {
            SqlDataReader tcc2 = MyClass.Getcom("select*from tb_user where userID='" + textNo.Text.Trim() + "'");
            if (tcc2.Read() == false)
            {
                MessageBox.Show("库中没有该用户，无法执行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textNo.Text != "")
                {
                    MyClass.getsqlcom("delete from tb_user where userID='" + textNo.Text.Trim() + "'");
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    butAll.PerformClick();
                }
                else
                {
                    MessageBox.Show("请输入您要删除的用户账号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
