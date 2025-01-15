using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobileRepair.Migrations
{
    /// <inheritdoc />
    public partial class fixrelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IX_OrderServices_ServiceId",
                table: "OrderServices",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrderServices_ServiceId",
                table: "OrderServices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderServices",
                table: "OrderServices",
                columns: new[] { "ServiceId", "OrderId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ebc8e9c7-5cf1-4c79-b3ad-4ddd0fa5268d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "95744f8a-3e81-433a-b2cd-8b0e757877bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7ad801e7-22ad-4dd9-8d6a-2b1ce68704aa");
        }
    }
}
