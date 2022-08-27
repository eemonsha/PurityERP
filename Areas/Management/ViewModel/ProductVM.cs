using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.ViewModel
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string ProductTittle { get; set; }
        public string ProductCode { get; set; }
        public decimal CostingPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal DiscountRate { get; set; }
        public int InitialProductStockQty { get; set; }
        public int RemainingQty { get; set; }
        public string QrExists { get; set; }//this field will be used to check if QR already created in the QR table or not, if yes this field will carry Yes and vice verse
    }
}
