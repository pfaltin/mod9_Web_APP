using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class AdminAccCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "a7d991e6-9f24-4ff1-9913-e310943b3e36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "baa1089a-cc64-4a68-b4f2-656ae813ef2f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588", 0, "Donji Glib 56", "c3218515-ded5-4876-9484-1321858d595f", "admin@tvrtka.com", false, "Tvrtko", "Tvrdic", false, null, "ADMIN@TVRTKA.COM", "ADMIN@TVRTKA.COM", "AQAAAAEAACcQAAAAENvxR3fukWlVWP2STAx8252+6BmigQAQAcyUfYIQk5KHVfmIMtqKtAeRwDU9BKz38Q==", null, false, "d79c05db-3e44-4139-85a7-8e010aedfa78", false, "admin@tvrtka.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20", "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20", "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "254aab8f-137d-4cc5-9e3b-093d16ae1d3e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "febeb9e7-7daf-4316-b7de-429d9fa816cc");
        }
    }
}
