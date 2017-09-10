using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Service.Controllers
{
    public class CarsController : ApiController
    {
        public IEnumerable<Car> Get()
        {
            var service = new CarService();
            return service.GetCars();
        }
    }
}
