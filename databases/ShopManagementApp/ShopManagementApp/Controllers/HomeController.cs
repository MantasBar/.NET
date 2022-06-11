using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Models;
using ShopManagementApp.Services;
using System.Diagnostics;

namespace ShopManagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ItemService _shopService;

        public HomeController(ILogger<HomeController> logger, ItemService shopService)
        {
            _logger = logger;
            _shopService = shopService;
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
    }
}
