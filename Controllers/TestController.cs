using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class TestController : Controller
    {
      public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int id = 0)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, id is {id}");
        }

        public IActionResult WelcomeBack(string name, int num = 3)
        {
            ViewData["name"] = name;
            ViewData["num"] = num;
            return View();
        }
    }
}
