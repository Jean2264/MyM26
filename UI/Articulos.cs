using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades.Articulos;
using MyM26.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyM26.screens
{
    public partial class Articulos : UserControl
    {
        int paginaActual = 1;
        int registrosPorPagina = 10;
        int totalPaginas = 0;
        public Articulos()
        {
            InitializeComponent();
            Conexion.Conectar();
            
            LlenarArt();
            CalcularTotalPaginas();
            calculoCantidad();

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            ABM aVM = new ABM(this);
            aVM.Modo = "Añadir";
            aVM.StartPosition = FormStartPosition.CenterParent;
            aVM.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ABM aVM = new ABM(this);
            aVM.Modo = "Modificar";
            aVM.StartPosition = FormStartPosition.CenterParent;
            aVM.ShowDialog();
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            ABM aVM = new ABM(this);
            aVM.Modo = "Vista";
            aVM.StartPosition = FormStartPosition.CenterParent;
            aVM.ShowDialog();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Categorias cat = new Categorias();
            cat.StartPosition = FormStartPosition.CenterParent;
            cat.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LlenarArt()
        {
           

            flowLayoutPanel1.Controls.Clear();
            ArticuloDatos db = new ArticuloDatos();

            db.LlenarContenedor(flowLayoutPanel1, AbrirEdicionArt, AbrirVista, this, paginaActual, registrosPorPagina);
            CalcularTotalPaginas();
        }

        /* private void AbrirEdicionUsuario(string dni)
        {
            UsuarioNegocio un = new UsuarioNegocio();
            un.Tomarinfo(dni);

            AMUser us = new AMUser(this);
            us.DNI = dni;
            us.Modo = "Modificar";
            us.StartPosition = FormStartPosition.CenterParent;

            if (us.ShowDialog() == DialogResult.OK)
            {
                llenarUser(); // 🔥 refresca
            }
        }*/
        public void AbrirEdicionArt(string cod)
        {
            ArticuloNegocio neg = new ArticuloNegocio();
            neg.TomarInfo(cod);

            ABM am = new ABM(this);
            am.cod = cod;
            am.Modo = "Modificar";
            am.StartPosition = FormStartPosition.CenterParent;

            if (am.ShowDialog() == DialogResult.OK)
            {
                LlenarArt();
            }
        }


        public void calculoCantidad()
        {
            VArticulo art = new VArticulo();
            ArticuloDatos dt = new ArticuloDatos();
            dt.CantCompleto(art);

            if(art.CantCategoria==0 && art.CantSub==0 && art.CantProveedor==0)
            {
                MessageBox.Show("Para dar de alta a un articulo, al menos debe haber dado de alta una Categoria, Subcategoria y un Proveedor");
                btn_buscar.Enabled = false;
                btn_añadir.Enabled = false;
                btn_anterior.Enabled = false;
                btn_siguente.Enabled = false;
                return;
            }
        }
        public void AbrirVista(string cod)
        {
            ArticuloNegocio neg = new ArticuloNegocio();
            neg.TomarInfo(cod);

            ABM am = new ABM(this);
            am.cod = cod;
            am.Modo = "Vista Artículo";
            am.StartPosition = FormStartPosition.CenterParent;

            if (am.ShowDialog() == DialogResult.OK)
            {
                LlenarArt();
            }
        }

        private void CalcularTotalPaginas()
        {
            ArticuloDatos dt = new ArticuloDatos();
            int totalRegistros = dt.ObtenerTotalArt();
            totalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);
            lbl_paginas.Text = $"Página {paginaActual} / {totalPaginas}";
            label1.Text = $"Total de articulos: " + totalRegistros.ToString();
            btn_siguente.Enabled = paginaActual < totalPaginas;
            btn_anterior.Enabled = paginaActual > 1;

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
           
            if (paginaActual > 1)
            {
                paginaActual--;
                LlenarArt();
            }
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
          if(paginaActual< totalPaginas)
            {
                paginaActual++;
                LlenarArt();
            }
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_bajas_Click(object sender, EventArgs e)
        {
            Bajas bj = new Bajas();
            bj.Modo = "Articulo";
            bj.StartPosition = FormStartPosition.CenterParent;
            bj.ShowDialog();
        }

        public void BuscarArt(string cod)
        {

            flowLayoutPanel1.Controls.Clear();
            ArticuloDatos dt = new ArticuloDatos();

            dt.FiltrarArt(
                flowLayoutPanel1,
                cod);



        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cod = txt_buscar.Text;
            BuscarArt(cod);
        }

        private void txt_buscar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
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

        private void txt_buscar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }
    }
}
