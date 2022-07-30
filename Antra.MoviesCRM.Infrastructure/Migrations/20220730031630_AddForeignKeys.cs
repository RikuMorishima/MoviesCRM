using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.MoviesCRM.Infrastructure.Migrations
{
    public partial class AddForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Casts_CastId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "CastId",
                table: "Movies",
                newName: "TrailerId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CastId",
                table: "Movies",
                newName: "IX_Movies_TrailerId");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewMovieId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewUserId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrailerId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserRoleRoleId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserRoleUserId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserRoleRoleId",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserRoleUserId",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FavoriteId",
                table: "Movies",
                type: "int",
                nullable: true);

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
                name: "MovieCrewCrewId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieCrewDepartment",
                table: "Movies",
                type: "nvarchar(128)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieCrewJob",
                table: "Movies",
                type: "nvarchar(128)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieCrewMovieId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieGenreGenreId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieGenreMovieId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewMovieId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewUserId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieGenreGenreId",
                table: "Genres",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieGenreMovieId",
                table: "Genres",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieCrewCrewId",
                table: "Crews",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieCrewDepartment",
                table: "Crews",
                type: "nvarchar(128)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MovieCrewJob",
                table: "Crews",
                type: "nvarchar(128)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieCrewMovieId",
                table: "Crews",
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
                name: "IX_Users_PurchaseId",
                table: "Users",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ReviewMovieId_ReviewUserId",
                table: "Users",
                columns: new[] { "ReviewMovieId", "ReviewUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_TrailerId",
                table: "Users",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserRoleRoleId_UserRoleUserId",
                table: "Users",
                columns: new[] { "UserRoleRoleId", "UserRoleUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserRoleRoleId_UserRoleUserId",
                table: "Roles",
                columns: new[] { "UserRoleRoleId", "UserRoleUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_FavoriteId",
                table: "Movies",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Movies",
                columns: new[] { "MovieCastMovieId", "MovieCastCastId", "MovieCastCharacter" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob",
                table: "Movies",
                columns: new[] { "MovieCrewMovieId", "MovieCrewCrewId", "MovieCrewDepartment", "MovieCrewJob" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieGenreMovieId_MovieGenreGenreId",
                table: "Movies",
                columns: new[] { "MovieGenreMovieId", "MovieGenreGenreId" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_PurchaseId",
                table: "Movies",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ReviewMovieId_ReviewUserId",
                table: "Movies",
                columns: new[] { "ReviewMovieId", "ReviewUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Genres_MovieGenreMovieId_MovieGenreGenreId",
                table: "Genres",
                columns: new[] { "MovieGenreMovieId", "MovieGenreGenreId" });

            migrationBuilder.CreateIndex(
                name: "IX_Crews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob",
                table: "Crews",
                columns: new[] { "MovieCrewMovieId", "MovieCrewCrewId", "MovieCrewDepartment", "MovieCrewJob" });

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
                name: "FK_Crews_MovieCrews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob",
                table: "Crews",
                columns: new[] { "MovieCrewMovieId", "MovieCrewCrewId", "MovieCrewDepartment", "MovieCrewJob" },
                principalTable: "MovieCrews",
                principalColumns: new[] { "MovieId", "CrewId", "Department", "Job" });

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_MovieGenres_MovieGenreMovieId_MovieGenreGenreId",
                table: "Genres",
                columns: new[] { "MovieGenreMovieId", "MovieGenreGenreId" },
                principalTable: "MovieGenres",
                principalColumns: new[] { "MovieId", "GenreId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Favorites_FavoriteId",
                table: "Movies",
                column: "FavoriteId",
                principalTable: "Favorites",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieCasts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Movies",
                columns: new[] { "MovieCastMovieId", "MovieCastCastId", "MovieCastCharacter" },
                principalTable: "MovieCasts",
                principalColumns: new[] { "MovieId", "CastId", "Character" });

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieCrews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob",
                table: "Movies",
                columns: new[] { "MovieCrewMovieId", "MovieCrewCrewId", "MovieCrewDepartment", "MovieCrewJob" },
                principalTable: "MovieCrews",
                principalColumns: new[] { "MovieId", "CrewId", "Department", "Job" });

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieGenres_MovieGenreMovieId_MovieGenreGenreId",
                table: "Movies",
                columns: new[] { "MovieGenreMovieId", "MovieGenreGenreId" },
                principalTable: "MovieGenres",
                principalColumns: new[] { "MovieId", "GenreId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Purchases_PurchaseId",
                table: "Movies",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Reviews_ReviewMovieId_ReviewUserId",
                table: "Movies",
                columns: new[] { "ReviewMovieId", "ReviewUserId" },
                principalTable: "Reviews",
                principalColumns: new[] { "MovieId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Trailers_TrailerId",
                table: "Movies",
                column: "TrailerId",
                principalTable: "Trailers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_UserRoles_UserRoleRoleId_UserRoleUserId",
                table: "Roles",
                columns: new[] { "UserRoleRoleId", "UserRoleUserId" },
                principalTable: "UserRoles",
                principalColumns: new[] { "RoleId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Purchases_PurchaseId",
                table: "Users",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Reviews_ReviewMovieId_ReviewUserId",
                table: "Users",
                columns: new[] { "ReviewMovieId", "ReviewUserId" },
                principalTable: "Reviews",
                principalColumns: new[] { "MovieId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Trailers_TrailerId",
                table: "Users",
                column: "TrailerId",
                principalTable: "Trailers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_UserRoleRoleId_UserRoleUserId",
                table: "Users",
                columns: new[] { "UserRoleRoleId", "UserRoleUserId" },
                principalTable: "UserRoles",
                principalColumns: new[] { "RoleId", "UserId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Casts_MovieCasts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Casts");

            migrationBuilder.DropForeignKey(
                name: "FK_Crews_MovieCrews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob",
                table: "Crews");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_MovieGenres_MovieGenreMovieId_MovieGenreGenreId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Favorites_FavoriteId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieCasts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieCrews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieGenres_MovieGenreMovieId_MovieGenreGenreId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Purchases_PurchaseId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Reviews_ReviewMovieId_ReviewUserId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Trailers_TrailerId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_UserRoles_UserRoleRoleId_UserRoleUserId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Purchases_PurchaseId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Reviews_ReviewMovieId_ReviewUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Trailers_TrailerId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_UserRoleRoleId_UserRoleUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PurchaseId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ReviewMovieId_ReviewUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_TrailerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserRoleRoleId_UserRoleUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Roles_UserRoleRoleId_UserRoleUserId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Movies_FavoriteId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieGenreMovieId_MovieGenreGenreId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_PurchaseId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ReviewMovieId_ReviewUserId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Genres_MovieGenreMovieId_MovieGenreGenreId",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Crews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob",
                table: "Crews");

            migrationBuilder.DropIndex(
                name: "IX_Casts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter",
                table: "Casts");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReviewMovieId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReviewUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TrailerId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserRoleRoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserRoleUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserRoleRoleId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UserRoleUserId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "FavoriteId",
                table: "Movies");

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
                name: "MovieCrewCrewId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCrewDepartment",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCrewJob",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCrewMovieId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieGenreGenreId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieGenreMovieId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReviewMovieId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReviewUserId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieGenreGenreId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "MovieGenreMovieId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "MovieCrewCrewId",
                table: "Crews");

            migrationBuilder.DropColumn(
                name: "MovieCrewDepartment",
                table: "Crews");

            migrationBuilder.DropColumn(
                name: "MovieCrewJob",
                table: "Crews");

            migrationBuilder.DropColumn(
                name: "MovieCrewMovieId",
                table: "Crews");

            migrationBuilder.DropColumn(
                name: "MovieCastCastId",
                table: "Casts");

            migrationBuilder.DropColumn(
                name: "MovieCastCharacter",
                table: "Casts");

            migrationBuilder.DropColumn(
                name: "MovieCastMovieId",
                table: "Casts");

            migrationBuilder.RenameColumn(
                name: "TrailerId",
                table: "Movies",
                newName: "CastId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_TrailerId",
                table: "Movies",
                newName: "IX_Movies_CastId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Casts_CastId",
                table: "Movies",
                column: "CastId",
                principalTable: "Casts",
                principalColumn: "Id");
        }
    }
}
