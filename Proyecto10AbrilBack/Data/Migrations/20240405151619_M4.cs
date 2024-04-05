using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Proyecto10AbrilBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class M4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Gastos",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 1,
                column: "Cantidad",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 2,
                column: "Cantidad",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Gastos");

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
        }
    }
}
