using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MyM26.Entidades.Usuario;
using MyM26.Entidades.Home;
using MyM26.DAL;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyM26.UI
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            Conexion.Conectar();
            mostrarDatos();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        public void mostrarDatos()
        {
            HomeDatos dt= new HomeDatos();
            VHome hm = new VHome();
            dt.cargarDatosHome(hm);

            lblCaja.Text = hm.caja + " Registros.";
            lblVenta.Text = hm.venta + " Registros.";
            lblCompra.Text = hm.compra + " Registros.";
            lblArticulo.Text = hm.articulo + " Registros.";
            lblProveedor.Text = hm.proveedor + " Registros.";
            lblCliente.Text = hm.cliente + " Registros.";
            lblUsuario.Text = hm.usuario + " Registros.";
            lblEmpleado.Text = hm.empleado + " Registros.";

        }
    }
}
