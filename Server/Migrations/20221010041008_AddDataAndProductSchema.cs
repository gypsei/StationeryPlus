using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StationeryPlus.Server.Migrations
{
    public partial class AddDataAndProductSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing", "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg", 80, "Nataraj 621 Pencils" },
                    { 2, "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing", "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg", 80, "Nataraj 621 Pencils" },
                    { 3, "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing", "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg", 80, "Nataraj 621 Pencils" },
                    { 4, "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing", "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg", 80, "Nataraj 621 Pencils" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
