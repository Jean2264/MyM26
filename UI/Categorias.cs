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
        public Categorias()
        {
            InitializeComponent();
            Conexion.Conectar();
            llenarCat();
            CalcularTotalPaginasCategorias();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {

        }
        //Para categoria
        public void llenarCat()
        {
            Decla.CatTab = CatySubDatos.TraerCat(paginaActual, registrosPorPagina);
            dtg_Cate.DataSource = Decla.CatTab;
            dtg_Cate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Cate.Columns["CodCategoria"].Visible = false;
            CalcularTotalPaginasCategorias();
        }
        //Para categoria
        public void CalcularTotalPaginasCategorias()
        {
            CatySubDatos dta = new CatySubDatos();
            int totalRegistros = dta.ObtenerTotalCategorias();
            totalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);

            if (paginaActual == totalPaginas)
            {
                btn_sig_cat.Enabled = false;
            }
            else if ( paginaActual< totalRegistros)
            {
                btn_sig_cat.Enabled = true;
            }


            if (dtg_Cate.Rows.Count == 0 || (dtg_Cate.AllowUserToAddRows && dtg_Cate.Rows.Count == 1))
            {
                lbl_pag_cat.Text = $"Página 0/0";
            }
            else
            {
                lbl_pag_cat.Text = $"Página {paginaActual} / {totalPaginas}";
            }
            lbl_total_cat.Text = $"Total de categorías: {totalRegistros}";
        }
        //Para categoria
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
            llenarCat();
            CalcularTotalPaginasCategorias();
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
            llenarSubcat();
            CalcularTotalPaginasSubcategorias();
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
                CatySubDatos.TraerCat(paginaActual, registrosPorPagina);
            }
        }
        //Para categoria
        private void btn_sig_cat_Click(object sender, EventArgs e)
        {
            paginaActual++;
            CatySubDatos.TraerCat(paginaActual, registrosPorPagina);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabcategoria)
            {
                llenarCat();
                CalcularTotalPaginasCategorias();
            }
            else if (tabControl1.SelectedTab == tabSub)
            {
                llenarSubcat();
                CalcularTotalPaginasSubcategorias();
                cmb_cate.DataSource = CatySubDatos.MostrarCategoriaBox();
                cmb_cate.DisplayMember = "Categoria";
                cmb_cate.ValueMember = "CodCategoria";
                cmb_cate.SelectedIndex = -1;
            }
        }

        //PARA SUBCATEGORIA 
        public void llenarSubcat()
        {
            Decla.SubCatTab = CatySubDatos.TraerSubcat(paginaActual, registrosPorPagina);
            dtg_Subcate.DataSource = Decla.SubCatTab;
            dtg_Subcate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Subcate.Columns["CodSubcategoria"].Visible = false;
            CalcularTotalPaginasSubcategorias();
        }

        public void CalcularTotalPaginasSubcategorias()
        {
            CatySubDatos dta = new CatySubDatos();
            int totalRegistros = dta.ObtenerTotalSubcategorias();
            totalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);

            if (paginaActual == totalPaginas)
            {
                btn_siguente.Enabled = false;
            }
            else if (paginaActual< totalRegistros)
            {
                btn_siguente.Enabled = true;
            }


            if (dtg_Subcate.Rows.Count == 0 || (dtg_Subcate.AllowUserToAddRows && dtg_Subcate.Rows.Count == 1))
            {
                lbl_paginas.Text = $"Página 0/0";
            }
            else
            {
                lbl_paginas.Text = $"Página {paginaActual} / {totalPaginas}";
            }
            lbl_total.Text = $"Total de subcategorías: {totalRegistros}";
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

            llenarSubcat();
            CalcularTotalPaginasSubcategorias();
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


            llenarCat();
            CalcularTotalPaginasCategorias();
        }

        private void dtg_Cate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
