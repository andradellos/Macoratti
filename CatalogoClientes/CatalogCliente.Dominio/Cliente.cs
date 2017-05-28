using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CatalogCliente.Dominio
{
	[Table ("Clientes")]
	public class Cliente
	{
		public  int ClienteId { get; set; }
		[Required(ErrorMessage ="Informe Nome")]
		public  string Nome { get; set; }
		[Required(ErrorMessage = "Informe Email")]
		[EmailAddress]
		public  string Email { get; set; }
		[Required(ErrorMessage = "Informe Endereço")]
		public  string Endereco { get; set; }
		public  byte[] Image { get; set; }
		public  string ImagemTipo { get; set; }
	}
}
