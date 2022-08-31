using Microsoft.AspNetCore.Mvc;
using PurityERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Controllers
{
    [Area("Management")]
    public class ReportsController : Controller
    {
        private readonly DataContext _context;
    

        public ReportsController(DataContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult RepportsIndex()
        {
            return View();
        } 
    }
}
