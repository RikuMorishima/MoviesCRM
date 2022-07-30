using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.MoviesCRM.Infrastructure.Migrations
{
    public partial class Check1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Casts_MovieCasts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Casts");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieCasts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Casts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Casts");

            migrationBuilder.DropColumn(
                name: "MovieCastCastId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCastCharacter",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCastMovieId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCastCastId",
                table: "Casts");

            migrationBuilder.DropColumn(
                name: "MovieCastCharacter",
                table: "Casts");

            migrationBuilder.DropColumn(
                name: "MovieCastMovieId",
                table: "Casts");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCasts_CastId",
                table: "MovieCasts",
                column: "CastId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCasts_Casts_CastId",
                table: "MovieCasts",
                column: "CastId",
                principalTable: "Casts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCasts_Movies_MovieId",
                table: "MovieCasts",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieCasts_Casts_CastId",
                table: "MovieCasts");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCasts_Movies_MovieId",
                table: "MovieCasts");

            migrationBuilder.DropIndex(
                name: "IX_MovieCasts_CastId",
                table: "MovieCasts");

            migrationBuilder.AddColumn<int>(
                name: "MovieCastCastId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieCastCharacter",
                table: "Movies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieCastMovieId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieCastCastId",
                table: "Casts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieCastCharacter",
                table: "Casts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieCastMovieId",
                table: "Casts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Movies",
                columns: new[] { "MovieCastMovieId", "MovieCastCastId", "MovieCastCharacter" });

            migrationBuilder.CreateIndex(
                name: "IX_Casts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Casts",
                columns: new[] { "MovieCastMovieId", "MovieCastCastId", "MovieCastCharacter" });

            migrationBuilder.AddForeignKey(
                name: "FK_Casts_MovieCasts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Casts",
                columns: new[] { "MovieCastMovieId", "MovieCastCastId", "MovieCastCharacter" },
                principalTable: "MovieCasts",
                principalColumns: new[] { "MovieId", "CastId", "Character" });

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieCasts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Movies",
                columns: new[] { "MovieCastMovieId", "MovieCastCastId", "MovieCastCharacter" },
                principalTable: "MovieCasts",
                principalColumns: new[] { "MovieId", "CastId", "Character" });
        }
    }
}
