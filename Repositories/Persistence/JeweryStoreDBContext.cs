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
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Vòng cổ 1", Cost = 1000000, Weight = 10.5f, Quantity = 5, CategoryID = 1 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Vòng cổ 2", Cost = 1500000, Weight = 12.0f, Quantity = 3, CategoryID = 1 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Vòng tay 1", Cost = 500000, Weight = 8.0f, Quantity = 10, CategoryID = 2 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Vòng tay 2", Cost = 700000, Weight = 9.0f, Quantity = 8, CategoryID = 2 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Nhẫn 1", Cost = 2000000, Weight = 5.0f, Quantity = 4, CategoryID = 3 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Nhẫn 2", Cost = 2500000, Weight = 6.0f, Quantity = 6, CategoryID = 3 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Đồng hồ 1", Cost = 3000000, Weight = 50.0f, Quantity = 2, CategoryID = 4 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Đồng hồ 2", Cost = 3500000, Weight = 55.0f, Quantity = 3, CategoryID = 4 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Bông tai 1", Cost = 800000, Weight = 3.0f, Quantity = 12, CategoryID = 5 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Bông tai 2", Cost = 900000, Weight = 3.5f, Quantity = 14, CategoryID = 5 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Kiềng 1", Cost = 1200000, Weight = 20.0f, Quantity = 7, CategoryID = 6 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Kiềng 2", Cost = 1400000, Weight = 22.0f, Quantity = 6, CategoryID = 6 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Lắc 1", Cost = 1000000, Weight = 15.0f, Quantity = 9, CategoryID = 7 },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Description = "Lắc 2", Cost = 1100000, Weight = 16.5f, Quantity = 8, CategoryID = 7 }
            };

            modelBuilder.Entity<ProductEntity>().HasData(products);

            var promotions = new List<PromotionEntity>
            {
                new PromotionEntity { ID = Guid.NewGuid().ToString(), Description = "Summer Sale", ConditionsOfUse = 5000000, ReducedPercent = 10, MaximumReduce = 500000, ExpiresTime = DateTime.Now.AddMonths(1), UserID = null, Status = "Active"},
                new PromotionEntity { ID = Guid.NewGuid().ToString(), Description = "Winter Sale", ConditionsOfUse = 3000000, ReducedPercent = 15, MaximumReduce = 300000, ExpiresTime = DateTime.Now.AddMonths(2), UserID = null, Status = "Active"}
            };
            modelBuilder.Entity<PromotionEntity>().HasData(promotions);

        }
    }
}
