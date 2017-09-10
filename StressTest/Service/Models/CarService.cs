using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Models
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            List<Car> Cars = new List<Car>
        {
            new Car
            {
                Make="Audi",
                Model="A4",
                Year=1995,
                Doors=4,
                Colour="Red",
                Price=2995f,
                Mileage=122458
            },
            new Car
            {
                Make="Ford",
                Model="Focus",
                Year=2002,
                Doors=5,
                Colour="Black",
                Price=3250f,
                Mileage=68500
            },
            new Car
            {
                Make="BMW",
                Model="5 Series",
                Year=2006,
                Doors=4,
                Colour="Grey",
                Price=24950f,
                Mileage=19500
            }
            //This keeps going like that
        };
            return Cars;
        }
    }
}