﻿using System;
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
                if (id_user == -1)
                {
                    return RedirectToAction("Login", "Login");
                }
                else
                {
                    IEnumerable<Build> build = buildService.GetAllUserBuilds(id_user);
                    return View(build);
                }
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
            var id_user = HttpContext.Session.GetInt32("UserID");

            build.CustomerID = int.Parse(id_user.ToString());
            build.Date = DateTime.Now.Date;
            build.Total = 0.0;
            build.ProductIDs = "";


            buildService.AddBuild(build);
            HttpContext.Session.SetInt32("BuildID", buildService.GetBuildId(build));
            return RedirectToAction("Index", "Items");
        }

        public ActionResult Edit(int id)
        {
            HttpContext.Session.SetInt32("BuildID", id);
            return RedirectToAction("Index", "Items");
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

        public ActionResult View(int id)
        {
            Build build = buildService.GetBuildById(id);
            string product_ids = build.ProductIDs;
            HttpContext.Session.SetString("IdsProduct",product_ids);
            return RedirectToAction("ViewProducts","Items");
        }
    }
}
