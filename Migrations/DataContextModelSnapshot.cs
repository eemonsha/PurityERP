﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PurityERP.Data;

namespace PurityERP.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PurityERP.Areas.Management.Models.CostMap", b =>
                {
                    b.Property<int>("CostMapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("OperationType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CostMapId");

                    b.ToTable("CostMaps");

                    b.HasData(
                        new
                        {
                            CostMapId = 1,
                            OperationType = "Raw Material"
                        },
                        new
                        {
                            CostMapId = 2,
                            OperationType = "Karchupi Work"
                        });
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.Costtype", b =>
                {
                    b.Property<int>("CostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CostMapId")
                        .HasColumnType("int");

                    b.Property<string>("Costtittle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CostId");

                    b.ToTable("Costtypes");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PurchaseQuantity")
                        .HasColumnType("int");

                    b.Property<int>("RemainingQty")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnidId")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.InventoryOut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("InventoryItem")
                        .HasColumnType("int");

                    b.Property<int>("InventoryQuantity")
                        .HasColumnType("int");

                    b.Property<float>("PerProductInventoryQuantity")
                        .HasColumnType("real");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<int>("ProductTittle")
                        .HasColumnType("int");

                    b.Property<DateTime>("SystemDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Worker")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InventoryOuts");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.NewWork", b =>
                {
                    b.Property<int>("WorkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DeliveryQty")
                        .HasColumnType("int");

                    b.Property<DateTime>("EDD")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaidAmount")
                        .HasColumnType("int");

                    b.Property<int>("Payment")
                        .HasColumnType("int");

                    b.Property<float>("PerUnitCost")
                        .HasColumnType("real");

                    b.Property<int>("Product")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("SystemDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WasteLostQty")
                        .HasColumnType("int");

                    b.Property<DateTime>("WorkAsignDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WorkStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkType")
                        .HasColumnType("int");

                    b.Property<int>("Wroker")
                        .HasColumnType("int");

                    b.HasKey("WorkId");

                    b.ToTable("NewWorks");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PaymentAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentWorkID")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CostingPrice")
                        .HasColumnType("int");

                    b.Property<int>("DiscountRate")
                        .HasColumnType("int");

                    b.Property<int>("InitialProductStockQty")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductTittle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RemainingQty")
                        .HasColumnType("int");

                    b.Property<int>("SalesPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.ProductWorkRegister", b =>
                {
                    b.Property<int>("ProductWorkRegisterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("RegAsignDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RegCategoryQty")
                        .HasColumnType("int");

                    b.Property<string>("RegType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegWorkID")
                        .HasColumnType("int");

                    b.HasKey("ProductWorkRegisterID");

                    b.ToTable("ProductWorkRegisters");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.Suppliers", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("SupplierAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierPhno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.Units", b =>
                {
                    b.Property<int>("UnitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnitID");

                    b.ToTable("units");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            PassWord = "123",
                            UserName = "Admin",
                            UserType = "Admin"
                        });
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.Worker", b =>
                {
                    b.Property<int>("WorkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("WorkerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkerNid")
                        .HasColumnType("int");

                    b.Property<string>("WorkerPhno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkerId");

                    b.ToTable("Workers");
                });
#pragma warning restore 612, 618
        }
    }
}
