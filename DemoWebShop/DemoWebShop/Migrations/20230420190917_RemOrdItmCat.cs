using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class RemOrdItmCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "fbc5951b-5c97-426c-8e5b-42b79b39e0b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "42b2794f-9e59-464c-b0c2-c671419f8bc5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce1bdc27-d24d-40b9-b334-067854cb551f", "AQAAAAEAACcQAAAAEFZkfK3gyjwcxwhbBfBrc1nzg6xggiUVnfXgruKyh/Gaf7CrpJaUR9t0v8cdgwF8Ig==", "eaa1d496-3737-486d-b543-a376ff296ec2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
