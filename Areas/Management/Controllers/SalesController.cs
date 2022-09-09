﻿using Microsoft.AspNetCore.Mvc;
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

            var salesin = _context.Sales.ToList();
            var viewmodel = new List<PurityERP.Areas.Management.ViewModel.CustomerVM>();
            var model = new PurityERP.Areas.Management.ViewModel.CustomerVM();
            
            for (int i= 0;i<salesin.Count(); i++)
            {
                if(salesin[i].CustID == 0)
                {
                    var item = new CustomerVM
                    {
                        SaleID = salesin[i].SaleID,
                        Date = salesin[i].Date,
                        TotalAmount = salesin[i].TotalAmount,
                        CustomerName = "None"
                    };
                    viewmodel.Add(item);
                }
                else
                {
                    var customer = _context.CustomerInfos.Where(x => x.CustomerID == salesin[i].CustID).FirstOrDefault();
                    var item = new CustomerVM
                    {
                        SaleID = salesin[i].SaleID,
                        Date = salesin[i].Date,
                        TotalAmount = salesin[i].TotalAmount,
                        CustomerName = customer.CustomerName + " - " + customer.CustomarPhn
                    };
                    viewmodel.Add(item);
                }

                
            }
            return View(viewmodel);
        }

       
        public IActionResult Sales()
        {

            //IEnumerable<SelectListItem> pro = from Product in _context.Products.ToList()

            IEnumerable<SelectListItem> pro = from Product in _context.Products.Where(x => x.RemainingQty > 0).ToList()      
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


        //public IActionResult hisabkoro()
        //{
        //    var products = _context.Products.ToList();
        //    foreach (var item in products)
        //    {
        //        var pid = item.Id;
        //        var wp = _context.NewWorks.Where(x => x.Product == pid).ToList();
        //        var wps = wp.Sum(c => c.Quantity) - wp.Sum(x => x.DeliveryQty);
        //        var sp = _context.SalesProducts.Where(x => x.ProductID == pid).Sum(x => x.OrderQty);
        //        var remain = item.InitialProductStockQty - (sp + wps);
        //        item.RemainingQty = Convert.ToInt32(remain);
        //        _context.Update(item);
        //        _context.SaveChanges();

        //    }
        //    return RedirectToAction("ProductIndex", "Inventory");
        //}

        public IActionResult Salesdetails(int id)
        {
            
            var salesdetails = (from sal in _context.Sales.Where(x => x.SaleID == id).ToList()
                                join prosel in _context.SalesProducts
                                on sal.SaleID equals prosel.SaleID
                                join product in _context.Products
                                on prosel.ProductID equals product.Id
                                select new CustomerVM
                                {
                                    SaleID = sal.SaleID,
                                    SalesProID = prosel.SalesProID,
                                    Date = sal.Date,
                                    Amount = prosel.Amount,
                                    ProductTittle = product.ProductTittle,
                                    OrderQty = prosel.OrderQty,
                                    PDiscount = prosel.PDiscount,
                                    Pvat = prosel.Pvat,

                                }).ToList();
            return View(salesdetails);
            
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
                    GiftAmount = data.GiftAmount,
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


                return Json(sales.SaleID);
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
