using System;
using System.Data;
using System.Data.SqlClient;
using MyM26.Entidades.Home;
using System.Collections.Generic;
using System.Text;

namespace MyM26.DAL
{
    public class HomeDatos
    {


        //CAJA
        public void caja(VHome hm, SqlTransaction trans)
        {
            string consulta = "SELECT COUNT(*) as Cantidad FROM TipoUsuario WHERE Tipo = 'Cajero'";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    hm.caja = 0;
                }
                else
                    hm.caja = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        //VENTA
        public void venta(VHome hm, SqlTransaction trans)
        {
            string consulta = "select count(*) as Cantidad FROM HVenta ";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    hm.venta = 0;
                }
                else
                    hm.venta = Convert.ToInt32(cmd.ExecuteScalar());

            }
        }


        //COMPRA
        public void compra(VHome hm, SqlTransaction trans)
        {
            string consulta = "select count(*) as Cantidad FROM HCompra ";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    hm.compra = 0;
                }
                else
                    hm.compra = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        //ARTICULO
        public void articulo(VHome hm, SqlTransaction trans)
        {
            string consulta = "select count(*) as Cantidad FROM Articulo ";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    hm.articulo = 0;
                }
                else
                    hm.articulo = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        //PROVEEDOR
        public void proveedor(VHome hm, SqlTransaction trans)
        {
            string consulta = "select count(*) as Cantidad FROM Proveedor WHERE Estado=1";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    hm.proveedor = 0;
                }
                else
                    hm.proveedor = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        //CLIENTE
        public void cliente(VHome hm, SqlTransaction trans)
        {
            string consulta = "select count(*) as Cantidad FROM Cliente WHERE Estado=1";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    hm.cliente = 0;
                }
                else
                    hm.cliente = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        //USUARIO
        public void usuario(VHome hm, SqlTransaction trans)
        {
            string consulta = "select count(*) as Cantidad FROM Usuario WHERE Estado=1";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    hm.usuario = 0;
                }
                else
                    hm.usuario = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        //EMPLEADO
        public void empleado(VHome hm, SqlTransaction trans)
        {
            string consulta = "select count(*) as Cantidad FROM Empleado WHERE Estado=1";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    hm.empleado = 0;
                }
                else
                    hm.empleado = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void cargarDatosHome(VHome hm)
        {
            string consulta = @"
                SELECT
                    (SELECT COUNT(IdTipoUsuario) FROM TipoUsuario WHERE Tipo = 'Cajero') AS Caja,
                    (SELECT COUNT(IdVenta) FROM HVenta) AS Venta,
                    (SELECT COUNT(IdHcompra) FROM HCompra) AS Compra,
                    (SELECT COUNT(IdArticulo) FROM Articulo) AS Articulo,
                    (SELECT COUNT(IdProveedor) FROM Proveedor WHERE Estado = 1) AS Proveedor,
                    (SELECT COUNT(IdCliente) FROM Cliente WHERE Estado = 1) AS Cliente,
                    (SELECT COUNT(IdUsuario) FROM Usuario WHERE Estado = 1) AS Usuario,
                    (SELECT COUNT(IdEmpleado) FROM Empleado WHERE Estado = 1) AS Empleado;";
            try
            {
                using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn))
                {
                    Decla.cnn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hm.caja = Convert.ToInt32(reader["Caja"]);
                            hm.venta = Convert.ToInt32(reader["Venta"]);
                            hm.compra = Convert.ToInt32(reader["Compra"]);
                            hm.articulo = Convert.ToInt32(reader["Articulo"]);
                            hm.proveedor = Convert.ToInt32(reader["Proveedor"]);
                            hm.cliente = Convert.ToInt32(reader["Cliente"]);
                            hm.usuario = Convert.ToInt32(reader["Usuario"]);
                            hm.empleado = Convert.ToInt32(reader["Empleado"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del Home: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                {
                    Decla.cnn.Close();
                }
            }
            
        }
    }
}
