﻿using MetaShop.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MetaShop.Web.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("~/")]
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}