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
    }
}
