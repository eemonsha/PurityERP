using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class InventoryOut
    {
        [Key]
        public int Id { get; set; }
        public int InventoryItem { get; set; }
        public DateTime SystemDate { get; set; }
        public int ProductTittle { get; set; }
        public decimal ProductQuantity { get; set; }
        public decimal InventoryQuantity { get; set; }
        public decimal PerProductInventoryQuantity { get; set; }
        public int Worker { get; set; }
    }
}
