using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.Util;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using TestCar.Models;

namespace TestCar.Controllers
{
    public class CarController : ApiController
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


    //    [HttpGet]
    //[AllowAnonymous]
      //[Route("api/test/get/{id}")]
        public HttpResponseMessage GetCar(int registrationNumber)
        {

            var car = from c in m_Car

                      where c.RegistrationNumber == registrationNumber

                      select c;



            return Request.CreateResponse<Car>(HttpStatusCode.OK, car.FirstOrDefault());

        }


        //[HttpPost]
        //public HttpResponseMessage PostCar(Car car)
        //{

        //    m_Car.Add(car);



        //    return Request.CreateResponse<Car>(HttpStatusCode.Created, car);

        //}


        [System.Web.Http.HttpPost]
   
        public void post(Car  cars) {
        
              int  RegistrationNumber =cars.RegistrationNumber;
              string company = cars.Company;
              string color = cars.Color;
              string type = cars.Type;

             

        //public string Company=

        //public string Color 

        //public string Type
 
        }
   
        //public void set(Car cars)
        //{

        //    int RegistrationNumber = cars.RegistrationNumber;
        //    string company = cars.Company;
        //    string color = cars.Color;
        //    string type = cars.Type;



            //public string Company=

            //public string Color 

            //public string Type

        }

    }

