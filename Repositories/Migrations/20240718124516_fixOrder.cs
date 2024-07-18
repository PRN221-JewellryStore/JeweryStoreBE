using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class fixOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<decimal>(
                name: "PrimaryPrice",
                table: "Order",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Cost", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "LastestUpdateAt", "Quantity", "UpdaterID", "Weight" },
                values: new object[,]
                {
                    { "0be66674-fb1a-42b2-b346-4c7fc1584968", 3, 2000000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1493), null, null, null, "Nhẫn 1", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1493), 4, null, 5f },
                    { "0ede6625-3b3a-435a-8154-59bddc40fd7f", 5, 900000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1600), null, null, null, "Bông tai 2", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1600), 14, null, 3.5f },
                    { "649fb470-3c3a-4241-bac2-30d43712ef81", 1, 1500000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1453), null, null, null, "Vòng cổ 2", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1453), 3, null, 12f },
                    { "6ed1aaf8-a86b-47f4-810e-77cfb55d8908", 2, 700000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1487), null, null, null, "Vòng tay 2", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1487), 8, null, 9f },
                    { "76ef3887-d484-428d-8459-40ec69e13eae", 2, 500000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1481), null, null, null, "Vòng tay 1", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1481), 10, null, 8f },
                    { "7c9baeee-2343-472e-ac73-5b4e6e410b88", 1, 1000000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1441), null, null, null, "Vòng cổ 1", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1441), 5, null, 10.5f },
                    { "7d67236e-e5de-4ead-b1e8-f55bce0b4404", 4, 3500000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1586), null, null, null, "Đồng hồ 2", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1586), 3, null, 55f },
                    { "92bcfcbe-1e64-4ac1-bf3f-28055ce36550", 6, 1400000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1615), null, null, null, "Kiềng 2", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1615), 6, null, 22f },
                    { "9a8aabc3-59cb-4dc2-b2ad-d2403f2c419a", 7, 1000000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1621), null, null, null, "Lắc 1", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1621), 9, null, 15f },
                    { "a3a0269f-941d-441b-87ee-0f59aec65679", 6, 1200000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1609), null, null, null, "Kiềng 1", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1609), 7, null, 20f },
                    { "a82435d7-7d8e-4388-a29c-9e4eacd4a3a5", 4, 3000000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1510), null, null, null, "Đồng hồ 1", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1510), 2, null, 50f },
                    { "b40974ce-9973-426d-84db-17745caeed29", 3, 2500000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1500), null, null, null, "Nhẫn 2", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1500), 6, null, 6f },
                    { "b4c5f0a2-a7cb-4357-a79c-5f6dfd648cd3", 7, 1100000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1627), null, null, null, "Lắc 2", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1627), 8, null, 16.5f },
                    { "d8d5f143-d0e6-44c1-b331-1de0f36cad35", 5, 800000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1593), null, null, null, "Bông tai 1", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1593), 12, null, 3f }
                });

            migrationBuilder.InsertData(
                table: "Promotion",
                columns: new[] { "ID", "ConditionsOfUse", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "ExpiresTime", "LastestUpdateAt", "MaximumReduce", "ReducedPercent", "Status", "UpdaterID", "UserID" },
                values: new object[,]
                {
                    { "15c79315-eefc-40ce-9463-3f9b0f29be01", 3000000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1719), null, null, null, "Winter Sale", new DateTime(2024, 9, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1723), new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1719), 300000m, 15f, "Active", null, null },
                    { "71770830-b7e5-4ec2-a59b-98cc293cb727", 5000000m, new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1699), null, null, null, "Summer Sale", new DateTime(2024, 8, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1704), new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1699), 500000m, 10f, "Active", null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Email", "FullName", "LastestUpdateAt", "PasswordHash", "PhoneNumber", "RoleID", "UpdaterID", "Username" },
                values: new object[] { "63963bee-46c2-437e-b438-33cef2bea5c5", "123 Admin St.", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1138), null, null, null, "admin@gmail.com", "Administrator", new DateTime(2024, 7, 18, 19, 45, 15, 211, DateTimeKind.Local).AddTicks(1110), "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y", "1234567890", 1, null, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "0be66674-fb1a-42b2-b346-4c7fc1584968");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "0ede6625-3b3a-435a-8154-59bddc40fd7f");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "649fb470-3c3a-4241-bac2-30d43712ef81");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "6ed1aaf8-a86b-47f4-810e-77cfb55d8908");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "76ef3887-d484-428d-8459-40ec69e13eae");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "7c9baeee-2343-472e-ac73-5b4e6e410b88");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "7d67236e-e5de-4ead-b1e8-f55bce0b4404");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "92bcfcbe-1e64-4ac1-bf3f-28055ce36550");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "9a8aabc3-59cb-4dc2-b2ad-d2403f2c419a");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "a3a0269f-941d-441b-87ee-0f59aec65679");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "a82435d7-7d8e-4388-a29c-9e4eacd4a3a5");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "b40974ce-9973-426d-84db-17745caeed29");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "b4c5f0a2-a7cb-4357-a79c-5f6dfd648cd3");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "d8d5f143-d0e6-44c1-b331-1de0f36cad35");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "15c79315-eefc-40ce-9463-3f9b0f29be01");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "71770830-b7e5-4ec2-a59b-98cc293cb727");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "63963bee-46c2-437e-b438-33cef2bea5c5");

            migrationBuilder.DropColumn(
                name: "PrimaryPrice",
                table: "Order");

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
    }
}
