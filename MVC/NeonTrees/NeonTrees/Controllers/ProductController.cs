using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NeonTrees.Interface;
using NeonTrees.Models;

namespace NeonTrees.Controllers
{
    public class ProductController : Controller
    {
        IProductService productService;

        public class Addr
        {
            public string ID { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public string InventoryValue { get; set; }

            public string PartType { get; set; }

            public string URL { get; set; }
        }

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> product = productService.GetAllProduct();
            return View(product);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            productService.AddProduct(product); 
            return RedirectToAction(nameof(Create));
        }

        [HttpPost]
        public ActionResult Creater(Product product)
        {
            productService.AddProduct(product);
            return RedirectToAction(nameof(Create));
        }


        [HttpPost]
        public ActionResult ImportJSON(string[] data)
        {            
            productService.AddProductJ(data);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            Product product = productService.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productService.EditProduct(product);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            Product product = productService.GetProductById(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Delete(Product product)
        {
            productService.DeleteProduct(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
