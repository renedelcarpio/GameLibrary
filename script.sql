CREATE TABLE [Games] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(80) NOT NULL,
    [Description] nvarchar(300) NOT NULL,
    [ReleaseDate] datetime2 NULL,
    [Released] bit NOT NULL,
    [Developer] nvarchar(80) NOT NULL,
    [Platforms] nvarchar(120) NOT NULL,
    CONSTRAINT [PK_Games] PRIMARY KEY ([Id])
);
GO


