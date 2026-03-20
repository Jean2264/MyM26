using System;
using System.Data.SqlClient;
using System.Data;
using MyM26.BLL;
using MyM26.Entidades.Comun;
using MyM26.Entidades;
using System.Collections.Generic;
using System.Text;
using MyM26.Entidades.Caja;

namespace MyM26.DAL
{
   public class CajaDatos
    {
        public VCaja TraerArt(string cb)
        {
            VCaja cj = null;
            string consulta = @"SELECT a.Nombre, a.CantMinMayorista, a.PrecioUnitario, a.PrecioXMayor, a.Imagen, s.Cantidad From 
                     Articulo a INNER JOIN Stock s on a.CodigoArticulo= s.CodigoArticulo WHERE a.CodigoBarra=@cb";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cb", cb);

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    cj = new VCaja();
                    
                        cj.Nombre= reader["Nombre"].ToString();
                        cj.CantidadMinimaMayor= Convert.ToInt32(reader["CantMinMayorista"]);
                        cj.PrecioUnitario= Convert.ToDecimal(reader["PrecioUnitario"]);
                        cj.PrecioMayorista= Convert.ToDecimal(reader["PrecioXMayor"]);
                        cj.StockDisponible = Convert.ToInt32(reader["Cantidad"]);
                   
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
            catch(Exception ex)
            {
                MessageBox.Show("Error al traer la info del cliente. "+ ex);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }

            return Decla.ClienteCaja;
        }
    }
}
