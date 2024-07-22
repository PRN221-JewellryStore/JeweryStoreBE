using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddImgUrlToProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "00b7997c-3ce2-4507-8ad0-0d059f4a4ae8");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "0246a922-c2e2-4e76-83a6-a5449f1db947");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "1dcebec9-745a-4848-bf0a-82feb52dfccd");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "231e4beb-3df6-4f39-b726-8683799d0a5a");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "316b5e70-6c43-4866-ae1f-ac0017ccfef1");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "3ed5e23b-b73d-4808-8ece-d17786d2d90e");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "47f672c6-6876-4f62-8d19-5425fa600420");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "605f3bbf-d60b-4451-acaf-9be437c407a0");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "6fd06362-9b48-47ce-a1bf-8627fe7186bb");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "a58f2a90-f573-489c-9a59-296fb316d54f");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "c0fd93cb-e0f8-450a-afdb-c69d27f65413");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "cc85829f-274d-432d-b1cc-6de48eac2f16");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "ce526015-d4be-47dc-a5d6-d67d6472af51");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "eb0bf3e9-3391-48f9-bb5c-da304b4c5ddc");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "a04d4ee8-73e4-4135-af75-a5da913b7268");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "ebf4e0c9-9cbf-41db-8e74-726bb3ddf8d8");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "0b393451-236d-4f75-bd62-84d17be775b0");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Cost", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "ImgUrl", "LastestUpdateAt", "Name", "Quantity", "UpdaterID", "Weight" },
                values: new object[,]
                {
                    { "122858cb-f253-494b-915d-71b1dc8676ed", 5, 900000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1727), null, null, null, "Bông tai 2", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1727), "Bông tai 2", 14, null, 3.5f },
                    { "1bf33110-0316-4c69-afb9-cf7a3d062f7b", 3, 2000000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1687), null, null, null, "Nhẫn 1", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1687), "Nhẫn 1", 4, null, 5f },
                    { "309e68e9-b1b7-400d-838a-04c9fb5c7038", 6, 1400000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1742), null, null, null, "Kiềng 2", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1742), "Kiềng 2", 6, null, 22f },
                    { "3d73ae7e-f3ee-43fe-92ca-4a3252f9aacd", 7, 1000000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1751), null, null, null, "Lắc 1", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1751), "Lắc 1", 9, null, 15f },
                    { "64bb6878-76b9-4a22-bc1b-faa45c7f0d20", 4, 3500000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1711), null, null, null, "Đồng hồ 2", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1711), "Đồng hồ 2", 3, null, 55f },
                    { "75bb724a-7d7b-44bb-becc-4209c94cf622", 3, 2500000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1696), null, null, null, "Nhẫn 2", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1696), "Nhẫn 2", 6, null, 6f },
                    { "83fbab8f-1c70-4728-bc01-721f2fda9d1e", 2, 700000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1677), null, null, null, "Vòng tay 2", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1677), "Vòng tay 2", 8, null, 9f },
                    { "903b8e9c-13c3-462a-8096-25a37f8b0559", 1, 1500000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1620), null, null, null, "Vòng cổ 2", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1620), "Vòng cổ 2", 3, null, 12f },
                    { "930d9ab2-566d-491f-b16a-a5f5325bf5ec", 4, 3000000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1704), null, null, null, "Đồng hồ 1", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1704), "Đồng hồ 1", 2, null, 50f },
                    { "9f201f61-1e2a-4dcf-9624-f01f86e3a3e9", 6, 1200000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1735), null, null, null, "Kiềng 1", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1735), "Kiềng 1", 7, null, 20f },
                    { "abde158b-7696-4de5-be79-81bd1d9b5d63", 5, 800000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1720), null, null, null, "Bông tai 1", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1720), "Bông tai 1", 12, null, 3f },
                    { "b40d2785-7a4b-486a-8ca8-d2cc9fc31adb", 1, 1000000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1606), null, null, null, "Vòng cổ 1", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1606), "Vòng cổ 1", 5, null, 10.5f },
                    { "ce95357a-9a62-4f88-bdc1-864a9dcf3d1a", 7, 1100000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1758), null, null, null, "Lắc 2", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1758), "Lắc 2", 8, null, 16.5f },
                    { "d3339339-da79-4a94-84fa-0f3cfe91e728", 2, 500000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1628), null, null, null, "Vòng tay 1", null, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1628), "Vòng tay 1", 10, null, 8f }
                });

            migrationBuilder.InsertData(
                table: "Promotion",
                columns: new[] { "ID", "ConditionsOfUse", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "ExpiresTime", "LastestUpdateAt", "MaximumReduce", "ReducedPercent", "Status", "UpdaterID", "UserID" },
                values: new object[,]
                {
                    { "5a14ff3b-092f-4215-87f2-c776128a4a6d", 5000000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1791), null, null, null, "Summer Sale", new DateTime(2024, 8, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1796), new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1791), 500000m, 10f, "Active", null, null },
                    { "679edb57-c064-405a-81a5-1fa324cf2a39", 3000000m, new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1809), null, null, null, "Winter Sale", new DateTime(2024, 9, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1815), new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1809), 300000m, 15f, "Active", null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Email", "FullName", "LastestUpdateAt", "PasswordHash", "PhoneNumber", "RoleID", "UpdaterID", "Username" },
                values: new object[] { "40759165-aee9-43b2-8342-8402542f4b8f", "123 Admin St.", new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1563), null, null, null, "admin@gmail.com", "Administrator", new DateTime(2024, 7, 22, 12, 14, 29, 481, DateTimeKind.Local).AddTicks(1519), "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y", "1234567890", 1, null, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "122858cb-f253-494b-915d-71b1dc8676ed");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "1bf33110-0316-4c69-afb9-cf7a3d062f7b");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "309e68e9-b1b7-400d-838a-04c9fb5c7038");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "3d73ae7e-f3ee-43fe-92ca-4a3252f9aacd");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "64bb6878-76b9-4a22-bc1b-faa45c7f0d20");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "75bb724a-7d7b-44bb-becc-4209c94cf622");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "83fbab8f-1c70-4728-bc01-721f2fda9d1e");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "903b8e9c-13c3-462a-8096-25a37f8b0559");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "930d9ab2-566d-491f-b16a-a5f5325bf5ec");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "9f201f61-1e2a-4dcf-9624-f01f86e3a3e9");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "abde158b-7696-4de5-be79-81bd1d9b5d63");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "b40d2785-7a4b-486a-8ca8-d2cc9fc31adb");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "ce95357a-9a62-4f88-bdc1-864a9dcf3d1a");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "d3339339-da79-4a94-84fa-0f3cfe91e728");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "5a14ff3b-092f-4215-87f2-c776128a4a6d");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "679edb57-c064-405a-81a5-1fa324cf2a39");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "40759165-aee9-43b2-8342-8402542f4b8f");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Product");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Cost", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "LastestUpdateAt", "Name", "Quantity", "UpdaterID", "Weight" },
                values: new object[,]
                {
                    { "00b7997c-3ce2-4507-8ad0-0d059f4a4ae8", 7, 1100000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5130), null, null, null, "Lắc 2", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5130), "Lắc 2", 8, null, 16.5f },
                    { "0246a922-c2e2-4e76-83a6-a5449f1db947", 5, 900000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5103), null, null, null, "Bông tai 2", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5103), "Bông tai 2", 14, null, 3.5f },
                    { "1dcebec9-745a-4848-bf0a-82feb52dfccd", 6, 1200000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5109), null, null, null, "Kiềng 1", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5109), "Kiềng 1", 7, null, 20f },
                    { "231e4beb-3df6-4f39-b726-8683799d0a5a", 5, 800000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5096), null, null, null, "Bông tai 1", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5096), "Bông tai 1", 12, null, 3f },
                    { "316b5e70-6c43-4866-ae1f-ac0017ccfef1", 6, 1400000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5118), null, null, null, "Kiềng 2", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5118), "Kiềng 2", 6, null, 22f },
                    { "3ed5e23b-b73d-4808-8ece-d17786d2d90e", 3, 2000000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5000), null, null, null, "Nhẫn 1", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5000), "Nhẫn 1", 4, null, 5f },
                    { "47f672c6-6876-4f62-8d19-5425fa600420", 1, 1500000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4976), null, null, null, "Vòng cổ 2", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4976), "Vòng cổ 2", 3, null, 12f },
                    { "605f3bbf-d60b-4451-acaf-9be437c407a0", 3, 2500000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5008), null, null, null, "Nhẫn 2", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5008), "Nhẫn 2", 6, null, 6f },
                    { "6fd06362-9b48-47ce-a1bf-8627fe7186bb", 2, 700000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4994), null, null, null, "Vòng tay 2", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4994), "Vòng tay 2", 8, null, 9f },
                    { "a58f2a90-f573-489c-9a59-296fb316d54f", 1, 1000000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4966), null, null, null, "Vòng cổ 1", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4966), "Vòng cổ 1", 5, null, 10.5f },
                    { "c0fd93cb-e0f8-450a-afdb-c69d27f65413", 4, 3500000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5023), null, null, null, "Đồng hồ 2", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5023), "Đồng hồ 2", 3, null, 55f },
                    { "cc85829f-274d-432d-b1cc-6de48eac2f16", 2, 500000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4983), null, null, null, "Vòng tay 1", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4983), "Vòng tay 1", 10, null, 8f },
                    { "ce526015-d4be-47dc-a5d6-d67d6472af51", 7, 1000000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5124), null, null, null, "Lắc 1", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5124), "Lắc 1", 9, null, 15f },
                    { "eb0bf3e9-3391-48f9-bb5c-da304b4c5ddc", 4, 3000000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5014), null, null, null, "Đồng hồ 1", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5014), "Đồng hồ 1", 2, null, 50f }
                });

            migrationBuilder.InsertData(
                table: "Promotion",
                columns: new[] { "ID", "ConditionsOfUse", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "ExpiresTime", "LastestUpdateAt", "MaximumReduce", "ReducedPercent", "Status", "UpdaterID", "UserID" },
                values: new object[,]
                {
                    { "a04d4ee8-73e4-4135-af75-a5da913b7268", 3000000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5276), null, null, null, "Winter Sale", new DateTime(2024, 9, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5279), new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5276), 300000m, 15f, "Active", null, null },
                    { "ebf4e0c9-9cbf-41db-8e74-726bb3ddf8d8", 5000000m, new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5256), null, null, null, "Summer Sale", new DateTime(2024, 8, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(5256), 500000m, 10f, "Active", null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Email", "FullName", "LastestUpdateAt", "PasswordHash", "PhoneNumber", "RoleID", "UpdaterID", "Username" },
                values: new object[] { "0b393451-236d-4f75-bd62-84d17be775b0", "123 Admin St.", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4869), null, null, null, "admin@gmail.com", "Administrator", new DateTime(2024, 7, 22, 9, 17, 11, 496, DateTimeKind.Local).AddTicks(4845), "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y", "1234567890", 1, null, "admin" });
        }
    }
}
