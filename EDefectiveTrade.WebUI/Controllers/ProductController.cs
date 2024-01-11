using Microsoft.AspNetCore.Mvc;

namespace EDefectiveTrade.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductDetails()
        {
            return View();
        }
        public IActionResult Favorites()
        {
            return View();
        }
    }
}
