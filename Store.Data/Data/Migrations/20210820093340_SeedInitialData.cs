using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Infraestructura.Data.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AgeRestriction", "Company", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 12, "TomHanksor", "Awesome Bicycle", "Bicycle Tom Hanks", 123f },
                    { 2, 99, "HandsOver", "Awesome Train", "Train Handsome", 123f },
                    { 3, 80, "BearLand", "Cute BearLand", "Teddy bear", 1000f },
                    { 4, 80, "DuckHunter", "Ducker", "Rubber ducky", 200f },
                    { 5, 80, "GoodGuyCompany", "GoodGuyCompany Description", "Good guy doll", 800f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
