using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIpetshop.Models
{
	public class Cliente
	{
		[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCliente { get; set; }
		[Required]
		public string nombre { get; set; }
		[Required]
		public string cedula { get; set; }
		public string direccion { get; set; }
		public string telefono { get; set; }

	
	}
}

