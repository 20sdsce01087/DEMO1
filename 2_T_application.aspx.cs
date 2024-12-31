using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace DEMO1
{
    public partial class _2_T_application : System.Web.UI.Page
    {
        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Nishant Patel\source\repos\DEMO1\App_Data\Database1.mdf"";Integrated Security=True";
        SqlConnection conn ;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmp;
        protected void Page_Load(object sender, EventArgs e)
        {
            getcon();

        }
        void getcon() {
            conn = new SqlConnection(s);
            conn.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            getcon();
            cmp = new SqlCommand("insert into stud_tbl(Username,Email,Addres) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", conn);
            cmp.ExecuteNonQuery();
            
        }
    }
}