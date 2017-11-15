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
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Update_click(object sender, EventArgs e)
        {
            string user = Username.Text;
            string oldpassword = OldPassword.Text;
            string newpassword = NewPassword.Text;
            string update = "update [dbo].[Userinformation] set Userpassword='" +newpassword + "'where Username='" + user + "' and Userpassword='" + oldpassword + "'";
            SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=test;Integrated Security=True");
            SqlCommand sqlcom = new SqlCommand(update, sqlcon);
            sqlcon.Open();
            if (checkrepeat(user,oldpassword))
            {
                if (sqlcom.ExecuteNonQuery() > 0)
                {
                    Response.Write("<script>alert('Successful！')</script> ");
                    Server.Transfer("index.aspx");
                }
                else
                {
                    Response.Write("<script>alert('fatal！')</script> ");
                }
            }
            else
            {
                Response.Write("<script>alert('原密码错误，请重试！')</script> ");
                Server.Transfer("update.aspx");
            }
            sqlcon.Close();
        }
        public bool checkrepeat(string user,string oldpassword)
        {
            string select = "select * from [dbo].[Userinformation]  where Username='" + user + "' and Userpassword='" + oldpassword + "'";
            SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=test;Integrated Security=True");
            SqlCommand sqlcom = new SqlCommand(select, sqlcon);
            sqlcon.Open();
            if (Convert.ToInt32(sqlcom.ExecuteScalar()) > 0)
            {
                sqlcon.Close();
                return true;
            }
            else
            {
                sqlcon.Close();
                return false;
            }
        }
    }
}