using KonusarakOgren.Application.Service;
using KonusarakOgren.Entities.Dtos;
using KonusarakOgren.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KonusarakOgren.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userservice;
        public HomeController(IUserService service)
        {
            _userservice = service;
        }
        public async Task<IActionResult> Index()
        {
            RegisterDto registerdto = new()
            {
                Email = "yucelalican@hotmail.com",
                Password = "torku123",
                UserName = "Alican"
            };
            _userservice.CreateUser(registerdto);
            return View();
        }

    }
}