using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class ProductAddNameField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Cost", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "LastestUpdateAt", "Name", "Quantity", "UpdaterID", "Weight" },
                values: new object[,]
                {
                    { "14a6a6e0-8d0d-443b-980f-6bcca4373a46", 3, 2000000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3182), null, null, null, "Nhẫn 1", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3182), "Nhẫn 1", 4, null, 5f },
                    { "18bacea9-7199-4bd4-921a-35ff820637de", 5, 800000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3212), null, null, null, "Bông tai 1", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3212), "Bông tai 1", 12, null, 3f },
                    { "1d4449e2-a1f3-4fd3-a556-41cc45e81835", 5, 900000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3219), null, null, null, "Bông tai 2", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3219), "Bông tai 2", 14, null, 3.5f },
                    { "1d4c4dc5-5231-4cf2-abc2-d989c33ecf44", 4, 3000000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3196), null, null, null, "Đồng hồ 1", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3196), "Đồng hồ 1", 2, null, 50f },
                    { "4bab394c-75fc-418e-800f-ec736c2bee7c", 2, 700000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3171), null, null, null, "Vòng tay 2", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3171), "Vòng tay 2", 8, null, 9f },
                    { "4fd0f1d2-eef7-438a-8798-77b905b65700", 6, 1400000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3232), null, null, null, "Kiềng 2", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3232), "Kiềng 2", 6, null, 22f },
                    { "6294cc35-a47c-484c-a140-66924d909453", 6, 1200000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3226), null, null, null, "Kiềng 1", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3226), "Kiềng 1", 7, null, 20f },
                    { "968a2898-e4b5-40b5-ad63-f956eaa46138", 4, 3500000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3202), null, null, null, "Đồng hồ 2", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3202), "Đồng hồ 2", 3, null, 55f },
                    { "ace19bbc-9fb0-486f-97f2-a1a261b6f48e", 3, 2500000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3189), null, null, null, "Nhẫn 2", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3189), "Nhẫn 2", 6, null, 6f },
                    { "b63d6933-e1b6-4d0e-b06e-18aca793f960", 1, 1000000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3142), null, null, null, "Vòng cổ 1", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3142), "Vòng cổ 1", 5, null, 10.5f },
                    { "d209087e-bd88-4060-81d8-ecc0b3586f5a", 1, 1500000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3155), null, null, null, "Vòng cổ 2", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3155), "Vòng cổ 2", 3, null, 12f },
                    { "daa86e6a-0db1-4f5d-84d5-a669bebcdb28", 7, 1000000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3241), null, null, null, "Lắc 1", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3241), "Lắc 1", 9, null, 15f },
                    { "ec5b6d08-7750-4501-8207-2fc356840b17", 7, 1100000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3247), null, null, null, "Lắc 2", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3247), "Lắc 2", 8, null, 16.5f },
                    { "f1d1f9ce-65f6-4882-ae0e-49a1f3ad5f23", 2, 500000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3164), null, null, null, "Vòng tay 1", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3164), "Vòng tay 1", 10, null, 8f }
                });

            migrationBuilder.InsertData(
                table: "Promotion",
                columns: new[] { "ID", "ConditionsOfUse", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "ExpiresTime", "LastestUpdateAt", "MaximumReduce", "ReducedPercent", "Status", "UpdaterID", "UserID" },
                values: new object[,]
                {
                    { "6b797d2e-b9ce-4932-913c-ac5d7f02ae55", 3000000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3350), null, null, null, "Winter Sale", new DateTime(2024, 9, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3358), new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3350), 300000m, 15f, "Active", null, null },
                    { "9084f86f-7468-40d3-a453-8142ace6e2e4", 5000000m, new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3325), null, null, null, "Summer Sale", new DateTime(2024, 8, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3333), new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(3325), 500000m, 10f, "Active", null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Email", "FullName", "LastestUpdateAt", "PasswordHash", "PhoneNumber", "RoleID", "UpdaterID", "Username" },
                values: new object[] { "a8da35fb-d36c-4f6c-abe9-3aeaa4781b80", "123 Admin St.", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(2780), null, null, null, "admin@gmail.com", "Administrator", new DateTime(2024, 7, 19, 8, 14, 18, 598, DateTimeKind.Local).AddTicks(2729), "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y", "1234567890", 1, null, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "14a6a6e0-8d0d-443b-980f-6bcca4373a46");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "18bacea9-7199-4bd4-921a-35ff820637de");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "1d4449e2-a1f3-4fd3-a556-41cc45e81835");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "1d4c4dc5-5231-4cf2-abc2-d989c33ecf44");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "4bab394c-75fc-418e-800f-ec736c2bee7c");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "4fd0f1d2-eef7-438a-8798-77b905b65700");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "6294cc35-a47c-484c-a140-66924d909453");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "968a2898-e4b5-40b5-ad63-f956eaa46138");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "ace19bbc-9fb0-486f-97f2-a1a261b6f48e");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "b63d6933-e1b6-4d0e-b06e-18aca793f960");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "d209087e-bd88-4060-81d8-ecc0b3586f5a");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "daa86e6a-0db1-4f5d-84d5-a669bebcdb28");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "ec5b6d08-7750-4501-8207-2fc356840b17");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "f1d1f9ce-65f6-4882-ae0e-49a1f3ad5f23");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "6b797d2e-b9ce-4932-913c-ac5d7f02ae55");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "9084f86f-7468-40d3-a453-8142ace6e2e4");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "a8da35fb-d36c-4f6c-abe9-3aeaa4781b80");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Product");

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
    }
}
