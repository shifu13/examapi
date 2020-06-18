using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using examapi.Model;

namespace examapi.Data
{
    public class RemaContext : DbContext
    {
        public RemaContext(DbContextOptions<RemaContext> opt) : base(opt)
        {
             
        }


        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }
    }
}
