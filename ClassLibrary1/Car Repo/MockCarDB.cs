using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public static class MockCarDB
    {
        public static List<Car> cars = new List<Car>
        {
            new Car
            {
                Model = "Mustang",
                Price = 20000,
                Colour = "Blue",
                Horsepower = 350,
                Rate = "9/10",
                ID = 1,
            },

            new Car
            {
                Model = "Focus",
                Price = 10000,
                Colour = "Black",
                Horsepower = 130,
                Rate = "6/10",
                ID = 2,
            },

            new Car
            {
                Model = "Fusion",
                Price = 25000,
                Colour = "White",
                Horsepower = 250,
                Rate = "8.5/10",
                ID = 3,
            },

            new Car
            {
            Model = "Escape",
            Price = 15000,
            Colour = "Grey",
            Horsepower = 170,
            Rate = "7.3/10",
            ID = 3,
            }
        };
    }
}
