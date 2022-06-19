using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.ViewModel
{
    public class ProdCostVM
    {
        public DateTime CostDate { get; set; }
        public String CostTitle { get; set; }
        public decimal CostAmount { get; set; }
    }
}
