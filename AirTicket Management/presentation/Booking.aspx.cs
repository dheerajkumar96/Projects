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
    public partial class Booking : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                FlightSchedule F = (FlightSchedule)Cache["Flight"];
                txtFlightno.Text = F.FlightNo;
                txtAirlinesname.Text = F.AirlineName;
                txtLocationfrom.Text = F.Locationfrom;
                txtLocationto.Text = F.LocationTo;
                txtDeparturetime.Text = F.DepartureTime.ToString("HH:mm:ss");
                txtDoj.Text = F.DateofJourney.ToString();
                txtBookingdate.Text = DateTime.Now.ToString();
                customerid1.Text = Session["User"].ToString();
                bookingid1.Text = BookingBO.getbookid();
                txtname.Text = BookingBO.getcustomername(Session["User"].ToString());
                
            }
        }

        protected void ddlNoofpassengers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlightSchedule F = (FlightSchedule)Cache["Flight"];
            double cost = F.Cost;
            double price = Convert.ToInt32(ddlNoofpassengers.SelectedItem.Value)*cost;
            txtTotalprice.Text = price.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BookingDetails b = new BookingDetails();
            
            b.customer_id = customerid1.Text;
            b.booking_id = bookingid1.Text;
            b.name = txtname.Text;
            b.flight_no = txtFlightno.Text;
            b.AirLinesName = txtAirlinesname.Text;
            b.locationfrom = txtLocationfrom.Text;
            b.LocationTo = txtLocationto.Text;
            b.DepartureTime = DateTime.Parse(txtDeparturetime.Text);
            b.date_of_journey =DateTime.Parse(txtDoj.Text);
            b.booking_date = DateTime.Parse(txtBookingdate.Text);
            b.no_of_passenger = int.Parse(ddlNoofpassengers.Text);
            b.total_price = double.Parse(txtTotalprice.Text);

            if (BookingBO.insertbookingdetails(b) == "Success")
            {
                bookmessage.Text = "Your Ticket has been successfully booked!!";
            }
            else
            {
                bookmessage.Text = "Please book your details again";
            }

            
            
        }
    }
}