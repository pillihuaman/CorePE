using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessEntity;
using dummiesServiciosTienda.Models;

namespace dummiesServiciosTienda.Controllers
{
    public class ListClientesController : Controller
    {
        //
        // GET: /ListClientes/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ListClientes/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ListClientes/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ListClientes/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                string Dnia = collection["Numero1"];
                string DNIB = collection["Numero2"];
                ClienteResource proce = new ClienteResource();
                proce = ProcesarClientes.GetCliente(DNIB);

                return View(proce);
                //return Json(proce, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ListClientes/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ListClientes/Edit/5

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
        // GET: /ListClientes/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ListClientes/Delete/5

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
    }
}
