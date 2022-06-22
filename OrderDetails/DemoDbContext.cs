using OrderDetails.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDetails
{
    public class DemoDbContext : DbContext
    {
        public DbSet<Item> items { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DemoDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2PKBUH0\SQLEXPRESS;Initial Catalog=OrderDetails;Integrated Security=True");

        }
    }
}


