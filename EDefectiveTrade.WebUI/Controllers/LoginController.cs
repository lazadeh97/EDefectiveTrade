using EDefectiveTrade.Business.DTOs.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace EDefectiveTrade.WebUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login1(LoginDto model)
        {
            string name = model.Email;
            return View();
        }
    }
}
