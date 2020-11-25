using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;
using WebApplication1.Services;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        IUserService userService;
        public UsersController(IUserService _userService)
        {
            userService = _userService;
        }

        public IActionResult Index()
        {
           var user = userService.GetAllUsers();
            return View(user);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            userService.AddUser(user);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit(int id)
        {
            User user = userService.GetUserById(id);
            return View(user);
        }
        [HttpPost]
        public ActionResult Edit(User user)
        {
            userService.EditUser(user);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Delete(int id)
        {
            User user = userService.GetUserById(id);
            return View(user);
        }
        [HttpPost]
        public ActionResult Delete(User user)
        {
            userService.DeleteUser(user);
            return RedirectToAction(nameof(Index));
        }
    }
}
