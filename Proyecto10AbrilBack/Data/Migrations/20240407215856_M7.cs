using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Proyecto10AbrilBack.Data.Migrations
{
    /// <inheritdoc />
    public partial class M7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Abonados_AbonadoId",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_CuerpoTecnicos_CuerpoTecnicoId",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Productos_ProductoId",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_AbonadoId",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_CuerpoTecnicoId",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_ProductoId",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_JugadorId",
                table: "Categorias");

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

            migrationBuilder.DropColumn(
                name: "AbonadoId",
                table: "Gastos");

            migrationBuilder.DropColumn(
                name: "CuerpoTecnicoId",
                table: "Gastos");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "Gastos",
                newName: "Dinero");

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

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_JugadorId",
                table: "Categorias",
                column: "JugadorId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Categorias_JugadorId",
                table: "Categorias");

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

            migrationBuilder.RenameColumn(
                name: "Dinero",
                table: "Gastos",
                newName: "ProductoId");

            migrationBuilder.AddColumn<int>(
                name: "AbonadoId",
                table: "Gastos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CuerpoTecnicoId",
                table: "Gastos",
                type: "int",
                nullable: true);

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
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 2,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 3,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 3, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 4,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 4, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 5,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 4, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 6,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 4, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 7,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 4, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 8,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 4, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 9,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 6, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 10,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 11,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 7, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 12,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 8, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 13,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 5, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 14,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 5, null });

            migrationBuilder.UpdateData(
                table: "Gastos",
                keyColumn: "GastoId",
                keyValue: 15,
                columns: new[] { "AbonadoId", "CuerpoTecnicoId" },
                values: new object[] { 5, null });

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

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_JugadorId",
                table: "Categorias",
                column: "JugadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Abonados_AbonadoId",
                table: "Gastos",
                column: "AbonadoId",
                principalTable: "Abonados",
                principalColumn: "AbonadoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_CuerpoTecnicos_CuerpoTecnicoId",
                table: "Gastos",
                column: "CuerpoTecnicoId",
                principalTable: "CuerpoTecnicos",
                principalColumn: "CuerpoTecnicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Productos_ProductoId",
                table: "Gastos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId");
        }
    }
}
