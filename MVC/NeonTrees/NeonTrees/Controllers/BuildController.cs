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
    public class BuildController : Controller
    {
        IBuildService buildService;

        public BuildController(IBuildService _buildService)
        {
            buildService = _buildService;
        }

        public IActionResult Index()
        {
            var user_id = HttpContext.Session.GetInt32("UserID");
            int id_user;
            if (int.TryParse(user_id.ToString(), out id_user))
            {
                IEnumerable<Build> build = buildService.GetAllUserBuilds(id_user);
                return View(build);   
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
        public ActionResult Create(Build build)
        {
            buildService.AddBuild(build);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            Build build = buildService.GetBuildById(id);
            return View(build);
        }

        [HttpPost]
        public ActionResult Edit(Build build)
        {
            buildService.EditBuild(build);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            Build build = buildService.GetBuildById(id);
            return View(build);
        }

        [HttpPost]
        public ActionResult Delete(Build build)
        {
            buildService.DeleteBuild(build);
            return RedirectToAction(nameof(Index));
        }
    }
}
