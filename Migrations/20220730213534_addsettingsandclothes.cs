using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiShop.Migrations
{
    public partial class addsettingsandclothes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClothesImage_Clothes_ClothesId",
                table: "ClothesImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Setting",
                table: "Setting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClothesImage",
                table: "ClothesImage");

            migrationBuilder.RenameTable(
                name: "Setting",
                newName: "Settings");

            migrationBuilder.RenameTable(
                name: "ClothesImage",
                newName: "ClothesImages");

            migrationBuilder.RenameIndex(
                name: "IX_Setting_Key",
                table: "Settings",
                newName: "IX_Settings_Key");

            migrationBuilder.RenameIndex(
                name: "IX_ClothesImage_ClothesId",
                table: "ClothesImages",
                newName: "IX_ClothesImages_ClothesId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryIds",
                table: "Clothes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settings",
                table: "Settings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClothesImages",
                table: "ClothesImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClothesImages_Clothes_ClothesId",
                table: "ClothesImages",
                column: "ClothesId",
                principalTable: "Clothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClothesImages_Clothes_ClothesId",
                table: "ClothesImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settings",
                table: "Settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClothesImages",
                table: "ClothesImages");

            migrationBuilder.DropColumn(
                name: "CategoryIds",
                table: "Clothes");

            migrationBuilder.RenameTable(
                name: "Settings",
                newName: "Setting");

            migrationBuilder.RenameTable(
                name: "ClothesImages",
                newName: "ClothesImage");

            migrationBuilder.RenameIndex(
                name: "IX_Settings_Key",
                table: "Setting",
                newName: "IX_Setting_Key");

            migrationBuilder.RenameIndex(
                name: "IX_ClothesImages_ClothesId",
                table: "ClothesImage",
                newName: "IX_ClothesImage_ClothesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Setting",
                table: "Setting",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClothesImage",
                table: "ClothesImage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClothesImage_Clothes_ClothesId",
                table: "ClothesImage",
                column: "ClothesId",
                principalTable: "Clothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
