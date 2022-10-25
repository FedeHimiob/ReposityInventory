CREATE TABLE [dbo].[Sale] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [InVoice]       INT            NOT NULL,
    [Comment]       NVARCHAR (250) NULL,
    [SaleDate]      DATE           NOT NULL,
    [PuerchaseType] INT            NOT NULL,
    [PaymentStatus] INT            NOT NULL,
    CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED ([Id] ASC)
);

