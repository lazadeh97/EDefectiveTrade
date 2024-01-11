using EDefectiveTrade.Business.DTOs.Authentication;
using EDefectiveTrade.Business.Services.Interfaces;
using EDefectiveTrade.Core.Entities;
using EDefectiveTrade.Data.DAL;
using EDefectiveTrade.WebUI.Extentions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EDefectiveTrade.WebUI.Controllers
{
    public class RegistrationController : Controller
    {
       //private readonly AppDbContext _context;
        private readonly IAppUserService _userService;
        public RegistrationController(
            //AppDbContext context,
            IAppUserService userService)
        {
            //_context = context;
            _userService = userService;
        }
        /// <summary>
        /// I yoxdu ele beledi  indi yaz))
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
     
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterDTO model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser { Email = model.Email, PasswordHash = model.Password };
                await _userService.RegisterAsync(user);
                return RedirectToAction("Login", "Login");
            }
            return View(model);
        }

        //[HttpPost]
        //public IActionResult SignUp(AppUser user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Users.Add(user);
        //            _context.SaveChanges();

        //            return RedirectToAction("SignIn", "Login");
        //        }
        //        catch (Exception ex)
        //        {                  
        //            ModelState.AddModelError("", "Kayıt olma işlemi sırasında bir hata oluştu.");
        //        }
        //    }
        //    return View(user);
        //}
    }
}
