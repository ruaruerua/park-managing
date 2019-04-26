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
    public partial class carupdate : Form
    {
        DataClass.MyMeans MyDataClass = new WindowsFormsApp1.DataClass.MyMeans();
        private string loginame = DataClass.MyMeans.Login_Name;
        private parksystem jiemian;
        public carupdate(parksystem form1)
        {
            InitializeComponent();
            jiemian = form1;
            SqlDataReader temDR = MyDataClass.Getcom("select * from tb_car where userid='" + loginame + "'");
            bool ifcom = temDR.Read();
            if(ifcom)
            {
                SqlDataReader temDD = MyDataClass.Getcom("select CarID from tb_car where userid='" + loginame + "'");
                temDD.Read();
                string morename = temDD.GetString(0);
                text_carid.Text = morename;
                SqlDataReader temDA = MyDataClass.Getcom("select Carname from tb_car where userid='" + loginame + "'");
                temDA.Read();
                string morenpass = temDA.GetString(0);
                text_carname.Text = morenpass;
                SqlDataReader temDB = MyDataClass.Getcom("select Carcolor from tb_car where userid='" + loginame + "'");
                temDB.Read();
                string morencard = temDB.GetString(0);
                text_color.Text = morencard;
            }
        }

        private void carupdate_Load(object sender, EventArgs e)
        {
            SqlDataReader temDR = MyDataClass.Getcom("select * from tb_car where userid='" + loginame + "'");
            bool ifcom = temDR.Read();
            if (ifcom)
            {
                this.text_carid.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader temDR = MyDataClass.Getcom("select * from tb_car where userid='" + loginame + "'");
            bool ifcom = temDR.Read();
            if (ifcom)
            {
                if (text_carid.Text == "" || text_carname.Text == "" || text_color.Text == "")
                {
                    MessageBox.Show("请将用户信息添加完整。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MyDataClass.getsqlcom("update tb_car set Carname='" + text_carname.Text + "',Carcolor='" + text_color.Text + "'");
                    MessageBox.Show("修改成功~","提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            else
            {
                if (text_carid.Text == "" || text_carname.Text == "" || text_color.Text == "")
                {
                    MessageBox.Show("请将用户信息添加完整。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MyDataClass.getsqlcom("insert into tb_car (CarID,userid,Carname,Carcolor) values('" + text_carid.Text + "','" + loginame + "','" + text_carname.Text + "','" + text_color.Text + "')");
                    DataClass.MyMeans.Login_car = text_carid.Text.Trim();
                    DataClass.MyMeans.My_con.Close();
                    DataClass.MyMeans.My_con.Dispose();
                    jiemian.UPdate();
                    MessageBox.Show("添加成功~","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
