using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonTrees.Interface;
using NeonTrees.Models;
using System.ComponentModel.DataAnnotations;

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
            var user_id = HttpContext.Session.GetInt32("UserID");
            int id_user;
            if (int.TryParse(user_id.ToString(), out id_user))
            {
                return RedirectToAction("Edit", "Customer", new { id = id_user });
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ValidPhone(customer.Phone))
            {
                if (ValidEmail(customer.Email))
                {
                    if (customerService.UniqueData(customer))
                    {
                        customerService.AddCustomer(customer);
                        int id = customerService.GetNewCustomerID(customer);
                        if (id == -1)
                        {
                            ViewBag.Message = "An error occurred. Please try again";
                            return View();
                        }
                        else
                        {
                            HttpContext.Session.SetInt32("new_customer_id", id);
                            return RedirectToAction("Create", "Login");
                        }
                    }
                    else
                    {
                        ViewBag.Message = "Phone number and email address are not valid";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Message = "Email format is incorrect";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Phone number is invalid";
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            Customer customer = customerService.GetCustomerById(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ValidPhone(customer.Phone))
            {
                if (ValidEmail(customer.Email))
                {
                    if (customerService.UniqueData(customer))
                    {
                        customerService.EditCustomer(customer);
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Message = "Invalid email or phone number";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Message = "Email format is incorrect";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Phone number is invalid";
                return View();
            }
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

        public bool ValidEmail(string email)
        { 
            return new EmailAddressAttribute().IsValid(email);
        }

        public bool ValidPhone(string number)
        {
            bool isValid = false;
            if(number.Length == 10)
            {
                int temp;
                if(int.TryParse(number, out temp))
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
}
