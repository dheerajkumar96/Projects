using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassObjects;
using DataLogic;

namespace BusinessObjects
{
    public class Userbl
    {
        //these methods are to get data from datalogic layer and transfer to presentation layer
        public List<productdetails> getdatagrid()
        {
            string s = "sp_getdata";
            List<productdetails> p = new List<productdetails>();
            p = DBOperations.getdata(s);
            return p;
        }

        //this method to implement buy option
        public List<productdetails> buyselect(int sno)
        {
            string s = "sp_getselectedphone";
            List<productdetails> p = new List<productdetails>();
            SqlParameter f = new SqlParameter("@Sr_No", sno);
            p = DBOperations.getselected(s, f);
            return p;
        }

        //implement search functionality
        public List<productdetails> getdetailsbyname(string name)
        {
            string s = "sp_detailsbyname";
            List<productdetails> p = new List<productdetails>();
            SqlParameter f = new SqlParameter("@Product_Name", name);
            p = DBOperations.getdetailsbyname(s, f);
            return p;
        }

        //implement filter functionality
        public List<productdetails> getfilters(string name,string ram,string colour)
        {
            string s = "sp_filter";
            List<productdetails> p = new List<productdetails>();
            List<SqlParameter> L = new List<SqlParameter>();
            SqlParameter k = null;
            k = new SqlParameter("@Product_Name", name);
            L.Add(k);
            k = new SqlParameter("@RAM_Size", ram);
            L.Add(k);
            k = new SqlParameter("@Colour", colour);
            L.Add(k);
            p = DBOperations.getfilters(s, L);
            return p;
        }

        
    }
}
