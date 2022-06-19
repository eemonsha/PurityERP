using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class CostRegister
    {
        public int ID { get; set; }
        public int ProdID { get; set; }//Product ID
        public int CostID { get; set; }//Cost ID
        public DateTime DateofCalculate { get; set; }//calculation date
        public decimal PerUnitCost { get; set; }//per unit cost
        public int CostRegID { get; set; }//incase of cost ID for raw material then raw material out ID and in case of cost id Production then work register ID
        public string CostStatus { get; set; }// in general active if cost is cancelled then status will be cancelled
        public int UserID { get; set; }//user ID
    }
}
