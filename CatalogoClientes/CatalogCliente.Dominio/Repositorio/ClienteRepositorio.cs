using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogCliente.Dominio.Repositorio
{
	public class ClienteRepositorio : IRepositorio<Cliente>
	{
		private ClienteContexto contexto;


		public ClienteRepositorio (ClienteContexto clienteContexto)
		{
			this.contexto = clienteContexto;

		}


		public IEnumerable<Cliente> GetTodos()
		{
			return contexto.Clientes.ToList();
		}
	}
}
