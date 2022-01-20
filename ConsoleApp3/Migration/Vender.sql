CREATE TABLE [dbo].[Vender] (
    [Id]   UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Name] NVARCHAR (256)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Name] <> N'')
);

