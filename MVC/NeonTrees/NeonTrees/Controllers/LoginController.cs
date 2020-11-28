using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NeonTrees.Interface;
using NeonTrees.Models;
using NeonTrees.Services;

namespace NeonTrees.Controllers
{
    public class LoginController : Controller
    {
        ILoginService loginService;

        public LoginController(ILoginService _loginService)
        {
            loginService = _loginService;
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
            loginService.AddLogin(login);
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
    }
}
