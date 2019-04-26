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
    public partial class ManServer : Form
    {
        DataClass.MyMeans MyClass = new WindowsFormsApp1.DataClass.MyMeans();
        public ManServer()
        {
            InitializeComponent();
        }

        private void butSev_Click(object sender, EventArgs e)
        {
            DataSet sever = MyClass.getDataSet("select serviceid as'服务编号',sertype as'服务类型',washcost as'洗车单价',timecost as'停车时价' from service", "service");
            dataGridView1.DataSource = sever.Tables["service"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butChaXun_Click(object sender, EventArgs e)
        {
            if (textSno.Text != "" && comboBox1.Text == "服务编号")
            {
                DataSet xinxi1 = MyClass.getDataSet("select serviceid as'服务编号',sertype as'服务类型',washcost as'洗车单价',timecost as'停车时价' from service where serviceid='" + textSno.Text.Trim() + "'", "service");
                dataGridView1.DataSource = xinxi1.Tables["service"];
            }
            else if (textSnam.Text != "" && comboBox1.Text == "服务类型")
            {
                DataSet xinxi2 = MyClass.getDataSet("select serviceid as'服务编号',sertype as'服务类型',washcost as'洗车单价',timecost as'停车时价' from service where sertype='" + textSnam.Text.Trim() + "'", "service");
                dataGridView1.DataSource = xinxi2.Tables["service"];
            }
            else if (textWcost.Text != "" && comboBox1.Text == "洗车单价")
            {
                DataSet xinxi3 = MyClass.getDataSet("select serviceid as'服务编号',sertype as'服务类型',washcost as'洗车单价',timecost as'停车时价' from service where washcost='" + textWcost.Text.Trim() + "'", "service");
                dataGridView1.DataSource = xinxi3.Tables["service"];
            }
            else if (comboBox1.Text == "停车时价" && textPcost.Text != "")
            {
                DataSet xinxi4 = MyClass.getDataSet("select serviceid as'服务编号',sertype as'服务类型',washcost as'洗车单价',timecost as'停车时价' from service where timecost='" + textPcost.Text.Trim() + "'", "service");
                dataGridView1.DataSource = xinxi4.Tables["service"];
            }
            else
            {
                MessageBox.Show("请选择正确的查询条件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butTianJia_Click(object sender, EventArgs e)
        {
            SqlDataReader fuwu = MyClass.Getcom("select*from service where serviceid='" + textSno.Text.Trim() + "'");
            if(fuwu .Read())
            {
                MessageBox.Show("该服务编号已经在库中，请输入其他停车场编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textSno.Text != "" && textSnam.Text != "" && textWcost.Text != "" && textPcost.Text != "")
                {
                    MyClass.getsqlcom("insert into service values('" + textSno.Text.Trim() + "','" + textSnam.Text.Trim() + "','" + textWcost.Text.Trim() + "','" + textPcost.Text.Trim() + "')");
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    butSev.PerformClick();
                }
                else
                {
                    MessageBox.Show("请将信息输入完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butXiuGai_Click(object sender, EventArgs e)
        {
            SqlDataReader fuwu1 = MyClass.Getcom("select*from service where serviceid='" + textSno.Text.Trim() + "'");
            if (fuwu1.Read() == false)
            {
                MessageBox.Show("库中没有该服务类型，请修改已有的服务", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textSno.Text != "" && textSnam.Text != "" && textWcost.Text != "" && textPcost.Text != "")
                {
                    MyClass.getsqlcom("update service set sertype='" + textSnam.Text.Trim() + "',washcost='" + textWcost.Text.Trim() + "',timecost='" + textPcost.Text.Trim() + "' where serviceid='" + textSno.Text.Trim() + "'");
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    butSev.PerformClick();
                }
                else
                {
                    MessageBox.Show("请将信息输入完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butShanChu_Click(object sender, EventArgs e)
        {
            SqlDataReader fuwu2 = MyClass.Getcom("select*from service where serviceID='" + textSno.Text.Trim() + "'");
            if (fuwu2.Read() == false)
            {
                MessageBox.Show("库中没有该服务类型，无法执行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textSno.Text != "")
                {
                    MyClass.getsqlcom("delete from service where serviceid='" + textSno.Text.Trim() + "'");
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    butSev.PerformClick();
                }
                else
                {
                    MessageBox.Show("请输入您要删除的服务编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
