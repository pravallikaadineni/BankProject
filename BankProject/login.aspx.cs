using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankProject
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "abc" && TextBox2.Text == "abc@123")
            {
                Response.Write("You have logged in successfully");

                 Response.Redirect("~/Welcome.aspx");
                Response.Redirect("");
            }
            else
            {
                Label3.Text = "Invalid userid/password... Pls check..";
            }
        }
    }
}