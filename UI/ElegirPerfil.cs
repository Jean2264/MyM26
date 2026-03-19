using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyM26.screens
{
    public partial class ElegirPerfil : Form
    {
        public Image ImagenSeleccionada { get; private set; }  // propiedad pública
        public ElegirPerfil()
        {
            InitializeComponent();
        }
        private PictureBox avatarSeleccionado = null;
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void perfil_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            //Si no tene cargado imagen, no hacer nada
            if (pb.BackgroundImage == null)
                return;

            // Quitar bordes a todos
            foreach (Control ctrl in this.Controls)
                if (ctrl is PictureBox)
                    (ctrl as PictureBox).BorderStyle = BorderStyle.None;

            // Marcar como seleccionado
            pb.BorderStyle = BorderStyle.FixedSingle;
            avatarSeleccionado = pb;

            button1.Visible = true;
        }
        private void pic_usu_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Seleccione una imagen";
            abrir.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                //pic_usu_Buscar.Image = Image.FromFile(abrir.FileName);
                pic_usu_Buscar.BackgroundImage = Image.FromFile(abrir.FileName);
                pic_usu_Buscar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (avatarSeleccionado != null)
            {
                ImagenSeleccionada = new Bitmap(avatarSeleccionado.BackgroundImage); // guardamos la imagen seleccionada
                this.DialogResult = DialogResult.OK; // notificamos al padre que hay selección
                this.Close();
            }
            else
            {
                MessageBox.Show("Primero selecciona un avatar");
            }
        }

        private void ElegirPerfil_Load(object sender, EventArgs e)
        {

        }
    }
}
