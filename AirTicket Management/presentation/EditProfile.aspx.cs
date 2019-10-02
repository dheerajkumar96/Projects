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
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                if (!IsPostBack)
                {
                    CustomerBO C = new CustomerBO();
                    Customerdetails Cd = C.retriveCustomer(Session["User"].ToString());
                    TextBox1.Text = Cd.CustId;
                    name1.Text = Cd.name;
                    email1.Text = Cd.email;
                    dob1.Text = Cd.dob.ToString();
                    address1.Text = Cd.address;
                    phone1.Text = Cd.phonenumber;
                    gender1.Text = Cd.gender;
                    ssntype1.Text = Cd.ssntype;
                    ssnnumber1.Text = Cd.ssnnumber;
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string name = name1.Text;
            string email = email1.Text;
            string dob = dob1.Text;
            string gender = gender1.Text;
            string address = address1.Text;
            string phonenumber = phone1.Text;

            EditProflieBO.update(username, name, address, phonenumber,email,dob,gender);

            Label1.Text = "Profile updated successfully!!!";
        }
    }
}