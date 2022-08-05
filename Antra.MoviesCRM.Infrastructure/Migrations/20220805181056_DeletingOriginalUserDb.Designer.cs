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
    [Migration("20220805181056_DeletingOriginalUserDb")]
    partial class DeletingOriginalUserDb
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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProfilePath")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<string>("TmdbUrl")
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProfilePath")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<string>("TmdbUrl")
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

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

                    b.Property<string>("UserRefId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserRefId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

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

                    b.Property<string>("ImdbUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<string>("OriginalLanguage")
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("PosterUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2(7)");

                    b.Property<decimal?>("Revenue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RunTime")
                        .HasColumnType("int");

                    b.Property<string>("Tagline")
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TmdbUrl")
                        .HasColumnType("nvarchar(2084)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2(7)");

                    b.HasKey("Id");

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

                    b.HasIndex("CastId");

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

                    b.HasIndex("CrewId");

                    b.ToTable("MovieCrews");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.MovieGenre", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenres");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDateTime")
                        .HasColumnType("datetime2(7)");

                    b.Property<Guid>("PurchaseNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserRefId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserRefId");

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

                    b.Property<string>("UserRefId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MovieId", "UserId");

                    b.HasIndex("UserRefId");

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

                    b.HasKey("Id");

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

                    b.HasIndex("MovieId");

                    b.ToTable("Trailers");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(128)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Favorite", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.Movie", "MovieRef")
                        .WithMany("FavoritesRef")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Antra.MoviesCRM.Core.Entities.User", "UserRef")
                        .WithMany("FavoritesRef")
                        .HasForeignKey("UserRefId");

                    b.Navigation("MovieRef");

                    b.Navigation("UserRef");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.MovieCast", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.Cast", "CastRef")
                        .WithMany("movieCastsRef")
                        .HasForeignKey("CastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Antra.MoviesCRM.Core.Entities.Movie", "MovieRef")
                        .WithMany("MovieCastsRef")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CastRef");

                    b.Navigation("MovieRef");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.MovieCrew", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.Crew", "CrewRef")
                        .WithMany("MovieCrewsRef")
                        .HasForeignKey("CrewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Antra.MoviesCRM.Core.Entities.Movie", "MovieRef")
                        .WithMany("MovieCrewsRef")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CrewRef");

                    b.Navigation("MovieRef");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.MovieGenre", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.Genre", "GenreRef")
                        .WithMany("MovieGenresRef")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Antra.MoviesCRM.Core.Entities.Movie", "MovieRef")
                        .WithMany("MovieGenresRef")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenreRef");

                    b.Navigation("MovieRef");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Purchase", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.Movie", "MovieRef")
                        .WithMany("PurchasesRef")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Antra.MoviesCRM.Core.Entities.User", "UserRef")
                        .WithMany("PurchasesRef")
                        .HasForeignKey("UserRefId");

                    b.Navigation("MovieRef");

                    b.Navigation("UserRef");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Review", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.Movie", "MovieRef")
                        .WithMany("ReviewsRef")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Antra.MoviesCRM.Core.Entities.User", "UserRef")
                        .WithMany("ReviewsRef")
                        .HasForeignKey("UserRefId");

                    b.Navigation("MovieRef");

                    b.Navigation("UserRef");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Trailer", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.Movie", "MovieRef")
                        .WithMany("TrailersRef")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieRef");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Antra.MoviesCRM.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Antra.MoviesCRM.Core.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Cast", b =>
                {
                    b.Navigation("movieCastsRef");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Crew", b =>
                {
                    b.Navigation("MovieCrewsRef");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Genre", b =>
                {
                    b.Navigation("MovieGenresRef");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.Movie", b =>
                {
                    b.Navigation("FavoritesRef");

                    b.Navigation("MovieCastsRef");

                    b.Navigation("MovieCrewsRef");

                    b.Navigation("MovieGenresRef");

                    b.Navigation("PurchasesRef");

                    b.Navigation("ReviewsRef");

                    b.Navigation("TrailersRef");
                });

            modelBuilder.Entity("Antra.MoviesCRM.Core.Entities.User", b =>
                {
                    b.Navigation("FavoritesRef");

                    b.Navigation("PurchasesRef");

                    b.Navigation("ReviewsRef");
                });
#pragma warning restore 612, 618
        }
    }
}
