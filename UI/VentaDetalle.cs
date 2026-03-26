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
            Decla.VentaDetTab = CajaDatos.MostrarVentaDetalle(cd);
            dataGridView1.DataSource = Decla.VentaDetTab;
            //  dtg_Cate.Columns["CodCategoria"].Visible = false;
            if(Decla.VentaDetTab.Rows.Count >0)
            {
                string cs = Decla.VentaDetTab.Rows[0]["CodRDetalle"].ToString();
                if(dataGridView1.Columns.Contains("CodRDetalle"))
                {
                    dataGridView1.Columns["CodRDetalle"].Visible = false;
                }
              
                label1.Text = "DetalleVenta: " + cs;
            }
            else
            {
                label1.Text = "DetalleVenta: No encontrado";
            }
          
        }
    }
}
