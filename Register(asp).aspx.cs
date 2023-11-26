using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length >= 8 && TextBox2.Text.Length <= 16)
            {
                if (TextBox2.Text == TextBox3.Text)
                {
                    if (TextBox4.Text != null)
                    {
                        if (TextBox5.Text.Length == 10)
                        {
                            Response.Redirect("Login.aspx");
                        }
                        else
                        {
                            Response.Write("Enter valid mobile number");
                        }
                    }
                    else
                    {
                        Response.Write("Enter valid EmailId");
                    }
                }
                else
                {
                    Response.Write("Password & Confirm Password should be same");
                }
            }
            else
            {
                Response.Write("Enter valid number");
            }

        }
    }
}