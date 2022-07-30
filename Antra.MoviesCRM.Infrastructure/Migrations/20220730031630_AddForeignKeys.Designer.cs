﻿// <auto-generated />
using System;
using Antra.MoviesCRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Antra.MoviesCRM.Infrastructure.Migrations
{
    [DbContext(typeof(MovieCrmDbContext))]
    [Migration("20220730031630_AddForeignKeys")]
    partial class AddForeignKeys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Cast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int?>("MovieCastCastId")
                        .HasColumnType("int");

                    b.Property<string>("MovieCastCharacter")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("MovieCastMovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProfilePath")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<string>("TmdbUrl")
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

                    b.HasIndex("MovieCastMovieId", "MovieCastCastId", "MovieCastCharacter");

                    b.ToTable("Casts");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Crew", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int?>("MovieCrewCrewId")
                        .HasColumnType("int");

                    b.Property<string>("MovieCrewDepartment")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("MovieCrewJob")
                        .HasColumnType("nvarchar(128)");

                    b.Property<int?>("MovieCrewMovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProfilePath")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<string>("TmdbUrl")
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

                    b.HasIndex("MovieCrewMovieId", "MovieCrewCrewId", "MovieCrewDepartment", "MovieCrewJob");

                    b.ToTable("Crews");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("MovieGenreGenreId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieGenreMovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("MovieGenreMovieId", "MovieGenreGenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BackDropUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<decimal?>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2(7)");

                    b.Property<int?>("FavoriteId")
                        .HasColumnType("int");

                    b.Property<string>("ImdbUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<int?>("MovieCastCastId")
                        .HasColumnType("int");

                    b.Property<string>("MovieCastCharacter")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("MovieCastMovieId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieCrewCrewId")
                        .HasColumnType("int");

                    b.Property<string>("MovieCrewDepartment")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("MovieCrewJob")
                        .HasColumnType("nvarchar(128)");

                    b.Property<int?>("MovieCrewMovieId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieGenreGenreId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieGenreMovieId")
                        .HasColumnType("int");

                    b.Property<string>("OriginalLanguage")
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("PosterUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int?>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2(7)");

                    b.Property<decimal?>("Revenue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ReviewMovieId")
                        .HasColumnType("int");

                    b.Property<int?>("ReviewUserId")
                        .HasColumnType("int");

                    b.Property<int?>("RunTime")
                        .HasColumnType("int");

                    b.Property<string>("Tagline")
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TmdbUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<int?>("TrailerId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2(7)");

                    b.HasKey("Id");

                    b.HasIndex("FavoriteId");

                    b.HasIndex("PurchaseId");

                    b.HasIndex("TrailerId");

                    b.HasIndex("MovieGenreMovieId", "MovieGenreGenreId");

                    b.HasIndex("ReviewMovieId", "ReviewUserId");

                    b.HasIndex("MovieCastMovieId", "MovieCastCastId", "MovieCastCharacter");

                    b.HasIndex("MovieCrewMovieId", "MovieCrewCrewId", "MovieCrewDepartment", "MovieCrewJob");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.MovieCast", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("CastId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MovieId", "CastId", "Character");

                    b.ToTable("MovieCasts");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.MovieCrew", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("CrewId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("MovieId", "CrewId", "Department", "Job");

                    b.ToTable("MovieCrews");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.MovieGenre", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.ToTable("MovieGenres");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MovidId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDateTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<Guid>("PurchaseNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Review", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(3,2)");

                    b.Property<string>("ReviewText")
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("MovieId", "UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("UserRoleRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("UserRoleUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserRoleRoleId", "UserRoleUserId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Trailer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.HasKey("Id");

                    b.ToTable("Trailers");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("HashedPassword")
                        .HasColumnType("nvarchar(1024)");

                    b.Property<bool?>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginDateTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime?>("LockoutEndDate")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(16)");

                    b.Property<int?>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<int?>("ReviewMovieId")
                        .HasColumnType("int");

                    b.Property<int?>("ReviewUserId")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(1024)");

                    b.Property<int?>("TrailerId")
                        .HasColumnType("int");

                    b.Property<bool?>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<int?>("UserRoleRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("UserRoleUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseId");

                    b.HasIndex("TrailerId");

                    b.HasIndex("ReviewMovieId", "ReviewUserId");

                    b.HasIndex("UserRoleRoleId", "UserRoleUserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.UserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Cast", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.MovieCast", null)
                        .WithMany("Casts")
                        .HasForeignKey("MovieCastMovieId", "MovieCastCastId", "MovieCastCharacter");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Crew", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.MovieCrew", null)
                        .WithMany("Crews")
                        .HasForeignKey("MovieCrewMovieId", "MovieCrewCrewId", "MovieCrewDepartment", "MovieCrewJob");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Genre", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.MovieGenre", null)
                        .WithMany("Genres")
                        .HasForeignKey("MovieGenreMovieId", "MovieGenreGenreId");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Movie", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.Favorite", null)
                        .WithMany("Movies")
                        .HasForeignKey("FavoriteId");

                    b.HasOne("Antra.MoviesCRM.Core.Entities.Purchase", null)
                        .WithMany("Movies")
                        .HasForeignKey("PurchaseId");

                    b.HasOne("Antra.MoviesCRM.Core.Entities.Trailer", null)
                        .WithMany("Movies")
                        .HasForeignKey("TrailerId");

                    b.HasOne("Antra.MoviesCRM.Core.Entities.MovieGenre", null)
                        .WithMany("Movies")
                        .HasForeignKey("MovieGenreMovieId", "MovieGenreGenreId");

                    b.HasOne("Antra.MoviesCRM.Core.Entities.Review", null)
                        .WithMany("Movies")
                        .HasForeignKey("ReviewMovieId", "ReviewUserId");

                    b.HasOne("Antra.MoviesCRM.Core.Entities.MovieCast", null)
                        .WithMany("Movies")
                        .HasForeignKey("MovieCastMovieId", "MovieCastCastId", "MovieCastCharacter");

                    b.HasOne("Antra.MoviesCRM.Core.Entities.MovieCrew", null)
                        .WithMany("Movies")
                        .HasForeignKey("MovieCrewMovieId", "MovieCrewCrewId", "MovieCrewDepartment", "MovieCrewJob");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Role", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.UserRole", null)
                        .WithMany("Roles")
                        .HasForeignKey("UserRoleRoleId", "UserRoleUserId");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.User", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.Purchase", null)
                        .WithMany("Users")
                        .HasForeignKey("PurchaseId");

                    b.HasOne("Antra.MoviesCRM.Core.Entities.Trailer", null)
                        .WithMany("Users")
                        .HasForeignKey("TrailerId");

                    b.HasOne("Antra.MoviesCRM.Core.Entities.Review", null)
                        .WithMany("Users")
                        .HasForeignKey("ReviewMovieId", "ReviewUserId");

                    b.HasOne("Antra.MoviesCRM.Core.Entities.UserRole", null)
                        .WithMany("Users")
                        .HasForeignKey("UserRoleRoleId", "UserRoleUserId");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Favorite", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.MovieCast", b =>
                {
                    b.Navigation("Casts");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.MovieCrew", b =>
                {
                    b.Navigation("Crews");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.MovieGenre", b =>
                {
                    b.Navigation("Genres");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Purchase", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Review", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Trailer", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.UserRole", b =>
                {
                    b.Navigation("Roles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
