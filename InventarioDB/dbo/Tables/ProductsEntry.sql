CREATE TABLE [dbo].[ProductsEntry] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [ProductId] INT             NOT NULL,
    [Quantity]  INT             NOT NULL,
    [Price]     DECIMAL (18, 2) NOT NULL,
    [EntryDate] DATE            NOT NULL,
    CONSTRAINT [PK_ProductsEntry] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductsEntry_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id])
);

