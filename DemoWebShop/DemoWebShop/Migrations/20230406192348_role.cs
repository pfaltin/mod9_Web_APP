using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "b3a671d2-0804-4606-8bac-71ca5133748a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "582e0409-ba67-4fd6-bcbd-abf026d9c2b5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f97f045f-594c-4d65-adc5-c506d1d00e1d", "AQAAAAEAACcQAAAAELL4I2ZLkncIpEB0QpHaA1W5ASg4HrEtvWcDhQtkDFIiAaPkeQno+WeGIXuaxs6haA==", "af132f4b-a910-4b0f-9d83-30599a520bed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
