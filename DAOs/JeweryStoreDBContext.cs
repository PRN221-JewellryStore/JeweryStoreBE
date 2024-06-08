using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DAOs
{
    public class JeweryStoreDBContext : DbContext
    {
        public JeweryStoreDBContext(DbContextOptions options) : base(options) { }
        
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
        }
        public void SeedData()
        {
            DbSampleData.Seed(this);
        }
    }

    public class DbSampleData
    {
        public static void Seed(JeweryStoreDBContext context)
        {
            // Check if the database already has data (optional)
            if (context.userEntities.Any())
            {
                return; // Exit if data already exists
            }

            context.categoryEntities.AddRange(
                new CategoryEntity { Name = "Electronics" },
                new CategoryEntity { Name = "Furniture" }
            );
            context.SaveChanges();

            context.counterEntities.AddRange(
                new CounterEntity { CategoryID = 1, Name = "Electronics" },
                new CounterEntity { CategoryID = 2, Name = "Furniture" }
            );
            context.SaveChanges();

            context.orderEntities.AddRange(
                new OrderEntity { Note = "Order for John Doe", PromotionID = "PRM001", CounterID = 1, UserID = "U001" },
                new OrderEntity { Note = "Jane Smith's order", PromotionID = "PRM002", CounterID = 1, UserID = "U002" },
                new OrderEntity { Note = "Enny's order", PromotionID = "PRM003", CounterID = 1, UserID = "U003" }
            );
            context.SaveChanges();

            context.orderDetailEntities.AddRange(
                new OrderDetailEntity { OrderID = "ODR001", ProductID = "PRD001", Quantity = 15 , ProductCost = 1500 },
                new OrderDetailEntity { OrderID = "ODR002", ProductID = "PRD002", Quantity = 10, ProductCost = 2000 },
                new OrderDetailEntity { OrderID = "ODR003", ProductID = "PRD003", Quantity = 12, ProductCost = 600 }
            );
            context.SaveChanges();

            context.productEntities.AddRange(
                new ProductEntity
                {
                    Cost = 100,
                    Weight = 1.5f,
                    Quantity = 50,
                    Description = "A stylish laptop for work and play",
                    CategoryID = 1
                },
                new ProductEntity
                {
                    Cost = 200,
                    Weight = 0.2f,
                    Quantity = 100,
                    Description = "A comfortable gaming chair",
                    CategoryID = 1
                },
                new ProductEntity
                {
                    Cost = 50,
                    Weight = 0.2f,
                    Quantity = 100,
                    Description = "A comfortable gaming chair",
                    CategoryID = 1
                }
            );
            context.SaveChanges();

            context.promotionEntities.AddRange(
                new PromotionEntity
                {
                    Description = "10% off your first order",
                    ConditionsOfUse = 10, 
                    ReducedPercent = 10,
                    MaximumReduce = 50,
                    ExchangePoint = 50,
                    ExpiresTime = DateTime.Now.AddDays(14),
                    UserID = "U001" 
                },
                new PromotionEntity
                {
                    Description = "10% off your first order",
                    ConditionsOfUse = 10,
                    ReducedPercent = 10,
                    MaximumReduce = 50,
                    ExchangePoint = 50,
                    ExpiresTime = DateTime.Now.AddDays(14),
                    UserID = "U002"
                },
                new PromotionEntity
                {
                    Description = "10% off your first order",
                    ConditionsOfUse = 10,
                    ReducedPercent = 10,
                    MaximumReduce = 50,
                    ExchangePoint = 50,
                    ExpiresTime = DateTime.Now.AddDays(14),
                    UserID = "U003"
                }
            );
            context.SaveChanges();

            context.userEntities.AddRange(
                new UserEntity
                {
                    Username = "john.doe",
                    PasswordHash = "123", 
                    FullName = "John Doe",
                    Email = "john.doe@example.com",
                    PhoneNumber = "1234567890",
                    Address = "123 Main Street",
                    Point = 1000,
                    RoleID = 2 
                },
                new UserEntity
                {
                    Username = "jane.smith",
                    PasswordHash = "456",
                    FullName = "Jane Smith",
                    Email = "jane.smith@example.com",
                    PhoneNumber = "9876543210",
                    Address = "456 Oak Avenue",
                    Point = 500,
                    RoleID = 2 
                },
                new UserEntity
                {
                    Username = "enny",
                    PasswordHash = "789",
                    FullName = "Enny",
                    Email = "enny@example.com",
                    PhoneNumber = "0113344589",
                    Address = "789 Some Where",
                    Point = 500,
                    RoleID = 2 
                },
                new UserEntity
                {
                    Username = "Admin",
                    PasswordHash = "admin",
                    FullName = "Admin",
                    Email = "admin@example.com",
                    PhoneNumber = "0000000000",
                    Address = "headquarter",
                    Point = 0,
                    RoleID = 1
                }
            );
            context.SaveChanges();

            context.roleEntities.AddRange(
                new RoleEntity { Name = "Admin" },
                new RoleEntity { Name = "Customer" }
            );
            context.SaveChanges();
        }
    }
}
