using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class RemOrdItmCat2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Categories_OrderId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "14eb197d-a454-4423-afb9-561ea9c8c328");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "5347fbc5-3b2b-4b36-98a3-f8472e945d77");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f57308d4-1614-4e8c-ad6f-50a89c162d7f", "AQAAAAEAACcQAAAAEJuM/mwO2HLX7iffxDUPjOf+IwsoT01Ac75vkjq7QI9Ratu0vWi9j2swfUh2r7MdoQ==", "24ac8dae-e365-4799-9f6e-83c46d4a12f4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Categories_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
