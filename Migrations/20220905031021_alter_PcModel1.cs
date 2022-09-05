using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace square.Migrations
{
    public partial class alter_PcModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCs_Brands_BrandIdId",
                table: "PCs");

            migrationBuilder.RenameColumn(
                name: "BrandIdId",
                table: "PCs",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_PCs_BrandIdId",
                table: "PCs",
                newName: "IX_PCs_BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_Brands_BrandId",
                table: "PCs",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCs_Brands_BrandId",
                table: "PCs");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "PCs",
                newName: "BrandIdId");

            migrationBuilder.RenameIndex(
                name: "IX_PCs_BrandId",
                table: "PCs",
                newName: "IX_PCs_BrandIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_Brands_BrandIdId",
                table: "PCs",
                column: "BrandIdId",
                principalTable: "Brands",
                principalColumn: "Id");
        }
    }
}
