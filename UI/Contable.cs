using MyM26.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyM26.UI
{
    public partial class Contable : UserControl
    {
        int paginaActual = 1;
        int registrosPorPagina = 20;
        int TotalPaginas = 0;
        string modo;
        public Contable()
        {
            InitializeComponent();
            Conexion.Conectar();
        }

        private void Contable_Load(object sender, EventArgs e)
        {
            CargarEstadisticasSemanales();
            CargarMontoVentasSemanales();
            CargarCantidadVentasPorMes();
            DataTable datos = ContableDatos.ObtenerVentasPorMes();
            MostrarResumenVenta(datos);
            ActualizarGraficoVentas(datos);
            modo = "mov";
            MostrarMov();
            CalcularTotalPaginasMovimientos();
            btn_movi.BackColor = Color.FromArgb(10, 40, 150);
            btn_sal.BackColor = Color.FromArgb(10, 70, 150);

            cmb_export.Items.Add("Exportar a Excel");
            cmb_export.Items.Add("Exportar a PDF");

            cmb_filtrar.Items.Add("Todos");
            cmb_filtrar.Items.Add("Usuario");
            cmb_filtrar.Items.Add("Articulo");
            cmb_filtrar.Items.Add("Venta");
            cmb_filtrar.Items.Add("Compra");
            cmb_filtrar.Items.Add("Cliente");
            cmb_filtrar.Items.Add("Proveedor");
            cmb_filtrar.Items.Add("Empleado");
            cmb_filtrar.SelectedIndex = -1;

            Tdesde.Checked = false;
            Thasta.Checked = false;
        }





        /// <summary>
        /// /Resumen semanal
        /// </summary>
        //Cart2
        public void CargarEstadisticasSemanales()
        {
            DataTable datos = ContableDatos.ObtenerVentasSemana();

            var chart = chart2;
            var serie = chart.Series["Cantidad-Semanal"];

            serie.Points.Clear();
            serie.ChartType = SeriesChartType.Column;

            serie.IsXValueIndexed = true;

            int maxSemanas = 4;
            int[] valores = new int[maxSemanas];

            // Labels
            Label[] labelsSemanas = { lblS1, lblS2, lblS3, lblS4 };

            // Inicializar labels
            for (int i = 0; i < labelsSemanas.Length; i++)
            {
                if (labelsSemanas[i] != null)
                    labelsSemanas[i].Text = $"Sem {i + 1}: 0 ventas";
            }

            // Cargar datos reales
            if (datos != null)
            {
                for (int i = 0; i < datos.Rows.Count && i < maxSemanas; i++)
                {
                    int cantidad = Convert.ToInt32(datos.Rows[i]["CantidadVentas"]);
                    valores[i] = cantidad;

                    if (labelsSemanas[i] != null)
                        labelsSemanas[i].Text = $"Sem {i + 1}: {cantidad} ventas";
                }
            }

            //creo los puntos numerico
            for (int i = 1; i <= maxSemanas; i++)
            {
                int index = serie.Points.AddXY(i, valores[i - 1]);
                serie.Points[index].AxisLabel = "Sem " + i;
            }

            var area = chart.ChartAreas[0];

            area.AxisX.Minimum = 0.5;
            area.AxisX.Maximum = maxSemanas + 0.5;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.IsMarginVisible = true;

            area.AxisY.Interval = 1;
            area.AxisY.Minimum = 0;
            chart.Invalidate();
        }


        //chart4
        public void CargarMontoVentasSemanales()
        {
            DataTable datos = ContableDatos.ObtenerTotalVentasSemana();

            var chart = chart4;
            var serie = chart.Series["Monto-Semanal"];

            serie.Points.Clear();
            serie.ChartType = SeriesChartType.Column;
            serie.IsXValueIndexed = true;


            int maxSemanas = 4;
            double[] valores = new double[maxSemanas];

            string[] nombres = { "Sem 1", "Sem 2", "Sem 3", "Sem 4" };

            Label[] labels = { lblTS1, lblTS2, lblTS3, lblTS4 };

            //inicializzo los labels
            for (int i = 0; i < maxSemanas; i++)
            {
                if (labels[i] != null)
                    labels[i].Text = $"{nombres[i]}: $ 0.00";
            }

            //cargo datos reales
            if (datos != null)
            {
                int indexSemana = 0;

                foreach (DataRow row in datos.Rows)
                {
                    if (indexSemana >= maxSemanas) break;

                    double total = Convert.ToDouble(row["TotalVentas"]);
                    valores[indexSemana] = total;

                    if (labels[indexSemana] != null)
                    {
                        labels[indexSemana].Text = $"{nombres[indexSemana]}: {total.ToString("C2")}";
                    }

                    indexSemana++;
                }
            }

            // Creao puntos
            for (int i = 1; i <= maxSemanas; i++)
            {
                int index = serie.Points.AddXY(i, valores[i - 1]);
                serie.Points[index].AxisLabel = nombres[i - 1];
            }

            var area = chart.ChartAreas[0];

            area.AxisX.Minimum = 0.5;
            area.AxisX.Maximum = maxSemanas + 0.5;
            area.AxisX.Interval = 1;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            chart.Invalidate();
        }


        /// 
        /// Resumen Anual
        /// 
        //Cart1
        public void CargarCantidadVentasPorMes()
        {
            DataTable dt = ContableDatos.ObtenerCantidadVentasPorMes();

            var chart = chart1;
            var serie = chart.Series["Cantidad Por Mes"];
            serie.Points.Clear();
            serie.ChartType = SeriesChartType.Column;

            serie.IsXValueIndexed = true;
            int maxMeses = 12;
            int[] valores = new int[maxMeses];

            Dictionary<int, Label> mapaLabelsCS = new Dictionary<int, Label>()
                {
                      { 1, lblCS1 }, { 2, lblCS2 }, { 3, lblCS3 }, { 4, lblCS4 },
                      { 5, lblCS5 }, { 6, lblCS6 }, { 7, lblCS7 }, { 8, lblCS8 },
                      { 9, lblCS9 }, { 10, lblCS10 }, { 11, lblCS11 }, { 12, lblCS12 }
                };
            string[] nombresMeses = { "", "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ags", "Sep", "Oct", "Nov", "Dic" };

            //inicializo los label
            foreach (var item in mapaLabelsCS)
            {
                int mes = item.Key;
                if (item.Value != null)
                    item.Value.Text = $"{nombresMeses[mes]}: 0 ventas";
            }



            //cargo los datos reales

            foreach (DataRow row in dt.Rows)
            {
                int mes = Convert.ToInt32(row["Mes"]);
                int cantidad = Convert.ToInt32(row["CantVenta"]);

                if (mapaLabelsCS.ContainsKey(mes))
                {
                    mapaLabelsCS[mes].Text = $"{nombresMeses[mes]}: {cantidad} ventas";
                }

                if (mes >= 1 && mes <= 12)
                {
                    valores[mes - 1] = cantidad;
                }

            }
            //creo los puntos numericos


            var area = chart.ChartAreas[0];

            area.AxisX.Minimum = 0.5;
            area.AxisX.Maximum = 12.5;
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            area.AxisX.LabelStyle.Interval = 1;
            area.AxisX.LabelStyle.Enabled = true;



            for (int i = 1; i <= 12; i++)
            {
                int index = serie.Points.AddXY(i, valores[i - 1]);
                serie.Points[index].AxisLabel = nombresMeses[i];


            }

            chart.Invalidate();

        }




        //cahrt3
        public void MostrarResumenVenta(DataTable dato)
        {
            Dictionary<int, Label> mapaLabels = new Dictionary<int, Label>()
              {
                 { 1, lblEne }, { 2, lblFeb }, { 3, lblMar }, { 4, lblAbr },
                 { 5, lblMay }, { 6, lblJn}, { 7, lblJl }, { 8, lblAg },
                 { 9, lblSep }, { 10, lblOct }, { 11, lblNov }, { 12, lblDic }
               };

            string[] nombresMeses = { "", "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ags", "Sep", "Oct", "Nov", "Dic" };

            // inicializo los labels con el mes + $0.00
            foreach (var item in mapaLabels)
            {
                int mes = item.Key;
                item.Value.Text = $"{nombresMeses[mes]}: $ 0.00";
            }

            // Cargar datos reales
            foreach (DataRow row in dato.Rows)
            {
                int mes = Convert.ToInt32(row["Mes"]);
                decimal total = Convert.ToDecimal(row["TotalVenta"]);

                if (mapaLabels.ContainsKey(mes))
                {
                    mapaLabels[mes].Text = $"{nombresMeses[mes]}: {total.ToString("C2")}";
                }
            }
        }

        //chart3
        public void ActualizarGraficoVentas(DataTable dato)
        {
            var chart = chart3;
            var serie = chart.Series["Total Por Mes"];

            serie.Points.Clear();
            serie.ChartType = SeriesChartType.Column;
            serie.IsXValueIndexed = true;

            double[] valores = new double[12];

            // Cargar datos reales
            if (dato != null)
            {
                foreach (DataRow row in dato.Rows)
                {
                    int mes = Convert.ToInt32(row["Mes"]);
                    decimal total = Convert.ToDecimal(row["TotalVenta"]);

                    if (mes >= 1 && mes <= 12)
                        valores[mes - 1] = (double)total;
                }
            }

            // Crear puntos numericos
            for (int i = 1; i <= 12; i++)
            {
                serie.Points.AddXY(i, valores[i - 1]);
            }

            var area = chart.ChartAreas[0];


            area.AxisX.Minimum = 1;
            area.AxisX.Maximum = 12;
            area.AxisX.Interval = 1;
            area.AxisX.Minimum = 0.5;
            area.AxisX.Maximum = 12.5;

            //Nombres de los meses
            string[] meses = { "", "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ags", "Sep", "Oct", "Nov", "Dic" };

            area.AxisX.LabelStyle.Interval = 1;
            area.AxisX.LabelStyle.Enabled = true;

            chart.Series["Total Por Mes"].Points.Clear();

            for (int i = 1; i <= 12; i++)
            {
                int index = serie.Points.AddXY(i, valores[i - 1]);
                serie.Points[index].AxisLabel = meses[i];
            }

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            chart.Invalidate();
        }





        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void MostrarMov()

        {
            dataGridView1.DataSource = null;
            Decla.MovTab = ContableDatos.HMovimientos(paginaActual, registrosPorPagina);
            dataGridView1.DataSource = Decla.MovTab;
            CalcularTotalPaginasMovimientos();
        }


        /* private void CalcularTotalPaginasProv()
        {
            ProveedorDatos db = new ProveedorDatos();
            int totalRegistros = db.ObtenerTotalProveedor();
            TotalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);
            lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
           
            btn_siguente.Enabled = paginaActual < TotalPaginas;
            btn_anterior.Enabled = paginaActual > 1;
            label1.Text = $"Total de proveedores: {totalRegistros}";
        }*/
        private void CalcularTotalPaginasMovimientos()
        {
            ContableDatos db = new ContableDatos();
            int totalRegistros = db.ObtenerTotalMovimiento();
            TotalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);
            btn_siguente.Enabled = paginaActual < TotalPaginas;
            btn_anterior.Enabled = paginaActual > 1;

            label1.Text = $"Total de movimientos: {totalRegistros}";
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.AllowUserToAddRows && dataGridView1.Rows.Count == 1))
            {
                lbl_paginas.Text = $"Página 0/0";
            }
            else
            {
                lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
            }
        }
        public void MostrarSal()
        {
            dataGridView1.DataSource = null;
            Decla.SalTab = ContableDatos.Salidas(paginaActual, registrosPorPagina);
            dataGridView1.DataSource = Decla.SalTab;
            CalcularTotalPaginasSalidas();
        }


        private void CalcularTotalPaginasSalidas()
        {
            ContableDatos db = new ContableDatos();
            int totalRegistros = db.ObtenerTotalSalidas();
            TotalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);

            btn_siguente.Enabled = paginaActual < TotalPaginas;
            btn_anterior.Enabled = paginaActual > 1;
            label1.Text = $"Total de salidas: {totalRegistros}";
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.AllowUserToAddRows && dataGridView1.Rows.Count == 1))
            {
                lbl_paginas.Text = $"Página 0/0";
            }
            else
            {
                lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
            }
        }

        private void btn_movi_Click(object sender, EventArgs e)
        {
            modo = "mov";
            MostrarMov();
            CalcularTotalPaginasMovimientos();
            btn_movi.BackColor = Color.FromArgb(10, 40, 150);
            btn_sal.BackColor = Color.FromArgb(10, 70, 150);
        }

        private void btn_sal_Click(object sender, EventArgs e)
        {
            modo = "sal";
            MostrarSal();
            CalcularTotalPaginasSalidas();
            btn_sal.BackColor = Color.FromArgb(10, 40, 150);
            btn_movi.BackColor = Color.FromArgb(10, 70, 150);
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {

            /*  if (Modal == "Clientes")
            {

               if(paginaActual < TotalPaginas)
                {
                    paginaActual++;
                    LlenarDtgClientes();
                }
               else if(Modal== "Proveedor")
               {
                   if(paginaActual < TotalPaginas)
                   {
                       paginaActual++;
                       LlenarDtgProveedores();
                   }
               }

            }*/
            if (modo == "mov")
            {
                if (paginaActual < TotalPaginas)
                {
                    paginaActual++;
                    MostrarMov();

                }
            }
            else if (modo == "sal")
            {
                if (paginaActual < TotalPaginas)
                {
                    paginaActual++;
                    MostrarSal();

                }
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (modo == "mov")
            {
                if (paginaActual > 1)
                {
                    paginaActual--;
                    MostrarMov();

                }
            }
            else if (modo == "sal")
            {
                if (paginaActual > 1)
                {
                    paginaActual--;
                    MostrarSal();

                }
            }
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (modo == "mov")
            {
                string categoria = cmb_filtrar.Text;
                DateTime? desde = Tdesde.Checked ? Tdesde.Value.Date : (DateTime?)null;
                DateTime? hasta = Thasta.Checked ? Thasta.Value.Date.AddDays(1).AddSeconds(-1) : (DateTime?)null;

                //validamos antes de llamar al DAL
                if (desde != null && hasta != null && desde > hasta)
                {
                    MessageBox.Show("La fecha Desde no puede mayor que hasta");
                    return;
                }
                DataTable dt = ContableDatos.FiltrarMvimiento(categoria, desde, hasta);
                dataGridView1.DataSource = dt;
            }
        }

        private void tableLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tdesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_reinicirDTG_Click(object sender, EventArgs e)
        {
            if(modo== "mov")
            {
                MostrarMov();
            }
            else if(modo=="sal")
            {
                MostrarSal();
            }
        }
    }
}
