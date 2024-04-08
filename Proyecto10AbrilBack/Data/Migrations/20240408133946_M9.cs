using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Proyecto10AbrilBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class M9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Fecha",
                table: "Partido",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "LogoLocal",
                table: "Partido",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoVisitante",
                table: "Partido",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00251e6b-f152-4959-85d1-31b30105a98c", null, "Visitante", "VISITANTE" },
                    { "27091232-8503-451f-88a7-fd90b11f12fa", null, "Abonado", "ABONADO" },
                    { "6b90b79a-5366-4e26-a76f-6e813c750a57", null, "Administrador", "ADMINISTRADOR" },
                    { "bf02d6ac-08fc-4a75-8f11-9155f6348d1d", null, "Entrenador", "ENTRENADOR" },
                    { "ea773633-ba89-4981-b31f-522f4f37d1fd", null, "Jugador", "JUGADOR" }
                });

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "LogoLocal", "LogoVisitante" },
                values: new object[] { "~/images/cadiz.jfif", "~/images/_bfac69ec-7f32-4d5b-8390-1afcd08c3829 (2).jpg" });

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "LogoLocal", "LogoVisitante" },
                values: new object[] { "~/images/_bfac69ec-7f32-4d5b-8390-1afcd08c3829 (2).jpg", "~/images/realmadri.jfif" });

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "LogoLocal", "LogoVisitante" },
                values: new object[] { "~/images/_bfac69ec-7f32-4d5b-8390-1afcd08c3829 (2).jpg", "~/images/Levante.jfif" });

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "LogoLocal", "LogoVisitante" },
                values: new object[] { "~/images/villareal.jfif", "~/images/_bfac69ec-7f32-4d5b-8390-1afcd08c3829 (2).jpg" });

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "LogoLocal", "LogoVisitante" },
                values: new object[] { "~/images/_bfac69ec-7f32-4d5b-8390-1afcd08c3829 (2).jpg", "~/images/getafe.jfif" });

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "LogoLocal", "LogoVisitante" },
                values: new object[] { "~/images/eibar.jfif", "~/images/_bfac69ec-7f32-4d5b-8390-1afcd08c3829 (2).jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00251e6b-f152-4959-85d1-31b30105a98c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27091232-8503-451f-88a7-fd90b11f12fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b90b79a-5366-4e26-a76f-6e813c750a57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf02d6ac-08fc-4a75-8f11-9155f6348d1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea773633-ba89-4981-b31f-522f4f37d1fd");

            migrationBuilder.DropColumn(
                name: "LogoLocal",
                table: "Partido");

            migrationBuilder.DropColumn(
                name: "LogoVisitante",
                table: "Partido");

            migrationBuilder.AlterColumn<string>(
                name: "Fecha",
                table: "Partido",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
