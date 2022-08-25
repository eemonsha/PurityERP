using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class SalesProduct
    {
        [Key]
        public int SalesProID { get; set; }
        public int SaleID { get; set; }
        public int ProductID { get; set; }
        public int OrderQty { get; set; }
        public decimal  UnitPrice { get; set; }
        public decimal  Amount { get; set; }
        public decimal  Pvat { get; set; }
        public decimal  PDiscount { get; set; }
        public bool  Returnable { get; set; }


    }
}
