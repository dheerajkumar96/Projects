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
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            output.Visible = false;
        }
        
        //this method is to take user input details and store them in database and verify
        //whether username is unique or not. Sending object to business layer and retrieving a string
        //from business layer
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = null;
            users u = new users();
            if (firstname.Text == "" || lastname.Text =="" || username.Text == "" || password.Text == "")
            {
                s = "please enter your details";
            }
            
            else
            {
                u.Firstname = firstname.Text;
                u.Lastname = lastname.Text;
                u.Username = username.Text;
                u.Password = password.Text;

                loginBO lb = new loginBO();
                s = lb.insertuser(u);
            }
            output.Visible = true;
            output.Text = s;

            if(s== "Registered Successfully")
            {
                Response.Redirect("loginpage.aspx");
            }

        }
    }
}