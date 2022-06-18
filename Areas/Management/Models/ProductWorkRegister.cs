using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class ProductWorkRegister
    {
        [Key]
        public int ProductWorkRegisterID { get; set; }
        public DateTime RegAsignDate { get; set; }
        public int RegWorkID { get; set; }
        public string RegType { get; set; }
        public decimal RegCategoryQty { get; set; }
    }
}
