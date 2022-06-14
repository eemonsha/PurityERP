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
        public int ProductQuantity { get; set; }
        public int InventoryQuantity { get; set; }
        public float PerProductInventoryQuantity { get; set; }
        public string Worker { get; set; }
    }
}
