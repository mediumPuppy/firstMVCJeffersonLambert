using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace firstMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // index.cshtml will be rendered from this function
        public IActionResult Index()
        {
            return View();
        }

        // CHarges.cshtml will be rendered from this function
        public IActionResult Charges()
        {
            return View();
        }

        // additional boilerplate
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
