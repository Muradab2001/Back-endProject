using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiShop.Migrations
{
    public partial class editedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClothesImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Alternative = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    ClothesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClothesImage_Clothes_ClothesId",
                        column: x => x.ClothesId,
                        principalTable: "Clothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClothesImage_ClothesId",
                table: "ClothesImage",
                column: "ClothesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClothesImage");
        }
    }
}
