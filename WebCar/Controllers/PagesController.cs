using Microsoft.AspNetCore.Mvc;

namespace WebCar.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Testimonial()
        {
            return View();
        }
    }
}
