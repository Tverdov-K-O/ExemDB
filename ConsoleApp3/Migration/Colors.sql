CREATE TABLE [dbo].[Colors] (
    [Id]   UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Name] NVARCHAR (100)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Name] <> N'')
);

