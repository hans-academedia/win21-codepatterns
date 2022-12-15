using _03_FRONTEND.Factories;
using _03_FRONTEND.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _03_FRONTEND.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeIndexViewModelFactory _factory;

        public HomeController(ILogger<HomeController> logger, IHomeIndexViewModelFactory factory)
        {
            _logger = logger;
            _factory = factory;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = _factory.Create();
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            var viewModel = _factory.Create();
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}