using datalogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    public class EditProflieBO
    {
        public static void update(string username, string name, string address, string phonenumber,string email,string dob,string gender)
        {
            DBOperations.updateprofile(username, name, address, phonenumber,email,dob,gender);
        }
    }
}
