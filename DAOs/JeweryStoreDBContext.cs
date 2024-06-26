﻿using BusinessObjecs.Models;
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
    public class JeweryStoreDBContext : DbContext, IUnitOfWork 
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
            //DbSampleData.Seed(this);
        }
    }  
}
