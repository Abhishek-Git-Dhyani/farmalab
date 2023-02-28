using Microsoft.AspNetCore.Mvc;
using Pharma.Models;

namespace Pharma.Controllers
{
    public class UserController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(User model)
        {
            return View();
        }
    }
}
