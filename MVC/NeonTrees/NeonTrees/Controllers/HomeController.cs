using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NeonTrees.Models;
using NeonTrees.Interface;

namespace NeonTrees.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService productService;
        private IBuildService buildService;
        private ICustomerService customerService;

        public HomeController(ILogger<HomeController> logger, IProductService _productService, IBuildService _buildsService, ICustomerService _customerService)
        {
            _logger = logger;
            productService = _productService;
            buildService = _buildsService;
            customerService = _customerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Analytics()
        {
            //working - gets total builds between different price ranges
            List<int> count_list_price = buildService.GetBuildPriceData();
            List<string> amount_list = new List<string>();

            string[] price_amounts = { "0 - 5000", "5001 - 10000", "10001 - 15000", "15001 - 20000", "20001 - 25000" };
            amount_list.AddRange(price_amounts);
            var price_info = amount_list;

            ViewBag.PRICE_INFO = price_info;
            ViewBag.PRICEREP = count_list_price.ToList();


            //working - shows amount of pc build per month
            //List<int> count_list_month = buildService.GetBuildPerMonth();
            //List<string> month_list = new List<string>();

            //string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
            //month_list.AddRange(months);
            //var month_info = month_list;

            //ViewBag.MONTH_INFO = month_info;
            //ViewBag.MONTHREP = count_list_month.ToList();

            return View();
        }
    }
}
