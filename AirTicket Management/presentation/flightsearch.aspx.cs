using business;
using ClassObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace presentation
{
    public partial class flightsearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ScheduleSearchBO S = new ScheduleSearchBO();
            List<FlightSchedule> L = S.SearchFlight(DropDownList1.Text, DropDownList2.Text, DateTime.Parse(TextBox1.Text));
            GridView1.DataSource = L;
            GridView1.DataBind();
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            FlightSchedule F = new FlightSchedule();
            foreach (GridViewRow gvrow in GridView1.Rows)
            {
                //string s = null;
                var radiobutton = gvrow.FindControl("rdbFlightNo") as RadioButton;
                
                if (radiobutton.Checked)
                {
                   F.FlightNo = gvrow.Cells[1].Text;
                   F.AirlineName = gvrow.Cells[2].Text;
                   F.Locationfrom = gvrow.Cells[3].Text;
                   F.DateofJourney = DateTime.Parse(gvrow.Cells[4].Text);
                   F.LocationTo = gvrow.Cells[5].Text;
                   F.DepartureTime = DateTime.Parse(gvrow.Cells[6].Text);
                   F.Cost = double.Parse(gvrow.Cells[7].Text);
               
            Cache["Flight"] = F;

            Response.Redirect("Booking.aspx");
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}