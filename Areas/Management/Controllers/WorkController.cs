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
    public class WorkController : Controller
    {
        private readonly DataContext _context;
        private readonly IToastNotification _toastNotification;
        public WorkController(DataContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }

        public IActionResult WorkIndex()
        {
            var Wrk =( from nwork in _context.NewWorks.Where(x=>x.WorkStatus=="Pending")
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

                          DeliveryQty= nwork.DeliveryQty,
                          PaidAmount = nwork.PaidAmount,
                          WorkStatus = nwork.WorkStatus

                      });


            return View(Wrk);
        }

        public IActionResult CompleteWorkIndex()
        {
            var Wrk = (from nwork in _context.NewWorks.Where(x => x.WorkStatus == "Delivered")
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

                           DeliveryQty = nwork.DeliveryQty,
                           PaidAmount = nwork.PaidAmount,
                           WorkStatus = nwork.WorkStatus

                       });


            return View(Wrk);
        }

        public IActionResult PaymentNotClearWorkIndex()
        {
            var Wrk = (from nwork in _context.NewWorks.Where(x => x.WorkStatus == "DeliveredWithDuepayment")
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

                           DeliveryQty = nwork.DeliveryQty,
                           PaidAmount = nwork.PaidAmount,
                           WorkStatus = nwork.WorkStatus

                       });


            return View(Wrk);
        }


        public IActionResult WorkCreate()
        {
            DefaultData();//loading default data
            var DefWork = new NewWork();
            DefWork.PaidAmount = 0;
            DefWork.WorkAsignDate = System.DateTime.Now;
            DefWork.EDD =  System.DateTime.Now.AddDays(10);
            return View(DefWork);
        }

        private void DefaultData()
        {
            ViewBag.worker = _context.Workers.ToList();
            ViewBag.worketype = _context.Costtypes.ToList();
            ViewBag.product = _context.Products.ToList();
        }


        [HttpPost]
        public IActionResult WorkCreate(NewWork newWork)
        {

            if (newWork.Quantity < 1)
            {
                _toastNotification.AddErrorToastMessage("Please specify work quanity to proceed");
                DefaultData();//loading default data
                return View(newWork);
            }

            var st = new NewWork
            {
                WorkId=0,
                WorkStatus = "Pending",

                EDD=newWork.EDD,
                PaidAmount=newWork.PaidAmount,
                PerUnitCost=newWork.PerUnitCost,
                WorkType=newWork.WorkType,
               WorkAsignDate=newWork.WorkAsignDate,
               Product=newWork.Product,
               Wroker=newWork.Wroker,
               Quantity=newWork.Quantity,
               Payment=newWork.Quantity*newWork.PerUnitCost
            };


            var rqty = _context.Products.Where(x => x.Id == st.Product).FirstOrDefault();
            rqty.RemainingQty = rqty.RemainingQty - Convert.ToInt32(st.Quantity);
            _context.Update(rqty);
            _context.SaveChanges();


            _context.NewWorks.Add(st);
            _context.SaveChanges();
            var nw = _context.NewWorks.Where(x=>x.WorkId == st.WorkId).FirstOrDefault();
            var pwr = new ProductWorkRegister
            {
                RegAsignDate = nw.WorkAsignDate,
                RegWorkID = nw.WorkId,
                RegType = "Out",
                MoveStatus="Work",
                RegCategoryQty = nw.Quantity
            };
            _context.Add(pwr);
            _context.SaveChanges();

            //add data to cost table
            if (newWork.PerUnitCost > 0)// indicates there is cost involved in the work
            {
                var NewCost = new CostRegister()
                {
                    ProdID=newWork.Product,
                    CostID=newWork.WorkType,
                    DateofCalculate=System.DateTime.Now,
                    PerUnitCost= newWork.PerUnitCost,
                    CostRegID=pwr.RegWorkID,
                    CostStatus="Active"
                };
                
                _context.Add(NewCost);
                _context.SaveChanges();
            }
            if(newWork.PaidAmount != 0)
            {
                var payment = new Payment
                {
                    PaymentDate = newWork.WorkAsignDate,
                    PaymentWorkID = st.WorkId,
                    PaymentAmount = newWork.PaidAmount
                };
                _context.Add(payment);
                _context.SaveChanges();
            }
           

            
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
                                   ProductCode=product.ProductCode,
                                   Product = product.ProductTittle,
                                   WorkAsignDate = nwork.WorkAsignDate,
                                   WorkType = costmape.OperationType,
                                   PerUnitCost = nwork.PerUnitCost,
                                   Quantity = nwork.Quantity,
                                   EDD = nwork.EDD,
                                   DeliveryQty = nwork.DeliveryQty,
                                   WasteQty=nwork.WasteLostQty,
                                   PaidAmount = nwork.PaidAmount,
                                   WorkStatus = nwork.WorkStatus

                               }).FirstOrDefault();

            //Gathering payment info
            var SelPayInfo = _context.Payments.Where(x => x.PaymentWorkID == id).ToList();
            var SelWorkTxninfo = _context.ProductWorkRegisters.Where(x => x.RegWorkID == id).ToList();

            ViewData["PayList"] = SelPayInfo;
            ViewData["ProdReg"] = SelWorkTxninfo;
            return View(workdetails);
        }

        public IActionResult WorkManage(int id)
        {
            var SelWork = _context.NewWorks.Where(x => x.WorkId == id).FirstOrDefault();
            SelWork.WorkTypeTitle = _context.CostMaps.Where(x => x.CostMapId == SelWork.WorkType).FirstOrDefault().OperationType;
            SelWork.WrokerName = _context.Workers.Where(x => x.WorkerId == SelWork.Wroker).FirstOrDefault().WorkerName;
            SelWork.ProductName = _context.Products.Where(x => x.Id == SelWork.Product).FirstOrDefault().ProductTittle;
            SelWork.NewDeliveryQty = 0;
            SelWork.NewWasterQty = 0;
            SelWork.NewPayment = 0;
            SelWork.TxnDate = System.DateTime.Now;
            SelWork.Product = _context.Products.Where(x => x.Id == SelWork.Product).FirstOrDefault().Id;
            return View(SelWork);
        }

        [HttpPost]
        public IActionResult WorkManage(NewWork newWork)
        {
            var wrkmng = _context.NewWorks.Where(x => x.WorkId == newWork.WorkId).FirstOrDefault();

            //validation
            if(newWork.NewDeliveryQty<1 && newWork.NewWasterQty < 1 && newWork.NewPayment<1)
            {
                _toastNotification.AddErrorToastMessage("Please specify delivery/waste quantity or payment to proceed");
                return View(newWork);
            }
                       
            decimal FinalQty = wrkmng.DeliveryQty + wrkmng.WasteLostQty + newWork.NewDeliveryQty + newWork.NewWasterQty;
            if (FinalQty > wrkmng.Quantity)
            {
                _toastNotification.AddErrorToastMessage("Invalid quanity specified");
                return View(newWork);
            }
            //end of validation


            //update in work table
            wrkmng.DeliveryQty = wrkmng.DeliveryQty + newWork.NewDeliveryQty;
            wrkmng.WasteLostQty = wrkmng.WasteLostQty + newWork.NewWasterQty;
            wrkmng.PaidAmount = wrkmng.PaidAmount + newWork.NewPayment;
            if(wrkmng.Quantity == FinalQty && wrkmng.Payment <= wrkmng.PaidAmount)
            {
                wrkmng.WorkStatus = "Delivered";
            }
            else if (wrkmng.Quantity == FinalQty )
            {
                wrkmng.WorkStatus = "DeliveredWithDuePayment";
            }
            _context.Update(wrkmng);
            _context.SaveChanges();


            //add row in product register-- New delivery qty
            if (newWork.NewDeliveryQty > 0)
            {
                var pwr = new ProductWorkRegister
                {
                    RegAsignDate = newWork.TxnDate,
                    RegWorkID = newWork.WorkId,
                    RegType = "In",
                    RegCategoryQty = newWork.NewDeliveryQty,
                    MoveStatus = "Receipt"
                };
                var addqty = _context.Products.Where(x => x.Id == newWork.Product).FirstOrDefault();
                addqty.RemainingQty = addqty.RemainingQty + newWork.NewDeliveryQty;
                _context.Update(addqty);
                _context.Add(pwr);
                _context.SaveChanges();

                //incase of receipt of product

            }
            //add row in product register-- New delivery qty


            //add row in product register-- New waste qty
            if (newWork.NewWasterQty > 0)
            {
                var pwr = new ProductWorkRegister
                {
                    RegAsignDate = newWork.TxnDate,
                    RegWorkID = newWork.WorkId,
                    RegType = "In",
                    RegCategoryQty = newWork.NewWasterQty,
                    MoveStatus = "Damaged"
                };
                _context.Add(pwr);
                _context.SaveChanges();
            }


          
            //add row in product register-- New waste qty

            if (newWork.NewPayment > 0)
            {
                var payment = new Payment
                {
                    PaymentWorkID = newWork.WorkId,
                    PaymentDate = newWork.TxnDate,
                    PaymentAmount = newWork.NewPayment
                };
                _context.Add(payment);
                _context.SaveChanges();
            }

            _toastNotification.AddSuccessToastMessage("Work management data stored");
            return RedirectToAction("WorkIndex");
        }



        //only payment
        public IActionResult PaymentManage(int id)
        {
            var SelWork = _context.NewWorks.Where(x => x.WorkId == id).FirstOrDefault();
            SelWork.WorkTypeTitle = _context.CostMaps.Where(x => x.CostMapId == SelWork.WorkType).FirstOrDefault().OperationType;
            SelWork.WrokerName = _context.Workers.Where(x => x.WorkerId == SelWork.Wroker).FirstOrDefault().WorkerName;
            SelWork.ProductName = _context.Products.Where(x => x.Id == SelWork.Product).FirstOrDefault().ProductTittle;
            SelWork.NewDeliveryQty = 0;
            SelWork.NewWasterQty = 0;
            SelWork.NewPayment = 0;
            SelWork.TxnDate = System.DateTime.Now;
            return View(SelWork);
        }

        [HttpPost]
        public IActionResult PaymentManage(NewWork newWork)
        {
            var wrkmng = _context.NewWorks.Where(x => x.WorkId == newWork.WorkId).FirstOrDefault();

            //validation
            if (newWork.NewDeliveryQty < 1 && newWork.NewWasterQty < 1 && newWork.NewPayment < 1)
            {
                _toastNotification.AddErrorToastMessage("Please specify delivery/waste quantity or payment to proceed");
                return View(newWork);
            }

            decimal FinalQty = wrkmng.DeliveryQty + wrkmng.WasteLostQty + newWork.NewDeliveryQty + newWork.NewWasterQty;
            if (FinalQty > wrkmng.Quantity)
            {
                _toastNotification.AddErrorToastMessage("Invalid quanity specified");
                return View(newWork);
            }
            //end of validation


            //update in work table
            wrkmng.DeliveryQty = wrkmng.DeliveryQty + newWork.NewDeliveryQty;
            wrkmng.WasteLostQty = wrkmng.WasteLostQty + newWork.NewWasterQty;
            wrkmng.PaidAmount = wrkmng.PaidAmount + newWork.NewPayment;
            if (wrkmng.Quantity == FinalQty && wrkmng.Payment <= wrkmng.PaidAmount)
            {
                wrkmng.WorkStatus = "Delivered";
            }
            else if (wrkmng.Quantity == FinalQty)
            {
                wrkmng.WorkStatus = "DeliveredWithDuePayment";
            }
            _context.Update(wrkmng);
            _context.SaveChanges();


            //add row in product register-- New delivery qty
            if (newWork.NewDeliveryQty > 0)
            {
                var pwr = new ProductWorkRegister
                {
                    RegAsignDate = newWork.TxnDate,
                    RegWorkID = newWork.WorkId,
                    RegType = "In",
                    RegCategoryQty = newWork.NewDeliveryQty,
                    MoveStatus = "Receipt"
                };
                _context.Add(pwr);
                _context.SaveChanges();

                //incase of receipt of product

            }
            //add row in product register-- New delivery qty


            //add row in product register-- New waste qty
            if (newWork.NewWasterQty > 0)
            {
                var pwr = new ProductWorkRegister
                {
                    RegAsignDate = newWork.TxnDate,
                    RegWorkID = newWork.WorkId,
                    RegType = "In",
                    RegCategoryQty = newWork.NewWasterQty,
                    MoveStatus = "Damaged"
                };
                _context.Add(pwr);
                _context.SaveChanges();
            }
            //add row in product register-- New waste qty

            if (newWork.NewPayment > 0)
            {
                var payment = new Payment
                {
                    PaymentWorkID = newWork.WorkId,
                    PaymentDate = newWork.TxnDate,
                    PaymentAmount = newWork.NewPayment
                };
                _context.Add(payment);
                _context.SaveChanges();
            }

            _toastNotification.AddSuccessToastMessage("Payment data stored");
            return RedirectToAction("PaymentNotClearWorkIndex");
        }
    }
}
