using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobileRepair.Migrations
{
    /// <inheritdoc />
    public partial class fixrelations1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrderServices_OrderId",
                table: "OrderServices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderServices",
                table: "OrderServices",
                columns: new[] { "OrderId", "ServiceId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7665a7df-063f-4af0-8eda-b7b8f44bd66f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a45a336d-f441-4182-bf1d-2017273265a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e3843cee-2fed-4f0b-9f38-e131252c7d56");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderServices",
                table: "OrderServices");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c41b67e1-8055-4a76-be78-25f44314380e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2a5f3248-546f-4666-bc47-a28d0bdfb54c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d0fa2ab9-105f-4b43-a338-1a4a7ed725eb");

            migrationBuilder.CreateIndex(
                name: "IX_OrderServices_OrderId",
                table: "OrderServices",
                column: "OrderId");
        }
    }
}
