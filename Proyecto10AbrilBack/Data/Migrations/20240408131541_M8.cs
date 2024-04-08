using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Proyecto10AbrilBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class M8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "591fe693-9873-47f6-877f-dbfdb99a287d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80e655eb-5db6-4baf-82d6-8484a6105399");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93d04bf0-ae5d-4962-94d4-8a2b9dd1b9d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98712bac-dd0a-4c01-88d4-50ad2b683837");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c961d424-f526-4712-9a1c-335018794727");

            migrationBuilder.CreateTable(
                name: "Partido",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipoLocal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipoVisitante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estadio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partido", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17d32e00-51d2-4ca7-8d42-8eb658e425a1", null, "Entrenador", "ENTRENADOR" },
                    { "3d7cdba0-0406-40fd-944f-09f91b8856e5", null, "Administrador", "ADMINISTRADOR" },
                    { "52db4866-6963-49b2-a6a9-23133f222352", null, "Abonado", "ABONADO" },
                    { "6b6ea5cd-2c64-4efc-940c-0b8dd370878e", null, "Visitante", "VISITANTE" },
                    { "b88e8ef8-f926-466e-b7f9-373b30539408", null, "Jugador", "JUGADOR" }
                });

            migrationBuilder.InsertData(
                table: "Partido",
                columns: new[] { "ID", "EquipoLocal", "EquipoVisitante", "Estadio", "Fecha", "Hora" },
                values: new object[,]
                {
                    { 1, "Cadiz", "Trueno FC", "Estadio Nuevo Mirandilla", "2024-04-10", "21:00" },
                    { 2, "Trueno FC", "Real Madrid", "Estadio Camp Nou", "2024-04-16", "21:00" },
                    { 3, "Trueno FC", "Levante", "Estadio Camp Nou", "2024-04-21", "21:00" },
                    { 4, "Villareal", "Trueno FC", "Estadio Cerámica", "2024-05-05", "21:00" },
                    { 5, "Trueno FC", "Getafe", "Estadio Camp Nou", "2024-05-12", "21:00" },
                    { 6, "Eibar", "Trueno FC", "Ipurua", "2024-05-16", "21:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partido");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17d32e00-51d2-4ca7-8d42-8eb658e425a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d7cdba0-0406-40fd-944f-09f91b8856e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52db4866-6963-49b2-a6a9-23133f222352");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b6ea5cd-2c64-4efc-940c-0b8dd370878e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b88e8ef8-f926-466e-b7f9-373b30539408");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "591fe693-9873-47f6-877f-dbfdb99a287d", null, "Administrador", "ADMINISTRADOR" },
                    { "80e655eb-5db6-4baf-82d6-8484a6105399", null, "Entrenador", "ENTRENADOR" },
                    { "93d04bf0-ae5d-4962-94d4-8a2b9dd1b9d0", null, "Visitante", "VISITANTE" },
                    { "98712bac-dd0a-4c01-88d4-50ad2b683837", null, "Abonado", "ABONADO" },
                    { "c961d424-f526-4712-9a1c-335018794727", null, "Jugador", "JUGADOR" }
                });
        }
    }
}
