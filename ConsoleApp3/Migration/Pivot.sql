CREATE TABLE [dbo].[Pivot] (
    [ProductId] UNIQUEIDENTIFIER NOT NULL,
    [ColorId]   UNIQUEIDENTIFIER NOT NULL,
    [SizeId]    UNIQUEIDENTIFIER NOT NULL,
    [GenderId]  UNIQUEIDENTIFIER NULL,
    [Count]     INT              DEFAULT ((0)) NOT NULL,
    [Prise]     MONEY            NOT NULL,
    CONSTRAINT [FK_Pivot_ToSizes] FOREIGN KEY ([SizeId]) REFERENCES [dbo].[Sizes] ([Id]),
    CONSTRAINT [FK_Pivot_ToGender] FOREIGN KEY ([GenderId]) REFERENCES [dbo].[Genders] ([Id]),
    CONSTRAINT [FK_Pivot_ToColors] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([Id]),
    CONSTRAINT [FK_Pivot_ToProducts] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Poducts] ([Id])
);

