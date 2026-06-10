using MyM26.Entidades;
using MyM26.Entidades.CatySub;
using MyM26.Entidades.Cliente;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MyM26.DAL
{
    public class CatySubDatos
    {

        //TODO DE CATEGORIA

        //Traemos el ultimo id de categoria para generar el nuevo id
        public void UltimoIdCategoria(VCatySub cat, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdCategoria) as UltimoId from Categoria";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    cat.UltimoIdCategoria = 0;
                }
                else
                {
                    cat.UltimoIdCategoria = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        //Hacemos el insert de categoria

        public void AltaCategoria(VCatySub cat, SqlTransaction trans)
        {
            cat.CodCategoria = "CAT" + (cat.UltimoIdCategoria + 1);
            string consulta = "Insert into Categoria(IdCategoria, CodCategoria, Categoria) " +
                "values(@IdCategoria, @CodCategoria, @Categoria)";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@IdCategoria", (cat.UltimoIdCategoria + 1));
            cmd.Parameters.AddWithValue("@CodCategoria", cat.CodCategoria);
            cmd.Parameters.AddWithValue("@Categoria", cat.Categoria);
            cmd.ExecuteNonQuery();
        }

        //Hacemos el metodo del atla completo

        public void AltaCompletoCategoria(VCatySub cat)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    UltimoIdCategoria(cat, trans);
                    AltaCategoria(cat, trans);

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
                {
                    Decla.cnn.Close();
                }
            }
        }

        //Baja categoria
        public static void BajaCategoria(string cod)
        {
            string consulta = "UPDATE Categoria set Estado=0 where CodCategoria=@cod";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cod", cod);
            try
            {
                Decla.cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja a la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }

        //CATEGORIA PARA MOSTRAR EN EL DATAGRIDVIEW
        public PagedResult<CategoriaDto> MostrarCategoria(int pagina, int limite)
        {

            if (pagina < 1)
                pagina = 1;

            int offset = (pagina - 1) * limite;
            int total = 0;
            var list = new List<CategoriaDto>();
            using (SqlConnection conn = new SqlConnection(Decla.ConnectionString))
            {

                conn.Open();

                string countQuery = "SELECT COUNT(*) FROM Categoria WHERE Estado=1";
                using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                {
                    total = (int)countCmd.ExecuteScalar();
                }

                string consulta = @"select CodCategoria, Categoria from Categoria where 
                                    Estado=1 ORDER BY  Categoria OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@limite", limite);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new CategoriaDto
                            {
                                CodCategoria = reader["CodCategoria"].ToString(),
                                Categoria = reader["Categoria"].ToString()
                            });
                        }
                    }
                }
            }
            return new PagedResult<CategoriaDto>
            {
                Data = list,
                Total = total
            };
        }

        //CATEGORIA PARA FILTRAR EN EL DATAGRIDVIEW
        public PagedResult<CategoriaDto> MostrarCategoriaFiltro(int pagina, int limite, string filtro)
        {
            if (pagina < 1) pagina = 1;
            if (limite <= 0) limite = 10;
            int offset = (pagina - 1) * limite;
            int total = 0;
            var list = new List<CategoriaDto>();
            using (SqlConnection conn = new SqlConnection(Decla.ConnectionString))
            {
                conn.Open();

                string countQuery = "Select COUNT(*) FROM Categoria WHERE Estado=1 AND Categoria LIKE @filtro";
                using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                {
                    countCmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                    total = (int)countCmd.ExecuteScalar();
                }

                // Consulta SQL para obtener categorías filtradas y paginadas:
                // - Selecciona CodCategoria y Categoria desde la tabla Categoria
                // - Filtra los registros con Estado = 1 y los que coinciden con el patrón @filtro (LIKE)
                // - Ordena por la columna Categoria
                // - Aplica paginación usando OFFSET @offset ROWS y FETCH NEXT @limite ROWS ONLY
                //   - OFFSET @offset ROWS: salta las primeras @offset filas del conjunto ordenado.
                //     Normalmente @offset = (pagina - 1) * limite.
                //   - FETCH NEXT @limite ROWS ONLY: después del salto, devuelve las siguientes @limite filas.
                //   - Ejemplo: pagina=1, limite=10 => OFFSET 0 FETCH NEXT 10 => filas 1..10.
                //              pagina=2, limite=10 => OFFSET 10 FETCH NEXT 10 => filas 11..20.
                //   - Requiere una cláusula ORDER BY válida; sin ORDER BY la paginación no es determinista.
                //   - Si OFFSET es mayor que el total de filas, la consulta devuelve 0 filas.
                //   - Parámetros (@offset, @limite) deben ser enteros no negativos.
                //   - Para desplazamientos muy grandes (offsets altos) puede ser más eficiente
                //     usar paginación por clave (keyset pagination) en lugar de OFFSET/FETCH.
                //
                string Consulta = @"select CodCategoria, Categoria FROM Categoria WHERE Estado=1 AND Categoria 
                                    LIKE @filtro ORDER BY Categoria OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";
                using (SqlCommand cmd = new SqlCommand(Consulta, conn))
                {
                    string mensaje = "HOLA, saludameeeeeee";
                    cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@limite", limite);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new CategoriaDto
                            {
                                CodCategoria = reader["CodCategoria"].ToString(),
                                Categoria = reader["Categoria"].ToString()
                            });
                        }
                    }
                }
            }

            return new PagedResult<CategoriaDto>
            {
                Data = list,
                Total = total
            };
        }




        //TODO DE SUBCATEGORIA

        //Traemos el ultimo id de Subcategoria para generar el nuevo id
        public void UltimoIdSubategoria(VCatySub subcat, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdSubcategoria) as UltimoId from Subcategoria";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    subcat.UltimoIdSubcategoria = 0;
                }
                else
                {
                    subcat.UltimoIdSubcategoria = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        //Alta sub

        public void AltaSubcategoria(VCatySub subcat, SqlTransaction trans)
        {
            subcat.CodSubcategoria = "CBT" + (subcat.UltimoIdSubcategoria + 1);
            string consulta = "Insert into Subcategoria(IdSubcategoria, CodSubcategoria, Subcategoria, CodCategoria) " +
                "values(@IdSubcategoria, @CodSubcategoria, @Subcategoria, @CodCategoria)";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@IdSubcategoria", (subcat.UltimoIdSubcategoria + 1));
            cmd.Parameters.AddWithValue("@CodSubcategoria", subcat.CodSubcategoria);
            cmd.Parameters.AddWithValue("@Subcategoria", subcat.Subcategoria);
            cmd.Parameters.AddWithValue("@CodCategoria", subcat.CodCatRef);

            cmd.ExecuteNonQuery();

        }


        //Para movimientos

        public void IdMovimientos(VCatySub cat, SqlTransaction trans)
        {

            string consulta = "SELECT ISNULL(MAX(IdHistorico), 0) FROM HMovimiento";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {

                cat.UltimoIdMov = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void AltaHistorico(VCatySub cat, SqlTransaction trans)
        {
            int proximoId = cat.UltimoIdMov + 1;
            string codHistorico = "MOV" + proximoId;

            string consulta = "INSERT INTO HMovimiento(IdHistorico, CodHistorico, DNI, TipoMovimiento, FechaHora, DetalleMovimiento) " +
                              "VALUES(@IdHistorico, @CodHistorico, @DNI, @TipoMovimiento, GETDATE(), @DetalleMovimiento)";

            using (SqlCommand comd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                comd.Parameters.AddWithValue("@IdHistorico", proximoId);
                comd.Parameters.AddWithValue("@CodHistorico", codHistorico);


                comd.Parameters.AddWithValue("@DNI", UsuarioActivo.Datos.DNIAc);

                comd.Parameters.AddWithValue("@TipoMovimiento", cat.TipoMovimiento);
                comd.Parameters.AddWithValue("@DetalleMovimiento", cat.DetalleMovimiento);

                comd.ExecuteNonQuery();
            }
        }

        public void AltaHistoricoCompleto(VCatySub cat)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    IdMovimientos(cat, trans);
                    AltaHistorico(cat, trans);

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



        //Alta completo de subcategoria
        public void Altacompeltosub(VCatySub sub)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();
                try
                {
                    UltimoIdSubategoria(sub, trans);
                    AltaSubcategoria(sub, trans);


                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("erro: " + ex);
                    throw;
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

        //Baja subcategoria
        public static void BajaSubcategoria(string cod)
        {
            string consulta = "UPDATE Subcategoria set Estado=0 where CodSubcategoria=@cod";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cod", cod);
            try
            {
                Decla.cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja a la subcategoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }

        //SUBCATEGORIA PARA MOSTRAR EN EL DATAGRIDVIEW
        public PagedResult<SubcategoriaDto> MostrarSubcategoria(int pagina, int limite)
        {
            if (pagina < 1)
                pagina = 1;

            int offset = (pagina - 1) * limite;
            int total = 0;
            var list = new List<SubcategoriaDto>();
            using (SqlConnection conn = new SqlConnection((Decla.ConnectionString)))
            {
                conn.Open();
                string countQuery = "SELECT COUNT(*) FROM Subcategoria WHERE Estado=1";
                using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                {
                    total = (int)countCmd.ExecuteScalar();
                }
                string consulta = @"select CodSubcategoria, Subcategoria from Subcategoria where 
                                    Estado=1 ORDER BY  Subcategoria OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@limite", limite);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new SubcategoriaDto
                            {
                                CodSubcategoria = reader["CodSubcategoria"].ToString(),
                                Subcategoria = reader["Subcategoria"].ToString()
                            });
                        }
                    }
                }
            }
            return new PagedResult<SubcategoriaDto>
            {
                Data = list,
                Total = total
            };
        }

        //SUBCATEGORIA PARA FILTRAR EN EL DATAGRIDVIEW
        public PagedResult<SubcategoriaDto> MostrarSubcategoriaFiltrada(int pagina, int limite, string filtro)
        {
            if (pagina < 1)
                pagina = 1;

            int offset = (pagina - 1) * limite;
            int total = 0;
            var list = new List<SubcategoriaDto>();
            using (SqlConnection conn = new SqlConnection((Decla.ConnectionString)))
            {
                conn.Open();
                string countQuery = "SELECT COUNT(*) FROM Subcategoria WHERE Estado=1 AND Subcategoria LIKE @filtro";
                using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                {
                    countCmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                    total = (int)countCmd.ExecuteScalar();
                }
                string consulta = @"select CodSubcategoria, Subcategoria from Subcategoria where 
                                    Estado=1 AND Subcategoria LIKE @filtro ORDER BY  Subcategoria OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@offset", offset);
                    cmd.Parameters.AddWithValue("@limite", limite);
                    cmd.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new SubcategoriaDto
                            {
                                CodSubcategoria = reader["CodSubcategoria"].ToString(),
                                Subcategoria = reader["Subcategoria"].ToString()
                            });
                        }
                    }
                }
            }
            return new PagedResult<SubcategoriaDto>
            {
                Data = list,
                Total = total
            };
        }



        //Metodo que usamos para mostrar la categoria en el Cmb
        public static DataTable MostrarCategoriaBox()
        {
            string consulta = "select CodCategoria, Categoria from Categoria where Estado=1";
            SqlCommand comando = new SqlCommand(consulta, Decla.cnn);
            Decla.CategoriaBox.Clear();
            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                Decla.CategoriaBox.Load(reader);
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
            return Decla.CategoriaBox;


        }

        //PARA DESCUENTOS  
        public int Descuento()
        {
            int total = 0;


            using (SqlConnection conn = new SqlConnection(Decla.ConnectionString))
            {
                conn.Open();
                string consulta = "SELECT DescuentoSocio FROM DescuentoCliente";
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result == DBNull.Value)
                    {
                        total = 0;

                    }
                    else
                    {
                        total = Convert.ToInt32(result);
                    }
                }

                return total;
            }
        }

        public void ModificarDescuento(int nuevoDescuento)
        {
            string consulta = "UPDATE DescuentoCliente SET DescuentoSocio = @nuevoDescuento";
            using (SqlConnection conn = new SqlConnection(Decla.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@nuevoDescuento", nuevoDescuento);
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}