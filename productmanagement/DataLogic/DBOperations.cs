using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ClassObjects;


namespace DataLogic
{
    public class DBOperations
    {
        static SqlConnection con=new SqlConnection(DBconnection.getConnection());//to establiish connection 
        static SqlCommand cmd = null;

        public static List<productdetails> getdata(string spname) //method to get data from table using stored procedure
        {
            List<productdetails> L = new List<productdetails>();
            try
            {
                con.Open();
                cmd = new SqlCommand(spname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();
                productdetails p = null;
                while (sdr.Read())
                {
                    p = new productdetails();
                    p.Srno = int.Parse(sdr[0].ToString());
                    p.Productname = sdr[1].ToString();
                    p.Ramsize = sdr[2].ToString();
                    p.Amount = int.Parse(sdr[3].ToString());
                    p.Flipkart_assured = sdr[4].ToString();
                    p.Colour = sdr[5].ToString();
                    p.Sim_type = sdr[6].ToString();
                    L.Add(p);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
            return L;
        
        }
        //this method is to get data of selected products from table
        public static List<productdetails> getselected(string spname,SqlParameter q)
        {
            List<productdetails> L = new List<productdetails>();
            try
            {
                con.Open();
                cmd = new SqlCommand(spname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(q);
                SqlDataReader sdr = cmd.ExecuteReader();
                productdetails p = null;
                while (sdr.Read())
                {
                    p = new productdetails();
                    p.Srno = int.Parse(sdr[0].ToString());
                    p.Productname = sdr[1].ToString();
                    p.Ramsize = sdr[2].ToString();
                    p.Amount = int.Parse(sdr[3].ToString());
                    p.Flipkart_assured = sdr[4].ToString();
                    p.Colour = sdr[5].ToString();
                    p.Sim_type = sdr[6].ToString();
                    L.Add(p);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
            return L;

        }
        //this method is to get data to implement search by name
        public static List<productdetails> getdetailsbyname(string spname, SqlParameter q)
        {
            List<productdetails> L = new List<productdetails>();
            try
            {
                con.Open();
                cmd = new SqlCommand(spname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(q);
                SqlDataReader sdr = cmd.ExecuteReader();
                productdetails p = null;
                while (sdr.Read())
                {
                    p = new productdetails();
                    p.Srno = int.Parse(sdr[0].ToString());
                    p.Productname = sdr[1].ToString();
                    p.Ramsize = sdr[2].ToString();
                    p.Amount = int.Parse(sdr[3].ToString());
                    p.Flipkart_assured = sdr[4].ToString();
                    p.Colour = sdr[5].ToString();
                    p.Sim_type = sdr[6].ToString();
                    L.Add(p);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
            return L;

        }
        //this method is to get data from database to implement filters
        public static List<productdetails> getfilters(string spname,List<SqlParameter> T)
        {
            List<productdetails> L = new List<productdetails>();
            try
            {
                con.Open();
                cmd = new SqlCommand(spname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter j in T)
                {
                    cmd.Parameters.Add(j);
                }
                SqlDataReader sdr = cmd.ExecuteReader();
                productdetails p = null;
                while (sdr.Read())
                {
                    p = new productdetails();
                    p.Srno = int.Parse(sdr[0].ToString());
                    p.Productname = sdr[1].ToString();
                    p.Ramsize = sdr[2].ToString();
                    p.Amount = int.Parse(sdr[3].ToString());
                    p.Flipkart_assured = sdr[4].ToString();
                    p.Colour = sdr[5].ToString();
                    p.Sim_type = sdr[6].ToString();
                    L.Add(p);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
            return L;

        }
        //this method is to insert details of user during registration
        public static string insertusers(string spname,List<SqlParameter> L)
        {
            string s = null;
            try
            {
                
                con.Open();
                cmd = new SqlCommand(spname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(SqlParameter p in L)
                {
                    cmd.Parameters.Add(p);
                }
                cmd.ExecuteNonQuery();
                s = cmd.Parameters["@st"].Value.ToString();
                
            }
            catch(SqlException ex)
            {
                if(ex.Number==2627)
                {
                    s = "please enter different username";
                }
                
            }
            finally
            {
                con.Close();
            }
            return s;
        }
        //this method to check login details
        public static string checklogin(string spname,List<SqlParameter> L)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(spname, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(SqlParameter p in L)
                {
                    cmd.Parameters.Add(p);
                }
                cmd.ExecuteNonQuery();
                string s = cmd.Parameters["@st"].Value.ToString();
                return s;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
