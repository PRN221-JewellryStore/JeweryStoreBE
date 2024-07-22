using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class SeedImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CategoryID", "Cost", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "ImgUrl", "LastestUpdateAt", "Name", "Quantity", "UpdaterID", "Weight" },
                values: new object[,]
                {
                    { "1a8a2e2e-f693-45ff-a5d3-084138ce979e", 6, 1400000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5640), null, null, null, "Kiềng 2", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo4.png?alt=media&token=c160c486-861d-4d7f-b402-9bd00b034056", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5640), "Kiềng 2", 6, null, 22f },
                    { "1d74c67f-67cd-493a-a993-a30faf04796b", 7, 1100000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5663), null, null, null, "Lắc 2", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo6.jpg?alt=media&token=5d3cfb40-30f4-4343-96cc-9fe016b1c0c8", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5663), "Lắc 2", 8, null, 16.5f },
                    { "1dc3b8e4-538b-430f-88af-e718a3b7f9ec", 5, 900000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5620), null, null, null, "Bông tai 2", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo2.jpg?alt=media&token=d3b10b84-a051-4e5d-a949-07d175177cce", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5620), "Bông tai 2", 14, null, 3.5f },
                    { "6287441d-0cf4-49d2-8b13-97ae9f76a170", 1, 1000000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5501), null, null, null, "Vòng cổ 1", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp1.png.png?alt=media&token=b2d74777-f9de-4a25-b0ff-52a31a1863f2", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5501), "Vòng cổ 1", 5, null, 10.5f },
                    { "7866ad36-2f33-4da0-947c-3bc8f2556fbc", 6, 1200000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5630), null, null, null, "Kiềng 1", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo3.jpg?alt=media&token=7fb28e19-a4bf-4095-b67f-a3a534781d8d", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5630), "Kiềng 1", 7, null, 20f },
                    { "95c5902a-101d-4140-99d7-a3271acce0d8", 4, 3000000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5582), null, null, null, "Đồng hồ 1", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp7.png.png?alt=media&token=4bb468c4-d12b-45a3-8e2c-f478b234273a", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5582), "Đồng hồ 1", 2, null, 50f },
                    { "a9e34ac5-965a-4e46-b042-d140abf990a0", 7, 1000000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5653), null, null, null, "Lắc 1", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo5.jpg?alt=media&token=601f08e1-2442-4cfe-93cf-7ff4c61a7b9e", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5653), "Lắc 1", 9, null, 15f },
                    { "c9a9c529-00d3-4fe9-8a61-309249ea958a", 4, 3500000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5593), null, null, null, "Đồng hồ 2", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp8.png.png?alt=media&token=51ca5f42-ea17-41ae-867a-6abd87a193a4", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5593), "Đồng hồ 2", 3, null, 55f },
                    { "d2b2bead-3b51-4758-bb80-76a84ccf37d6", 3, 2500000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5572), null, null, null, "Nhẫn 2", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp6.png.png?alt=media&token=732f4160-e52c-4ac0-a870-590b598362fa", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5572), "Nhẫn 2", 6, null, 6f },
                    { "dbe130db-58c1-4d58-93f0-b741b739aeec", 2, 500000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5528), null, null, null, "Vòng tay 1", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp3.png.png?alt=media&token=dc618717-aa96-490b-9a2b-dd42ece0a55f", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5528), "Vòng tay 1", 10, null, 8f },
                    { "dfa2bdb4-2818-4fb1-b02b-d115bfa15772", 2, 700000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5541), null, null, null, "Vòng tay 2", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp4.png.png?alt=media&token=0d8d2339-7c58-4d7c-b5be-863c45834423", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5541), "Vòng tay 2", 8, null, 9f },
                    { "e042a170-73d2-4e5b-a273-99fcc469ee08", 5, 800000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5609), null, null, null, "Bông tai 1", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fo1.jpg?alt=media&token=4aeac259-9a2a-47a4-a24c-af63322f8e62", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5609), "Bông tai 1", 12, null, 3f },
                    { "e4ddbc79-10b7-4290-84d0-0e08a1382796", 3, 2000000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5556), null, null, null, "Nhẫn 1", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp5.png.png?alt=media&token=152b1990-5dfd-4de1-b548-94f6410655d5", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5556), "Nhẫn 1", 4, null, 5f },
                    { "f7b988ee-bd5d-45e2-a9cf-16ddc149628a", 1, 1500000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5518), null, null, null, "Vòng cổ 2", "https://firebasestorage.googleapis.com/v0/b/prn221project-1bdc7.appspot.com/o/assets%2Fp2.png.png?alt=media&token=a93ff335-a5da-4309-ae29-51b4500c6402", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5518), "Vòng cổ 2", 3, null, 12f }
                });

            migrationBuilder.InsertData(
                table: "Promotion",
                columns: new[] { "ID", "ConditionsOfUse", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Description", "ExpiresTime", "LastestUpdateAt", "MaximumReduce", "ReducedPercent", "Status", "UpdaterID", "UserID" },
                values: new object[,]
                {
                    { "d87285d0-2ee0-4041-acac-14fa13555dad", 3000000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5793), null, null, null, "Winter Sale", new DateTime(2024, 9, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5799), new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5793), 300000m, 15f, "Active", null, null },
                    { "fc1b202b-1bdb-4df8-9d9e-43211882fa77", 5000000m, new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5764), null, null, null, "Summer Sale", new DateTime(2024, 8, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5772), new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5764), 500000m, 10f, "Active", null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Address", "CreatedAt", "CreatorID", "DeletedAt", "DeleterID", "Email", "FullName", "LastestUpdateAt", "PasswordHash", "PhoneNumber", "RoleID", "UpdaterID", "Username" },
                values: new object[] { "09afea9e-c569-402b-b4c4-dd74292e8aec", "123 Admin St.", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5086), null, null, null, "admin@gmail.com", "Administrator", new DateTime(2024, 7, 22, 22, 6, 6, 267, DateTimeKind.Local).AddTicks(5054), "$2b$12$HE0v7UbzZwl6wY3y/jXhR.oYyGo2DWcIRFQatHueQLw4aS1PbeI8y", "1234567890", 1, null, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "1a8a2e2e-f693-45ff-a5d3-084138ce979e");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "1d74c67f-67cd-493a-a993-a30faf04796b");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "1dc3b8e4-538b-430f-88af-e718a3b7f9ec");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "6287441d-0cf4-49d2-8b13-97ae9f76a170");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "7866ad36-2f33-4da0-947c-3bc8f2556fbc");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "95c5902a-101d-4140-99d7-a3271acce0d8");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "a9e34ac5-965a-4e46-b042-d140abf990a0");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "c9a9c529-00d3-4fe9-8a61-309249ea958a");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "d2b2bead-3b51-4758-bb80-76a84ccf37d6");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "dbe130db-58c1-4d58-93f0-b741b739aeec");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "dfa2bdb4-2818-4fb1-b02b-d115bfa15772");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "e042a170-73d2-4e5b-a273-99fcc469ee08");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "e4ddbc79-10b7-4290-84d0-0e08a1382796");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: "f7b988ee-bd5d-45e2-a9cf-16ddc149628a");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "d87285d0-2ee0-4041-acac-14fa13555dad");

            migrationBuilder.DeleteData(
                table: "Promotion",
                keyColumn: "ID",
                keyValue: "fc1b202b-1bdb-4df8-9d9e-43211882fa77");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "09afea9e-c569-402b-b4c4-dd74292e8aec");

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
    }
}
