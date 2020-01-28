use SisVentasPRG40

select * from Categoria
select * from Modelo
select * from Marca
select * from Producto
select * from Proveedor
select * from Datos
select * from Cliente
select * from DetalleVenta

--Procedimiento almacenado de Listados
Create Proc ListaCategoria
as
select c.IdCategoria, c.Codigo, c.Descripcion from Categoria c

Create Proc ListaMarca
as
select c.IdMarca, c.Codigo, c.Descripcion from Marca c

Create Proc ListaModelo
as
select c.IdModelo, c.Codigo, c.Descripcion from Modelo c

exec ListaModelo

----------------------------------------------
----------------------------------------------
---------------------------------------------


--Listado de Cliente
Create Proc ListaClientes
as
select c.IdCliente ,c.Codigo as Codigo, p.Nombre, p.Apellido, p.Direccion, p.Telefono from Datos p
inner join Cliente c on c.DatosIdDatos = p.IdDatos

exec ListaClientes

--Listado de proveedores
Create Proc ListaProveedores
as
select c.IdProveedor, c.Codigo, c.RazonSocial, d.Nombre, d.Apellido, d.Direccion, d.Telefono
from Datos d
inner join Proveedor c on c.DatosIdDatos = d.IdDatos

--Listado de Empledos
Create Proc ListaEmpledos
as
select c.Codigo, c.Identificacion, d.Nombre, d.Apellido, d.Direccion, d.Telefono, c.Correo
from Datos d
inner join Empleado c on c.DatosIdDatos = d.IdDatos

--Listado de productos
Create Proc ListaProductos
as
select e.IdProducto, e.Codigo, e.Descripcion, e.PrecioCompra, e.PrecioVenta, e.Stock, p.Descripcion as Categoria, m.Descripcion as Marca, n.Descripcion as Modelo
from Producto e
inner join Categoria p on e.CategoriaIdCategoria = p.IdCategoria 
inner join  Marca m on e.MarcaIdMarca = m.IdMarca
inner join Modelo n on e.ModeloIdModelo = n.IdModelo

exec ListaProductos

--Listado de producto por Marca
select e.IdProducto as Id, e.Descripcion as Producto, m.Descripcion AS Marca
from Producto e
inner join Marca m on e.IdProducto = m.IdMarca
------------------------------------------------------
------------------------------------------------------------------------
------------------------------------------------------------------------------
--Busquedas Proveedor--------------------------------------------
Create Proc BusquedaProveedor(@Nombre varchar(100), @Apellido varchar(100))
as
select c.IdProveedor, c.Codigo,c.RazonSocial, p.Nombre, p.Apellido, p.Direccion, p.Telefono
from Datos p
inner join Proveedor c on c.DatosIdDatos = p.IdDatos
where p.Nombre like '%' +@Nombre + '%' AND p.Apellido like '%' + @Apellido +'%'

exec BusquedaProveedor '',''

--Busquedas Empleado--------------------------------------------
Create Proc BusquedaEmpleado(@Nombre varchar(100), @Apellido varchar(100))
as
select c.IdEmpleado, c.Codigo, c.Identificacion, d.Nombre, d.Apellido, d.Direccion, d.Telefono, c.Correo
from Datos d
inner join Empleado c on c.DatosIdDatos = d.IdDatos
where d.Nombre like '%' +@Nombre + '%' AND d.Apellido like '%' + @Apellido +'%'

exec BusquedaEmpleado '',''

--Busquedas Cliente--------------------------------------------
Create Proc BusquedaCliente(@Nombre varchar(100), @Apellido varchar(100))
as
select c.IdCliente, c.Codigo as Codigo, p.Nombre, p.Apellido, p.Direccion, p.Telefono 
from Datos p
inner join Cliente c on c.DatosIdDatos = p.IdDatos
where p.Nombre like '%' +@Nombre + '%' AND p.Apellido like '%' + @Apellido +'%'

exec BusquedaCliente '',''

----Busqueda de Productos-----------------------------
Create Proc BusquedaProducto(@Descripcion varchar(300))
as
select e.IdProducto, e.Codigo, e.Descripcion, e.PrecioCompra, e.PrecioVenta, e.Stock, p.Descripcion as Categoria, m.Descripcion as Marca, n.Descripcion as Modelo
from Producto e
inner join Categoria p on e.IdProducto = p.IdCategoria 
inner join  Marca m on e.MarcaIdMarca = m.IdMarca
inner join Modelo n on e.ModeloIdModelo = n.IdModelo
where e.Descripcion like '%' +@Descripcion + '%' 

exec BusquedaProducto ''

------Busqueda de Categoria--------------------------------------------
Create Proc BusquedaCategoria(@Descripcion varchar(100))
as
select c.Codigo, c.Descripcion from Categoria c
where c.Descripcion like '%' +@Descripcion + '%' 

exec BusquedaCategoria 't'

------Busqueda de Marca--------------------------------------------

Create Proc BusquedaMarca(@Descripcion varchar(100))
as
select c.Codigo, c.Descripcion from Marca c
where c.Descripcion like '%' +@Descripcion + '%' 

exec BusquedaMarca 'a'

------Busqueda de Modelo--------------------------------------------

Create Proc BusquedaModelo(@Descripcion varchar(100))
as
select c.Codigo, c.Descripcion from Modelo c
where c.Descripcion like '%' +@Descripcion + '%' 

exec BusquedaModelo ''

---------------------------------------------------------
--Registros Datos-CLIENTES-------------------------------------------
insert into Datos values('Abel Antonio','Abad Urcuy','7722334','Alameda Empentejs somriurien','001')
insert into Datos values('Alba Iris','Abalos Borg','76879847','Camino Objurguin, 213B 8E','002')
insert into Datos values('Alba Maria','Abarca Albarado','97497327','Alameda Empentejs somriurien, 243B 2E','003')
insert into Datos values('Eliezer David','Abad Molina','89621333','IGNACIO ALLENDE NO.20','004')
insert into Datos values('Erick Antonio','Abarca Abarca','87457327','De Bello Horizonte 2 al sur','005')
insert into Datos values('Flor De Maria','Abad Urroz','89455323','Del Auto lote El Chele 3 cuadras al norte','006')
insert into Datos values('Danfer Jose','Abad Martinez','97497327','Del Parque Luis Alfonso 2 cuadras al lago','007')
insert into Datos values('Cesar Augusto','Abarca Aguilar','89621363','Ministerio','008')
insert into Datos values('Carlos Alberto','Abad Palacios','87457327','CARRETERA MEXICO-LAREDO KM.125','009')
insert into Datos values('Cecilia Maria','Urroz Aguila','89455323','Carretera sur 8 cuadras al lago','010')
insert into Datos values('Abel Antonio','Abad Urcuy','7722334','Alameda Empentejs somriurien','011')
insert into Datos values('Alba Iris','Abalos Borg','76879847','Camino Objurguin, 213B 8E','012')
insert into Datos values('Alba Maria','Abarca Albarado','97497327','Alameda Empentejs somriurien, 243B 2E','013')
insert into Datos values('Eliezer David','Abad Molina','89621333','IGNACIO ALLENDE NO.20','014')
insert into Datos values('Erick Antonio','Abarca Abarca','87457327','De Bello Horizonte 2 al sur','015')
insert into Datos values('Flor De Maria','Abad Urroz','89455323','Del Auto lote El Chele 3 cuadras al norte','016')
insert into Datos values('Danfer Jose','Abad Martinez','97497327','Del Parque Luis Alfonso 2 cuadras al lago','017')
insert into Datos values('Cesar Augusto','Abarca Aguilar','89621363','Ministerio','018')
insert into Datos values('Carlos Alberto','Abad Palacios','87457327','CARRETERA MEXICO-LAREDO KM.125','019')
insert into Datos values('Cecilia Maria','Urroz Aguila','89455323','Carretera sur 8 cuadras al lago','020')
insert into Datos values('Abel Antonio','Abad Urcuy','7722334','Alameda Empentejs somriurien','021')
insert into Datos values('Alba Iris','Abalos Borg','76879847','Camino Objurguin, 213B 8E','022')
insert into Datos values('Alba Maria','Abarca Albarado','97497327','Alameda Empentejs somriurien, 243B 2E','023')
insert into Datos values('Eliezer David','Abad Molina','89621333','IGNACIO ALLENDE NO.20','024')
insert into Datos values('Erick Antonio','Abarca Abarca','87457327','De Bello Horizonte 2 al sur','025')
insert into Datos values('Flor De Maria','Abad Urroz','89455323','Del Auto lote El Chele 3 cuadras al norte','026')
insert into Datos values('Danfer Jose','Abad Martinez','97497327','Del Parque Luis Alfonso 2 cuadras al lago','027')
insert into Datos values('Cesar Augusto','Abarca Aguilar','89621363','Ministerio','028')
insert into Datos values('Carlos Alberto','Abad Palacios','87457327','CARRETERA MEXICO-LAREDO KM.125','029')
insert into Datos values('Cecilia Maria','Urroz Aguila','89455323','Carretera sur 8 cuadras al lago','030')

--Registros Datos-Empleado-------------------------------------------

insert into Datos values('Abel Antonio','Abad Urcuy','7722334','Alameda Empentej�s somriurien','031')
insert into Datos values('Alba Iris','Abalos Borg','76879847','Camino Objurguin, 213B 8�E','032')
insert into Datos values('Alba Maria','Abarca Albarado','97497327','Alameda Empentej�s somriurien, 243B 2�E','033')
insert into Datos values('Eliezer David','Abad Molina','89621333','IGNACIO ALLENDE NO.20','034')
insert into Datos values('Erick Antonio','Abarca Abarca','87457327','De Bello Horizonte 2 al sur','035')
insert into Datos values('Flor De Maria','Abad Urroz','89455323','Del Auto lote El Chele 3 cuadras al norte','036')
insert into Datos values('Danfer Jose','Abad Martinez','97497327','Del Parque Luis Alfonso 2 cuadras al lago','037')
insert into Datos values('Cesar Augusto','Abarca Aguilar','89621363','Ministerio','038')
insert into Datos values('Carlos Alberto','Abad Palacios','87457327','CARRETERA MEXICO-LAREDO KM.125','039')
insert into Datos values('Cecilia Maria','Urroz Aguila','89455323','Carretera sur 8 cuadras al lago','040')
insert into Datos values('Abel Antonio','Abad Urcuy','7722334','Alameda Empentej�s somriurien','041')
insert into Datos values('Alba Iris','Abalos Borg','76879847','Camino Objurguin, 213B 8�E','042')
insert into Datos values('Alba Maria','Abarca Albarado','97497327','Alameda Empentej�s somriurien, 243B 2�E','043')
insert into Datos values('Eliezer David','Abad Molina','89621333','IGNACIO ALLENDE NO.20','044')
insert into Datos values('Erick Antonio','Abarca Abarca','87457327','De Bello Horizonte 2 al sur','045')
insert into Datos values('Flor De Maria','Abad Urroz','89455323','Del Auto lote El Chele 3 cuadras al norte','046')
insert into Datos values('Danfer Jose','Abad Martinez','97497327','Del Parque Luis Alfonso 2 cuadras al lago','047')
insert into Datos values('Cesar Augusto','Abarca Aguilar','89621363','Ministerio','048')
insert into Datos values('Carlos Alberto','Abad Palacios','87457327','CARRETERA MEXICO-LAREDO KM.125','049')
insert into Datos values('Cecilia Maria','Urroz Aguila','89455323','Carretera sur 8 cuadras al lago','050')
insert into Datos values('Abel Antonio','Abad Urcuy','7722334','Alameda Empentej�s somriurien','051')
insert into Datos values('Alba Iris','Abalos Borg','76879847','Camino Objurguin, 213B 8�E','052')
insert into Datos values('Alba Maria','Abarca Albarado','97497327','Alameda Empentej�s somriurien, 243B 2�E','053')
insert into Datos values('Eliezer David','Abad Molina','89621333','IGNACIO ALLENDE NO.20','054')
insert into Datos values('Erick Antonio','Abarca Abarca','87457327','De Bello Horizonte 2 al sur','055')
insert into Datos values('Flor De Maria','Abad Urroz','89455323','Del Auto lote El Chele 3 cuadras al norte','056')
insert into Datos values('Danfer Jose','Abad Martinez','97497327','Del Parque Luis Alfonso 2 cuadras al lago','057')
insert into Datos values('Cesar Augusto','Abarca Aguilar','89621363','Ministerio','058')
insert into Datos values('Carlos Alberto','Abad Palacios','87457327','CARRETERA MEXICO-LAREDO KM.125','059')
insert into Datos values('Cecilia Maria','Urroz Aguila','89455323','Carretera sur 8 cuadras al lago','060')
--Registros Datos-Proveedor-------------------------------------------

insert into Datos values('Abel Antonio','Abad Urcuy','7722334','Alameda Empentej�s somriurien','061')
insert into Datos values('Alba Iris','Abalos Borg','76879847','Camino Objurguin, 213B 8�E','062')
insert into Datos values('Alba Maria','Abarca Albarado','97497327','Alameda Empentej�s somriurien, 243B 2�E','063')
insert into Datos values('Eliezer David','Abad Molina','89621333','IGNACIO ALLENDE NO.20','064')
insert into Datos values('Erick Antonio','Abarca Abarca','87457327','De Bello Horizonte 2 al sur','065')
insert into Datos values('Flor De Maria','Abad Urroz','89455323','Del Auto lote El Chele 3 cuadras al norte','066')
insert into Datos values('Danfer Jose','Abad Martinez','97497327','Del Parque Luis Alfonso 2 cuadras al lago','067')
insert into Datos values('Cesar Augusto','Abarca Aguilar','89621363','Ministerio','068')
insert into Datos values('Carlos Alberto','Abad Palacios','87457327','CARRETERA MEXICO-LAREDO KM.125','069')
insert into Datos values('Cecilia Maria','Urroz Aguila','89455323','Carretera sur 8 cuadras al lago','070')
insert into Datos values('Abel Antonio','Abad Urcuy','7722334','Alameda Empentej�s somriurien','071')
insert into Datos values('Alba Iris','Abalos Borg','76879847','Camino Objurguin, 213B 8�E','072')
insert into Datos values('Alba Maria','Abarca Albarado','97497327','Alameda Empentej�s somriurien, 243B 2�E','073')
insert into Datos values('Eliezer David','Abad Molina','89621333','IGNACIO ALLENDE NO.20','074')
insert into Datos values('Erick Antonio','Abarca Abarca','87457327','De Bello Horizonte 2 al sur','075')
insert into Datos values('Flor De Maria','Abad Urroz','89455323','Del Auto lote El Chele 3 cuadras al norte','076')
insert into Datos values('Danfer Jose','Abad Martinez','97497327','Del Parque Luis Alfonso 2 cuadras al lago','077')
insert into Datos values('Cesar Augusto','Abarca Aguilar','89621363','Ministerio','078')
insert into Datos values('Carlos Alberto','Abad Palacios','87457327','CARRETERA MEXICO-LAREDO KM.125','079')
insert into Datos values('Cecilia Maria','Urroz Aguila','89455323','Carretera sur 8 cuadras al lago','080')
insert into Datos values('Abel Antonio','Abad Urcuy','7722334','Alameda Empentej�s somriurien','081')
insert into Datos values('Alba Iris','Abalos Borg','76879847','Camino Objurguin, 213B 8�E','082')
insert into Datos values('Alba Maria','Abarca Albarado','97497327','Alameda Empentej�s somriurien, 243B 2�E','083')
insert into Datos values('Eliezer David','Abad Molina','89621333','IGNACIO ALLENDE NO.20','084')
insert into Datos values('Erick Antonio','Abarca Abarca','87457327','De Bello Horizonte 2 al sur','085')
insert into Datos values('Flor De Maria','Abad Urroz','89455323','Del Auto lote El Chele 3 cuadras al norte','086')
insert into Datos values('Danfer Jose','Abad Martinez','97497327','Del Parque Luis Alfonso 2 cuadras al lago','087')
insert into Datos values('Cesar Augusto','Abarca Aguilar','89621363','Ministerio','088')
insert into Datos values('Carlos Alberto','Abad Palacios','87457327','CARRETERA MEXICO-LAREDO KM.125','089')
insert into Datos values('Cecilia Maria','Urroz Aguila','89455323','Carretera sur 8 cuadras al lago','090')

-------------------------------------------------------
---Registros Clientes
---------------------------------------------------------
insert into Cliente values ('001',1)
insert into Cliente values ('002',2)
insert into Cliente values ('003',3)
insert into Cliente values ('004',4)
insert into Cliente values ('005',5)
insert into Cliente values ('006',6)
insert into Cliente values ('007',7)
insert into Cliente values ('008',8)
insert into Cliente values ('009',9)
insert into Cliente values ('010',10)
insert into Cliente values ('021',11)
insert into Cliente values ('022',22)
insert into Cliente values ('023',23)
insert into Cliente values ('024',24)
insert into Cliente values ('025',25)
insert into Cliente values ('026',26)
insert into Cliente values ('027',27)
insert into Cliente values ('028',28)
insert into Cliente values ('029',29)
insert into Cliente values ('030',30)

-------------------------------------------------------
---Registros Empleado
---------------------------------------------------------
insert into Empleado values ('001',31,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('002',32,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('003',33,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('004',34,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('005',35,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('006',36,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('007',37,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('008',38,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('009',39,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('010',40,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('011',41,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('012',32,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('013',43,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('014',44,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('015',45,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('016',46,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('017',47,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('018',48,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('019',49,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('020',50,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('021',51,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('022',52,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('023',53,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('024',54,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('025',55,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('026',56,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('027',57,'001-162333-1132K','Antonio@gmail.com')
insert into Empleado values ('028',58,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('029',59,'184436-2342G','Maria@gmail.com')
insert into Empleado values ('030',60,'184436-2342G','Maria@gmail.com')
------------------------------------------------------
---Registros Proveedor
---------------------------------------------------------
insert into Proveedor values ('001',61,'Sevasa')
insert into Proveedor values ('001',62,'Comtech')
insert into Proveedor values ('001',63,'PcCom')
insert into Proveedor values ('001',64,'PCExpress')
insert into Proveedor values ('001',65,'CompuTotal')
insert into Proveedor values ('001',66,'Amazon')
insert into Proveedor values ('001',67,'AliExpress')
insert into Proveedor values ('001',68,'CECA Electronica')
insert into Proveedor values ('001',69,'Sicsa')
insert into Proveedor values ('001',70,'SmartPhone House')
-------------------------------------------------------
---Registros MARCA	
---------------------------------------------------------
insert into Marca values ('001','Toshiba')
insert into Marca values ('002','HP')
insert into Marca values ('003','Accer')
insert into Marca values ('004','Samsung')
insert into Marca values ('005','Apple')
insert into Marca values ('006','Samsung')
insert into Marca values ('007','Lenovo')
insert into Marca values ('008','G.Skill')
insert into Marca values ('009','Sony')
insert into Marca values ('010','Asus')
insert into Marca values ('011','AMD')
insert into Marca values ('012','Kingston')
insert into Marca values ('013','Logitech') 
insert into Marca values ('014','Intel') 
-------------------------------------------------------
---Registros CATEGORIA	
---------------------------------------------------------
insert into Categoria values ('001','Smartphones')
insert into Categoria values ('002','Tarjetas gr�ficas')
insert into Categoria values ('003','Parlantes')
insert into Categoria values ('004','Port�tiles')
insert into Categoria values ('005','Discos Duros')
insert into Categoria values ('006','Samsung')
insert into Categoria values ('007','Discos Duros SSD')
insert into Categoria values ('008','Memoria RAM')
insert into Categoria values ('009','Grabadoras DVD/Blu Ray')
insert into Categoria values ('010','Fuentes Alimentaci�n')
insert into Categoria values ('011','Impresoras')
insert into Categoria values ('012','Televisor')
insert into Categoria values ('013','Mouse')
insert into Categoria values ('014','Teclado')
insert into Categoria values ('015','Procesadores')
-------------------------------------------------------
---Registros MODELO	
---------------------------------------------------------
insert into Modelo values ('001','T40S')
insert into Modelo values ('002','Z97')
insert into Modelo values ('003','G835r')
insert into Modelo values ('004','MM90')
insert into Modelo values ('005','YU78')
insert into Modelo values ('006','PO90')
insert into Modelo values ('007','SW34')
insert into Modelo values ('008','GH56')
insert into Modelo values ('009','BOA1')
insert into Modelo values ('010','SERP')
insert into Modelo values ('011','COA5')
-------------------------------------------------------
---Registros PRODUCTO	
---------------------------------------------------------
insert into Producto values ('Samsung Galaxy M20 4/64GB Charcoal Black Libre',222,200,10,1,4,4,'001')
insert into Producto values ('HP Pavilion Gaming 15-CX0000NS Intel Core i7-8750H/8GB/1TB/GTX 1050Ti/15.6',500,450,5,4,2,7,'002')
insert into Producto values ('Sapphire Pulse Radeon RX 550 4GB GDDR5',220,200,6,2,11,7,'003')
insert into Producto values ('Kingston A400 SSD 240GB',75,56,7,7,12,6,'004')
insert into Producto values ('Samsung UE40NU7125 40" LED UltraHD 4K',80,60,8,12,4,9,'005')
insert into Producto values ('Lenovo Ideapad 530S-14IKB Intel Core i5-8250U/8GB/256GB SSD/MX130/14"',700,600,4,7,4,9,'006')
insert into Producto values ('Logitech Wireless Mouse M185 Azul',11,9,13,13,5,4,'007')
insert into Producto values ('Logitech Keyboard K120 Teclado USB',9,7,14,13,2,7,'008')
insert into Producto values ('Intel Core i5-8400 2.8GHz',190,160,5,15,14,7,'009')
insert into Producto values ('Toshiba P300 3.5" 1TB 7200RPM SATA 3',45,36,5,5,1,6,'010')




select * from Producto

select * from Venta

select * from DetalleVenta


Create Proc ListaVentas
as
select e.IdDetalleVenta, m.IdVenta, e.Precio, e.Cantidad, m.FechaVenta, p.Descripcion
from DetalleVenta e
inner join Producto p on e.ProductoIdProducto = p.IdProducto 
inner join  Venta m on e.VentaIdVenta = m.IdVenta

Create Proc ListaCompra
as
select e.IdDetalleCompra, m.IdCompra, e.Precio, e.Cantidad, m.FechaCompra, p.Descripcion
from DetalleCompra e
inner join Producto p on e.ProductoIdProducto = p.IdProducto 
inner join  Compra m on e.CompraIdCompra = m.IdCompra