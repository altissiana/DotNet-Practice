using System;
using DotNetPractices.Models;
using Microsoft.EntityFrameworkCore;


namespace DotNetPractices.Data
{
    public class PetStoreContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductOrder> productOrders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=PetStore;Uid=root;Pwd=12345678;");
        }
    }
}
