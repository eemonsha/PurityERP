using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class QR
    {
        public int ID { get; set; }
        public int ItemCode { get; set; }//holds product or inventory ID
        public string ItemName { get; set; }
        public decimal PriceAmount { get; set; }//cost price of inventory and sales price of product
        public byte[] QrImage { get; set; }
        public virtual int QrCategory { get; set; }//category of QR i.e. inventory or product
        public virtual int QrQty { get; set; }//request quanity of QR by user

        public int UserID { get; set; }//QRCode

    }
}
