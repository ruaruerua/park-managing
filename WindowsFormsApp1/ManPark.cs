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
    public partial class ManPark : Form
    {
        DataClass.MyMeans MyClass = new WindowsFormsApp1.DataClass.MyMeans();
        public ManPark()
        {
            InitializeComponent();
        }

        private void ManPark_Load(object sender, EventArgs e)
        {
            
        }

        private void butAll_Click(object sender, EventArgs e)
        {
            DataSet xinxi = MyClass.getDataSet("select parkingid as'停车场号',paddress as'停车场地址',parkingname as'停车场名称',pspacenum as'停车位数量' from tb_park", "tb_park");
            dataGridView1.DataSource = xinxi.Tables["tb_park"];
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butChaxun_Click(object sender, EventArgs e)
        {
            if(textNo.Text!="" && comboBox1.Text=="停车场编号")
            {
                DataSet xinxi1 = MyClass.getDataSet("select parkingid as'停车场号',paddress as'停车场地址',parkingname as'停车场名称',pspacenum as'停车位数量' from tb_park where ParkingID='" + textNo.Text.Trim()+"'", "tb_park");
                dataGridView1.DataSource = xinxi1.Tables["tb_park"];
            }
            else if(textNam.Text != "" && comboBox1.Text=="停车场名称")
            {
                DataSet xinxi2 = MyClass.getDataSet("select parkingid as'停车场号',paddress as'停车场地址',parkingname as'停车场名称',pspacenum as'停车位数量' from tb_park where Parkingname='" + textNam.Text.Trim() + "'", "tb_park");
                dataGridView1.DataSource = xinxi2.Tables["tb_park"];
            }
            else if(textNum.Text != "" && comboBox1.Text=="停车位数量")
            {
                DataSet xinxi3 = MyClass.getDataSet("select parkingid as'停车场号',paddress as'停车场地址',parkingname as'停车场名称',pspacenum as'停车位数量' from tb_park where Pspacenum='" + textNum.Text.Trim() + "'", "tb_park");
                dataGridView1.DataSource = xinxi3.Tables["tb_park"];
            }
            else if(comboBox1.Text=="停车场地址" && textAddress.Text != "")
            {
                DataSet xinxi4 = MyClass.getDataSet("select parkingid as'停车场号',paddress as'停车场地址',parkingname as'停车场名称',pspacenum as'停车位数量' from tb_park where Paddress='" + textAddress.Text.Trim() + "'", "tb_park");
                dataGridView1.DataSource = xinxi4.Tables["tb_park"];
            }
            else
            {
                MessageBox.Show("请选择正确的查询条件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            SqlDataReader tcc = MyClass.Getcom("select*from tb_park where ParkingID='" + textNo.Text.Trim() + "'");
            if(tcc.Read())
            {
                MessageBox.Show("该停车场已经在库中，请输入其他停车场编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textNo.Text != "" && textAddress.Text != "" && textNam.Text != "" && textNum.Text != "")
                {
                    MyClass.getsqlcom("insert into tb_park values('" + textNo.Text.Trim() + "','" + textAddress.Text.Trim() + "','" + textNam.Text.Trim() + "','" + textNum.Text.Trim() + "')");
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    butAll.PerformClick();
                }
                else
                {
                    MessageBox.Show("请将信息输入完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            SqlDataReader tcc1 = MyClass.Getcom("select*from tb_park where ParkingID='" + textNo.Text.Trim() + "'");
            if (tcc1.Read()==false)
            {
                MessageBox.Show("库中没有该停车场，请修改已有的停车场", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textNo.Text != "" && textAddress.Text != "" && textNam.Text != "" && textNum.Text != "")
                {
                    MyClass.getsqlcom("update tb_park set paddress='" + textAddress.Text.Trim() + "',parkingname='" + textNam.Text.Trim() + "',pspacenum='" + textNum.Text.Trim() + "' where parkingID='" + textNo.Text.Trim() + "'");
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    butAll.PerformClick();
                }
                else
                {
                    MessageBox.Show("请将信息输入完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            SqlDataReader tcc2 = MyClass.Getcom("select*from tb_park where ParkingID='" + textNo.Text.Trim() + "'");
            if(tcc2.Read()==false)
            {
                MessageBox.Show("库中没有该停车场，无法执行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textNo.Text != "")
                {
                    MyClass.getsqlcom("delete from tb_park where ParkingID='" + textNo.Text.Trim() + "'");
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    butAll.PerformClick();
                }
                else
                {
                    MessageBox.Show("请输入您要删除的停车场号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
