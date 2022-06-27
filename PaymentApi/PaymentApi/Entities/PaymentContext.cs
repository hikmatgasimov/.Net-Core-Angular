using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Entities
{
    public class PaymentContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5FT6Q5M;Initial Catalog=PaymentDetail;Integrated Security=True");
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }


    }
}
