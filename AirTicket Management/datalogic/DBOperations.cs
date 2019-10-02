using ClassObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalogic
{
    public class DBOperations
    {
        static SqlConnection Con = new SqlConnection(DBConnection.getConnection());
        static SqlCommand cmd = null;
        public static List<FlightSchedule> FlightSearch(string spname, List<SqlParameter> L)
        {
            Con.Open();
            cmd = new SqlCommand(spname, Con);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter P in L)
            {
                cmd.Parameters.Add(P);
            }
            SqlDataReader R = cmd.ExecuteReader();
            List<FlightSchedule> L1 = new List<FlightSchedule>();
            FlightSchedule F = null;
            while (R.Read())
            {
                F = new FlightSchedule();
                F.FlightNo = R[0].ToString();
                F.AirlineName = R[1].ToString();
                F.Locationfrom = R[2].ToString();
                F.DateofJourney = DateTime.Parse(R[3].ToString());
                F.LocationTo = R[4].ToString();
                F.DepartureTime = DateTime.Parse(R[5].ToString());
                F.Cost = double.Parse(R[6].ToString());
                F.ScheduleID = R[7].ToString();
                L1.Add(F);

            }
            Con.Close();
            return L1;




        }
        public static string insert(string sp_customerdetails2, List<SqlParameter> V)
        {
            try
            {
                Con.Open();
                cmd = new SqlCommand("sp_customerdetails2", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                // Customerdetails cd = new Customerdetails();
                foreach (SqlParameter p in V)
                {
                    cmd.Parameters.Add(p);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                throw E;
            }
            finally
            {

                Con.Close();
            }
            return V[V.Count - 1].Value.ToString();

        }
        public static int getCustID()
        {
            int cid;
            Con.Open();
            cmd = new SqlCommand("sp_CustId", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader R = cmd.ExecuteReader();
            R.Read();
            cid = int.Parse(R[0].ToString()) + 1;
            Con.Close();
            return cid;

        }

        public static bool loginValidate(string spname, List<SqlParameter> L)
        {
            bool flag = false;
            try
            {
                Con.Open();
                cmd = new SqlCommand(spname, Con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter P in L)
                {
                    cmd.Parameters.Add(P);
                }
                SqlDataReader R = cmd.ExecuteReader();
                if (R.Read())
                {
                    flag = true;

                }
            }
            catch (Exception E)
            {
                throw E;
            }
            finally
            {
                Con.Close();
            }
            return flag;

        }

        public static string getbookid()
        {
            int bid;
            Con.Open();
            cmd = new SqlCommand("sp_bookingid", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader R = cmd.ExecuteReader();
            R.Read();
            bid = int.Parse(R[0].ToString()) + 1;
            Con.Close();
            return bid.ToString();

        }

        public static Customerdetails retrievecustomer(string username)
        {
            Customerdetails c = null;
            try
            {
                Con.Open();
                cmd = new SqlCommand("sp_editcustomer", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    c = new Customerdetails();
                    c.CustId = R[0].ToString();
                    c.name = R[1].ToString();
                    c.email = R[2].ToString();
                    // c.password = R[4].ToString();
                    c.dob = DateTime.Parse(R[3].ToString());
                    c.address = R[4].ToString();
                    c.phonenumber = R[5].ToString();
                    c.gender = R[6].ToString();
                    c.ssntype = R[7].ToString();
                    c.ssnnumber = R[8].ToString();
                }
            }
            catch (Exception E)
            {
                throw E;
            }
            finally
            {


                Con.Close();
            }
            return c;
        }

        public static void updateprofile(string username, string name, string address, string phonenumber, string email, string dob, string gender)
        {

            Con.Open();
            cmd = new SqlCommand("sp_updateprofile", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@gender", gender);

            cmd.ExecuteNonQuery();
            Con.Close();
        }


        public static string getcustomername(string username)
        {
            Con.Open();
            cmd = new SqlCommand("sp_getcustomername", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader R = cmd.ExecuteReader();
            R.Read();
            string customername = R[0].ToString();
            Con.Close();
            return customername;
        }

        public static string insertbookingdetails(List<SqlParameter> v)
        {
            try
            {
                Con.Open();
                cmd = new SqlCommand("sp_bookinginsert", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter p in v)
                {
                    cmd.Parameters.Add(p);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                throw E;
            }
            finally
            {
                Con.Close();
            }
            return v[v.Count - 1].Value.ToString();
        }

        public static bool bookingvalidate(SqlParameter p)
        {
            bool flag = false;
            try
            {
                Con.Open();
                cmd = new SqlCommand("sp_bookingvalidate", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(p);

                SqlDataReader R = cmd.ExecuteReader();
                if (R.Read())
                {
                    flag = true;

                }
            }
            catch (Exception E)
            {
                throw E;
            }
            finally
            {
                Con.Close();
            }
            return flag;

        }

        public static List<cancelticket> cancelbooking(SqlParameter p)
        {
            Con.Open();
            cmd = new SqlCommand("sp_bookingdisplay", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(p);
            SqlDataReader R = cmd.ExecuteReader();
            List<cancelticket> L1 = new List<cancelticket>();
            cancelticket F = null;
            while (R.Read())
            {
                F = new cancelticket();
                F.bookingid = R[0].ToString();
                F.bookingdate = DateTime.Parse(R[1].ToString());
                F.journeydate = DateTime.Parse(R[2].ToString());
                F.from = R[3].ToString();
                F.to = R[4].ToString();
                F.totalfare = double.Parse(R[5].ToString());
                
                
            }
            Con.Close();
            TimeSpan t=new TimeSpan();
            t = F.journeydate.Subtract(DateTime.Now);
            int days=t.Days;
            if(days>10)
            {
            F.cancellationcharge=(F.totalfare)*(0.1);
            }
            else if(days>5 && days<=10)
            {
                F.cancellationcharge=(F.totalfare)*(0.2);
            }
            else if(days>1 && days<5)
            {
                F.cancellationcharge=(F.totalfare)*(0.5);
            }
            
            F.refundamount = F.totalfare - F.cancellationcharge;
            L1.Add(F);
            return L1;
        }

        public static string bookingdelete(List<SqlParameter> l)
        {
            Con.Open();
            cmd = new SqlCommand("sp_deletebookingdetails", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter p in l)
            {
                cmd.Parameters.Add(p);
            }
            cmd.ExecuteNonQuery();
            Con.Close();
            return l[l.Count - 1].Value.ToString();
        }
    }
}