using PurityERP.Areas.Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.ViewModel
{
    public class CustomerVM
    {
        public int SaleID { get; set; }
        public int SalesProID { get; set; }
        public int CustID { get; set; }
        public String CustomerName { get; set; }
        public String CustomarPhn { get; set; }
        public String CustomerArea { get; set; }
        public String CustomarAddress { get; set; }
        public String CustomerEmail { get; set; }
        public int ProductId { get; set; }
        public int ProductID { get; set; }
        public int OrderQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public bool Returnable { get; set; }
        public DateTime Date { get; set; }
        public decimal SubTotalAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal CashAmount { get; set; }
        public decimal CardAmount { get; set; }
        public decimal MobilebankingAmount { get; set; }
        public decimal Vat { get; set; }
        public string ProductCode { get; set; }
        public string ProductTittle { get; set; }

        public List<SalesProduct> selsp { get; set; }
    }
}
