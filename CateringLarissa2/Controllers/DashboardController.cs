using Microsoft.AspNetCore.Mvc;

namespace CateringLarissa2.Controllers
{
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Review()
        {
            return View();
        }

        public IActionResult Account()
        {
            return View();
        }
    }
}
