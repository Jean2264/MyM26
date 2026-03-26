using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Empleado;
using MyM26.Entidades.Usuario;
using MyM26.Querys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyM26.UI
{
    public partial class Empleados : UserControl
    {
        int paginaActual = 1;
        int registrosPorPagina = 50;
        int TotalPaginas = 0;
        string cda2 = "";
        string nombre = "";
        public Empleados()
        {
            InitializeComponent();
            Conexion.Conectar();
            CalcularTotalPaginasEmpleados();
            LlenarDtgEmpleado();
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            AMEmpleado empleado = new AMEmpleado(this);
            empleado.StartPosition = FormStartPosition.CenterParent;
            empleado.Modo = "Alta";
            empleado.ShowDialog();

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                cda2 = dataGridView1.CurrentRow.Cells["DNI"].Value.ToString();


            }
            AMEmpleado empleado = new AMEmpleado(this);
            empleado.dni = cda2;
            empleado.Modo = "Editar";
            empleado.StartPosition = FormStartPosition.CenterParent;
            empleado.ShowDialog();
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            AMEmpleado empleado = new AMEmpleado(this);
            empleado.StartPosition = FormStartPosition.CenterParent;
            empleado.Modo = "Ver";
            empleado.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cda2 = dataGridView1.CurrentRow.Cells["DNI"].Value.ToString();
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        public void LlenarDtgEmpleado()
        {
            Decla.EmpleadoTab = EmpleadoDatos.LLenarDtgEmpleado(paginaActual, registrosPorPagina);

            dataGridView1.DataSource = Decla.EmpleadoTab;

        }
        private void CalcularTotalPaginasEmpleados()
        {
            EmpleadoDatos db = new EmpleadoDatos();
            int totalRegistros = db.ObtenerTotalEmpleados();
            TotalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);



            if (paginaActual == totalRegistros)
            {
                btn_siguente.Enabled = false;
            }
            else if (paginaActual < totalRegistros)
            {
                btn_siguente.Enabled = true;
            }
            label1.Text = $"Total de clientes: {totalRegistros}";
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.AllowUserToAddRows && dataGridView1.Rows.Count == 1))
            {
                lbl_paginas.Text = $"Página 0/0";
            }
            else
            {
                lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
            }
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            paginaActual++;
            EmpleadoDatos.LLenarDtgEmpleado(paginaActual, registrosPorPagina);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                EmpleadoDatos.LLenarDtgEmpleado(paginaActual, registrosPorPagina);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                cda2 = dataGridView1.CurrentRow.Cells["DNI"].Value.ToString();


            }
            AMEmpleado empleado = new AMEmpleado(this);
            empleado.dni = cda2;
            empleado.Modo = "Editar";
            empleado.StartPosition = FormStartPosition.CenterParent;
            empleado.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado();
        }

        public void EliminarEmpleado()
        {
            if (dataGridView1.CurrentRow != null)
            {
                cda2 = dataGridView1.CurrentRow.Cells["DNI"].Value.ToString();
                nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString() + " " + dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
            }
            DialogResult reasultado = MessageBox.Show("¿Esta seguro de eliminar a este empleado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reasultado != DialogResult.Yes)
                return;

            EmpleadoNegocio nego = new EmpleadoNegocio();
            VEmpleado empleado = nego.EliminarEmpleado(cda2);
            if (empleado == null) empleado = new VEmpleado { DNI = cda2 };

            if (UsuarioActivo.Datos == null)
            {
                MessageBox.Show("Sesión expirada");
                return;
            }

            empleado.TipoMovimiento = "Baja de empleado";
            empleado.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                            " (DNI: " + UsuarioActivo.Datos.DNIAc +
                            " ) ha dado de baja a: " + nombre +
                            " ( DNI: " + cda2 + ")";
            EmpleadoDatos datos = new EmpleadoDatos();
            datos.AltaHistoricoCompleto(empleado);
            LlenarDtgEmpleado();

        }

        private void btn_bajas_Click(object sender, EventArgs e)
        {
            Bajas b = new Bajas();
            b.StartPosition = FormStartPosition.CenterParent;
            b.Modo = "Empleado";
            b.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string dni = txt_buscar.Text;
            BuscarEmpl(dni);
        }

        public void BuscarEmpl(string dni)
        {
            dataGridView1.DataSource = EmpleadoDatos.FiltrarEmpl(dni);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_buscar_KeyDown(object sender, KeyEventArgs e)
        {
            bool isALtgr = e.Control && e.Alt;
            if ((e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

            //bloquear ALtGr + Q
            if (e.Control && e.Alt && e.KeyCode == Keys.Q)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_buscar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
