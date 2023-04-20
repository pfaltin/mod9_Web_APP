using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class Kosaricas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41112308 - 4603 - 420b - be22 - 3af8a2166be1",
                column: "ConcurrencyStamp",
                value: "3b288176-5d2f-4c3d-8607-a24f38a81963");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20",
                column: "ConcurrencyStamp",
                value: "68e353d5-782c-4c5f-bb70-fbe9ab4bc210");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de2d8b12-199f-4b43-b94a-ea76d175fee1", "AQAAAAEAACcQAAAAEJYQNO0MhXxWmS+ACiHPI3mHgE9ACzHT1I0FOrXwm78K/TJbTvWAnSEf8SwDM+HBZQ==", "7e1dfe6e-d89d-4e11-9963-333add76fdb6" });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
