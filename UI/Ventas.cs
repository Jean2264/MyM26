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
    public partial class Ventas : UserControl
    {
        int paginaActual = 1;
        int registrosPorPagina = 37;
        int TotalPaginas = 0;
        bool filtroActivo = false;
        public Ventas()
        {
            InitializeComponent();

            Conexion.Conectar();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
           MostrasVenta();
        }

        private void MostrasVenta()
        {
            CajaDatos db = new CajaDatos();
            var result = db.MostrarVenta(paginaActual, registrosPorPagina);

            if (result == null) return;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.Data;
            TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
            lbl_paginas.Text= $"Página {paginaActual} / {TotalPaginas}";
            btn_siguente.Enabled = paginaActual < TotalPaginas;
            btn_anterior.Enabled = paginaActual > 1;
            label1.Text = $"Total de ventas: {result.Total}";

            filtroActivo = false;

        }
       
        public void MostrarVentaFiltrada(DateTime fecha)
        {
            CajaDatos db = new CajaDatos();
            var result = db.MostrarVentaFiltro(paginaActual, registrosPorPagina, fecha);
            if (result == null) return;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.Data;
            TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
            lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
            btn_siguente.Enabled = paginaActual < TotalPaginas;
            btn_anterior.Enabled = paginaActual > 1;
            label1.Text = $"Total de ventas: {result.Total}";
            filtroActivo = true;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cod = dataGridView1.CurrentRow.Cells["CodRemito"].Value.ToString();
            VentaDetalle vd = new VentaDetalle(cod);
            vd.StartPosition = FormStartPosition.CenterParent;
            vd.ShowDialog();
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value.Date;
           MostrarVentaFiltrada(fechaSeleccionada);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrasVenta();
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            if (paginaActual < TotalPaginas)
            {
                paginaActual++;
                if(!filtroActivo)
                    MostrasVenta();
                else
                    MostrarVentaFiltrada(dateTimePicker1.Value.Date);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                if(!filtroActivo)
                    MostrasVenta();
                else
                    MostrarVentaFiltrada(dateTimePicker1.Value.Date);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
