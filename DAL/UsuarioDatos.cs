using MyM26.Querys;
using MyM26.screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MyM26.Entidades.Usuario;
using System.Data.SqlClient;
using System.Dynamic;
using System.Drawing;
using System.IO;

using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using System.Text;

using Microsoft.VisualBasic.ApplicationServices;

namespace MyM26.DAL
{
    public class UsuarioDatos
    {
        private string _dni;
        private string _nombre;
        private string _tipo;
        private byte[] _foto;


        public string Dni { get => _dni; set => _dni = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public byte[] Foto { get => _foto; set => _foto = value; }
        public object ImagenHelper { get; private set; }

     

        public void LlenarContenedor(
FlowLayoutPanel Contenedor,
Action<string> editarCallback,
Users usu,
int paginaActual,
int registrosPorPagina)
        {
            int offset = (paginaActual - 1) * registrosPorPagina;

            string sql = @"SELECT s.DNI, s.Usuario, t.Tipo, s.perfil
                   FROM Usuario s
                   INNER JOIN TipoUsuario t 
                   ON s.CodtipoUsuario = t.CodTipoUsuario
                   WHERE s.Estado = 1
                   ORDER BY s.Usuario
                   OFFSET @offset ROWS
                   FETCH NEXT @limite ROWS ONLY";

            SqlCommand cmd = new SqlCommand(sql, Decla.cnn);
            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@limite", registrosPorPagina);

            try
            {
                Contenedor.Controls.Clear();

                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _dni = reader["DNI"].ToString();
                    _nombre = reader["Usuario"].ToString();
                    _tipo = reader["Tipo"].ToString();

                    if (reader["perfil"] != DBNull.Value)
                        _foto = (byte[])reader["perfil"];
                    else
                        _foto = null;

                    TargetaUsuario btn = new TargetaUsuario();

                    btn.DatoEliminado += () =>
                    {
                        usu.llenarUser();
                    };

                    btn.Dni = _dni;
                    btn.Nombre = _nombre;
                    btn.Tipo = _tipo;

                    btn.EditarUsuario += editarCallback;

                    if (_foto != null)
                    {
                        using (var ms = new System.IO.MemoryStream(_foto))
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
                MessageBox.Show("Error al llenar usuarios: " + ex.Message);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }

        public static DataTable bajaUsuario()
        {
            string sqltranq = "Select TOP 50 s.DNI, s.Usuario, t.Tipo from Usuario s inner join TipoUsuario t on s.CodtipoUsuario= t.CodTipoUsuario where s.Estado=0 ORDER BY IdUsuario DESC";
            SqlConnection cn = new SqlConnection(Decla.ConnectionString);
            SqlCommand cmd = new SqlCommand(sqltranq, cn);
            Decla.bajaUsu.Clear();
            try
            {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Decla.bajaUsu.Load(reader);
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

            return Decla.bajaUsu;

        }
        public static DataTable mostrarUser()
        {
            string consulta = "Select DNI, Usuario, Contrasenia, Telefono, Mail from Usuario where Estado=1";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            Variables.User.Clear();
            try
            {
                Decla.cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Variables.User = new DataTable();
                da.Fill(Variables.User);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al mostrar los usuarios: " + ex.ToString());
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return Variables.User;
        }

        //Alat de usuario
        public void UltimoIdUser(VUser usuario, SqlTransaction trans)
        {
            string consulta = "SELECT MAX(IdUsuario) as ultimoId FROM Usuario";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    usuario.UltimoId = 0;
                }
                else
                    usuario.UltimoId = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public void AltaUsuario(VUser usuario, SqlTransaction trans)
        {
            string consulta = "insert into Usuario(IdUsuario, DNI ,Usuario, Contrasenia, Telefono, Mail, FechaAlta, Perfil, CodTipoUsuario) " +
                            "values(@IdUsuario,@DNI ,@Usuario, @Contrasenia, @Telefono, @Mail, GETDATE(), @Perfil, @CodTipoUsuario)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@IdUsuario", usuario.UltimoId + 1);
            cmd.Parameters.AddWithValue("@DNI", usuario.Dni);
            cmd.Parameters.AddWithValue("@Usuario", usuario.Nombre);
            cmd.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
            cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            cmd.Parameters.AddWithValue("@Mail", usuario.Mail);
            if (usuario.Foto != null)
            {
                cmd.Parameters.Add("@Perfil", SqlDbType.VarBinary).Value = usuario.Foto;
            }
            else
            {
                cmd.Parameters.Add("@Perfil", SqlDbType.VarBinary).Value = DBNull.Value;
            }
            cmd.Parameters.AddWithValue("@CodTipoUsuario", usuario.CodTipoUsuario);

            cmd.ExecuteNonQuery();
        }
        public void UltimoIdTipoUser(VUser usuario, SqlTransaction trans)
        {
            string consulta = "Select MAX(IdTipoUsuario) as ultimoId from TipoUsuario";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    usuario.ultimoIdTipo = 0;
                }
                else
                    usuario.ultimoIdTipo = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public void AltaTipoUsuario(VUser usuario, SqlTransaction trans)
        {
            usuario.NuevoIdTipo = usuario.ultimoIdTipo + 1;
            usuario.CodTipoUsuario = "CTU" + usuario.NuevoIdTipo;

            string consulta = "insert into  TipoUsuario(IdTipoUsuario, CodTipoUsuario, Tipo, Cajas, Compras, Productos, Ventas, Usuarios, Clientes, Empleados, Proveedores, EstadoContable) " +
                "Values(@IdTipoUsuario, @CodTipoUsuario, @Tipo, @Cajas, @Compras, @Productos, @Ventas, @Usuarios, @Clientes, @Empleados, @Proveedores, @EstadoContable)";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            cmd.Parameters.AddWithValue("@IdTipoUsuario", usuario.NuevoIdTipo);
            cmd.Parameters.AddWithValue("@CodTipoUsuario", usuario.CodTipoUsuario);
            cmd.Parameters.AddWithValue("@Tipo", usuario.Tipo);
            cmd.Parameters.AddWithValue("@Cajas", usuario.Cajas);
            cmd.Parameters.AddWithValue("@Compras", usuario.Compras);
            cmd.Parameters.AddWithValue("@Productos", usuario.Articulos);
            cmd.Parameters.AddWithValue("@Ventas", usuario.Ventas);
            cmd.Parameters.AddWithValue("@Usuarios", usuario.Usuarios);
            cmd.Parameters.AddWithValue("@Clientes", usuario.Clientes);
            cmd.Parameters.AddWithValue("@Empleados", usuario.Empleados);
            cmd.Parameters.AddWithValue("@Proveedores", usuario.Proveedores);
            cmd.Parameters.AddWithValue("@EstadoContable", usuario.Contabilidad);
            cmd.ExecuteNonQuery();

        }

        public void AltacompletoUsuario(VUser usuario)
        {

            try
            {
                Decla.cnn.Open(); SqlTransaction trans = Decla.cnn.BeginTransaction();
                try
                {
                    UltimoIdTipoUser(usuario, trans);
                    UltimoIdUser(usuario, trans);
                    AltaTipoUsuario(usuario, trans);
                    AltaUsuario(usuario, trans);
                    trans.Commit();
                    MessageBox.Show("Usuario dado de alta con exito");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error al dar de alta el usuario: " + ex.Message.ToString());
                }
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open) Decla.cnn.Close();
            }
        }

        public VUser Tomarinfo(string dni)
        {
            VUser usuario = null;
            string consulta = "SELECT s.DNI, s.Usuario, s.Contrasenia, s.Telefono, s.Mail, s.FechaAlta, s.Perfil, t.Tipo, t.Cajas, t.Compras, t.Productos, " +
                                     "t.Ventas, t.Usuarios, t.Clientes, t.Empleados, t.Proveedores, t.EstadoContable FROM Usuario s inner join TipoUsuario t on s.CodTipoUsuario= t.CodTipoUsuario WHERE s.DNI=@dni";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn);
            cmd.Parameters.AddWithValue("@dni", dni);

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new VUser();
                    usuario.Dni = reader["DNI"].ToString();
                    usuario.Nombre = reader["Usuario"].ToString();
                    usuario.Contrasenia = reader["Contrasenia"].ToString();
                    usuario.Telefono = reader["Telefono"].ToString();
                    usuario.Mail = reader["Mail"].ToString();
                    usuario.FechaAlta = reader["FechaAlta"].ToString();
                    usuario.NombreOriginal = reader["Usuario"].ToString();
                    usuario.ContraseniaOriginal = reader["Contrasenia"].ToString();

                    if (reader["Perfil"] != DBNull.Value)
                    {
                        usuario.Foto = (byte[])reader["Perfil"];
                    }
                    else
                    {
                        usuario.Foto = null;
                    }

                    usuario.Tipo = reader["Tipo"].ToString();
                    usuario.Cajas = Convert.ToBoolean(reader["Cajas"]);
                    usuario.Compras = Convert.ToBoolean(reader["Compras"]);
                    usuario.Articulos = Convert.ToBoolean(reader["Productos"]);
                    usuario.Ventas = Convert.ToBoolean(reader["Ventas"]);
                    usuario.Usuarios = Convert.ToBoolean(reader["Usuarios"]);
                    usuario.Clientes = Convert.ToBoolean(reader["Clientes"]);
                    usuario.Proveedores = Convert.ToBoolean(reader["Proveedores"]);
                    usuario.Contabilidad = Convert.ToBoolean(reader["EstadoContable"]);
                    usuario.Empleados = Convert.ToBoolean(reader["Empleados"]);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return usuario;
        }

        public void ModificarUsuario(VUser usuario, SqlTransaction trans)
        {
            string consulta = "UPDATE Usuario SET Usuario=@Usuario, Contrasenia=@Contrasenia, Telefono=@Telefono, Mail=@Mail, Perfil=@Perfil WHERE DNI=@DNI";

            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);

            cmd.Parameters.AddWithValue("@DNI", usuario.Dni);
            cmd.Parameters.AddWithValue("@Usuario", usuario.Nombre);
            cmd.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
            cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
            cmd.Parameters.AddWithValue("@Mail", usuario.Mail);
            if (usuario.Foto != null)
            {
                cmd.Parameters.Add("@Perfil", SqlDbType.VarBinary).Value = usuario.Foto;
            }
            else
            {
                cmd.Parameters.Add("@Perfil", SqlDbType.VarBinary).Value = DBNull.Value;
            }
            cmd.ExecuteNonQuery();
        }

        public string ObtenerCodTipoUsuario(string dni, SqlTransaction trans)
        {
            string cod = null;
            string consulta = "select CodTipoUsuario from Usuario where DNI=@dni";
            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                cmd.Parameters.AddWithValue("@dni", dni);


                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    cod = result.ToString();
                }


            }
            return cod;
        }
        public void modificarTipoUser(VUser usuario, SqlTransaction trans)
        {
            string cod = ObtenerCodTipoUsuario(usuario.Dni, trans);

            string consulta = "UPDATE TipoUsuario set Tipo= @Tipo, " +
                                                            "Cajas=@Cajas, " +
                                                            "Compras=@Compras, " +
                                                            "Productos=@Productos, " +
                                                            "Ventas=@Ventas, " +
                                                            "Usuarios=@Usuarios, " +
                                                            "Clientes=@Clientes, " +
                                                            "Empleados= @Empleados," +
                                                            "Proveedores=@Proveedores, " +
                                                            "EStadoContable=@EstadoContable " +
                                                            "WHERE CodTipoUsuario= @Cod";
            SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans);
            cmd.Parameters.AddWithValue("@Cod", cod);
            cmd.Parameters.AddWithValue("@Tipo", usuario.Tipo);
            cmd.Parameters.AddWithValue("@Cajas", usuario.Cajas);
            cmd.Parameters.AddWithValue("@Compras", usuario.Compras);
            cmd.Parameters.AddWithValue("@Productos", usuario.Articulos);
            cmd.Parameters.AddWithValue("@Ventas", usuario.Ventas);
            cmd.Parameters.AddWithValue("@Usuarios", usuario.Usuarios);
            cmd.Parameters.AddWithValue("@Clientes", usuario.Clientes);
            cmd.Parameters.AddWithValue("@Proveedores", usuario.Proveedores);
            cmd.Parameters.AddWithValue("@EstadoContable", usuario.Contabilidad);
            cmd.Parameters.AddWithValue("@Empleados", usuario.Empleados);
            cmd.ExecuteNonQuery();
        }
        public void ModiCompleto(VUser usuario)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    ObtenerCodTipoUsuario(usuario.Dni, trans);
                    modificarTipoUser(usuario, trans);
                    ModificarUsuario(usuario, trans);


                    trans.Commit();
                    MessageBox.Show("Usuario modificado con exito");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error al modificar el usuario: " + ex.Message.ToString());
                }
            }

            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }
        public VUser ElimianrUser(string dni)
        {
            VUser usuario = null;
            string consulta = "Update Usuario set Estado=0 WHERE DNI=@DNI";
            SqlCommand comando = new SqlCommand(consulta, Decla.cnn);
            comando.Parameters.AddWithValue("@DNI", dni);
            try
            {
                Decla.cnn.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message.ToString());
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return usuario;
        }


        public void FiltrarUser(FlowLayoutPanel Contenedor, string dni)
        {//      string consulta = "select top 300 Cuit, Nombre, Entidad, Cuit, Telefono, Mail from Cliente where (Nombre LIKE @filtro OR Cuit LIKE @filtro) and Estado= 1";
            string sqltranq = "Select s.DNI, s.Usuario, t.Tipo, s.perfil from Usuario s inner join TipoUsuario t on s.CodtipoUsuario= t.CodTipoUsuario WHERE (s.Usuario LIKE @filtro OR s.DNI LIKE @filtro) AND  s.Estado=1";
            SqlCommand cmd = new SqlCommand(sqltranq, Decla.cnn);
            cmd.Parameters.AddWithValue("@filtro", "%" + dni + "%");

            try
            {
                Decla.cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _dni = reader["DNI"].ToString();
                    _nombre = reader["Usuario"].ToString();
                    _tipo = reader["Tipo"].ToString();
                    if (reader["perfil"] != DBNull.Value)
                    {
                        _foto = (byte[])reader["perfil"];
                    }
                    else
                    {
                        _foto = null;
                    }

                    TargetaUsuario btn = new TargetaUsuario();
                    btn.Dni = _dni;
                    btn.Nombre = _nombre;
                    btn.Tipo = _tipo;


                    if (_foto != null)
                    {
                        using (var ms = new System.IO.MemoryStream(_foto))
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
                System.Windows.Forms.MessageBox.Show("Error al llenar el contenedor de usuarios: " + ex.Message.ToString());
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
        }

        public (bool dniDuplicado, bool usuarioDuplicado) VerficacionDuplicados(string dni, string usuario)
        {
            bool dniDup = false;
            bool usuarioDup = false;

            string consulta = @"
                    SELECT
                        CASE WHEN EXISTS (SELECT 1 FROM Usuario Where DNI=@dni and Estado=1) Then 1 else
                         0 END AS DNI_Duplicado,
                        Case WHEN EXISTS (SELECT 1 FROM Usuario Where Usuario= @usuario AND Estado=1) then 1 ELse 0 END as Usuario_Duplicado;";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn))
            {
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                try
                {
                    Decla.cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dniDup = Convert.ToInt32(reader["DNI_Duplicado"]) == 1;
                        usuarioDup = Convert.ToInt32(reader["Usuario_Duplicado"]) == 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar duplicados:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Decla.cnn.State == ConnectionState.Open)
                        Decla.cnn.Close();
                }

            }

            return (dniDup, usuarioDup);
        }


        public void ReactivarUsuario(string dni)
        {
            string consulta = "UPDATE Usuario SET Estado = 1 WHERE DNI = @DNI";

            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@DNI", dni);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int ObtenerTotalUsuarios()
        {
            int total = 0;

            string sql = "SELECT COUNT(*) FROM Usuario WHERE Estado = 1";

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

        //Verificacion de existencia para modificacion

        public bool ExisteUsuarioEnModificacion(string usuario, string dni)
        {
            using (SqlConnection cn = new SqlConnection(Decla.ConnectionString))
            {
                string sql = @"SELECT COUNT(*) 
                       FROM Usuario 
                       WHERE Usuario = @usuario 
                       AND DNI <> @dni 
                       AND Estado = 1";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@dni", dni);

                    cn.Open();
                    int existe = (int)cmd.ExecuteScalar();

                    return existe > 0;
                }
            }
        }

        //Verificacion para logeo de usuario en la app

        public VUser logeo(string us, string contrasenia)
        {
            VUser user = null;

            string consulta = "SELECT s.DNI, s.Perfil, s.Usuario, t.Tipo, t.Cajas, t.Compras, " +
                    "t.Productos, t.Ventas, t.Empleados, t.Usuarios, t.Clientes, t.Proveedores, " +
                    "t.EstadoContable " +
                    "FROM Usuario s " +
                    "INNER JOIN TipoUsuario t ON s.CodTipoUsuario = t.CodTipoUsuario " +
                    "WHERE (s.Usuario = @user OR s.DNI = @dni) " +
                    "AND s.Contrasenia = @pass " +
                    "AND s.Estado = 1";
            try
            {
                using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn))
                {
                    cmd.Parameters.AddWithValue("@user", us);
                    cmd.Parameters.AddWithValue("@dni", us);
                    cmd.Parameters.AddWithValue("@pass", contrasenia);

                    Decla.cnn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        user = new VUser();
                        user.DNIAc = reader["DNI"].ToString();
                        user.NombreAc = reader["Usuario"].ToString();
                        user.TipoAc = reader["Tipo"].ToString();
                        user.CajasAc = Convert.ToBoolean(reader["Cajas"]);
                        user.ComprasAc = Convert.ToBoolean(reader["Compras"]);
                        user.ProductosAC = Convert.ToBoolean(reader["Productos"]);
                        user.VentasAc = Convert.ToBoolean(reader["Ventas"]);
                        user.UsuariosAc = Convert.ToBoolean(reader["Usuarios"]);
                        user.ClientesAc = Convert.ToBoolean(reader["Clientes"]);
                        user.ProveedoresAc = Convert.ToBoolean(reader["Proveedores"]);
                        user.ContableAc = Convert.ToBoolean(reader["EstadoContable"]);
                        user.EmpleadosAc = Convert.ToBoolean(reader["Empleados"]);

                        if (reader["Perfil"] != DBNull.Value)
                        {
                            user.FotoAc = (byte[])reader["Perfil"];
                        }
                        else
                        {
                            user.FotoAc = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Decla.cnn.State == ConnectionState.Open)
                    Decla.cnn.Close();
            }
            return user;
        }

        //Para movimientos

        public void IdMovimientos(VUser usuario, SqlTransaction trans)
        {
           
            string consulta = "SELECT ISNULL(MAX(IdHistorico), 0) FROM HMovimiento";

            using (SqlCommand cmd = new SqlCommand(consulta, Decla.cnn, trans))
            {
               
                usuario.UltimiIdMovimiento = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void AltaHistorico(VUser usuario, SqlTransaction trans)
        {
            int proximoId = usuario.UltimiIdMovimiento + 1;
            string codHistorico = "MOV" + proximoId;

            string consulta = "INSERT INTO HMovimiento(IdHistorico, CodHistorico, DNI, TipoMovimiento, FechaHora, DetalleMovimiento) " +
                              "VALUES(@IdHistorico, @CodHistorico, @DNI, @TipoMovimiento, GETDATE(), @DetalleMovimiento)";

            using (SqlCommand comd = new SqlCommand(consulta, Decla.cnn, trans))
            {
                comd.Parameters.AddWithValue("@IdHistorico", proximoId);
                comd.Parameters.AddWithValue("@CodHistorico", codHistorico);

                
                comd.Parameters.AddWithValue("@DNI", UsuarioActivo.Datos.DNIAc);

                comd.Parameters.AddWithValue("@TipoMovimiento", usuario.TipoMovimiento);
                comd.Parameters.AddWithValue("@DetalleMovimiento", usuario.DetalleMovimiento);

                comd.ExecuteNonQuery();
            }
        }

        public void AltaHistoricoCompleto(VUser usuario)
        {
            try
            {
                Decla.cnn.Open();
                SqlTransaction trans = Decla.cnn.BeginTransaction();

                try
                {
                    IdMovimientos(usuario, trans);
                    AltaHistorico(usuario, trans);

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
                
    } }
