using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MyM26.BLL;
using System.Windows.Forms;
using MyM26.Entidades.Usuario;
using MyM26.DAL;

namespace MyM26.screens
{
    public partial class TargetaUsuario : UserControl
    {
        private string dni;
        private string nombre;
        private string tipo;
        public Users usr;

        public event Action<string> EditarUsuario;
        public event Action DatoEliminado;



        public TargetaUsuario(Users user)
        {
            InitializeComponent();
            pic_usu.SizeMode = PictureBoxSizeMode.StretchImage;
            this.usr = user;
        }

        public TargetaUsuario()
        {
         InitializeComponent();
         pic_usu.SizeMode = PictureBoxSizeMode.StretchImage;

        }
      
        private void TargetaUsuario_Load(object sender, EventArgs e)
        {

        }


        public void label1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        /* public void eliminar()
         {
             string dni = lbl_dni.Text.Trim();
             DialogResult resultado = MessageBox.Show("¿Esta seguro de eliminar a este usuario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             if (resultado != DialogResult.Yes)
                 return;
             UsuarioNegocio un = new UsuarioNegocio();
             VUser usuario= un.eliminarUser(dni);

             DatoEliminado?.Invoke();


             usuario.TipoMovimiento = "modificación de usuario";
             usuario.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                             " (DNI: " + UsuarioActivo.Datos.DNIAc +
                             " ) ha modificado la información de: " + nombre +
                             " ( DNI: " + dni + ")";
             UsuarioDatos datos = new UsuarioDatos();
             datos.AltaHistoricoCompleto(usuario);
             //se rompio
         }*/
        public void eliminar()
        {
            string dni = lbl_dni.Text.Trim();
            if (MessageBox.Show("¿Esta seguro de eliminar a este usuario?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            UsuarioNegocio un = new UsuarioNegocio();
            VUser usuario = un.eliminarUser(dni);

            // Si el negocio falló y devolvió null, lo creamos aquí para que no de error
            if (usuario == null) usuario = new VUser { Dni = dni };

            // Verificamos que la sesión global exista
            if (UsuarioActivo.Datos == null)
            {
                MessageBox.Show("Sesión expirada");
                return;
            }

            usuario.TipoMovimiento = "Baja de usuario";
            usuario.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                            " (DNI: " + UsuarioActivo.Datos.DNIAc +
                            " ) ha dado de baja a: " + nombre +
                            " ( DNI: " + dni + ")";
            UsuarioDatos datos = new UsuarioDatos();
            datos.AltaHistoricoCompleto(usuario);
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
         
            string dni = lbl_dni.Text.Trim();
            EditarUsuario?.Invoke(dni);

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = lbl_dni.Text.Trim();
            eliminar();
            DatoEliminado?.Invoke();

        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Dni
        {
            get { return dni; }
            set
            { dni = value; lbl_dni.Text = dni; }
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                lbl_nombre.Text = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Foto
        {
            get { return pic_usu.Image; }
            set
            {
                pic_usu.Image = value;
            }

        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Tipo
        {
            get { return tipo; }
            set
            {
                tipo = value;
                lbl_tipo.Text = value;
            }
        }

    }
}

