using Microsoft.AspNetCore.Mvc;

namespace WebCar.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Car()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Booking()
        {
            return View();
        }
    }
}
