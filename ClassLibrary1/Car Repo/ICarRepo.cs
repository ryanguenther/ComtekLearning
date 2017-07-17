using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    interface ICarRepo
    {
        Car Update(int ID, Car car);

        Car GetCarById(int ID);

        List<Car> GetCars();
    }
}
