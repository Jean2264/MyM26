using MyM26.Entidades.Cliente;
using MyM26.Entidades.Proveedor;
using MyM26.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MyM26.DAL
{
    public class ProveedorDatos
    {
        public void UltimoIdProveedor(VProveedor prov, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdProveedor) as ultimoId FROM Proveedor";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    prov.UltimoId = 0;
                }
                else
                    prov.UltimoId = Convert.ToInt32(cmd.ExecuteScalar());
                {

                }
            }
        }
        public void AltaProveedor(VProveedor prov, SqlTransaction trans)
        {
            string consulta = "insert into Proveedor(IdProveedor, Nombre, Cuit, Empresa, Telefono, Mail)" +
                "values(@IdProveedor, @Nombre, @Cuit, @Empresa, @Telefono, @Mail)";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            cmd.Parameters.AddWithValue("@IdProveedor", prov.UltimoId + 1);
            cmd.Parameters.AddWithValue("@Nombre", prov.Nombre);
            cmd.Parameters.AddWithValue("@Cuit", prov.Cuit);
            cmd.Parameters.AddWithValue("@Empresa", prov.Empresa);
            cmd.Parameters.AddWithValue("@Telefono", prov.Telefono);
            cmd.Parameters.AddWithValue("@Mail", prov.Mail);
            cmd.ExecuteNonQuery();

        }
        public void AltaCompletoProveedor(VProveedor prov)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();
                try
                {
                    UltimoIdProveedor(prov, trans);
                    AltaProveedor(prov, trans);

                    trans.Commit();
                }
                catch (Exception)
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

        
        public static DataTable LLenarDtg(int paginaActual, int registrosPorPagina)
        {
            int offset = (paginaActual - 1) * registrosPorPagina;
            string consulta = "select  Nombre, Empresa, Cuit, Telefono, Mail from Proveedor where Estado=1 ORDER BY Nombre OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";
            SqlConnection cn = new SqlConnection(Decla.ConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cn);
            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@limite", registrosPorPagina);

            Decla.proveedorTab.Clear();
            try
            {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.proveedorTab.Load(reader);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Error al cargar los datos", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return Decla.proveedorTab;
        }


      
        public VProveedor tomarInfo(string cuit)
        {
            VProveedor prov = null;


            string consulta = "SELECT Cuit, Nombre, Empresa, Telefono, Mail " +
                " FROM Proveedor " +
                " WHERE Estado = 1 AND Cuit = @Cuit";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@Cuit", cuit);

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    prov = new VProveedor()
                    {
                        Cuit = reader["Cuit"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Empresa = reader["Empresa"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Mail = reader["Mail"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al obtener proveedor....: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return prov;
        }



        public VProveedor resumenProv(string cuit)
        {
            VProveedor prov = new VProveedor();

            string consulta = @"SELECT 
                            COUNT(*) AS CantidadCompras,
                            ISNULL(SUM(Total), 0) AS TotalGastado,
                            ISNULL(SUM(Descuento), 0) AS TotalDescuento,
                            MAX(FechaHora) AS UltimaCompra
                        FROM HCompra
                        WHERE Cuit = @Cuit";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@Cuit", cuit);

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    prov.CantidadCompras = Convert.ToInt32(reader["CantidadCompras"]);
                    prov.TotalGastado = Convert.ToDecimal(reader["TotalGastado"]);
                    prov.TotalDescuento = Convert.ToDecimal(reader["TotalDescuento"]);
                    if (reader["UltimaCompra"] != DBNull.Value)
                        prov.UltimaCompra = Convert.ToDateTime(reader["UltimaCompra"]);
                    else
                        prov.UltimaCompra = null;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return prov;
        }

       
        public VProveedor EliminarProveedor(string cuit)
        {
            VProveedor prov = null;
            string consulta = "Update Proveedor set Estado=0 WHERE Cuit=@Cuit";
            SqlCommand comando = new SqlCommand(consulta, Decla.cnn);
            comando.Parameters.AddWithValue("@Cuit", cuit);
            try
            {
                Decla.cnn.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al eliminar el proveedor: " + ex.Message.ToString());
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return prov;
        }
        public void ModiProveedor(VProveedor prov)
        {
            string consulta = "UPDATE Proveedor SET Empresa=@Empresa, Telefono=@Telefono, Mail=@Mail Where Cuit=@Cuit";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@Cuit", prov.Cuit);
            cmd.Parameters.AddWithValue("@Empresa", prov.Empresa);
            cmd.Parameters.AddWithValue("@Telefono", prov.Telefono);
            cmd.Parameters.AddWithValue("@Mail", prov.Mail);
            try
            {
                Decla.cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al modificar el proveedor: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }

        public static DataTable BajaProv()
        {
            string consulta = "select  Nombre, Empresa, Cuit, Telefono, Mail from Proveedor where Estado=0";
            SqlConnection cn = new SqlConnection(Decla.ConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cn);
            Decla.bajaProv.Clear();
            try
            {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.bajaProv.Load(reader);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Error al cargar los datos", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return Decla.bajaProv;
        }
        public int ObtenerTotalProveedor()
        {
            int total = 0;

            string sql = "SELECT COUNT(*) FROM Proveedor WHERE Estado = 1";

            SqlCommand cmd = new SqlCommand(sql, Decla.cnn);

            try
            {
                Decla.cnn.Open();
                total = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }

            return total;
        }

        public void ReactivarProveedor(string cuit)
        {
            string consulta = "UPDATE Proveedor SET Estado = 1 WHERE Cuit = @cuit";

            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@cuit", cuit);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }



        //Para movimientos

        public void IdMovimientos(VProveedor prov, SqlTransaction trans)
        {

            string consulta = "SELECT ISNULL(MAX(IdHistorico), 0) FROM HMovimiento";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
               
                prov.UltimiIdMovimiento = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void AltaHistorico(VProveedor prov, SqlTransaction trans)
        {
            int proximoId = prov.UltimiIdMovimiento + 1;
            string codHistorico = "MOV" + proximoId;

            string consulta = "INSERT INTO HMovimiento(IdHistorico, CodHistorico, DNI, TipoMovimiento, FechaHora, DetalleMovimiento) " +
                              "VALUES(@IdHistorico, @CodHistorico, @DNI, @TipoMovimiento, GETDATE(), @DetalleMovimiento)";

            using (SqlCommand comd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                comd.Parameters.AddWithValue("@IdHistorico", proximoId);
                comd.Parameters.AddWithValue("@CodHistorico", codHistorico);


                comd.Parameters.AddWithValue("@DNI", UsuarioActivo.Datos.DNIAc);

                comd.Parameters.AddWithValue("@TipoMovimiento", prov.TipoMovimiento);
                comd.Parameters.AddWithValue("@DetalleMovimiento", prov.DetalleMovimiento);

                comd.ExecuteNonQuery();
            }
        }

        public void AltaHistoricoCompleto(VProveedor prov)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    IdMovimientos(prov, trans);
                    AltaHistorico(prov, trans);

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


        public static DataTable FiltrarProv(string cuit)
        {

            string consulta = "select Nombre, Empresa, Cuit, Telefono, Mail from Proveedor WHERE (Nombre LIKE @cuit OR Cuit LIKE @cuit) and Estado=1";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cuit", "%" + cuit + "%");

            try
            {

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Decla.proveedorTab.Clear();

                da.Fill(Decla.proveedorTab);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al filtrar el proveedor: " + ex.Message.ToString());
            }
            return Decla.proveedorTab;
        }
    }
}

