using Microsoft.AspNetCore.Mvc;

namespace WebCar.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
