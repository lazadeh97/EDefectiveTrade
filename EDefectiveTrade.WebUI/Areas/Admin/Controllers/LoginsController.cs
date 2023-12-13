using EDefectiveTrade.Business.DTOs.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace EDefectiveTrade.WebUI.Areas.Admin.Controllers
{
    [Area("admin")]
    public class LoginsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginDto model)
        {
            string name = model.Email;
            return View();
        }
    }
}
