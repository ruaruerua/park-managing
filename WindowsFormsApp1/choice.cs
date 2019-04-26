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
    public partial class choice : Form
    {
        DataClass.MyMeans MyDataClass = new WindowsFormsApp1.DataClass.MyMeans();
        private parksystem jiemian;
        private string serid;
        public choice(parksystem form1)
        {
            InitializeComponent();
            jiemian = form1;
        }

        private void choice_Load(object sender, EventArgs e)
        {
            DataSet da = MyDataClass.getDataSet("select * from service", "service");
            comboBox1.DisplayMember = "sertype";
            comboBox1.ValueMember = "sertype";
            comboBox1.DataSource = da.Tables["service"];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > 0 && comboBox1.SelectedIndex >= 0)
            {
                SqlDataReader temDA = MyDataClass.Getcom("select serviceid from service where sertype='" + comboBox1.Text + "'");
                temDA.Read();
                DataClass.MyMeans.Login_ser = temDA.GetString(0);
                DataClass.MyMeans.Login_park = jiemian.choosepark;
                MyDataClass.getsqlcom("insert into tb_order(userid, spaceno, serviceid) values('" + DataClass.MyMeans.Login_Name + "', '" + jiemian.choosepark + "','"+serid+"')");
                MyDataClass.getsqlcom("insert into tb_bill (userid,serviceid,money) values('" + DataClass.MyMeans.Login_Name + "','" + DataClass.MyMeans.Login_ser + "','" + DataClass.MyMeans.Login_cost + "')");
                MyDataClass.getsqlcom("update tb_parkingspace set parkstate='" + "已预约" + "' where spaceno='" +jiemian.choosepark+ "'");
                jiemian.B_park.Text = "停车登记";
                jiemian.UPdate();
                MessageBox.Show("预约完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择服务时间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader temDA = MyDataClass.Getcom("select washcost from service where sertype='"+comboBox1.Text+"'");
            temDA.Read();
            int fucost = temDA.GetInt32(0);
            fuwu.Text = Convert.ToString(fucost);
            update();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader temDD = MyDataClass.Getcom("select timecost from service where sertype='" + comboBox1.Text + "'");
            temDD.Read();
            string moren = comboBox2.Text;
            int shijian =Convert.ToInt32(moren);
            int tingcost = temDD.GetInt32(0) *shijian;
            tingche.Text = Convert.ToString(tingcost);
            update();
        }
        private void update()
        {
            if(comboBox2.SelectedIndex>0&&comboBox1.SelectedIndex>=0)
            {
                int fucost = Convert.ToInt32(fuwu.Text);
                int tingcost = Convert.ToInt32(tingche.Text);
                int zongcost = fucost + tingcost;
                DataClass.MyMeans.Login_cost = zongcost;
                zong.Text =Convert.ToString(zongcost);
                SqlDataReader temDD = MyDataClass.Getcom("select serviceid from service where sertype='" + comboBox1.Text + "'");
                temDD.Read();
                serid = temDD.GetString(0);
            }
        }
    }
}
