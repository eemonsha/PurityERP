using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class NewWork
    {
        [Key]
        public int WorkId { get; set; }
        public int Wroker { get; set; }
        public int Product { get; set; }
        public DateTime WorkAsignDate { get; set; }
        public int WorkType { get; set; }
        public float PerUnitCost { get; set; }
        public decimal Quantity { get; set; }
        public DateTime EDD { get; set; }
        public int DeliveryQty { get; set; }
        public int WasteLostQty { get; set; }
        public decimal Payment { get; set; }
        public DateTime SystemDate { get; set; }
        public decimal PaidAmount { get; set; }
        public string WorkStatus { get; set; }


    }
}
