using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BeardShop.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) => Database.EnsureCreated();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string customerRoleName = "customer";

            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role customerRole = new Role { Id = 2, Name = customerRoleName };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, customerRole });
            base.OnModelCreating(modelBuilder);
        }
    }
}
