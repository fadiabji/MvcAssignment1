using Microsoft.AspNetCore.Mvc;

namespace MvcAssignment1.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Msg = "Here is using ViewBag SecondController Index!";
            ViewData["Message"] = "Here is using ViewData SecondController Index!";
            TempData["Message"] = "Here is using TempData SecondController Index!";

            return View();
        }

        public IActionResult secondControllerFirstMethod()
        {
            ViewBag.Msg = "Here is using ViewBag SecondController secondControllerFirstMethod!";
            ViewData["Message"] = "Here is using ViewData SecondController secondControllerFirstMethod!";
            TempData["Message"] = "Here is using TempData SecondController secondControllerFirstMethod!";

            return View();
        }

        public IActionResult secondControllerSecondMethod()
        {
            ViewBag.Msg = "Here is using ViewBag SecondController secondControllerSecondMethod!";
            ViewData["Message"] = "Here is using ViewData SecondController secondControllerSecondMethod!";
            TempData["Message"] = "Here is using TempData SecondController secondControllerSecondMethod!";

            return View();
        }
    }
}
