using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c => c.email);
            modelBuilder.Entity<Table>().HasKey(t => t.number);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server =(localdb)\\mssqllocaldb;Database=CustomerDb;Trusted_Connection=True;");
        }
    }
}
