IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Categories] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Customers] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Address] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [Image] nvarchar(max) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Products] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Price] decimal(18,2) NOT NULL,
    [Image] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [CategoryId] int NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AccountUsers] (
    [Id] int NOT NULL IDENTITY,
    [Useraname] nvarchar(max) NULL,
    [Password] nvarchar(max) NULL,
    [CustomerId] int NOT NULL,
    CONSTRAINT [PK_AccountUsers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AccountUsers_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AddressCustomers] (
    [Id] int NOT NULL IDENTITY,
    [AddressName] nvarchar(max) NULL,
    [CustomerId] int NOT NULL,
    CONSTRAINT [PK_AddressCustomers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AddressCustomers_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Bills] (
    [Id] int NOT NULL IDENTITY,
    [TotalPrice] decimal(18,2) NOT NULL,
    [CustomerId] int NOT NULL,
    CONSTRAINT [PK_Bills] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Bills_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [BillDetails] (
    [Id] int NOT NULL IDENTITY,
    [Quantity] int NOT NULL,
    [IntoMoney] decimal(18,2) NOT NULL,
    [ProductId] int NOT NULL,
    [BillId] int NOT NULL,
    CONSTRAINT [PK_BillDetails] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BillDetails_Bills_BillId] FOREIGN KEY ([BillId]) REFERENCES [Bills] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_BillDetails_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_AccountUsers_CustomerId] ON [AccountUsers] ([CustomerId]);
GO

CREATE INDEX [IX_AddressCustomers_CustomerId] ON [AddressCustomers] ([CustomerId]);
GO

CREATE INDEX [IX_BillDetails_BillId] ON [BillDetails] ([BillId]);
GO

CREATE INDEX [IX_BillDetails_ProductId] ON [BillDetails] ([ProductId]);
GO

CREATE INDEX [IX_Bills_CustomerId] ON [Bills] ([CustomerId]);
GO

CREATE INDEX [IX_Products_CategoryId] ON [Products] ([CategoryId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210411135018_SneakerShopDb', N'5.0.5');
GO

COMMIT;
GO

