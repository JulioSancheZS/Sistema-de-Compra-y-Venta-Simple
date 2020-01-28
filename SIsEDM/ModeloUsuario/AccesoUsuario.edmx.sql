
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/24/2020 10:50:13
-- Generated from EDMX file: E:\Proyectos\Proyectyo Prog40\PROYECTO\SisVentasPrg40\SIsEDM\ModeloUsuario\AccesoUsuario.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AccesoUsuario];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FuncionDeAccesoFuncionAsignada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionAsignadaSet] DROP CONSTRAINT [FK_FuncionDeAccesoFuncionAsignada];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioFuncionAsignada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FuncionAsignadaSet] DROP CONSTRAINT [FK_UsuarioFuncionAsignada];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FuncionDeAccesoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FuncionDeAccesoSet];
GO
IF OBJECT_ID(N'[dbo].[FuncionAsignadaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FuncionAsignadaSet];
GO
IF OBJECT_ID(N'[dbo].[UsuarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuarioSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FuncionDeAccesoSet'
CREATE TABLE [dbo].[FuncionDeAccesoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FuncionAsignadaSet'
CREATE TABLE [dbo].[FuncionAsignadaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaDeVencimiento] datetime  NOT NULL,
    [FuncionDeAccesoId] int  NOT NULL,
    [UsuarioId] int  NOT NULL
);
GO

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreDeUsuario] nvarchar(max)  NOT NULL,
    [ClaveDeUsuario] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'FuncionDeAccesoSet'
ALTER TABLE [dbo].[FuncionDeAccesoSet]
ADD CONSTRAINT [PK_FuncionDeAccesoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FuncionAsignadaSet'
ALTER TABLE [dbo].[FuncionAsignadaSet]
ADD CONSTRAINT [PK_FuncionAsignadaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FuncionDeAccesoId] in table 'FuncionAsignadaSet'
ALTER TABLE [dbo].[FuncionAsignadaSet]
ADD CONSTRAINT [FK_FuncionDeAccesoFuncionAsignada]
    FOREIGN KEY ([FuncionDeAccesoId])
    REFERENCES [dbo].[FuncionDeAccesoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionDeAccesoFuncionAsignada'
CREATE INDEX [IX_FK_FuncionDeAccesoFuncionAsignada]
ON [dbo].[FuncionAsignadaSet]
    ([FuncionDeAccesoId]);
GO

-- Creating foreign key on [UsuarioId] in table 'FuncionAsignadaSet'
ALTER TABLE [dbo].[FuncionAsignadaSet]
ADD CONSTRAINT [FK_UsuarioFuncionAsignada]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[UsuarioSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioFuncionAsignada'
CREATE INDEX [IX_FK_UsuarioFuncionAsignada]
ON [dbo].[FuncionAsignadaSet]
    ([UsuarioId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------