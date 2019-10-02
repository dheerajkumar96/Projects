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
    public partial class Cancelticket : System.Web.UI.Page
    {
        cancelticket ct = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ct = new cancelticket();
            ct.bookingid = txtbookid.Text;
            if (CancelticketBO.validatebooking(ct.bookingid))
            {
                List<cancelticket> ct1 = CancelticketBO.bookingcancel(ct.bookingid);
                DetailsView1.DataSource = ct1;
                DetailsView1.DataBind();
            }
            else
            {

                Label1.Text = "Please Enter Correct Booking Number";
            }

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //cancelticket ct1 = new cancelticket();
            string bid=DetailsView1.Rows[0].Cells[1].Text;
            string msg=CancelticketBO.deletebooking(bid);
            if (msg == "Success")
            {
                Label2.Text = "Ticket Cancelled Successfully!!!";
            }
            
        }

       
    }
}