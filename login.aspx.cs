using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = Pass.Text.Trim().ToString();
            string password = uname.Text.Trim().ToString();

            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Nishant Patel\\source\\repos\\DEMO1\\App_Data\\Database2.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            String query = "select * from Users where UserEmail = '" + username + "' and Password = '" + password + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["UserEmail"] = username;
                Response.Redirect("Home.aspx");
                Response.Write("<script>alert('Login Successful')</script>");
            }
            else
            {
                Response.Write("<script>alert('Invalid Username or Password')</script>");
            }
        }
    }
}