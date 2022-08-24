using Microsoft.EntityFrameworkCore;
using PurityERP.Areas.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Data
{
    public class DataContext : DbContext
    {
        internal object suppliers;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Units> units { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Costtype> Costtypes { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Inventory> Inventories {get; set;}
        public DbSet<InventoryOut> InventoryOuts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<NewWork> NewWorks { get; set; }
        public DbSet<CostMap> CostMaps { get; set; }
        public DbSet<ProductWorkRegister> ProductWorkRegisters { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public DbSet<QRCode> QRCodes { get; set; }

        public DbSet<CostRegister> CostRegisters { get; set; }
        public DbSet<QR> QRs { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<RolebasedMenu> RolebasedMenus { get; set; }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }
        public DbSet<Sales> Sales{ get; set; }
        public DbSet<SalesProduct> SalesProducts{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CostMap>().HasData(

                new CostMap { CostMapId = 1, OperationType = "Raw Material" },
                new CostMap { CostMapId = 2, OperationType = "Karchupi Work" }
                );
            modelBuilder.Entity<UserType>().HasData(

                new UserType {UserTypeID = 1,UserTypeName = "Administrator" },
                new UserType {UserTypeID = 2,UserTypeName = "Manager" },
                new UserType {UserTypeID = 3,UserTypeName = "Employee" },
                new UserType {UserTypeID = 4,UserTypeName = "User" }

                );
            modelBuilder.Entity<Users>().HasData(

                 new Users { UserID = 1, UserName = "Admin", PassWord = "123", UserTypeID = 1}

                 );

            modelBuilder.Entity<Menu>().HasData(

                new Menu { MenuID = 1, ManuName = "Super Admin" },
                new Menu { MenuID = 2, ManuName= "Management"}
                 );
             modelBuilder.Entity<SubMenu>().HasData(

                new SubMenu { SubMenuID = 1, SubManuName = "Menus", Area = "Management", Controller = "Home", Action = "MenuIndex", MainMenuID=1 },
                new SubMenu { SubMenuID = 2, SubManuName = "Sub Menus", Area = "Management", Controller = "Home", Action = "SubMenuIndex", MainMenuID=1 },
                new SubMenu { SubMenuID = 3, SubManuName = "Role Based Menus", Area = "Management", Controller = "Home", Action = "RolePermission", MainMenuID=1 }
                
                 );
            modelBuilder.Entity<RolebasedMenu>().HasData(

                new RolebasedMenu { RBMenuID=1, UserID = 1, UserTypeID = 1, SubMenuID = 1, ActiveStatus = true },
                new RolebasedMenu { RBMenuID=2, UserID = 1, UserTypeID = 1, SubMenuID = 2, ActiveStatus = true },
                new RolebasedMenu { RBMenuID=3, UserID = 1, UserTypeID = 1, SubMenuID = 3, ActiveStatus = true }

                );


        }

    }
}
