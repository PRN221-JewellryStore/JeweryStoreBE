using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "ID", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "LastestUpdateAt", "Name", "UpdaterID" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, "Admin", null },
                    { 2, null, null, null, null, null, "Customer", null },
                    { 3, null, null, null, null, null, "Manager", null },
                    { 4, null, null, null, null, null, "Staff", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Email", "FullName", "LastestUpdateAt", "PasswordHash", "PhoneNumber", "Point", "RoleID", "UpdaterID", "Username" },
                values: new object[] { "1c1d51d4-342c-4630-b427-96cee794772b", "123 Admin St.", new DateTime(2024, 7, 1, 14, 59, 35, 643, DateTimeKind.Local).AddTicks(4861), null, null, null, "admin@gmail.com", "Administrator", new DateTime(2024, 7, 1, 14, 59, 35, 643, DateTimeKind.Local).AddTicks(4832), "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y", "1234567890", 0, 1, null, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "1c1d51d4-342c-4630-b427-96cee794772b");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
