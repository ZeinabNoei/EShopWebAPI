﻿// <auto-generated />
using System;
using EShopAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EShopAPI.Migrations
{
    [DbContext(typeof(EShopAPI_DBContext))]
    [Migration("20201122185946_CitiFK")]
    partial class CitiFK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EShopAPI.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Citi");

                    b.Property<DateTime>("MotificationDate");

                    b.Property<DateTime>("RegisterDate");

                    b.HasKey("ID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("EShopAPI.Models.OrderItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("MotificationDate");

                    b.Property<int?>("OrderId");

                    b.Property<int?>("ProductId");

                    b.Property<int?>("Quantity");

                    b.Property<DateTime>("RegisterDate");

                    b.HasKey("ID");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("EShopAPI.Models.Orders", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("MotificationDate");

                    b.Property<DateTime?>("OrderDate");

                    b.Property<string>("OrderStatus");

                    b.Property<double?>("OrderTotal");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<int?>("SalesPersonId");

                    b.Property<int?>("UserId");

                    b.Property<int?>("UsersID");

                    b.HasKey("ID");

                    b.HasIndex("SalesPersonId");

                    b.HasIndex("UsersID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EShopAPI.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("MotificationDate");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<double?>("ProductPrice")
                        .IsRequired();

                    b.Property<int?>("ProductSize")
                        .IsRequired();

                    b.Property<string>("ProductStatus");

                    b.Property<string>("ProductVarienty");

                    b.Property<DateTime>("RegisterDate");

                    b.HasKey("ID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("EShopAPI.Models.Province", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityID");

                    b.Property<DateTime>("MotificationDate");

                    b.Property<string>("Provinc");

                    b.Property<DateTime>("RegisterDate");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("EShopAPI.Models.SalesPerson", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("MotificationDate");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<string>("SpAddress");

                    b.Property<string>("SpCity");

                    b.Property<string>("SpEmail")
                        .IsRequired();

                    b.Property<string>("SpName");

                    b.Property<string>("SpPhone");

                    b.Property<string>("SpState");

                    b.Property<string>("SpZipCode");

                    b.HasKey("ID");

                    b.ToTable("SalesPerson");
                });

            modelBuilder.Entity("EShopAPI.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("MotificationDate");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<string>("UserActiveCode");

                    b.Property<string>("UserAddress");

                    b.Property<string>("UserConfirmPassword")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("UserEmail")
                        .IsRequired();

                    b.Property<bool>("UserIsActive");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("UserPhone");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EShopAPI.Models.OrderItems", b =>
                {
                    b.HasOne("EShopAPI.Models.Orders", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");

                    b.HasOne("EShopAPI.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EShopAPI.Models.Orders", b =>
                {
                    b.HasOne("EShopAPI.Models.SalesPerson", "SalesPerson")
                        .WithMany("Orders")
                        .HasForeignKey("SalesPersonId");

                    b.HasOne("EShopAPI.Models.Users", "Users")
                        .WithMany("Orders")
                        .HasForeignKey("UsersID");
                });

            modelBuilder.Entity("EShopAPI.Models.Province", b =>
                {
                    b.HasOne("EShopAPI.Models.City")
                        .WithMany("province")
                        .HasForeignKey("CityID");
                });
#pragma warning restore 612, 618
        }
    }
}
