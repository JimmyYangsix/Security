using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SqlTest
{
    public partial class sign_up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Join_us(object sender, EventArgs e)
        {
            string user = Username.Text;
            string password = Password.Text;    
            string insert = "insert into [dbo].[Userinformation](Username,UserPassword) values('" + user + "','" + password + "')";
            SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=test;Integrated Security=True");
            SqlCommand sqlcom = new SqlCommand(insert, sqlcon);
            sqlcon.Open();
            if (checkrepeat(user))
            {
                if (sqlcom.ExecuteNonQuery() > 0)
                {
                    Response.Write("<script>alert('注册成功！')</script> ");
                    Server.Transfer("index.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('此用户已注册，请重试！')</script> ");
                Server.Transfer("sign up.aspx");
            }
            sqlcon.Close();
        }
        public bool checkrepeat(string user)
        {
            string select = "select * from [dbo].[Userinformation]  where Username='" + user + "'";
            SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=test;Integrated Security=True");
            SqlCommand sqlcom = new SqlCommand(select, sqlcon);
            sqlcon.Open();
            if (Convert.ToInt32(sqlcom.ExecuteScalar()) > 0)
            {
                sqlcon.Close();
                return false;
            }
            else{
                sqlcon.Close();
                return true;
            }
        }
    }
}