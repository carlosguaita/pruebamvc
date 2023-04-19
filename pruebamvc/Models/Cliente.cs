using System;
namespace pruebamvc.Models
{

	public class Cliente
	{

		string cedula;
		string nombre;
		string direccion;
		string telefono;

		public Cliente(string cedula, string nombre, string direccion, string telefono)
		{
			this.cedula = cedula;
			this.nombre = nombre;
			this.direccion = direccion;
			this.telefono = telefono;
		}
	}

}
