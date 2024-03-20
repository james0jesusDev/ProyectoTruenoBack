using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Proyecto10AbrilBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abonados",
                columns: table => new
                {
                    AbonadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    AbonadoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbonadoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbonadoTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbonadoUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abonados", x => x.AbonadoId);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    JugadorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JugadorSueldo = table.Column<int>(type: "int", nullable: false),
                    JugadorNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JugadorApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JugadorUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lesionado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.JugadorId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductoPrecio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Niveles = table.Column<int>(type: "int", nullable: false),
                    JugadorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                    table.ForeignKey(
                        name: "FK_Categorias_Jugadores_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "JugadorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CuerpoTecnicos",
                columns: table => new
                {
                    CuerpoTecnicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuerpoTecnicoSueldo = table.Column<int>(type: "int", nullable: false),
                    CuerpoTecnicoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CuerpoTecnicoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JugadorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuerpoTecnicos", x => x.CuerpoTecnicoId);
                    table.ForeignKey(
                        name: "FK_CuerpoTecnicos_Jugadores_JugadorId",
                        column: x => x.JugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "JugadorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gastos",
                columns: table => new
                {
                    GastoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GastoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbonadoId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: true),
                    CuerpoTecnicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => x.GastoId);
                    table.ForeignKey(
                        name: "FK_Gastos_Abonados_AbonadoId",
                        column: x => x.AbonadoId,
                        principalTable: "Abonados",
                        principalColumn: "AbonadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gastos_CuerpoTecnicos_CuerpoTecnicoId",
                        column: x => x.CuerpoTecnicoId,
                        principalTable: "CuerpoTecnicos",
                        principalColumn: "CuerpoTecnicoId");
                    table.ForeignKey(
                        name: "FK_Gastos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId");
                });

            migrationBuilder.InsertData(
                table: "Abonados",
                columns: new[] { "AbonadoId", "AbonadoApellido", "AbonadoNombre", "AbonadoTelefono", "AbonadoUser", "Precio" },
                values: new object[,]
                {
                    { 1, "Pérez", "Juan", "123456789", "JuanAbonado", 100 },
                    { 2, "López", "María", "987654321", "MariaAbonado", 150 },
                    { 3, "Gómez", "Carlos", "555666777", "CarlosAbonado", 120 },
                    { 4, "Díaz", "Laura", "111222333", "LauraAbonado", 130 },
                    { 5, "Sánchez", "David", "999888777", "DavidAbonado", 110 },
                    { 6, "Fernández", "Elena", "444555666", "ElenaAbonado", 140 },
                    { 7, "Rodríguez", "Miguel", "777888999", "MiguelAbonado", 125 },
                    { 8, "Martínez", "Sara", "666555444", "SaraAbonado", 145 },
                    { 9, "García", "Diego", "333222111", "DiegoAbonado", 115 },
                    { 10, "López", "Carmen", "888999111", "CarmenAbonado", 135 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2accea02-2a7e-4ddc-b812-bd15fa99bb40", null, "Entrenador", "ENTRENADOR" },
                    { "68d4752c-d4e7-4116-b277-82e5f8b78ff8", null, "Jugador", "JUGADOR" },
                    { "6bb633f9-1652-4898-aff9-1414b51ca439", null, "Abonado", "ABONADO" },
                    { "ba16e9c5-400a-4bf3-80e8-4b361644e067", null, "Administrador", "ADMINISTRADOR" },
                    { "c9268dc8-e70a-4c5d-bdbd-a29a50c82cde", null, "Visitante", "VISITANTE" }
                });

            migrationBuilder.InsertData(
                table: "Jugadores",
                columns: new[] { "JugadorId", "ImageUrl", "JugadorApellido", "JugadorNombre", "JugadorSueldo", "JugadorUser", "Lesionado" },
                values: new object[,]
                {
                    { 1, "~/images/5cb68fa1-dac5-4c6e-9faf-a083483d0486.png", "Martínez", "Luis", 2000, "LuisJugador", 1 },
                    { 2, "~/images/02186b80-325e-474c-8282-c3c78f53c685.png", "García", "Ana", 1800, "AnaJugador", 0 },
                    { 3, "~/images/0114cc3f-4c78-4a63-b651-cfad67481440.png", "Gómez", "Pedro", 1800, "PedroJugador", 0 },
                    { 4, "~/images/432fdf64-3cd4-4f91-8fdd-f97f2592d635.png", "Hernández", "Sara", 2200, "SaraJugador", 1 },
                    { 5, "~/images/84e8ff71-7868-439b-8511-817099d5b2a8.png", "Díaz", "Carlos", 1900, "CarlosJugador", 0 },
                    { 6, "~/images/62b27d3e-a213-441b-8d32-d39c1ba6730f.png", "Rodríguez", "Elena", 2100, "ElenaJugador", 1 },
                    { 7, "~/images/8bad9107-56f9-4bf7-972e-5f10b846ea14.png", "Fernández", "Pablo", 2000, "PabloJugador", 1 },
                    { 8, "~/images/8cdf84b3-9750-4e51-bfa4-83d721e693c2.png", "Martínez", "Laura", 1700, "LauraJugador", 0 },
                    { 9, "~/images/_47c9d792-3d98-44d6-b238-5cd41b80f879.png", "García", "Mario", 2300, "MarioJugador", 1 },
                    { 10, "~/images/_9e9e8fa6-62a0-4072-9733-34a985cca372.png", "López", "Isabel", 2400, "IsabelJugador", 0 },
                    { 11, "~/images/_e259c736-c326-4505-a76b-3c85a7d212b1.png", "Hernández", "Juan", 1950, "JuanJugador", 1 },
                    { 12, "~/images/_cf6e421e-914e-4e1b-b72c-1681a0efa2eb.png", "Gómez", "Ana", 1800, "AnaJugador", 0 },
                    { 13, "~/images/_8dce3c44-ae0b-452b-993f-9707833344e6.png", "Martín", "Diego", 2200, "DiegoJugador", 1 },
                    { 14, "~/images/_2b9d4c45-429f-4217-b2da-028950e11336.png", "Jiménez", "Eva", 2100, "EvaJugador", 0 },
                    { 15, "~/images/_1bf715e4-8285-4dde-a2b9-90bad0e56d4d.png", "Sánchez", "José", 1900, "JoseJugador", 1 },
                    { 16, "~/images/_a3f5eaa5-c392-45aa-a698-33fbac33c2e5.png", "Pérez", "María", 2000, "MariaJugador", 0 },
                    { 17, "~/images/_5c75b6f6-efff-4662-9064-118b2e35dd7d.png", "Gutiérrez", "Manuel", 1850, "ManuelJugador", 1 },
                    { 18, "~/images/_89ec388f-428a-4210-87b1-bbd4578b6103.png", "Martínez", "Carmen", 2050, "CarmenJugador", 0 },
                    { 19, "~/images/_2fc03db0-492e-48d1-9541-4bb0fd806a89.png", "González", "Daniel", 1950, "DanielJugador", 1 },
                    { 20, "~/images/_833d50b0-3d0b-4b92-9303-9a4788fb19c0.png", "Hernández", "Lorena", 2200, "LorenaJugador", 0 },
                    { 21, "~/images/_0c1bd7ea-e87d-4fb1-b9e8-3a11f99ad1b2.png", "Fernández", "Adrián", 2000, "AdrianJugador", 1 },
                    { 22, "~/images/_73db2531-d93e-45f9-8c30-6114e8aceea4.png", "Gómez", "Marta", 2100, "MartaJugador", 0 }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "ProductoNombre", "ProductoPrecio" },
                values: new object[,]
                {
                    { 1, "Balón de fútbol", "20" },
                    { 2, "Conos de entrenamiento", "10" },
                    { 3, "Red de fútbol", "50" },
                    { 4, "Botella de agua", "5" },
                    { 5, "Conjunto de pesas", "30" },
                    { 6, "Guantes de portero", "15" },
                    { 7, "Camiseta deportiva", "25" },
                    { 8, "Zapatillas de fútbol", "40" },
                    { 9, "Balón de baloncesto", "30" },
                    { 10, "Pelota de tenis", "10" },
                    { 11, "Raqueta de pádel", "20" },
                    { 12, "Saco de boxeo", "50" },
                    { 13, "Cinta para correr", "200" },
                    { 14, "Bicicleta estática", "300" },
                    { 15, "Balón medicinal", "20" },
                    { 16, "Cuerda para saltar", "10" }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "JugadorId", "Niveles" },
                values: new object[,]
                {
                    { 1, 1, 0 },
                    { 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "CuerpoTecnicos",
                columns: new[] { "CuerpoTecnicoId", "CuerpoTecnicoApellido", "CuerpoTecnicoNombre", "CuerpoTecnicoSueldo", "JugadorId" },
                values: new object[,]
                {
                    { 1, "Ramírez", "Pedro", 2500, 1 },
                    { 2, "Fernández", "Sofía", 2300, 2 },
                    { 3, "Gómez", "Pablo", 2700, 3 },
                    { 4, "Martínez", "Elena", 2800, 4 },
                    { 5, "García", "Alejandro", 2900, 5 },
                    { 6, "Díaz", "Cristina", 3000, 6 },
                    { 7, "Pérez", "David", 3100, 7 }
                });

            migrationBuilder.InsertData(
                table: "Gastos",
                columns: new[] { "GastoId", "AbonadoId", "CuerpoTecnicoId", "GastoNombre", "ProductoId" },
                values: new object[,]
                {
                    { 1, 1, null, "Material deportivo", null },
                    { 2, 2, null, "Pago de árbitros", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_JugadorId",
                table: "Categorias",
                column: "JugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_CuerpoTecnicos_JugadorId",
                table: "CuerpoTecnicos",
                column: "JugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_AbonadoId",
                table: "Gastos",
                column: "AbonadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_CuerpoTecnicoId",
                table: "Gastos",
                column: "CuerpoTecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_ProductoId",
                table: "Gastos",
                column: "ProductoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropTable(
                name: "Abonados");

            migrationBuilder.DropTable(
                name: "CuerpoTecnicos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2accea02-2a7e-4ddc-b812-bd15fa99bb40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68d4752c-d4e7-4116-b277-82e5f8b78ff8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bb633f9-1652-4898-aff9-1414b51ca439");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba16e9c5-400a-4bf3-80e8-4b361644e067");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9268dc8-e70a-4c5d-bdbd-a29a50c82cde");
        }
    }
}
