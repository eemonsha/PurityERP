﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PurityERP.Areas.Management.Models;
using PurityERP.Areas.Management.ViewModel;
using PurityERP.Data;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Controllers
{
    [Area("Management")]
    public class InventoryController : Controller
    {
        private readonly DataContext _context;
        private string code;

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
            inventory.RemainingQty = inventory.PurchaseQuantity;
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

            //loading inventory consumption information
            var InvTxn = (from TxnInv in _context.InventoryOuts.Where(x => x.InventoryItem == id).ToList()
                          join ProdInfo in _context.Products on TxnInv.ProductTittle equals ProdInfo.Id
                          select new InventoryVM
                          {
                              ProductTitle = ProdInfo.ProductTittle,
                              InvOutDate= TxnInv.SystemDate,
                              InvOutQty= TxnInv.InventoryQuantity,
                              ProdQty= TxnInv.ProductQuantity
                          });

            ViewData["InvTxnInfo"] = InvTxn;

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
                                InventorOutId = inven.Id,
                                Tittle = inven.Tittle,
                                SystemDate = inveout.SystemDate,
                                ProductTittle = product.ProductTittle,
                                ProductQuantity = inveout.ProductQuantity,
                                InventoryQuantity = inveout.InventoryQuantity,
                                PerProductInventoryQuantity= inveout.PerProductInventoryQuantity,
                                Worker = worer.WorkerName
                                
                            };
            return View(invenoutl);
        }

        public IActionResult InventoryOutCreate()
        {
            DefaultData();

            return View();
        }

        private void DefaultData()
        {
            ViewBag.inventories = _context.Inventories.ToList();
            ViewBag.product = _context.Products.ToList();
            ViewBag.worker = _context.Workers.ToList();
        }

        [HttpPost]
        public IActionResult InventoryOutCreate(InventoryOut inventoryout )
        {
            //validation
            if (inventoryout.InventoryQuantity < 0)
            {

                return View(inventoryout);
            }

            //checking if cost type has been added for raw material
            var SelCostType = _context.Costtypes.Where(x => x.CostMapId == 1).FirstOrDefault();
            if (SelCostType == null)
            {
                return View(inventoryout);
            }
            //end of validation


            var perqty = (inventoryout.InventoryQuantity / inventoryout.ProductQuantity);
            var invenout = new InventoryOut
            {
                InventoryItem = inventoryout.InventoryItem,
                SystemDate = DateTime.Now,
                ProductTittle = inventoryout.ProductTittle,
                ProductQuantity = inventoryout.ProductQuantity,
                InventoryQuantity = inventoryout.InventoryQuantity,
                Worker = inventoryout.Worker,
                PerProductInventoryQuantity= perqty
            };
            Inventory inventory = _context.Inventories.Where(x=>x.Id == inventoryout.InventoryItem).FirstOrDefault();
            var finalremain = inventory.RemainingQty - inventoryout.InventoryQuantity;
            inventory.RemainingQty = finalremain;
            _context.Inventories.Update(inventory);
            _context.InventoryOuts.Add(invenout);
            _context.SaveChanges();

            //add data to cost table
            if (inventoryout.InventoryQuantity > 0)// indicates there is cost involved in the work
            {
                decimal SelPerUnitCost = _context.Inventories.Where(x => x.Id == inventoryout.InventoryItem).FirstOrDefault().UnitPrice;

                decimal PerUnitCost = SelPerUnitCost;
                var NewCost = new CostRegister()
                {
                    ProdID = inventoryout.ProductTittle,
                    CostID = SelCostType.CostId,
                    DateofCalculate = System.DateTime.Now,
                    PerUnitCost = PerUnitCost,
                    CostRegID = invenout.Id,
                    CostStatus = "Active"
                };
                _context.Add(NewCost);
                _context.SaveChanges();
            }

            return RedirectToAction("InventoryOutIndex");
        }

        public IActionResult InventoryOutDetails(int id)
        {
            var Invnoutdtls = (from inoutd in _context.InventoryOuts.Where(x => x.Id == id)
                               join inventory in _context.Inventories
                               on inoutd.InventoryItem equals inventory.Id
                               join product in _context.Products
                               on inoutd.ProductTittle equals product.Id
                               join worker in _context.Workers
                               on Convert.ToInt32(inoutd.Worker) equals worker.WorkerId  
                               select new ManagementVm
                               {
                                   
                                   InventorOutId= inoutd.Id,
                                   InventoryItem = inventory.Tittle,
                                   SystemDate = inoutd.SystemDate,
                                   ProductTittle = product.ProductTittle,
                                   ProductQuantity = inoutd.ProductQuantity,
                                   InventoryQuantity = inoutd.InventoryQuantity,
                                   PerProductInventoryQuantity = inoutd.PerProductInventoryQuantity,
                                   Worker = worker.WorkerName,

                               }).FirstOrDefault();


            return View(Invnoutdtls);
        }



    public IActionResult ProductIndex()
    {
            var ProList = _context.Products.Where(x=>x.RemainingQty>0).ToList();
            var viewmodel = new List<ProductVM>();
            var model = new ProductVM();

            foreach (var item in ProList)
            {
                var SelQr = _context.QRs.Where(x => x.QrCategory == "Product" && x.ItemCode == item.Id).FirstOrDefault();
                var QrStatus = "No";
                if (SelQr != null)
                {
                    QrStatus = "Yes";
                }

                model = new ProductVM
                {
                    Id=item.Id,
                    ProductTittle=item.ProductTittle,
                    ProductCode=item.ProductCode,
                    SalesPrice=item.SalesPrice,
                    RemainingQty=item.RemainingQty,
                    QrExists=QrStatus
                };
                viewmodel.Add(model);
            }

            ViewData["products"] = viewmodel;
            return View(viewmodel);
     }



        public IActionResult Productcreate()
        {
            var NewProduct = new Product();
            
            NewProduct.CostingPrice = 0;
            NewProduct.SalesPrice = 0;
            NewProduct.DiscountRate = 0;
            return View(NewProduct);
        }

        [HttpPost]
        public IActionResult Productcreate(Product product)
        {
            var procoe = _context.Products.Where(x => x.ProductCode == product.ProductCode).FirstOrDefault();
            if (procoe == null)
            {
                var salermnqty = new Product();

                salermnqty.InitialProductStockQty = product.InitialProductStockQty;
               
                salermnqty.RemainingQty = salermnqty.InitialProductStockQty;
                salermnqty.ProductCode = product.ProductCode;
                salermnqty.ProductTittle = product.ProductTittle;
                salermnqty.CostingPrice = product.CostingPrice;
                salermnqty.SalesPrice = product.SalesPrice;
                salermnqty.DiscountRate = product.DiscountRate;
                salermnqty.QRId = product.QRId;

                    
                
                _context.Products.Add(salermnqty);

                _context.SaveChanges();
                return RedirectToAction("ProductIndex");
            }
            else
            {
                TempData["msg"] = "Product Code Already Exist";
                return View();
            }
            return View();
        }


        public IActionResult ProductManage(int Id)
        {

            return View();
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
                           ProductCode =product.ProductCode,
                           CostingPrice = product.CostingPrice,
                           SalesPrice = product.SalesPrice,
                           DiscountRate = product.DiscountRate,
                           InitialProductStockQty = product.InitialProductStockQty,
                           RemainingQty = product.RemainingQty,
                           pId = product.Id,
                           
                           
                       }).FirstOrDefault();
            return View(sql);
            
        }

        public ActionResult CreateQr(int ProdID)
        {

            var SelProduct = _context.Products.Where(x => x.Id == ProdID).FirstOrDefault();

            var qrcodestring = Convert.ToString(ProdID);
            int NoofQr =SelProduct.RemainingQty;

            var qrCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qrCodeGenerator.CreateQrCode(qrcodestring, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            Bitmap bitmap = qRCode.GetGraphic(3);
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding.GetEncoding("windows-1252");
            byte[] paramValue = null;
            using (var b = new Bitmap(qRCode.GetGraphic(3)))
            {
                using (var ms = new MemoryStream())
                {
                    b.Save(ms, ImageFormat.Bmp);
                    paramValue = ms.ToArray();
                }
            }

            for(int LoopMoover = 0; LoopMoover < SelProduct.RemainingQty;LoopMoover++)
            {
                var NewQr = new QR()
                {
                    ID=0,
                    ItemCode= ProdID,
                    QrImage= paramValue,
                    ItemName=SelProduct.ProductTittle,
                    PriceAmount=SelProduct.SalesPrice,
                    UserID=1,
                    QrQty=0,
                    QrCategory="Product"
                };
                _context.Add(NewQr);
            }
            _context.SaveChanges();

            return RedirectToAction("ProductIndex");
        }


        public ActionResult DeleteQr(int ProdID)
        {
            var SelQr = _context.QRs.Where(x => x.QrCategory == "Product" && x.ItemCode == ProdID).FirstOrDefault();
            _context.Remove(SelQr);
            _context.SaveChanges();

            return RedirectToAction("ProductIndex");
        }


        private byte[] ConvertBitmapToBytes(Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                // bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }



        public JsonResult inventoryqty(int invenid)
        {
            var remainqty = _context.Inventories.FirstOrDefault(x => x.Id == invenid).RemainingQty; 
            return Json(remainqty);
        }

        public JsonResult GetInvUnit(int invenid)
        {
            int SelUnitId = _context.Inventories.FirstOrDefault(x => x.Id == invenid).UnidId;
            var SelUnitName = _context.units.Where(x => x.UnitID == SelUnitId).FirstOrDefault().UnitName;

            return Json(SelUnitName);
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
