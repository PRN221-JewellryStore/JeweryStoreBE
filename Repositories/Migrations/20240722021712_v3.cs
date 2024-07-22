using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Counter_CounterID",
                table: "Order");

            migrationBuilder.DropTable(
                name: "Counter");

            migrationBuilder.DropIndex(
                name: "IX_Order_CounterID",
                table: "Order");

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
                name: "CounterID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Order");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CounterID",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Counter",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleterID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastestUpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdaterID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Counter_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Order_CounterID",
                table: "Order",
                column: "CounterID");

            migrationBuilder.CreateIndex(
                name: "IX_Counter_CategoryID",
                table: "Counter",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Counter_CounterID",
                table: "Order",
                column: "CounterID",
                principalTable: "Counter",
                principalColumn: "ID");
        }
    }
}
