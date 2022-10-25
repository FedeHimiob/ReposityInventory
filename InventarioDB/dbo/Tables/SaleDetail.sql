CREATE TABLE [dbo].[SaleDetail] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [ProductId] INT NOT NULL,
    [Quantity]  INT NOT NULL,
    [SaleId]    INT NOT NULL,
    CONSTRAINT [PK_SaleDetail] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SaleDetail_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]),
    CONSTRAINT [FK_SaleDetail_Sale] FOREIGN KEY ([SaleId]) REFERENCES [dbo].[Sale] ([Id])
);

