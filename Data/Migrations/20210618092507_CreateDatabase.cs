using Microsoft.EntityFrameworkCore.Migrations;

namespace Snacks.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageFileName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 1, "A scrumptious almond cake encrusted with sliced almonds", "Almond_Cake.jpg", "Almond Cake", 8.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 2, "A delicious curry of potato and cauliflower with Indian spices", "Alu-Gobhi_Curry.jpg", "Alu Gobhi Curry", 9.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 3, "Delectable savoury cutlet made from fish", "Fish_Cutlet.jpg", "Fish Cutlet", 5.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 4, "Chickpeas made into delicious snack with lamb mutton", "Mutton_Chholay.jpg", "Mutton Chholay", 1.49m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 5, "A delectable fresh cheese dumpling embedded in Sugar Syrup", "Rasgulla.jpg", "Bengali Rasgulla", 5.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[] { 6, "Fried Besan Coated Lentil Fritters", "Sambhar_Vada.jpg", "Sambhar Vada", 8.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
