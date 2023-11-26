using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Home_cookies_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String str1 = Request.Cookies["MyCookie"].Value;
            Response.Write(str1);
        }
    }
}