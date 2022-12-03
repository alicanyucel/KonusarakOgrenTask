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
                Password = "Torku.123",
                UserName = "Alican"
            };
            await _userservice.CreateUser(registerdto);
            registerdto = new()
            {
                Email = "yagmur@hotmail.com",
                Password = "Torku.123",
                UserName = "yagmur"
            };
            await _userservice.CreateUser(registerdto);
            registerdto = new()
            {
                Email = "eseryucel@hotmail.com",
                Password = "Torku.123",
                UserName = "Eser"
            };
            await _userservice.CreateUser(registerdto);
            registerdto = new()
            {
                Email = "kezban@hotmail.com",
                Password = "Torku.123",
                UserName = "Kezban"
            };
            await _userservice.CreateUser(registerdto);
            registerdto = new()
            {
                Email = "atilla@hotmail.com",
                Password = "Torku.123",
                UserName = "Atilla"
            };
            await _userservice.CreateUser(registerdto);
            registerdto = new()
            {
                Email = "atikmatik@hotmail.com",
                Password = "Torku.123",
                UserName = "Atıl"
            };

            await _userservice.CreateUser(registerdto);
            return View();
        }

    }
}