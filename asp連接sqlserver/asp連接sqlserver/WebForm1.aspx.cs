using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp連接sqlserver
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strConn = "Data Source=KELVINNG;Initial Catalog=個人資料;Persist Security Info=True;User ID=kelvinngshuhui;Password=CHELsea16/17";

            //建立連接
            SqlConnection myConn = new SqlConnection(strConn);


            //打開連接
            myConn.Open();


            String strSQL = @"select * from 姓名";


            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);


            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();



            //讀取結果
            while (myDataReader.Read())
            {
                if (myDataReader["序號"].ToString() != "")
                {
                    TextBox1.Text += myDataReader["序號"].ToString();
                    TextBox1.Text += " : ";
                    TextBox1.Text += myDataReader["姓名"].ToString();
                    TextBox1.Text += Environment.NewLine;                 //跳行
                }
            }
        }
    }
    }
