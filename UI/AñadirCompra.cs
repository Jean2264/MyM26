using MyM26.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MyM26.DAL;
using MyM26.BLL;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyM26.screens;

namespace MyM26.UI
{
    public partial class AñadirCompra : Form
    {
        string cbinpt;
        public AñadirCompra()
        {
            InitializeComponent();
            Conexion.Conectar();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Buscar()
        {
            cbinpt = textBox1.Text.Trim();
            string CodArt = VerificarArt(cbinpt);

            if (CodArt == "NO_EXISTE")
            {
                DialogResult result = MessageBox.Show(
                "No existe ningun articulo en ninguna compra con este código de barra. ¿Desea dar de alta el artículo?",
                "Artículo no encontrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ABM ar = new ABM();
                    ar.Modo = "Añadir-Compra";
                    ar.StartPosition = FormStartPosition.CenterScreen;
                    ar.ShowDialog();
                    this.Close();
                }
            }
            else if (CodArt != "ERROR")
            {
                DialogResult result = MessageBox.Show(
                    $"Ya existe un artículo registrado ({CodArt}). ¿Desea actualizar la información de la compra?",
                    "Artículo existente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {

                    ActCompra at = new ActCompra(cbinpt);
                    at.cod = cbinpt.ToString(); ;
                    at.StartPosition = FormStartPosition.CenterScreen;
                    at.ShowDialog();
                    this.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public string VerificarArt(string cb)
        {
            // Buscamos por Código de Barras, pero recuperamos tu "ID profesional" (CodigoArticulo)
            string consulta = "SELECT CodigoArticulo FROM Articulo WHERE CodigoBarra = @cb AND Estado = 1";

            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.Add("@cb", SqlDbType.VarChar).Value = cb;

                try
                {
                    conn.Open();
                    object resultado = cmd.ExecuteScalar();

                    if (resultado == null || resultado == DBNull.Value)
                    {
                        return "NO_EXISTE";
                    }

                    // Devolvemos el string "Art 3", "Art 4", etc.
                    return resultado.ToString();
                }
                catch (Exception)
                {
                    return "ERROR";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AñadirCompra_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
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

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }
    }
}
