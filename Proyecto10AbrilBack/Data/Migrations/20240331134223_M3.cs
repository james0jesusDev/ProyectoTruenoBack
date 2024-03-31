using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Proyecto10AbrilBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class M3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09857af0-9c3a-41c9-bd2f-2e349094f1bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e217649-d059-428a-8514-5028617480f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78ef167f-1851-4ce9-87ea-f93ba33c6993");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9b6e931-db60-4b78-a346-156b5de9dbc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9672f04-9e8c-46ee-ab98-3a5d21e58d57");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9bf35711-2c3a-4336-ad90-1c4cf4a00ddd", null, "Visitante", "VISITANTE" },
                    { "b2c8b80e-c225-47c8-aed3-226d702e976d", null, "Jugador", "JUGADOR" },
                    { "ca428641-7df3-4601-82c3-8369207bc270", null, "Abonado", "ABONADO" },
                    { "cba73167-76a1-4665-a7f9-ca5d94dc6e7e", null, "Administrador", "ADMINISTRADOR" },
                    { "ecfbc929-6f4a-4795-95be-fb97f3121435", null, "Entrenador", "ENTRENADOR" }
                });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                columns: new[] { "ProductoNombre", "ProductoPrecio" },
                values: new object[] { "Camiseta Titular ", "50" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                columns: new[] { "ProductoNombre", "ProductoPrecio" },
                values: new object[] { "Camiseta Visitante", "45" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                column: "ProductoNombre",
                value: "Sudadera Retro");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                columns: new[] { "ProductoNombre", "ProductoPrecio" },
                values: new object[] { "Sudadera Visitante", "47" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                columns: new[] { "ProductoNombre", "ProductoPrecio" },
                values: new object[] { "Camiseta entreno", "35" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                columns: new[] { "ProductoNombre", "ProductoPrecio" },
                values: new object[] { "Indumentaria Calentamiento", "55" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bf35711-2c3a-4336-ad90-1c4cf4a00ddd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2c8b80e-c225-47c8-aed3-226d702e976d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca428641-7df3-4601-82c3-8369207bc270");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cba73167-76a1-4665-a7f9-ca5d94dc6e7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecfbc929-6f4a-4795-95be-fb97f3121435");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09857af0-9c3a-41c9-bd2f-2e349094f1bf", null, "Entrenador", "ENTRENADOR" },
                    { "6e217649-d059-428a-8514-5028617480f0", null, "Jugador", "JUGADOR" },
                    { "78ef167f-1851-4ce9-87ea-f93ba33c6993", null, "Abonado", "ABONADO" },
                    { "c9b6e931-db60-4b78-a346-156b5de9dbc6", null, "Administrador", "ADMINISTRADOR" },
                    { "f9672f04-9e8c-46ee-ab98-3a5d21e58d57", null, "Visitante", "VISITANTE" }
                });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 10,
                columns: new[] { "ProductoNombre", "ProductoPrecio" },
                values: new object[] { "Pelota de tenis", "10" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 11,
                columns: new[] { "ProductoNombre", "ProductoPrecio" },
                values: new object[] { "Raqueta de pádel", "20" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 12,
                column: "ProductoNombre",
                value: "Saco de boxeo");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 13,
                columns: new[] { "ProductoNombre", "ProductoPrecio" },
                values: new object[] { "Cinta para correr", "200" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 14,
                columns: new[] { "ProductoNombre", "ProductoPrecio" },
                values: new object[] { "Bicicleta estática", "300" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 15,
                columns: new[] { "ProductoNombre", "ProductoPrecio" },
                values: new object[] { "Balón medicinal", "20" });
        }
    }
}
