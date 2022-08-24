using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Tittle { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int UnidId { get; set; }
        public decimal PurchaseQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int SupplierId { get; set; }
        public decimal RemainingQty { get; set; }

    }
}
