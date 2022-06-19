using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class NewWork
    {
        [Key]
        public int WorkId { get; set; }
        public int Wroker { get; set; }

        [NotMapped]
        public string WrokerName { get; set; }

        public int Product { get; set; }

        [NotMapped]
        public string ProductName { get; set; }

        public DateTime WorkAsignDate { get; set; }
        public int WorkType { get; set; }

        [NotMapped]
        public string WorkTypeTitle { get; set; }

        public decimal PerUnitCost { get; set; }
        public decimal Quantity { get; set; }
        public DateTime EDD { get; set; }
        public int DeliveryQty { get; set; }

        [NotMapped]
        public DateTime TxnDate { get; set; }//this field will be used to transfer delivery/waste/payment date from view to controller


        [NotMapped]
        public int NewDeliveryQty { get; set; }//this field will be used to transfer new delivery amount from view to controller
        
        public int WasteLostQty { get; set; }

        [NotMapped]
        public int NewWasterQty { get; set; }//this field will be used to transfer new waste amount from view to controller

        public decimal Payment { get; set; }

        [NotMapped]
        public int NewPayment { get; set; }//this field will be used to transfer new payment amount from view to controller
        public DateTime SystemDate { get; set; }
        public decimal PaidAmount { get; set; }
        public string WorkStatus { get; set; }
        


    }
}
