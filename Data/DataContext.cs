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
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Units> units { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
