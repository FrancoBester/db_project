using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonTrees.Interface;
using NeonTrees.Models;
using NeonTrees.Services;

namespace NeonTrees.Controllers
{
    public class LoginController : Controller
    {
        ILoginService loginService;
        ICustomerService customerService;

        public LoginController(ILoginService _loginService,ICustomerService _customerService)
        {
            loginService = _loginService;
            customerService = _customerService;
        }

        //public IActionResult Index(string username)
        //{
        //    Login login = loginService.GetLoginByUser(username);
        //    return View(login);
        //}

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Login login)
        {
            int value = (int)HttpContext.Session.GetInt32("new_customer_id");
            login.CustomerID = value;
            loginService.AddLogin(login);
            int login_id = loginService.GetNewLoginId(login);
            UpdateCustomerInfo(value, login_id);
            return RedirectToAction();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login login)
        {
            bool validLogin = loginService.GetLoginByUser(login);
            return View();
        }

        public void UpdateCustomerInfo(int customerID,int loginID)
        {
            Customer customer = customerService.GetCustomerById(customerID);
            customer.LoginID = loginID;
            customerService.EditCustomer(customer);

        }
    }
}
