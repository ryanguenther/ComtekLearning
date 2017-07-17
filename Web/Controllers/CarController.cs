using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1;

namespace Web.Controllers
{
    public class CarController : Controller
    {
        /*
        public IActionResult ViewCar()
        {
            var myCar = new Car();
            myCar.Price = 15000;
            myCar.Model = "Mustang";
            myCar.Colour = "Black";
            myCar.Horsepower = 400;
            myCar.Rate = "Awesome";
            myCar.ID = 1;

            return View(myCar);
        }
        */

        public IActionResult Edit(int ID)
        {
            var repo = new CarRepo();
            var newCar = repo.GetCarById(ID);
            return View(newCar);
        }

        [HttpPost]
        public IActionResult Edit(Car car)
        {
            var repo = new CarRepo();
            repo.Update(car.ID, car);
            return RedirectToAction("Index", "Home");
        }

    }
}