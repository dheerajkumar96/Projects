using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalogic
{
   public  class DBConnection
    {
       public static string getConnection()
       {

           return ConfigurationManager.ConnectionStrings["Con"].ToString();
       
       
       }

    }
}
