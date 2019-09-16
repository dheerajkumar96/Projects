using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassObjects;
using DataLogic;
using System.Data;
using System.Data.SqlClient;

namespace BusinessObjects
{
    public class loginBO
    {
        //these methods are to get data from datalogic layer and transfer to presentation layer
        //this method is to send user data to datalogic
        public string insertuser(users u)
        {
            string spname = "sp_insertuser";
            List<SqlParameter> L = new List<SqlParameter>();
            SqlParameter k = null;
           
            k = new SqlParameter("@FirstName", u.Firstname);
            L.Add(k);
            k = new SqlParameter("@LastName", u.Lastname);
            L.Add(k);
            k = new SqlParameter("@UserName", u.Username);
            L.Add(k);
            k = new SqlParameter("@Password", u.Password);
            L.Add(k);
            k = new SqlParameter("@st", SqlDbType.NVarChar, 4000);
            k.Direction=ParameterDirection.Output;
            L.Add(k);

            string s = DBOperations.insertusers(spname, L);
            return s;
        }

        //ythis method to implement login functionality
        public string checklogin(string username,string password)
        {
            string spname = "sp_checklogin";
            List<SqlParameter> L = new List<SqlParameter>();
            SqlParameter k = null;
            k = new SqlParameter("@UserName", username);
            L.Add(k);
            k = new SqlParameter("@Password", password);
            L.Add(k);
            k = new SqlParameter("@st", SqlDbType.NVarChar, 4000);
            k.Direction = ParameterDirection.Output;
            L.Add(k);
            string s = DBOperations.checklogin(spname, L);
            return s;
        }
    }
}
