using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StationeryPlus.Server.Migrations
{
    public partial class Categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Shop now for the best variety of school supplies, teaching solutions and essentials to transform the teaching environment.", "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000", "School Supplies", "school-supplies" },
                    { 2, "Shop now for the best variety of Office Supplies, equipments and essentials to transform the Office Environment.", "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000", "Office Supplies", "office-supplies" },
                    { 3, "Best Stationaries for Home, working from Home.", "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000", "Home Supplies", "home-supplies" },
                    { 4, "Explore art supplies and materials for any activity drawing, painting, sculpting, printmaking, calligraphy, and more.", "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000", "Art Supplies", "art-supplies" },
                    { 5, "Check out for very best, unique and custom gifts and decorations for any occasion.", "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000", "Gift and Decorations", "gifts-and-decorations" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Price" },
                values: new object[] { 1, 80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Price" },
                values: new object[] { 1, 80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Price" },
                values: new object[] { 1, 80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Price" },
                values: new object[] { 2, 80m });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 80);
        }
    }
}
