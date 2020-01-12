using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QuickMaster.Controllers
{
    using Models;
    public class HelloController : Controller
    {
        private readonly MyContext _context; 
        public HelloController(MyContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return Content("hello world!!!");
        }

        public IActionResult Greet()
        {
            ViewBag.Message = "こんにちは世界！";

            return View();
        }

        public IActionResult List()
        {
            return View(_context.Books);
        }

    }
}