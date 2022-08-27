using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class QrCategory
    {
        //this table will be a seed data. this table will hold category for QR , e.g. inventory or product
        public int ID { get; set; }
        public string CategoryTitle { get; set; }
    }
}
