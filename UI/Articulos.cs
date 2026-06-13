using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades.Articulos;
using MyM26.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace MyM26.screens
{
    public partial class Articulos : UserControl
    {
        int pagina = 1;
        int limite = 50;
        int totalPaginas = 0;
        bool modoFiltro = false;
        string filtro;
        public Articulos()
        {
            InitializeComponent();
            Conexion.Conectar();



            calculoCantidad();

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            ABM aVM = new ABM(this);
            aVM.Modo = "Añadir";
            aVM.StartPosition = FormStartPosition.CenterParent;
            aVM.ShowDialog();
        }

       

        public void AggColumnasAccion()
        {
            if (!dtg_art.Columns.Contains("btnVer"))
            {
                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.Name = "btnVer";
                btnVer.HeaderText = "";
                btnVer.Text = "Ver";
                btnVer.FlatStyle = FlatStyle.Flat;
                btnVer.Width = 150;
                btnVer.UseColumnTextForButtonValue = true;
                btnVer.DefaultCellStyle.BackColor = Color.FromArgb(100, 82, 255);
                btnVer.DefaultCellStyle.ForeColor = Color.White;
                dtg_art.Columns.Add(btnVer);
            }

            if (!dtg_art.Columns.Contains("btnEditar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.Name = "btnEditar";
                btnEditar.HeaderText = "";
                btnEditar.Text = "Editar";
                btnEditar.FlatStyle = FlatStyle.Flat;
                btnEditar.Width = 150;
                btnEditar.UseColumnTextForButtonValue = true;
                btnEditar.DefaultCellStyle.BackColor = Color.FromArgb(87, 0, 238);
                btnEditar.DefaultCellStyle.ForeColor = Color.White;
                dtg_art.Columns.Add(btnEditar);
            }

            if (!dtg_art.Columns.Contains("btnEliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "btnEliminar";
                btnEliminar.HeaderText = "";
                btnEliminar.Text = "Eliminar";
                btnEliminar.FlatStyle = FlatStyle.Flat;
                btnEliminar.Width = 150;
                btnEliminar.UseColumnTextForButtonValue = true;
                btnEliminar.DefaultCellStyle.BackColor = Color.FromArgb(53, 0, 152);
                btnEliminar.DefaultCellStyle.ForeColor = Color.White;
                dtg_art.Columns.Add(btnEliminar);
            }
        }
        public void LlenarDtg()
        {
            ArticuloDatos dt = new ArticuloDatos();

            var result = dt.MostrarArticulo(pagina, limite);

            if (result == null) return;

            dtg_art.DataSource = null;
            dtg_art.DataSource = result.Data;

            int ultimo = dtg_art.Columns.Count - 1;

            dtg_art.Columns["btnVer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtg_art.Columns["btnVer"].Width = 80;

            dtg_art.Columns["btnEditar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtg_art.Columns["btnEditar"].Width = 80;

            dtg_art.Columns["btnEliminar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dtg_art.Columns["btnEliminar"].Width = 90;

            dtg_art.Columns["btnEliminar"].DisplayIndex = ultimo;
            dtg_art.Columns["btnEditar"].DisplayIndex = ultimo - 1;
            dtg_art.Columns["btnVer"].DisplayIndex = ultimo - 2;

       

            dtg_art.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N2";
            dtg_art.Columns["PrecioUnitario"].DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");

            dtg_art.Columns["PrecioXMayor"].DefaultCellStyle.Format = "N2";
            dtg_art.Columns["PrecioXMayor"].DefaultCellStyle.FormatProvider = new CultureInfo("es-AR");

            dtg_art.Columns["CodigoArticulo"].Visible = false;
            totalPaginas = (int)Math.Ceiling((double)result.Total / limite);
            lbl_paginas.Text = $"Pagina {pagina}/{totalPaginas}";
            label1.Text = $"Total registros: {result.Total}";
            btn_anterior.Enabled = pagina > 1;
            btn_siguente.Enabled = pagina < totalPaginas;

            modoFiltro = false;

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



        private void btn_anterior_Click(object sender, EventArgs e)
        {
            filtro = txt_buscar.Text;

            if (pagina > 1)
            {
                pagina--;
                if (!modoFiltro)
                {
                    LlenarDtg();
                }
                else
                {
                    // LlenarFlowFiltro(filtro);
                }
            }
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            filtro = txt_buscar.Text;

            if (pagina < totalPaginas)
            {
                pagina++;
                if (!modoFiltro)
                {
                    LlenarDtg();
                }
                else
                {
                    //LlenarFlowFiltro(filtro);
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
            //  LlenarFlowFiltro(cod);
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
            AggColumnasAccion();
            LlenarDtg();

        }

        private void dtg_art_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== dtg_art.Columns["btnVer"].Index)
            {
                ABM ab = new ABM();
                ab.cod = dtg_art.CurrentRow.Cells["CodigoArticulo"].Value.ToString();
                ab.Modo = "Ver";
                ab.ShowDialog();
            }

            if(e.ColumnIndex== dtg_art.Columns["btnEditar"].Index)
            {
                ABM ab= new ABM(this);
                ab.cod = dtg_art.CurrentRow.Cells["CodigoArticulo"].Value.ToString();
                ab.Modo = "Modificar";
                ab.ShowDialog();
            }

            if(e.ColumnIndex== dtg_art.Columns["btnEliminar"].Index)
            {
                string cod= dtg_art.CurrentRow.Cells["CodigoArticulo"].Value.ToString();

                DialogResult r = MessageBox.Show("Estas seguro de eliminar este articulo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(r== DialogResult.Yes)
                {
                    ArticuloNegocio neg = new ArticuloNegocio();
                    neg.EliminarArt(cod);

                    LlenarDtg();
                }
            }
        }
    }
}
