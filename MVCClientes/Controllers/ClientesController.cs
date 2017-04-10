using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectClienteWallet.Models.LogicaNegocio;
using BusinessEntity;
namespace ProjectClienteWallet.Controllers
{
    public class ClientesController : Controller
    {
        //
            [OutputCache(CacheProfile = "CacheDuracion")]
        [AllowAnonymous]
        public ActionResult Index()


        {

            return View( CrudClientes.Listclientes());
        }
       [AllowAnonymous]
        public ActionResult Edit(int id)
        {
           
            return View(CrudClientes.Editclientes(id));



        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Edit(FormCollection collecion)
        {
            BeCliente objcliente= new BeCliente();

            objcliente.IdCliente=int.Parse( collecion["IdCliente"]);
            objcliente.Nombres=collecion["Nombres"].Trim();
            objcliente.ApellidoPaterno=collecion["ApellidoPaterno"].Trim();
            objcliente.ApellidoMaterno=collecion["ApellidoMaterno"].Trim();
             objcliente.Email=collecion["Email"].Trim();
             objcliente.NumeroMovil=collecion["NumeroMovil"].Trim();
             CrudClientes.Updateclientes(objcliente);


            return RedirectToAction("Index");


        }


        [Authorize]
        public ActionResult Create()
        {

            return View();
        }

        [AllowAnonymous]
        public ActionResult Delete(int id)
        {
            CrudClientes.DeleteClientes(id);
            return RedirectToAction("Index");
        
        }
        [AllowAnonymous]
        [OutputCache(CacheProfile = "CacheDuracion")]
        public ActionResult Details(int id)
        {

            return View(CrudClientes.Editclientes(id));
        
        }

    }
}
