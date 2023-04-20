using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class ispravak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "3d8e8552-f3f1-4850-a86a-2df2e48f5f85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "f52a6426-50a1-4dcd-ac7e-0b57a6a23b19");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0cbd483-6bc7-4e97-90a3-439451611365", "AQAAAAEAACcQAAAAECwgdKMJwc6PmD+o5lUgbxHg7IdyxNartohBtZYugYsVibOLGmstbBroEkKEHYRuCw==", "f533be59-ecb8-4de6-9041-809c574008c2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "72c36174-dd0b-4854-bbfd-77f69200cecd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "06c037c7-c017-4342-9aaf-d727abdf1e7b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "054c71a4-2cd6-4cf0-afa0-fb5359641e60", "AQAAAAEAACcQAAAAEOUJlwGtop4OZt0HESHZ29GiZxl6LYAN+Lnokg0n6ZvT6oou/x1u0/GjpKBRQimpmw==", "9aef4150-1f25-48a4-8e7d-399631c07eb6" });
        }
    }
}
