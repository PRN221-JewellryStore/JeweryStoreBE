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

            var products = new List<ProductEntity>
            {
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Vòng cổ 1", Description = "Vòng cổ 1", Cost = 1000000, Weight = 10.5f, Quantity = 5, CategoryID = 1, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp1.png.png?alt=media&token=b2d74777-f9de-4a25-b0ff-52a31a1863f2" },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Vòng cổ 2", Description = "Vòng cổ 2", Cost = 1500000, Weight = 12.0f, Quantity = 3, CategoryID = 1, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp2.png.png?alt=media&token=a93ff335-a5da-4309-ae29-51b4500c6402" },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Vòng tay 1", Description = "Vòng tay 1", Cost = 500000, Weight = 8.0f, Quantity = 10, CategoryID = 2, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp3.png.png?alt=media&token=dc618717-aa96-490b-9a2b-dd42ece0a55f"},
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Vòng tay 2", Description = "Vòng tay 2", Cost = 700000, Weight = 9.0f, Quantity = 8, CategoryID = 2, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp4.png.png?alt=media&token=0d8d2339-7c58-4d7c-b5be-863c45834423"},
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Nhẫn 1", Description = "Nhẫn 1", Cost = 2000000, Weight = 5.0f, Quantity = 4, CategoryID = 3, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp5.png.png?alt=media&token=152b1990-5dfd-4de1-b548-94f6410655d5"},
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Nhẫn 2", Description = "Nhẫn 2", Cost = 2500000, Weight = 6.0f, Quantity = 6, CategoryID = 3, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp6.png.png?alt=media&token=732f4160-e52c-4ac0-a870-590b598362fa" },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Đồng hồ 1", Description = "Đồng hồ 1", Cost = 3000000, Weight = 50.0f, Quantity = 2, CategoryID = 4, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp7.png.png?alt=media&token=4bb468c4-d12b-45a3-8e2c-f478b234273a" },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Đồng hồ 2", Description = "Đồng hồ 2", Cost = 3500000, Weight = 55.0f, Quantity = 3, CategoryID = 4, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp8.png.png?alt=media&token=51ca5f42-ea17-41ae-867a-6abd87a193a4" },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Bông tai 1", Description = "Bông tai 1", Cost = 800000, Weight = 3.0f, Quantity = 12, CategoryID = 5, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo1.jpg?alt=media&token=4aeac259-9a2a-47a4-a24c-af63322f8e62"},
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Bông tai 2", Description = "Bông tai 2", Cost = 900000, Weight = 3.5f, Quantity = 14, CategoryID = 5, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo2.jpg?alt=media&token=d3b10b84-a051-4e5d-a949-07d175177cce" },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Kiềng 1", Description = "Kiềng 1", Cost = 1200000, Weight = 20.0f, Quantity = 7, CategoryID = 6, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo3.jpg?alt=media&token=7fb28e19-a4bf-4095-b67f-a3a534781d8d" },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Kiềng 2", Description = "Kiềng 2", Cost = 1400000, Weight = 22.0f, Quantity = 6, CategoryID = 6, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo4.png?alt=media&token=c160c486-861d-4d7f-b402-9bd00b034056" },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Lắc 1", Description = "Lắc 1", Cost = 1000000, Weight = 15.0f, Quantity = 9, CategoryID = 7, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo5.jpg?alt=media&token=601f08e1-2442-4cfe-93cf-7ff4c61a7b9e" },
                new ProductEntity { ID = Guid.NewGuid().ToString(), Name = "Lắc 2", Description = "Lắc 2", Cost = 1100000, Weight = 16.5f, Quantity = 8, CategoryID = 7, ImgUrl = "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo6.jpg?alt=media&token=5d3cfb40-30f4-4343-96cc-9fe016b1c0c8" }
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
