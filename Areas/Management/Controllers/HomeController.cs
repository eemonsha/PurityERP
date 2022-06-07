using Microsoft.AspNetCore.Mvc;
using PurityERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Controllers
{
    [Area("Management")]
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            TempData["msg"] = "null";
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Username,string Password)
        {
            var user = _context.Users.Where(x => x.UserName == Username && x.PassWord == Password).FirstOrDefault();
            if(user != null)
            {
                if(user.UserType == "Admin")
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["msg"] = "Wrong ID or Password";
                return View();
            }
            
        }


    }
}
