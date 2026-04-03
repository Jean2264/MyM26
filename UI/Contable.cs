using MyM26.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyM26.UI
{
    public partial class Contable : UserControl
    {
        public Contable()
        {
            InitializeComponent();
            Conexion.Conectar();
        }

        private void Contable_Load(object sender, EventArgs e)
        {

            DataTable datos = ContableDatos.ObtenerVentasPorMes();
            MostrarResumenVenta(datos);
            ActualizarGraficoVentas(datos);
        }


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


        public void ActualizarGraficoVentas(DataTable dato)
        {
            var chart = chart3;
            var serie = chart.Series["Ventas"];

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

           //Nombres de los meses
            string[] meses = { "", "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ags", "Sep", "Oct", "Nov", "Dic" };

            area.AxisX.LabelStyle.Interval = 1;
            area.AxisX.LabelStyle.Enabled = true;

            chart.Series["Ventas"].Points.Clear();

            for (int i = 1; i <= 12; i++)
            {
                int index = serie.Points.AddXY(i, valores[i - 1]);
                serie.Points[index].AxisLabel = meses[i];
            }

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            chart.Invalidate();
        }
    }
}
