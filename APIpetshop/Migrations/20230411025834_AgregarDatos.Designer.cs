﻿// <auto-generated />
using APIpetshop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIpetshop.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230411025834_AgregarDatos")]
    partial class AgregarDatos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIpetshop.Models.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCliente"));

                    b.Property<string>("cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCliente");

                    b.ToTable("clientes");

                    b.HasData(
                        new
                        {
                            idCliente = 1,
                            cedula = "1715607071",
                            direccion = "La Tola",
                            nombre = "Carlos Guaita",
                            telefono = "0984667518"
                        },
                        new
                        {
                            idCliente = 2,
                            cedula = "0987654321",
                            direccion = "Ajaví",
                            nombre = "Luis Quishpe",
                            telefono = "0912345678"
                        },
                        new
                        {
                            idCliente = 3,
                            cedula = "1712349876",
                            direccion = "Tumbaco",
                            nombre = "Edgar Guijarro",
                            telefono = "0912349876"
                        });
                });

            modelBuilder.Entity("APIpetshop.Models.Producto", b =>
                {
                    b.Property<int>("idProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProducto"));

                    b.Property<string>("codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.HasKey("idProducto");

                    b.ToTable("productos");

                    b.HasData(
                        new
                        {
                            idProducto = 1,
                            codigo = "P001",
                            nombre = "Collar",
                            numero = 40,
                            precio = 12.0
                        },
                        new
                        {
                            idProducto = 2,
                            codigo = "P002",
                            nombre = "Traje",
                            numero = 30,
                            precio = 15.0
                        },
                        new
                        {
                            idProducto = 3,
                            codigo = "P003",
                            nombre = "Placa",
                            numero = 35,
                            precio = 20.5
                        },
                        new
                        {
                            idProducto = 4,
                            codigo = "P004",
                            nombre = "Cadena",
                            numero = 55,
                            precio = 3.5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
