using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class QR
    {
        public int ID { get; set; }
        public int ItemCode { get; set; }
        public byte[] QrImage { get; set; }

    }
}
