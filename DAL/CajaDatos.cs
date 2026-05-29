using MyM26.BLL;
using MyM26.Entidades;
using MyM26.Entidades.Articulos;
using MyM26.Entidades.Caja;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MyM26.DAL
{

    public class CajaDatos
    {
        string codR;

        public VCaja TraerArt(string cb)
        {
            VCaja cj = null;
            string consulta = @"SELECT a.CodigoArticulo, a.Nombre, a.CantMinMayorista, a.PrecioUnitario, a.PrecioXMayor, a.Imagen, s.Cantidad From 
                     Articulo a INNER JOIN Stock s on a.CodigoArticulo= s.CodigoArticulo WHERE a.CodigoBarra=@cb";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cb", cb);

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cj = new VCaja();

                    cj.Nombre = reader["Nombre"].ToString();
                    cj.CantidadMinimaMayor = Convert.ToInt32(reader["CantMinMayorista"]);
                    cj.PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]);
                    cj.PrecioMayorista = Convert.ToDecimal(reader["PrecioXMayor"]);
                    cj.StockDisponible = Convert.ToInt32(reader["Cantidad"]);
                    cj.codigoArticulo = reader["CodigoArticulo"].ToString();

                    if (reader["Imagen"] != DBNull.Value)
                    {
                        cj.Imagen = (byte[])reader["Imagen"];
                    }
                    else
                    {
                        cj.Imagen = null;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al extarear la informacion del poroducto: " + ex);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return cj;
        }

        public static DataTable ClienteCaja()
        {
            string consulta = @"SELECT Cuit, Nombre + '-'+ Entidad AS NombreCompleto FROM Cliente WHERE Estado=1;";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            Decla.ClienteCaja.Clear();
            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.ClienteCaja.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer la info del cliente. " + ex);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }

            return Decla.ClienteCaja;
        }

        public VCaja ArtCajaBuscar(string filtro)
        {
            VCaja cj = null;
            string consulta = @"SELECT a.CodigoArticulo, a.CodigoBarra, a.Nombre, a.CantMinMayorista, a.PrecioUnitario, a.PrecioXMayor, a.Imagen, s.Cantidad From 
                     Articulo a INNER JOIN Stock s on a.CodigoArticulo= s.CodigoArticulo WHERE (a.CodigoBarra LIKE @filtro OR a.Nombre LIKE @filtro) AND Estado=1";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cj = new VCaja();

                    cj.Nombre = reader["Nombre"].ToString();
                    cj.CantidadMinimaMayor = Convert.ToInt32(reader["CantMinMayorista"]);
                    cj.PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]);
                    cj.PrecioMayorista = Convert.ToDecimal(reader["PrecioXMayor"]);
                    cj.StockDisponible = Convert.ToInt32(reader["Cantidad"]);
                    cj.CodigoBarra = reader["CodigoBarra"].ToString();
                    cj.codigoArticulo = reader["CodigoArticulo"].ToString();

                    if (reader["Imagen"] != DBNull.Value)
                    {
                        cj.Imagen = (byte[])reader["Imagen"];
                    }
                    else
                    {
                        cj.Imagen = null;
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al extarear la informacion del poroducto: " + ex);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return cj;
        }


        ///PARA VENTAS
        ///

        //Ultimo id hventa
        public void UltimoIdVenta(HVenta venta, SqlTransaction trans)
        {
            string consulta = @"SELECT MAX(IdVenta) as UltimoId FROM HVenta";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {

                object obj = cmd.ExecuteScalar();

                if (obj == DBNull.Value)
                    venta.UltimoIdHV = 0;
                else
                    venta.UltimoIdHV = Convert.ToInt32(obj);
            }

        }

        //Alta venta
        public void AltaVenta(HVenta venta, SqlTransaction trans)
        {
            venta.NuevoIdHV = venta.UltimoIdHV + 1;
            venta.CodRemito = "CR" + venta.NuevoIdHV;
            codR = venta.CodRemito;
            string consulta = @"insert into HVenta(IdVenta, CodRemito, DNI, Cuit, SubTotal, Descuento, Total, Factura, FormaPago, TipoComprobante)
                    values (@IdVenta, @CodRemito, @DNI, @Cuit, @SubTotal, @Descuento, @Total, @Factura, @FormaPago, @TipoComprobante)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            cmd.Parameters.AddWithValue("@IdVenta", venta.NuevoIdHV);
            cmd.Parameters.AddWithValue("@CodRemito", venta.CodRemito);
            cmd.Parameters.AddWithValue("@DNI", UsuarioActivo.Datos.DNIAc);
            cmd.Parameters.AddWithValue("@Cuit", venta.Cuit);
            cmd.Parameters.AddWithValue("@SubTotal", venta.SubtotalV);
            cmd.Parameters.AddWithValue("@Descuento", venta.Descuento);
            cmd.Parameters.AddWithValue("@Total", venta.Total);
            cmd.Parameters.AddWithValue("@Factura", venta.Factura);
            cmd.Parameters.AddWithValue("@FormaPago", venta.FormaPago);
            cmd.Parameters.AddWithValue("@TipoComprobante", venta.TipoComprobante);
            cmd.ExecuteNonQuery();
        }

        //Ultimo id de HVentaDetalle

        public int UltimoIdHVentaDetalle(SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdVentaDetalle) FROM HVentaDetalle";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            object obj = cmd.ExecuteScalar();

            if (obj == DBNull.Value || obj == null)
                return 0;

            return Convert.ToInt32(obj);
        }

        //Alta VentaDetalle
        public void AltaDetalle(HVentaDetalle det, int idDetalle, string CodRDetalle, SqlTransaction trans)
        {
            string consulta = @"insert into HVentaDetalle(IdVentaDetalle, CodRDetalle, CodRemito, CodigoArticulo, Descripcion, PrecioUnitario, Cantidad, PrecioXCantidad)
                        values(@IdVentaDetalle, @CodRDetalle, @CodRemito, @CodigoArticulo, @Descripcion, @PrecioUnitario, @Cantidad, @PrecioXCantidad)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@IdVentaDetalle", idDetalle);
            cmd.Parameters.AddWithValue("@CodRDetalle", CodRDetalle);
            cmd.Parameters.AddWithValue("@CodRemito", det.CodRemito);
            cmd.Parameters.AddWithValue("@CodigoArticulo", det.CodigoArticulo);
            cmd.Parameters.AddWithValue("@Descripcion", det.Descripcion);
            cmd.Parameters.AddWithValue("@PrecioUnitario", det.PU);
            cmd.Parameters.AddWithValue("@Cantidad", det.CantidadV);
            cmd.Parameters.AddWithValue("@PrecioXCantidad", det.PXC);
            cmd.ExecuteNonQuery();
        }

        public void ModiStockCaja(HVentaDetalle det, SqlTransaction trans)
        {
            string consulta = @"UPDATE Stock SET Cantidad= Cantidad -@cant WHERE CodigoArticulo=@cd AND Cantidad >= @cant";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            cmd.Parameters.AddWithValue("@cd", det.CodigoArticulo);
            cmd.Parameters.AddWithValue("@cant", det.CantidadV);
            cmd.ExecuteNonQuery();
        }

        //Alta completo de venta
        public void altacompletoVenta(HVenta venta, List<HVentaDetalle> detalles)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    UltimoIdVenta(venta, trans);
                    AltaVenta(venta, trans);

                    int ultimoIdDetalle = UltimoIdHVentaDetalle(trans);

                    foreach (var det in detalles)
                    {
                        ultimoIdDetalle++;

                        string codRDetalle = "CRD" + ultimoIdDetalle;

                        det.CodRemito = venta.CodRemito;

                        AltaDetalle(det, ultimoIdDetalle, codRDetalle, trans);
                        ModiStockCaja(det, trans);
                    }

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }


        //VENTA

       public PagedResult<VentaDto> MostrarVenta(int pagina, int limite)
        {
            if (pagina < 1)
                pagina = 1;
            int offset = (pagina - 1) * limite;
            int Total = 0;
            var list= new List<VentaDto>();


            using (SqlConnection conn = new SqlConnection(Decla.ConnectionString))
            {
                conn.Open();

                //Total
                string countQuery = "SELECT COUNT(*) FROM HVenta";
                using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                {
                    Total = (int)countCmd.ExecuteScalar();
                }


                string consulta = @"SELECT FechaHora, CodRemito, DNI, Cuit, SubTotal, Descuento, Total, TipoComprobante, Factura, FormaPago FROM HVenta
                                    ORDER BY FechaHora DESC OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";
                using(SqlCommand cmd= new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@limite", limite);
                    using (SqlDataReader reader= cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new VentaDto
                            {
                                FechaHora = Convert.ToDateTime(reader["FechaHora"]),
                                CodRemito = reader["CodRemito"].ToString(),
                                DNI = reader["DNI"].ToString(),
                                Cuit = reader["Cuit"].ToString(),
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]),
                                Descuento = Convert.ToDecimal(reader["Descuento"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                TipoComprobante = reader["TipoComprobante"].ToString(),
                                Factura = reader["Factura"].ToString(),
                                FormaPago = reader["FormaPago"].ToString()
                            });
                        }
                    }
                }
            }

           
          return new PagedResult<VentaDto>
          {
              Data = list,
              Total = Total
          };
        }



        public PagedResult<VDetalleDto> MostrarVentaDetalle(int pagina, int limite, string filtro)
        {
            if (pagina < 1)
                pagina = 1;
            if (limite <= 0)
                limite = 10;
            int offset = (pagina - 1) * limite;
            int Total = 0;
            var list = new List<VDetalleDto>();

            using (SqlConnection conn = new SqlConnection(Decla.ConnectionString))
            {
                conn.Open();
                //Total
                string countQuery = @"SELECT COUNT(*) FROM HVentaDetalle WHERE CodRemito=@filtro";
                using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                {
                    countCmd.Parameters.AddWithValue("@filtro", filtro);
                    Total = (int)countCmd.ExecuteScalar();
                }


                //data

                string consulta = @"SELECT Descripcion,CodRDetalle, Cantidad, PrecioXCantidad FROM HVentaDetalle WHERE CodRemito=@filtro
                                        ORDER BY Descripcion OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        cmd.Parameters.AddWithValue("@filtro", filtro);
                    }
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@limite", limite);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new VDetalleDto
                            {
                                Descripcion = reader["Descripcion"].ToString(),
                                CodRDetalle = reader["CodRDetalle"].ToString(),
                                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                PrecioXCantidad = Convert.ToDecimal(reader["PrecioXCantidad"])
                            });
                        }
                    }
                }
                return new PagedResult<VDetalleDto>
                {
                    Data = list,
                    Total = Total
                };
            }
        }

        public PagedResult<VentaDto> MostrarVentaFiltro(int pagina, int limite, DateTime fecha)
        {

            if (pagina < 1)
                pagina = 1;
            if(limite<=0)
                limite = 10;
            int offset = (pagina - 1) * limite;
            int Total = 0;
            var list = new List<VentaDto>();
            using (SqlConnection conn= new SqlConnection(Decla.ConnectionString))
               {
                conn.Open();

                //Total
                string countQuery = @"SELECT COUNT(*) FROM HVenta WHERE CAST(FechaHora AS DATE) = @fecha";
                using (SqlCommand cmd= new SqlCommand(countQuery, conn))
                {
                    if(!string.IsNullOrWhiteSpace(fecha.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                        Total = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                //data
                string consulta = @"SELECT FechaHora, CodRemito, DNI, Cuit, SubTotal, Descuento, Total, TipoComprobante, Factura, FormaPago 
                        FROM HVenta
                        WHERE CAST(FechaHora AS DATE) = @fecha
                        ORDER BY FechaHora DESC 
                        OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";

                using(SqlCommand cmd= new SqlCommand(consulta, conn))
                {
                    if (!string.IsNullOrWhiteSpace(fecha.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                    }
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@limite", limite);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new VentaDto
                            {
                                FechaHora = Convert.ToDateTime(reader["FechaHora"]),
                                CodRemito = reader["CodRemito"].ToString(),
                                DNI = reader["DNI"].ToString(),
                                Cuit = reader["Cuit"].ToString(),
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]),
                                Descuento = Convert.ToDecimal(reader["Descuento"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                TipoComprobante = reader["TipoComprobante"].ToString(),
                                Factura = reader["Factura"].ToString(),
                                FormaPago = reader["FormaPago"].ToString()
                            });
                        }
                    }
                }
            }
           return new PagedResult<VentaDto>
           {
               Data = list,
               Total = Total
           };
        }

        //
        //
        //
        //
        //
        //
        //
        //
        //
        public void IdMovimientos(HVenta hv, SqlTransaction trans)
        {

            string consulta = "SELECT ISNULL(MAX(IdHistorico), 0) FROM HMovimiento";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {

                hv.UltimoIdMov = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void AltaHistorico(HVenta hv, SqlTransaction trans)
        {
            int proximoId = hv.UltimoIdMov + 1;
            string codHistorico = "MOV" + proximoId;

            string consulta = "INSERT INTO HMovimiento(IdHistorico, CodHistorico, DNI, TipoMovimiento, FechaHora, DetalleMovimiento) " +
                              "VALUES(@IdHistorico, @CodHistorico, @DNI, @TipoMovimiento, GETDATE(), @DetalleMovimiento)";

            using (SqlCommand comd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                comd.Parameters.AddWithValue("@IdHistorico", proximoId);
                comd.Parameters.AddWithValue("@CodHistorico", codHistorico);


                comd.Parameters.AddWithValue("@DNI", UsuarioActivo.Datos.DNIAc);

                comd.Parameters.AddWithValue("@TipoMovimiento", hv.TipoMovimiento);
                comd.Parameters.AddWithValue("@DetalleMovimiento", hv.DetalleMovimiento);

                comd.ExecuteNonQuery();
            }
        }

        public void AltaHistoricoCompleto(HVenta hv)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    IdMovimientos(hv, trans);
                    AltaHistorico(hv, trans);

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error al registrar el movimiento: " + ex.Message.ToString());
                }

            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();

            }

        }


        //para IntoutVarios

        /*create table InOutVarios
(
IdMovimiento int not null,
CodMovimiento varchar(10) unique not null,
Detalle varchar(100),
Monto decimal(12,2),
Fecha datetime default getdate(),
primary key(IdMovimiento)
)*/

        public void IdIntOutVarios(HVenta hv, SqlTransaction trans)
        {
            string consulta = @"Select ISNULL(MAX(IdMovimiento), 0) as UltimoId from InOutVarios";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))

            {
                hv.UltimoIdIntOut = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void AltaIntOutVarios(HVenta hv, SqlTransaction trans)
        {

            hv.NuevoIdIntOut = hv.UltimoIdIntOut + 1;
            hv.CodMovimiento = "MOVV" + hv.NuevoIdIntOut;

            string consulta = @"INSERT INTO InOutVarios(IdMovimiento, CodMovimiento, Detalle, Monto, Fecha) 
                                VALUES(@IdMovimiento, @CodMovimiento, @Detalle, @Monto, GETDATE())";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@IdMovimiento", hv.NuevoIdIntOut);
            cmd.Parameters.AddWithValue("@CodMovimiento", hv.CodMovimiento);
            cmd.Parameters.AddWithValue("@Detalle", hv.Detalle);
            cmd.Parameters.AddWithValue("@Monto", hv.Monto);
            cmd.ExecuteNonQuery();
        }

        public void ALtaCompletoIntOutVarios(HVenta hv)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    IdIntOutVarios(hv, trans);
                    AltaIntOutVarios(hv, trans);

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error al registrar el movimiento: " + ex.Message.ToString());
                }
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();

            }
        }

        public void cantArt(VCaja vc)
        {
            string consulta = "SELECT COUNT(*) FROM Articulo WHERE Estado=1";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            try
            {
                Decla.cnn.Open();
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    vc.cantArt = 0;

                }
                else
                {
                    vc.cantArt = Convert.ToInt32(obj);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener la cantidad de artículos: " + ex.Message.ToString());
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }


        }
    }
}