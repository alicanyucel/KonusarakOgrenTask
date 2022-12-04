using KonusarakOgren.Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {

            var result = _productService.GetProducts();
            return View(result);
        }

    }
}

        //private readonly IUserService _userservice;
        //public HomeController(IUserService service)
        //{
        //    _userservice = service;
        //}
        //public async Task<IActionResult> Index()
        //{
        //    RegisterDto registerdto = new()
        //    {
        //        Email = "yucelalican@hotmail.com",
        //        Password = "Torku.123",
        //        UserName = "Alican"
        //    };
        //    await _userservice.CreateUser(registerdto);
        //    registerdto = new()
        //    {
        //        Email = "yagmur@hotmail.com",
        //        Password = "Torku.123",
        //        UserName = "yagmur"
        //    };
        //    await _userservice.CreateUser(registerdto);
        //    registerdto = new()
        //    {
        //        Email = "eseryucel@hotmail.com",
        //        Password = "Torku.123",
        //        UserName = "Eser"
        //    };
        //    await _userservice.CreateUser(registerdto);
        //    registerdto = new()
        //    {
        //        Email = "kezban@hotmail.com",
        //        Password = "Torku.123",
        //        UserName = "Kezban"
        //    };
        //    await _userservice.CreateUser(registerdto);
        //    registerdto = new()
        //    {
        //        Email = "atilla@hotmail.com",
        //        Password = "Torku.123",
        //        UserName = "Atilla"
        //    };
        //    await _userservice.CreateUser(registerdto);
        //    registerdto = new()
        //    {
        //        Email = "atikmatik@hotmail.com",
        //        Password = "Torku.123",
        //        UserName = "Atıl"
        //    };

        //    await _userservice.CreateUser(registerdto);
        //    return View();
        //}