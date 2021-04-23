using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyfirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyfirstMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Shippingpage()
        {
            string name = "Batz";
            int age = 23;

            string address = "Cebu";

            ViewData["name"] = name;
            ViewData["age"] = age;

            ViewBag.Address = address;


            return View();
        }

        public Guid getUID()
        {
            return Guid.NewGuid();
        }

        public string HelloWorld()
        {
            return "Hello";
        }
    }
}
