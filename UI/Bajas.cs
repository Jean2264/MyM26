using MyM26.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using MyM26.DAL;
using MyM26.BLL;
using System.Text;
using System.Windows.Forms;

namespace MyM26.UI
{
    public partial class Bajas : Form
    {
        public string Modo;
        public Bajas()
        {
            InitializeComponent();
            Conexion.Conectar();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bajas_Load(object sender, EventArgs e)
        {
            if (Modo == "Cliente")
            {
                lbl_title.Text = "Clientes dados de baja";
                bajaCliente();
            }
            if (Modo == "Proveedor")
            {
                lbl_title.Text = "Proveedores dados de baja";
                bajaProv();
            }
            if (Modo == "Usuario")
            {
                lbl_title.Text = "Usuarios dados de baja";
                bajaUser();
            }
            if (Modo == "Articulo")
            {
                lbl_title.Text = "Articulos dados de baja";
                ArtBajas();
            }
            if (Modo == "Empleado")
            {
                lbl_title.Text = "Empleados dados de baja";
                bajaEmpl(); 
            }

        }
        public void bajaProv()
        {
            Decla.bajaProv = ProveedorDatos.BajaProv();
            dataGridView1.DataSource = Decla.bajaProv;
        }
        public void bajaCliente()
        {
            Decla.bajaCli = ClienteDatos.bajaCliente();
            dataGridView1.DataSource = Decla.bajaCli;
        }
        public void bajaUser()
        {
            Decla.bajaUsu = UsuarioDatos.bajaUsuario();
            dataGridView1.DataSource = Decla.bajaUsu;
        }
        public void bajaEmpl()
        {
            Decla.bajaEmpl = EmpleadoDatos.BajaEmpleado();
            dataGridView1.DataSource = Decla.bajaEmpl;
        }

        public void ArtBajas()
        {
            Decla.bajaArt = ArticuloDatos.ARTBajas();
            dataGridView1.DataSource= Decla.bajaArt;
        }
    }
}
