using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;

namespace DataLogic
{
    public class DBconnection
    {
        public static string getConnection()
        {
                string connStr = ConfigurationManager.ConnectionStrings["a"].ConnectionString;
                return connStr;
        }
    }
}
