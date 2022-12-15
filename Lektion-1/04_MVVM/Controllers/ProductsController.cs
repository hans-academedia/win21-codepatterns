using _04_MVVM.Models;
using _04_MVVM.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _04_MVVM.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new ProductIndexViewModel();
            // viewModel.Latest = await _context.Products.Where(x => x.Created < DateTime.Now);

            return View(viewModel);
        }

        public IActionResult Details()
        {
            var viewModel = new ProductDetailsViewModel();

            return View(viewModel);
        }
    }
}
