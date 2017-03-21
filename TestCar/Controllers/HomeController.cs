using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
//using System.Web.Http;
using TestCar.Models;
namespace TestCar.Controllers
{
    public class HomeController : Controller
    {

        List<Car> m_Car = new List<Car>()
 
        {
 
           new Car()
 
           {
 
               RegistrationNumber = 1000,
 
               Company = "Ferrari",
 
               Color = "Red",
 
               Type = "Sport"
 
           },
 
           new Car()
 
           {
 
               RegistrationNumber = 1001,
 
               Company = "Mercedes",
 
               Color = "White",
 
               Type = "Comfort"
 
           },
 
           new Car()
 
           {
 
               RegistrationNumber = 1002,
 
               Company = "Audi",
 
               Color = "Black",
 
               Type = "Luxury"
 
           }
 
        };
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetCar()
        {
            var car = from c in m_Car

                      where c.RegistrationNumber == 2

                      select c;

            return Json(car,JsonRequestBehavior.AllowGet);
            //return Request.CreateResponse<Car>(HttpStatusCode.OK, car.FirstOrDefault());
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult PostCar(Car car)
        {

            m_Car.Add(car);

            return Json(car, JsonRequestBehavior.AllowGet);

            //return Request.CreateResponse<Car>(HttpStatusCode.Created, car);

        }
 
    }
}
