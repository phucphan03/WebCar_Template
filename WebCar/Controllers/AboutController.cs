using Microsoft.AspNetCore.Mvc;

namespace WebCar.Controllers
{
    public class AboutController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
