using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class Sales
    {
        [Key]
        public int SaleID { get; set; }
        public int CustID { get; set; }
        public DateTime Date { get; set; }
        public decimal SubTotalAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal CardAmount { get; set; }
        public decimal MobilebankingAmount { get; set; }
        public decimal Vat { get; set; }

    }
}
