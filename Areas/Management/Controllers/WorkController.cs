using Microsoft.AspNetCore.Mvc;
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
    public class WorkController : Controller
    {
        private readonly DataContext _context;
        public WorkController(DataContext context)
        {
            _context = context;
        }

        public IActionResult WorkIndex()
        {
            var Wrk =( from nwork in _context.NewWorks
                      join worker in _context.Workers
                      on nwork.Wroker equals worker.WorkerId
                      join costmape in _context.CostMaps
                      on nwork.WorkType equals costmape.CostMapId
                      join product in _context.Products
                      on nwork.Product equals product.Id
                      select new ManagementVm
                      {
                          WorkId = nwork.WorkId,
                          Worker = worker.WorkerName,
                          Product = product.ProductTittle,
                          WorkAsignDate = nwork.WorkAsignDate,
                          WorkType = costmape.OperationType,
                          PerUnitCost = nwork.PerUnitCost,
                          Quantity = nwork.Quantity,
                          EDD = nwork.EDD,
                          ADD= nwork.ADD,
                          DeliveryQty= nwork.DeliveryQty,
                          PaidAmount = nwork.PaidAmount,
                          WorkStatus = nwork.WorkStatus

                      });


            return View(Wrk);
        }

        public IActionResult WorkCreate()
        {
            ViewBag.worker = _context.Workers.ToList();
            ViewBag.worketype = _context.CostMaps.ToList();
            ViewBag.product = _context.Products.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult WorkCreate(NewWork newWork)
        {
            var st = new NewWork
            {
                WorkId=0,
                WorkStatus = "Pending",
                ADD=newWork.ADD,
                EDD=newWork.EDD,
                PaidAmount=newWork.PaidAmount,
                PerUnitCost=newWork.PerUnitCost,
                WorkType=newWork.WorkType,
               WorkAsignDate=newWork.WorkAsignDate,
               Product=newWork.Product,
               Wroker=newWork.Wroker,
               Quantity=newWork.Quantity

            };
            _context.NewWorks.Add(st);
            _context.SaveChanges();
            var nw = _context.NewWorks.Where(x=>x.WorkId == st.WorkId).FirstOrDefault();
            var pwr = new ProductWorkRegister
            {
                RegAsignDate = nw.WorkAsignDate,
                RegWorkID = nw.WorkId,
                RegType = "Out",
                RegCategoryQty = nw.Quantity
            };
            _context.Add(pwr);
            _context.SaveChanges();
            return RedirectToAction("WorkIndex");
        }

        public IActionResult WorkDetails(int id)
        {
            var workdetails = (from nwork in _context.NewWorks.Where(x => x.WorkId == id)
                               join worker in _context.Workers
                               on nwork.Wroker equals worker.WorkerId
                               join costmape in _context.CostMaps
                               on nwork.WorkType equals costmape.CostMapId
                               join product in _context.Products
                                 on nwork.Product equals product.Id
                               select new ManagementVm
                               {
                                   WorkId = nwork.WorkId,
                                   Worker = worker.WorkerName,
                                   Product = product.ProductTittle,
                                   WorkAsignDate = nwork.WorkAsignDate,
                                   WorkType = costmape.OperationType,
                                   PerUnitCost = nwork.PerUnitCost,
                                   Quantity = nwork.Quantity,
                                   EDD = nwork.EDD,
                                   ADD = nwork.ADD,
                                   DeliveryQty = nwork.DeliveryQty,
                                   PaidAmount = nwork.PaidAmount,
                                   WorkStatus = nwork.WorkStatus

                               }).FirstOrDefault();

            return View(workdetails);
        }

        public IActionResult WorkManage(int id)
        {
            var mng = _context.NewWorks.Where(x => x.WorkId == id).FirstOrDefault();
            return View(mng);
        }

        [HttpPost]
        public IActionResult WorkManage(NewWork newWork)
        {
            var wrkmng = _context.NewWorks.Where(x => x.WorkId == newWork.WorkId).FirstOrDefault();

            var sm = (newWork.DeliveryQty + newWork.WasteLostQty);
            if (wrkmng.Quantity == sm)
            {
                wrkmng.SystemDate = DateTime.Now;
                wrkmng.DeliveryQty = newWork.DeliveryQty;
                wrkmng.WasteLostQty = newWork.WasteLostQty;
                wrkmng.Payment = newWork.Payment;
                _context.Update(wrkmng);
                _context.SaveChanges();


                var dte = _context.NewWorks.FirstOrDefault(); 
                var pwr = new ProductWorkRegister
                {
                    RegAsignDate = dte.WorkAsignDate,
                    RegWorkID = newWork.WorkId,
                    RegType = "In",
                    RegCategoryQty = dte.DeliveryQty
                };
                _context.Add(pwr);
                _context.SaveChanges();
                var payment = new Payment
                {
                    PaymentWorkID = newWork.WorkId,
                    PaymentDate = dte.SystemDate,
                    PaymentAmount = dte.Payment
                };
                _context.Add(payment);
                _context.SaveChanges();
                return RedirectToAction("WorkIndex");
            }
            else
            {
                TempData["msg"] = "Quantity Not Same";
            }
            return View();
            
           
        }


    }
}
