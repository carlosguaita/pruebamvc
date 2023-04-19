using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APIpetshop.Models
{
	public class ApplicationDBContext: DbContext
	{

       

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){ }

        public DbSet<Producto> productos { get; set; }
        public DbSet<Cliente> clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
                new Producto()
                {
                    idProducto=1,
                    codigo = "P001",
                    nombre = "Collar",
                    precio = 12,
                    numero = 40
                },
            new Producto()
            {
                idProducto = 2,
                codigo = "P002",
                nombre = "Traje",
                precio = 15,
                numero = 30
            },
            new Producto()
            {
                idProducto = 3,
                codigo = "P003",
                nombre = "Placa",
                precio = 20.5,
                numero = 35
            },
            new Producto()
            {
                idProducto = 4,
                codigo = "P004",
                nombre = "Cadena",
                precio = 3.5,
                numero = 55
            }
            );
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    idCliente=1,
                    nombre="Carlos Guaita",
                    cedula="1715607071",
                    direccion="La Tola",
                    telefono="0984667518"
                },
                new Cliente
                {
                    idCliente = 2,
                    nombre = "Luis Quishpe",
                    cedula = "0987654321",
                    direccion = "Ajaví",
                    telefono = "0912345678"
                },
                new Cliente
                {
                    idCliente = 3,
                    nombre = "Edgar Guijarro",
                    cedula = "1712349876",
                    direccion = "Tumbaco",
                    telefono = "0912349876"
                }
                );
        }

    }
}

