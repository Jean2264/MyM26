USE MyM9;
GO

/* ============================================================
   INDICES RECOMENDADOS
   ============================================================ */

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_HVenta_FechaHora' AND object_id = OBJECT_ID('dbo.HVenta'))
    CREATE INDEX IX_HVenta_FechaHora
    ON dbo.HVenta (FechaHora)
    INCLUDE (IdVenta, CodRemito, DNI, Cuit, SubTotal, Descuento, Total, TipoComprobante, Factura, FormaPago);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_HVenta_Cuit_FechaHora' AND object_id = OBJECT_ID('dbo.HVenta'))
    CREATE INDEX IX_HVenta_Cuit_FechaHora
    ON dbo.HVenta (Cuit, FechaHora)
    INCLUDE (IdVenta, Total, Descuento);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_HCompra_Cuit_FechaAlta' AND object_id = OBJECT_ID('dbo.HCompra'))
    CREATE INDEX IX_HCompra_Cuit_FechaAlta
    ON dbo.HCompra (Cuit, FechaAlta)
    INCLUDE (IdHcompra, Total, Descuento);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_HMovimiento_FechaHora' AND object_id = OBJECT_ID('dbo.HMovimiento'))
    CREATE INDEX IX_HMovimiento_FechaHora
    ON dbo.HMovimiento (FechaHora DESC)
    INCLUDE (IdHistorico, CodHistorico, DNI, TipoMovimiento, DetalleMovimiento);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_InOutVarios_Fecha' AND object_id = OBJECT_ID('dbo.InOutVarios'))
    CREATE INDEX IX_InOutVarios_Fecha
    ON dbo.InOutVarios (Fecha DESC)
    INCLUDE (IdMovimiento, CodMovimiento, Detalle, Monto);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_Articulo_Estado_Nombre' AND object_id = OBJECT_ID('dbo.Articulo'))
    CREATE INDEX IX_Articulo_Estado_Nombre
    ON dbo.Articulo (Estado, Nombre)
    INCLUDE (IdArticulo, CodigoArticulo, CodigoBarra, PrecioUnitario, PrecioXMayor, CantMinMayorista, Cuit, CodCategoria, CodSubcategoria);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_Stock_CodigoArticulo' AND object_id = OBJECT_ID('dbo.Stock'))
    CREATE INDEX IX_Stock_CodigoArticulo
    ON dbo.Stock (CodigoArticulo)
    INCLUDE (IdStock, Cantidad, Costo, Ganancia);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_Cliente_Estado_Nombre' AND object_id = OBJECT_ID('dbo.Cliente'))
    CREATE INDEX IX_Cliente_Estado_Nombre
    ON dbo.Cliente (Estado, esGenerico, Nombre)
    INCLUDE (IdCliente, Cuit, Entidad, Telefono, Mail);
GO

IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'IX_Proveedor_Estado_Nombre' AND object_id = OBJECT_ID('dbo.Proveedor'))
    CREATE INDEX IX_Proveedor_Estado_Nombre
    ON dbo.Proveedor (Estado, Nombre)
    INCLUDE (IdProveedor, Cuit, Empresa, Telefono, Mail);
GO

/* ============================================================
   VISTAS BASE
   Una vista no recibe parametros. Sirve para centralizar joins
   y columnas calculadas reutilizables.
   ============================================================ */

CREATE OR ALTER VIEW dbo.vw_ArticuloStockActivo
AS
SELECT
    a.IdArticulo,
    a.CodigoArticulo,
    a.CodigoBarra,
    a.Nombre,
    a.CantMinMayorista,
    a.PrecioUnitario,
    a.PrecioXMayor,
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
INNER JOIN dbo.Stock s ON s.CodigoArticulo = a.CodigoArticulo
LEFT JOIN dbo.Categoria c ON c.CodCategoria = a.CodCategoria
LEFT JOIN dbo.Subcategoria sc ON sc.CodSubcategoria = a.CodSubcategoria
LEFT JOIN dbo.Proveedor p ON p.Cuit = a.Cuit
WHERE a.Estado = 1;
GO

CREATE OR ALTER VIEW dbo.vw_VentasBase
AS
SELECT
    IdVenta,
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

CREATE OR ALTER VIEW dbo.vw_ComprasBase
AS
SELECT
    h.IdHcompra,
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

/* ============================================================
   FUNCIONES DE TABLA EN LINEA
   Usalas cuando quieres algo parecido a una vista, pero con
   parametros de entrada.
   ============================================================ */

CREATE OR ALTER FUNCTION dbo.fn_ResumenCliente (@Cuit varchar(11))
RETURNS TABLE
AS
RETURN
(
    SELECT
        COUNT(IdVenta) AS CantidadVentas,
        ISNULL(SUM(Total), 0) AS TotalGastado,
        ISNULL(SUM(Descuento), 0) AS TotalDescuento,
        MAX(FechaHora) AS UltimaCompra
    FROM dbo.HVenta
    WHERE Cuit = @Cuit
);
GO

CREATE OR ALTER FUNCTION dbo.fn_ResumenProveedor (@Cuit varchar(11))
RETURNS TABLE
AS
RETURN
(
    SELECT
        COUNT(IdHcompra) AS CantidadCompras,
        ISNULL(SUM(Total), 0) AS TotalGastado,
        ISNULL(SUM(Descuento), 0) AS TotalDescuento,
        MAX(FechaAlta) AS UltimaCompra
    FROM dbo.HCompra
    WHERE Cuit = @Cuit
);
GO

/* ============================================================
   PROCEDIMIENTOS PARA REPORTES Y LISTADOS
   Usalos cuando C# necesita mandar parametros y recibir datos ya
   filtrados, paginados o agregados.
   ============================================================ */

CREATE OR ALTER PROCEDURE dbo.sp_ContableVentasMensuales
    @Anio int
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Desde date = DATEFROMPARTS(@Anio, 1, 1);
    DECLARE @Hasta date = DATEADD(YEAR, 1, @Desde);

    SELECT
        MONTH(FechaHora) AS Mes,
        COUNT(IdVenta) AS CantVenta,
        ISNULL(SUM(Total), 0) AS TotalVenta
    FROM dbo.HVenta
    WHERE FechaHora >= @Desde
      AND FechaHora < @Hasta
    GROUP BY MONTH(FechaHora)
    ORDER BY Mes;
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_ContableVentasSemanales
    @Anio int,
    @Mes int
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Desde date = DATEFROMPARTS(@Anio, @Mes, 1);
    DECLARE @Hasta date = DATEADD(MONTH, 1, @Desde);

    SELECT
        ((DAY(FechaHora) - 1) / 7) + 1 AS SemanaMes,
        COUNT(IdVenta) AS CantidadVentas,
        ISNULL(SUM(Total), 0) AS TotalVentas
    FROM dbo.HVenta
    WHERE FechaHora >= @Desde
      AND FechaHora < @Hasta
    GROUP BY ((DAY(FechaHora) - 1) / 7) + 1
    ORDER BY SemanaMes;
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_ListarArticulos
    @Pagina int,
    @Limite int,
    @Filtro varchar(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Pagina < 1 SET @Pagina = 1;
    IF @Limite < 1 SET @Limite = 10;

    DECLARE @Offset int = (@Pagina - 1) * @Limite;
    DECLARE @Buscar varchar(102) = NULLIF(LTRIM(RTRIM(@Filtro)), '');

    SELECT
        COUNT(*) OVER() AS TotalRegistros,
        CodigoArticulo,
        CodigoBarra,
        Nombre,
        PrecioUnitario,
        PrecioXMayor,
        Cantidad
    FROM dbo.vw_ArticuloStockActivo
    WHERE @Buscar IS NULL
       OR Nombre LIKE '%' + @Buscar + '%'
       OR CodigoBarra LIKE '%' + @Buscar + '%'
    ORDER BY Nombre
    OFFSET @Offset ROWS FETCH NEXT @Limite ROWS ONLY;
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_ListarVentas
    @Pagina int,
    @Limite int,
    @Fecha date = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Pagina < 1 SET @Pagina = 1;
    IF @Limite < 1 SET @Limite = 10;

    DECLARE @Offset int = (@Pagina - 1) * @Limite;

    SELECT
        COUNT(*) OVER() AS TotalRegistros,
        FechaHora,
        CodRemito,
        DNI,
        Cuit,
        SubTotal,
        Descuento,
        Total,
        TipoComprobante,
        Factura,
        FormaPago
    FROM dbo.vw_VentasBase
    WHERE @Fecha IS NULL
       OR (FechaHora >= @Fecha AND FechaHora < DATEADD(DAY, 1, @Fecha))
    ORDER BY FechaHora DESC
    OFFSET @Offset ROWS FETCH NEXT @Limite ROWS ONLY;
END;
GO

CREATE OR ALTER PROCEDURE dbo.sp_HomeContadores
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        (SELECT COUNT(IdTipoUsuario) FROM dbo.TipoUsuario WHERE Tipo = 'Cajero') AS Caja,
        (SELECT COUNT(IdVenta) FROM dbo.HVenta) AS Venta,
        (SELECT COUNT(IdHcompra) FROM dbo.HCompra) AS Compra,
        (SELECT COUNT(IdArticulo) FROM dbo.Articulo) AS Articulo,
        (SELECT COUNT(IdProveedor) FROM dbo.Proveedor WHERE Estado = 1) AS Proveedor,
        (SELECT COUNT(IdCliente) FROM dbo.Cliente WHERE Estado = 1) AS Cliente,
        (SELECT COUNT(IdUsuario) FROM dbo.Usuario WHERE Estado = 1) AS Usuario,
        (SELECT COUNT(IdEmpleado) FROM dbo.Empleado WHERE Estado = 1) AS Empleado;
END;
GO
