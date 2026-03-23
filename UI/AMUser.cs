using Microsoft.VisualBasic.ApplicationServices;
using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Usuario;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyM26.screens
{
    public partial class AMUser : Form
    {
        public string Modo;
        public string DNI;
        public Users usu;
        public string UsuOriginal;
        public string ContraOriginal;



        public AMUser(Users usu)
        {
            InitializeComponent();
            Conexion.Conectar();
            this.usu = usu;
        }

        public AMUser()
        {
            InitializeComponent();
            Conexion.Conectar();

        }
        private void AMUser_Load(object sender, EventArgs e)
        {
            cmb_tipo.Items.Add("Administrador");
            cmb_tipo.Items.Add("Cajero");
            cmb_tipo.Items.Add("RRHH");
            if (Modo == "Alta")
            {
                label_title.Text = "Alta de usuario";
                btn_AM.Text = "Añadir usuario";
                btn_AM.BackgroundImage = Properties.Resources.verde;
            }
            else if (Modo == "Modificar")
            {
                label_title.Text = "Modificación de usuario";
                btn_AM.Text = "Modificar usuario";
                txt_dni.ReadOnly = true;
                txt_dni.BackColor = Color.White;
                buscarUsuario();
                btn_AM.BackgroundImage = Properties.Resources.naranja;
            }
            else
            {
                label_title.Text = "Consulta de usuario";
                btn_AM.Visible = false;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ((TextBox)ctrl).ReadOnly = true;
                    }
                    else if (ctrl is ComboBox)
                    {
                        ((ComboBox)ctrl).Enabled = false;
                    }
                }
                // Deshabilitar campos para solo consulta


            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buscarUsuario()
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            VUser usuario = usuarioNegocio.Tomarinfo(DNI);

            if (usuario == null)
            {
                return;

            }

            txt_dni.Text = usuario.Dni;
            txt_nombre.Text = usuario.Nombre;
            txt_contraseña.Text = usuario.Contrasenia;
            txt_repit.Text = usuario.Contrasenia;
            txt_fechaAlta.Text = usuario.FechaAlta;
            txt_telefono.Text = usuario.Telefono;
            txt_mail.Text = usuario.Mail;
            cmb_tipo.SelectedItem = usuario.Tipo;
            cajas.Checked = usuario.Cajas;
            Ventas.Checked = usuario.Ventas;
            articulos.Checked = usuario.Articulos;
            Clientes.Checked = usuario.Clientes;
            compras.Checked = usuario.Compras;
            Proveedores.Checked = usuario.Proveedores;
            Usuarios.Checked = usuario.Usuarios;
            Contable.Checked = usuario.Contabilidad;
            if (usuario.Foto != null)
            {
                using (MemoryStream ms = new MemoryStream(usuario.Foto))
                {
                    pic_usu.Image = Image.FromStream(ms);
                    pic_usu.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }


        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {

            using (ElegirPerfil elegir = new ElegirPerfil())
            {
                elegir.StartPosition = FormStartPosition.CenterParent;
                if (elegir.ShowDialog() == DialogResult.OK)
                {
                    pic_usu.Image = elegir.ImagenSeleccionada;
                    pic_usu.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
        }

        private Users GetUsu()
        {
            return usu;
        }

        private void btn_AM_Click(object sender, EventArgs e, Users usu)
        {

        }
        private byte[] ImagenABytes(Image imagen)
        {
            if (imagen == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }


        public void MostrarErrores(Resultado resultado)
        {
            foreach (var error in resultado.Errores)

            {
                switch (error.Campo)
                {
                    case "Dni":
                        errorProvider1.SetError(txt_dni, error.Mensaje);
                        break;
                    case "Nombre":
                        errorProvider1.SetError(txt_nombre, error.Mensaje);
                        break;
                    case "Contrasenia":
                        errorProvider1.SetError(txt_contraseña, error.Mensaje);
                        break;
                    case "Telefono":
                        errorProvider1.SetError(txt_telefono, error.Mensaje);
                        break;
                    case "Mail":
                        errorProvider1.SetError(txt_mail, error.Mensaje);
                        break;
                    case "Tipo":
                        errorProvider1.SetError(cmb_tipo, error.Mensaje);
                        break;

                    case "Permisos":
                        errorProvider1.SetError(panel3, error.Mensaje);
                        break;
                }
            }
        }

        string tipoAnterior = "";
        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TipoSeleccionado = cmb_tipo.SelectedItem?.ToString();
            if (TipoSeleccionado == "Administrador")
            {
                cajas.Checked = true;
                Ventas.Checked = true;
                articulos.Checked = true;
                compras.Checked = true;
                Proveedores.Checked = true;
                Clientes.Checked = true;
                Usuarios.Checked = true;
                Contable.Checked = true;

            }
            else if (tipoAnterior == "Administrador")
            {
                cajas.Checked = false;
                Ventas.Checked = false;
                articulos.Checked = false;
                compras.Checked = false;
                Proveedores.Checked = false;
                Clientes.Checked = false;
                Usuarios.Checked = false;
                Contable.Checked = false;
            }
            tipoAnterior = TipoSeleccionado;
        }

        //Validaciines de campos
        private void txt_dni_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_dni_KeyDown(object sender, KeyEventArgs e)
        {

            bool isALtgr = e.Control && e.Alt;
            if ((e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            //bloquear ALtGr + Q
            if (e.Control && e.Alt && e.KeyCode == Keys.Q)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txt_dni_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {

            bool isALtgr = e.Control && e.Alt;
            if ((e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            //bloquear ALtGr + Q
            if (e.Control && e.Alt && e.KeyCode == Keys.Q)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txt_mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && c != '@' && c != '.' && !char.IsControl(c))
            {
                e.Handled = true; // Bloquea cualquier otro carácter
            }

        }

        private void txt_mail_KeyDown(object sender, KeyEventArgs e)
        {
            bool isALtgr = e.Control && e.Alt;
            if ((e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        public List<string> CamposDuplicados()
        {
            List<string> duplicados = new List<string>();



            string consulta = @"
        SELECT
         
            CASE WHEN EXISTS (SELECT 1 FROM Usuario WHERE Usuario = @Usuario ) THEN 'Sí' ELSE 'No' END AS Usuario_Duplicado;";

            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {

                cmd.Parameters.AddWithValue("@Usuario", txt_nombre.Text.Trim());


                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                        if (reader["Usuario_Duplicado"].ToString() == "Sí") duplicados.Add("Nombre de usuario");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar duplicados:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return duplicados;
        }

        public int VerificarDNI(string dni)
        {
            string consulta = "SELECT Estado FROM Usuario WHERE DNI = @DNI";

            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@DNI", dni);

                conn.Open();
                object resultado = cmd.ExecuteScalar();

                if (resultado == null)
                    return -1; // no existe

                return Convert.ToInt32(resultado); // devuelve 0 o 1
            }
        }
        private void btn_AM_Click(object sender, EventArgs e)
        {
            if (Modo == "Alta")
            {
                errorProvider1.Clear();
                VUser usuario = CrearUsuarioDesdeFormulario();

                string dni = txt_dni.Text.Trim();
                string user = txt_nombre.Text.Trim();
                int EstadoDNI = VerificarDNI(dni);

                //Existe DNI
                if (EstadoDNI == 1)
                {
                    MessageBox.Show("Ya existe un usuario activo con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (EstadoDNI == 0)
                {
                    DialogResult r = MessageBox.Show(
                        "El usuario existe pero está dado de baja.\n¿Desea reactivarlo?",
                        "Reactivar usuario",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        UsuarioDatos datos = new UsuarioDatos();
                        datos.ReactivarUsuario(dni);
                        MessageBox.Show("Usuario reactivado correctamente.");
                        usu.llenarUser();
                        this.Close();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                var duplicados = CamposDuplicados();




                if (duplicados.Count > 0)
                {
                    string mensaje = "¡Ya existen datos duplicados en los siguientes campos:\n" +
                                     string.Join(", ", duplicados) + "!";
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Se encontró duplicado, se detiene el proceso
                }
                else
                {
                    UsuarioNegocio negocio = new UsuarioNegocio();
                    UsuarioDatos usuarioDatos = new UsuarioDatos();
                    Resultado resultado = negocio.ValidarUsuario(usuario);

                    if (!resultado.EsValido)
                    {
                        MostrarErrores(resultado);
                        return;
                    }




                    usuarioDatos.AltacompletoUsuario(usuario);
                    usuarioDatos.AltaHistoricoCompleto(usuario);
                    usu?.llenarUser();
                    this.Close();
                }

            }
            else if (Modo == "Modificar")
            {
                VUser usuario = new VUser();

                usuario.Dni = txt_dni.Text;
                usuario.Nombre = txt_nombre.Text;
                usuario.Contrasenia = txt_contraseña.Text;
                usuario.Repit = txt_repit.Text;
                usuario.Telefono = txt_telefono.Text;
                usuario.Mail = txt_mail.Text;

                usuario.Tipo = cmb_tipo.SelectedItem?.ToString();

                usuario.Cajas = cajas.Checked;
                usuario.Ventas = Ventas.Checked;
                usuario.Articulos = articulos.Checked;
                usuario.Compras = compras.Checked;
                usuario.Proveedores = Proveedores.Checked;
                usuario.Clientes = Clientes.Checked;
                usuario.Usuarios = Usuarios.Checked;
                usuario.Contabilidad = Contable.Checked;
                usuario.Empleados = empleados.Checked;
                usuario.Foto = ImagenABytes(pic_usu.Image);


                usuario.TipoMovimiento = "modificación de usuario";
                usuario.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                " ) ha modificado la información de: " + txt_nombre.Text +
                                " ( DNI: " + txt_dni.Text.Trim() + ")";

                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                Resultado resultado = usuarioNegocio.ValidarUsuario(usuario);

                if (!resultado.EsValido)
                {
                    MostrarErrores(resultado);
                    return;
                }

                UsuarioDatos usuarioDatos = new UsuarioDatos();
                usuarioDatos.ModiCompleto(usuario);
                usuarioDatos.AltaHistoricoCompleto(usuario);
                usu.llenarUser();
                this.DialogResult = DialogResult.OK;
                this.Close();


            }
        }

        private VUser CrearUsuarioDesdeFormulario()
        {
            VUser usuario = new VUser
            {
                Dni = txt_dni.Text.Trim(),
                Nombre = txt_nombre.Text.Trim(),
                Contrasenia = txt_contraseña.Text,
                Repit = txt_repit.Text,
                Telefono = txt_telefono.Text.Trim(),
                Mail = txt_mail.Text.Trim(),
                Tipo = cmb_tipo.SelectedItem?.ToString(),

                Cajas = cajas.Checked,
                Ventas = Ventas.Checked,
                Articulos = articulos.Checked,
                Compras = compras.Checked,
                Proveedores = Proveedores.Checked,
                Clientes = Clientes.Checked,
                Usuarios = Usuarios.Checked,
                Contabilidad = Contable.Checked,
                TipoMovimiento = "Alta de usuario",

                DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                ") ha dado de alta a: " + txt_nombre.Text +
                                " (DNI: " + txt_dni.Text.Trim() + ")"



            };

            Image img = pic_usu.Image ?? Properties.Resources.usuario__11_;
            usuario.Foto = ImagenABytes(img);

            return usuario;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
