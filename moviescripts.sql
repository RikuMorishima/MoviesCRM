IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Crews] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(128) NULL,
    [Gender] nvarchar(MAX) NULL,
    [TmdbUrl] nvarchar(MAX) NULL,
    [ProfilePath] nvarchar(2084) NULL,
    CONSTRAINT [PK_Crews] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Favorites] (
    [Id] int NOT NULL IDENTITY,
    [MovieId] int NOT NULL,
    [UserId] int NOT NULL,
    CONSTRAINT [PK_Favorites] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [MovieCast] (
    [MovieId] int NOT NULL,
    [CastId] int NOT NULL,
    [Character] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_MovieCast] PRIMARY KEY ([MovieId], [CastId], [Character])
);
GO

CREATE TABLE [MovieCrews] (
    [MovieId] int NOT NULL,
    [CrewId] int NOT NULL,
    [Department] nvarchar(128) NOT NULL,
    [Job] nvarchar(128) NOT NULL,
    CONSTRAINT [PK_MovieCrews] PRIMARY KEY ([MovieId], [CrewId], [Department], [Job])
);
GO

CREATE TABLE [MovieGenre] (
    [MovieId] int NOT NULL,
    [GenreId] int NOT NULL,
    CONSTRAINT [PK_MovieGenre] PRIMARY KEY ([MovieId], [GenreId])
);
GO

CREATE TABLE [Purchases] (
    [Id] int NOT NULL IDENTITY,
    [UserId] int NOT NULL,
    [PurchaseNumber] uniqueidentifier NOT NULL,
    [TotalPrice] decimal(18,2) NOT NULL,
    [PurchaseDateTime] datetime2(7) NOT NULL,
    [MovidId] int NOT NULL,
    CONSTRAINT [PK_Purchases] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Reviews] (
    [MovieId] int NOT NULL,
    [UserId] int NOT NULL,
    [Rating] decimal(3,2) NOT NULL,
    [ReviewText] nvarchar(MAX) NULL,
    CONSTRAINT [PK_Reviews] PRIMARY KEY ([MovieId], [UserId])
);
GO

CREATE TABLE [Roles] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(20) NOT NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [UserRoles] (
    [UserId] int NOT NULL,
    [RoleId] int NOT NULL,
    CONSTRAINT [PK_UserRoles] PRIMARY KEY ([RoleId], [UserId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220729234325_AddingTables', N'6.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [MovieGenre] DROP CONSTRAINT [PK_MovieGenre];
GO

ALTER TABLE [MovieCast] DROP CONSTRAINT [PK_MovieCast];
GO

EXEC sp_rename N'[MovieGenre]', N'MovieGenres';
GO

EXEC sp_rename N'[MovieCast]', N'MovieCasts';
GO

ALTER TABLE [MovieGenres] ADD CONSTRAINT [PK_MovieGenres] PRIMARY KEY ([MovieId], [GenreId]);
GO

ALTER TABLE [MovieCasts] ADD CONSTRAINT [PK_MovieCasts] PRIMARY KEY ([MovieId], [CastId], [Character]);
GO

CREATE TABLE [Casts] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(128) NULL,
    [Gender] nvarchar(MAX) NULL,
    [TmdbUrl] nvarchar(MAX) NULL,
    [ProfilePath] nvarchar(2084) NULL,
    CONSTRAINT [PK_Casts] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Genres] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(64) NOT NULL,
    CONSTRAINT [PK_Genres] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Trailers] (
    [Id] int NOT NULL IDENTITY,
    [MovieId] int NOT NULL,
    [TrailerUrl] nvarchar(2084) NULL,
    [Name] nvarchar(2084) NULL,
    CONSTRAINT [PK_Trailers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Users] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(128) NULL,
    [LastName] nvarchar(128) NULL,
    [DateOfBirth] datetime2(7) NULL,
    [Email] nvarchar(256) NULL,
    [HashedPassword] nvarchar(1024) NULL,
    [Salt] nvarchar(1024) NULL,
    [PhoneNumber] nvarchar(16) NULL,
    [TwoFactorEnabled] bit NULL,
    [LockoutEndDate] datetime2(7) NULL,
    [LastLoginDateTime] datetime2(7) NULL,
    [IsLocked] bit NULL,
    [AccessFailedCount] int NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Movies] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(256) NOT NULL,
    [Overview] nvarchar(MAX) NULL,
    [Tagline] nvarchar(512) NULL,
    [Budget] decimal(18,2) NULL,
    [Revenue] decimal(18,2) NULL,
    [ImdbUrl] nvarchar(2084) NULL,
    [TmdbUrl] nvarchar(2084) NULL,
    [PosterUrl] nvarchar(2084) NULL,
    [BackDropUrl] nvarchar(2084) NULL,
    [OriginalLanguage] nvarchar(64) NULL,
    [ReleaseDate] datetime2(7) NULL,
    [RunTime] int NULL,
    [Price] decimal(5,2) NULL,
    [CreatedDate] datetime2(7) NULL,
    [UpdatedDate] datetime2(7) NULL,
    [UpdatedBy] nvarchar(MAX) NULL,
    [CreatedBy] nvarchar(MAX) NULL,
    [CastId] int NULL,
    CONSTRAINT [PK_Movies] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Movies_Casts_CastId] FOREIGN KEY ([CastId]) REFERENCES [Casts] ([Id])
);
GO

CREATE INDEX [IX_Movies_CastId] ON [Movies] ([CastId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730024417_AddCast', N'6.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Movies] DROP CONSTRAINT [FK_Movies_Casts_CastId];
GO

EXEC sp_rename N'[Movies].[CastId]', N'TrailerId', N'COLUMN';
GO

EXEC sp_rename N'[Movies].[IX_Movies_CastId]', N'IX_Movies_TrailerId', N'INDEX';
GO

ALTER TABLE [Users] ADD [PurchaseId] int NULL;
GO

ALTER TABLE [Users] ADD [ReviewMovieId] int NULL;
GO

ALTER TABLE [Users] ADD [ReviewUserId] int NULL;
GO

ALTER TABLE [Users] ADD [TrailerId] int NULL;
GO

ALTER TABLE [Users] ADD [UserRoleRoleId] int NULL;
GO

ALTER TABLE [Users] ADD [UserRoleUserId] int NULL;
GO

ALTER TABLE [Roles] ADD [UserRoleRoleId] int NULL;
GO

ALTER TABLE [Roles] ADD [UserRoleUserId] int NULL;
GO

ALTER TABLE [Movies] ADD [FavoriteId] int NULL;
GO

ALTER TABLE [Movies] ADD [MovieCastCastId] int NULL;
GO

ALTER TABLE [Movies] ADD [MovieCastCharacter] nvarchar(450) NULL;
GO

ALTER TABLE [Movies] ADD [MovieCastMovieId] int NULL;
GO

ALTER TABLE [Movies] ADD [MovieCrewCrewId] int NULL;
GO

ALTER TABLE [Movies] ADD [MovieCrewDepartment] nvarchar(128) NULL;
GO

ALTER TABLE [Movies] ADD [MovieCrewJob] nvarchar(128) NULL;
GO

ALTER TABLE [Movies] ADD [MovieCrewMovieId] int NULL;
GO

ALTER TABLE [Movies] ADD [MovieGenreGenreId] int NULL;
GO

ALTER TABLE [Movies] ADD [MovieGenreMovieId] int NULL;
GO

ALTER TABLE [Movies] ADD [PurchaseId] int NULL;
GO

ALTER TABLE [Movies] ADD [ReviewMovieId] int NULL;
GO

ALTER TABLE [Movies] ADD [ReviewUserId] int NULL;
GO

ALTER TABLE [Genres] ADD [MovieGenreGenreId] int NULL;
GO

ALTER TABLE [Genres] ADD [MovieGenreMovieId] int NULL;
GO

ALTER TABLE [Crews] ADD [MovieCrewCrewId] int NULL;
GO

ALTER TABLE [Crews] ADD [MovieCrewDepartment] nvarchar(128) NULL;
GO

ALTER TABLE [Crews] ADD [MovieCrewJob] nvarchar(128) NULL;
GO

ALTER TABLE [Crews] ADD [MovieCrewMovieId] int NULL;
GO

ALTER TABLE [Casts] ADD [MovieCastCastId] int NULL;
GO

ALTER TABLE [Casts] ADD [MovieCastCharacter] nvarchar(450) NULL;
GO

ALTER TABLE [Casts] ADD [MovieCastMovieId] int NULL;
GO

CREATE INDEX [IX_Users_PurchaseId] ON [Users] ([PurchaseId]);
GO

CREATE INDEX [IX_Users_ReviewMovieId_ReviewUserId] ON [Users] ([ReviewMovieId], [ReviewUserId]);
GO

CREATE INDEX [IX_Users_TrailerId] ON [Users] ([TrailerId]);
GO

CREATE INDEX [IX_Users_UserRoleRoleId_UserRoleUserId] ON [Users] ([UserRoleRoleId], [UserRoleUserId]);
GO

CREATE INDEX [IX_Roles_UserRoleRoleId_UserRoleUserId] ON [Roles] ([UserRoleRoleId], [UserRoleUserId]);
GO

CREATE INDEX [IX_Movies_FavoriteId] ON [Movies] ([FavoriteId]);
GO

CREATE INDEX [IX_Movies_MovieCastMovieId_MovieCastCastId_MovieCastCharacter] ON [Movies] ([MovieCastMovieId], [MovieCastCastId], [MovieCastCharacter]);
GO

CREATE INDEX [IX_Movies_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob] ON [Movies] ([MovieCrewMovieId], [MovieCrewCrewId], [MovieCrewDepartment], [MovieCrewJob]);
GO

CREATE INDEX [IX_Movies_MovieGenreMovieId_MovieGenreGenreId] ON [Movies] ([MovieGenreMovieId], [MovieGenreGenreId]);
GO

CREATE INDEX [IX_Movies_PurchaseId] ON [Movies] ([PurchaseId]);
GO

CREATE INDEX [IX_Movies_ReviewMovieId_ReviewUserId] ON [Movies] ([ReviewMovieId], [ReviewUserId]);
GO

CREATE INDEX [IX_Genres_MovieGenreMovieId_MovieGenreGenreId] ON [Genres] ([MovieGenreMovieId], [MovieGenreGenreId]);
GO

CREATE INDEX [IX_Crews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob] ON [Crews] ([MovieCrewMovieId], [MovieCrewCrewId], [MovieCrewDepartment], [MovieCrewJob]);
GO

CREATE INDEX [IX_Casts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter] ON [Casts] ([MovieCastMovieId], [MovieCastCastId], [MovieCastCharacter]);
GO

ALTER TABLE [Casts] ADD CONSTRAINT [FK_Casts_MovieCasts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter] FOREIGN KEY ([MovieCastMovieId], [MovieCastCastId], [MovieCastCharacter]) REFERENCES [MovieCasts] ([MovieId], [CastId], [Character]);
GO

ALTER TABLE [Crews] ADD CONSTRAINT [FK_Crews_MovieCrews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob] FOREIGN KEY ([MovieCrewMovieId], [MovieCrewCrewId], [MovieCrewDepartment], [MovieCrewJob]) REFERENCES [MovieCrews] ([MovieId], [CrewId], [Department], [Job]);
GO

ALTER TABLE [Genres] ADD CONSTRAINT [FK_Genres_MovieGenres_MovieGenreMovieId_MovieGenreGenreId] FOREIGN KEY ([MovieGenreMovieId], [MovieGenreGenreId]) REFERENCES [MovieGenres] ([MovieId], [GenreId]);
GO

ALTER TABLE [Movies] ADD CONSTRAINT [FK_Movies_Favorites_FavoriteId] FOREIGN KEY ([FavoriteId]) REFERENCES [Favorites] ([Id]);
GO

ALTER TABLE [Movies] ADD CONSTRAINT [FK_Movies_MovieCasts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter] FOREIGN KEY ([MovieCastMovieId], [MovieCastCastId], [MovieCastCharacter]) REFERENCES [MovieCasts] ([MovieId], [CastId], [Character]);
GO

ALTER TABLE [Movies] ADD CONSTRAINT [FK_Movies_MovieCrews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob] FOREIGN KEY ([MovieCrewMovieId], [MovieCrewCrewId], [MovieCrewDepartment], [MovieCrewJob]) REFERENCES [MovieCrews] ([MovieId], [CrewId], [Department], [Job]);
GO

ALTER TABLE [Movies] ADD CONSTRAINT [FK_Movies_MovieGenres_MovieGenreMovieId_MovieGenreGenreId] FOREIGN KEY ([MovieGenreMovieId], [MovieGenreGenreId]) REFERENCES [MovieGenres] ([MovieId], [GenreId]);
GO

ALTER TABLE [Movies] ADD CONSTRAINT [FK_Movies_Purchases_PurchaseId] FOREIGN KEY ([PurchaseId]) REFERENCES [Purchases] ([Id]);
GO

ALTER TABLE [Movies] ADD CONSTRAINT [FK_Movies_Reviews_ReviewMovieId_ReviewUserId] FOREIGN KEY ([ReviewMovieId], [ReviewUserId]) REFERENCES [Reviews] ([MovieId], [UserId]);
GO

ALTER TABLE [Movies] ADD CONSTRAINT [FK_Movies_Trailers_TrailerId] FOREIGN KEY ([TrailerId]) REFERENCES [Trailers] ([Id]);
GO

ALTER TABLE [Roles] ADD CONSTRAINT [FK_Roles_UserRoles_UserRoleRoleId_UserRoleUserId] FOREIGN KEY ([UserRoleRoleId], [UserRoleUserId]) REFERENCES [UserRoles] ([RoleId], [UserId]);
GO

ALTER TABLE [Users] ADD CONSTRAINT [FK_Users_Purchases_PurchaseId] FOREIGN KEY ([PurchaseId]) REFERENCES [Purchases] ([Id]);
GO

ALTER TABLE [Users] ADD CONSTRAINT [FK_Users_Reviews_ReviewMovieId_ReviewUserId] FOREIGN KEY ([ReviewMovieId], [ReviewUserId]) REFERENCES [Reviews] ([MovieId], [UserId]);
GO

ALTER TABLE [Users] ADD CONSTRAINT [FK_Users_Trailers_TrailerId] FOREIGN KEY ([TrailerId]) REFERENCES [Trailers] ([Id]);
GO

ALTER TABLE [Users] ADD CONSTRAINT [FK_Users_UserRoles_UserRoleRoleId_UserRoleUserId] FOREIGN KEY ([UserRoleRoleId], [UserRoleUserId]) REFERENCES [UserRoles] ([RoleId], [UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730031630_AddForeignKeys', N'6.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730182619_Test', N'6.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Casts] DROP CONSTRAINT [FK_Casts_MovieCasts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter];
GO

ALTER TABLE [Movies] DROP CONSTRAINT [FK_Movies_MovieCasts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter];
GO

DROP INDEX [IX_Movies_MovieCastMovieId_MovieCastCastId_MovieCastCharacter] ON [Movies];
GO

DROP INDEX [IX_Casts_MovieCastMovieId_MovieCastCastId_MovieCastCharacter] ON [Casts];
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'MovieCastCastId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Movies] DROP COLUMN [MovieCastCastId];
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'MovieCastCharacter');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Movies] DROP COLUMN [MovieCastCharacter];
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'MovieCastMovieId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Movies] DROP COLUMN [MovieCastMovieId];
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Casts]') AND [c].[name] = N'MovieCastCastId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Casts] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Casts] DROP COLUMN [MovieCastCastId];
GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Casts]') AND [c].[name] = N'MovieCastCharacter');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Casts] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Casts] DROP COLUMN [MovieCastCharacter];
GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Casts]') AND [c].[name] = N'MovieCastMovieId');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Casts] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Casts] DROP COLUMN [MovieCastMovieId];
GO

CREATE INDEX [IX_MovieCasts_CastId] ON [MovieCasts] ([CastId]);
GO

ALTER TABLE [MovieCasts] ADD CONSTRAINT [FK_MovieCasts_Casts_CastId] FOREIGN KEY ([CastId]) REFERENCES [Casts] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [MovieCasts] ADD CONSTRAINT [FK_MovieCasts_Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730193410_Check1', N'6.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Crews] DROP CONSTRAINT [FK_Crews_MovieCrews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob];
GO

ALTER TABLE [Genres] DROP CONSTRAINT [FK_Genres_MovieGenres_MovieGenreMovieId_MovieGenreGenreId];
GO

ALTER TABLE [Movies] DROP CONSTRAINT [FK_Movies_Favorites_FavoriteId];
GO

ALTER TABLE [Movies] DROP CONSTRAINT [FK_Movies_MovieCrews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob];
GO

ALTER TABLE [Movies] DROP CONSTRAINT [FK_Movies_MovieGenres_MovieGenreMovieId_MovieGenreGenreId];
GO

ALTER TABLE [Movies] DROP CONSTRAINT [FK_Movies_Purchases_PurchaseId];
GO

ALTER TABLE [Movies] DROP CONSTRAINT [FK_Movies_Reviews_ReviewMovieId_ReviewUserId];
GO

ALTER TABLE [Movies] DROP CONSTRAINT [FK_Movies_Trailers_TrailerId];
GO

ALTER TABLE [Roles] DROP CONSTRAINT [FK_Roles_UserRoles_UserRoleRoleId_UserRoleUserId];
GO

ALTER TABLE [Users] DROP CONSTRAINT [FK_Users_Purchases_PurchaseId];
GO

ALTER TABLE [Users] DROP CONSTRAINT [FK_Users_Reviews_ReviewMovieId_ReviewUserId];
GO

ALTER TABLE [Users] DROP CONSTRAINT [FK_Users_Trailers_TrailerId];
GO

ALTER TABLE [Users] DROP CONSTRAINT [FK_Users_UserRoles_UserRoleRoleId_UserRoleUserId];
GO

DROP INDEX [IX_Users_PurchaseId] ON [Users];
GO

DROP INDEX [IX_Users_ReviewMovieId_ReviewUserId] ON [Users];
GO

DROP INDEX [IX_Users_TrailerId] ON [Users];
GO

DROP INDEX [IX_Users_UserRoleRoleId_UserRoleUserId] ON [Users];
GO

DROP INDEX [IX_Roles_UserRoleRoleId_UserRoleUserId] ON [Roles];
GO

DROP INDEX [IX_Movies_FavoriteId] ON [Movies];
GO

DROP INDEX [IX_Movies_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob] ON [Movies];
GO

DROP INDEX [IX_Movies_MovieGenreMovieId_MovieGenreGenreId] ON [Movies];
GO

DROP INDEX [IX_Movies_PurchaseId] ON [Movies];
GO

DROP INDEX [IX_Movies_ReviewMovieId_ReviewUserId] ON [Movies];
GO

DROP INDEX [IX_Movies_TrailerId] ON [Movies];
GO

DROP INDEX [IX_Genres_MovieGenreMovieId_MovieGenreGenreId] ON [Genres];
GO

DROP INDEX [IX_Crews_MovieCrewMovieId_MovieCrewCrewId_MovieCrewDepartment_MovieCrewJob] ON [Crews];
GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'PurchaseId');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Users] DROP COLUMN [PurchaseId];
GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'ReviewMovieId');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Users] DROP COLUMN [ReviewMovieId];
GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'ReviewUserId');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Users] DROP COLUMN [ReviewUserId];
GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'TrailerId');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [Users] DROP COLUMN [TrailerId];
GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'UserRoleRoleId');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [Users] DROP COLUMN [UserRoleRoleId];
GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'UserRoleUserId');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [Users] DROP COLUMN [UserRoleUserId];
GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Roles]') AND [c].[name] = N'UserRoleRoleId');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Roles] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [Roles] DROP COLUMN [UserRoleRoleId];
GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Roles]') AND [c].[name] = N'UserRoleUserId');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Roles] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [Roles] DROP COLUMN [UserRoleUserId];
GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'FavoriteId');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [Movies] DROP COLUMN [FavoriteId];
GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'MovieCrewCrewId');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [Movies] DROP COLUMN [MovieCrewCrewId];
GO

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'MovieCrewDepartment');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [Movies] DROP COLUMN [MovieCrewDepartment];
GO

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'MovieCrewJob');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [Movies] DROP COLUMN [MovieCrewJob];
GO

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'MovieCrewMovieId');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [Movies] DROP COLUMN [MovieCrewMovieId];
GO

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'MovieGenreGenreId');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var19 + '];');
ALTER TABLE [Movies] DROP COLUMN [MovieGenreGenreId];
GO

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'MovieGenreMovieId');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [Movies] DROP COLUMN [MovieGenreMovieId];
GO

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'PurchaseId');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [Movies] DROP COLUMN [PurchaseId];
GO

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'ReviewMovieId');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [Movies] DROP COLUMN [ReviewMovieId];
GO

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'ReviewUserId');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [Movies] DROP COLUMN [ReviewUserId];
GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Movies]') AND [c].[name] = N'TrailerId');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [Movies] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [Movies] DROP COLUMN [TrailerId];
GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Genres]') AND [c].[name] = N'MovieGenreGenreId');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [Genres] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [Genres] DROP COLUMN [MovieGenreGenreId];
GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Genres]') AND [c].[name] = N'MovieGenreMovieId');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [Genres] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [Genres] DROP COLUMN [MovieGenreMovieId];
GO

DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Crews]') AND [c].[name] = N'MovieCrewCrewId');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [Crews] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [Crews] DROP COLUMN [MovieCrewCrewId];
GO

DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Crews]') AND [c].[name] = N'MovieCrewDepartment');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [Crews] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [Crews] DROP COLUMN [MovieCrewDepartment];
GO

DECLARE @var29 sysname;
SELECT @var29 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Crews]') AND [c].[name] = N'MovieCrewJob');
IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [Crews] DROP CONSTRAINT [' + @var29 + '];');
ALTER TABLE [Crews] DROP COLUMN [MovieCrewJob];
GO

DECLARE @var30 sysname;
SELECT @var30 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Crews]') AND [c].[name] = N'MovieCrewMovieId');
IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [Crews] DROP CONSTRAINT [' + @var30 + '];');
ALTER TABLE [Crews] DROP COLUMN [MovieCrewMovieId];
GO

ALTER TABLE [Trailers] ADD [UserId] int NULL;
GO

ALTER TABLE [Purchases] ADD [MovieRefId] int NOT NULL DEFAULT 0;
GO

CREATE INDEX [IX_UserRoles_UserId] ON [UserRoles] ([UserId]);
GO

CREATE INDEX [IX_Trailers_MovieId] ON [Trailers] ([MovieId]);
GO

CREATE INDEX [IX_Trailers_UserId] ON [Trailers] ([UserId]);
GO

CREATE INDEX [IX_Reviews_UserId] ON [Reviews] ([UserId]);
GO

CREATE INDEX [IX_Purchases_MovieRefId] ON [Purchases] ([MovieRefId]);
GO

CREATE INDEX [IX_Purchases_UserId] ON [Purchases] ([UserId]);
GO

CREATE INDEX [IX_MovieGenres_GenreId] ON [MovieGenres] ([GenreId]);
GO

CREATE INDEX [IX_MovieCrews_CrewId] ON [MovieCrews] ([CrewId]);
GO

CREATE INDEX [IX_Favorites_MovieId] ON [Favorites] ([MovieId]);
GO

CREATE INDEX [IX_Favorites_UserId] ON [Favorites] ([UserId]);
GO

ALTER TABLE [Favorites] ADD CONSTRAINT [FK_Favorites_Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [Favorites] ADD CONSTRAINT [FK_Favorites_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [MovieCrews] ADD CONSTRAINT [FK_MovieCrews_Crews_CrewId] FOREIGN KEY ([CrewId]) REFERENCES [Crews] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [MovieCrews] ADD CONSTRAINT [FK_MovieCrews_Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [MovieGenres] ADD CONSTRAINT [FK_MovieGenres_Genres_GenreId] FOREIGN KEY ([GenreId]) REFERENCES [Genres] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [MovieGenres] ADD CONSTRAINT [FK_MovieGenres_Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [Purchases] ADD CONSTRAINT [FK_Purchases_Movies_MovieRefId] FOREIGN KEY ([MovieRefId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [Purchases] ADD CONSTRAINT [FK_Purchases_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [Reviews] ADD CONSTRAINT [FK_Reviews_Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [Reviews] ADD CONSTRAINT [FK_Reviews_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [Trailers] ADD CONSTRAINT [FK_Trailers_Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [Trailers] ADD CONSTRAINT [FK_Trailers_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]);
GO

ALTER TABLE [UserRoles] ADD CONSTRAINT [FK_UserRoles_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [UserRoles] ADD CONSTRAINT [FK_UserRoles_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730194612_Check2', N'6.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Trailers] DROP CONSTRAINT [FK_Trailers_Users_UserId];
GO

DROP INDEX [IX_Trailers_UserId] ON [Trailers];
GO

DECLARE @var31 sysname;
SELECT @var31 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Trailers]') AND [c].[name] = N'UserId');
IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [Trailers] DROP CONSTRAINT [' + @var31 + '];');
ALTER TABLE [Trailers] DROP COLUMN [UserId];
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730195107_Check3', N'6.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Purchases] DROP CONSTRAINT [FK_Purchases_Movies_MovieRefId];
GO

DECLARE @var32 sysname;
SELECT @var32 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Purchases]') AND [c].[name] = N'MovidId');
IF @var32 IS NOT NULL EXEC(N'ALTER TABLE [Purchases] DROP CONSTRAINT [' + @var32 + '];');
ALTER TABLE [Purchases] DROP COLUMN [MovidId];
GO

EXEC sp_rename N'[Purchases].[MovieRefId]', N'MovieId', N'COLUMN';
GO

EXEC sp_rename N'[Purchases].[IX_Purchases_MovieRefId]', N'IX_Purchases_MovieId', N'INDEX';
GO

ALTER TABLE [Purchases] ADD CONSTRAINT [FK_Purchases_Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730195433_Check4', N'6.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730221222_CheckingMovie', N'6.0.7');
GO

COMMIT;
GO

