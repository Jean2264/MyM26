using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MyM26.DAL;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyM26.UI
{
    public partial class VentaDetalle : Form
    {

        int paginaActual = 1;
        int registrosPorPagina = 37;
        int TotalPaginas = 0;
        public string cd;
        public VentaDetalle(string cod)
        {
            InitializeComponent();
            Conexion.Conectar();
            this.cd = cod;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentaDetalle_Load(object sender, EventArgs e)
        {
           MostrarDetalla(this.cd);
            /*//  dtg_Cate.Columns["CodCategoria"].Visible = false;
            if (Decla.VentaDetTab.Rows.Count > 0)
            {
                string cs = Decla.VentaDetTab.Rows[0]["CodRDetalle"].ToString();
                if (dataGridView1.Columns.Contains("CodRDetalle"))
                {
                    dataGridView1.Columns["CodRDetalle"].Visible = false;
                }

                label1.Text = "DetalleVenta: " + cs;
            }
            else
            {
                label1.Text = "DetalleVenta: No encontrado";
            }*/

        }

        public void MostrarDetalla(string filtro)
        {
            CajaDatos db = new CajaDatos();
            var result= db.MostrarVentaDetalle(paginaActual, registrosPorPagina, filtro);
            label1.Text= $"DetalleVenta: {filtro}";

            if (result == null) return;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.Data;
            TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
            lbl_paginas.Text= $"Página {paginaActual} / {TotalPaginas}";
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguente.Enabled = paginaActual < TotalPaginas;
            label2.Text = $"total items: {result.Total}";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {

        }
    }
}
