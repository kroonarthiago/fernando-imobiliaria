﻿using RealState.Helper;
using RealState.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealState.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            var property = new RealStateService.Property();
            return View(property.MostRecent(3));

        }
    }
}