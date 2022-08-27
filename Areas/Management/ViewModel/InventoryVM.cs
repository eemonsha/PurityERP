using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.ViewModel
{
    public class InventoryVM
    {
        public string ProductTitle { get; set; }
        public DateTime InvOutDate { get; set; }//inventory out date
        public decimal InvOutQty { get; set; }
        public decimal ProdQty { get; set; }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Tittle { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int UnidId { get; set; }
        public decimal PurchaseQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int SupplierId { get; set; }
        public decimal RemainingQty { get; set; }


        public string QrExistsInv { get; set; }//this field will be used to check if QR already created in the QR table or not, if yes this field will carry Yes and vice verse
    }
}
