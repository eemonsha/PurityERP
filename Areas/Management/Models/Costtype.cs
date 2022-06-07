using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class Costtype
    {
        [Key]
        public int CostId { get; set; }
        public string Costtittle { get; set; }
    }
}
