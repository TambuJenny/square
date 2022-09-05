using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace square.Migrations
{
    public partial class alter_PcModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "PCs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserIdId",
                table: "PCs",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_PCs_UserIdId",
                table: "PCs",
                column: "UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_Users_UserIdId",
                table: "PCs",
                column: "UserIdId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCs_Users_UserIdId",
                table: "PCs");

            migrationBuilder.DropIndex(
                name: "IX_PCs_UserIdId",
                table: "PCs");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "PCs");

            migrationBuilder.DropColumn(
                name: "UserIdId",
                table: "PCs");
        }
    }
}
