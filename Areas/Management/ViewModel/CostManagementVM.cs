using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.ViewModel
{
    public class CostManagementVM
    {
        //product cost
        public int CostRegID { get; set; }//ID from cost register table
        public int ProdID { get; set; }//Product ID
        public int CostTypeID { get; set; }//Cost type ID
        public DateTime CostDate { get; set; }// date of cost incure
        public decimal PerUnitCostNew { get; set; }// per unit cost will be used for insert
        public decimal PerUnitCostUpdate { get; set; }// per unit cost will be used for Update
        public int CostCorrRegId { get; set; }//ID from product out table or  inventory out table
        public string CostStatus { get; set; }
    }
}
