using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0099d4fe-0468-40d1-9684-b4591f910f40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "387a9458-2af5-499e-ad97-633da73bb712");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1389997-a8bb-4edb-85ec-4c58aa6fa38b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20a750c6-264d-40ac-a079-22462ca72b23", null, "Admin", "ADMIN" },
                    { "3aafdfb6-aab9-4220-9979-1cb721dad9fe", null, "User", "USER" },
                    { "f46e5901-5936-4312-a1af-daf71e0acb53", null, "Personal", "PERSONAL" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20a750c6-264d-40ac-a079-22462ca72b23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aafdfb6-aab9-4220-9979-1cb721dad9fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f46e5901-5936-4312-a1af-daf71e0acb53");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0099d4fe-0468-40d1-9684-b4591f910f40", null, "Admin", "ADMIN" },
                    { "387a9458-2af5-499e-ad97-633da73bb712", null, "Personal", "PERSONAL" },
                    { "e1389997-a8bb-4edb-85ec-4c58aa6fa38b", null, "User", "USER" }
                });
        }
    }
}
