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

        //Treamos info de la categoria
        public static DataTable TraerCat(int PaginaActual, int RegistrosPorPagina)
        {
            if (PaginaActual < 1)
                PaginaActual = 1;

            int offset = (PaginaActual - 1) * RegistrosPorPagina;
            string consulta = "select CodCategoria, Categoria from Categoria where Estado=1 ORDER BY  Categoria OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";

            SqlConnection cn = new SqlConnection(Decla.ConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cn);

            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@limite", RegistrosPorPagina);
            Decla.CatTab.Clear();

            try
            {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.CatTab.Load(reader);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer categorias: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return Decla.CatTab;
        }

        //Obtener total categorias

        public int ObtenerTotalCategorias()
        {
            int total = 0;

            string sql = "SELECT COUNT(*) FROM Categoria WHERE Estado = 1";

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
                    MessageBox.Show("erro: "+ex);
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

        //Treamos info de la Subcategoria
        public static DataTable TraerSubcat(int PaginaActual, int RegistrosPorPagina)
        {
            if (PaginaActual < 1)
                PaginaActual = 1;

            int offset = (PaginaActual - 1) * RegistrosPorPagina;
            string consulta = "select CodSubcategoria, Subcategoria from Subcategoria where Estado=1 ORDER BY  Subcategoria OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";

            SqlConnection cn = new SqlConnection(Decla.ConnectionString);
            SqlCommand cmd = new SqlCommand(consulta, cn);

            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@limite", RegistrosPorPagina);
            Decla.SubCatTab.Clear();

            try
            {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.SubCatTab.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo traer las subcategorias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return Decla.SubCatTab;
        }

        public int ObtenerTotalSubcategorias()
        {
            int total = 0;

            string sql = "SELECT COUNT(*) FROM Subcategoria WHERE Estado = 1";

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
    }
}