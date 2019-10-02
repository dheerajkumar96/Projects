using ClassObjects;
using datalogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    public class BookingBO
    {
        public static string getbookid()
        {
            string bookingid=DBOperations.getbookid();
            string bid = "B" + bookingid.ToString();
            return bid;
        }

        public static string getcustomername(string username)
        {
            string customername=DBOperations.getcustomername(username);
            return customername;
        }

        public static string insertbookingdetails(BookingDetails b)
        {
            List<SqlParameter> v = new List<SqlParameter>();
            SqlParameter p = null;

            //int bookingid = DBOperations.getbookid();
            p = new SqlParameter("@bookingid", b.booking_id);
            v.Add(p);
            p = new SqlParameter("@customerid", b.customer_id);
            v.Add(p);
            p = new SqlParameter("@name", b.name);
            v.Add(p);
            p=new SqlParameter("@flightno",b.flight_no);
            v.Add(p);
            p=new SqlParameter("@airlinesname ",b.AirLinesName);
            v.Add(p);
		    p=new SqlParameter("@locationfrom",b.locationfrom);
            v.Add(p);
            p=new SqlParameter("@locationto",b.LocationTo);
            v.Add(p);
            p=new SqlParameter("@dateofjourney",b.date_of_journey);
            v.Add(p);
            p=new SqlParameter("@departuretime",b.DepartureTime);
            v.Add(p);
            p=new SqlParameter("@bookingdate",b.booking_date);
            v.Add(p);
            p=new SqlParameter("@noofpassengers",b.no_of_passenger);
            v.Add(p);
            p = new SqlParameter("@totalprice",b.total_price);
            v.Add(p);
            p = new SqlParameter("@st", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            v.Add(p);

           string msg=DBOperations.insertbookingdetails(v);

           return msg;
		
		 
		 
		 
		 
            //string msg = "B"+bookingid.ToString();
            //return msg;
        }
 
    }
}
