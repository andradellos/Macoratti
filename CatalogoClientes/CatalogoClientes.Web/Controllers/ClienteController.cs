using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CatalogCliente.Dominio;
using CatalogCliente.Dominio.Repositorio;

namespace CatalogoClientes.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

		private IRepositorio<Cliente> _RepositorioCliente;
		public ClienteController ()
		{
			_RepositorioCliente = new ClienteRepositorio(new ClienteContexto());
		}

		public ActionResult Catalogo()
		{
			return View(_RepositorioCliente.GetTodos());
		}
		
		public JsonResult AutoCompleteCityList(string term)
		{
			JsonResult result = new JsonResult();
			var vStateList = _RepositorioCliente.GetTodos();
			var namelist = vStateList.Where(n => n.Nome.ToLower().StartsWith(term.ToLower()));
			return Json(namelist, JsonRequestBehavior.AllowGet);
		
		}

	}
}