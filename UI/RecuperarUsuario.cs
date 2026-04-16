using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using MyM26.DAL;
using MyM26.BLL;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyM26.UI
{
    public partial class RecuperarUsuario : Form
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
        public RecuperarUsuario()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void RecuperarUsuario_Load(object sender, EventArgs e)
        {
            MostrarPaso1();
        }


        private void MostrarUserControl(UserControl uc)
        {
            panelprincipal.Controls.Clear(); // Limpiar lo que haya antes
            uc.Dock = DockStyle.Fill;        // Que ocupe todo el panel
            panelprincipal.Controls.Add(uc);
            panelprincipal.BackColor = this.BackColor; // mismo púrpura que el Form

            panelprincipal.Visible = true; // mostrar el panel
            uc.BringToFront();                // Traerlo al frente
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            log.Location = this.Location;
            this.Close();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MostrarPaso1()
        {
            Correo uc1 = new Correo();
            // Nos suscribimos al evento
            uc1.CorreoValidado += (s, e) =>
            {
                // Cuando el UC avisa, mostramos el paso 2
                MostrarPaso2();
            };
            MostrarUserControl(uc1);
        }
        private void MostrarPaso2()
        {
            Token uc12 = new Token();
            // Nos suscribimos al evento
            uc12.TokenValidado += (s, e) =>
            {
                // Cuando el UC avisa, mostramos el paso 3
                MostrarPaso3();
            };
            MostrarUserControl(uc12);
        }

        private void MostrarPaso3()
        {
            Contrasenia uc3 = new Contrasenia();
            uc3.ContraseniaValidado += (
                s, e) =>
            {
                // Cuando el UC avisa, volvemos al login
                Login log = new Login();
                log.Show();
                log.Location = this.Location;
                this.Close();
            };
            MostrarUserControl(uc3);
        }

        private void panelprincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
