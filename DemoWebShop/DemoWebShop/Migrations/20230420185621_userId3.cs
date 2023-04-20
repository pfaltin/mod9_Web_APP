using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class userId3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "ba367941-1929-4a4e-971e-f3d8d8249cd2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "5e29b8aa-b43f-4b46-80a1-f0712799a226");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21511838-0189-48f8-aa39-eb5ffa41c49a", "AQAAAAEAACcQAAAAEDqH/Gywh6EqfyLVzXg3qCgqMkrfVbge2upcMHo6zkcU99i8HQbnI4ljwm6NgOZGDw==", "3475ce1e-c049-45e9-91b1-68b569d2b96f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
