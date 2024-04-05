using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Proyecto10AbrilBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class M5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e530d93-4915-4cea-8a29-887f0ca067f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e23d246-a676-4bba-bcab-2bfebe47fbad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a001453f-d037-4b7e-bdd1-22c3de6b88a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5117dad-2bd3-4c6f-aa7d-e6c49195c6a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d165a43b-b3c8-4afa-8b49-fb113e133858");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04e8481d-67ca-4e6a-9349-cab0b4a31aaf", null, "Visitante", "VISITANTE" },
                    { "18c2bc3a-6235-4399-a978-0bf0d1203d3b", null, "Abonado", "ABONADO" },
                    { "84ae7271-5ade-4833-be33-a6a3e9655d17", null, "Administrador", "ADMINISTRADOR" },
                    { "9485a3a3-2b99-4ce3-afaf-c3ba2ebc5c0e", null, "Jugador", "JUGADOR" },
                    { "9a9463d9-7408-4b02-af6e-6c78972ad39d", null, "Entrenador", "ENTRENADOR" }
                });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/images/balon.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/images/conos.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/images/red.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "ImageUrl",
                value: "~/images/botella.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "ImageUrl",
                value: "~/images/Conjunto_de_pesas.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                column: "ImageUrl",
                value: "~/images/guantes.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                column: "ImageUrl",
                value: "~/images/Camisa5.PNG");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "ImageUrl",
                value: "~/images/deportivas.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                column: "ImageUrl",
                value: "~/images/baloncesto.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ProductoNombre" },
                values: new object[] { "~/images/Camisa1.PNG", "Camiseta Titular" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                column: "ImageUrl",
                value: "~/images/Camisa3.PNG");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                column: "ImageUrl",
                value: "~/images/retro.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                column: "ImageUrl",
                value: "~/images/invitado.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                column: "ImageUrl",
                value: "~/images/indumentariaprepartidooscuravisi.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                column: "ImageUrl",
                value: "~/images/calentar.jpg");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 16,
                column: "ImageUrl",
                value: "~/images/camisetaentrenonegra.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04e8481d-67ca-4e6a-9349-cab0b4a31aaf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18c2bc3a-6235-4399-a978-0bf0d1203d3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84ae7271-5ade-4833-be33-a6a3e9655d17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9485a3a3-2b99-4ce3-afaf-c3ba2ebc5c0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a9463d9-7408-4b02-af6e-6c78972ad39d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e530d93-4915-4cea-8a29-887f0ca067f3", null, "Jugador", "JUGADOR" },
                    { "7e23d246-a676-4bba-bcab-2bfebe47fbad", null, "Abonado", "ABONADO" },
                    { "a001453f-d037-4b7e-bdd1-22c3de6b88a6", null, "Visitante", "VISITANTE" },
                    { "c5117dad-2bd3-4c6f-aa7d-e6c49195c6a6", null, "Entrenador", "ENTRENADOR" },
                    { "d165a43b-b3c8-4afa-8b49-fb113e133858", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 7,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 8,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 9,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ProductoNombre" },
                values: new object[] { null, "Camiseta Titular " });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 16,
                column: "ImageUrl",
                value: null);
        }
    }
}
