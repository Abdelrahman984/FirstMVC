using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Hello()
        {
            return Content("Hello World from First MVC Controller!");
        }
        public IActionResult getView()
        {
            return View("FirstView");
        }
        public IActionResult getJson()
        {
            return Json(new { Name = "Abdeltahman", Age = 21, City = "Sharqia" });
        }
        public IActionResult GetMix()
        {
            if (DateTime.Now.Hour < 12)
            {
                return Content("Good Morning from First MVC Controller!");
            }
            else
            {
                return View("FirstView");
            }
        }
    }
}
