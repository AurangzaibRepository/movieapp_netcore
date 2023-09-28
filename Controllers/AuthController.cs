using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
