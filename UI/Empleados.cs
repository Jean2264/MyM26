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
        string md;
        bool modoFiltro = false;
        string filtro;
        public Empleados()
        {
            InitializeComponent();
            Conexion.Conectar();

            mostrar();
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


        private void btn_siguente_Click(object sender, EventArgs e)
        {
            filtro = txt_buscar.Text;

            if (paginaActual < TotalPaginas)
            {
                paginaActual++;
                if (!modoFiltro)
                {
                    mostrar();
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        buscar(filtro);
                    }

                }
            }

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            filtro = txt_buscar.Text;
            if (paginaActual > 1)
            {
                paginaActual--;
                if (!modoFiltro)
                {
                    mostrar();
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        buscar(filtro);
                    }

                }
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
            mostrar();

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
            buscar(dni);
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

            if (e.KeyCode == Keys.Enter)
            {
                btn_buscar.PerformClick();

                e.Handled = true; e.SuppressKeyPress = true;
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

        // Método mostrar: carga y muestra la página actual de empleados en el DataGridView
        public void mostrar()
        {

            try
            {
                // Crea una instancia de la capa de datos para empleados
                EmpleadoDatos dt = new EmpleadoDatos();
                // Llama a GetEmpleado pasando la página actual y el número de registros por página
                var result = dt.GetEmpleado(paginaActual, registrosPorPagina);

                // Si no hay resultado, salir del método
                if (result == null) return;

                // Limpia el origen de datos del DataGridView antes de asignar uno nuevo
                dataGridView1.DataSource = null;
                // Asigna la lista de datos obtenida al DataSource del DataGridView
                dataGridView1.DataSource = result.Data;

                // Calcula el número total de páginas redondeando hacia arriba
                TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);

                // Actualiza la etiqueta que muestra la página actual y el total de páginas
                lbl_paginas.Text = $"Página  {paginaActual} / {TotalPaginas}";

                // Habilita o deshabilita el botón anterior dependiendo si no estamos en la primera página
                btn_anterior.Enabled = paginaActual > 1;
                // Habilita o deshabilita el botón siguiente dependiendo si no estamos en la última página
                btn_siguente.Enabled = paginaActual < TotalPaginas;

                // Actualiza la etiqueta que muestra el total de registros devueltos
                label1.Text = $"Total registros: {result.Total}";
                // Marca que actualmente no se está usando un filtro (modo lista completa)
                modoFiltro = false;


            }
            catch (Exception ex)
            {
                // Muestra un mensaje con el error en caso de excepción
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void buscar(string filtro)
        {

            try
            {
                EmpleadoDatos dt = new EmpleadoDatos();
                var result = dt.GetFiltroEmpleado(paginaActual, registrosPorPagina, filtro);

                if (result.Total == 0)
                {
                    mostrar();
                    MessageBox.Show("no se encontro ningun registro con esa descripción.");
                    return;
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = result.Data;

                TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);

                lbl_paginas.Text = $"Página  {paginaActual} / {TotalPaginas}";

                btn_anterior.Enabled = paginaActual > 1;
                btn_siguente.Enabled = paginaActual < TotalPaginas;

                label1.Text = $"Total filtrado: {result.Total}";

                modoFiltro = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
