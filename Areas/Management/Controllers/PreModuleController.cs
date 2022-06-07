using Microsoft.AspNetCore.Mvc;
using PurityERP.Areas.Management.Models;
using PurityERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Controllers
{
    [Area("Management")]
    public class PreModuleController : Controller
    {
        private readonly DataContext _context;
        public PreModuleController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UnitIndex()
        {
            var units = _context.units.ToList();
            return View(units);
        }

        public IActionResult UnitCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UnitCreate(Units units)
        {
            _context.units.Add(units);
            _context.SaveChanges();
            return RedirectToAction("UnitIndex"); 
        }

        public IActionResult SupplierIndex()
        {
            var suppliers = _context.Suppliers.ToList();
            return View(suppliers);
        }

        public IActionResult SupplierCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SupplierCreate(Suppliers suppliers)
        {
            _context.Add(suppliers);
            _context.SaveChanges();
            return RedirectToAction("SupplierIndex");
        }





    }
}
