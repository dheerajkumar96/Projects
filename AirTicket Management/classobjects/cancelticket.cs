using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjects
{
    public class cancelticket
    {
        public string bookingid { get; set; }
        public DateTime bookingdate { get; set; }
        public DateTime journeydate { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public double totalfare { get; set; }
        public double cancellationcharge { get; set; }
        public double refundamount { get; set; }

    }
}
