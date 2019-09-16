using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassObjects;
using BusinessObjects;

namespace productmanagement
{
    public partial class loginpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            output.Visible = false;
        }

        //this method is to verify login details by passing object to BL and getting string as output from the 
        //respective method.if login successful user redirected to products page
        protected void Button1_Click(object sender, EventArgs e)
        {
            users u = new users();
            u.Username = TextBox1.Text;
            u.Password = TextBox2.Text;

            loginBO lb = new loginBO();
            string o = lb.checklogin(u.Username, u.Password);

            output.Visible = true;
            output.Text = o;

            if(o == "login success")
            {
                Session["user"] = u.Username;
                Response.Redirect("WebForm1.aspx");
            }
        }
    }
}