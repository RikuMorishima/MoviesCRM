using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.MoviesCRM.Infrastructure.Migrations
{
    public partial class Check3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trailers_Users_UserId",
                table: "Trailers");

            migrationBuilder.DropIndex(
                name: "IX_Trailers_UserId",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Trailers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Trailers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trailers_UserId",
                table: "Trailers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailers_Users_UserId",
                table: "Trailers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
