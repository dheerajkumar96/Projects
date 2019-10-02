using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects
{
    public class FlightSchedule
    {
        public string FlightNo { set; get; }
        public string AirlineName { set; get; }
        public DateTime DateofJourney { set; get; }
        public string Locationfrom { set; get; }
        public string LocationTo { set; get; }
        public DateTime  DepartureTime { set; get; }
        public double Cost { set; get; }
        public string ScheduleID { set; get; }



    }
}
