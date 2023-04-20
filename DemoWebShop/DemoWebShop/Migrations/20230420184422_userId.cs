using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class userId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "411f10c7-73a4-4d84-927e-468b6f0457fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "e3ec6632-320a-48f5-8fc4-74aa66f6425b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d83951c-255e-4f29-9d54-047081a59141", "AQAAAAEAACcQAAAAECCffnX1qQui8ntZ9miBlMMvw8kOVAaGX6tEb79ZGs7tk/seG6Jw8YC+K1tvtbbCRw==", "a7fa762c-4d52-4960-97f8-acb55d2bc2c5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
    }
}
