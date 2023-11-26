using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication9
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manoj\\source\\repos\\WebApplication9\\WebApplication9\\App_Data\\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "insert into [dbo].[Register]values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            SqlCommand cmd=new SqlCommand(query, con);
            cmd.CommandText = query;
            int i=cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("Some details gone wrong please verify them again");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty; TextBox2.Text=string.Empty; TextBox3.Text = string.Empty; TextBox4.Text = string.Empty; 
        }
    }
}