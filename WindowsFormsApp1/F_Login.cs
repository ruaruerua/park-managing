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
    public partial class F_Login : Form
    {
        DataClass.MyMeans MyClass = new WindowsFormsApp1.DataClass.MyMeans();
        public F_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textName.Text != "" & textPass.Text != "")
            {
                SqlDataReader temDR = MyClass.Getcom("select * from tb_user where userid='" + textName.Text.Trim() + "'and password= '" + textPass.Text.Trim() + "'");
                bool ifcom = temDR.Read();
                if (ifcom)
                {
                    DataClass.MyMeans.Login_Name = textName.Text.Trim();
                    DataClass.MyMeans.My_con.Close();
                    DataClass.MyMeans.My_con.Dispose();
                    SqlDataReader temDP = MyClass.Getcom("select userpower from tb_user where userid='" + textName.Text.Trim() + "'");
                    temDP.Read();
                    int power = temDP.GetInt32(0);
                    if (power==0)
                    {
                        SqlDataReader temDE = MyClass.Getcom("select * from tb_car where userid='" + textName.Text.Trim() + "'");
                        bool ifcomm = temDE.Read();
                        if (ifcomm)
                        {
                            SqlDataReader temDD = MyClass.Getcom("select CarID from tb_car where userid='" + textName.Text.Trim() + "'");
                            temDD.Read();
                            string morename = temDD.GetString(0);
                            DataClass.MyMeans.Login_car = morename;
                            DataClass.MyMeans.My_con.Close();
                            DataClass.MyMeans.My_con.Dispose();
                        }
                        parksystem rua = new parksystem();
                        rua.ShowDialog(this);
                        this.Close();
                    }
                    else
                    {
                        manager fm = new manager();
                        fm.ShowDialog(this);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textName.Text = "";
                    textPass.Text = "";
                }
                MyClass.con_close();
            }
            else
                MessageBox.Show("请将登录信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }
        private void textName_KeyPress(object sender,KeyPressEventArgs e)
        {

        }
        private void textPass_KeyPress(object sender,KeyPressEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_UserADD fm = new F_UserADD();
            fm.Show();
        }
    }
}
