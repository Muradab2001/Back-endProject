using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiShop.Migrations
{
    public partial class createClothesInfarmotion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_ClothesInformation_ClothesInformationId",
                table: "Clothes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClothesInformation",
                table: "ClothesInformation");

            migrationBuilder.RenameTable(
                name: "ClothesInformation",
                newName: "clothesInformations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clothesInformations",
                table: "clothesInformations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_clothesInformations_ClothesInformationId",
                table: "Clothes",
                column: "ClothesInformationId",
                principalTable: "clothesInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_clothesInformations_ClothesInformationId",
                table: "Clothes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clothesInformations",
                table: "clothesInformations");

            migrationBuilder.RenameTable(
                name: "clothesInformations",
                newName: "ClothesInformation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClothesInformation",
                table: "ClothesInformation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_ClothesInformation_ClothesInformationId",
                table: "Clothes",
                column: "ClothesInformationId",
                principalTable: "ClothesInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
