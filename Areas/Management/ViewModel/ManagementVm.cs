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
        
        public decimal PurchaseQuantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal RemainingQty { get; set; }
        public string InventoryItem { get; set; }
        public DateTime SystemDate { get; set; }
        public string ProductTittle { get; set; }
        public decimal ProductQuantity { get; set; }
        public decimal InventoryQuantity { get; set; }
        public string Worker { get; set; }
        public string ProductCode { get; set; }
        public decimal PerProductInventoryQuantity { get; set; }


        public decimal CostingPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal DiscountRate { get; set; }
        public int InitialProductStockQty { get; set; }

        public int pId { get; set; }//product ID

        public int InventorOutId { get; set; }

        public int CostMapId { get; set; }
        public string OperationType { get; set; }

        public int WorkId { get; set; }
        public int Wroker { get; set; }
        public string Product { get; set; }
        public DateTime WorkAsignDate { get; set; }
        public string WorkType { get; set; }
        public decimal PerUnitCost { get; set; }//per unit cost of work
        public decimal Quantity { get; set; }
        public DateTime EDD { get; set; }
        public DateTime ADD { get; set; }
        public int DeliveryQty { get; set; }
        public int WasteQty { get; set; }
        public decimal PaidAmount { get; set; }
        public string WorkStatus { get; set; }





    }
}

