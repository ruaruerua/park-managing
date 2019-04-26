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
    public partial class ManSpace : Form
    {
        DataClass.MyMeans MyClass = new WindowsFormsApp1.DataClass.MyMeans();
        public ManSpace()
        {
            InitializeComponent();
        }

        private void butAll_Click(object sender, EventArgs e)
        {
            DataSet xinxi = MyClass.getDataSet("select spaceno as'停车位号',parkingid as'停车场号',parkstate as'车位状态' from tb_parkingspace", "tb_parkingspace");
            dataGridView1.DataSource = xinxi.Tables["tb_parkingspace"];
        }

        private void butFanHui_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butChaXun_Click(object sender, EventArgs e)
        {
            if (textSpaceNo.Text != "" && comboBox1.Text == "停车位号")
            {
                DataSet xinxi1 = MyClass.getDataSet("select spaceno as'停车位号',parkingid as'停车场号',parkstate as'车位状态' from tb_parkingspace where spaceno='" + textSpaceNo.Text.Trim() + "'", "tb_parkingspace");
                dataGridView1.DataSource = xinxi1.Tables["tb_parkingspace"];
            }
            else if (textParkid.Text != "" && comboBox1.Text == "停车场号")
            {
                DataSet xinxi2 = MyClass.getDataSet("select spaceno as'停车位号',parkingid as'停车场号',parkstate as'车位状态' from tb_parkingspace where parkingid='" + textParkid.Text.Trim() + "'", "tb_parkingspace");
                dataGridView1.DataSource = xinxi2.Tables["tb_parkingspace"];
            }
            else if (textState.Text != "" && comboBox1.Text == "车位状态")
            {
                DataSet xinxi3 = MyClass.getDataSet("select spaceno as'停车位号',parkingid as'停车场号',parkstate as'车位状态' from tb_parkingspace where parkstate='" + textState.Text.Trim() + "'", "tb_parkingspace");
                dataGridView1.DataSource = xinxi3.Tables["tb_parkingspace"];
            }
            else
            {
                MessageBox.Show("请选择正确的查询条件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butTianJia_Click(object sender, EventArgs e)
        {
            SqlDataReader tcc = MyClass.Getcom("select*from tb_parkingspace where spaceno='" + textSpaceNo.Text.Trim() + "'");
            SqlDataReader jilian = MyClass.Getcom("select*from tb_park where parkingid='" + textParkid.Text.Trim() + "'");
            if (tcc.Read())
            {
                MessageBox.Show("该用户已经在库中，请输入其他用户账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textSpaceNo.Text != "" && textParkid.Text != "" && textState.Text != "")
                {
                    if(jilian.Read())
                    {
                        if (textState.Text == "空" || textState.Text == "已占用" || textState.Text == "已预约")
                        {
                            MyClass.getsqlcom("insert into tb_parkingspace values('" + textSpaceNo.Text.Trim() + "','" + textParkid.Text.Trim() + "','" + textState.Text.Trim() + "')");
                            MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            butAll.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("请在车位状态中输入‘空’、‘已占用’、‘已预约’中的一个！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入已经存在的停车场号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("请将信息输入完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butXiuGai_Click(object sender, EventArgs e)
        {
            SqlDataReader tcc1 = MyClass.Getcom("select*from tb_parkingspace where spaceno='" + textSpaceNo.Text.Trim() + "'");
            SqlDataReader jilian = MyClass.Getcom("select*from tb_park where parkingid='" + textParkid.Text.Trim() + "'");
            if (tcc1.Read() == false)
            {
                MessageBox.Show("库中没有该用户，请修改已有的用户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textSpaceNo.Text != "" && textParkid.Text != "" && textState.Text != "")
                {
                    if(jilian.Read())
                    {
                        MyClass.getsqlcom("update tb_parkingspace set parkingid='" + textParkid.Text.Trim() + "',parkstate='" + textState.Text.Trim() + "' where spaceno='" + textSpaceNo.Text.Trim() + "'");
                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        butAll.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("请输入库中已有的停车场号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("请将信息输入完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butShanChu_Click(object sender, EventArgs e)
        {
            SqlDataReader tcc1 = MyClass.Getcom("select*from tb_parkingspace where spaceno='" + textSpaceNo.Text.Trim() + "'");
            if (tcc1.Read() == false)
            {
                MessageBox.Show("库中没有该用户，无法执行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textSpaceNo.Text != "")
                {
                    MyClass.getsqlcom("delete from tb_parkingspace where spaceno='" + textSpaceNo.Text.Trim() + "'");
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
