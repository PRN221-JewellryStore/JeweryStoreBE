﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace Repositories.Migrations
{
    [DbContext(typeof(JeweryStoreDBContext))]
    [Migration("20240718085746_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessObjecs.Models.Configured.CategoryEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastestUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdaterID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Vòng cổ"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Vòng tay"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Nhẫn"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Đồng hồ"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Bông tai"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Kiềng"
                        },
                        new
                        {
                            ID = 7,
                            Name = "Lắc"
                        });
                });

            modelBuilder.Entity("BusinessObjecs.Models.Configured.CounterEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastestUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdaterID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Counter");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            Name = "Vòng cổ Counter"
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 2,
                            Name = "Vòng tay Counter"
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 3,
                            Name = "Nhẫn Counter"
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 4,
                            Name = "Đồng hồ Counter"
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 5,
                            Name = "Bông tai Counter"
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 6,
                            Name = "Kiềng Counter"
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = 7,
                            Name = "Lắc Counter"
                        });
                });

            modelBuilder.Entity("BusinessObjecs.Models.Configured.RoleEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastestUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdaterID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Customer"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Manager"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Staff"
                        });
                });

            modelBuilder.Entity("BusinessObjecs.Models.OrderDetailEntity", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastestUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("ProductCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UpdaterID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("BusinessObjecs.Models.OrderEntity", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CounterID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastestUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PromotionID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdaterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("CounterID");

                    b.HasIndex("PromotionID");

                    b.HasIndex("UserID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BusinessObjecs.Models.ProductEntity", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastestUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UpdaterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ID = "74fc71a7-2bf9-4347-8434-10d0d6c40498",
                            CategoryID = 1,
                            Cost = 1000000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8894),
                            Description = "Vòng cổ 1",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8894),
                            Quantity = 5,
                            Weight = 10.5f
                        },
                        new
                        {
                            ID = "557fca59-a5d9-4592-a551-5e44fa6ba880",
                            CategoryID = 1,
                            Cost = 1500000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8903),
                            Description = "Vòng cổ 2",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8903),
                            Quantity = 3,
                            Weight = 12f
                        },
                        new
                        {
                            ID = "07e2c8ad-47e3-47bd-a741-13993432efa9",
                            CategoryID = 2,
                            Cost = 500000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8922),
                            Description = "Vòng tay 1",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8922),
                            Quantity = 10,
                            Weight = 8f
                        },
                        new
                        {
                            ID = "72b7970c-ee77-4ce0-8748-2e7177f43b96",
                            CategoryID = 2,
                            Cost = 700000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8927),
                            Description = "Vòng tay 2",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8927),
                            Quantity = 8,
                            Weight = 9f
                        },
                        new
                        {
                            ID = "97742fc5-6591-4cc2-9a12-d34b8ffe6130",
                            CategoryID = 3,
                            Cost = 2000000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8931),
                            Description = "Nhẫn 1",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8931),
                            Quantity = 4,
                            Weight = 5f
                        },
                        new
                        {
                            ID = "7395033d-a161-422e-a98f-e2753caa5871",
                            CategoryID = 3,
                            Cost = 2500000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8937),
                            Description = "Nhẫn 2",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8937),
                            Quantity = 6,
                            Weight = 6f
                        },
                        new
                        {
                            ID = "0e16200d-15ae-40d3-b438-ce4c184c6662",
                            CategoryID = 4,
                            Cost = 3000000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8945),
                            Description = "Đồng hồ 1",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8945),
                            Quantity = 2,
                            Weight = 50f
                        },
                        new
                        {
                            ID = "a52b38bd-61f9-4bc8-9bb5-7c4af90b954b",
                            CategoryID = 4,
                            Cost = 3500000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8949),
                            Description = "Đồng hồ 2",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8949),
                            Quantity = 3,
                            Weight = 55f
                        },
                        new
                        {
                            ID = "ce8a739e-5e5e-4595-8773-ad81e0050115",
                            CategoryID = 5,
                            Cost = 800000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8954),
                            Description = "Bông tai 1",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8954),
                            Quantity = 12,
                            Weight = 3f
                        },
                        new
                        {
                            ID = "a2d6607a-fe09-4829-b16a-0e893f21f036",
                            CategoryID = 5,
                            Cost = 900000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8959),
                            Description = "Bông tai 2",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8959),
                            Quantity = 14,
                            Weight = 3.5f
                        },
                        new
                        {
                            ID = "6e4b6dae-9eb0-4819-874d-b10ae434be54",
                            CategoryID = 6,
                            Cost = 1200000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8966),
                            Description = "Kiềng 1",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8966),
                            Quantity = 7,
                            Weight = 20f
                        },
                        new
                        {
                            ID = "27a16383-3b50-4f73-80d5-9edcc144f56b",
                            CategoryID = 6,
                            Cost = 1400000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8971),
                            Description = "Kiềng 2",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8971),
                            Quantity = 6,
                            Weight = 22f
                        },
                        new
                        {
                            ID = "1d4a5c7f-591e-4742-9f5d-e3876a3796be",
                            CategoryID = 7,
                            Cost = 1000000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8976),
                            Description = "Lắc 1",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8976),
                            Quantity = 9,
                            Weight = 15f
                        },
                        new
                        {
                            ID = "e7063741-2084-4b1c-b733-4a443d348438",
                            CategoryID = 7,
                            Cost = 1100000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8981),
                            Description = "Lắc 2",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8981),
                            Quantity = 8,
                            Weight = 16.5f
                        });
                });

            modelBuilder.Entity("BusinessObjecs.Models.PromotionEntity", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("ConditionsOfUse")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiresTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastestUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MaximumReduce")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("ReducedPercent")
                        .HasColumnType("real");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdaterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Promotion");

                    b.HasData(
                        new
                        {
                            ID = "3745ac82-01f7-45ba-a557-6b2a72cac214",
                            ConditionsOfUse = 5000000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9029),
                            Description = "Summer Sale",
                            ExpiresTime = new DateTime(2024, 8, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9034),
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9029),
                            MaximumReduce = 500000m,
                            ReducedPercent = 10f,
                            Status = "Done"
                        },
                        new
                        {
                            ID = "375d5228-d350-4428-aad2-cec99c6e578b",
                            ConditionsOfUse = 3000000m,
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9046),
                            Description = "Winter Sale",
                            ExpiresTime = new DateTime(2024, 9, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9049),
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9046),
                            MaximumReduce = 300000m,
                            ReducedPercent = 15f,
                            Status = "Done"
                        });
                });

            modelBuilder.Entity("BusinessObjecs.Models.UserEntity", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastestUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("UpdaterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = "d7310277-ef51-4681-8eca-0074ab8d2c5f",
                            Address = "123 Admin St.",
                            CreatedAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8697),
                            Email = "admin@gmail.com",
                            FullName = "Administrator",
                            LastestUpdateAt = new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8676),
                            PasswordHash = "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y",
                            PhoneNumber = "1234567890",
                            RoleID = 1,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("BusinessObjecs.Models.Configured.CounterEntity", b =>
                {
                    b.HasOne("BusinessObjecs.Models.Configured.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BusinessObjecs.Models.OrderDetailEntity", b =>
                {
                    b.HasOne("BusinessObjecs.Models.OrderEntity", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjecs.Models.ProductEntity", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BusinessObjecs.Models.OrderEntity", b =>
                {
                    b.HasOne("BusinessObjecs.Models.Configured.CounterEntity", "Counter")
                        .WithMany("Orders")
                        .HasForeignKey("CounterID");

                    b.HasOne("BusinessObjecs.Models.PromotionEntity", "Promotion")
                        .WithMany("Orders")
                        .HasForeignKey("PromotionID");

                    b.HasOne("BusinessObjecs.Models.UserEntity", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Counter");

                    b.Navigation("Promotion");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjecs.Models.ProductEntity", b =>
                {
                    b.HasOne("BusinessObjecs.Models.Configured.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BusinessObjecs.Models.PromotionEntity", b =>
                {
                    b.HasOne("BusinessObjecs.Models.UserEntity", "User")
                        .WithMany("Promotions")
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjecs.Models.UserEntity", b =>
                {
                    b.HasOne("BusinessObjecs.Models.Configured.RoleEntity", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BusinessObjecs.Models.Configured.CategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BusinessObjecs.Models.Configured.CounterEntity", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BusinessObjecs.Models.Configured.RoleEntity", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BusinessObjecs.Models.OrderEntity", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BusinessObjecs.Models.ProductEntity", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BusinessObjecs.Models.PromotionEntity", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BusinessObjecs.Models.UserEntity", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Promotions");
                });
#pragma warning restore 612, 618
        }
    }
}
