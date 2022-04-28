using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ProductEntity.Models
{
    public class CustomerDbcontext : DbContext
    {
        public CustomerDbcontext()
        {

        }
        public CustomerDbcontext(DbContextOptions<CustomerDbcontext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-R2O6G8R; Database = trail; Integrated Security = True");
        }
        public virtual DbSet<Customer> Customers { get; set; }
        // public virtual DbSet<Product> Products { get; set; }
    }
}
