using Microsoft.EntityFrameworkCore;
using SneakerShopBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShopBlazor.Context
{
    public class SneakerShopDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ShopSneakersDb;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountUser>().HasIndex(s => s.Useraname).IsUnique();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Bill> Bills{ get; set; }
        public DbSet<BillDetail> BillDetails{ get; set; }
        public DbSet<AccountUser> AccountUsers{ get; set; }
        public DbSet<AddressCustomer> AddressCustomers{ get; set; }
    }
}
