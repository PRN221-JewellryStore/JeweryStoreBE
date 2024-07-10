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
    [Migration("20240701075938_SeedDataMigration")]
    partial class SeedDataMigration
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

                    b.Property<int>("ExchangePoint")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiresTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastestUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MaximumReduce")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("ReducedPercent")
                        .HasColumnType("real");

                    b.Property<string>("UpdaterID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Promotion");
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

                    b.Property<int>("Point")
                        .HasColumnType("int");

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
                            ID = "1c1d51d4-342c-4630-b427-96cee794772b",
                            Address = "123 Admin St.",
                            CreatedAt = new DateTime(2024, 7, 1, 14, 59, 35, 643, DateTimeKind.Local).AddTicks(4861),
                            Email = "admin@gmail.com",
                            FullName = "Administrator",
                            LastestUpdateAt = new DateTime(2024, 7, 1, 14, 59, 35, 643, DateTimeKind.Local).AddTicks(4832),
                            PasswordHash = "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y",
                            PhoneNumber = "1234567890",
                            Point = 0,
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