using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades.Articulos;
using MyM26.Entidades.Cliente;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Empleado;
using MyM26.Entidades.Usuario;
using MyM26.Querys;
using MyM26.screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MyM26.UI
{
    public partial class registroDeUser : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
  int nLeftRect,     // x-coordinate of upper-left corner
  int nTopRect,      // y-coordinate of upper-left corner
  int nRightRect,    // x-coordinate of lower-right corner
  int nBottomRect,   // y-coordinate of lower-right corner
  int nWidthEllipse, // width of ellipse (curvatura)
  int nHeightEllipse // height of ellipse (curvatura)
);
        private Size tamañoOriginal = new Size(178, 39);
        private Size tamañoHover = new Size(180, 43); // Un poco más grande
        private Size tamañoClick = new Size(175, 36);  // Un poco más pequeño
        public registroDeUser()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            Conexion.Conectar();
        }

        private void registroDeUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                Tipo = "Administrador",

                Cajas = true,
                Ventas = true,
                Articulos = true,
                Compras = true,
                Proveedores = true,
                Clientes = true,
                Empleados = true,
                Usuarios = true,
                Contabilidad = true,
                TipoMovimiento = "Alta de usuario",

                /* DetalleMovimiento = "el usuario " +
                                 " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                 ") ha dado de alta a: " + txt_nombre.Text +
                                 " (DNI: " + txt_dni.Text.Trim() + ")"*/

                DetalleMovimiento = $"El usuario (DNI: {txt_dni.Text.Trim()}) se ha registrado al sistema como primer usuario"

            };

            Image img = pic_usu.Image ?? Properties.Resources.usuario__11_;
            usuario.Foto = ImagenABytes(img);

            return usuario;
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

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            VUser usuario = CrearUsuarioDesdeFormulario();


            UsuarioNegocio negocio = new UsuarioNegocio();
            UsuarioDatos usuarioDatos = new UsuarioDatos();
            Resultado resultado = negocio.ValidarUserRegitro(usuario);
            if (!resultado.EsValido)
            {
                MostrarErrores(resultado);
                return;
            }




            usuarioDatos.AltacompletoUsuario(usuario);
            usuarioDatos.AltaHistoricoCompleto(usuario);



            //una vez que el registro fue dado avisamos que ya no es la primera ejecucion y se redirige al login
            Properties.Settings.Default.PrimeraEjecucion = false;
            Properties.Settings.Default.Save();
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();
            this.Hide();
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir? Se perderán los datos ingresados.", "Confirmar cambio QA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else            {
                result = DialogResult.None;
            }

        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_QA_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("¿Estás seguro de que deseas restablecer la configuración de primera ejecución? Esto hará que la aplicación se comporte como si ya no fuera la primera vez  que se ejecuta, solicitando el registro de un nuevo usuario.", "Restablecer Configuración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.PrimeraEjecucion = false;
                Properties.Settings.Default.Save();
                Application.Exit();
            }
            else
            {
                result = DialogResult.None;
            }

        }
    }
}
