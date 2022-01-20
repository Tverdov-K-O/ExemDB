CREATE TABLE [dbo].[Sizes] (
    [Id]   UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Name] NVARCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Name] <> N'')
);

