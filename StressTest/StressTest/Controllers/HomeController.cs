using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace StressTest.Controllers
{
    public class HomeController : Controller
    {
        private CarRESTService service = new CarRESTService();

        public async Task<ActionResult> Index()
        {
            return View("index", await service.GetCarsAsync());
        }

        public ActionResult IndexSync()
        {
            return View("index", service.GetCars());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}