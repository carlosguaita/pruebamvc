using System;
using pruebamvc.Models;

namespace pruebamvc.Services
{
	public interface IServicioApi
	{

		Task<List<Producto>> ListarProductos();
		Task<Producto> ObtenerProducto(string codigo);
		Task<string> GuardarProducto(Producto producto);
		Task<string> EditarProducto(string codigo, Producto producto);
		Task<string> BorrarProducto(string codigo);
	}
}

