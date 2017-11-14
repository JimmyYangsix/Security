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
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("<script>alert('请登录！')</script> ");
            }
        }
        protected void Login_click(object sender, EventArgs e)
        {
            string user = Username.Text;
            string password = Password.Text;
            if (password == "'or 1='1" || password == "'or '1'='1")
            {
                Response.Write("<script>alert('简单SQL注入攻击登录使条件为true')</script> ");
            }
            else if(password == "'or 1=1--")
            {
                 Response.Write("<script>alert('注释SQL注入攻击登录')</script> ");
            }
            SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=test;Integrated Security=True");
            SqlCommand sqlcom = new SqlCommand("select * from [dbo].[Userinformation]  where Username='" + user + "' and Userpassword='" + password + "'", sqlcon);
            sqlcon.Open();
            if (Convert.ToInt32(sqlcom.ExecuteScalar()) > 0)
            {
                Response.Write("<script>alert('登录成功！')</script> ");
            }
            else
            {
                Response.Write("<script>alert('账号或密码错误！')</script> ");
            }
            sqlcon.Close();
        }
        protected void Join_click(object sender, EventArgs e)
        {
            Server.Transfer("sign up.aspx");
        }
    }
}