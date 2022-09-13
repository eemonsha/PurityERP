using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class PreModuleController : Controller
    {


        private readonly DataContext _context;
        private readonly IToastNotification _toastNotification;


        public PreModuleController(DataContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;

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
            var units = _context.units.FirstOrDefault();
            return View(units);
        }

        public IActionResult UnitCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UnitCreate(Units units)
        {

            //validation to check redundent input
            var SelUnit = _context.units.Where(x => x.UnitName == units.UnitName).FirstOrDefault();
            if (SelUnit != null)
            {
                _toastNotification.AddErrorToastMessage("An existing unit exists in the same name");
                return View(units);

            }

            _context.units.Add(units);
            _context.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Unit added successfully");
            return RedirectToAction("UnitIndex");
        }
        public IActionResult EditUnit(int id)
        {
            var edit = _context.units.Where(x => x.UnitID == id).FirstOrDefault();
            return View(edit);
        }
        [HttpPost]
        public IActionResult EditUnit(Units units)
        {
            _context.Update(units);
            _context.SaveChanges();
            return RedirectToAction("UnitIndex");
        }
        public IActionResult DeleteUnit(int id)
        {
            var data = _context.units.Where(x => x.UnitID == id).FirstOrDefault();
            _context.Remove(data);
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
        public IActionResult SupplierCreate( Suppliers suppliers)
        {
            var SelSup = _context.Suppliers.Where(x => x.SupplierName == suppliers.SupplierName).FirstOrDefault();
            if (SelSup != null)
            {
                _toastNotification.AddErrorToastMessage("An existing Supplier exists in the same name");
                return View(suppliers);
            }

            _context.Add(suppliers);
            _context.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Supplier added successfully");
            return RedirectToAction("SupplierIndex");
        }

        public IActionResult EditSupplier(int id)
        {
            var edit = _context.Suppliers.Where(x => x.SupplierId == id).FirstOrDefault();
            return View(edit);
        }

        [HttpPost]
        public IActionResult EditSupplier(Suppliers suppliers)
        {
            _context.Update(suppliers);
            _context.SaveChanges();
            return RedirectToAction("SupplierIndex");
        }

        public IActionResult DeleteSupplier(int Id)
        {
            var dat = _context.Suppliers.Where(x => x.SupplierId == Id).FirstOrDefault();
            _context.Remove(dat);
            _context.SaveChanges();
            return RedirectToAction("SupplierIndex");
        }



        public IActionResult CosttypeIndex()
        {
            var costtype = from cst in _context.Costtypes
                           join csm in _context.CostMaps
                           on cst.CostMapId equals csm.CostMapId
                           select new Costtype
                           {
                               Costtittle = cst.Costtittle,
                               OperationType = csm.OperationType,
                               CostId = cst.CostId
                           };


            return View(costtype);
        }
        public IActionResult CostType()
        {
            ViewBag.costmape = _context.CostMaps.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult CostType(Costtype costtype)
        {
            ViewBag.costmape = _context.CostMaps.ToList();
            var CostSup = _context.Costtypes.Where(x => x.Costtittle == costtype.Costtittle).FirstOrDefault();
            if (CostSup != null)
            {
                _toastNotification.AddErrorToastMessage("An existing Coset exists in the same name");
                return View(costtype);
            }

            _context.Add(costtype);
            _context.SaveChanges();
            _toastNotification.AddSuccessToastMessage("CostType added successfully");
            return RedirectToAction("CosttypeIndex");
        }


        public IActionResult EditCostType(int id)
        {
            ViewBag.costmape = _context.CostMaps.ToList();
            var edit = _context.Costtypes.Where(x => x.CostId == id).FirstOrDefault();
            return View(edit);
        }

        [HttpPost]
        public IActionResult EditCostType(Costtype costtype)
        {

            _context.Update(costtype);
            _context.SaveChanges();
            return RedirectToAction("CosttypeIndex");
        }



        public IActionResult DeleteCost(int id)
        {
            var del = _context.Costtypes.Where(x => x.CostId == id).FirstOrDefault();
            _context.Costtypes.Remove(del);
            _context.SaveChanges();
            return RedirectToAction("CosttypeIndex");
        }





        public IActionResult WorkerIndex()
        {

            var worker = _context.Workers.ToList();
            return View(worker);
        }

        public IActionResult Worker()
        {
            var NewWorker = new Worker();
            NewWorker.WorkerNid = 0;
            return View(NewWorker);
        }

        [HttpPost]
        public IActionResult Worker(Worker worker)
        {
            var WorkrSup = _context.Workers.Where(x => x.WorkerName == worker.WorkerName).FirstOrDefault();
            if (WorkrSup != null)
            {
                _toastNotification.AddErrorToastMessage("An existing Woker exists in the same name");
                return View(worker);
            }


            _context.Add(worker);
            _context.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Worker added successfully");
            return RedirectToAction("WorkerIndex");

        }

        public IActionResult DeleteWorker(int id)
        {
            var data = _context.Workers.Where(x => x.WorkerId == id).FirstOrDefault();
            _context.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("WorkerIndex");
        }


        public IActionResult CostMap()
        {
            ViewBag.costmape = _context.CostMaps.ToList();
            return View();

        }

        //Customar ADD 
        public IActionResult CustomerIndex()
        {
            var customer = _context.CustomerInfos.ToList();
            return View(customer);
        }

        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCustomer(CustomerInfo customerInfo)
        {
            var alcus = _context.CustomerInfos.Where(x => x.CustomerName == customerInfo.CustomerName).FirstOrDefault();
            if (alcus != null)
                {
                    _toastNotification.AddErrorToastMessage("An existing Supplier exists in the same name");
                    return View(customerInfo);
                }

            _context.Add(customerInfo);
            _context.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Supplier added successfully");
            return RedirectToAction("CustomerIndex");

            


            
        }



    }
}
