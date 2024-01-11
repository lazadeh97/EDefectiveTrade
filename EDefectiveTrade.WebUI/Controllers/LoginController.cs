using EDefectiveTrade.Business.DTOs.Authentication;
using Microsoft.AspNetCore.Mvc;
using EDefectiveTrade.WebUI.Extentions;
using Microsoft.Build.Execution;
using Microsoft.AspNetCore.Identity;
using EDefectiveTrade.Data.DAL;
using Microsoft.EntityFrameworkCore;
using EDefectiveTrade.Business.Services.Interfaces;

namespace EDefectiveTrade.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAppUserService _userService;
        public const string SessionKeyName = "_Name";
        public const string SessionKeyAge = "_Age";
        public LoginController(AppDbContext context, IAppUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(LoginDto model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.FindUserAsync(model.Email, model.Password);

                if (user != null)
                {
                    if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyName)))
                    {
                        HttpContext.Session.SetString(SessionKeyName, user.Email);
                        //HttpContext.Session.SetInt32(SessionKeyAge, user.);
                    }
                    var name = HttpContext.Session.GetString(SessionKeyName);
                                 
                    //LoginDto userInfos = HttpContext.Session.GetObject<LoginDto>("UserInfos");

                    //if (userInfos == null)
                    //{
                    //    userInfos 

                    //    userInfos.Add(new LoginDto { Email = model.Email});
                    //    HttpContext.Session.SetObject("UserInfos", userInfos);
                    //}
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Giriş uğursuz oldu. İstifadəçi adı və ya şifrə yanlışdır.");
                }
            }
            return View(model);
        }
        //[HttpPost]
        //public async Task<IActionResult> SignIn(LoginDto model)
        //{
        //    string username = model.Email;
        //    var password = model.Password;

        //    List<LoginDto> userInfos = HttpContext.Session.GetObject<List<LoginDto>>("UserInfos");

        //    if (userInfos == null)
        //    {
        //        userInfos = new List<LoginDto>();

        //        userInfos.Add(new LoginDto { Email = username, Password = password });

        //        HttpContext.Session.SetObject("UserInfos", userInfos);
        //    }
        //    return RedirectToAction("Index", "Home");
        //}
    }
}
