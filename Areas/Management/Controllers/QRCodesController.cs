using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PurityERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Controllers
{
    [Area("Management")]
    public class QRCodesController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public QRCodesController(DataContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;

        }

        public IActionResult GenerateQRCode()
        {
            //if (HttpContext.Session.GetString("Email") == null)
            //{
            //    return RedirectToAction("Login", "Home", new { Area = "Accounting" });
            //}

            //ViewBag.Inventory = new SelectList(_context.Inventorys.ToList(), "Id", "ProductDetails");
            //ViewBag.Product = new SelectList(_context.Products.ToList(),"","");
            ViewBag.product = _context.Products.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult GenerateQRCode()
        {
            

            return View();
        }
    }
}
