using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class CarRepo: ICarRepo
    {
        public List<Car> GetCars()
        {
            var carList = MockDB.cars;
            return carList;
        }
        /// <summary>
        /// Returns a single car given by ID
        /// </summary>
        /// <param name="ID">The ID of the Car</param>
        /// <returns></returns>
        public Car GetCarById(int ID)
        {
            var listOfCars = GetCars();
            var carOne = listOfCars.FirstOrDefault(car => car.ID == ID);

            return (carOne);
        }

        public Car Update(int ID, Car car)
        {
            var model = GetCarById(ID);
            model.Horsepower = car.Horsepower;
            model.Model = car.Model;
            model.Price = car.Price;
            model.Rate = car.Rate;
            model.Colour = car.Colour;

            return model;
        }
    }
}
