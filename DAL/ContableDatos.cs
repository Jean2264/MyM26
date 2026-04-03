using System;
using System.Data.SqlClient;
using System.Data;
using MyM26.BLL;
using MyM26.Entidades.Comun;
using MyM26.Entidades;
using MyM26.Entidades.Usuario;
using System.Collections.Generic;
using System.Text;

namespace MyM26.DAL
{
   public class ContableDatos
    {

       public static DataTable ObtenerVentasPorMes()
        {
            string consulta = @"SELECT MONTH(FechaHora) as Mes, SUM(Total) as TotalVenta
                                                FROM HVenta     
                                                WHERE YEAR(FechaHora)= YEAR(GETDATE())  
                                                GROUP BY MONTH(FechaHora) ORDER BY Mes";
            DataTable dt= new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn))
                {
                    if(Decla.cnn.State!= ConnectionState.Open) Decla.cnn.Open();
                    SqlDataAdapter da= new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener estadísticas: " + ex.Message);
            }
            finally { Decla.cnn.Close(); }

            return dt;
        }
    }
}
