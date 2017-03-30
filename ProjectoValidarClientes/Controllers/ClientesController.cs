﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectoValidarClientes.Models;
 using ProjectoValidarClientes.APPBack;

namespace ProjectoValidarClientes.Controllers
{
    public class ClientesController : Controller
    {
        //
        // GET: /Clientes/

        public ActionResult Index(string NumeroDocumento)
        {
            var clientes = Server.HtmlEncode(NumeroDocumento);
            if (clientes != null)
            {
                var lista = Listarclientes(clientes);

                return View(lista);
            }
            else 
            {
                return View();
            }

       
        }

        //
        // GET: /Clientes/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Clientes/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Clientes/Create

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
        // GET: /Clientes/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Clientes/Edit/5

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
        // GET: /Clientes/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Clientes/Delete/5

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
        public List<BIClientes> Listarclientes(string numeroDNI)
        {
            return ProcesosCliente.Listarcliente(numeroDNI);

        }
    }
}