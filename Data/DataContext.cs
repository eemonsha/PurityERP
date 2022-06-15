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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CostMap>().HasData(

                new CostMap { CostMapId = 1, OperationType = "Raw Material" },
                new CostMap { CostMapId = 2, OperationType = "Karchupi Work" }
                );
           modelBuilder.Entity<Users>().HasData(

                new Users { UserID = 1, UserName = "Admin",PassWord = "123",UserType ="Admin" }
                
                );
           
        }

    }
}
