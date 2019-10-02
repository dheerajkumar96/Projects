using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using ClassObjects;
using business;

namespace presentation
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customerdetails cs = new Customerdetails();

            cs.name = name.Text;
            cs.email = email.Text;
            cs.password = password.Text;
            cs.address = address.Text;
            cs.dob = DateTime.Parse(dob.Text);
            cs.phonenumber = phone.Text;
            cs.gender = gender.Text;
            cs.ssntype = ssntype.Text;
            cs.ssnnumber = ssnnumber.Text;

            
            CustomerBO cb = new CustomerBO();
            string msg=cb.insertcustomer(cs);
            if(!msg.Equals("Success"))
            {
                
                Label1.Text =  msg;
                HyperLink1.Text = "Login";
                //Response.Redirect("Webform1.aspx");
            
            }
            else
            {
                Label1.Text = "Please register again"; 
            }
            //custid.Text = c.ToString();
            Cache["customer"] = cs;
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("customer.aspx");
        }


    }
}