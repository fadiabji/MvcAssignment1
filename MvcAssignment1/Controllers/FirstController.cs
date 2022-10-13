using Microsoft.AspNetCore.Mvc;

namespace MvcAssignment1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Msg = "Here is using ViewBag FirstController Index!";
            ViewData["Message"] = "Here is using ViewData FirstController Index!";
            TempData["Message"] = "Here is using TempData FirstController Index!";
            return View();
        }

        public IActionResult controllerOneFirstMethod()
        {
            ViewBag.Msg = "Here is using ViewBag FirstController controllerOneFirstMethod!";
            ViewData["Message"] = "Here is using ViewData FirstController controllerOneFirstMethod!";
            TempData["Message"] = "Here is using TempData FirstController controllerOneFirstMethod!";
            return View();
        }

        public IActionResult controllerOneSecondMethod()
        {
            ViewBag.Msg = "Here is using ViewBag FirstController controllerTwoSecondMethod!";
            ViewData["Message"] = "Here is using ViewData FirstController controllerTwoSecondMethod!";
            TempData["Message"] = "Here is using TempData FirstController controllerTwoSecondMethod!";

            return View();
        }
    }
}
