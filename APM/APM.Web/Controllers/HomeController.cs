﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APM.Web.Models;
using APM.Web.Interfaces;

namespace APM.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiRepository _apiRepository;

        public HomeController(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
