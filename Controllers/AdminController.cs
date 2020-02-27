using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeardShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeardShop.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private AppDbContext db;
        public AdminController(AppDbContext context)
        {
            db = context;
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Orders()
        {
            return View();
        }
    }
}