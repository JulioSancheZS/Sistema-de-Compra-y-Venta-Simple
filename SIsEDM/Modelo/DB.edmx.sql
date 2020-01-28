
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/04/2019 10:21:40
-- Generated from EDMX file: C:\Users\Kelvin\Desktop\Programacioen Base de Datos\SisVentasPrg40\SIsEDM\Modelo\DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SisVentaProg40];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CategoriaProducto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Producto] DROP CONSTRAINT [FK_CategoriaProducto];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteVenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venta] DROP CONSTRAINT [FK_ClienteVenta];
GO
IF OBJECT_ID(N'[dbo].[FK_CompraDetalleCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleCompra] DROP CONSTRAINT [FK_CompraDetalleCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_DatosCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cliente] DROP CONSTRAINT [FK_DatosCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_DatosEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleado] DROP CONSTRAINT [FK_DatosEmpleado];
GO
IF OBJECT_ID(N'[dbo].[FK_DatosProveedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proveedor] DROP CONSTRAINT [FK_DatosProveedor];
GO
IF OBJECT_ID(N'[dbo].[FK_DetalleVenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleVenta] DROP CONSTRAINT [FK_DetalleVenta];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpleadoCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Compra] DROP CONSTRAINT [FK_EmpleadoCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpleadoVenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venta] DROP CONSTRAINT [FK_EmpleadoVenta];
GO
IF OBJECT_ID(N'[dbo].[FK_MarcaProducto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Producto] DROP CONSTRAINT [FK_MarcaProducto];
GO
IF OBJECT_ID(N'[dbo].[FK_ModeloProducto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Producto] DROP CONSTRAINT [FK_ModeloProducto];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductoDetalleCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleCompra] DROP CONSTRAINT [FK_ProductoDetalleCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductoDetalleVenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleVenta] DROP CONSTRAINT [FK_ProductoDetalleVenta];
GO
IF OBJECT_ID(N'[dbo].[FK_ProveedorCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Compra] DROP CONSTRAINT [FK_ProveedorCompra];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Categoria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categoria];
GO
IF OBJECT_ID(N'[dbo].[Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cliente];
GO
IF OBJECT_ID(N'[dbo].[Compra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Compra];
GO
IF OBJECT_ID(N'[dbo].[Datos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Datos];
GO
IF OBJECT_ID(N'[dbo].[DetalleCompra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleCompra];
GO
IF OBJECT_ID(N'[dbo].[DetalleVenta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleVenta];
GO
IF OBJECT_ID(N'[dbo].[Empleado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleado];
GO
IF OBJECT_ID(N'[dbo].[Marca]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Marca];
GO
IF OBJECT_ID(N'[dbo].[Modelo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Modelo];
GO
IF OBJECT_ID(N'[dbo].[Producto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Producto];
GO
IF OBJECT_ID(N'[dbo].[Proveedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proveedor];
GO
IF OBJECT_ID(N'[dbo].[Venta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Venta];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Venta'
CREATE TABLE [dbo].[Venta] (
    [IdVenta] int IDENTITY(1,1) NOT NULL,
    [Codigo] char(3)  NOT NULL,
    [FechaVenta] datetime  NOT NULL,
    [EmpleadoIdEmpleado] int  NOT NULL,
    [ClienteIdCliente] int  NOT NULL
);
GO

-- Creating table 'Datos'
CREATE TABLE [dbo].[Datos] (
    [IdDatos] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(100)  NOT NULL,
    [Apellido] varchar(100)  NOT NULL,
    [Telefono] varchar(30)  NOT NULL,
    [Direccion] nvarchar(200)  NOT NULL,
    [Codigo] char(3)  NOT NULL
);
GO

-- Creating table 'DetalleCompra'
CREATE TABLE [dbo].[DetalleCompra] (
    [IdDetalleCompra] int IDENTITY(1,1) NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [Cantidad] int  NOT NULL,
    [CompraIdCompra] int  NOT NULL,
    [ProductoIdProducto] int  NOT NULL
);
GO

-- Creating table 'Compra'
CREATE TABLE [dbo].[Compra] (
    [IdCompra] int IDENTITY(1,1) NOT NULL,
    [Codigo] char(3)  NOT NULL,
    [FechaCompra] datetime  NOT NULL,
    [ProveedorIdProveedor] int  NOT NULL,
    [EmpleadoIdEmpleado] int  NOT NULL
);
GO

-- Creating table 'DetalleVenta'
CREATE TABLE [dbo].[DetalleVenta] (
    [IdDetalleVenta] int IDENTITY(1,1) NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [Cantidad] int  NOT NULL,
    [ProductoIdProducto] int  NOT NULL,
    [VentaIdVenta] int  NOT NULL
);
GO

-- Creating table 'Producto'
CREATE TABLE [dbo].[Producto] (
    [IdProducto] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(300)  NOT NULL,
    [PrecioVenta] decimal(18,0)  NOT NULL,
    [PrecioCompra] decimal(18,0)  NOT NULL,
    [Stock] int  NOT NULL,
    [CategoriaIdCategoria] int  NOT NULL,
    [MarcaIdMarca] int  NOT NULL,
    [ModeloIdModelo] int  NOT NULL,
    [Codigo] char(3)  NOT NULL
);
GO

-- Creating table 'Categoria'
CREATE TABLE [dbo].[Categoria] (
    [IdCategoria] int IDENTITY(1,1) NOT NULL,
    [Codigo] char(3)  NOT NULL,
    [Descripcion] varchar(50)  NOT NULL
);
GO

-- Creating table 'Marca'
CREATE TABLE [dbo].[Marca] (
    [IdMarca] int IDENTITY(1,1) NOT NULL,
    [Codigo] char(3)  NOT NULL,
    [Descripcion] char(100)  NOT NULL
);
GO

-- Creating table 'Modelo'
CREATE TABLE [dbo].[Modelo] (
    [IdModelo] int IDENTITY(1,1) NOT NULL,
    [Codigo] char(3)  NOT NULL,
    [Descripcion] varchar(100)  NOT NULL
);
GO

-- Creating table 'Proveedor'
CREATE TABLE [dbo].[Proveedor] (
    [IdProveedor] int IDENTITY(1,1) NOT NULL,
    [Codigo] char(3)  NOT NULL,
    [DatosIdDatos] int  NOT NULL,
    [RazonSocial] varchar(100)  NOT NULL
);
GO

-- Creating table 'Empleado'
CREATE TABLE [dbo].[Empleado] (
    [IdEmpleado] int IDENTITY(1,1) NOT NULL,
    [Codigo] char(3)  NOT NULL,
    [DatosIdDatos] int  NOT NULL,
    [Identificacion] varchar(200)  NOT NULL,
    [Correo] varchar(200)  NOT NULL
);
GO

-- Creating table 'Cliente'
CREATE TABLE [dbo].[Cliente] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Codigo] char(3)  NOT NULL,
    [DatosIdDatos] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdVenta] in table 'Venta'
ALTER TABLE [dbo].[Venta]
ADD CONSTRAINT [PK_Venta]
    PRIMARY KEY CLUSTERED ([IdVenta] ASC);
GO

-- Creating primary key on [IdDatos] in table 'Datos'
ALTER TABLE [dbo].[Datos]
ADD CONSTRAINT [PK_Datos]
    PRIMARY KEY CLUSTERED ([IdDatos] ASC);
GO

-- Creating primary key on [IdDetalleCompra] in table 'DetalleCompra'
ALTER TABLE [dbo].[DetalleCompra]
ADD CONSTRAINT [PK_DetalleCompra]
    PRIMARY KEY CLUSTERED ([IdDetalleCompra] ASC);
GO

-- Creating primary key on [IdCompra] in table 'Compra'
ALTER TABLE [dbo].[Compra]
ADD CONSTRAINT [PK_Compra]
    PRIMARY KEY CLUSTERED ([IdCompra] ASC);
GO

-- Creating primary key on [IdDetalleVenta] in table 'DetalleVenta'
ALTER TABLE [dbo].[DetalleVenta]
ADD CONSTRAINT [PK_DetalleVenta]
    PRIMARY KEY CLUSTERED ([IdDetalleVenta] ASC);
GO

-- Creating primary key on [IdProducto] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [PK_Producto]
    PRIMARY KEY CLUSTERED ([IdProducto] ASC);
GO

-- Creating primary key on [IdCategoria] in table 'Categoria'
ALTER TABLE [dbo].[Categoria]
ADD CONSTRAINT [PK_Categoria]
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC);
GO

-- Creating primary key on [IdMarca] in table 'Marca'
ALTER TABLE [dbo].[Marca]
ADD CONSTRAINT [PK_Marca]
    PRIMARY KEY CLUSTERED ([IdMarca] ASC);
GO

-- Creating primary key on [IdModelo] in table 'Modelo'
ALTER TABLE [dbo].[Modelo]
ADD CONSTRAINT [PK_Modelo]
    PRIMARY KEY CLUSTERED ([IdModelo] ASC);
GO

-- Creating primary key on [IdProveedor] in table 'Proveedor'
ALTER TABLE [dbo].[Proveedor]
ADD CONSTRAINT [PK_Proveedor]
    PRIMARY KEY CLUSTERED ([IdProveedor] ASC);
GO

-- Creating primary key on [IdEmpleado] in table 'Empleado'
ALTER TABLE [dbo].[Empleado]
ADD CONSTRAINT [PK_Empleado]
    PRIMARY KEY CLUSTERED ([IdEmpleado] ASC);
GO

-- Creating primary key on [IdCliente] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [PK_Cliente]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DatosIdDatos] in table 'Proveedor'
ALTER TABLE [dbo].[Proveedor]
ADD CONSTRAINT [FK_DatosProveedor]
    FOREIGN KEY ([DatosIdDatos])
    REFERENCES [dbo].[Datos]
        ([IdDatos])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DatosProveedor'
CREATE INDEX [IX_FK_DatosProveedor]
ON [dbo].[Proveedor]
    ([DatosIdDatos]);
GO

-- Creating foreign key on [DatosIdDatos] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [FK_DatosCliente]
    FOREIGN KEY ([DatosIdDatos])
    REFERENCES [dbo].[Datos]
        ([IdDatos])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DatosCliente'
CREATE INDEX [IX_FK_DatosCliente]
ON [dbo].[Cliente]
    ([DatosIdDatos]);
GO

-- Creating foreign key on [DatosIdDatos] in table 'Empleado'
ALTER TABLE [dbo].[Empleado]
ADD CONSTRAINT [FK_DatosEmpleado]
    FOREIGN KEY ([DatosIdDatos])
    REFERENCES [dbo].[Datos]
        ([IdDatos])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DatosEmpleado'
CREATE INDEX [IX_FK_DatosEmpleado]
ON [dbo].[Empleado]
    ([DatosIdDatos]);
GO

-- Creating foreign key on [ProveedorIdProveedor] in table 'Compra'
ALTER TABLE [dbo].[Compra]
ADD CONSTRAINT [FK_ProveedorCompra]
    FOREIGN KEY ([ProveedorIdProveedor])
    REFERENCES [dbo].[Proveedor]
        ([IdProveedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProveedorCompra'
CREATE INDEX [IX_FK_ProveedorCompra]
ON [dbo].[Compra]
    ([ProveedorIdProveedor]);
GO

-- Creating foreign key on [EmpleadoIdEmpleado] in table 'Compra'
ALTER TABLE [dbo].[Compra]
ADD CONSTRAINT [FK_EmpleadoCompra]
    FOREIGN KEY ([EmpleadoIdEmpleado])
    REFERENCES [dbo].[Empleado]
        ([IdEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoCompra'
CREATE INDEX [IX_FK_EmpleadoCompra]
ON [dbo].[Compra]
    ([EmpleadoIdEmpleado]);
GO

-- Creating foreign key on [CompraIdCompra] in table 'DetalleCompra'
ALTER TABLE [dbo].[DetalleCompra]
ADD CONSTRAINT [FK_CompraDetalleCompra]
    FOREIGN KEY ([CompraIdCompra])
    REFERENCES [dbo].[Compra]
        ([IdCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompraDetalleCompra'
CREATE INDEX [IX_FK_CompraDetalleCompra]
ON [dbo].[DetalleCompra]
    ([CompraIdCompra]);
GO

-- Creating foreign key on [EmpleadoIdEmpleado] in table 'Venta'
ALTER TABLE [dbo].[Venta]
ADD CONSTRAINT [FK_EmpleadoVenta]
    FOREIGN KEY ([EmpleadoIdEmpleado])
    REFERENCES [dbo].[Empleado]
        ([IdEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpleadoVenta'
CREATE INDEX [IX_FK_EmpleadoVenta]
ON [dbo].[Venta]
    ([EmpleadoIdEmpleado]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'Venta'
ALTER TABLE [dbo].[Venta]
ADD CONSTRAINT [FK_ClienteVenta]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Cliente]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenta'
CREATE INDEX [IX_FK_ClienteVenta]
ON [dbo].[Venta]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [ProductoIdProducto] in table 'DetalleCompra'
ALTER TABLE [dbo].[DetalleCompra]
ADD CONSTRAINT [FK_ProductoDetalleCompra]
    FOREIGN KEY ([ProductoIdProducto])
    REFERENCES [dbo].[Producto]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoDetalleCompra'
CREATE INDEX [IX_FK_ProductoDetalleCompra]
ON [dbo].[DetalleCompra]
    ([ProductoIdProducto]);
GO

-- Creating foreign key on [ProductoIdProducto] in table 'DetalleVenta'
ALTER TABLE [dbo].[DetalleVenta]
ADD CONSTRAINT [FK_ProductoDetalleVenta]
    FOREIGN KEY ([ProductoIdProducto])
    REFERENCES [dbo].[Producto]
        ([IdProducto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoDetalleVenta'
CREATE INDEX [IX_FK_ProductoDetalleVenta]
ON [dbo].[DetalleVenta]
    ([ProductoIdProducto]);
GO

-- Creating foreign key on [CategoriaIdCategoria] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [FK_CategoriaProducto]
    FOREIGN KEY ([CategoriaIdCategoria])
    REFERENCES [dbo].[Categoria]
        ([IdCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaProducto'
CREATE INDEX [IX_FK_CategoriaProducto]
ON [dbo].[Producto]
    ([CategoriaIdCategoria]);
GO

-- Creating foreign key on [MarcaIdMarca] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [FK_MarcaProducto]
    FOREIGN KEY ([MarcaIdMarca])
    REFERENCES [dbo].[Marca]
        ([IdMarca])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MarcaProducto'
CREATE INDEX [IX_FK_MarcaProducto]
ON [dbo].[Producto]
    ([MarcaIdMarca]);
GO

-- Creating foreign key on [ModeloIdModelo] in table 'Producto'
ALTER TABLE [dbo].[Producto]
ADD CONSTRAINT [FK_ModeloProducto]
    FOREIGN KEY ([ModeloIdModelo])
    REFERENCES [dbo].[Modelo]
        ([IdModelo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModeloProducto'
CREATE INDEX [IX_FK_ModeloProducto]
ON [dbo].[Producto]
    ([ModeloIdModelo]);
GO

-- Creating foreign key on [VentaIdVenta] in table 'DetalleVenta'
ALTER TABLE [dbo].[DetalleVenta]
ADD CONSTRAINT [FK_DetalleVenta]
    FOREIGN KEY ([VentaIdVenta])
    REFERENCES [dbo].[Venta]
        ([IdVenta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleVenta'
CREATE INDEX [IX_FK_DetalleVenta]
ON [dbo].[DetalleVenta]
    ([VentaIdVenta]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------