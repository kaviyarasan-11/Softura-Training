using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductEntity.Models;
using Microsoft.EntityFrameworkCore;
namespace ProductEntity.Models
{
    public class ProductDbcontext : DbContext
    {
       // public ProductDbcontext()
       // {

       // }
       // public ProductDbcontext(DbContextOptions<ProductDbcontext> options) : base(options)
       // {

       // }
       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
       //     optionsBuilder.UseSqlServer("Data Source = DESKTOP-R2O6G8R; Database = trail; Integrated Security = True");
       // }
       //// public virtual DbSet<Customer> Customers { get; set; }
       // public virtual DbSet<Product> Products { get; set; }
    }
}



