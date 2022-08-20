using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class QRCode
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Inventorys { get; set; }
        public decimal Quantity { get; set; }
        public string QcStatus { get; set; }
        public string QrStatus { get; set; }
        public string Img { get; set; }

    }
}
