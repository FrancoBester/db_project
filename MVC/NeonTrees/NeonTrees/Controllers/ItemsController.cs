using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NeonTrees.Interface;
using NeonTrees.Models;
using NeonTrees.Services;

namespace NeonTrees.Controllers
{
    public class ItemsController : Controller
    {
        IProductService productService;
        IBuildService buildService;
        bool created;

        public ItemsController(IProductService _productService, IBuildService _buildService)
        {
            productService = _productService;
            buildService = _buildService;
        }


        public IActionResult Index(string sortOrder, string currentFilter, string searchString)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.CurrentFilter = currentFilter;
            ViewBag.Item = String.IsNullOrEmpty(sortOrder) ? "CPU" : "";
            ViewBag.Selected = "";
            IEnumerable<Product> product;
            if (String.IsNullOrEmpty(sortOrder))
            {
                product = productService.FilterProduct("CPU");
            }
            else
            {
                product = productService.FilterProduct(sortOrder);
            }

            product = from s in product
                      select s;
            if (searchString != null)
            {
                product = product.Where(s => s.Name == (searchString));
            }

            ViewBag.CurreFilter = searchString;

            switch (sortOrder)
            {
                default:
                case "CPU":
                    product = product.Where(s => s.PartType.Contains("CPU"));
                    break;
                case "Case":
                    product = product.Where(s => s.PartType.Contains("Case"));
                    break;
                case "GPU":
                    product = product.Where(s => s.PartType.Contains("GPU"));
                    break;
                case "Motherboard":
                    product = product.Where(s => s.PartType.Contains("Motherboard"));
                    break;
                case "Ram":
                    product = product.Where(s => s.PartType.Contains("Ram"));
                    break;
                case "Storage":
                    product = product.Where(s => s.PartType.Contains("Storage"));
                    break;
                case "Chair":
                    product = product.Where(s => s.PartType.Contains("Chair"));
                    break;
                case "MousePad":
                    product = product.Where(s => s.PartType.Contains("MousePad"));
                    break;
                case "Headset":
                    product = product.Where(s => s.PartType.Contains("Headset"));
                    break;
                case "Gaming Combo":
                    product = product.Where(s => s.PartType.Contains("Gaming Combo"));
                    break;
                case "Wrist Rest":
                    product = product.Where(s => s.PartType.Contains("Wrist Rest"));
                    break;
                case "Network Cable":
                    product = product.Where(s => s.PartType.Contains("Network Cable"));
                    break;
                case "Switch":
                    product = product.Where(s => s.PartType.Contains("Switch"));
                    break;
                case "Workstation":
                    product = product.Where(s => s.PartType.Contains("Workstation"));
                    break;
                case "UpgradeKit":
                    product = product.Where(s => s.PartType.Contains("UpgradeKit"));
                    break;
                case "Speakers":
                    product = product.Where(s => s.PartType.Contains("Speakers"));
                    break;
                case "Adapter":
                    product = product.Where(s => s.PartType.Contains("Adapter"));
                    break;
                case "Mouse":
                    product = product.Where(s => s.PartType.Contains("Mouse"));
                    break;
                case "Keycap":
                    product = product.Where(s => s.PartType.Contains("Keycap"));
                    break;
                case "NVLink":
                    product = product.Where(s => s.PartType.Contains("NVLink"));
                    break;
                case "Mouse Keyboard combo":
                    product = product.Where(s => s.PartType.Contains("Mouse Keyboard combo"));
                    break;
                case "Keyboard":
                    product = product.Where(s => s.PartType.Contains("Keyboard"));
                    break;
            }
            return View(product);
        }

        public ActionResult AddItem(Product product)
        {
            if (created)
            {
                int id = int.Parse(product.ID);
                // buildService.AddItem(id);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                //buildService.AddBuild(product);
                return RedirectToAction(nameof(Index));
            }

        }
        public ActionResult Edit(int id)
        {
            try
            {
                var id_build = HttpContext.Session.GetInt32("BuildID");
                int build_id = int.Parse(id_build.ToString());

                Build build = buildService.GetBuildById(build_id);
                if (build.ProductIDs == "")
                {
                    build.ProductIDs = build.ProductIDs + id.ToString();
                }
                else
                {
                    build.ProductIDs = build.ProductIDs + "," + id.ToString();
                }

                buildService.EditBuild(build);

                return RedirectToAction("Index", "Items");
            }
            catch
            {
                return RedirectToAction("Login", "Login");
            }
        }

        public ActionResult Update(int productID)
        {
            var id_build = HttpContext.Session.GetInt32("BuildID");
            int build_id = int.Parse(id_build.ToString());

            Build build = buildService.GetBuildById(build_id);
            build.ProductIDs = build.ProductIDs + "," + productID.ToString();

            buildService.EditBuild(build);

            return RedirectToAction("Index", "Items");
        }
    }
}
