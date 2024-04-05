using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Proyecto10AbrilBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class M6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "45820afa-7e13-4a78-9b99-993db9587d46", null, "Entrenador", "ENTRENADOR" },
                    { "7a300773-72f0-4b86-8ddf-733a70fbd6ed", null, "Administrador", "ADMINISTRADOR" },
                    { "96d3b0bb-626a-479b-ab54-c0d64a785e45", null, "Jugador", "JUGADOR" },
                    { "b0a6bfc7-7766-4d5f-ac0f-5c79e11e22b3", null, "Visitante", "VISITANTE" },
                    { "ce9b3b57-f12e-429c-97e6-a0190c691d00", null, "Abonado", "ABONADO" }
                });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 1,
                columns: new[] { "Cantidad", "GastoNombre" },
                values: new object[] { 2000, "📉Material deportivo" });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 2,
                columns: new[] { "Cantidad", "GastoNombre" },
                values: new object[] { 20000, "📉Pago de árbitros" });

            migrationBuilder.InsertData(
                table: "Gastos",
                columns: new[] { "GastoId", "AbonadoId", "Cantidad", "CuerpoTecnicoId", "GastoNombre", "ProductoId" },
                values: new object[,]
                {
                    { 3, 3, 500, null, "📉Alquiler del campo de entrenamiento", null },
                    { 4, 4, 1500, null, "📉Viaje para torneo fuera de la ciudad", null },
                    { 5, 4, 1500000, null, "📉Sueldo de Jugadores", null },
                    { 6, 4, 250000, null, "📉Sueldo del Cuerpo Tecnico", null },
                    { 7, 4, 15000, null, "📉Sueldo del Entrenador", null },
                    { 8, 4, 1500, null, "📉Viaje para torneo fuera de la ciudad", null },
                    { 9, 6, 3000, null, "📈Venta de entradas en partidos locales", null },
                    { 10, 1, 1000, null, "📉Mantenimiento de equipamiento", null },
                    { 11, 7, 1000, null, "📈Donación de un miembro del equipo", null },
                    { 12, 8, 20000, null, "📈Subvención del gobierno local", null },
                    { 13, 5, 200, null, "📈Venta de productos de merchandising", null },
                    { 14, 5, 20000, null, "📈Entradas", null },
                    { 15, 5, 2000000, null, "📈Beneficios por campeonatos", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45820afa-7e13-4a78-9b99-993db9587d46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a300773-72f0-4b86-8ddf-733a70fbd6ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96d3b0bb-626a-479b-ab54-c0d64a785e45");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0a6bfc7-7766-4d5f-ac0f-5c79e11e22b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce9b3b57-f12e-429c-97e6-a0190c691d00");

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 15);

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
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 1,
                columns: new[] { "Cantidad", "GastoNombre" },
                values: new object[] { 0, "Material deportivo" });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 2,
                columns: new[] { "Cantidad", "GastoNombre" },
                values: new object[] { 0, "Pago de árbitros" });
        }
    }
}
