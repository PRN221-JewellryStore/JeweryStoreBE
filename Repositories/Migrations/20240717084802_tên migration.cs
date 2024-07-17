using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class tênmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "1c1d51d4-342c-4630-b427-96cee794772b");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "LastestUpdateAt", "Name", "UpdaterID" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, "Vòng cổ", null },
                    { 2, null, null, null, null, null, "Vòng tay", null },
                    { 3, null, null, null, null, null, "Nhẫn", null },
                    { 4, null, null, null, null, null, "Đồng hồ", null },
                    { 5, null, null, null, null, null, "Bông tai", null },
                    { 6, null, null, null, null, null, "Kiềng", null },
                    { 7, null, null, null, null, null, "Lắc", null }
                });

            migrationBuilder.InsertData(
                table: "Promotion",
                columns: new[] { "ID", "ConditionsOfUse", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "ExchangePoint", "ExpiresTime", "LastestUpdateAt", "MaximumReduce", "ReducedPercent", "UpdaterID", "UserID" },
                values: new object[,]
                {
                    { "3cf14a06-24f2-4fd0-8c7d-2c5214712b47", 3000000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5968), null, null, null, "Winter Sale", 50, new DateTime(2024, 9, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5968), 300000m, 15f, null, null },
                    { "ca577c12-932b-4c49-8d12-90d22cf67b94", 5000000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5949), null, null, null, "Summer Sale", 100, new DateTime(2024, 8, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5955), new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5949), 500000m, 10f, null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Email", "FullName", "LastestUpdateAt", "PasswordHash", "PhoneNumber", "Point", "RoleID", "UpdaterID", "Username" },
                values: new object[] { "a7e19803-eee7-4d48-a73e-193fde213aaf", "123 Admin St.", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5684), null, null, null, "admin@gmail.com", "Administrator", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5660), "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y", "1234567890", 0, 1, null, "admin" });

            migrationBuilder.InsertData(
                table: "Counter",
                columns: new[] { "ID", "CategoryID", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "LastestUpdateAt", "Name", "UpdaterID" },
                values: new object[,]
                {
                    { 1, 1, null, null, null, null, null, "Vòng cổ Counter", null },
                    { 2, 2, null, null, null, null, null, "Vòng tay Counter", null },
                    { 3, 3, null, null, null, null, null, "Nhẫn Counter", null },
                    { 4, 4, null, null, null, null, null, "Đồng hồ Counter", null },
                    { 5, 5, null, null, null, null, null, "Bông tai Counter", null },
                    { 6, 6, null, null, null, null, null, "Kiềng Counter", null },
                    { 7, 7, null, null, null, null, null, "Lắc Counter", null }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Cost", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "LastestUpdateAt", "Quantity", "UpdaterID", "Weight" },
                values: new object[,]
                {
                    { "0500a3f5-9816-418d-b11a-2aa4ef391a4e", 4, 3500000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5875), null, null, null, "Đồng hồ 2", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5875), 3, null, 55f },
                    { "0632586e-f9ec-4d9c-8e28-3e67ef2b551c", 6, 1200000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5896), null, null, null, "Kiềng 1", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5896), 7, null, 20f },
                    { "0ea0a181-a50b-4157-b499-17e42b0efbfe", 5, 800000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5882), null, null, null, "Bông tai 1", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5882), 12, null, 3f },
                    { "3e4f1126-79ef-47cc-975a-be0ce3388bd8", 7, 1100000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5918), null, null, null, "Lắc 2", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5918), 8, null, 16.5f },
                    { "4038100e-8758-488f-ab1e-3dd5201c7f81", 3, 2500000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5860), null, null, null, "Nhẫn 2", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5860), 6, null, 6f },
                    { "51c57838-d670-43a8-a507-51d85755ada1", 3, 2000000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5852), null, null, null, "Nhẫn 1", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5852), 4, null, 5f },
                    { "7a443370-4562-4afe-ae84-1c765f7e9108", 6, 1400000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5904), null, null, null, "Kiềng 2", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5904), 6, null, 22f },
                    { "80c2b05d-9930-4270-9ed4-6e44533f32dc", 1, 1000000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5804), null, null, null, "Vòng cổ 1", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5804), 5, null, 10.5f },
                    { "93de1d5c-ae63-41bc-b8b9-f239f8a6e120", 5, 900000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5890), null, null, null, "Bông tai 2", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5890), 14, null, 3.5f },
                    { "a4b87b58-948e-4b9d-82aa-eafd6f520751", 1, 1500000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5818), null, null, null, "Vòng cổ 2", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5818), 3, null, 12f },
                    { "b8b5c091-4229-4484-9348-f961a379dc3b", 7, 1000000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5911), null, null, null, "Lắc 1", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5911), 9, null, 15f },
                    { "c6f39d5a-ef8d-4378-a5ae-9996cdaf3936", 2, 700000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5845), null, null, null, "Vòng tay 2", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5845), 8, null, 9f },
                    { "d47cf759-d436-40c5-8743-3c4ff2dfa59e", 2, 500000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5825), null, null, null, "Vòng tay 1", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5825), 10, null, 8f },
                    { "ed7911ba-ed22-4d81-a3c7-ef7658332b63", 4, 3000000m, new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5867), null, null, null, "Đồng hồ 1", new DateTime(2024, 7, 17, 15, 48, 1, 65, DateTimeKind.Local).AddTicks(5867), 2, null, 50f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Counter",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Counter",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Counter",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Counter",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Counter",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Counter",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Counter",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "0500a3f5-9816-418d-b11a-2aa4ef391a4e");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "0632586e-f9ec-4d9c-8e28-3e67ef2b551c");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "0ea0a181-a50b-4157-b499-17e42b0efbfe");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "3e4f1126-79ef-47cc-975a-be0ce3388bd8");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "4038100e-8758-488f-ab1e-3dd5201c7f81");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "51c57838-d670-43a8-a507-51d85755ada1");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "7a443370-4562-4afe-ae84-1c765f7e9108");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "80c2b05d-9930-4270-9ed4-6e44533f32dc");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "93de1d5c-ae63-41bc-b8b9-f239f8a6e120");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "a4b87b58-948e-4b9d-82aa-eafd6f520751");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "b8b5c091-4229-4484-9348-f961a379dc3b");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "c6f39d5a-ef8d-4378-a5ae-9996cdaf3936");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "d47cf759-d436-40c5-8743-3c4ff2dfa59e");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "ed7911ba-ed22-4d81-a3c7-ef7658332b63");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "3cf14a06-24f2-4fd0-8c7d-2c5214712b47");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "ca577c12-932b-4c49-8d12-90d22cf67b94");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "a7e19803-eee7-4d48-a73e-193fde213aaf");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Email", "FullName", "LastestUpdateAt", "PasswordHash", "PhoneNumber", "Point", "RoleID", "UpdaterID", "Username" },
                values: new object[] { "1c1d51d4-342c-4630-b427-96cee794772b", "123 Admin St.", new DateTime(2024, 7, 1, 14, 59, 35, 643, DateTimeKind.Local).AddTicks(4861), null, null, null, "admin@gmail.com", "Administrator", new DateTime(2024, 7, 1, 14, 59, 35, 643, DateTimeKind.Local).AddTicks(4832), "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y", "1234567890", 0, 1, null, "admin" });
        }
    }
}
