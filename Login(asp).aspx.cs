﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="Admin" && TextBox2.Text == "Admin")
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("Enter correct details");
            }
        }
    }
}