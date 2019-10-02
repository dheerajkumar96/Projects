using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ecommerce.Models
{
    public class Mainpagecontext : DbContext
    {
        public Mainpagecontext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Mainpage> Mainpages { get; set; }
        public DbSet<vegetables> vegetables { get; set; }
        public DbSet<mobiles> mobiles { get; set; }


    }




}
