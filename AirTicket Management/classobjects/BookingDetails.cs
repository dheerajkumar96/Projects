using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects
{
    public class BookingDetails
    {

        public string customer_id { set; get; }
        public string booking_id { set; get; }
        public string name { get; set; }
        public string flight_no { set; get; }
        public string AirLinesName { get; set; }
        public string locationfrom { get; set; }
        public string LocationTo { get; set; }
        public DateTime date_of_journey { set; get; }
        public DateTime DepartureTime { get; set; }
        public int no_of_passenger { set; get; }
        public DateTime booking_date { set; get; }
        public double total_price { set; get; }



    }
}
