create database MyM7
use MyM7

create table Proveedor
(
IdProveedor int not null,
Cuit varchar(11) unique,
Empresa varchar(200),
Nombre varchar(100),
Telefono varchar(15),
Mail varchar(200),
Estado bit default 1 not null,
primary key(IdProveedor)
)

create table Categoria
(
IdCategoria int not null,
CodCategoria varchar(10) unique not null,
Categoria varchar(100),
Estado bit default 1 not null,
primary key(IdCategoria)
)

create table Subcategoria
(
IdSubcategoria int not null,
CodSubcategoria varchar(10) unique not null,
Subcategoria varchar(100) not null,
CodCategoria varchar(10),
Estado bit default 1 not null,
primary key(IdSubcategoria),
foreign key (CodCategoria) references Categoria (CodCategoria)
)

create table Articulo
(
IdArticulo int not null,
CodigoArticulo varchar(10) unique not null,
CodigoBarra varchar(100) unique ,
Imagen varbinary(max) null,
Nombre varchar(100),
CantMinMayorista int,
PrecioUnitario decimal(12,2),
PrecioXMayor decimal(12,2),
FechaAlta datetime,
Estado bit default 1 not null,
CodCategoria varchar(10),
CodSubcategoria varchar(10),
Cuit varchar(11),
primary key(IdArticulo),
foreign key (CodCategoria) references Categoria (CodCategoria),
foreign key (CodSubcategoria) references Subcategoria (CodSubcategoria),
foreign key (Cuit) references Proveedor (Cuit)

)
--EXEC sp_rename 'Clientes.Telefono', 'NumeroTelefono', 'COLUMN';




create table Stock 
(
IdStock int  not null,
CodStock varchar(10) unique not null,
Cantidad int,
Costo decimal(12,2),
Ganancia decimal(12,2),
CodigoArticulo varchar(10),
primary key(IdStock),
foreign key(CodigoArticulo) references Articulo (CodigoArticulo)
)


create table Empleado
(
IdEmpleado int not null,
DNI varchar(8) unique,
Apellido varchar(100),
Nombre varchar(100),
Telefono varchar(15),
Mail varchar(200),
Sector varchar(100),
Estado bit default 1 not null,
primary key(IdEmpleado)
)

create table Cliente
(
IdCliente int not null,
Cuit varchar(11) unique,
Nombre varchar(100),
Entidad varchar(100),
Telefono varchar(25),
Mail varchar(200),
Estado bit default 1 not null,
esGenerico bit default 0 not null
primary key(IdCliente)
)

INSERT INTO Cliente (IdCliente, Cuit, Nombre, Entidad, Telefono, Mail, Estado, esGenerico)
VALUES (1, '00000000000', 'Consumidor Final', '1111111111', NULL, 'null@gmail.com', 1, 1);

create table TipoUsuario
(
IdTipoUsuario int not null,
CodTipoUsuario varchar(10) unique not null,
Tipo varchar(100),
Cajas bit,
Compras bit,
Productos bit ,
Ventas bit,
Usuarios bit,
Empleados bit, 
Clientes bit,
Proveedores bit,
EstadoContable bit,
Estado bit default 1,
primary key(IdTipoUsuario)
)

create table Usuario
(
IdUsuario int not null,
DNI varchar(8) unique not null,
Usuario varchar(20) unique,
Contrasenia varchar(20),
Telefono varchar(15),
Mail varchar(200),
FechaAlta datetime default getdate(),
Estado bit default 1 not null,
Perfil varbinary(max),
TokenRecuperacion varchar(10),
TokenExpira datetime,
CodTipoUsuario varchar(10),
primary key(IdUsuario),
foreign key(CodTipoUsuario) references TipoUsuario (CodTipoUsuario)
)



-- 1. Crear el tipo de usuario ADMIN (si no existe)
INSERT INTO dbo.TipoUsuario 
    (IdTipoUsuario, CodTipoUsuario, Tipo, Cajas, Compras, Productos, Ventas, Empleados, Usuarios, Clientes, Proveedores, EstadoContable, Estado)
VALUES 
    (1, 'CTU1', 'Administrador', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1) 

-- 2. Crear el usuario admin
INSERT INTO dbo.Usuario 
    (IdUsuario, DNI, Usuario, Contrasenia, Telefono, Mail, FechaAlta, Estado, CodTipoUsuario)
VALUES 
    (1, '95237175', 'Jean2005', 'Jean2005', 1157240315, 'apaivajean263@gmail.com', GETDATE(), 1, 'CTU1')


create table HCompra
(
IdHcompra int not null,
FechaAlta datetime default getdate(),
CodHCompra varchar(10) unique,
DNI varchar(8),
Cuit varchar(11),
SubTotal decimal(12,2),
Descuento decimal(12,2),
Total decimal(12,2),
primary key(IdHcompra),
foreign key(DNI) references Usuario(DNI),
foreign key(Cuit) references Proveedor (Cuit)
)

create table HCompraDetalle
(
IdHCompraDetalle int not null,
 CodHCDetalle varchar(10) unique not null,
 CodHCompra varchar(10),
 CodigoArticulo varchar(10),
 Descripcion varchar(100),
 PrecioUnitario decimal(12,2),
 Cantidad int,
 PrecioXCantidad decimal(12,2),
 primary key(IdHCompraDetalle),
 foreign key (CodHCompra) references HCompra(CodHCompra),
 foreign key (CodigoArticulo) references Articulo (CodigoArticulo)
 )

create table DescuentoCliente
(
IdDescuento int not null,
CodDesc varchar(10) unique not null,
DescuentoSocio decimal(5,2)-- Por ejemplo, 5.00 significa 5% de descuento
)

 insert into DescuentoCliente (IdDescuento, CodDesc, DescuentoSocio) values (1, 'DESC1', 05.00);
select * from DescuentoCliente
 
create table HVenta
(
IdVenta int not null,
CodRemito varchar(10) unique not null,
DNI varchar(8),
Cuit varchar(11),
FechaHora datetime default getdate(),
SubTotal decimal(12,2),
Descuento decimal(12,2),
Total decimal(12,2),
TipoComprobante varchar(200),
Factura varchar(100),
FormaPago varchar(100),
primary key(IdVenta),
foreign key(DNI) references Usuario (DNI),
foreign key (Cuit) references Cliente (Cuit)
)

create table HVentaDetalle
(
IdVentaDetalle int not null,
CodRDetalle varchar(10) unique not null,
CodRemito varchar(10),
CodigoArticulo varchar(10),
Descripcion varchar(100),
PrecioUnitario decimal(12,2),
Cantidad int,
PrecioXCantidad decimal(12,2),
primary key (IdVentaDetalle),
foreign key(CodRemito) references HVenta(CodRemito),
foreign key (CodigoArticulo) references Articulo (CodigoArticulo)
)

create table InOutVarios
(
IdMovimiento int not null,
CodMovimiento varchar(10) unique not null,
Detalle varchar(100),
Monto decimal(12,2),
Fecha datetime default getdate(),
primary key(IdMovimiento)
)

create table HMovimiento
(
IdHistorico int not null,
CodHistorico varchar(10) unique not null,
DNI varchar(8),
TipoMovimiento varchar(100),
DetalleMovimiento varchar(max),
FechaHora datetime default getdate(),
primary key (IdHistorico),
foreign key(DNI) references Usuario (DNI)
)




 --VISTAS BASE
 --Una vista no recibe parametros. Sirve para centralizar joins
 --y columnas calculadas reutilizables.


--VISTAS, INDEXS Y FUNCIONES/PROCEDURES

--VISTA PARA ARTICULO ESTADO=1, para el modal

CREATE OR ALTER VIEW dbo.vw_ArticuloStockActivo
AS
SELECT
 a.CodigoArticulo,
 a.CodigoBarra,
 a.Nombre,
 a.CantMinMayorista,
 a.PrecioUnitario,
 a.PrecioXMayor,
 a.FechaAlta,
 a.CodCategoria,
 c.Categoria,
 a.CodSubcategoria,
 sc.Subcategoria,
 a.Cuit,
 p.Nombre AS ProveedorNombre,
 p.Empresa AS ProveedorEmpresa,
 s.Cantidad,
 s.Costo,
 s.Ganancia
 FROM dbo.Articulo a
 INNER JOIN dbo.Stock s ON s.CodigoArticulo= a.CodigoArticulo
 LEFT JOIN dbo.Categoria c ON c.CodCategoria= a.CodCategoria
 LEFT JOIN dbo.Subcategoria sc ON sc.CodSubcategoria= a.CodSubcategoria
 LEFT JOIN dbo.Proveedor p ON p.Cuit= a.Cuit
WHERE a.Estado=1
GO



--VISTA PARA USUARIO GENERAL
CREATE OR ALTER VIEW dbo.vw_UsuarioCompleto
AS
SELECT
    u.DNI,
    u.Usuario,
    u.Contrasenia,
    u.Telefono,
    u.Mail,
    u.FechaAlta,
    u.Estado,
    u.Perfil,
    u.TokenRecuperacion,
    u.TokenExpira,
    u.CodTipoUsuario,
    t.Tipo,
    t.Cajas,
    t.Compras,
    t.Productos,
    t.Ventas,
    t.Usuarios,
    t.Empleados,
    t.Clientes,
    t.Proveedores,
    t.EstadoContable
FROM dbo.Usuario u
INNER JOIN dbo.TipoUsuario t
    ON u.CodTipoUsuario = t.CodTipoUsuario;
GO



--VISTA PARA VENTAS BASE
CREATE OR ALTER VIEW dbo.vw_VentasBase
AS
SELECT
    CodRemito,
    DNI,
    Cuit,
    FechaHora,
    SubTotal,
    Descuento,
    Total,
    TipoComprobante,
    Factura,
    FormaPago
FROM dbo.HVenta;
GO

--VISTA PARA COMPRAS BASE
CREATE OR ALTER VIEW dbo.vw_ComprasBase
AS
SELECT
    h.CodHCompra,
    h.FechaAlta,
    h.DNI,
    h.Cuit,
    h.SubTotal,
    h.Descuento,
    h.Total,
    d.IdHCompraDetalle,
    d.CodHCDetalle,
    d.CodigoArticulo,
    d.Descripcion,
    d.PrecioUnitario,
    d.Cantidad,
    d.PrecioXCantidad
FROM dbo.HCompra h
INNER JOIN dbo.HCompraDetalle d ON d.CodHCompra = h.CodHCompra;
GO



--PROCEDIMIENTOS 

--PARA ARTICULO PAGINADO

CREATE OR ALTER PROCEDURE dbo.sp_ListarArticulos
    @pagina int,
    @limite int

AS
BEGIN 
    SET NOCOUNT ON;
    if @pagina <1 SET @pagina=1;
    if @limite <=0 SET @limite=10;

    DECLARE @offset int= (@pagina-1)* @limite;

    SELECT 
    COUNT(*) OVER() AS TotalRegistros,
        CodigoArticulo,
        CodigoBarra,
        Nombre,
        Categoria,
        Subcategoria,
        ProveedorNombre,
        ProveedorEmpresa,
        PrecioUnitario,
        PrecioXMayor,
        Cantidad
FROM dbo.vw_ArticuloStockActivo

  
  ORDER BY Nombre
  OFFSET @offset ROWS
  FETCH NEXT @limite ROWS ONLY;
  END;
  GO
    