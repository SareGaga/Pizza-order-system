CREATE TABLE [dbo].[Products] (
    [Id]   INT NOT NULL,
    [PizzaName] VARCHAR (20) NOT NULL,
    [Ingredients]       VARCHAR(20)          NOT NULL, 
    [Price] INT NOT NULL, 
    CONSTRAINT [PK_Products] PRIMARY KEY ([Id])
);

