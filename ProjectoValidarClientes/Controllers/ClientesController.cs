using System;
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

        //public ActionResult Index(string NumeroDocumento)
        //{
        //    var clientes = Server.HtmlEncode(NumeroDocumento);
        //    if (clientes != null)
        //    {
        //        var lista = Listarclientes(clientes);

        //        return View(lista);
        //    }
        //    else 
        //    {
        //        return View();
        //    }

       
        //}

        public ActionResult Index()
        {

            var lista = Listartodosclientes();
       return View(lista);
         

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

        public ActionResult Edit(string id)
        {

            return View(Editrclientes(id));
        }

        //
        // POST: /Clientes/Edit/5

        [HttpPost]
        public ActionResult Edit( FormCollection collection)
        {
            try
            {
                BIClientes cliente = new BIClientes();

                cliente.NumeroDocumento = collection["NumeroDocumento"].ToString();
                cliente.IdClientePagoEfectivo = collection["IdClientePagoEfectivo"].ToString();
                cliente.Nombres = collection["Nombres"].ToString();
                cliente.ApellidoPaterno = collection["ApellidoPaterno"].ToString();
                cliente.IdCliente = collection["IdCliente"].ToString();
                ProcesosCliente.Update(cliente);





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
        public BIClientes Editrclientes(string numeroDNI)
        {
            return ProcesosCliente.Editcliente(numeroDNI);

        }
          [NonAction]
        public List<BIClientes> Listartodosclientes()
        {
            return ProcesosCliente.Listarallclientes();

        }
    }
}