using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Point",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ExchangePoint",
                table: "Promotion");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Promotion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Order",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Cost", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "LastestUpdateAt", "Quantity", "UpdaterID", "Weight" },
                values: new object[,]
                {
                    { "07e2c8ad-47e3-47bd-a741-13993432efa9", 2, 500000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8922), null, null, null, "Vòng tay 1", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8922), 10, null, 8f },
                    { "0e16200d-15ae-40d3-b438-ce4c184c6662", 4, 3000000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8945), null, null, null, "Đồng hồ 1", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8945), 2, null, 50f },
                    { "1d4a5c7f-591e-4742-9f5d-e3876a3796be", 7, 1000000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8976), null, null, null, "Lắc 1", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8976), 9, null, 15f },
                    { "27a16383-3b50-4f73-80d5-9edcc144f56b", 6, 1400000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8971), null, null, null, "Kiềng 2", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8971), 6, null, 22f },
                    { "557fca59-a5d9-4592-a551-5e44fa6ba880", 1, 1500000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8903), null, null, null, "Vòng cổ 2", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8903), 3, null, 12f },
                    { "6e4b6dae-9eb0-4819-874d-b10ae434be54", 6, 1200000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8966), null, null, null, "Kiềng 1", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8966), 7, null, 20f },
                    { "72b7970c-ee77-4ce0-8748-2e7177f43b96", 2, 700000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8927), null, null, null, "Vòng tay 2", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8927), 8, null, 9f },
                    { "7395033d-a161-422e-a98f-e2753caa5871", 3, 2500000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8937), null, null, null, "Nhẫn 2", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8937), 6, null, 6f },
                    { "74fc71a7-2bf9-4347-8434-10d0d6c40498", 1, 1000000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8894), null, null, null, "Vòng cổ 1", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8894), 5, null, 10.5f },
                    { "97742fc5-6591-4cc2-9a12-d34b8ffe6130", 3, 2000000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8931), null, null, null, "Nhẫn 1", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8931), 4, null, 5f },
                    { "a2d6607a-fe09-4829-b16a-0e893f21f036", 5, 900000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8959), null, null, null, "Bông tai 2", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8959), 14, null, 3.5f },
                    { "a52b38bd-61f9-4bc8-9bb5-7c4af90b954b", 4, 3500000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8949), null, null, null, "Đồng hồ 2", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8949), 3, null, 55f },
                    { "ce8a739e-5e5e-4595-8773-ad81e0050115", 5, 800000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8954), null, null, null, "Bông tai 1", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8954), 12, null, 3f },
                    { "e7063741-2084-4b1c-b733-4a443d348438", 7, 1100000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8981), null, null, null, "Lắc 2", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8981), 8, null, 16.5f }
                });

            migrationBuilder.InsertData(
                table: "Promotion",
                columns: new[] { "ID", "ConditionsOfUse", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "ExpiresTime", "LastestUpdateAt", "MaximumReduce", "ReducedPercent", "Status", "UpdaterID", "UserID" },
                values: new object[,]
                {
                    { "3745ac82-01f7-45ba-a557-6b2a72cac214", 5000000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9029), null, null, null, "Summer Sale", new DateTime(2024, 8, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9034), new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9029), 500000m, 10f, "Done", null, null },
                    { "375d5228-d350-4428-aad2-cec99c6e578b", 3000000m, new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9046), null, null, null, "Winter Sale", new DateTime(2024, 9, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9049), new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(9046), 300000m, 15f, "Done", null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Email", "FullName", "LastestUpdateAt", "PasswordHash", "PhoneNumber", "RoleID", "UpdaterID", "Username" },
                values: new object[] { "d7310277-ef51-4681-8eca-0074ab8d2c5f", "123 Admin St.", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8697), null, null, null, "admin@gmail.com", "Administrator", new DateTime(2024, 7, 18, 15, 57, 45, 697, DateTimeKind.Local).AddTicks(8676), "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y", "1234567890", 1, null, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "07e2c8ad-47e3-47bd-a741-13993432efa9");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "0e16200d-15ae-40d3-b438-ce4c184c6662");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "1d4a5c7f-591e-4742-9f5d-e3876a3796be");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "27a16383-3b50-4f73-80d5-9edcc144f56b");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "557fca59-a5d9-4592-a551-5e44fa6ba880");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "6e4b6dae-9eb0-4819-874d-b10ae434be54");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "72b7970c-ee77-4ce0-8748-2e7177f43b96");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "7395033d-a161-422e-a98f-e2753caa5871");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "74fc71a7-2bf9-4347-8434-10d0d6c40498");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "97742fc5-6591-4cc2-9a12-d34b8ffe6130");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "a2d6607a-fe09-4829-b16a-0e893f21f036");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "a52b38bd-61f9-4bc8-9bb5-7c4af90b954b");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "ce8a739e-5e5e-4595-8773-ad81e0050115");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "e7063741-2084-4b1c-b733-4a443d348438");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "3745ac82-01f7-45ba-a557-6b2a72cac214");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "375d5228-d350-4428-aad2-cec99c6e578b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "d7310277-ef51-4681-8eca-0074ab8d2c5f");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Promotion");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "Point",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExchangePoint",
                table: "Promotion",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
