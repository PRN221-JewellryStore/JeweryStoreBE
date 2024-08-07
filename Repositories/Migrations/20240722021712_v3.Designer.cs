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
    [Migration("20240722021712_v3")]
    partial class v3
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

                    b.Property<decimal?>("PrimaryPrice")
                        .HasColumnType("decimal(18,2)");

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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            ID = "a58f2a90-f573-489c-9a59-296fb316d54f",
                            CategoryID = 1,
                            Cost = 1000000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4966),
                            Description = "Vòng cổ 1",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4966),
                            Name = "Vòng cổ 1",
                            Quantity = 5,
                            Weight = 10.5f
                        },
                        new
                        {
                            ID = "47f672c6-6876-4f62-8d19-5425fa600420",
                            CategoryID = 1,
                            Cost = 1500000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4976),
                            Description = "Vòng cổ 2",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4976),
                            Name = "Vòng cổ 2",
                            Quantity = 3,
                            Weight = 12f
                        },
                        new
                        {
                            ID = "cc85829f-274d-432d-b1cc-6de48eac2f16",
                            CategoryID = 2,
                            Cost = 500000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4983),
                            Description = "Vòng tay 1",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4983),
                            Name = "Vòng tay 1",
                            Quantity = 10,
                            Weight = 8f
                        },
                        new
                        {
                            ID = "6fd06362-9b48-47ce-a1bf-8627fe7186bb",
                            CategoryID = 2,
                            Cost = 700000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4994),
                            Description = "Vòng tay 2",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4994),
                            Name = "Vòng tay 2",
                            Quantity = 8,
                            Weight = 9f
                        },
                        new
                        {
                            ID = "3ed5e23b-b73d-4808-8ece-d17786d2d90e",
                            CategoryID = 3,
                            Cost = 2000000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5000),
                            Description = "Nhẫn 1",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5000),
                            Name = "Nhẫn 1",
                            Quantity = 4,
                            Weight = 5f
                        },
                        new
                        {
                            ID = "605f3bbf-d60b-4451-acaf-9be437c407a0",
                            CategoryID = 3,
                            Cost = 2500000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5008),
                            Description = "Nhẫn 2",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5008),
                            Name = "Nhẫn 2",
                            Quantity = 6,
                            Weight = 6f
                        },
                        new
                        {
                            ID = "eb0bf3e9-3391-48f9-bb5c-da304b4c5ddc",
                            CategoryID = 4,
                            Cost = 3000000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5014),
                            Description = "Đồng hồ 1",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5014),
                            Name = "Đồng hồ 1",
                            Quantity = 2,
                            Weight = 50f
                        },
                        new
                        {
                            ID = "c0fd93cb-e0f8-450a-afdb-c69d27f65413",
                            CategoryID = 4,
                            Cost = 3500000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5023),
                            Description = "Đồng hồ 2",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5023),
                            Name = "Đồng hồ 2",
                            Quantity = 3,
                            Weight = 55f
                        },
                        new
                        {
                            ID = "231e4beb-3df6-4f39-b726-8683799d0a5a",
                            CategoryID = 5,
                            Cost = 800000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5096),
                            Description = "Bông tai 1",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5096),
                            Name = "Bông tai 1",
                            Quantity = 12,
                            Weight = 3f
                        },
                        new
                        {
                            ID = "0246a922-c2e2-4e76-83a6-a5449f1db947",
                            CategoryID = 5,
                            Cost = 900000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5103),
                            Description = "Bông tai 2",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5103),
                            Name = "Bông tai 2",
                            Quantity = 14,
                            Weight = 3.5f
                        },
                        new
                        {
                            ID = "1dcebec9-745a-4848-bf0a-82feb52dfccd",
                            CategoryID = 6,
                            Cost = 1200000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5109),
                            Description = "Kiềng 1",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5109),
                            Name = "Kiềng 1",
                            Quantity = 7,
                            Weight = 20f
                        },
                        new
                        {
                            ID = "316b5e70-6c43-4866-ae1f-ac0017ccfef1",
                            CategoryID = 6,
                            Cost = 1400000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5118),
                            Description = "Kiềng 2",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5118),
                            Name = "Kiềng 2",
                            Quantity = 6,
                            Weight = 22f
                        },
                        new
                        {
                            ID = "ce526015-d4be-47dc-a5d6-d67d6472af51",
                            CategoryID = 7,
                            Cost = 1000000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5124),
                            Description = "Lắc 1",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5124),
                            Name = "Lắc 1",
                            Quantity = 9,
                            Weight = 15f
                        },
                        new
                        {
                            ID = "00b7997c-3ce2-4507-8ad0-0d059f4a4ae8",
                            CategoryID = 7,
                            Cost = 1100000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5130),
                            Description = "Lắc 2",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5130),
                            Name = "Lắc 2",
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
                            ID = "ebf4e0c9-9cbf-41db-8e74-726bb3ddf8d8",
                            ConditionsOfUse = 5000000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5256),
                            Description = "Summer Sale",
                            ExpiresTime = new DateTime(2024, 8, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5260),
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5256),
                            MaximumReduce = 500000m,
                            ReducedPercent = 10f,
                            Status = "Active"
                        },
                        new
                        {
                            ID = "a04d4ee8-73e4-4135-af75-a5da913b7268",
                            ConditionsOfUse = 3000000m,
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5276),
                            Description = "Winter Sale",
                            ExpiresTime = new DateTime(2024, 9, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5279),
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5276),
                            MaximumReduce = 300000m,
                            ReducedPercent = 15f,
                            Status = "Active"
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
                            ID = "0b393451-236d-4f75-bd62-84d17be775b0",
                            Address = "123 Admin St.",
                            CreatedAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4869),
                            Email = "admin@gmail.com",
                            FullName = "Administrator",
                            LastestUpdateAt = new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4845),
                            PasswordHash = "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y",
                            PhoneNumber = "1234567890",
                            RoleID = 1,
                            Username = "admin"
                        });
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
                    b.HasOne("BusinessObjecs.Models.PromotionEntity", "Promotion")
                        .WithMany("Orders")
                        .HasForeignKey("PromotionID");

                    b.HasOne("BusinessObjecs.Models.UserEntity", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
