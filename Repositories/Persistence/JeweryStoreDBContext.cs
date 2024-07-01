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
        }
    }
}
