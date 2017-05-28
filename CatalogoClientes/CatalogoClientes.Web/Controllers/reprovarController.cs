using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CatalogCliente.Dominio;
using CatalogCliente.Dominio.Repositorio;

namespace CatalogoClientes.Web.Controllers
{
    public class reprovarController : Controller
    {
        // GET: reprovar
        public ActionResult Index()
        {
            return View();
        }


		private IRepositorio<Cliente> _RepositorioCliente;
		public reprovarController()
		{
			_RepositorioCliente = new ClienteRepositorio(new ClienteContexto());
		}



		// GET: reprovar/Details/5
		public ActionResult Details(int id, string dunga)
        {
			IEnumerable<Cliente> ListaCli;
			ListaCli = _RepositorioCliente.GetTodos().Where(x=> x.ClienteId == id);
			//retornar um partialview
			return PartialView(ListaCli);
        }

        // GET: reprovar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: reprovar/Create
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

        // GET: reprovar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: reprovar/Edit/5
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

        // GET: reprovar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: reprovar/Delete/5
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
