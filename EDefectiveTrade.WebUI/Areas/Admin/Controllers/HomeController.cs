using Microsoft.AspNetCore.Mvc;

namespace EDefectiveTrade.WebUI.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
