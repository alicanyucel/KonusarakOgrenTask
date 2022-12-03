using KonusarakOgren.Entities;
using KonusarakOgren.Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgren.Mvc.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;
        public AuthController(UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            AppUser user = await _usermanager.FindByEmailAsync(loginDto.UserName);
            if (user == null)
                user = await _usermanager.FindByNameAsync(loginDto.UserName);
            if (user == null)
            {
                TempData["errors"] = "Kullanici bulunamadi";
                return RedirectToAction("Index", "Auth");
            }

            bool result = await _usermanager.CheckPasswordAsync(user, loginDto.PassWord);
            if (result)
            {
                var roles = await _usermanager.GetRolesAsync(user);
                TempData["roles"] = roles;
                return RedirectToAction("Index", "Home");
            }
            TempData["errors"] = "Şifre hatalı";
            return RedirectToAction("Index", "Auth");
        }


    }
}