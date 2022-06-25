using Microsoft.AspNetCore.Mvc;
using NToastNotify;
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

        public IActionResult SalesIndex()
        {
            return View();
        }
    }
}
