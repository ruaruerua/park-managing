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
    public partial class parksystem : Form
    {
        DataClass.MyMeans MyDataClass = new WindowsFormsApp1.DataClass.MyMeans();
        public string loginame = DataClass.MyMeans.Login_Name;
        public string logincar = DataClass.MyMeans.Login_car;
        public string loginpark = DataClass.MyMeans.Login_park;
        public string choosepark="";
        public string yuyuepark = "";
        public parksystem()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userupdate fm = new userupdate();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carupdate fn = new carupdate(this);
            fn.Show();
        }
        public void UPdate()
        {
            logincar = DataClass.MyMeans.Login_car;
            loginpark = DataClass.MyMeans.Login_park;
            this.statusStrip1.Items[4].Text = logincar;
            this.statusStrip1.Items[6].Text = loginpark;
            int index = comboBox1.SelectedIndex;
            comboBox1.SelectedIndex = -1;
            comboBox1.SelectedIndex = index;
            switch(B_park.Text)
            {
                case "停车预约":
                    this.statusStrip1.Items[5].Text = "您当前的车位：";
                    break;
                case "停车登记":
                    this.statusStrip1.Items[5].Text = "您当前预约的车位：";
                    break;
                case "停车结算":
                    this.statusStrip1.Items[5].Text = "您当前停靠的车位：";
                    break;
                default:
                    break;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void parksystem_Load_1(object sender, EventArgs e)
        {
            this.Owner.Hide();
            if(DataClass.MyMeans.Login_car=="")
            {
                statusStrip1.Items[2].Text = loginame;
                statusStrip1.Items[4].Text = logincar;
                statusStrip1.Items[6].Text = loginpark;
                DataSet da = MyDataClass.getDataSet("select * from tb_park", "tb_park");
                comboBox1.DisplayMember = "Parkingname";
                comboBox1.ValueMember = "ParkingID";
                comboBox1.DataSource = da.Tables["tb_park"];
                comboBox1.SelectedIndex = -1;
                comboBox2.DataSource = null;
                dataGridView1.DataSource = null;
                return;
            }
            else
            {
                SqlDataReader temDD = MyDataClass.Getcom("select spaceno from tb_carandspace where CarID='" + logincar + "'");
                bool rua=temDD.Read();
                statusStrip1.Items[2].Text = loginame;
                statusStrip1.Items[4].Text = logincar;
                statusStrip1.Items[6].Text = loginpark;
                DataSet da = MyDataClass.getDataSet("select * from tb_park", "tb_park");
                comboBox1.DisplayMember = "Parkingname";
                comboBox1.ValueMember = "ParkingID";
                comboBox1.DataSource = da.Tables["tb_park"];
                comboBox1.SelectedIndex = -1;
                comboBox2.DataSource = null;
                dataGridView1.DataSource = null;
                if (rua)
                {
                    string parkrua = temDD.GetString(0);
                    DataClass.MyMeans.Login_park = parkrua;
                    statusStrip1.Items[6].Text = DataClass.MyMeans.Login_park;
                    B_park.Text = "停车结算";
                    this.statusStrip1.Items[5].Text = "您当前停靠的车位：";
                    SqlDataReader temDA = MyDataClass.Getcom("select top 1 * from tb_bill where userid='" + loginame + "' order by TabID desc");
                    temDA.Read();
                    int qian = temDA.GetInt32(3);
                    DataClass.MyMeans.Login_cost = qian;
                    return;
                }
                SqlDataReader temDB = MyDataClass.Getcom("select top 1 * from tb_order where userid='" + loginame + "'order by ordid desc");
                if(temDB.Read())
                {
                    string ssp=temDB.GetString(2);
                    SqlDataReader temDC = MyDataClass.Getcom("select parkstate from tb_parkingspace where spaceno='" + ssp + "'");
                    temDC.Read();
                    if(temDC.GetString(0)=="已预约")
                    {
                        DataClass.MyMeans.Login_park = ssp;
                        statusStrip1.Items[6].Text = DataClass.MyMeans.Login_park;
                        B_park.Text = "停车登记";
                        this.statusStrip1.Items[5].Text = "您当前预约的车位：";
                        SqlDataReader temDA = MyDataClass.Getcom("select top 1 * from tb_bill where userid='" + loginame + "' order by TabID desc");
                        temDA.Read();
                        int qian = temDA.GetInt32(3);
                        DataClass.MyMeans.Login_cost = qian;
                        return;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string park_name = this.comboBox1.Text;
                SqlDataReader temDD = MyDataClass.Getcom("select ParkingID from tb_park where Parkingname='" + park_name + "'");
                temDD.Read();
                string park_space = temDD.GetString(0);
                DataSet ds = MyDataClass.getDataSet("select spaceno from tb_parkingspace where ParkingID='" + park_space + "'", "tb_parkingspace");
                comboBox2.DataSource = ds.Tables["tb_parkingspace"];
                comboBox2.DisplayMember = "spaceno";
                comboBox2.ValueMember = "spaceno";
                DataSet da = MyDataClass.getDataSet("select spaceno as'车位号',Parkingname as'停车场名称',parkstate as'车位状态' from tb_parkingspace,tb_park where tb_park.ParkingID=tb_parkingspace.ParkingID and tb_parkingspace.ParkingID='" + park_space + "'", "tb_parkingspace");
                dataGridView1.DataSource = da.Tables["tb_parkingspace"];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex==0)
            {
                //int index = dataGridView1.CurrentRow.Index;
                //comboBox2.SelectedIndex = index;
                string intext = dataGridView1.CurrentCell.FormattedValue.ToString();
                comboBox2.Text = intext;
            }
        }

        private void B_park_Click(object sender, EventArgs e)
        {
            SqlDataReader temDR = MyDataClass.Getcom("select * from tb_carandspace where CarID='" + logincar + "'");
            bool ifcom = temDR.Read();
            SqlDataReader temDC = MyDataClass.Getcom("select * from tb_car where userid='" + loginame + "'");
            bool ififcom = temDC.Read();
            choosepark = comboBox2.Text;
            if (ififcom)
            {
                switch (B_park.Text)
                {
                    case "停车预约":
                        if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0)
                        {
                            MessageBox.Show("请选择停车位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        SqlDataReader temDD = MyDataClass.Getcom("select parkstate from tb_parkingspace where spaceno='" + choosepark + "'");
                        temDD.Read();
                        string YN = temDD.GetString(0);
                        if (YN == "已预约" || YN == "已占用")
                        {
                            MessageBox.Show("此车位无法预约", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            choice fm = new choice(this);
                            fm.Show();
                        }
                        break;
                    case "停车登记":
                        if (MessageBox.Show("是否进行停车登记", "停车登记", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            SqlDataReader temSE = MyDataClass.Getcom("select top 1 * from tb_order where userid='" + loginame + "'order by ordid desc");
                            temSE.Read();
                            yuyuepark = temSE.GetString(2);
                            MyDataClass.getsqlcom("insert into tb_carandspace (CarID,spaceno) values('" + logincar + "','" + yuyuepark + "')");
                            MyDataClass.getsqlcom("update tb_parkingspace set parkstate='" + "已占用" + "'where spaceno='" + yuyuepark + "'");
                            DataClass.MyMeans.Login_park = yuyuepark;
                            B_park.Text = "停车结算";
                            this.UPdate();
                            MessageBox.Show("停车登记成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        break;
                    case "停车结算":
                        if (MessageBox.Show("是否进行停车结算", "停车结算", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            MyDataClass.getsqlcom("Delete tb_carandspace where CarID='" + logincar + "'");
                            MyDataClass.getsqlcom("update tb_parkingspace set parkstate='" + "空" + "'where spaceno='" + DataClass.MyMeans.Login_park + "'");
                            DataClass.MyMeans.Login_park = null;
                            B_park.Text = "停车预约";
                            this.UPdate();
                            MessageBox.Show("结算成功\r\n消费金额为:"+DataClass.MyMeans.Login_cost, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("请登记您的车辆信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            billform frm = new billform();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string park_name = this.comboBox1.Text;
                SqlDataReader temDD = MyDataClass.Getcom("select ParkingID from tb_park where Parkingname='" + park_name + "'");
                temDD.Read();
                string park_space = temDD.GetString(0);
                DataSet ds = MyDataClass.getDataSet("select spaceno as'车位号', Parkingname as'停车场名称', parkstate as'车位状态' from tb_parkingspace, tb_park where tb_park.ParkingID = tb_parkingspace.ParkingID and tb_parkingspace.ParkingID = '" + park_space + "'and parkstate='" + "空"+"'", "tb_parkingspace");
                dataGridView1.DataSource = ds.Tables["tb_parkingspace"];
            }
            else
            {
                DataSet ds = MyDataClass.getDataSet("select spaceno as'车位号',Parkingname as'停车场名称',parkstate as'车位状态' from tb_parkingspace,tb_park where tb_park.ParkingID=tb_parkingspace.ParkingID and parkstate ='" + "空" + "'", "tb_parkingspace");
                dataGridView1.DataSource = ds.Tables["tb_parkingspace"];
            }
        }
    }
}