using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Comun;
using MyM26.DAL;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyM26.UI
{
    public partial class Contrasenia : UserControl
    {
        public event EventHandler ContraseniaValidado;
        public Contrasenia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Contrasenia_Load(object sender, EventArgs e)
        {
            lbl_user.Text = $"Usuario: {RecUser.usuario}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public bool validarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_contra.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(txt_contra, "Este campo es obligatorio.");
                errorProvider1.SetError(textBox2, "Este campo es obligatorio.");
               
                return false;
            }
            if (txt_contra.Text != textBox2.Text)
            {
                errorProvider1.SetError(txt_contra, "Las contraseñas no coinciden.");
                errorProvider1.SetError(textBox2, "Las contraseñas no coinciden.");
               
                return false;
            }
            if (txt_contra.Text.Length < 8)
            {
                errorProvider1.SetError(txt_contra, "La contraseña debe tener al menos 8 caracteres.");

                return false;
            }

            return true;
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


        }

        private void txt_contra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // cancela el clic derecho
                e = null;
                MessageBox.Show("Función deshabilitada.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_contra_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_contra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // bloquea cualquier símbolo
            }
        }

        private void btn_verifi_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {
                using (SqlConnection cn = new SqlConnection(Decla.ConnectionString))
                {
                    cn.Open();
                    string consulta = @"
                                        UPDATE Usuario
                                        SET Contrasenia = @contra
                                        WHERE Usuario = @usuario";
                    SqlCommand comando = new SqlCommand(consulta, cn);
                    comando.Parameters.AddWithValue("@contra", txt_contra.Text.Trim());
                    comando.Parameters.AddWithValue("@usuario", RecUser.usuario);
                    comando.ExecuteNonQuery();
                }
                MessageBox.Show("Contraseña actualizada exitosamente.");
                ContraseniaValidado?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
