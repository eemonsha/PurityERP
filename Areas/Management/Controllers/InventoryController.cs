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
    public class InventoryController : Controller
    {
        private readonly DataContext _context;
        public InventoryController(DataContext context)
        {
            _context = context;
        }
        public IActionResult InventoryIndex()
        {
            var inv = _context.Inventories.ToList();
            return View(inv);
        }

        public IActionResult InventoryCreate()
        {
            var inven = _context.Inventories.ToList();
            var max = "";
            if (inven.Count == 0)
            {
                max = "1";
            }
            else
            {
                max = (inven.Count + 1).ToString();
            }
            var userid = HttpContext.Session.GetString("Id");
            var code = "Purity-" + DateTime.Now.Year + "/U-" + userid + "/"+ max;
            ViewBag.code = code;
            ViewBag.units = _context.units.ToList();
            ViewBag.supplier = _context.Suppliers.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult InventoryCreate(Inventory inventory)
        {
            
            _context.Inventories.Add(inventory);
            _context.SaveChanges();
            return RedirectToAction("InventoryIndex");
        }

        public IActionResult EditInventory(int id)
        {
            ViewBag.units = _context.units.ToList();
            ViewBag.supplier = _context.Suppliers.ToList();
            var edit = _context.Inventories.Where(x => x.Id == id).FirstOrDefault();
            return View(edit);
        }
        [HttpPost]
        public IActionResult EditInventory(Inventory inventory)
        {

            _context.Update(inventory);
            _context.SaveChanges();
            return RedirectToAction("InventoryIndex");
        }

        public JsonResult UnitCreate(string Unitname)
        {
            var inventory = new Units
            {
                UnitName = Unitname
            };
            _context.Add(inventory);
            _context.SaveChanges();
            var allunits = _context.units.OrderByDescending(x => x.UnitID).ToList();
            return Json(allunits);
        }

    }
}
