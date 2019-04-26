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
    public partial class manager : Form
    {
        DataClass.MyMeans MyClass = new WindowsFormsApp1.DataClass.MyMeans();
        public manager()
        {
            InitializeComponent();
        }

        private void manager_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
            statusStrip1.Items[2].Text = DataClass.MyMeans.Login_Name;
            //statusStrip1.Items[4].Text = DataClass.MyMeans.Login_ID;

            comboBox1.SelectedIndex = 2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "用户基本信息")
            {
                DataSet xinxi = MyClass.getDataSet("select userid as'用户账号',name as'姓名',userage as'年龄',IDcard as'身份证号',password as'密码' from tb_user where userpower=0", "tb_user");
                GrideViewMan.DataSource = xinxi.Tables["tb_user"];
            }
            else if (comboBox1.Text == "停车场信息")
            {
                DataSet xinxi2 = MyClass.getDataSet("select parkingid as'停车场号',paddress as'停车场地址',parkingname as'停车场名称',pspacenum as'停车位数量' from tb_park", "tb_park");
                GrideViewMan.DataSource = xinxi2.Tables["tb_park"];
            }
            else if (comboBox1.Text == "停车位信息")
            {
                DataSet xinxi3 = MyClass.getDataSet("select spaceno as'停车位号',parkingid as'停车场号',parkstate as'停车位状态' from tb_parkingspace", "tb_parkingspace");
                GrideViewMan.DataSource = xinxi3.Tables["tb_parkingspace"];
            }
            else if (comboBox1.Text == "服务类型")
            {
                DataSet xinxi3 = MyClass.getDataSet("select serviceid as'服务编号',sertype as'服务类型',washcost as'洗车单价',timecost as'停车时价' from service", "service");
                GrideViewMan.DataSource = xinxi3.Tables["service"];
            }
            else if (comboBox1.Text == "账单信息")
            {
                DataSet xinxi3 = MyClass.getDataSet("select tabid as'账单号',userid as'用户账号',serviceid as'服务编号',money as'金额' from tb_bill", "tb_bill");
                GrideViewMan.DataSource = xinxi3.Tables["tb_bill"];
            }
            else if (comboBox1.Text == "订单信息")
            {
                DataSet xinxi3 = MyClass.getDataSet("select ordid as'订单号',userid as'用户账号',spaceno as'停车位号',serviceID as'服务编号' from tb_order", "tb_order");
                GrideViewMan.DataSource = xinxi3.Tables["tb_order"];
            }
            else if (comboBox1.Text == "汽车信息")
            {
                DataSet xinxi3 = MyClass.getDataSet("select carid as'汽车编号',userid as'用户账号',carname as'汽车型号',carcolor as'汽车颜色' from tb_car", "tb_car");
                GrideViewMan.DataSource = xinxi3.Tables["tb_car"];
            }
        }

        private void butparkUpdate_Click(object sender, EventArgs e)
        {
            ManPark manp;
            manp = new ManPark();
            manp.ShowDialog();
        }

        private void butServer_Click(object sender, EventArgs e)
        {
            ManServer manS;
            manS = new ManServer();
            manS.ShowDialog();
        }

        private void butUser_Click(object sender, EventArgs e)
        {
            ManUser manU;
            manU = new ManUser();
            manU.ShowDialog();
        }

        private void butSpace_Click(object sender, EventArgs e)
        {
            ManSpace manSp;
            manSp = new ManSpace();
            manSp.ShowDialog();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSheZhi_Click(object sender, EventArgs e)
        {
            manUpdate up;
            up = new manUpdate();
            up.ShowDialog();
        }
    }
}
