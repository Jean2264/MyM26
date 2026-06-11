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
        int registrosPorPagina = 24;
        int totalPaginas = 0;
        bool modoFiltro = false;
        string filtro;
        public Articulos()
        {
            InitializeComponent();
            Conexion.Conectar();

           LLenarFlow();
           
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
       

       public void LLenarFlow()
        {
            flowLayoutPanel1.Controls.Clear();

            ArticuloDatos db = new ArticuloDatos();
            var result= db.MostrarArticulo(paginaActual, registrosPorPagina);
            if (result == null) return;

            foreach(var item in result.Data)
            {
                TarjetaArticulo ar= new TarjetaArticulo();
                ar.SetDta(item);
                ar.EditarArt += AbrirEdicionArt;
                ar.VistaArt += AbrirVista;
                ar.DatoEliminado += () =>
                {
                    LLenarFlow();
                };
                flowLayoutPanel1.Controls.Add(ar);
            }

            totalPaginas= (int)Math.Ceiling((double)result.Total / registrosPorPagina);
            lbl_paginas.Text = $"Página {paginaActual} / {totalPaginas}";
            btn_siguente.Enabled = paginaActual < totalPaginas;
            btn_anterior.Enabled = paginaActual > 1;
            label1.Text = $"Total de articulos: " + result.Total.ToString();
            modoFiltro = false;
        }

        public void LlenarFlowFiltro(string filtro)
        {
            flowLayoutPanel1.Controls.Clear();

            ArticuloDatos db = new ArticuloDatos();
            var result = db.MostrarArticuloFiltro(paginaActual, registrosPorPagina, filtro);
            if (result.Total == 0)
            {
                LLenarFlow();
                MessageBox.Show("No se encontraron resultados para la búsqueda.");
                return;
            }

            foreach (var item in result.Data)
            {
                TarjetaArticulo ar = new TarjetaArticulo();
                ar.SetDta(item);
                ar.EditarArt += AbrirEdicionArt;
                ar.VistaArt += AbrirVista;
                ar.DatoEliminado += () =>
                {
                    LLenarFlow();
                };
                flowLayoutPanel1.Controls.Add(ar);
            }

            totalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
            lbl_paginas.Text = $"Página {paginaActual} / {totalPaginas}";
            btn_siguente.Enabled = paginaActual < totalPaginas;
            btn_anterior.Enabled = paginaActual > 1;
            label1.Text = $"Total de articulos: " + result.Total.ToString();
            modoFiltro = true;

        }
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
                LLenarFlow();
            }
        }


        public void calculoCantidad()
        {
            VArticulo art = new VArticulo();
            ArticuloDatos dt = new ArticuloDatos();
            dt.CantCompleto(art);

            if (art.CantCategoria == 0 && art.CantSub == 0 && art.CantProveedor == 0)
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
                LLenarFlow();
            }
        }

     

        private void btn_anterior_Click(object sender, EventArgs e)
        { filtro= txt_buscar.Text;

            if (paginaActual > 1)
            {
                paginaActual--;
                if(!modoFiltro)
                {
                    LLenarFlow();
                }
                else
                {
                    LlenarFlowFiltro(filtro);
                }
            }
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            filtro = txt_buscar.Text;

            if (paginaActual < totalPaginas)
            {
                paginaActual++;
                if (!modoFiltro)
                {
                    LLenarFlow();
                }
                else
                {
                    LlenarFlowFiltro(filtro);
                }
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

      
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cod = txt_buscar.Text;
            LlenarFlowFiltro(cod);
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

            if (e.KeyCode == Keys.Enter)
            {
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

        private void txt_buscar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            // Supongamos que ya agregaste las columnas Editar y Ver en el diseñador
          /*  foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Editar"].Value = Properties.Resources.edit;
                row.Cells["Ver"].Value = Properties.Resources.ver;
                row.Cells["Eliminar"].Value = Properties.Resources.eliminar;
            }*/

        }
    }
}
