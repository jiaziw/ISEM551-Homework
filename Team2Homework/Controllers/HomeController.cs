using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team2Homework.Models;

namespace Team2Homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This application is created by Jiazi Wu and Yunzheng Zhang in Team 2";

            return View();
        }

        public IActionResult Members()
        {
            ViewData["Message"] = "Contact method of Team Members";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Assignment()
        {
            ViewData["Message"] = "Description of Harrisburg";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
