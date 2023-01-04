using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Login_Register()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Single_Product()
        {
            return View();
        }
    }
}
