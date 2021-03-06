using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SlackOverload.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SlackOverload.Controllers
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
        public IActionResult LoginForm(string error)
        {
            return View(error);
        }
        [HttpPost]
        public IActionResult Login(string username)
        {
            DAL.CurrentUser = username;
            if(DAL.CurrentUser != null)
            {
                DAL.loginerror = null;
            }
            return RedirectToAction("index");
        }
        public IActionResult Logout()
        {
            DAL.CurrentUser = null;
            return RedirectToAction("index");
        }
        [HttpPost]
        public IActionResult Search(string qSearch)
        {
            Home.qSearch = qSearch;
            string search = Request.Form["qSearch"].First();
            List<questions> q = DAL.GetTaggedQ();
            return View(q);
        }
    }
}
