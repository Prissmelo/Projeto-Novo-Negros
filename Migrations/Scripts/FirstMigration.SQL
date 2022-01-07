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

CREATE TABLE [Consumidores] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(40) NOT NULL,
    [CPF] char(11) NOT NULL,
    [Endereco] nvarchar(40) NOT NULL,
    [Complemento] nvarchar(40) NOT NULL,
    [Cidade] nvarchar(40) NOT NULL,
    [Estado] nvarchar(5) NOT NULL,
    [Telefone] int NOT NULL,
    [Nascimento] date NOT NULL,
    [Email] nvarchar(40) NOT NULL,
    [Sexo] nvarchar(11) NOT NULL,
    CONSTRAINT [PK_Consumidores] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220106225918_FirstMigration', N'5.0.13');
GO

COMMIT;
GO

