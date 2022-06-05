using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class Units
    {
        [Key]
        public int UnitID { get; set; }
        public string UnitName { get; set; }
    }
}
