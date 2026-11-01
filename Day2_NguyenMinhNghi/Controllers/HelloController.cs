using Microsoft.AspNetCore.Mvc;

namespace Day2_NguyenMinhNghi.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 1. Attribute Routing (URL trên bảng: /Hello/Welcome/3?name=KTPM&Num=5)
        [Route("Hello/Welcome/{id:int?}")]
        public IActionResult Welcome(int id, string name, int num = 1)
        {
            ViewBag.RoutingType = "Attribute Routing";
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Num = num;
            return View();
        }

        // 2. Conventional Routing (Theo quy ước Program.cs: /Hello/WelcomeConventional/3?name=KTPM&Num=5)
        public IActionResult WelcomeConventional(int id, string name, int num = 1)
        {
            ViewBag.RoutingType = "Conventional Routing";
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Num = num;
            return View("Welcome");
        }
    }
}
