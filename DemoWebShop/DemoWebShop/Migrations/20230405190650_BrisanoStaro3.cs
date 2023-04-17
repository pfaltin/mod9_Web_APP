using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class BrisanoStaro3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "2ea7dfb2-f32a-419c-9bcc-023b626139d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "74136878-5cac-436d-bb69-1823e03ef067");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "252fcbc9-aead-4638-aba1-b45a6ed69fca", "AQAAAAEAACcQAAAAEPSJ3bExsEPo5mTKCNE8ehmV/fMWH4wJ7pmYcXo5GorfztYG5T7Ipk91YPYDM8jQ2A==", "93ede7cd-99fc-4e87-9861-b094dc6870e3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "d7dfe3cc-5115-43e8-9a7d-1006987b6dc5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "897cf40f-d8de-4bac-99a0-b6264056e6db");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4fa1f4a-d2c5-43b2-bc1e-ed7560642f8a", "AQAAAAEAACcQAAAAEPZs8B9M0khDj0RfCQJ2dd8UPpV0Q65LzJ9GpkBd/gfhnM+f+1R3c1pY0h74pYYFhQ==", "fd56c8d3-7b26-4513-ae17-4bd549c69c27" });
        }
    }
}
