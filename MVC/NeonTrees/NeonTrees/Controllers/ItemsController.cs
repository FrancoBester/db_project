using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NeonTrees.Models;

namespace NeonTrees.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ILogger<ItemsController> _logger;

        public ItemsController(ILogger<ItemsController> logger)
        {
           // var test = HttpContext.Session.GetString("test");
            _logger = logger;
        }

        public IActionResult Case()
        {
           
            return View();
        }

        public IActionResult Cooler()
        {
            return View();
        }

        public IActionResult Cpu()
        {
            //var test = HttpContext.Current.Session
            return View();
        }
        public IActionResult Gpu()
        {
            var test = HttpContext.Session.GetString("test");
            return View();
        }
        public IActionResult Hdd()
        {
            return View();
        }
        public IActionResult Mother()
        {
            return View();
        }
        public IActionResult Psu()
        {
            return View();
        }
        public IActionResult Ram()
        {
            return View();
        }
        public IActionResult Ssd()
        {
            return View();
        }

    }
}
