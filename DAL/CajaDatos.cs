using System;
using System.Data.SqlClient;
using System.Data;
using MyM26.BLL;
using MyM26.Entidades.Comun;
using MyM26.Entidades;
using MyM26.Entidades.Usuario;
using System.Collections.Generic;
using System.Text;
using MyM26.Entidades.Caja;

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
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn,trans);
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
    }
}