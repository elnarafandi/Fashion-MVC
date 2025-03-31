using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fashion.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
