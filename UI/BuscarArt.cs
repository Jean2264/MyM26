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
        public string cd;
        public string cb;
        public string nombre;
        public decimal PU;
        public decimal PM;
        public int CM;
        public int stock;
        public int stockkk;
        public byte[] imagen;
        public byte[] img;
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

                img = cj.Imagen;
            }

        }

        public void buscar()
        {
            CajaNegocio negocio = new CajaNegocio();
            VCaja cj = negocio.BuscarAer(caj);
            if (cj != null)
            {

                dtg_caja.Rows.Add(cj.CodigoBarra,cj.codigoArticulo, cj.Nombre, cj.PrecioUnitario, cj.PrecioMayorista, cj.CantidadMinimaMayor, cj.StockDisponible);

                img = cj.Imagen;

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
            cb = dtg_caja.CurrentRow.Cells["CodigoBarra"].Value.ToString();
            nombre = dtg_caja.CurrentRow.Cells["Nombre"].Value.ToString() ;
            PU = Convert.ToDecimal(dtg_caja.CurrentRow.Cells["PrecioUnit"].Value);
            PM = Convert.ToDecimal(dtg_caja.CurrentRow.Cells["PrecioMayor"].Value);
            CM = Convert.ToInt32(dtg_caja.CurrentRow.Cells["CantMinMayor"].Value);
            stock = Convert.ToInt32(dtg_caja.CurrentRow.Cells["Cantidad"].Value);
            cd = dtg_caja.CurrentRow.Cells["CodigoArticulo"].Value.ToString();
            imagen = img;

            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
