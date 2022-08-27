using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Controllers
{
    [Area("Management")]
    public class QrCodesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PDQRcode()
        {
            return View();
        }
    }
}
