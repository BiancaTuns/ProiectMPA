using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProdusApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProdusApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();

        }

        public IActionResult Despre()
        {
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }
        
    }
}
