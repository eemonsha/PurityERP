using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PurityERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Controllers
{
    [Area("Management")]
    public class SalesController : Controller
    {
        private readonly DataContext _context;
        private readonly IToastNotification _toastNotification;

        public SalesController(DataContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }

        public IActionResult SalesIndex()
        {

            IEnumerable<SelectListItem> pro = from Product in _context.Products.ToList()
                                              select new SelectListItem
                                              {
                                                  Value = Product.ProductCode,
                                                  Text = Product.ProductCode + "_" + Product.ProductTittle
                                              };

            ViewBag.pr = pro;
            return View();
        }

        public JsonResult GetProductName(string proname)
        {
            var p = _context.Products.Where(x => x.ProductCode == proname).FirstOrDefault();
            return Json(p);
        }
        public JsonResult GetAmount(string name , int Quantity)
        {
            var p = _context.Products.Where(x => x.ProductCode == name).FirstOrDefault().SalesPrice;
            var amnt = (Quantity * p);

            return Json(amnt);
        }
    }
}
