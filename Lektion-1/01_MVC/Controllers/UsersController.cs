using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _01_MVC.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
