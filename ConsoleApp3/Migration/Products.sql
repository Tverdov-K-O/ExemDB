CREATE TABLE [dbo].[Poducts] (
    [Id]         UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Name]       NVARCHAR (256)   NOT NULL,
    [CategoryId] UNIQUEIDENTIFIER NOT NULL,
    [VenderId]   UNIQUEIDENTIFIER NOT NULL,
    [QualityId]  UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Name] <> N''),
    CONSTRAINT [FK_Pivot_ToCategories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id]),
    CONSTRAINT [FK_Pivot_ToQualities] FOREIGN KEY ([QualityId]) REFERENCES [dbo].[Qualities] ([Id]),
    CONSTRAINT [FK_Pivot_ToVender] FOREIGN KEY ([VenderId]) REFERENCES [dbo].[Vender] ([Id])
);

