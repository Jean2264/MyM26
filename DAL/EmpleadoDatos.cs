using MyM26.Entidades;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Empleado;
using MyM26.Entidades.Usuario;
using MyM26.screens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security;
using System.Text;

namespace MyM26.DAL
{


    public class EmpleadoDatos
    {
        public void UltimoIdEmpleado(VEmpleado empleado, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdEmpleado) as UltimoId from Empleado";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    empleado.UltimoId = 0;
                }
                else
                    empleado.UltimoId = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        

        public void AltaEmpleado(VEmpleado empleado, SqlTransaction trans)
        {
            string consulta = "insert into Empleado(IdEmpleado, DNI, Apellido, Nombre, Telefono, Mail, Sector)" +
                "values(@IdEmpleado, @DNI, @Apellido, @Nombre, @Telefono, @Mail, @Sector)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@IdEmpleado", empleado.UltimoId + 1);
            cmd.Parameters.AddWithValue("@DNI", empleado.DNI);
            cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
            cmd.Parameters.AddWithValue("@Mail", empleado.Mail);
            cmd.Parameters.AddWithValue("@Sector", empleado.Seccion);
            cmd.ExecuteNonQuery();
        }

        public void AltaCompletoEmpleado(VEmpleado empleado)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();
                try
                {
                    UltimoIdEmpleado(empleado, trans);
                    AltaEmpleado(empleado, trans);

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

 
        public void ModiEmpleado(VEmpleado empleado)
        {
            string consulta = "UPDATE Empleado SET Telefono=@telefono, Mail=@mail, Sector=@sector where DNI=@DNI";
            SqlCommand cmd= new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@DNI", empleado.DNI);
            cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
            cmd.Parameters.AddWithValue("@mail", empleado.Mail);
            cmd.Parameters.AddWithValue("@sector", empleado.Seccion);
            try
            {
                Decla.cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al modificar el empleado: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }

        public VEmpleado ELiminarEmpleado(string dni)
        {
            VEmpleado empleado= null;
            string consulta = "UPDATE Empleado SET Estado=0 where DNI=@DNI";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@DNI", dni);
            try
            {
                Decla.cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return empleado;
        }

      
        public VEmpleado tomarInfo(string dni)
        {
            VEmpleado empleado = null;

            string consulta = "SELECT DNI, Apellido, Nombre, Telefono, Mail, Sector FROM Empleado Where Estado=1 and DNI=@dni";
            SqlCommand cmd= new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@dni", dni);
            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    empleado = new VEmpleado()
                    {
                        DNI = reader["DNI"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Mail = reader["Mail"].ToString(),
                        Seccion = reader["Sector"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al obtener empleado....: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }

            return empleado;
        }

        public PagedResult<EmpleadoDto> GetEmpleado(int pagina, int limite)
        {
            if (pagina < 1) pagina = 1;
            if(limite<=0) limite = 10;

            var lis = new List<EmpleadoDto>();
            int total = 0;
            int offset= (pagina-1)*limite;
            using(SqlConnection conn= new SqlConnection(Decla.ConnectionString))
            {
                conn.Open();

                //TOTAL

                string queryTotal = "SELECT COUNT(*) FROM Empleado WHERE Estado=1";

                using(SqlCommand cmd= new SqlCommand(queryTotal, conn))
                {
                    total= (int)cmd.ExecuteScalar();
                }

                //Data

                string queryData = @"select  DNI, Apellido, Nombre,
                                   Telefono, Mail, Sector from Empleado
                                    where Estado=1 ORDER BY Apellido OFFSET 
                                      @offset ROWS FETCH NEXT @limite ROWS ONLY";
                using(SqlCommand cmd= new SqlCommand(queryData, conn))
                {
                    cmd.Parameters.Add("@offset", SqlDbType.Int).Value = offset;
                    cmd.Parameters.Add("@limite", SqlDbType.Int).Value = limite;

                    using(SqlDataReader  reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lis.Add(new EmpleadoDto
                            {
                              DNI= reader["DNI"].ToString(),
                              Apellido= reader["Apellido"].ToString(),
                              Nombre= reader["Nombre"].ToString(),
                              Telefono= reader["Telefono"].ToString(),
                              Mail= reader["Mail"].ToString(),
                              Seccion= reader["Sector"].ToString(),
                            });
                        }
                    }
                }
            }

            return new PagedResult<EmpleadoDto>
            {
                Data = lis,
                Total = total
            };
        }
      public PagedResult<EmpleadoDto> GetFiltroEmpleado(int pagina, int limite, string filtro)
        {

            if (pagina < 1) pagina = 1;
            if (limite <= 0) limite = 10;

            var lis = new List<EmpleadoDto>();
            int total = 0; 
            int offset = (pagina - 1) * limite;
            using (SqlConnection conn = new SqlConnection(Decla.ConnectionString))
            {
                conn.Open();

                
                string where = "WHERE Estado=1";
                if(!string.IsNullOrWhiteSpace(filtro))
                {
                    where += @"AND (DNI LIKE @filtro OR 
                               Apellido LIKE @filtro OR 
                               Nombre LIKE @filtro OR Sector like @filtro)";
                }

                //total

                string QueryTotalC = $"SELECT COUNT(*) FROM Empleado {where}";
                using(SqlCommand cmd= new SqlCommand(QueryTotalC, conn))
                {
                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    }


                    total= (int)cmd.ExecuteScalar();
                }

                //DataFiltrada

                string queryData = @$"select  DNI, Apellido, Nombre,
                                   Telefono, Mail, Sector from Empleado
                                    {where} ORDER BY Apellido OFFSET 
                                      @offset ROWS FETCH NEXT @limite ROWS ONLY";

                using(SqlCommand cmd= new SqlCommand(queryData, conn))
                {
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@limite", limite);
                    if(!string.IsNullOrWhiteSpace(filtro))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    }


                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lis.Add(new EmpleadoDto
                            {
                                DNI = reader["DNI"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Mail = reader["Mail"].ToString(),
                                Seccion = reader["Sector"].ToString(),
                            });
                        }
                    }
                }

            }

            return new PagedResult<EmpleadoDto>
            {
                Data = lis,
                Total = total,
            };
        }

        public static DataTable BajaEmpleado()
        {
            string consulta = "SELECT TOP 50  DNI, Apellido, Nombre, Telefono, Mail, Sector from Empleado where Estado=0 ORDER BY IdEmpleado DESC";
            SqlConnection cn = new SqlConnection(Decla.ConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cn);
            Decla.bajaEmpl.Clear();
            try
            {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.bajaEmpl.Load(reader);

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
            return Decla.bajaEmpl;
        }

        public void ReactivarEmpleado(string dni)
        {
            string consulta = "UPDATE Empleado SET Estado = 1 WHERE DNI = @dni";

            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@dni", dni);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Para movimientos

        public void IdMovimientos(VEmpleado empleado, SqlTransaction trans)
        {

            string consulta = "SELECT ISNULL(MAX(IdHistorico), 0) FROM HMovimiento";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                
                empleado.UltimiIdMovimiento = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void AltaHistorico(VEmpleado empleado, SqlTransaction trans)
        {
            int proximoId = empleado.UltimiIdMovimiento + 1;
            string codHistorico = "MOV" + proximoId;

            string consulta = "INSERT INTO HMovimiento(IdHistorico, CodHistorico, DNI, TipoMovimiento, FechaHora, DetalleMovimiento) " +
                              "VALUES(@IdHistorico, @CodHistorico, @DNI, @TipoMovimiento, GETDATE(), @DetalleMovimiento)";

            using (SqlCommand comd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                comd.Parameters.AddWithValue("@IdHistorico", proximoId);
                comd.Parameters.AddWithValue("@CodHistorico", codHistorico);


                comd.Parameters.AddWithValue("@DNI", UsuarioActivo.Datos.DNIAc);

                comd.Parameters.AddWithValue("@TipoMovimiento", empleado.TipoMovimiento);
                comd.Parameters.AddWithValue("@DetalleMovimiento", empleado.DetalleMovimiento);

                comd.ExecuteNonQuery();
            }
        }

        public void AltaHistoricoCompleto(VEmpleado empleado)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    IdMovimientos(empleado, trans);
                    AltaHistorico(empleado, trans);

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
