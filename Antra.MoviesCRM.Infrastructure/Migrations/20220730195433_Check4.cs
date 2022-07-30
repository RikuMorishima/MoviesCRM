using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.MoviesCRM.Infrastructure.Migrations
{
    public partial class Check4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Movies_MovieRefId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "MovidId",
                table: "Purchases");

            migrationBuilder.RenameColumn(
                name: "MovieRefId",
                table: "Purchases",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_MovieRefId",
                table: "Purchases",
                newName: "IX_Purchases_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Movies_MovieId",
                table: "Purchases",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Movies_MovieId",
                table: "Purchases");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Purchases",
                newName: "MovieRefId");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_MovieId",
                table: "Purchases",
                newName: "IX_Purchases_MovieRefId");

            migrationBuilder.AddColumn<int>(
                name: "MovidId",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Movies_MovieRefId",
                table: "Purchases",
                column: "MovieRefId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
