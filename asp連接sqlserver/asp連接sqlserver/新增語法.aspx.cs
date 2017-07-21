using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp連接sqlserver
{
    public partial class 新增語法 : System.Web.UI.Page
    { 
        private String strConn;
        private SqlConnection myConn;
        protected void Page_Load(object sender, EventArgs e)
        {
             strConn = "Data Source=KELVINNG;Initial Catalog=個人資料;Persist Security Info=True;User ID=kelvinngshuhui;Password=CHELsea16/17";

            //建立連接
             myConn= new SqlConnection(strConn);
            
            //打開連接
            myConn.Open();
            

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd1 = new SqlCommand("Insert Into 姓名 (姓名) Values (@姓名)", myConn);
            cmd1.Parameters.Add("@姓名", SqlDbType.NVarChar, 10).Value = TextBox1.Text;
           cmd1.ExecuteNonQuery();
        }
    }
}