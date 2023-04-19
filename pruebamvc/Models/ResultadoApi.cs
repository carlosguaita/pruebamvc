using System;
namespace pruebamvc.Models
{
	public class ResultadoApi
	{
		public string httpResponseCode { get; set; }

		public List<Producto> listaProductos { get; set; }

		public Producto producto { get; set; }
    }
}

