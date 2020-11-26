using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            customerService.AddCustomer(customer);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            Customer customer = customerService.GetCustomerById(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            customerService.EditCustomer(customer);
            return RedirectToAction(nameof(Index));
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
