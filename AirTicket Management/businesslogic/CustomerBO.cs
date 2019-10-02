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
    public class CustomerBO
    {
        public string insertcustomer(Customerdetails cs)
        {
            List<SqlParameter> V = new List<SqlParameter>();
            SqlParameter p = null;
            int CustId = DBOperations.getCustID();
            p = new SqlParameter("@custId", CustId);
            V.Add(p);
            p = new SqlParameter("@name", cs.name);
            V.Add(p);
            p = new SqlParameter("@email", cs.email);
            V.Add(p);
            p = new SqlParameter("@password", cs.password);
            V.Add(p);
            p = new SqlParameter("@dob", cs.dob);
            V.Add(p);
            p = new SqlParameter("@address", cs.address);
            V.Add(p);
            p = new SqlParameter("@phonenumber", cs.phonenumber);
            V.Add(p);
            p = new SqlParameter("@gender", cs.gender);
            V.Add(p);
            p = new SqlParameter("@ssntype", cs.ssntype);
            V.Add(p);
            p = new SqlParameter("@ssnnumber", cs.ssnnumber);
            V.Add(p);
            p = new SqlParameter("@st", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            V.Add(p);
           string msg= DBOperations.insert("sp_customerdetails2", V);
           if (msg.Equals("Success"))
           {
               return "Success Your CustomerId is " + CustId.ToString();
           }
           else
           {
               return msg;
           }


           // return cd;
        }

        public Customerdetails retriveCustomer(string username)
        {
            Customerdetails C=   DBOperations.retrievecustomer(username);
            return C;
        }


    }
}
