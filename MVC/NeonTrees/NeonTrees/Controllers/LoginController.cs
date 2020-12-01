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

        public LoginController(ILoginService _loginService, ICustomerService _customerService)
        {
            loginService = _loginService;
            customerService = _customerService;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Login login)
        {
            if (loginService.CheckUserName(login))
            {
                if (ValidPassword(login.Password))
                {
                    int value = (int)HttpContext.Session.GetInt32("new_customer_id");
                    login.CustomerID = value;
                    loginService.AddLogin(login);
                    int login_id = loginService.GetNewLoginId(login);
                    UpdateCustomerInfo(value, login_id);
                    HttpContext.Session.SetInt32("UserID", value);
                    return RedirectToAction("Index", "Build");
                }
                else
                {
                    ViewBag.Message = "Password invalid";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Username already taken";
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (!loginService.CheckUserName(login))
            {
                if (loginService.CheckPassward(login))
                {
                    int user_id = loginService.GetUserID(login);
                    HttpContext.Session.SetInt32("UserID", user_id);
                    return RedirectToAction("Index", "Build");
                }
                else
                {
                    ViewBag.Message = "Username and password are not valid";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Username and password are not valid";
                return View();
            }

        }

        public void UpdateCustomerInfo(int customerID, int loginID)
        {
            Customer customer = customerService.GetCustomerById(customerID);
            customer.LoginID = loginID;
            customerService.EditCustomer(customer);
        }

        public bool ValidPassword(string password)
        {
            bool isValid = false;
            if (password.Length >= 8)
            {
                if (password.Any(char.IsUpper))
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(password, "[^a - zA - Z0 - 9]"))
                    {
                        isValid = true;
                    }
                }
            }

            return isValid;
        }
    }
}
