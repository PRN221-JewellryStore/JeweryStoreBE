using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using Microsoft.EntityFrameworkCore;
using Repositories.Common.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class JeweryStoreDBContext : DbContext, IUnitOfWork 
    {
        public JeweryStoreDBContext(DbContextOptions<JeweryStoreDBContext> options) : base(options) 
        {

        }
        
        public DbSet<OrderDetailEntity> orderDetailEntities { get; set; }
        
        public DbSet<OrderEntity> orderEntities { get; set; }
        
        public DbSet<ProductEntity> productEntities { get; set; }
        
        public DbSet<PromotionEntity> promotionEntities { get; set; }
        
        public DbSet<UserEntity> userEntities { get; set; }

        public DbSet<CategoryEntity> categoryEntities { get; set; }

        public DbSet<CounterEntity> counterEntities { get; set; }

        public DbSet<RoleEntity> roleEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
        private void ConfigureModel(ModelBuilder modelBuilder)
        {


        }


    }
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleEntity>().HasData(
                new RoleEntity { ID = 1, Name = "Admin" },
                new RoleEntity { ID = 2, Name = "Customer" },
                new RoleEntity { ID = 3, Name = "Manager" },
                new RoleEntity { ID = 4, Name = "Staff" }
            );

            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    ID = Guid.NewGuid().ToString(),
                    Username = "admin",
                    Email = "admin@gmail.com",
                    PasswordHash = "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y", //admin
                    RoleID = 1,
                    CreatedAt = DateTime.Now,
                    FullName = "Administrator",
                    Address = "123 Admin St.",
                    PhoneNumber = "1234567890",
                    Point = 0
                }
            );

            var categories = new List<CategoryEntity>
        {
            new CategoryEntity { ID = 1, Name = "Vòng cổ" },
            new CategoryEntity { ID = 2, Name = "Vòng tay" },
            new CategoryEntity { ID = 3, Name = "Nhẫn" },
            new CategoryEntity { ID = 4, Name = "Đồng hồ" },
            new CategoryEntity { ID = 5, Name = "Bông tai" },
            new CategoryEntity { ID = 6, Name = "Kiềng" },
            new CategoryEntity { ID = 7, Name = "Lắc" }
        };

            modelBuilder.Entity<CategoryEntity>().HasData(categories);

            var counters = categories.Select(c => new CounterEntity
            {
                ID = c.ID,
                Name = c.Name + " Counter",
                CategoryID = c.ID
            }).ToList();

            modelBuilder.Entity<CounterEntity>().HasData(counters);

            var products = new List<ProductEntity>
            {
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 1", Cost = 1000, Weight = 10, Quantity = 5, CategoryID = 1 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 2", Cost = 1500, Weight = 15, Quantity = 10, CategoryID = 1 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 3", Cost = 2000, Weight = 20, Quantity = 7, CategoryID = 2 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 4", Cost = 2500, Weight = 25, Quantity = 12, CategoryID = 2 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 5", Cost = 3000, Weight = 30, Quantity = 3, CategoryID = 3 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 6", Cost = 3500, Weight = 35, Quantity = 8, CategoryID = 3 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 7", Cost = 4000, Weight = 40, Quantity = 2, CategoryID = 4 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 8", Cost = 4500, Weight = 45, Quantity = 6, CategoryID = 4 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 9", Cost = 5000, Weight = 50, Quantity = 4, CategoryID = 5 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 10", Cost = 5500, Weight = 55, Quantity = 9, CategoryID = 5 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 11", Cost = 6000, Weight = 60, Quantity = 1, CategoryID = 6 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 12", Cost = 6500, Weight = 65, Quantity = 5, CategoryID = 6 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 13", Cost = 7000, Weight = 70, Quantity = 11, CategoryID = 7 },
                new ProductEntity { ID = Guid.NewGuid().ToString("N"), Description = "Product 14", Cost = 7500, Weight = 75, Quantity = 13, CategoryID = 7 }
            };

            modelBuilder.Entity<ProductEntity>().HasData(products);

        }
    }
}
