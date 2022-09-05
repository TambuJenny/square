using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace square.Migrations
{
    public partial class Create_BrandModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCs_BrandModel_BrandIdId",
                table: "PCs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BrandModel",
                table: "BrandModel");

            migrationBuilder.RenameTable(
                name: "BrandModel",
                newName: "Brands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_Brands_BrandIdId",
                table: "PCs",
                column: "BrandIdId",
                principalTable: "Brands",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCs_Brands_BrandIdId",
                table: "PCs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                table: "Brands");

            migrationBuilder.RenameTable(
                name: "Brands",
                newName: "BrandModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BrandModel",
                table: "BrandModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_BrandModel_BrandIdId",
                table: "PCs",
                column: "BrandIdId",
                principalTable: "BrandModel",
                principalColumn: "Id");
        }
    }
}
