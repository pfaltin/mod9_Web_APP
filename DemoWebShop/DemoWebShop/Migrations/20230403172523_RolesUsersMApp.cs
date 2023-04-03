using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class RolesUsersMApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "beaecd87-f1ed-44a5-9d2b-a44768700215");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "7725b57a-ef26-44c9-bd08-098bb1a26477");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1fbd615-9f29-43ea-b3ea-4b5f8e8daa94", "AQAAAAEAACcQAAAAEIJGNDdz9RpBHAhA+lWvkMWULyhTRTxilhqG2zyJRB93ou2h6H3aVPGXnPr5Z2q66g==", "b2dc07d2-c695-4d52-a9de-c408f02f701e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3218515-ded5-4876-9484-1321858d595f", "AQAAAAEAACcQAAAAENvxR3fukWlVWP2STAx8252+6BmigQAQAcyUfYIQk5KHVfmIMtqKtAeRwDU9BKz38Q==", "d79c05db-3e44-4139-85a7-8e010aedfa78" });
        }
    }
}
