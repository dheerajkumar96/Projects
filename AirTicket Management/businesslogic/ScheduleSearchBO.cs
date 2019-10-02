using ClassObjects;
using datalogic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    public class ScheduleSearchBO
    {
        public List<FlightSchedule> SearchFlight(string from,string to,DateTime doj)
        {
            List<SqlParameter> L = new List<SqlParameter>();
            SqlParameter P = null;
            P = new SqlParameter("@From", from);
            L.Add(P);
            P = new SqlParameter("@to", to);
            L.Add(P);
            P = new SqlParameter("@Doj", doj);
            L.Add(P);
            List<FlightSchedule>L1=DBOperations.FlightSearch("sp_SearchFlight", L);

            return L1;


        
        }

    }
}
