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
        public string InventoryItem { get; set; }
        public DateTime SystemDate { get; set; }
        public string ProductTittle { get; set; }
        public int ProductQuantity { get; set; }
        public int InventoryQuantity { get; set; }
        public string Worker { get; set; }
    }
}
