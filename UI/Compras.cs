using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades.Articulos;
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
        int registrosPorPagina = 20;
        int TotalPaginas = 0;
        bool filtroCompra = false;
        public Compras()
        {
            InitializeComponent();
            Conexion.Conectar();
            AvisosGlobales.OnCompraFinalizada += ActualizarGrilla;
           MostrarCompra();
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
           MostrarCompra();
        }
        public void MostrarCompra()
        {
            ArticuloDatos db = new ArticuloDatos();
            var result = db.MostrarCompra(paginaActual, registrosPorPagina);

            if (result == null) return;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.Data;

            TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
            lbl_paginas.Text = $"Pagina {paginaActual} / {TotalPaginas}";
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguente.Enabled = paginaActual < TotalPaginas;

            label1.Text = $"Total de clientes: {result.Total}";
            filtroCompra = false;
        }

       

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            if (paginaActual < TotalPaginas)
            {
                paginaActual++;
                if (!filtroCompra)
                {
                    MostrarCompra();
                }
                else
                {
                    MostrarCompraFiltro(txt_buscar.Text);
                }
            }

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
               if(!filtroCompra)
                {
                    MostrarCompra();
                }
                else
                {
                    MostrarCompraFiltro(txt_buscar.Text);
                }
            }
        }


       
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string nombre = txt_buscar.Text;
            MostrarCompraFiltro(nombre);
        }

        public void MostrarCompraFiltro(string filtro)
        {
            ArticuloDatos db = new ArticuloDatos();

            var result= db.MostrarCompraFiltro(paginaActual, registrosPorPagina,filtro);
            if (result == null) return;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.Data;
            TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
           lbl_paginas.Text= $"Pagina {paginaActual} / {TotalPaginas}";
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguente.Enabled = paginaActual < TotalPaginas;
            label1.Text = $"Total de clientes: {result.Total}";
            filtroCompra = true;
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

            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_buscar.PerformClick();
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

        //validacion de existencia de proveedor
        private void prov()
        {
            VArticulo art = new VArticulo();
            ArticuloDatos db = new ArticuloDatos();
            db.CantProvCompra(art);
            if (art.CantProveedor == 0)

            {
                MessageBox.Show("Para poder realizar y/0 modificar una compra, debe existir al menos un proveedor.");
                btn_buscar.Enabled = false;
                btn_añadirUsrr.Enabled = false;
                btn_anterior.Enabled = false;
                btn_siguente.Enabled = false;
                return;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Compras_Load(object sender, EventArgs e)
        {
            prov();
        }
    }
}
