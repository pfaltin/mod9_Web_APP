using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class userId2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "7a4ad97a-828a-4bf4-b488-bf41141b3139");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "73b34569-51d8-4659-bf29-d043f4a27ac4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "745ccd76-7fa9-425e-8e2b-9d92769a7eb5", "AQAAAAEAACcQAAAAEDeq+rcPNhrUCDLgVigc/3YhL/P46Pxpm2yXkHmKLv31fkvlnTvYT3jCLHqYTlKrIg==", "0a999357-6f64-4589-8145-66e30331c11a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
