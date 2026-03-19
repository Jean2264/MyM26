using MyM26.Entidades.Articulos;
using MyM26.Entidades.Empleado;
using MyM26.Entidades.Usuario;
using MyM26.Querys;
using MyM26.screens;
using MyM26.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MyM26.DAL
{
    public class ArticuloDatos
    {
        int nuevoId;
        int nuevivoIdHC;

        private string _CodArt;
        private string _nombre;
        private byte[] _imagen;
        private string _img;
        private decimal _precio;
        private int _cantidad;
        private decimal _pm;
        public string CodArt { get => _CodArt; set => _CodArt = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public byte[] Imagen { get => _imagen; set => _imagen = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public object ImagenHelper { get; private set; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public decimal Pm { get => _pm; set => _pm = value; }


        //METODOS PARA LOS COMBOBOX
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
            /*  cmb_Cat.DataSource = Decla.CategoriaBox;
              cmb_Cat.DisplayMember = "Categoria";
              cmb_Cat.ValueMember = "CodCategoria";
              cmb_Cat.SelectedIndex = -1;*/

        }

        public static DataTable MostrarCompra(int paginaActual, int registrosPorPagina)
        {
            int offset = (paginaActual - 1) * registrosPorPagina;
            string consulta = @"select h.FechaAlta, cd.Descripcion, cd.Cantidad, cd.PrecioUnitario,
                                    cd.PrecioXCantidad, h.DNI, h.Cuit from HCompra h inner join HCompraDetalle cd on h.CodHCompra = cd.CodHCompra ORDER BY FechaAlta DESC OFFSET @offset ROWS FETCH NEXT @limite ROWS ONLY";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@limite", registrosPorPagina);
            Decla.CompraTab.Clear();

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.CompraTab.Load(reader);
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
            return Decla.CompraTab;
        }


        /* public static DataTable FiltrarEmpl(string dni)
        {

            string consulta = "select  DNI, Apellido, Nombre, Telefono, Mail, Sector from Empleado WHERE (Nombre LIKE @cuit OR DNI LIKE @cuit) and Estado=1";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cuit", "%" + dni + "%");

            try
            {

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Decla.EmpleadoFil.Clear();

                da.Fill(Decla.EmpleadoFil);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al filtrar el proveedor: " + ex.Message.ToString());
            }
            return Decla.EmpleadoFil;
        }*/

        public static DataTable FiltrarCompra(string nombre)
        {
            string consulta = @"select h.FechaAlta, cd.Descripcion, cd.Cantidad, cd.PrecioUnitario,
                                    cd.PrecioXCantidad, h.DNI, h.Cuit from HCompra h inner join HCompraDetalle cd on h.CodHCompra = cd.CodHCompra  WHERE (cd.Descripcion LIKE @filtro)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@filtro", "%"+ nombre + "%");
            Decla.CompraFil.Clear();
            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.CompraFil.Load(reader);
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
            return Decla.CompraFil;
        }
        //Metodo que usamos para mostrar la subcategoria en el Cmb

        public static DataTable MostrarSubcategoriaBox(string cod)
        {
            string consulta = "select CodSubcategoria, Subcategoria from Subcategoria where Estado=1 AND CodCategoria=@cd";
            SqlCommand comando = new SqlCommand(consulta, Decla.cnn);
            comando.Parameters.AddWithValue("@cd", cod);
            Decla.SubBox.Clear();
            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                Decla.SubBox.Load(reader);
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
            return Decla.SubBox;
            /*  cmb_Cat.DataSource = Decla.CategoriaBox;
              cmb_Cat.DisplayMember = "Categoria";
              cmb_Cat.ValueMember = "CodCategoria";
              cmb_Cat.SelectedIndex = -1;*/

        }

        //Metodo que usamos para mostrar el proveedor en el Cmb
        public static DataTable MostrarProvBox()
        {
            string consulta = "select Cuit, Nombre + '-' + Empresa AS NombreCompleto from Proveedor where Estado=1";
            SqlCommand comando = new SqlCommand(consulta, Decla.cnn);
            Decla.ProvBox.Clear();
            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                Decla.ProvBox.Load(reader);
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
            return Decla.ProvBox;
            /*  cmb_Cat.DataSource = Decla.CategoriaBox;
              cmb_Cat.DisplayMember = "Categoria";
              cmb_Cat.ValueMember = "CodCategoria";
              cmb_Cat.SelectedIndex = -1;*/

        }

        //PARA ARTICULO

        //Mostramos articulos
        public void LlenarContenedor(FlowLayoutPanel Contenedor,
            Action<string> editarCallBack,
            Action<string> VerCallBack,
            Articulos arts, int paginaActual,
            int registroPorPagina)
        {
            int offset = (paginaActual - 1) * registroPorPagina;
            string consulta = @"SELECT a.CodigoArticulo, a.Nombre, a.PrecioUnitario, a.PrecioXMayor, a.Imagen, s.Cantidad FROM Articulo a 
                 INNER JOIN Stock s ON a.CodigoArticulo= s.CodigoArticulo WHERE a.Estado=1 ORDER BY a.Nombre OFFSET @offset ROWS
                    FETCH NEXT @limite ROWS ONLY";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@limite", registroPorPagina);

            try
            {
                Contenedor.Controls.Clear();

                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _CodArt = reader["CodigoArticulo"].ToString();
                    _nombre = reader["Nombre"].ToString();
                    _cantidad = Convert.ToInt32(reader["Cantidad"]);
                    _precio = Convert.ToDecimal(reader["PrecioUnitario"]);
                    _pm = Convert.ToDecimal(reader["PrecioXMayor"]);

                    if (reader["Imagen"] != DBNull.Value)
                    {
                        _imagen = (byte[])reader["Imagen"];
                    }
                    else
                    {
                        _imagen = null;
                    }

                    TargetaArticulo btn = new TargetaArticulo();

                    btn.DatoEliminado += () =>
                    {
                        arts.LlenarArt();
                    };
                 
                    btn.Nombre = _nombre;
                    btn.Cantidad = _cantidad;
                    btn.PU = _precio;
                    btn.PM = _pm;
                    btn.codArt = _CodArt;

                    btn.EditarArt += editarCallBack;
                    btn.VistaArt += VerCallBack;
                    if (_imagen != null)
                    {
                        using (var ms = new System.IO.MemoryStream(_imagen))
                        {
                            btn.Foto = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        btn.Foto = null;
                    }
                    Contenedor.Controls.Add(btn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar articulos: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }

        public void ModiArt(VArticulo art, SqlTransaction trans)
        {

            string consulta = @"UPDATE Articulo SET PrecioUnitario=@PU, PrecioXMayor=@PM, CantMinMayorista=@CM WHERE CodigoArticulo=@CD";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@CD", art.codArtRef);
            cmd.Parameters.AddWithValue("@PU", art.PrecioUnitario);
            cmd.Parameters.AddWithValue("@PM", art.PrecioXMayor);
            cmd.Parameters.AddWithValue("@CM", art.CantMinMayor);

            cmd.ExecuteNonQuery();
        }

        public void ModiStock(VArticulo art, SqlTransaction trans)
        {
            decimal ganancia = Convert.ToDecimal(art.PrecioUnitario - art.Costo);
            string consulta = @"UPDATE Stock SET Cantidad=@cant,  Ganancia=@gan WHERE CodigoArticulo=@cd";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@cd", art.codArtRef);
            cmd.Parameters.AddWithValue("@cant", art.Cantidad);
            cmd.Parameters.AddWithValue("@gan", ganancia);
            cmd.ExecuteNonQuery();
        }

        public void ModiCompleto(VArticulo art)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    ModiArt(art, trans);
                    ModiStock(art, trans);

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

        public VArticulo BajaArt(string cod)
        {
            VArticulo art = null;
            string consulta = "UPDATE Articulo SET Estado=0 WHERE CodigoArticulo=@cd";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cd", cod);

            try
            {
                Decla.cnn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja al articulo", "Error" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return art;
        }

        public VArticulo ReactivarArt(string cod)
        {
            VArticulo art = null;
            string consulta = "UPDATE Articulo SET Estado=1 WHERE CodigoArticulo=@cd";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cd", cod);

            try
            {
                Decla.cnn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reactivar al articulo", "Error" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return art;
        }

        //Id
        public void UltimoIdArt(VArticulo art, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdArticulo) as UltimoId from Articulo";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    art.UltimoIdArt = 0;
                }
                else
                    art.UltimoIdArt = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        //Alta

        public void AltaArt(VArticulo art, SqlTransaction trans)
        {
            nuevoId = art.UltimoIdArt + 1;
            art.CodArt = "ART" + nuevoId;
            string consulta = "insert into Articulo(IdArticulo, CodigoArticulo, CodigoBarra, Imagen, Nombre, " +
                "CantMinMayorista, PrecioUnitario, PrecioXMayor, CodCategoria, CodSubcategoria, Cuit) values" +
                "(@IdArticulo, @CodigoArticulo, @CodigoBarra, @Imagen, @Nombre," +
                "@CantMinMayorista, @PrecioUnitario, @PrecioXMayor, @CodCategoria, @CodSubcategoria, @Cuit)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@IdArticulo", nuevoId);
            cmd.Parameters.AddWithValue("@CodigoArticulo", art.CodArt);
            cmd.Parameters.AddWithValue("@CodigoBarra", art.CodigoBarra);
            cmd.Parameters.AddWithValue("@Imagen", art.Imagen);
            cmd.Parameters.AddWithValue("@Nombre", art.Nombre);
            cmd.Parameters.AddWithValue("@CantMinMayorista", art.CantMinMayor);
            cmd.Parameters.AddWithValue("@PrecioUnitario", art.PrecioUnitario);
            cmd.Parameters.AddWithValue("@PrecioXMayor", art.PrecioXMayor);
            cmd.Parameters.AddWithValue("@CodCategoria", art.CodCategoria);
            cmd.Parameters.AddWithValue("@CodSubcategoria", art.CodSubcategoria);
            cmd.Parameters.AddWithValue("@Cuit", art.cuitProv);
            cmd.ExecuteNonQuery();
        }

        //PARA STOCK

        //Traemos el id
        public void UltimoIdStock(VArticulo art, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdStock) AS UltimoId FROM Stock";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    art.UltimoIdStock = 0;
                }
                else
                    art.UltimoIdStock = Convert.ToInt32(cmd.ExecuteScalar());

            }
        }

        //Alta stock
        public void AltaStock(VArticulo art, SqlTransaction trans)
        {
            int nuevoidStock = art.UltimoIdStock + 1;
            string Cod = "CSK" + nuevoidStock;
            string consulta = "insert into Stock(IdStock, CodStock, Cantidad,Costo, Ganancia, CodigoArticulo)" +
                "values(@IdStock, @CodStock, @Cantidad,@Costo, @Ganancia, @CodigoArticulo)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            cmd.Parameters.AddWithValue("@IdStock", nuevoidStock);
            cmd.Parameters.AddWithValue("@CodStock", Cod);
            cmd.Parameters.AddWithValue("@Cantidad", art.Cantidad);
            cmd.Parameters.AddWithValue("@Costo", art.Costo);
            cmd.Parameters.AddWithValue("@Ganancia", art.Ganancia);
            cmd.Parameters.AddWithValue("@CodigoArticulo", art.CodArt);
            cmd.ExecuteNonQuery();

        }


        //PARA HCOMPRA

        //Traemos el id

        public void ultimoIdHC(VArticulo art, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdHcompra) AS UltimoId FROM HCompra";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            object obj = cmd.ExecuteScalar();
            if (obj == DBNull.Value)
            {
                art.UltimoIdHC = 0;
            }
            else
                art.UltimoIdHC = Convert.ToInt32(cmd.ExecuteScalar());
        }

        //Alta HCompra

        public void AltaHCompra(VArticulo art, SqlTransaction trans)
        {
            nuevivoIdHC = art.UltimoIdHC + 1;
            art.codHC = "CHC" + nuevivoIdHC;
            art.SubTotal = Convert.ToDecimal(art.Costo * art.Cantidad);
            art.Total = (art.SubTotal - art.Descuento);


            string consulta = "insert into HCompra(IdHcompra, CodHCompra, DNI, Cuit, SubTotal, Descuento, Total) values" +
                "(@IdHcompra, @CodHCompra, @DNI, @Cuit, @SubTotal, @Descuento, @Total)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@IdHcompra", nuevivoIdHC);
            cmd.Parameters.AddWithValue("CodHCompra", art.codHC);
            cmd.Parameters.AddWithValue("@DNI", UsuarioActivo.Datos.DNIAc);
            cmd.Parameters.AddWithValue("@Cuit", art.cuitProv);
            cmd.Parameters.AddWithValue("@SubTotal", art.SubTotal);
            cmd.Parameters.AddWithValue("@Descuento", art.Descuento);
            cmd.Parameters.AddWithValue("@Total", art.Total);
            cmd.ExecuteNonQuery();
        }



        //PARA HCOMPRADETALLE

        //Traemos el id

        public void ultimoIdHCD(VArticulo art, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdHCompraDetalle) AS UltimoId FROM HCompraDetalle";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            object obj = cmd.ExecuteScalar();
            if (obj == DBNull.Value)
            {
                art.UltimoIdHCD = 0;
            }
            else
                art.UltimoIdHCD = Convert.ToInt32(cmd.ExecuteScalar());
        }

        //Alta hcd

        public void AltaHCD(VArticulo art, SqlTransaction trans)
        {
            art.NuevoIdHCD = art.UltimoIdHCD + 1;
            art.codHCD = "CHD" + art.NuevoIdHCD;
            art.PrecioXCantidad = (art.Costo * art.Cantidad);
            string consulta = "insert into HCompraDetalle(IdHCompraDetalle, CodHCDetalle, CodHCompra, CodigoArticulo, Descripcion, PrecioUnitario, Cantidad, PrecioXCantidad) " +
                "values(@IdHCompraDetalle, @CodHCDetalle, @CodHCompra, @CodigoArticulo, @Descripcion, @PrecioUnitario, @Cantidad, @PrecioXCantidad)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            cmd.Parameters.AddWithValue("@IdHCompraDetalle", art.NuevoIdHCD);
            cmd.Parameters.AddWithValue("@CodHCDetalle", art.codHCD);
            cmd.Parameters.AddWithValue("@CodHCompra", art.codHC);
            cmd.Parameters.AddWithValue("@CodigoArticulo", art.CodArt);
            cmd.Parameters.AddWithValue("@Descripcion", art.Nombre);
            cmd.Parameters.AddWithValue("@PrecioUnitario", art.Costo);
            cmd.Parameters.AddWithValue("@Cantidad", art.Cantidad);
            cmd.Parameters.AddWithValue("@PrecioXCantidad", art.PrecioXCantidad);
            cmd.ExecuteNonQuery();
        }

        //AltaCompleto 

        public void AltaCompleto(VArticulo art)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();
                try
                {
                    UltimoIdArt(art, trans);
                    AltaArt(art, trans);
                    UltimoIdStock(art, trans);
                    AltaStock(art, trans);
                    ultimoIdHC(art, trans);
                    AltaHCompra(art, trans);
                    ultimoIdHCD(art, trans);
                    AltaHCD(art, trans);

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error: " + ex);
                }
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }

        public int ObtenerTotalArt()
        {
            int total = 0;


            string sql = "SELECT COUNT(*) FROM Articulo WHERE Estado = 1";

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

        public VArticulo TomarInfo(string cod)
        {
            VArticulo art = null;


            string Consulta = @"SELECT a.CodigoArticulo, 
                          a.Nombre,
                          a.CodigoBarra,
                          a.Imagen,
                          c.Categoria,
                          sb.Subcategoria,
                          (p.Nombre + ' - ' + p.Empresa) AS ProveedorInfo,
                          a.PrecioUnitario,
                          s.Cantidad,
                          a.CantMinMayorista,
                          a.PrecioXMayor,
                          s.Costo,
                          hc.Descuento 
                     FROM Articulo a 
                      INNER JOIN Stock s ON a.CodigoArticulo = s.CodigoArticulo        
                      INNER JOIN Categoria c ON a.CodCategoria = c.CodCategoria    
                      INNER JOIN Subcategoria sb ON a.CodSubcategoria = sb.CodSubcategoria 
                      INNER JOIN Proveedor p ON a.Cuit = p.Cuit     
                      INNER JOIN HCompra hc ON p.Cuit = hc.Cuit 
                     WHERE a.CodigoArticulo = @cod";
            SqlCommand cmd = new SqlCommand(Consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cod", cod);

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    art = new VArticulo();
                    art.CodArt = reader["CodigoArticulo"].ToString();
                    art.Nombre = reader["Nombre"].ToString();
                    art.CodigoBarra = reader["CodigoBarra"].ToString();
                    if (reader["Imagen"] != DBNull.Value)
                    {
                        art.Imagen = (byte[])reader["Imagen"];
                    }
                    else
                    {
                        art.Imagen = null;
                    }

                    art.Categoria = reader["Categoria"].ToString();
                    art.Subcategoria = reader["Subcategoria"].ToString();
                    art.Prov = reader["ProveedorInfo"].ToString();
                    art.PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]);
                    art.Cantidad = Convert.ToInt32(reader["Cantidad"]);
                    art.CantMinMayor = Convert.ToInt32(reader["CantMinMayorista"]);
                    art.PrecioXMayor = Convert.ToDecimal(reader["PrecioXMayor"]);
                    art.Costo = Convert.ToDecimal(reader["Costo"]);
                    art.Descuento = Convert.ToDecimal(reader["Descuento"]);
                }
                ;

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

            return art;
        }

        public static DataTable ARTBajas()
        {
            string consulta = @"SELECT TOP 50 CodigoArticulo, Nombre, PrecioUnitario FROM Articulo WHERE Estado=0 ORDER BY IdArticulo DESC";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            Decla.bajaArt.Clear();

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.bajaArt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer articulos dadas de baja. " + ex);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return Decla.bajaArt;
        }



        //PARA MOVIMIENTOS /////////////////////////////////////////////

        //Para movimientos

        public void IdMovimientos(VArticulo art, SqlTransaction trans)
        {

            string consulta = "SELECT ISNULL(MAX(IdHistorico), 0) FROM HMovimiento";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                // Ahora el resultado siempre será un número (0 o superior)
                art.UltimoIdMov = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void AltaHistorico(VArticulo art, SqlTransaction trans)
        {
            int proximoId = art.UltimoIdMov + 1;
            string codHistorico = "MOV" + proximoId;

            string consulta = "INSERT INTO HMovimiento(IdHistorico, CodHistorico, DNI, TipoMovimiento, FechaHora, DetalleMovimiento) " +
                              "VALUES(@IdHistorico, @CodHistorico, @DNI, @TipoMovimiento, GETDATE(), @DetalleMovimiento)";

            using (SqlCommand comd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                comd.Parameters.AddWithValue("@IdHistorico", proximoId);
                comd.Parameters.AddWithValue("@CodHistorico", codHistorico);


                comd.Parameters.AddWithValue("@DNI", UsuarioActivo.Datos.DNIAc);

                comd.Parameters.AddWithValue("@TipoMovimiento", art.TipoMovimiento);
                comd.Parameters.AddWithValue("@DetalleMovimiento", art.DetalleMovimiento);

                comd.ExecuteNonQuery();
            }
        }

        public void AltaHistoricoCompleto(VArticulo art)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    IdMovimientos(art, trans);
                    AltaHistorico(art, trans);

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


        ///////////////////////PARA FILTRAR ARTICULO
        ///
        public void FiltrarArt(FlowLayoutPanel Contenedor, string cod)
        {
            string consulta = @"SELECT a.CodigoArticulo, a.Nombre, a.PrecioUnitario, a.PrecioXMayor, a.Imagen, s.Cantidad FROM Articulo a 
                 INNER JOIN Stock s ON a.CodigoArticulo= s.CodigoArticulo WHERE (a.Nombre LIKE @filtro OR a.CodigoBarra LIKE @filtro) AND  a.Estado=1 ";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@filtro", "%" + cod + "%");
            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _CodArt = reader["CodigoArticulo"].ToString();
                    _nombre = reader["Nombre"].ToString();
                    _cantidad = Convert.ToInt32(reader["Cantidad"]);
                    _precio = Convert.ToDecimal(reader["PrecioUnitario"]);
                    _pm = Convert.ToDecimal(reader["PrecioXMayor"]);

                    if (reader["Imagen"] != DBNull.Value)
                    {
                        _imagen = (byte[])reader["Imagen"];
                    }
                    else
                    {
                        _imagen = null;
                    }

                    TargetaArticulo btn = new TargetaArticulo();
                    btn.Nombre = _nombre;
                    btn.Cantidad = _cantidad;
                    btn.PU = _precio;
                    btn.PM = _pm;
                    btn.codArt = _CodArt;
                    if (_imagen != null)
                    {
                        using (var ms = new System.IO.MemoryStream(_imagen))
                        {
                            btn.Foto = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        btn.Foto = null;
                    }
                    Contenedor.Controls.Add(btn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar articulos: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }

        public VArticulo traerParaCompra( string cb)
        {
            VArticulo art = null;

           
            string consulta = @"
                                SELECT 
    a.CodigoArticulo,
    a.Nombre AS NombreArticulo,
    a.CodigoBarra,
    (p.Nombre + ' - ' + p.Empresa) AS ProveedorCompleto,
    s.Costo,
p.Cuit,
    s.Cantidad,
    hc.Descuento
FROM Articulo a
INNER JOIN Stock s ON a.CodigoArticulo = s.CodigoArticulo
INNER JOIN Proveedor p ON a.Cuit = p.Cuit
LEFT JOIN HCompra hc ON p.Cuit = hc.Cuit
WHERE a.CodigoBarra = @codBarra ";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@codBarra", cb);

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    art = new VArticulo();
                    art.CodArt = reader["CodigoArticulo"].ToString();
                    art.Nombre = reader["NombreArticulo"].ToString();
                    art.Prov = reader["ProveedorCompleto"].ToString();
                    art.cuitProv = reader["Cuit"].ToString();
                    art.Costo = Convert.ToDecimal(reader["Costo"]);
                    art.Cantidad = Convert.ToInt32(reader["Cantidad"]);

                    // Para el descuento, como puede ser NULL por el LEFT JOIN:
                    art.Descuento = reader["Descuento"] != DBNull.Value ? Convert.ToDecimal(reader["Descuento"]) : 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }

            return art;
        }

        public VArticulo mostrarStockEnCampos(string cod)
        {
            VArticulo art = null;
            string consulta = "  SELECT Cantidad, Costo FROM Stock Where CodigoArticulo=@cod";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cod", cod);

            try
            {
                Decla.cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                if(r.Read())
                {
                    art= new VArticulo
                    {
                       Cantidad= Convert.ToInt32(r["Cantidad"]),
                       Costo= Convert.ToDecimal(r["Costo"])
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }

            return art;
        }

        public VArticulo mostrarHCCampos(string cuit)
        {
            VArticulo art = null;
            string consulta = "SELECT Descuento FROM HCompra WHERE Cuit=@cuit";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@cuit", cuit);

            try
            {
                Decla.cnn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    art = new VArticulo
                    {
                        Descuento= Convert.ToDecimal(r["Descuento"])
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }

            return art;


        }
        //////////////////PARA LA ACTUALIZACION DE HCOMPRA
        ///
        


        //PARA HCOMPRADETALLE


       

        public void ModArtCompra(VArticulo art, SqlTransaction trans)
        {
            string consulta = "UPDATE Articulo SET Cuit=@cuit WHERE CodigoArticulo=@cod";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@cuit", art.cuitProv);
            cmd.Parameters.AddWithValue("@cod", art.CodArt);
            cmd.ExecuteNonQuery();
        }

        public void ModStockCompra(VArticulo art, SqlTransaction trans)
        {
            string consulta = "UPDATE Stock SET Costo=@costo, Cantidad=@cantidad WHERE CodigoArticulo=@cod" ;
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@cod", art.CodArt);
            cmd.Parameters.AddWithValue("@costo", art.Costo);
            cmd.Parameters.AddWithValue("@cantidad", art.Cantidad);
            cmd.ExecuteNonQuery();
        }
        //Traemos el id

        public void ultimoIdHCd(VArticulo art, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdHcompra) AS UltimoId FROM HCompra";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            object obj = cmd.ExecuteScalar();
            if (obj == DBNull.Value)
            {
                art.UltimoIdHC = 0;
            }
            else
                art.UltimoIdHC = Convert.ToInt32(cmd.ExecuteScalar());
        }

        //Alta HCompra

        public void AltaHComprad(VArticulo art, SqlTransaction trans)
        {
            nuevivoIdHC = art.UltimoIdHC + 1;
            art.codHC = "CHC" + nuevivoIdHC;
            art.SubTotal = Convert.ToDecimal(art.Costo * art.Cantidad);
            art.Total = (art.SubTotal - art.Descuento);


            string consulta = "insert into HCompra(IdHcompra, CodHCompra, DNI, Cuit, SubTotal, Descuento, Total) values" +
                "(@IdHcompra, @CodHCompra, @DNI, @Cuit, @SubTotal, @Descuento, @Total)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@IdHcompra", nuevivoIdHC);
            cmd.Parameters.AddWithValue("CodHCompra", art.codHC);
            cmd.Parameters.AddWithValue("@DNI", UsuarioActivo.Datos.DNIAc);
            cmd.Parameters.AddWithValue("@Cuit", art.cuitProv);
            cmd.Parameters.AddWithValue("@SubTotal", art.SubTotal);
            cmd.Parameters.AddWithValue("@Descuento", art.Descuento);
            cmd.Parameters.AddWithValue("@Total", art.Total);
            cmd.ExecuteNonQuery();
        }


        //Traemos el id

        public void ultimoIdHCDd(VArticulo art, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdHCompraDetalle) AS UltimoId FROM HCompraDetalle";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            object obj = cmd.ExecuteScalar();
            if (obj == DBNull.Value)
            {
                art.UltimoIdHCD = 0;
            }
            else
                art.UltimoIdHCD = Convert.ToInt32(cmd.ExecuteScalar());
        }

        //Alta hcd

        public void AltaHCDd(VArticulo art, SqlTransaction trans)
        {
            art.NuevoIdHCD = art.UltimoIdHCD + 1;
            art.codHCD = "CHD" + art.NuevoIdHCD;
            art.PrecioXCantidad = (art.Costo * art.Cantidad);
            string consulta = "insert into HCompraDetalle(IdHCompraDetalle, CodHCDetalle, CodHCompra, CodigoArticulo, Descripcion, PrecioUnitario, Cantidad, PrecioXCantidad) " +
                "values(@IdHCompraDetalle, @CodHCDetalle, @CodHCompra, @CodigoArticulo, @Descripcion, @PrecioUnitario, @Cantidad, @PrecioXCantidad)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            cmd.Parameters.AddWithValue("@IdHCompraDetalle", art.NuevoIdHCD);
            cmd.Parameters.AddWithValue("@CodHCDetalle", art.codHCD);
            cmd.Parameters.AddWithValue("@CodHCompra", art.codHC);
            cmd.Parameters.AddWithValue("@CodigoArticulo", art.CodArt);
            cmd.Parameters.AddWithValue("@Descripcion", art.Nombre);
            cmd.Parameters.AddWithValue("@PrecioUnitario", art.Costo);
            cmd.Parameters.AddWithValue("@Cantidad", art.Cantidad);
            cmd.Parameters.AddWithValue("@PrecioXCantidad", art.PrecioXCantidad);
            cmd.ExecuteNonQuery();
        }

        public void NodiArtCompletoH(VArticulo art)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    ModArtCompra(art, trans);
                    ModStockCompra(art, trans);
                    ultimoIdHCd(art, trans);
                    AltaHComprad(art, trans);
                    ultimoIdHCDd(art, trans);
                    AltaHCDd(art, trans);

                    trans.Commit();
                    MessageBox.Show("Se completo la compra de forma correcta.");
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

        public int ObtenerTotalCompras()
        {
            int total = 0;

            string sql = "SELECT COUNT(*) FROM HCompra";

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

