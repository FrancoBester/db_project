using System;
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
            return RedirectToAction(nameof(Index));
        }

        //NO-SQL import
        [HttpPost]
        public ActionResult Creater(string name, string description, string InventoryValue, string Parttype, string url)
        {
            productService.AddProductJ(name, description, InventoryValue, Parttype, url);
            return RedirectToAction(nameof(Create));
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
