IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190301115608_InitialCreate')
BEGIN
    CREATE TABLE [Organ] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_Organ] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190301115608_InitialCreate')
BEGIN
    CREATE TABLE [Console] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Made] nvarchar(max) NULL,
        [OrganID] int NOT NULL,
        CONSTRAINT [PK_Console] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_Console_Organ_OrganID] FOREIGN KEY ([OrganID]) REFERENCES [Organ] ([ID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190301115608_InitialCreate')
BEGIN
    CREATE TABLE [Division] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [OrganID] int NOT NULL,
        CONSTRAINT [PK_Division] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_Division_Organ_OrganID] FOREIGN KEY ([OrganID]) REFERENCES [Organ] ([ID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190301115608_InitialCreate')
BEGIN
    CREATE TABLE [Pipe] (
        [ID] int NOT NULL,
        [Name] nvarchar(max) NULL,
        [Category] int NOT NULL,
        [Specification] int NOT NULL,
        [Material] int NOT NULL,
        [Price] decimal(18,2) NOT NULL,
        [Year] int NOT NULL,
        [DivisionID] int NOT NULL,
        CONSTRAINT [PK_Pipe] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_Pipe_Division_DivisionID] FOREIGN KEY ([DivisionID]) REFERENCES [Division] ([ID]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190301115608_InitialCreate')
BEGIN
    CREATE INDEX [IX_Console_OrganID] ON [Console] ([OrganID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190301115608_InitialCreate')
BEGIN
    CREATE INDEX [IX_Division_OrganID] ON [Division] ([OrganID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190301115608_InitialCreate')
BEGIN
    CREATE INDEX [IX_Pipe_DivisionID] ON [Pipe] ([DivisionID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190301115608_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190301115608_InitialCreate', N'2.2.2-servicing-10034');
END;

GO

