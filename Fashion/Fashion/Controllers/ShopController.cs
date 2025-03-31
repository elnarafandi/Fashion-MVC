using Microsoft.AspNetCore.Mvc;

namespace Fashion.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
