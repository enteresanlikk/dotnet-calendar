using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calendar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int year = 0, int month = 0)
        {
            var now = DateTime.Now;
            var _year = year != 0 ? year : now.Year;
            var _month = month != 0 ? month : now.Month;

            ViewBag.Year = _year;
            ViewBag.Month = _month;

            return View();
        }
    }
}