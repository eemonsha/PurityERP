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

            modelBuilder.Entity("PurityERP.Areas.Management.Models.CostRegister", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CostID")
                        .HasColumnType("int");

                    b.Property<int>("CostRegID")
                        .HasColumnType("int");

                    b.Property<string>("CostStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateofCalculate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PerUnitCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProdID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("CostRegisters");
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

                    b.Property<decimal>("RemainingQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnidId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

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

                    b.Property<decimal>("InventoryQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PerProductInventoryQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProductQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductTittle")
                        .HasColumnType("int");

                    b.Property<DateTime>("SystemDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Worker")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InventoryOuts");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ManuName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuID");

                    b.ToTable("Menus");
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

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Payment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PerUnitCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Product")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

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

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

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

                    b.Property<decimal>("CostingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiscountRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("InitialProductStockQty")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductTittle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QRId")
                        .HasColumnType("int");

                    b.Property<int>("RemainingQty")
                        .HasColumnType("int");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.ProductWorkRegister", b =>
                {
                    b.Property<int>("ProductWorkRegisterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MoveStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegAsignDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("RegCategoryQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RegType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegWorkID")
                        .HasColumnType("int");

                    b.HasKey("ProductWorkRegisterID");

                    b.ToTable("ProductWorkRegisters");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.QR", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ItemCode")
                        .HasColumnType("int");

                    b.Property<byte[]>("QrImage")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ID");

                    b.ToTable("QRs");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.RolebasedMenu", b =>
                {
                    b.Property<int>("RBMenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("bit");

                    b.Property<int>("SubMenuID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("UserTypeID")
                        .HasColumnType("int");

                    b.HasKey("RBMenuID");

                    b.ToTable("RolebasedMenus");
                });

            modelBuilder.Entity("PurityERP.Areas.Management.Models.SubMenu", b =>
                {
                    b.Property<int>("SubMenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MainMenuID")
                        .HasColumnType("int");

                    b.Property<string>("SubManuName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubMenuID");

                    b.ToTable("SubMenus");
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

            modelBuilder.Entity("PurityERP.Areas.Management.Models.UserType", b =>
                {
                    b.Property<int>("UserTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UserTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserTypeID");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            UserTypeID = 1,
                            UserTypeName = "Administrator"
                        },
                        new
                        {
                            UserTypeID = 2,
                            UserTypeName = "Maneger"
                        },
                        new
                        {
                            UserTypeID = 3,
                            UserTypeName = "Employee"
                        },
                        new
                        {
                            UserTypeID = 4,
                            UserTypeName = "User"
                        });
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

                    b.Property<int>("UserTypeID")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            PassWord = "123",
                            UserName = "Admin",
                            UserTypeID = 1
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
