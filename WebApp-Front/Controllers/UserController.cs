using Microsoft.AspNetCore.Mvc;

namespace WebApp_Front.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
