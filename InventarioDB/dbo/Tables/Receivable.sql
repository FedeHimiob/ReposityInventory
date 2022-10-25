CREATE TABLE [dbo].[Receivable] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [SaleId]      INT             NOT NULL,
    [TotalAmount] DECIMAL (18, 2) NOT NULL,
    [PaidAmount]  DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Receivable] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Receivable_Sale] FOREIGN KEY ([SaleId]) REFERENCES [dbo].[Sale] ([Id])
);

