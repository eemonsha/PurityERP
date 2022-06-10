using Microsoft.AspNetCore.Http;
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
    public class InventoryController : Controller
    {
        private readonly DataContext _context;
        public InventoryController(DataContext context)
        {
            _context = context;
        }
        public IActionResult InventoryIndex()
        {
            var inv = _context.Inventories.ToList();
            return View(inv);
        }

        public IActionResult InventoryCreate()
        {
            var inven = _context.Inventories.ToList();
            var max = "";
            if (inven.Count == 0)
            {
                max = "1";
            }
            else
            {
                max = (inven.Count + 1).ToString();
            }
            var userid = HttpContext.Session.GetString("Id");
            var code = "Purity-" + DateTime.Now.Year + "/U-" + userid + "/"+ max;
            ViewBag.code = code;
            ViewBag.units = _context.units.ToList();
            ViewBag.supplier = _context.Suppliers.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult InventoryCreate(Inventory inventory)
        {
            
            _context.Inventories.Add(inventory);
            _context.SaveChanges();
            return RedirectToAction("InventoryIndex");
        }

        public IActionResult EditInventory(int id)
        {
            ViewBag.units = _context.units.ToList();
            ViewBag.supplier = _context.Suppliers.ToList();
            var edit = _context.Inventories.Where(x => x.Id == id).FirstOrDefault();
            return View(edit);
        }
        [HttpPost]
        public IActionResult EditInventory(Inventory inventory)
        {

            _context.Update(inventory);
            _context.SaveChanges();
            return RedirectToAction("InventoryIndex");
        }

        public IActionResult DetailsInventory(int id)
        {
            var inven = (from inventory in _context.Inventories.Where(x => x.Id == id)
                         join Supplier in _context.Suppliers
                         on inventory.SupplierId equals Supplier.SupplierId
                         join Unit in _context.units
                         on inventory.UnidId equals Unit.UnitID
                         select new ManagementVm
                         {
                             InventoryId= inventory.Id,
                             SupplierName = Supplier.SupplierName,
                             Code = inventory.Code,
                             Tittle = inventory.Tittle,
                             PurchaseDate = inventory.PurchaseDate,
                             UnitID = Unit.UnitID,
                             UnitName=Unit.UnitName,
                             PurchaseQuantity = inventory.PurchaseQuantity,
                             UnitPrice = inventory.UnitPrice,
                             SupplierId = Supplier.SupplierId,
                             RemainingQty = inventory.RemainingQty

                         }).FirstOrDefault();
            
            return View(inven);
        }

        public JsonResult UnitCreate(string Unitname)
        {
            var inventory = new Units
            {
                UnitName = Unitname
            };
            _context.Add(inventory);
            _context.SaveChanges();
            var allunits = _context.units.OrderByDescending(x => x.UnitID).ToList();
            return Json(allunits);
        }
        public IActionResult InventoryOutIndex()
        {
            var invenoutl = from inveout in _context.InventoryOuts
                            join inven in _context.Inventories
                            on inveout.InventoryItem equals inven.Id
                            join product in _context.Products
                            on inveout.ProductTittle equals product.Id
                            join worer in _context.Workers
                            on Convert.ToInt32(inveout.Worker) equals worer.WorkerId

                            select new ManagementVm
                            {
                                Tittle = inven.Tittle,
                                SystemDate = inveout.SystemDate,
                                ProductTittle = product.ProductTittle,
                                ProductQuantity = inveout.ProductQuantity,
                                InventoryQuantity = inveout.InventoryQuantity,
                                Worker = worer.WorkerName
                                
                            };
            return View(invenoutl);
        }

        public IActionResult InventoryOutCreate()
        {
            ViewBag.inventories = _context.Inventories.ToList();
            ViewBag.product = _context.Products.ToList();
            ViewBag.worker = _context.Workers.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult InventoryOutCreate(InventoryOut inventoryout )
        {
            var invenout = new InventoryOut
            {
                InventoryItem = inventoryout.InventoryItem,
                SystemDate = DateTime.Now,
                ProductTittle = inventoryout.ProductTittle,
                ProductQuantity = inventoryout.ProductQuantity,
                InventoryQuantity = inventoryout.InventoryQuantity,
                Worker = inventoryout.Worker
            };
            Inventory inventory = _context.Inventories.Where(x=>x.Id == inventoryout.InventoryItem).FirstOrDefault();
            var finalremain = inventory.RemainingQty - inventoryout.InventoryQuantity;
            inventory.RemainingQty = finalremain;
            _context.Inventories.Update(inventory);
            _context.InventoryOuts.Add(invenout);
            _context.SaveChanges();
            return RedirectToAction("InventoryOutIndex");
        }

        //public IActionResult InventoryOutDetails(int id)
        //{
        //    var iout = (from InventoryOut in _context.InventoryOuts.Where(x => x.Id == id)
        //                join Inventory in _context.Inventories
        //                on InventoryOut.InventoryItem equals Inventory.Id
        //                join Product in _context.Products
        //                on InventoryOut.ProductTittle equals Product.Id
        //                join Worker in _context.Workers
        //                on InventoryOut.Worker equals Worker.WorkerId
        //                select new ManagementVm
        //                { 
        //                 })

        //    return View();
        //    //var inven = (from inventory in _context.Inventories.Where(x => x.Id == id)
        //    //             join Supplier in _context.Suppliers
        //    //             on inventory.SupplierId equals Supplier.SupplierId
        //    //             join Unit in _context.units
        //    //             on inventory.UnidId equals Unit.UnitID
        //    //             select new ManagementVm
        //    //             {
        //    //                 ////InventoryId = inventory.Id,
        //    //                 ////SupplierName = Supplier.SupplierName,
        //    //                 ////Code = inventory.Code,
        //    //                 ////Tittle = inventory.Tittle,
        //    //                 ////PurchaseDate = inventory.PurchaseDate,
        //    //                 ////UnitID = Unit.UnitID,
        //    //                 ////UnitName = Unit.UnitName,
        //    //                 ////PurchaseQuantity = inventory.PurchaseQuantity,
        //    //                 ////UnitPrice = inventory.UnitPrice,
        //    //                 ////SupplierId = Supplier.SupplierId,
        //    //                 ////RemainingQty = inventory.RemainingQty

        //    //             }).FirstOrDefault();

        //    //return View(inven);
        //}

        public IActionResult ProductIndex()
        {
            var pro = _context.Products.ToList();
            return View(pro);
        }

        public IActionResult Productcreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Productcreate(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("ProductIndex");
        }


        public IActionResult EditProduct(int id)
        {

            var edit = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            return View(edit);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {

            _context.Update(product);
            _context.SaveChanges();
            return RedirectToAction("ProductIndex");
        }

        public IActionResult ProductDetails(int id)
        {
            var sql = (from product in _context.Products.Where(x => x.Id == id)
                       select new ManagementVm
                       {
                           ProductTittle = product.ProductTittle,
                           CostingPrice = product.CostingPrice,
                           SalesPrice = product.SalesPrice,
                           DiscountRate = product.DiscountRate,
                           InitialProductStockQty = product.InitialProductStockQty,
                           RemainingQty = product.RemainingQty,
                           pId = product.Id
                           
                       }).FirstOrDefault();
            return View(sql);
            
        }


        public JsonResult inventoryqty(int invenid)
        {
            var remainqty = _context.Inventories.FirstOrDefault(x => x.Id == invenid).RemainingQty; 
            return Json(remainqty);
        }
        public JsonResult SupplierCreate(Suppliers data)
        {
            _context.Suppliers.Add(data);
            _context.SaveChanges();
            var supplier = _context.Suppliers.OrderByDescending(x => x.SupplierId).ToList();
            return Json(supplier);
        }
    }
}
