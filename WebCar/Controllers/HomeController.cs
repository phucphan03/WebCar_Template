using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebCar.Models;


namespace WebCar.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }


    }
}
