using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int ID)
        {
            var repo = new CarRepo();
            var CarList = repo.GetCars();

            return View(CarList);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Trade()
        {
            return View();
        }
    }
}