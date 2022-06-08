using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductTittle { get; set; }
        public int CostingPrice { get; set; }
        public int SalesPrice { get; set; }
        public int DiscountRate { get; set; }
        public int InitialProductStockQty { get; set; }
        public int RemainingQty { get; set; }

    }
}
