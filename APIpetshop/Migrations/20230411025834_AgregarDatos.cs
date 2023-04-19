using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIpetshop.Migrations
{
    /// <inheritdoc />
    public partial class AgregarDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] {"cedula", "direccion", "nombre", "telefono" },
                values: new object[,]
                {
                    {"1715607071", "La Tola", "Carlos Guaita", "0984667518" },
                    {"0987654321", "Ajaví", "Luis Quishpe", "0912345678" },
                    {"1712349876", "Tumbaco", "Edgar Guijarro", "0912349876" }
                });

            migrationBuilder.InsertData(
                table: "productos",
                columns: new[] {"codigo", "nombre", "numero", "precio" },
                values: new object[,]
                {
                    {"P001", "Collar", 40, 12.0 },
                    {"P002", "Traje", 30, 15.0 },
                    {"P003", "Placa", 35, 20.5 },
                    {"P004", "Cadena", 55, 3.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "idCliente",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "idCliente",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "idCliente",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "productos",
                keyColumn: "idProducto",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "productos",
                keyColumn: "idProducto",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "productos",
                keyColumn: "idProducto",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "productos",
                keyColumn: "idProducto",
                keyValue: 4);
        }
    }
}
