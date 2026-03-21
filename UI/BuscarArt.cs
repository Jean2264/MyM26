using MyM26.BLL;
using MyM26.Entidades.Caja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MyM26.DAL;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyM26.screens;

namespace MyM26.UI
{
    public partial class BuscarArt : Form
    {
        public string caj;

        public string cb;
        public string nombre;
        public decimal PU;
        public decimal PM;
        public int CM;
        public int stock;
        public byte[] imagen;
        public BuscarArt(string caja)
        {
            InitializeComponent();
            Conexion.Conectar();
            this.caj = caja;
            buscar();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string filtro = txt_buscar.Text;
            CajaNegocio negocio = new CajaNegocio();
            VCaja cj = negocio.BuscarAer(filtro);
            if (cj != null)
            {

                dtg_caja.Rows.Add(cj.CodigoBarra, cj.Nombre, cj.PrecioUnitario, cj.PrecioMayorista, cj.CantidadMinimaMayor, cj.StockDisponible);

                
            }

        }

        public void buscar()
        {
            CajaNegocio negocio = new CajaNegocio();
            VCaja cj = negocio.BuscarAer(caj);
            if (cj != null)
            {

                dtg_caja.Rows.Add(cj.CodigoBarra, cj.Nombre, cj.PrecioUnitario, cj.PrecioMayorista, cj.CantidadMinimaMayor, cj.StockDisponible);

              

            }
        }

        private void dtg_caja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BuscarArt_Load(object sender, EventArgs e)
        {

        }

        private void dtg_caja_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cb = dtg_caja.CurrentRow.Cells["Cantidad"].Value.ToString();
            nombre = dtg_caja.CurrentRow.Cells["Nombre"].Value.ToString() ;
            PU = Convert.ToDecimal(dtg_caja.CurrentRow.Cells["PrecioUnit"]);
            PM = Convert.ToDecimal(dtg_caja.CurrentRow.Cells["PrecioMayor"]);
            CM = Convert.ToInt32(dtg_caja.CurrentRow.Cells["CantMinMayor"]);
            stock = Convert.ToInt32(cj.StockDisponible);
            imagen = cj.Imagen;
        }
    }
}
