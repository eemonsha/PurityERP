using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class Worker
    {
        [Key]
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerPhno { get; set; }
        public int WorkerNid { get; set; }
    }
}
