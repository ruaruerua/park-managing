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
    public partial class manUpdate : Form
    {
        DataClass.MyMeans MyDataClass = new WindowsFormsApp1.DataClass.MyMeans();
        private string loginame = DataClass.MyMeans.Login_Name;
        public manUpdate()
        {
            InitializeComponent();
            SqlDataReader temDR = MyDataClass.Getcom("select * from tb_user where userid='" + loginame + "'");
            temDR.Read();
            int age = temDR.GetInt32(2);
            string ages = Convert.ToString(age);
            textage.Text = ages;
            string morename = temDR.GetString(1);
            textname.Text = morename;
            string morencard = temDR.GetString(4);
            textidcard.Text = morencard;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textname.Text != "" && textage.Text != "" && textnewpass.Text != "" && textsurepass.Text != "" && textidcard.Text != "")
            {
                if (textnewpass.Text == textsurepass.Text)
                {
                    MyDataClass.getsqlcom("update tb_user set name='" + textname.Text + "',userage='" + textage.Text + "',password='" + textnewpass.Text + "',IDcard='" + textidcard.Text + "' where userid='" + loginame + "'");
                    MessageBox.Show("修改成功~", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                    MessageBox.Show("确定密码错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("请将用户信息添加完整。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void manUpdate_Load(object sender, EventArgs e)
        {
            SqlDataReader temDD = MyDataClass.Getcom("select * from tb_user where userid='" + loginame + "'");
            temDD.Read();
            int age = temDD.GetInt32(2);
            string ages = Convert.ToString(age);
            string morencard = temDD.GetString(4);
            textidcard.Text = morencard;
            string morename = temDD.GetString(1);
            textname.Text = morename;
            statusStrip2.Items[1].Text = DataClass.MyMeans.Login_Name;
            statusStrip2.Items[3].Text = morename;
            statusStrip1.Items[1].Text = ages;
            statusStrip1.Items[3].Text = morencard;
        }

    }
}
