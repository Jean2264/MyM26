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
        public Ventas()
        {
            InitializeComponent();

            Conexion.Conectar();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            llenarDTG();
        }

        private void llenarDTG()
        {
            Decla.VentaTab = CajaDatos.MostrarVenta(paginaActual, registrosPorPagina);
            dataGridView1.DataSource = Decla.VentaTab;
            CalcularTotalPaginasVentas();
        }
        private void CalcularTotalPaginasVentas()
        {
            CajaDatos cj = new CajaDatos();
            int totalRegistros = cj.TotalVenta();
            TotalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);



            btn_siguente.Enabled = paginaActual < TotalPaginas;
            btn_anterior.Enabled = paginaActual > 1;
            label1.Text = $"Total de ventas: {totalRegistros}";
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.AllowUserToAddRows && dataGridView1.Rows.Count == 1))
            {
                lbl_paginas.Text = $"Página 0/0";
            }
            else
            {
                lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
            }
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
            Decla.VentaFil = CajaDatos.FiltroVenta(paginaActual, registrosPorPagina, fechaSeleccionada);
            dataGridView1.DataSource = Decla.VentaFil;
            CalcularTotalPaginasVentas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDTG();
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            if (paginaActual < TotalPaginas)
            {
                paginaActual++;
                llenarDTG();
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if(paginaActual>1)
            {
                paginaActual--;
                llenarDTG();
            }
        }
    }
}
