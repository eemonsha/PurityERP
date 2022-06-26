using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PurityERP.Areas.Management.Models;
using PurityERP.Areas.Management.ViewModel;
using PurityERP.Data;
using PurityERP.SessionExtention;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

       

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult Login(string Username,string Password)
        {
            var user = _context.Users.Where(x => x.UserName == Username && x.PassWord == Password).FirstOrDefault();
            if(user != null)
            {
                HttpContext.Session.SetInt32("UserTypeId", user.UserTypeID);
                HttpContext.Session.SetInt32("UserId", user.UserID);
                var menu = _context.Menus.ToList();
                //List<MenuVM> submenus = new List<MenuVM>();
                var submm = _context.RolebasedMenus.Where(x => x.UserID == 0).ToList();
                List<MenuVM> submenus = (from rbm in _context.RolebasedMenus.Where(x => x.UserID == user.UserID).ToList()
                                         join sub in _context.SubMenus.ToList()
                                         on rbm.SubMenuID equals sub.SubMenuID
                                         join menus in menu
                                         on sub.MainMenuID equals menus.MenuID
                                         select new MenuVM
                                         {
                                             SubManuName = sub.SubManuName,
                                             ManuName = menus.ManuName,
                                             Controller = sub.Controller,
                                             Action = sub.Action
                                         }).ToList();
                HttpContext.Session.Set<List<MenuVM>>("someKey", submenus);

                
                


                return RedirectToAction("Index");
                //if(user.UserType == "Admin")
                //{
                //    HttpContext.Session.SetString("Id", user.UserID.ToString());
                //    //HttpContext.Session.SetString("Type", user.UserType);
                //    return RedirectToAction("Index");
                //}
                //else
                //{
                //    HttpContext.Session.SetString("Id", user.UserID.ToString());
                //    //HttpContext.Session.SetString("Type", user.UserType);
                //    return RedirectToAction("Iindex","");
                //}
            }
            else
            {
                TempData["msg"] = "Wrong ID or Password";
                return View();
            }
            
        }

        public IActionResult CreateMenu()
        {
            
            return View();
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult CreateMenu(Menu menu)
        {
            _context.Add(menu);
            _context.SaveChanges();
            return View();
        }
        public IActionResult CreateSubMenu()
        {






            ViewBag.menus = _context.Menus.ToList();
            return View();
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult CreateSubMenu(MenuVM menuvm)
        {
            var submenu = new SubMenu { 
                SubManuName = menuvm.SubManuName,
                Area = menuvm.Area,
                Controller = menuvm.Controller,
                Action = menuvm.Action,
                MainMenuID = menuvm.MainMenuID
            };

            _context.Add(submenu);
            _context.SaveChanges();
            return View();
        }
        public IActionResult RolePermission()
        {
            
            ViewBag.submenu = _context.SubMenus.ToList();
            ViewBag.user = _context.Users.ToList();
            ViewBag.usertype = _context.UserTypes.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult RolePermission(MenuVM menuvm)
        {
            
            var role = new RolebasedMenu
            {
                SubMenuID = menuvm.SubMenuID,
                UserID = menuvm.UserID,
                UserTypeID = menuvm.UserTypeID,
                ActiveStatus = true
            };
            _context.Add(role);
            _context.SaveChanges();
            return View();
        }
        
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            //HttpContext.Session.Remove();
            return RedirectToAction("Login");
        }


    }
}
