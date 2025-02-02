using System.Diagnostics;
using HotelATR.RealPortal0.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelATR.RealPortal0.Controllers
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

        public IActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        //public IActionResult AddMessage(string name, string email, string message)
        public IActionResult AddMessage(Message userMessage)
        {
            var data = Request.Form;
            return RedirectToAction("Contact", "home");
            //return View();
        }

        [HttpPost]
        public IActionResult SendEmail(string email)
        {
            //return RedirectToAction("Contact", "home");
            return View();
        }

    }
}
