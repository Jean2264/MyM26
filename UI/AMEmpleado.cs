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
using System.Text;
using System.Windows.Forms;

namespace MyM26.UI
{
    public partial class AMEmpleado : Form
    {
        public string Modo;
        public string dni;
        public Empleados em;
        public AMEmpleado(Empleados empl)
        {
            InitializeComponent();
            Conexion.Conectar();
            em = empl;

            cmb_seccion.Items.Add("Manteniminto");
            cmb_seccion.Items.Add("Limpieza");
            cmb_seccion.Items.Add("RRHH");
            cmb_seccion.Items.Add("Seguridad");
            cmb_seccion.Items.Add("Encargado");
            cmb_seccion.Items.Add("Repositor");
            cmb_seccion.Items.Add("Cajas");
            cmb_seccion.Items.Add("Sin especificar");
            cmb_seccion.SelectedIndex = -1;
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AMEmpleado_Load(object sender, EventArgs e)
        {
            if (Modo == "Alta")
            {
                button1.Text = "Añadir";
                label_title.Text = "Alta de Empleado";
                button1.ForeColor = Color.White;
                button1.BackgroundImage = Properties.Resources.verde;
            }
            if (Modo == "Editar")
            {
                button1.Text = "Editar";
                txt_dni.ReadOnly = true;
                txt_dni.BackColor = Color.LightGray;
                txt_apellido.ReadOnly = true;
                txt_apellido.BackColor = Color.LightGray;
                txt_nombre.ReadOnly = true;
                txt_nombre.BackColor = Color.LightGray;
                label_title.Text = "Edición de Empleado";
                button1.ForeColor = Color.White;
                button1.BackgroundImage = Properties.Resources.naranja;
                cargarEmpleado();
            }
            if (Modo == "Ver")
            {
                label_title.Text = "Detalle de Empleado";
                button1.Visible = false;
                txt_nombre.ReadOnly = true;
                txt_apellido.ReadOnly = true;
                txt_dni.ReadOnly = true;
                txt_telefono.ReadOnly = true;
                cmb_seccion.Enabled = false;
            }
        }

        private void txt_dni_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_dni_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_dni_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }

        private void txt_apellido_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_apellido_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }

        private void txt_mail_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void txt_mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetterOrDigit(c) && c != '@' && c != '.' && !char.IsControl(c))
            {
                e.Handled = true; // Bloquea cualquier otro carácter
            }

        }

        public void cargarEmpleado()
        {

            EmpleadoNegocio empleado = new EmpleadoNegocio();
            VEmpleado emp = empleado.ObtenerEmpleadoPorCuit(dni);
            if (emp == null)
            {
                MessageBox.Show("No se encontró el empleado");
                return;
            }
            txt_dni.Text = emp.DNI;
            txt_apellido.Text = emp.Apellido;
            txt_nombre.Text = emp.Nombre;
            txt_telefono.Text = emp.Telefono;
            txt_mail.Text = emp.Mail;
            cmb_seccion.SelectedItem = emp.Seccion;

        }
        private void txt_mail_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Modo=="Alta")
            {
               

                errorProvider1.Clear();
                VEmpleado empleado = new VEmpleado();
                empleado.DNI = txt_dni.Text;
                empleado.Apellido = txt_apellido.Text;
                empleado.Nombre = txt_nombre.Text;
                empleado.Telefono = txt_telefono.Text;
                empleado.Mail = txt_mail.Text;
                empleado.Seccion = cmb_seccion.SelectedItem?.ToString();
                empleado.TipoMovimiento = "Alta de empleado";

                empleado.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                ") ha dado de alta a: " + txt_nombre.Text +
                                " (DNI: " + txt_dni.Text.Trim() + ")";

                string dni = txt_dni.Text.Trim();
                int EstadoDni = VerificarCuitEmpleado(dni);
                EmpleadoDatos datos = new EmpleadoDatos();
                //Existe DNI
                if (EstadoDni == 1)
                {
                    MessageBox.Show("Ya existe un empleado activo con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (EstadoDni == 0)
                {
                    DialogResult r = MessageBox.Show(
                        "El empleado existe pero está dado de baja.\n¿Desea reactivarlo?",
                        "Reactivar Empleado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {

                       datos.ReactivarEmpleado(dni);
                        MessageBox.Show("Empleado reactivado correctamente.");
                        em.LlenarDtgEmpleado();
                        this.Close();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }

                EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
               Resultado resultado = empleadoNegocio.ValidarEmpleado(empleado);

               if(!resultado.EsValido)
                {
                    MostrarErrores(resultado);
                    return;
                }

           
                datos.AltaCompletoEmpleado(empleado);
                datos.AltaHistoricoCompleto(empleado);
                em.LlenarDtgEmpleado();
                this.Close();
            }
            if (Modo=="Editar")
            {

                errorProvider1.Clear();
                VEmpleado empleado = new VEmpleado();
                empleado.DNI = txt_dni.Text;
                empleado.Apellido = txt_apellido.Text;
                empleado.Nombre = txt_nombre.Text;
                empleado.Telefono = txt_telefono.Text;
                empleado.Mail = txt_mail.Text;
                empleado.Seccion = cmb_seccion.SelectedItem?.ToString();

                empleado.TipoMovimiento = "modificación de empleado";
                empleado.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                " ) ha modificado la información de: " + txt_nombre.Text +
                                " ( DNI: " + txt_dni.Text.Trim() + ")";

                EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
                Resultado resultado = empleadoNegocio.ValidarEmpleado(empleado);

                if (!resultado.EsValido)
                {
                    MostrarErrores(resultado);
                    return;
                }

                EmpleadoDatos datos = new EmpleadoDatos();
                datos.ModiEmpleado(empleado);
                datos.AltaHistoricoCompleto(empleado);
                em.LlenarDtgEmpleado();
                this.Close();
            }
        }

   
        public void MostrarErrores(Resultado resultado)
        {
            foreach (var error in resultado.Errores)
            {
                switch (error.Campo)
                {
                    case "DNI":
                        errorProvider1.SetError(txt_dni, error.Mensaje);
                        break;
                    case "Apellido":
                        errorProvider1.SetError(txt_apellido, error.Mensaje);
                        break;
                    case "Nombre":
                        errorProvider1.SetError(txt_nombre, error.Mensaje);
                        break;
                    case "Telefono":
                        errorProvider1.SetError(txt_telefono, error.Mensaje);
                        break;
                    case "Mail":
                        errorProvider1.SetError(txt_mail, error.Mensaje);
                        break;
                    case "Seccion":
                        errorProvider1.SetError(cmb_seccion, error.Mensaje);
                        break;
                }
            }
        }

        public int VerificarCuitEmpleado(string dni)
        {
            string consulta = "SELECT Estado FROM Empleado WHERE DNI = @dni";

            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@dni", dni);

                conn.Open();
                object resultado = cmd.ExecuteScalar();

                if (resultado == null)
                    return -1; // no existe

                return Convert.ToInt32(resultado); // devuelve 0 o 1
            }
        }
    }
}
