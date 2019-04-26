using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1.DataClass
{
    class MyMeans
    {
        #region
        public static string Login_car = "";
        public static string Login_park = "";
        public static string Login_Name = "";
        public static int Login_cost=0;
        public static string Login_ser = "";
        public static string Mean_SQL = "", Mean_Table = "", Mean_Field = "";
        public static SqlConnection My_con;
        public static string M_str_sqlcon = "Data Source=DESKTOP-NSNSOPH;Initial Catalog=数据库课设;Integrated Security=True";
        public static int Login_n = 0;
        public static string AllSql = "Select * from tb_user";
        #endregion
        public static SqlConnection Getcon()
        {
            My_con = new SqlConnection(M_str_sqlcon);
            My_con.Open();
            return My_con;
        }
        public void con_close()
        {
            if (My_con.State == System.Data.ConnectionState.Open)
            {
                My_con.Close();
                My_con.Dispose();
            }
        }
        public SqlDataReader Getcom(string SQLstr)
        {
            Getcon();
            SqlCommand My_com = My_con.CreateCommand();
            My_com.CommandText = SQLstr;
            SqlDataReader My_read = My_com.ExecuteReader();
            return My_read;
        }
        public void getsqlcom(string SQLstr)
        {
            Getcon();
            SqlCommand SQLcom = new SqlCommand(SQLstr, My_con);
            SQLcom.ExecuteNonQuery();
            SQLcom.Dispose();
            con_close();
        }
        public DataSet getDataSet(string SQLstr,string tableName)
        {
            Getcon();
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLstr,My_con);
            DataSet My_DataSet = new DataSet();
            SQLda.Fill(My_DataSet, tableName);
            con_close();
            return My_DataSet;
        }
    }
}
