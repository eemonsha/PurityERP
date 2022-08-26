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

        public IActionResult Salesindex()
        {
            var salesin = (from pro in _context.Products
                           join spro in _context.SalesProducts
                           on pro.Id equals spro.ProductID
                           join sa in _context.Sales
                           on spro.SaleID equals sa.SaleID
                           

                           select new CustomerVM
                           {
                               SaleID = sa.SaleID,
                               ProductCode = pro.ProductCode,
                               ProductTittle = pro.ProductTittle,
                               Date = sa.Date,
                               
                               Amount = spro.Amount,
                               OrderQty = spro.OrderQty
                           });
            return View(salesin);
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
        public JsonResult CustomerCreate(CustomerVM data)   
        {
            CustomerInfo customer = new CustomerInfo
            {
                CustomerID = 0,
                CustomerName = data.CustomerName,
                CustomarAddress = data.CustomarAddress,
                CustomarPhn = data.CustomarPhn,
                CustomerArea = data.CustomerArea,
                CustomerEmail = data.CustomerEmail
            };
            _context.CustomerInfos.Add(customer);
            _context.SaveChanges();
            var allcus = _context.CustomerInfos.OrderByDescending(x=>x.CustomerID).ToList();
            return Json(allcus);
        }



        public JsonResult SalesCreate(CustomerVM data)
        {
            try
            {
                var sales = new Sales()
                {
                    CustID = data.CustID,
                    Date = DateTime.UtcNow.AddHours(6),
                    SubTotalAmount = data.SubTotalAmount,
                    TotalAmount = data.TotalAmount,
                    Discount = data.Discount,
                    CashAmount = data.CashAmount,
                    CardAmount = data.CardAmount,
                    MobilebankingAmount = data.MobilebankingAmount,
                    Vat = data.Vat,

                };
                _context.Add(sales);
                _context.SaveChanges();

                foreach (var item in data.selsp)
                {
                    var proqty = _context.Products.Where(x => x.Id == item.ProductID).FirstOrDefault();
                    proqty.RemainingQty = proqty.RemainingQty - item.OrderQty;
                    _context.Update(proqty);
                    _context.SaveChanges();


                    var salep = new SalesProduct()
                    {
                        SaleID = sales.SaleID,
                        ProductID = item.ProductID,
                        OrderQty = item.OrderQty,
                        UnitPrice = item.UnitPrice,
                        Amount = item.Amount,
                        Pvat = item.Pvat,
                        PDiscount = item.PDiscount,
                        Returnable = false,
                    };
                    _context.Add(salep);
                    _context.SaveChanges();


                    if (item.OrderQty > 0)
                    {
                        var pwr = new ProductWorkRegister
                        {
                            RegAsignDate = sales.Date,
                            RegWorkID = salep.SalesProID,
                            RegType = "Out",
                            RegCategoryQty = item.OrderQty,
                            MoveStatus = "Sell"
                        };
                        _context.Add(pwr);
                        _context.SaveChanges();
                    }

                }


                return Json(1);
            }
            catch
            {
                return Json(0);
            }
            
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
