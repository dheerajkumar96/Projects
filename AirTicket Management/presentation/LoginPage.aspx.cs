using business;
using ClassObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace presentation
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            logindetails ld = new logindetails();
            ld.username = customerid.Text;
            ld.password = password.Text;
            LoginBO LB = new LoginBO();
            bool b = LB.LoginValidate(ld);
            if (b)
            {
                Session["User"] = customerid.Text;
                Response.Redirect("flightsearch.aspx");
            }
            else
            {
                Label1.Text = "Invalid Username/Password...";
            }
        }
    }
}