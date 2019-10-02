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
    public class LoginBO
    {
        public bool LoginValidate(logindetails L)
        {
            List<SqlParameter> L1 = new List<SqlParameter>();
            SqlParameter P = null;
            P = new SqlParameter("@username", L.username);
            L1.Add(P);
            P = new SqlParameter("@password", L.password);
            L1.Add(P);
            bool B = DBOperations.loginValidate("sp_loginvalidate", L1);
            return B;
        }
    }
}
