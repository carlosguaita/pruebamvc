﻿using System;
namespace APIpetshop.Models
{
	public class ResultadoApi
	{
		
            public string httpResponseCode { get; set; }

			public List<Producto> listaProductos { get; set; }

            public Producto producto { get; set; }

            public List<Contacto> listaContactos{ get; set; }

            public Contacto contacto{ get; set; }

    }
}

