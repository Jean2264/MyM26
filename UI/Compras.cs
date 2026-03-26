using MyM26.BLL;
using MyM26.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyM26.UI
{
    public partial class Compras : UserControl
    {
        int paginaActual = 1;
        int registrosPorPagina = 37;
        int TotalPaginas = 0;
        public Compras()
        {
            InitializeComponent();
            Conexion.Conectar();
            AvisosGlobales.OnCompraFinalizada += ActualizarGrilla;
            llenar();
            CalcularTotalPaginasCompras();
        }

        private void btn_añadirUsrr_Click(object sender, EventArgs e)
        {
            AñadirCompra añadir = new AñadirCompra();
            añadir.StartPosition = FormStartPosition.CenterScreen;
            añadir.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /* public void LlenarDtgEmpleado()
        {
            Decla.EmpleadoTab = EmpleadoDatos.LLenarDtgEmpleado(paginaActual, registrosPorPagina);

            dataGridView1.DataSource = Decla.EmpleadoTab;

        }*/
        private void ActualizarGrilla()
        {
            llenar();
        }
        public void llenar()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Decla.CompraTab = ArticuloDatos.MostrarCompra(paginaActual, registrosPorPagina);
            dataGridView1.DataSource = Decla.CompraTab;
            CalcularTotalPaginasCompras();
        }

        private void CalcularTotalPaginasCompras()
        {
            ArticuloDatos db = new ArticuloDatos();
            int totalRegistros = db.ObtenerTotalCompras();
            TotalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);



            if (paginaActual == totalRegistros)
            {
                btn_siguente.Enabled = false;
            }
            else if (paginaActual < totalRegistros)
            {
                btn_siguente.Enabled = true;
            }
            label1.Text = $"Total de clientes: {totalRegistros}";
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.AllowUserToAddRows && dataGridView1.Rows.Count == 1))
            {
                lbl_paginas.Text = $"Página 0/0";
            }
            else
            {
                lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
            }
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            paginaActual++;
            ArticuloDatos.MostrarCompra(paginaActual, registrosPorPagina);

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                ArticuloDatos.MostrarCompra(paginaActual, registrosPorPagina);
            }
        }


        /*private void btn_buscar_Click(object sender, EventArgs e)
        {
            string dni= txt_buscar.Text;
            BuscarEmpl(dni);
        }

        public void BuscarEmpl(string dni)
        {
            dataGridView1.DataSource = EmpleadoDatos.FiltrarEmpl(dni);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }*/
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string nombre = txt_buscar.Text;
            BuscarCompra(nombre);
        }

        public void BuscarCompra(string nombre)
        {
            dataGridView1.DataSource = ArticuloDatos.FiltrarCompra(nombre);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void txt_buscar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_buscar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }

        private void txt_buscar_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
