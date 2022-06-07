using Microsoft.AspNetCore.Http;
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

        public IActionResult PreSelect()
        {
            //if (HttpContext.Session.GetString("UserName") ==  null)
            //{
            //    return RedirectToAction("Login", "Home", new { Area = "Management" });
            //}
            return View();
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


        public IActionResult CosttypeIndex()
        {
            var costtype = _context.Costtypes.ToList();

            return View(costtype);
        }
        public IActionResult CostType()
        {
         
            return View();
        }

        [HttpPost]
        public IActionResult CostType(Costtype costtype)
            {
            _context.Add(costtype);
            _context.SaveChanges();
            return RedirectToAction("CosttypeIndex");
        }


 




    }
}
