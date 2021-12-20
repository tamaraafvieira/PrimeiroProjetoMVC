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

CREATE TABLE [Clientes] (
    [CodigoCliente] int NOT NULL IDENTITY,
    [Cpf] char(14) NOT NULL,
    [Nome] nvarchar(50) NOT NULL,
    [E_mail] nvarchar(50) NOT NULL,
    [Rua] nvarchar(40) NOT NULL,
    [Numero] int NOT NULL,
    [Complemento] nvarchar(20) NULL,
    [Cep] CHAR(9) NOT NULL,
    [Situacao] int NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([CodigoCliente])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211219233431_Migrations', N'5.0.13');
GO

COMMIT;
GO

