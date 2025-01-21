using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1 = int.Parse(TextBox1.Text);
            num2 = int.Parse(TextBox2.Text); 
            sum= num1 + num2;

            Label3.Visible = true;
            Label3.Text = "total is "+sum;
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);
            sum = num1 + num2;
            //TextBox3.Visible = true;
            TextBox3.Text = sum;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);
            sum = num1 + num2;
            //TextBox3.Visible = true;
            TextBox3.Text = sum;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {




            int num1, num2, sum;
            num1 = Convert.ToInt32(TextBox1.Text);
            num2 = Convert.ToInt32(TextBox2.Text);
            sum = num1 + num2;
            //TextBox3.Visible = true;
            TextBox3.Text = sum;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}