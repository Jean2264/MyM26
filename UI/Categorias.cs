using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades.CatySub;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyM26.screens
{
    public partial class Categorias : Form
    {
        int paginaActual = 1;
        int registrosPorPagina = 10;
        int totalPaginas = 0;
        string cod;
        string sub;
        string cte;
        bool filtroCategorias = false;
        bool filtroSub = false;
        public Categorias()
        {
            InitializeComponent();
            Conexion.Conectar();
            MostrarCategorias();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {

        }
        //CATEGORIA

        public void MostrarCategorias()
        {
            CatySubDatos db = new CatySubDatos();
            var categorias = db.MostrarCategoria(paginaActual, registrosPorPagina);
            if (categorias == null) return;

            dtg_Cate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Cate.DataSource = null;
            dtg_Cate.DataSource = categorias.Data;
            dtg_Cate.Columns["CodCategoria"].Visible = false;

            totalPaginas = (int)Math.Ceiling((double)categorias.Total / registrosPorPagina);
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguente.Enabled = paginaActual < totalPaginas;
            lbl_pag_cat.Text = $"{paginaActual} / {totalPaginas}";
            lbl_total_cat.Text = $"Total: {categorias.Total}";
            filtroCategorias = false;
        }

        //Para categoria con filtro

        public void MostrarCategoriasFiltro(string filtro)
        {
            CatySubDatos db = new CatySubDatos();
            var categorias = db.MostrarCategoriaFiltro(paginaActual, registrosPorPagina, filtro);
            if (categorias == null) return;

            dtg_Cate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Cate.DataSource = null;
            dtg_Cate.DataSource = categorias.Data;
            dtg_Cate.Columns["CodCategoria"].Visible = false;

            totalPaginas = (int)Math.Ceiling((double)categorias.Total / registrosPorPagina);
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguente.Enabled = paginaActual < totalPaginas;
            lbl_pag_cat.Text = $"{paginaActual} / {totalPaginas}";
            lbl_total_cat.Text = $"Total: {categorias.Total}";
            filtroCategorias = true;
        }


        //SUBCATEGORIA
        private void btn_añadirCate_Click(object sender, EventArgs e)
        {
            VCatySub cat = new VCatySub();
            cat.Categoria = txt_cate.Text;

            CatySubNegocio neg = new CatySubNegocio();
            Resultado res = neg.ValidarCategoria(cat);
            if (!res.EsValido)
            {
                MostrarErrorCat(res);
                return;
            }

            CatySubDatos dta = new CatySubDatos();
            dta.AltaCompletoCategoria(cat);
            cat.TipoMovimiento = "Alta de Categoria";
            cat.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                          " (DNI: " + UsuarioActivo.Datos.DNIAc +
                          " ) ha dado de alta a la categoria: " + cte;
            dta.AltaHistoricoCompleto(cat);
            MostrarCategorias();
            txt_cate.Clear();
        }
        //Para categoria
        public void MostrarErrorCat(Resultado resultado)
        {
            foreach (var error in resultado.Errores)
            {
                switch (error.Campo)
                {
                    case "Categoria":
                        errorProvider1.SetError(txt_cate, error.Mensaje);
                        break;
                }
            }
        }




        private void btn_añadirSub_Click(object sender, EventArgs e)
        {
            VCatySub sub = new VCatySub();

            if (cmb_cate.SelectedValue != null)
            {
                sub.CodCatRef = cmb_cate.SelectedValue.ToString();
            }
            else
            {
                sub.CodCatRef = ""; // O un valor que tu validación reconozca como error
            }
            sub.Subcategoria = txt_sub.Text;
            CatySubNegocio ct = new CatySubNegocio();
            Resultado resultado = ct.ValidarSubcategoria(sub);

            if (!resultado.EsValido)
            {
                MostrarErrorSubcat(resultado);
                return;
            }
            CatySubDatos dt = new CatySubDatos();
            dt.Altacompeltosub(sub);

            sub.TipoMovimiento = "Alta de Subcategoria";
            sub.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                          " (DNI: " + UsuarioActivo.Datos.DNIAc +
                          " ) ha dado de alta a la Subcategoria: " + cte;
            dt.AltaHistoricoCompleto(sub);
            MostrarSubcategorias();
            txt_sub.Clear();
            cmb_cate.SelectedIndex = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Para categoria
        private void lbl_ant_cat_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                if (filtroCategorias == false)
                {
                    MostrarCategorias();
                }
                else
                {
                    MostrarCategoriasFiltro(txt_buscar.Text);
                }
            }
        }
        //Para categoria
        private void btn_sig_cat_Click(object sender, EventArgs e)
        {
            if (paginaActual < totalPaginas)
            {
                paginaActual++;
                if (filtroCategorias == false)
                {
                    MostrarCategorias();
                }
                else
                {
                    MostrarCategoriasFiltro(txt_buscar.Text);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabcategoria)
            {
                MostrarCategorias();
            }
            else if (tabControl1.SelectedTab == tabSub)
            {
                MostrarSubcategorias();
                cmb_cate.DataSource = CatySubDatos.MostrarCategoriaBox();
                cmb_cate.DisplayMember = "Categoria";
                cmb_cate.ValueMember = "CodCategoria";
                cmb_cate.SelectedIndex = -1;
            }
            else if (tabControl1.SelectedTab == tabDescuentos)
            {
                MostrarDescuentos();
            }
        }

        //PARA SUBCATEGORIA 
        public void MostrarSubcategorias()
        {
            CatySubDatos db = new CatySubDatos();
            var subcategorias = db.MostrarSubcategoria(paginaActual, registrosPorPagina);
            if (subcategorias == null) return;

            dtg_Subcate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Subcate.DataSource = null;
            dtg_Subcate.DataSource = subcategorias.Data;
            dtg_Subcate.Columns["CodSubcategoria"].Visible = false;
            totalPaginas = (int)Math.Ceiling((double)subcategorias.Total / registrosPorPagina);
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguente.Enabled = paginaActual < totalPaginas;
            lbl_paginas.Text = $"{paginaActual} / {totalPaginas}";
            lbl_total.Text = $"Total: {subcategorias.Total}";
            filtroSub = false;

        }

        //PARA SUBCATEGORIA CON FILTRO
        public void MostrarSubcategoriasFiltro(string filtro)
        {
            CatySubDatos db = new CatySubDatos();
            var subcategorias = db.MostrarSubcategoriaFiltrada(paginaActual, registrosPorPagina, filtro);
            if (subcategorias == null) return;
            dtg_Subcate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Subcate.DataSource = null;
            dtg_Subcate.DataSource = subcategorias.Data;
            dtg_Subcate.Columns["CodSubcategoria"].Visible = false;
            totalPaginas = (int)Math.Ceiling((double)subcategorias.Total / registrosPorPagina);
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguente.Enabled = paginaActual < totalPaginas;
            lbl_paginas.Text = $"{paginaActual} / {totalPaginas}";
            lbl_total.Text = $"Total: {subcategorias.Total}";
            filtroSub = true;
        }
        public void MostrarErrorSubcat(Resultado resultado)
        {
            foreach (var error in resultado.Errores)
            {
                switch (error.Campo)
                {
                    case "Categoria":
                        errorProvider1.SetError(cmb_cate, error.Mensaje);
                        break;
                    case "Subcategoria":
                        errorProvider1.SetError(txt_sub, error.Mensaje);
                        break;
                }
            }
        }

        private void btn_eliminarSub_Click(object sender, EventArgs e)
        {
            if (dtg_Subcate.CurrentRow != null)
            {
                cod = dtg_Subcate.CurrentRow.Cells["CodSubcategoria"].Value.ToString();
                sub = dtg_Subcate.CurrentRow.Cells["Subcategoria"].Value.ToString();
            }
            DialogResult resultado = MessageBox.Show("¿Esta seguro de eliminar a este subcategoria?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes)
            {
                return;
            }
            CatySubDatos.BajaSubcategoria(cod);

            VCatySub cat = new VCatySub();

            cat.TipoMovimiento = "Baja de Subcategoria";
            cat.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                          " (DNI: " + UsuarioActivo.Datos.DNIAc +
                          " ) ha dado de baja a la subcategoria: " + sub;
            CatySubDatos dt = new CatySubDatos();
            dt.AltaHistoricoCompleto(cat);

            /* empleado.TipoMovimiento = "Baja de empleado";
          empleado.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                          " (DNI: " + UsuarioActivo.Datos.DNIAc +
                          " ) ha dado de baja a: " + nombre +
                          " ( DNI: " + cda2 + ")";
          EmpleadoDatos datos = new EmpleadoDatos();
          datos.AltaHistoricoCompleto(empleado);
          LlenarDtgEmpleado()*/

            MostrarSubcategorias();
        }

        private void btn_eliminarCate_Click(object sender, EventArgs e)
        {
            if (dtg_Cate.CurrentRow != null)
            {
                cod = dtg_Cate.CurrentRow.Cells["CodCategoria"].Value.ToString();
                cte = dtg_Cate.CurrentRow.Cells["Categoria"].Value.ToString();

            }
            DialogResult resultado = MessageBox.Show("¿Esta seguro de eliminar a este categoria?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes)
            {
                return;
            }
            CatySubDatos.BajaCategoria(cod);

            VCatySub cat = new VCatySub();

            cat.TipoMovimiento = "Baja de Categoria";
            cat.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                          " (DNI: " + UsuarioActivo.Datos.DNIAc +
                          " ) ha dado de baja a la categoria: " + cte;
            CatySubDatos dt = new CatySubDatos();
            dt.AltaHistoricoCompleto(cat);


            MostrarCategorias();

        }

        private void dtg_Cate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabcategoria_Click(object sender, EventArgs e)
        {

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                if (filtroSub == false)
                {
                    MostrarSubcategorias();
                }
                else
                {
                    MostrarSubcategoriasFiltro(txt_buscar_sub.Text);
                }
            }
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            if (paginaActual < totalPaginas)
            {
                paginaActual++;
                if (filtroSub == false)
                {
                    MostrarSubcategorias();
                }
                else
                {
                    MostrarSubcategoriasFiltro(txt_buscar_sub.Text);
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            MostrarCategoriasFiltro(txt_buscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSubcategoriasFiltro(txt_buscar_sub.Text);
        }

        private void btn_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_buscar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_buscar_sub_KeyDown(object sender, KeyEventArgs e)
        {
            bool ALTGR = e.Control && e.Alt;
            if (
                (e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.C) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete)
                )
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                MostrarSubcategoriasFiltro(txt_buscar_sub.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_buscar_sub_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_buscar_KeyDown(object sender, KeyEventArgs e)
        {
            bool ALTGR = e.Control && e.Alt;
            if (
                (e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.C) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete)
                )
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                MostrarCategoriasFiltro(txt_buscar.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsAsciiLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_buscar_sub_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }

        private void tabDescuentos_Click(object sender, EventArgs e)
        {

        }

        private void MostrarDescuentos()
        {
            CatySubDatos db = new CatySubDatos();
            var descuentos = db.Descuento();
            if (descuentos == null) return;
            txt_descuento.Text = descuentos.ToString();
        }

        private void btn_editarDesc_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txt_descuento.Text))
            {
                MessageBox.Show("El campo de descuento no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!int.TryParse(txt_descuento.Text, out int desc))
            {
                MessageBox.Show("El descuento debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (desc < 0 || desc > 100)
            {
                MessageBox.Show("El descuento debe ser un número entre 0 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Esta seguro de editar el descuento?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes)
            {
                return;
            }
            CatySubDatos db = new CatySubDatos();
            db.ModificarDescuento(desc);
            MostrarDescuentos();
        }

        private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_descuento_KeyDown(object sender, KeyEventArgs e)
        {
            bool ALTGR = e.Control && e.Alt;
            if (
                (e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.C) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete)
                )
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
               btn_editarDesc.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}