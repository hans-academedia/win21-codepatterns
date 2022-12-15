using _04_MVVM.Models;
using Microsoft.AspNetCore.Mvc;

namespace _04_MVVM.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var userModel = new UserModel();

            return View(userModel);
        }
    }
}
