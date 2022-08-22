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
    public class AdminController : Controller
    {
        private readonly DataContext _context;
        public AdminController(DataContext context)
        {
            _context = context;
        }
        public IActionResult UserIndex()
        {
            var users = (from user in _context.Users.ToList()
                         join userty in _context.UserTypes
                         on user.UserTypeID equals userty.UserTypeID
                         select new MenuVM
                         {
                             UserID = user.UserID,
                             UserName = user.UserName,
                             UserPass = user.PassWord,
                             UserTypeName = userty.UserTypeName
                         }).ToList();
            return View(users);
        } 
        public IActionResult CreateUser()
        {
            ViewBag.usertype = _context.UserTypes.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(Users users)
        {
            _context.Add(users);
            _context.SaveChanges();
            return RedirectToAction("UserIndex");
        }

        //tt
    }
}
