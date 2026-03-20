using MyM26.Entidades.Cliente;
using MyM26.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace MyM26.DAL
{
    public class ClienteDatos
    {
        private string _cuit;
        private string _nombre;
        private string _telefono;
        private string _mail;
        private string _entidad;

        //public static DataTable dt = new DataTable();

        public string Cuit { get => _cuit; set => _cuit = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public string Entidad { get => _entidad; set => _entidad = value; }
        public static DataTable LLenarDtg(int paginaActual, int registrosPorPagina)
        {
            int offset = (paginaActual - 1) * registrosPorPagina;
             string consulta = @"SELECT Nombre, Entidad, Cuit, Telefono, Mail
                   FROM Cliente
                  WHERE Estado = 1 AND EsGenerico = 0
                   ORDER BY Nombre
                   OFFSET @offset ROWS
                   FETCH NEXT @limite ROWS ONLY";
           

         

            SqlConnection cn = new SqlConnection(Decla.ConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cn);

            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@limite", registrosPorPagina);
            Decla.clienteTab.Clear();

            try
            {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.clienteTab.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return Decla.clienteTab;

        }
    
        public static DataTable bajaCliente()
        {
            string consulta = "select  Nombre, Entidad, Cuit, Telefono, Mail from Cliente where Estado=0";
            SqlConnection cn = new SqlConnection(Decla.ConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cn);
            Decla.bajaCli.Clear();

            try
            {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.bajaCli.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return Decla.bajaCli;

        }
        public void UltimoIdCliente(VCliente cliente, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdCliente) as ultimoId FROM Cliente";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    cliente.UltimoId = 0;
                }
                else
                    cliente.UltimoId = Convert.ToInt32(cmd.ExecuteScalar());

            }
        }

        public void AltaCliente(VCliente cliente, SqlTransaction trans)
        {
            string consulta = "Insert into Cliente(IdCliente, Nombre, Entidad, Cuit, Telefono, Mail)" +
                "Values(@IdCliente, @Nombre, @Entidad, @Cuit, @Telefono, @Mail)";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            cmd.Parameters.AddWithValue("@IdCliente", cliente.UltimoId + 1);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Entidad", cliente.Entidad);
            cmd.Parameters.AddWithValue("@Cuit", cliente.Cuit);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Mail", cliente.Mail);
            cmd.ExecuteNonQuery();

        }

        public void AltaCompletoCliente(VCliente cliente)
        {

            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();
                try
                {
                    UltimoIdCliente(cliente, trans);
                    AltaCliente(cliente, trans);
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

        public VCliente tomarInfo(string cuit)
        {
            VCliente cliente = null;

            string consulta =
      "SELECT Cuit, Nombre, Entidad, Telefono, Mail "+
" FROM Cliente"+
" WHERE Estado = 1 AND Cuit = @Cuit";


            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);

            cmd.Parameters.AddWithValue("@Cuit", cuit);

            try
            {

                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cliente = new VCliente()
                    {
                        Cuit = reader["Cuit"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Entidad = reader["Entidad"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Mail = reader["Mail"].ToString()
                    };

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener cliente....: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return cliente;
        }

        public void ModiCliente(VCliente cliente)
        {
            string consulta = "UPDATE Cliente SET Entidad=@Entidad, Telefono=@Telefono, Mail=@Mail Where Cuit=@Cuit";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);

            cmd.Parameters.AddWithValue("@Cuit", cliente.Cuit);
            cmd.Parameters.AddWithValue("@Entidad", cliente.Entidad);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Mail", cliente.Mail);
            try
            {
                Decla.cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }
        public VCliente EliminarCliente(string cuit)
        {
            VCliente cliente = null;
            string consulta = "Update Cliente set Estado=0 WHERE Cuit=@Cuit";
            SqlCommand comando = new SqlCommand(consulta, Decla.cnn);
            comando.Parameters.AddWithValue("@Cuit", cuit);
            try
            {
                Decla.cnn.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message.ToString());
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return cliente;
        }

        public VCliente ResumenCliente(string cuit)
        {
            VCliente cliente = new VCliente();
        
            string consulta = @"SELECT 
                            COUNT(*) AS CantidadVentas,
                            ISNULL(SUM(Total), 0) AS TotalGastado,
                            ISNULL(SUM(Descuento), 0) AS TotalDescuento,
                            MAX(FechaHora) AS UltimaCompra
                        FROM HVenta
                        WHERE Cuit = @Cuit";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@Cuit", cuit);

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cliente.CantidadVentas = Convert.ToInt32(reader["CantidadVentas"]);
                    cliente.TotalGastado = Convert.ToDecimal(reader["TotalGastado"]);
                    cliente.TotalDescuento = Convert.ToDecimal(reader["TotalDescuento"]);

                    if (reader["UltimaCompra"] != DBNull.Value)
                        cliente.UltimaCompra = Convert.ToDateTime(reader["UltimaCompra"]);
                    else
                        cliente.UltimaCompra = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }

            return cliente;
        }

        public static DataTable FiltrarCliente( string cuit)
        {

            string consulta = "select Nombre, Entidad, Cuit, Telefono, Mail from Cliente WHERE (Nombre LIKE @cuit OR Cuit LIKE @cuit) and Estado=1 AND EsGenerico=0";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cuit", "%" + cuit + "%");

            try
            {
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Decla.ClienteFilTab.Clear();

                               da.Fill(Decla.ClienteFilTab);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al filtrar el cliente: " + ex.Message.ToString());
            }
            return Decla.ClienteFilTab;
        }

        public int ObtenerTotalClientes()
        {
            int total = 0;

            string sql = "SELECT COUNT(*) FROM Cliente WHERE Estado = 1";

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

        public void ReactivarCliente(string cuit)
        {
            string consulta = "UPDATE Cliente SET Estado = 1 WHERE Cuit = @cuit";

            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@cuit", cuit);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        //Para movimientos

        public void IdMovimientos(VCliente cliente, SqlTransaction trans)
        {

            string consulta = "SELECT ISNULL(MAX(IdHistorico), 0) FROM HMovimiento";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                

                cliente.UltimiIdMovimiento = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void AltaHistorico(VCliente cliente, SqlTransaction trans)
        {
            int proximoId = cliente.UltimiIdMovimiento + 1;
            string codHistorico = "MOV" + proximoId;

            string consulta = "INSERT INTO HMovimiento(IdHistorico, CodHistorico, DNI, TipoMovimiento, FechaHora, DetalleMovimiento) " +
                              "VALUES(@IdHistorico, @CodHistorico, @DNI, @TipoMovimiento, GETDATE(), @DetalleMovimiento)";

            using (SqlCommand comd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                comd.Parameters.AddWithValue("@IdHistorico", proximoId);
                comd.Parameters.AddWithValue("@CodHistorico", codHistorico);


                comd.Parameters.AddWithValue("@DNI", UsuarioActivo.Datos.DNIAc);

                comd.Parameters.AddWithValue("@TipoMovimiento", cliente.TipoMovimiento);
                comd.Parameters.AddWithValue("@DetalleMovimiento", cliente.DetalleMovimiento);

                comd.ExecuteNonQuery();
            }
        }

        public void AltaHistoricoCompleto(VCliente cliente)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    IdMovimientos(cliente, trans);
                    AltaHistorico(cliente, trans);

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

    }
}
