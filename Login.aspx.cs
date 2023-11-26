using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication9
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manoj\\source\\repos\\WebApplication9\\WebApplication9\\App_Data\\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from[dbo].[Register] where uname='" + TextBox1.Text + "' and pwd='" + TextBox2.Text + "'";
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader=cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("Invalid Credentials");
                TextBox1.Text = string.Empty; TextBox2.Text = string.Empty;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty; TextBox2.Text = string.Empty;
        }
    }
}