using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 

namespace ShoppingCart.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, "Balo chống gù lưng", "item1.jpg", 120000m },
                    { 2, "Mũ tai bèo hươu cao cổ", "item2.jpg", 320000m },
                    { 3, "Thắt lưng trẻ em", "item3.jpg", 110000m },
                    { 4, "Váy hồng đính nơ trẻ em", "item4.jpg", 99000m },
                    { 5, "Áo Thun Cho Bé Tay Ngắn In Nhiều Họa Tiết Xinh xắn", "item5.jpg", 100000m },
                    { 6, "Quần Short Jean Cho Bé Gái In Hình Sành Điệu", "item6.jpg", 120000m },
                    { 7, "Quần Short Jean Lửng Cho Bé Gái Sành Điệu", "item7.jpg", 170000m },
                    { 8, "Quần Short Jean Lửng Cho Bé Gái Sành Điệu", "item8.jpg", 200000m },
                    { 9, "Áo Thun Có Nón Bé Gái Tay Ngắn In Cô Bé Xinh Xắn", "item9.jpg", 200000m }
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
