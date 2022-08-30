using Microsoft.AspNetCore.Mvc;
using PurityERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Controllers
{
    [Area("Management")]

    public class QrCodesController : Controller
    {
        private readonly DataContext _context;
        private string code;

        public QrCodesController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PDeleteQr(int data)
        {
            var Qrs = _context.QRs.Where(x => x.QrCategory == "Product").ToList();
            _context.RemoveRange(Qrs);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult INDeleteQr(int data)
        {
            var Qrs = _context.QRs.Where(x => x.QrCategory == "Inventory").ToList();
            _context.RemoveRange(Qrs);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PDQRcode()
        {
            return View();
        }
    }
}
