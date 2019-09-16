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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //displaying given data(productmaster) in grid after successful login
      
            name.Text = Session["user"].ToString();
            Userbl ub = new Userbl();
            GridView1.DataSource = ub.getdatagrid();
            GridView1.DataBind();

        }


        //this method is to get user selected phone and its corresponding sr no in table and store and pass the value
        //to Businesslogic and other page to display corresponding data
        protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int crow;
                crow = int.Parse(e.CommandArgument.ToString());
                int v = int.Parse(GridView1.Rows[crow].Cells[1].Text);
                Session["value"] = v;
                Response.Redirect("sr1.aspx");

            }


        }

        //displaying data in grid of user search operation based on name
        protected void Button1_Click(object sender, EventArgs e)
        {
            productdetails pd = new productdetails();
            pd.Productname = TextBox1.Text;

            Userbl ub = new Userbl();
            GridView1.DataSource = ub.getdetailsbyname(pd.Productname);
            GridView1.DataBind();
        }

        //these three methods are for filter search functionality and displaying data according to user selected 
        //filters
        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Userbl ub = new Userbl();
            productdetails p = new productdetails();

            p.Colour = DropDownList3.SelectedValue;
            
            if(DropDownList3.SelectedValue=="NULL")
            {
                p.Colour = null;
            }
            Session["colour"] = p.Colour;
            p.Ramsize =(string) Session["ramsize"];
            p.Productname = (string)Session["productname"];

            GridView1.DataSource = ub.getfilters(p.Productname, p.Ramsize, p.Colour);
            GridView1.DataBind();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Userbl ub = new Userbl();
            productdetails p = new productdetails();

            p.Ramsize = DropDownList1.SelectedValue;
            if(DropDownList1.SelectedValue=="NULL")
            {
                p.Ramsize = null;
            }
            Session["ramsize"] = p.Ramsize;
            p.Colour = (string)Session["colour"];
            p.Productname = (string)Session["productname"];

            GridView1.DataSource = ub.getfilters(p.Productname, p.Ramsize, p.Colour);
            GridView1.DataBind();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Userbl ub = new Userbl();
            productdetails p = new productdetails();

            p.Productname = DropDownList2.SelectedValue;
            if(DropDownList2.SelectedValue=="NULL")
            {
                p.Productname = null;
            }
            Session["productname"] = p.Productname;
            p.Colour = (string)Session["colour"];
            p.Ramsize = (string)Session["ramsize"];
            GridView1.DataSource = ub.getfilters(p.Productname, p.Ramsize, p.Colour);
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("loginpage.aspx");
        }
    }
}