using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Proyecto10AbrilBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "572393ad-a374-464d-b3c2-ad5e1470f3b4", null, "Administrador", "ADMINISTRADOR" },
                    { "7258d916-6a56-4698-a402-6ad599595a01", null, "Jugador", "JUGADOR" },
                    { "95f359b2-3898-4f7d-b3a9-7b2c0ed5e9ea", null, "Abonado", "ABONADO" },
                    { "9ad1c288-fbf5-43d5-9010-99c1aa3e4e27", null, "Entrenador", "ENTRENADOR" },
                    { "eaf12f63-21d0-4f42-bc35-36c92433bd4f", null, "Visitante", "VISITANTE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "572393ad-a374-464d-b3c2-ad5e1470f3b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7258d916-6a56-4698-a402-6ad599595a01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95f359b2-3898-4f7d-b3a9-7b2c0ed5e9ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ad1c288-fbf5-43d5-9010-99c1aa3e4e27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaf12f63-21d0-4f42-bc35-36c92433bd4f");

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
        }
    }
}
