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

            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();
                try
                {
                    caja(hm, trans);
                    venta(hm, trans);
                    compra(hm, trans);
                    articulo(hm, trans);
                    proveedor(hm, trans);
                    cliente(hm, trans);
                    usuario(hm, trans);
                    empleado(hm, trans);

                    trans.Commit();
                }
                catch(Exception ex)
                {
                    trans.Rollback();
                   MessageBox.Show("Error al cargar los datos del Home: " + ex.Message);
                }
                
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