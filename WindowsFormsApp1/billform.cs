using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class billform : Form
    {
        DataClass.MyMeans MyDataClass = new WindowsFormsApp1.DataClass.MyMeans();
        public billform()
        {
            InitializeComponent();
        }

        private void billform_Load(object sender, EventArgs e)
        {
            DataSet da = MyDataClass.getDataSet("select TabID as'账单号',userid as'用户号',sertype as'服务类型',money as'总金额' from tb_bill,service where tb_bill.serviceid=service.serviceid and userid='" + DataClass.MyMeans.Login_Name + "'order by TabID desc", "tb_bill");
            dataGridView1.DataSource = da.Tables["tb_bill"];
        }
    }
}
