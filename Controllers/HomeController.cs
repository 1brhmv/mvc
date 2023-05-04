using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.wwwroot
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
