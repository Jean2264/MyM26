using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using MyM26.DAL;
using System.Net.Mail;
using System.Net;
using MyM26.BLL;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyM26.UI
{
    public partial class Login : Form
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
        public Login()
        {
            InitializeComponent();
            Conexion.Conectar();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var controlVisibilidad = new VisibleContraseña(
        txt_contra,
         pcb_ver,
         Properties.Resources.visible,  // ojo abierto
            Properties.Resources.NoVisible
            );       // ojo cerrado
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button2_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
           

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Size = tamañoClick;
            button2.BackgroundImage = Properties.Resources.apreto;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Size = tamañoHover;
            button2.BackgroundImage = Properties.Resources.suelto;
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // bloquea cualquier símbolo
            }
        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            bool isAltGr = e.Control && e.Alt;

            // Bloquear combinaciones comunes de copiar/pegar/cortar
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

            // Bloquear teclas de Windows
            if (e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txt_user_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_user_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // cancela el clic derecho
                e = null;
                MessageBox.Show("Función deshabilitada.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_contra_KeyDown(object sender, KeyEventArgs e)
        {

            bool isAltGr = e.Control && e.Alt;

            // Bloquear combinaciones comunes de copiar/pegar/cortar
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

            // Bloquear teclas de Windows
            if (e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VUser usu = new VUser
            {
                NombreAc = txt_user.Text,
                DNIAc = txt_user.Text,
                ContraseniaAc = txt_contra.Text
            };

            UsuarioNegocio negocio = new UsuarioNegocio();
            Resultado resultado = negocio.Validarlog(usu);

            if (!resultado.EsValido)
            {
                mostrarError(resultado);
                return;
            }

            UsuarioDatos usuarioDatos = new UsuarioDatos();
            VUser usuariolog = usuarioDatos.logeo(usu.NombreAc, usu.ContraseniaAc);


            if (usuariolog != null)
            {
                UsuarioActivo.Datos = usuariolog;
                Principal principal = new Principal(usuariolog);
                principal.name = usuariolog.NombreAc;
                principal.tipo = usuariolog.TipoAc;
                principal.foto = usuariolog.FotoAc;
                principal.StartPosition = FormStartPosition.CenterScreen;
                principal.Show();
                this.Hide();
            }
            else
            {
                lbl_error.Visible = true;
                return;
            }
        }

        public void mostrarError(Resultado resultado)
        {
            foreach (var error in resultado.Errores)
            {
                switch (error.Campo)
                {
                    case "Usuario":
                        errorProvider1.SetError(txt_user, error.Mensaje);
                        break;
                    case "Contrasenia":
                        errorProvider1.SetError(txt_contra, error.Mensaje);
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarUsuario recuperar = new RecuperarUsuario();
            recuperar.StartPosition = FormStartPosition.CenterScreen;
            recuperar.Show();
            this.Hide();
        }

        private void txt_user_MouseEnter(object sender, EventArgs e)
        {


        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            //Segoe UI Semibold, 9.75pt, style=Bold  
            //79, 207
            label2.Location = new Point(79, 210);
            label2.Enabled = true;
            label2.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label2.ForeColor = Color.Black;

        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            { //Segoe UI, 7.8pt
                label2.Location = new Point(83, 238);

                label2.Font = new Font("Segoe UI", 8);
                label2.ForeColor = Color.FromArgb(64, 64, 64);
                label2.Enabled = false;
            }
        }

        private void txt_contra_Enter(object sender, EventArgs e)
        {
            label4.Location = new Point(81, 330);
            label4.Enabled = true;
            label4.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label4.ForeColor = Color.Black;
        }

        private void txt_contra_Leave(object sender, EventArgs e)
        {
            if (txt_contra.Text == "")
            {
                label4.Location = new Point(86, 358);
                label4.Font = new Font("Segoe UI", 8);
                label4.ForeColor = Color.DimGray;
                label4.ForeColor = Color.FromArgb(64, 64, 64);
                label4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
