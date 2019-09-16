using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects
{
    public class productdetails
    {
        int srno;
        string productname;
        string ramsize;
        int amount;
        string flipkart_assured;
        string colour;
        string SIM_type;

        public int Srno { get => srno; set => srno = value; }
        public string Productname { get => productname; set => productname = value; }
        public string Ramsize { get => ramsize; set => ramsize = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Flipkart_assured { get => flipkart_assured; set => flipkart_assured = value; }
        public string Colour { get => colour; set => colour = value; }
        public string Sim_type{ get => SIM_type; set => SIM_type = value; }
    }
}
