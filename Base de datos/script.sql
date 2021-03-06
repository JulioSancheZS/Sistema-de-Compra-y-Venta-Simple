USE [master]
GO
/****** Object:  Database [SisVentaProg40]    Script Date: 20/08/2019 15:47:54 ******/
CREATE DATABASE [SisVentaProg40]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SisVentaProg40', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SisVentaProg40.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SisVentaProg40_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SisVentaProg40_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SisVentaProg40] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SisVentaProg40].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SisVentaProg40] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SisVentaProg40] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SisVentaProg40] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SisVentaProg40] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SisVentaProg40] SET ARITHABORT OFF 
GO
ALTER DATABASE [SisVentaProg40] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SisVentaProg40] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SisVentaProg40] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SisVentaProg40] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SisVentaProg40] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SisVentaProg40] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SisVentaProg40] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SisVentaProg40] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SisVentaProg40] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SisVentaProg40] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SisVentaProg40] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SisVentaProg40] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SisVentaProg40] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SisVentaProg40] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SisVentaProg40] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SisVentaProg40] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SisVentaProg40] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SisVentaProg40] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SisVentaProg40] SET  MULTI_USER 
GO
ALTER DATABASE [SisVentaProg40] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SisVentaProg40] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SisVentaProg40] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SisVentaProg40] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SisVentaProg40] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SisVentaProg40]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [char](3) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [char](3) NOT NULL,
	[DatosIdDatos] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compra](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [char](3) NOT NULL,
	[FechaCompra] [datetime] NOT NULL,
	[ProveedorIdProveedor] [int] NOT NULL,
	[EmpleadoIdEmpleado] [int] NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Datos]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Datos](
	[IdDatos] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Telefono] [varchar](30) NOT NULL,
	[Direccion] [nvarchar](200) NOT NULL,
	[Codigo] [char](3) NOT NULL,
 CONSTRAINT [PK_Datos] PRIMARY KEY CLUSTERED 
(
	[IdDatos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCompra](
	[IdDetalleCompra] [int] IDENTITY(1,1) NOT NULL,
	[Precio] [decimal](18, 0) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[CompraIdCompra] [int] NOT NULL,
	[ProductoIdProducto] [int] NOT NULL,
 CONSTRAINT [PK_DetalleCompra] PRIMARY KEY CLUSTERED 
(
	[IdDetalleCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[IdDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[Precio] [decimal](18, 0) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[ProductoIdProducto] [int] NOT NULL,
	[VentaIdVenta] [int] NOT NULL,
 CONSTRAINT [PK_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[IdDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [char](3) NOT NULL,
	[DatosIdDatos] [int] NOT NULL,
	[Identificacion] [varchar](200) NOT NULL,
	[Correo] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marca](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [char](3) NOT NULL,
	[Descripcion] [char](100) NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modelo](
	[IdModelo] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [char](3) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Modelo] PRIMARY KEY CLUSTERED 
(
	[IdModelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](300) NOT NULL,
	[PrecioVenta] [decimal](18, 0) NOT NULL,
	[PrecioCompra] [decimal](18, 0) NOT NULL,
	[Stock] [int] NOT NULL,
	[CategoriaIdCategoria] [int] NOT NULL,
	[MarcaIdMarca] [int] NOT NULL,
	[ModeloIdModelo] [int] NOT NULL,
	[Codigo] [char](3) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [char](3) NOT NULL,
	[DatosIdDatos] [int] NOT NULL,
	[RazonSocial] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venta](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [char](3) NOT NULL,
	[FechaVenta] [datetime] NOT NULL,
	[EmpleadoIdEmpleado] [int] NOT NULL,
	[ClienteIdCliente] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Index [IX_FK_DatosCliente]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_DatosCliente] ON [dbo].[Cliente]
(
	[DatosIdDatos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_EmpleadoCompra]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_EmpleadoCompra] ON [dbo].[Compra]
(
	[EmpleadoIdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ProveedorCompra]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ProveedorCompra] ON [dbo].[Compra]
(
	[ProveedorIdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CompraDetalleCompra]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_CompraDetalleCompra] ON [dbo].[DetalleCompra]
(
	[CompraIdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ProductoDetalleCompra]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ProductoDetalleCompra] ON [dbo].[DetalleCompra]
(
	[ProductoIdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_DetalleVenta]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_DetalleVenta] ON [dbo].[DetalleVenta]
(
	[VentaIdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ProductoDetalleVenta]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ProductoDetalleVenta] ON [dbo].[DetalleVenta]
(
	[ProductoIdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_DatosEmpleado]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_DatosEmpleado] ON [dbo].[Empleado]
(
	[DatosIdDatos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CategoriaProducto]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_CategoriaProducto] ON [dbo].[Producto]
(
	[CategoriaIdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_MarcaProducto]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_MarcaProducto] ON [dbo].[Producto]
(
	[MarcaIdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ModeloProducto]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ModeloProducto] ON [dbo].[Producto]
(
	[ModeloIdModelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_DatosProveedor]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_DatosProveedor] ON [dbo].[Proveedor]
(
	[DatosIdDatos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ClienteVenta]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ClienteVenta] ON [dbo].[Venta]
(
	[ClienteIdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_EmpleadoVenta]    Script Date: 20/08/2019 15:47:54 ******/
CREATE NONCLUSTERED INDEX [IX_FK_EmpleadoVenta] ON [dbo].[Venta]
(
	[EmpleadoIdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_DatosCliente] FOREIGN KEY([DatosIdDatos])
REFERENCES [dbo].[Datos] ([IdDatos])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_DatosCliente]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoCompra] FOREIGN KEY([EmpleadoIdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_EmpleadoCompra]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_ProveedorCompra] FOREIGN KEY([ProveedorIdProveedor])
REFERENCES [dbo].[Proveedor] ([IdProveedor])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_ProveedorCompra]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_CompraDetalleCompra] FOREIGN KEY([CompraIdCompra])
REFERENCES [dbo].[Compra] ([IdCompra])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [FK_CompraDetalleCompra]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_ProductoDetalleCompra] FOREIGN KEY([ProductoIdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [FK_ProductoDetalleCompra]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta] FOREIGN KEY([VentaIdVenta])
REFERENCES [dbo].[Venta] ([IdVenta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_ProductoDetalleVenta] FOREIGN KEY([ProductoIdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_ProductoDetalleVenta]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_DatosEmpleado] FOREIGN KEY([DatosIdDatos])
REFERENCES [dbo].[Datos] ([IdDatos])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_DatosEmpleado]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_CategoriaProducto] FOREIGN KEY([CategoriaIdCategoria])
REFERENCES [dbo].[Categoria] ([IdCategoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_CategoriaProducto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_MarcaProducto] FOREIGN KEY([MarcaIdMarca])
REFERENCES [dbo].[Marca] ([IdMarca])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_MarcaProducto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_ModeloProducto] FOREIGN KEY([ModeloIdModelo])
REFERENCES [dbo].[Modelo] ([IdModelo])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_ModeloProducto]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_DatosProveedor] FOREIGN KEY([DatosIdDatos])
REFERENCES [dbo].[Datos] ([IdDatos])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_DatosProveedor]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_ClienteVenta] FOREIGN KEY([ClienteIdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_ClienteVenta]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoVenta] FOREIGN KEY([EmpleadoIdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_EmpleadoVenta]
GO
/****** Object:  StoredProcedure [dbo].[BusquedaCategoria]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------Busqueda de Categoria--------------------------------------------
Create Proc [dbo].[BusquedaCategoria](@Descripcion varchar(100))
as
select c.Codigo, c.Descripcion from Categoria c
where c.Descripcion like '%' +@Descripcion + '%' 
GO
/****** Object:  StoredProcedure [dbo].[BusquedaCliente]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Busquedas Cliente--------------------------------------------
Create Proc [dbo].[BusquedaCliente](@Nombre varchar(100), @Apellido varchar(100))
as
select c.IdCliente, c.Codigo as Codigo, p.Nombre, p.Apellido, p.Direccion, p.Telefono 
from Datos p
inner join Cliente c on c.DatosIdDatos = p.IdDatos
where p.Nombre like '%' +@Nombre + '%' AND p.Apellido like '%' + @Apellido +'%'
GO
/****** Object:  StoredProcedure [dbo].[BusquedaEmpleado]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Busquedas Empleado--------------------------------------------
Create Proc [dbo].[BusquedaEmpleado](@Nombre varchar(100), @Apellido varchar(100))
as
select c.IdEmpleado, c.Codigo, c.Identificacion, d.Nombre, d.Apellido, d.Direccion, d.Telefono, c.Correo
from Datos d
inner join Empleado c on c.DatosIdDatos = d.IdDatos
where d.Nombre like '%' +@Nombre + '%' AND d.Apellido like '%' + @Apellido +'%'
GO
/****** Object:  StoredProcedure [dbo].[BusquedaMarca]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[BusquedaMarca](@Descripcion varchar(100))
as
select c.Codigo, c.Descripcion from Marca c
where c.Descripcion like '%' +@Descripcion + '%' 
GO
/****** Object:  StoredProcedure [dbo].[BusquedaModelo]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[BusquedaModelo](@Descripcion varchar(100))
as
select c.Codigo, c.Descripcion from Modelo c
where c.Descripcion like '%' +@Descripcion + '%' 
GO
/****** Object:  StoredProcedure [dbo].[BusquedaProducto]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----Busqueda de Productos-----------------------------
Create Proc [dbo].[BusquedaProducto](@Descripcion varchar(300))
as
select e.IdProducto, e.Codigo, e.Descripcion, e.PrecioCompra, e.PrecioVenta, e.Stock, p.Descripcion as Categoria, m.Descripcion as Marca, n.Descripcion as Modelo
from Producto e
inner join Categoria p on e.IdProducto = p.IdCategoria 
inner join  Marca m on e.MarcaIdMarca = m.IdMarca
inner join Modelo n on e.ModeloIdModelo = n.IdModelo
where e.Descripcion like '%' +@Descripcion + '%' 
GO
/****** Object:  StoredProcedure [dbo].[BusquedaProveedor]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Busquedas Proveedor--------------------------------------------
Create Proc [dbo].[BusquedaProveedor](@Nombre varchar(100), @Apellido varchar(100))
as
select c.IdProveedor, c.Codigo,c.RazonSocial, p.Nombre, p.Apellido, p.Direccion, p.Telefono
from Datos p
inner join Proveedor c on c.DatosIdDatos = p.IdDatos
where p.Nombre like '%' +@Nombre + '%' AND p.Apellido like '%' + @Apellido +'%'
GO
/****** Object:  StoredProcedure [dbo].[ListaCategoria]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ListaCategoria]
as
select c.IdCategoria, c.Codigo, c.Descripcion from Categoria c
GO
/****** Object:  StoredProcedure [dbo].[ListaClientes]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Listado de Cliente
Create Proc [dbo].[ListaClientes]
as
select c.IdCliente ,c.Codigo as Codigo, p.Nombre, p.Apellido, p.Direccion, p.Telefono from Datos p
inner join Cliente c on c.DatosIdDatos = p.IdDatos
GO
/****** Object:  StoredProcedure [dbo].[ListaCompra]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ListaCompra]
as
select e.IdDetalleCompra, m.IdCompra, e.Precio, e.Cantidad, m.FechaCompra, p.Descripcion
from DetalleCompra e
inner join Producto p on e.ProductoIdProducto = p.IdProducto 
inner join  Compra m on e.CompraIdCompra = m.IdCompra
GO
/****** Object:  StoredProcedure [dbo].[ListaEmpleados]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[ListaEmpleados]
as
select c.IdEmpleado, c.Codigo, c.Identificacion, d.Nombre, d.Apellido, d.Direccion, d.Telefono, c.Correo
from Datos d
inner join Empleado c on c.DatosIdDatos = d.IdDatos
GO
/****** Object:  StoredProcedure [dbo].[ListaMarca]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ListaMarca]
as
select c.IdMarca, c.Codigo, c.Descripcion from Marca c
GO
/****** Object:  StoredProcedure [dbo].[ListaModelo]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[ListaModelo]
as
select c.IdModelo, c.Codigo, c.Descripcion from Modelo c
GO
/****** Object:  StoredProcedure [dbo].[ListaProductos]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ListaProductos]
as
select e.IdProducto, e.Codigo, e.Descripcion, e.PrecioCompra, e.PrecioVenta, e.Stock, p.Descripcion as Categoria, m.Descripcion as Marca, n.Descripcion as Modelo
from Producto e
inner join Categoria p on e.CategoriaIdCategoria = p.IdCategoria 
inner join  Marca m on e.MarcaIdMarca = m.IdMarca
inner join Modelo n on e.ModeloIdModelo = n.IdModelo
GO
/****** Object:  StoredProcedure [dbo].[ListaProveedores]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ListaProveedores]
as
select c.IdProveedor, c.Codigo, c.RazonSocial, d.Nombre, d.Apellido, d.Direccion, d.Telefono
from Datos d
inner join Proveedor c on c.DatosIdDatos = d.IdDatos

GO
/****** Object:  StoredProcedure [dbo].[ListaVentas]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ListaVentas]
as
select e.IdDetalleVenta, m.IdVenta, e.Precio, e.Cantidad, m.FechaVenta, p.Descripcion
from DetalleVenta e
inner join Producto p on e.ProductoIdProducto = p.IdProducto 
inner join  Venta m on e.VentaIdVenta = m.IdVenta
GO
/****** Object:  StoredProcedure [dbo].[ObtenerCompraActualCliente]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[ObtenerCompraActualCliente]
     as
	 SELECT Empleado.IdEmpleado, Datos.Nombre, Producto.Descripcion, DetalleCompra.Precio, DetalleCompra.Cantidad, Compra.FechaCompra
     FROM     Compra INNER JOIN
                  DetalleCompra ON Compra.IdCompra = DetalleCompra.CompraIdCompra INNER JOIN
                  Producto ON DetalleCompra.ProductoIdProducto = Producto.IdProducto INNER JOIN
                  Empleado ON Compra.EmpleadoIdEmpleado = Empleado.IdEmpleado INNER JOIN
                  Datos ON Empleado.DatosIdDatos = Datos.IdDatos AND
				  Compra.IdCompra IN (SELECT MAX(Compra.IdCompra) as IdVenta from Compra)
GO
/****** Object:  StoredProcedure [dbo].[ObtenerCompraCliente]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ObtenerCompraCliente](@IdCliente int)
as 
select d.Nombre,d.Apellido,p.Descripcion,dt.Cantidad,dt.Precio,v.FechaVenta
from Datos d
inner join Cliente c on c.DatosIdDatos=d.IdDatos
inner join Venta v on v.ClienteIdCliente=c.IdCliente
inner join DetalleVenta dt on dt.VentaIdVenta=v.IdVenta 
inner join Producto p on dt.ProductoIdProducto=p.IdProducto
where @IdCliente = c.IdCliente
GO
/****** Object:  StoredProcedure [dbo].[ObterVentaEmpleado]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ObterVentaEmpleado](@IdEmpleado int)
as 
select e.Identificacion,da.Nombre,da.Apellido,v.Codigo,p.Descripcion,d.Cantidad,d.Precio,v.FechaVenta
 from Empleado e
 inner join Venta v on e.IdEmpleado= v.EmpleadoIdEmpleado
 inner join DetalleVenta d on d.VentaIdVenta= v.IdVenta
 inner join Producto p on d.ProductoIdProducto=p.IdProducto
 inner join Datos da on e.DatosIdDatos=da.IdDatos
 where e.IdEmpleado = @IdEmpleado
GO
/****** Object:  StoredProcedure [dbo].[VentaActual]    Script Date: 20/08/2019 15:47:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[VentaActual]
as 
SELECT Empleado.IdEmpleado, Datos.Nombre, Producto.Descripcion, DetalleVenta.Precio, DetalleVenta.Cantidad
FROM     Venta INNER JOIN
                  DetalleVenta ON Venta.IdVenta = DetalleVenta.VentaIdVenta INNER JOIN
                  Producto ON DetalleVenta.ProductoIdProducto = Producto.IdProducto INNER JOIN
                  Empleado ON Venta.EmpleadoIdEmpleado = Empleado.IdEmpleado INNER JOIN
                  Datos ON Empleado.DatosIdDatos = Datos.IdDatos AND
				  Venta.IdVenta IN (SELECT MAX(Venta.IdVenta) as IdVenta from Venta)
GO
USE [master]
GO
ALTER DATABASE [SisVentaProg40] SET  READ_WRITE 
GO
