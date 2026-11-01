using Microsoft.AspNetCore.Mvc;

namespace Day2_NguyenMinhNghi.ViewComponents
{
    // Mục 1: ViewComponent
    public class StudentInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name, int numTimes = 1)
        {
            ViewBag.Name = name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}
