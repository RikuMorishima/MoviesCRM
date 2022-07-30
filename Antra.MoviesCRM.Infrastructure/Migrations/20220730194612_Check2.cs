using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Antra.MoviesCRM.Infrastructure.Migrations
{
    public partial class Check2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_Movies_TrailerId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Genres_MovieGenreMovieId_MovieGenreGenreId",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Crews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob",
                table: "Crews");

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
                name: "TrailerId",
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

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Trailers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieRefId",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailers_MovieId",
                table: "Trailers",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Trailers_UserId",
                table: "Trailers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_MovieRefId",
                table: "Purchases",
                column: "MovieRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_UserId",
                table: "Purchases",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenreId",
                table: "MovieGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCrews_CrewId",
                table: "MovieCrews",
                column: "CrewId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_MovieId",
                table: "Favorites",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Movies_MovieId",
                table: "Favorites",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Users_UserId",
                table: "Favorites",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCrews_Crews_CrewId",
                table: "MovieCrews",
                column: "CrewId",
                principalTable: "Crews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCrews_Movies_MovieId",
                table: "MovieCrews",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Movies_MovieRefId",
                table: "Purchases",
                column: "MovieRefId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Users_UserId",
                table: "Purchases",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Reviews",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trailers_Movies_MovieId",
                table: "Trailers",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trailers_Users_UserId",
                table: "Trailers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Movies_MovieId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Users_UserId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCrews_Crews_CrewId",
                table: "MovieCrews");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCrews_Movies_MovieId",
                table: "MovieCrews");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Genres_GenreId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Movies_MovieId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Movies_MovieRefId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Users_UserId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Movies_MovieId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Trailers_Movies_MovieId",
                table: "Trailers");

            migrationBuilder.DropForeignKey(
                name: "FK_Trailers_Users_UserId",
                table: "Trailers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_Trailers_MovieId",
                table: "Trailers");

            migrationBuilder.DropIndex(
                name: "IX_Trailers_UserId",
                table: "Trailers");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_MovieRefId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_UserId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenres_GenreId",
                table: "MovieGenres");

            migrationBuilder.DropIndex(
                name: "IX_MovieCrews_CrewId",
                table: "MovieCrews");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_MovieId",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "MovieRefId",
                table: "Purchases");

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
                name: "TrailerId",
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
                name: "IX_Movies_TrailerId",
                table: "Movies",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_MovieGenreMovieId_MovieGenreGenreId",
                table: "Genres",
                columns: new[] { "MovieGenreMovieId", "MovieGenreGenreId" });

            migrationBuilder.CreateIndex(
                name: "IX_Crews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob",
                table: "Crews",
                columns: new[] { "MovieCrewMovieId", "MovieCrewCrewId", "MovieCrewDepartment", "MovieCrewJob" });

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
    }
}
