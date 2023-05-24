using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIpetshop.Migrations
{
    /// <inheritdoc />
    public partial class CrearTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "contactos",
                columns: table => new
                {
                    idContacto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imagen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cedula = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactos", x => x.idContacto);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    idProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.idProducto);
                });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "idCliente", "cedula", "direccion", "nombre", "telefono" },
                values: new object[,]
                {
                    { 1, "1715607071", "La Tola", "Carlos Guaita", "0984667518" },
                    { 2, "0987654321", "Ajaví", "Luis Quishpe", "0912345678" },
                    { 3, "1712349876", "Tumbaco", "Edgar Guijarro", "0912349876" }
                });

            migrationBuilder.InsertData(
                table: "contactos",
                columns: new[] { "idContacto", "cedula", "direccion", "imagen", "nombre", "telefono" },
                values: new object[,]
                {
                    { 1, "1715607071", "La Tola", "https://cdn-icons-png.flaticon.com/512/3577/3577429.png", "Carlos Guaita", "0984667518" },
                    { 2, "0987654321", "Ajaví", "https://cdn-icons-png.flaticon.com/512/1198/1198293.png", "Luis Quishpe", "0912345678" },
                    { 3, "1712349876", "Tumbaco", "https://cdn-icons-png.flaticon.com/512/1373/1373254.png", "Edgar Guijarro", "0912349876" }
                });

            migrationBuilder.InsertData(
                table: "productos",
                columns: new[] { "idProducto", "codigo", "nombre", "numero", "precio" },
                values: new object[,]
                {
                    { 1, "P001", "Collar", 40, 12.0 },
                    { 2, "P002", "Traje", 30, 15.0 },
                    { 3, "P003", "Placa", 35, 20.5 },
                    { 4, "P004", "Cadena", 55, 3.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "contactos");

            migrationBuilder.DropTable(
                name: "productos");
        }
    }
}
