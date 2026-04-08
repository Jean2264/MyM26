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

        //chart1
        public static DataTable ObtenerCantidadVentasPorMes()
        {
            string consulta = @"SELECT MONTH(FechaHora) as Mes, COUNT(*) as CantVenta
                                                FROM HVenta     
                                                WHERE YEAR(FechaHora)= YEAR(GETDATE())  
                                                GROUP BY MONTH(FechaHora) ORDER BY Mes";
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn))
                {
                    if (Decla.cnn.State != ConnectionState.Open) Decla.cnn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
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

        public static DataTable ObtenerVentasSemana()
        {
            string consulta = @"
        SELECT 
            ((DAY(FechaHora)-1)/7)+1 AS SemanaMes,
            COUNT(*) as CantidadVentas
        FROM HVenta 
        WHERE MONTH(FechaHora) = MONTH(GETDATE())
        AND YEAR(FechaHora) = YEAR(GETDATE())
        GROUP BY ((DAY(FechaHora)-1)/7)+1
        ORDER BY SemanaMes";

            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn))
            {
                if (Decla.cnn.State != ConnectionState.Open)
                    Decla.cnn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            Decla.cnn.Close();
            return dt;
        }

        public static DataTable ObtenerTotalVentasSemana()
        {
            string consulta = @"
        SELECT 
            ((DAY(FechaHora)-1)/7)+1 AS SemanaMes,
            SUM(Total) as TotalVentas
        FROM HVenta
        WHERE MONTH(FechaHora) = MONTH(GETDATE())
        AND YEAR(FechaHora) = YEAR(GETDATE())
        GROUP BY ((DAY(FechaHora)-1)/7)+1
        ORDER BY SemanaMes";

            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn))
            {
                if (Decla.cnn.State != ConnectionState.Open)
                    Decla.cnn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            Decla.cnn.Close();
            return dt;
        }


        //Para Movimientos
        public static DataTable HMovimientos(int paginaActual, int registrosPorPagina)
        {
            if (paginaActual < 1)
                paginaActual = 1;
            int offset = (paginaActual - 1) * registrosPorPagina;
           
            string consulta = "Select CodHistorico, DNI, TipoMovimiento, DetalleMovimiento, FechaHora from HMovimiento ORDER BY FechaHora DESC OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            
                cmd.Parameters.AddWithValue("@offset", offset);
                cmd.Parameters.AddWithValue("@limite", registrosPorPagina);
            Decla.MovTab.Clear();
            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.MovTab.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }

            return Decla.MovTab;
        }
       
        public int ObtenerTotalMovimiento()
        {
            int total = 0;


            string sql = "SELECT COUNT(*) FROM HMovimiento";

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

        //Para Salidas
        public static DataTable Salidas(int paginaActual, int registrosPorPagina)
        {
            if (paginaActual < 1)
                paginaActual = 1;
            int offset = (paginaActual - 1) * registrosPorPagina;
            string consulta = "SELECT CodMovimiento, Detalle, Monto, Fecha FROM InOutVarios ORDER BY Fecha DESC OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            
                cmd.Parameters.AddWithValue("@offset", offset);
                cmd.Parameters.AddWithValue("@limite", registrosPorPagina);
            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.SalTab.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }


            return Decla.SalTab;
        }


        public int ObtenerTotalSalidas()
        {
            int total = 0;


            string sql = "SELECT COUNT(*) FROM InOutVarios";

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
    }
}
