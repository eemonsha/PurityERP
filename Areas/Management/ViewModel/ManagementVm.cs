using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.ViewModel
{
    public class ManagementVm
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhno { get; set; }
        public string SupplierAddress { get; set; }

        public int UnitID { get; set; }
        public string UnitName { get; set; }

        public int InventoryId { get; set; }
        public string Code { get; set; }
        public string Tittle { get; set; }
        public DateTime PurchaseDate { get; set; }
        
        public int PurchaseQuantity { get; set; }
        public int UnitPrice { get; set; }

        public int RemainingQty { get; set; }
        public int InventoryItem { get; set; }
        public DateTime SystemDate { get; set; }
        public string ProductTittle { get; set; }
        public int ProductQuantity { get; set; }
        public int InventoryQuantity { get; set; }
        public string Worker { get; set; }

        
        public int CostingPrice { get; set; }
        public int SalesPrice { get; set; }
        public int DiscountRate { get; set; }
        public int InitialProductStockQty { get; set; }

        public int pId { get; set; }

        public int InventorOutId { get; set; }

    }
}

