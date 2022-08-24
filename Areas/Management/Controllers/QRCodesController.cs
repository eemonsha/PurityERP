using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

            IEnumerable<SelectListItem> pro = from Product in _context.Products.ToList()
                                              select new SelectListItem
                                              {
                                                  Value = Product.ProductCode,
                                                  Text = Product.ProductCode + "_" + Product.ProductTittle
                                              };

                                            ViewBag.pr = pro;
                                            return View();
        }

        [HttpPost]
        public IActionResult GenerateQRCode(int id)
        {
            return View();
        }





    }
}
