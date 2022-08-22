using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PurityERP.Areas.Management.Models;
using PurityERP.Areas.Management.ViewModel;
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



       
        public IActionResult Sales()
        {

            IEnumerable<SelectListItem> pro = from Product in _context.Products.ToList()
                                              select new SelectListItem
                                              {
                                                  Value = Product.Id.ToString(),
                                                  Text = Product.ProductCode + "_" + Product.ProductTittle
                                              };


            IEnumerable<SelectListItem> cus = from Customer in _context.CustomerInfos.ToList()
                                              select new SelectListItem
                                              {
                                                  Value = Customer.CustomerID.ToString(),
                                                  Text = Customer.CustomarPhn+ "_" + Customer.CustomerName
                                              };
            ViewBag.cs = cus;
            ViewBag.pr = pro;
            return View();
        }
        [HttpPost]
        public IActionResult Sales(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CustomerCreate(CustomerVM model)   
        {
            CustomerInfo customer = new CustomerInfo
            {
                CustomerID = 0,
                CustomerName = model.CustomerName,
                CustomarAddress = model.CustomarAddress,
                CustomarPhn = model.CustomarPhn,
                CustomerArea = model.CustomerArea,
                CustomerEmail = model.CustomerEmail
            };
            _context.CustomerInfos.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Sales");
        }

        public JsonResult GetProductName(int proname)
        {
            var p = _context.Products.Where(x => x.Id == proname).FirstOrDefault();
            return Json(p);
        }
        public JsonResult GetAmount(int name , int Quantity)
        {
            var p = _context.Products.Where(x => x.Id == name).FirstOrDefault().SalesPrice;
            var amnt = (Quantity * p);

            return Json(amnt);
        }

        
    }
}
