using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoWebShop.Migrations
{
    public partial class DataSeedCatProd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CatrgoryId", "Description", "Image", "Title" },
                values: new object[,]
                {
                    { 1, "Cat desc 1", "/1catimg.png", "Kreme" },
                    { 2, "Cat desc 2", "/2catimg.png", "Losioni" },
                    { 3, "Cat desc 3", "/3catimg.png", "Dezodoransi" },
                    { 4, "Cat desc 4", "/4catimg.png", "Eter Ulja" },
                    { 5, "Cat desc 5", "/5catimg.png", "Razno" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Image", "InStock", "Price", "Sku", "Title" },
                values: new object[,]
                {
                    { 1, "A", "/a.png", 1.00m, 1.01m, "SA", "AARt" },
                    { 2, "B", "/b.png", 2.00m, 2.01m, "SB", "BArt" },
                    { 3, "C", "/c.png", 3.00m, 3.01m, "SC", "CArt" },
                    { 4, "D", "/d.png", 4.00m, 4.01m, "SD", "DArt" },
                    { 5, "E", "/e.png", 5.00m, 5.01m, "SE", "EARt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatrgoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatrgoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatrgoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatrgoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CatrgoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);
        }
    }
}
