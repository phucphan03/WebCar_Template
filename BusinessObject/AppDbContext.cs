using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationship: Account (1) <--> (many) Product
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Account)
                .WithMany(a => a.Products)
                .HasForeignKey(p => p.AccountId);
        }
    }
}
