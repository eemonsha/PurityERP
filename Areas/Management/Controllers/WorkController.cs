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

            _context.NewWorks.Add(newWork);
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

        public IActionResult WorkManage()
        {
            return View();
        }


    }
}
