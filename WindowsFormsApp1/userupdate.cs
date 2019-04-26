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
    public partial class userupdate : Form
    {
        DataClass.MyMeans MyDataClass = new WindowsFormsApp1.DataClass.MyMeans();
        private string loginame = DataClass.MyMeans.Login_Name;
        public userupdate()
        {
            InitializeComponent();
            SqlDataReader temDR = MyDataClass.Getcom("select userage from tb_user where userid='" + loginame+"'");
            temDR.Read();
            int age = temDR.GetInt32(0);
            string ages = Convert.ToString(age);
            text_age.Text = ages;
            SqlDataReader temDD = MyDataClass.Getcom("select name from tb_user where userid='" + loginame + "'");
            temDD.Read();
            string morename = temDD.GetString(0);
            text_name.Text = morename;
            SqlDataReader temDA = MyDataClass.Getcom("select password from tb_user where userid='" + loginame + "'");
            temDA.Read();
            string morenpass = temDA.GetString(0);
            text_pass.Text = morenpass;
            SqlDataReader temDB = MyDataClass.Getcom("select IDcard from tb_user where userid='" + loginame + "'");
            temDB.Read();
            string morencard = temDB.GetString(0);
            text_card.Text = morencard;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((Convert.ToDouble(text_age.Text) <= 0)&&(text_card.Text!="114514"))
            {
                MessageBox.Show("请添加正确的信息。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (text_name.Text == "" && text_pass.Text == "" && text_card.Text == "" && text_age.Text == "")
            {
                MessageBox.Show("请将用户信息添加完整。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MyDataClass.getsqlcom("update tb_user set name='"+text_name.Text+"',userage='"+text_age.Text+"',password='"+text_pass.Text+"',IDcard='"+text_card.Text+"' where userid='"+loginame+"'");
                MessageBox.Show("修改成功~", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void userupdate_Load(object sender, EventArgs e)
        {

        }
    }
}
