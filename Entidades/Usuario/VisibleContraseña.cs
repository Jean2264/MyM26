using System;
using System.Collections.Generic;
using System.Text;

namespace MyM26.Entidades.Usuario
{
    public class VisibleContraseña
    {
        //creo las viariables de tipo objeto contenedores       
        private TextBox _textBox;
        private PictureBox _pictureBox;
        private Image _imagenOjoAbierto;
        private Image _imagenOjoCerrado;
        public bool _mostrarClave;

        public VisibleContraseña(TextBox textBox, PictureBox pictureBox, Image imagenOjoAbierto, Image imagenOjoCerrado)
        {
            _textBox = textBox;
            _pictureBox = pictureBox;
            _imagenOjoAbierto = imagenOjoAbierto;
            _imagenOjoCerrado = imagenOjoCerrado;
            _mostrarClave = false;

            _textBox.UseSystemPasswordChar = true;
            ActualizarVisibilidadClave();

            _pictureBox.Click += PictureBox_Click;
            _textBox.TextChanged += TextBox_TextChanged; // Suscribimos el evento
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            _mostrarClave = !_mostrarClave;
            ActualizarVisibilidadClave();
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (_mostrarClave)
            {
                _mostrarClave = false; // Forzar a ocultar la contraseña
                ActualizarVisibilidadClave();

                // Mantener el cursor al final
                _textBox.SelectionStart = _textBox.Text.Length;
            }
        }

        private void ActualizarVisibilidadClave()
        {
            _textBox.UseSystemPasswordChar = !_mostrarClave;

            _pictureBox.BackgroundImage = _mostrarClave ? Properties.Resources.visible : Properties.Resources.NoVisible;

        }
    }
}
