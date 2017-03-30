﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 using ProjectoValidarClientes.Models;

namespace ProjectoValidarClientes.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            var listar = from p in ListarClientes() select p;

            return View(listar);
        }

        //
        // GET: /Customer/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Customer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Customer/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Customer/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Customer/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Customer/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Customer/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    [NonAction]
        public List<Employee> ListarClientes()
        {
            return new List<Employee> {
                new Employee
                { ID=1,
                   Name="zarmir pillihuaman hurtado",
                   Age=23,
                   JoiningDate= DateTime.Now
                
                },
                 new Employee
                { ID=1,
                   Name="mendel pillihuaman hurtado",
                   Age=23,
                   JoiningDate= DateTime.Now
                
                }
        };
        
        
        }
    }
}
