using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonTrees.Interface;
using NeonTrees.Models;

namespace NeonTrees.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerService customerService;

        public CustomerController(ICustomerService _customerService)
        {
            customerService = _customerService;
        }

        public IActionResult Index()
        {
            IEnumerable<Customer> customer = customerService.GetAllCustomer();
            return View(customer);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (customerService.UniqueData(customer))
            {
                customerService.AddCustomer(customer);
                int id = customerService.GetNewCustomerID(customer);
                if (id == -1)
                {
                    return RedirectToAction("Login", "Login");
                }
                else
                {
                    HttpContext.Session.SetInt32("new_customer_id", id);
                    return RedirectToAction("Create", "Login");
                }
            }
            return RedirectToAction("Create", "Login");
        }

        public ActionResult Edit(int id)
        {
            Customer customer = customerService.GetCustomerById(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (customerService.UniqueData(customer))
            {
                customerService.EditCustomer(customer);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Message = string.Format("Test1");
            return View(customer);
        }

        public ActionResult Delete(int id)
        {
            Customer customer = customerService.GetCustomerById(id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            customerService.DeleteCustomer(customer);
            return RedirectToAction(nameof(Index));
        }
    }
}
