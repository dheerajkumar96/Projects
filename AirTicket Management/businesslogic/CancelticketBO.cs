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
    public class CancelticketBO
    {
        public static bool validatebooking(string bookingid)
        {
            SqlParameter p = new SqlParameter("@bookingid", bookingid);
            bool b = DBOperations.bookingvalidate(p);
            return b;
        }

        public static List<cancelticket> bookingcancel(string bookingid)
        {
            SqlParameter P = null;
            P = new SqlParameter("@bookingid",bookingid);
            List<cancelticket> c = DBOperations.cancelbooking(P);
            return c;
        }

        public static string deletebooking(string bookingid)
        {
            List<SqlParameter> l = new List<SqlParameter>();
            SqlParameter p = null;
            p = new SqlParameter("@bookingid", bookingid);
            l.Add(p);
            p = new SqlParameter("@st", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            l.Add(p);
            string msg=DBOperations.bookingdelete(l);
            return msg;
        }
    }
}
