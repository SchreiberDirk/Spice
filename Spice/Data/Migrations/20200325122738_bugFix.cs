using Microsoft.EntityFrameworkCore.Migrations;

namespace Spice.Data.Migrations
{
    public partial class bugFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_Category_CategoryId",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "CatergoryId",
                table: "SubCategory");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "SubCategory",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_Category_CategoryId",
                table: "SubCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_Category_CategoryId",
                table: "SubCategory");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "SubCategory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CatergoryId",
                table: "SubCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_Category_CategoryId",
                table: "SubCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
