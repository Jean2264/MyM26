using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades.Cliente;
using MyM26.Entidades.Comun;
using MyM26.Entidades.Empleado;
using MyM26.Entidades.Proveedor;
using MyM26.Entidades.Usuario;
using MyM26.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MyM26.screens
{
    public partial class añadirCyP : Form
    {
        public string Modo;
        private string _cuit;
        public ClienteProveedor cl;
        public string cuit;
        public VCliente cliente;

        public añadirCyP(ClienteProveedor Cl)
        {
            InitializeComponent();
            Conexion.Conectar();

            cmb_entidad.Items.Add("Consumidor final");
            cmb_entidad.Items.Add("Empresa");
            cmb_entidad.Items.Add("Mayorista");
            cmb_entidad.SelectedIndex = -1;



            this.cl = Cl;
        }
        public añadirCyP(string cuit)
        {
            InitializeComponent();
            Conexion.Conectar();

            cmb_entidad.Items.Add("Consumidor final");
            cmb_entidad.Items.Add("Empresa");
            cmb_entidad.Items.Add("Mayorista");
            cmb_entidad.SelectedIndex = -1;
            this.cuit = cuit;


        }

        public añadirCyP()
        {
            InitializeComponent();
            Conexion.Conectar();

            cmb_entidad.Items.Add("Consumidor final");
            cmb_entidad.Items.Add("Empresa");
            cmb_entidad.Items.Add("Mayorista");
            cmb_entidad.SelectedIndex = -1;



        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void añadirCyP_Load(object sender, EventArgs e)
        {
            if (Modo == "Alta-Cliente")
            {
                label_title.Text = "Añadir Cliente";
                btn_alta_modi.Text = "Añadir Cliente";
                lbl_EM_EN.Text = "Entidad";
                this.BackgroundImage = Properties.Resources.Rectangle_295;
                this.Height = 301;
                cmb_entidad.Visible = true;
                btn_alta_modi.BackgroundImage = Properties.Resources.verde;
                btn_alta_modi.ForeColor = Color.White;


            }
            else if (Modo == "Alta-Proveedor")
            {
                label_title.Text = "Añadir Proveedor";
                btn_alta_modi.Text = "Añadir Proveedor";
                lbl_EM_EN.Text = "Empresa";
                this.BackgroundImage = Properties.Resources.Rectangle_295;
                this.Height = 301;
                cmb_entidad.Visible = false;
                txt_entidad.Visible = true;
                btn_alta_modi.BackgroundImage = Properties.Resources.verde;
                btn_alta_modi.ForeColor = Color.White;
            }
            else if (Modo == "Editar-Cliente")
            {
                txt_cuit.ReadOnly = true;
                txt_cuit.BackColor = Color.LightGray;
                txt_nombre.BackColor = Color.LightGray;
                txt_nombre.ReadOnly = true;

                label_title.Text = "Editar Cliente";
                btn_alta_modi.Text = "Editar Cliente";
                this.BackgroundImage = Properties.Resources.Rectangle_295;

                cmb_entidad.Visible = true; cmb_entidad.Enabled = true;
                lbl_EM_EN.Text = "Entidad";

                btn_alta_modi.BackgroundImage = Properties.Resources.naranja;
                btn_alta_modi.ForeColor = Color.White;
                cargarCliente();
            }
            else if (Modo == "Editar-Proveedor")
            {
                txt_cuit.BackColor = Color.LightGray;
                lbl_EM_EN.Text = "Empresa";
                txt_nombre.BackColor = Color.LightGray;
                txt_cuit.ReadOnly = true;
                txt_nombre.ReadOnly = true;

                label_title.Text = "Editar Proveedor";
                btn_alta_modi.Text = "Editar Proveedor";
                txt_entidad.Visible = true;
                cmb_entidad.Visible = false;
                btn_alta_modi.BackgroundImage = Properties.Resources.naranja;
                btn_alta_modi.ForeColor = Color.White;
                this.BackgroundImage = Properties.Resources.Rectangle_295;

                cargarProveedor();
            }
            else if (Modo == "Vista-Cliente")
            {
                label_title.Text = "Vista Cliente";
                btn_alta_modi.Visible = false;
                cargarCliente();
                lbl_EM_EN.Text = "Entidad";
                cmb_entidad.Visible = true;
                txt_entidad.Visible = false;
                this.Height = 442;
                panel2.Width = 344;
                panel2.Height = 214;
                panel3.Location = new Point(8, 252);

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ((TextBox)ctrl).ReadOnly = true;
                    }

                }
                cmb_entidad.Enabled = false;
                cmb_entidad.BackColor = Color.White;
            }
            else if (Modo == "Vista-Proveedor")
            {
                label_title.Text = "Vista Proveedor";
                cargarProveedor();
                btn_alta_modi.Visible = false;
                lbl_EM_EN.Text = "Empresa";
                cmb_entidad.Visible = false;
                txt_entidad.Visible = true;
                txt_entidad.Visible = true;
                this.Height = 442;
                panel2.Width = 344;
                panel2.Height = 214;
                panel3.Location = new Point(8, 252);
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ((TextBox)ctrl).ReadOnly = true;
                    }

                }

            }
        }
        //aca no
        private void btn_alta_modi_Click(object sender, EventArgs e)
        {
            if (Modo == "Alta-Cliente")
            {
                errorProvider1.Clear();
                VCliente cliente = new VCliente();

                cliente.Cuit = txt_cuit.Text;
                cliente.Nombre = txt_nombre.Text;
                cliente.Entidad = cmb_entidad.SelectedItem?.ToString();
                cliente.Telefono = txt_telefono.Text;
                cliente.Mail = txt_mail.Text;

                string cuit = txt_cuit.Text.Trim();

                cliente.TipoMovimiento = "Alta de cliente";

                cliente.DetalleMovimiento = "el usuario" + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                ") ha dado de alta a: " + txt_nombre.Text +
                                " (Cuit: " + txt_cuit.Text.Trim() + ")";

                int EstadoCuit = VerificarCuitCliente(cuit);
                ClienteDatos clienteDatos = new ClienteDatos();
                //Existe DNI
                if (EstadoCuit == 1)
                {
                    MessageBox.Show("Ya existe un cliente activo con ese cuit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (EstadoCuit == 0)
                {
                    DialogResult r = MessageBox.Show(
                        "El cliente existe pero está dado de baja.\n¿Desea reactivarlo?",
                        "Reactivar cliente",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {

                        clienteDatos.ReactivarCliente(cuit);
                        MessageBox.Show("Cliente reactivado correctamente.");
                        cl.LlenarDtgClientes();
                        this.Close();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }


                ClienteNegocio clienteNegocio = new ClienteNegocio();
                Resultado resultado = clienteNegocio.ValidarCliente(cliente);
                if (!resultado.EsValido)
                {
                    MostrarErrores(resultado);
                    return;
                }


                clienteDatos.AltaCompletoCliente(cliente);
                clienteDatos.AltaHistoricoCompleto(cliente);
                cl.LlenarDtgClientes();
                this.Close();
            }
            if (Modo == "Editar-Cliente")
            {
                VCliente cliente
                    = new VCliente();
                cliente.Cuit = txt_cuit.Text;
                cliente.Nombre = txt_nombre.Text;
                cliente.Entidad = cmb_entidad.SelectedItem?.ToString();
                cliente.Telefono = txt_telefono.Text;
                cliente.Mail = txt_mail.Text;

                cliente.TipoMovimiento = "Modificación de cliente";

                cliente.DetalleMovimiento = "el usuario" + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                ") ha modificado la información de: " + txt_nombre.Text +
                                " (Cuit: " + txt_cuit.Text.Trim() + ")";

                ClienteNegocio clienteNegocio = new ClienteNegocio();
                Resultado resultado = clienteNegocio.ValidarCliente(cliente);
                if (!resultado.EsValido)
                {

                    MostrarErrores(resultado);
                    return;
                }

                ClienteDatos clienteDatos = new ClienteDatos();
                clienteDatos.ModiCliente(cliente);
                clienteDatos.AltaHistoricoCompleto(cliente);
                cl.LlenarDtgClientes();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }

            if (Modo == "Alta-Proveedor")
            {
                errorProvider1.Clear();
                VProveedor Prov = new VProveedor();
                Prov.Cuit = txt_cuit.Text;
                Prov.Nombre = txt_nombre.Text;
                Prov.Empresa = txt_entidad.Text;
                Prov.Telefono = txt_telefono.Text;
                Prov.Mail = txt_mail.Text;

                string cuit = txt_cuit.Text.Trim();

                Prov.TipoMovimiento = "Alta de proveedor";

                Prov.DetalleMovimiento = "el usuario" + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                ") ha dado de alta a: " + txt_nombre.Text +
                                " (Cuit: " + txt_cuit.Text.Trim() + ")";

                int EstadoCuit = VerificarCuitProveedor(cuit);
                ProveedorDatos proveedorDatos = new ProveedorDatos();
                //Existe DNI
                if (EstadoCuit == 1)
                {
                    MessageBox.Show("Ya existe un proveedor activo con ese cuit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (EstadoCuit == 0)
                {
                    DialogResult r = MessageBox.Show(
                        "El proveedor existe pero está dado de baja.\n¿Desea reactivarlo?",
                        "Reactivarproveedor",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {

                        proveedorDatos.ReactivarProveedor(cuit);
                        MessageBox.Show("Proveedor reactivado correctamente.");
                        cl.LlenarDtgProveedores();
                        this.Close();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }

                ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
                Resultado resultado = proveedorNegocio.ValidarProveedor(Prov);
                if (!resultado.EsValido)
                {
                    MostrarErroresP(resultado);
                    return;
                }



                proveedorDatos.AltaCompletoProveedor(Prov);
                proveedorDatos.AltaHistoricoCompleto(Prov);
                cl.LlenarDtgProveedores();
                this.Close();
            }
            if (Modo == "Editar-Proveedor")
            {
                VProveedor Prov = new VProveedor();
                Prov.Cuit = txt_cuit.Text;
                Prov.Nombre = txt_nombre.Text;
                Prov.Empresa = txt_entidad.Text;
                Prov.Telefono = txt_telefono.Text;
                Prov.Mail = txt_mail.Text;

                Prov.TipoMovimiento = "Modificación de proveedor";

                Prov.DetalleMovimiento = "el usuario" + UsuarioActivo.Datos.NombreAc +
                                " (DNI: " + UsuarioActivo.Datos.DNIAc +
                                ") ha modificado la información de: " + txt_nombre.Text +
                                " (Cuit: " + txt_cuit.Text.Trim() + ")";

                ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
                Resultado resultado = proveedorNegocio.ValidarProveedor(Prov);
                if (!resultado.EsValido)
                {
                    MostrarErroresP(resultado);
                    return;
                }
                ProveedorDatos datos = new ProveedorDatos();
                datos.ModiProveedor(Prov);
                datos.AltaHistoricoCompleto(Prov);
                cl.LlenarDtgProveedores();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        //acano  <=

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        public void MostrarErrores(Resultado resultado)
        {
            foreach (var error in resultado.Errores)
            {
                switch (error.Campo)
                {
                    case "Cuit":
                        errorProvider1.SetError(txt_cuit, error.Mensaje);
                        break;
                    case "Nombre":
                        errorProvider1.SetError(txt_nombre, error.Mensaje);
                        break;
                    case "Entidad":
                        errorProvider1.SetError(cmb_entidad, error.Mensaje);
                        break;
                    case "Telefono":
                        errorProvider1.SetError(txt_telefono, error.Mensaje);
                        break;
                    case "Mail":
                        errorProvider1.SetError(txt_mail, error.Mensaje);
                        break;
                }
            }
        }

        public void MostrarErroresP(Resultado resultado)
        {
            foreach (var error in resultado.Errores)
            {
                switch (error.Campo)
                {
                    case "Cuit":
                        errorProvider1.SetError(txt_cuit, error.Mensaje);
                        break;
                    case "Nombre":
                        errorProvider1.SetError(txt_nombre, error.Mensaje);
                        break;
                    case "Entidad":
                        errorProvider1.SetError(txt_entidad, error.Mensaje);
                        break;
                    case "Telefono":
                        errorProvider1.SetError(txt_telefono, error.Mensaje);
                        break;
                    case "Mail":
                        errorProvider1.SetError(txt_mail, error.Mensaje);
                        break;
                }
            }
        }

        public void cargarCliente()
        {
            ClienteNegocio cliente = new ClienteNegocio();
            VCliente cli = cliente.ObtenerClientePorCuit(cuit);
            cliente.ObtenerResumenCliente(cuit);

            if (cli == null)
            {
                MessageBox.Show("No se encontró el cliente");
                return;
            }

            txt_cuit.Text = cli.Cuit;
            txt_nombre.Text = cli.Nombre;
            cmb_entidad.SelectedItem = cli.Entidad;
            txt_telefono.Text = cli.Telefono;
            txt_mail.Text = cli.Mail;

            lbl_R1.Text = $"Cantidad de Ventas: {cli.CantidadVentas}";
            lbl_R2.Text = $"Total Gastado: {cli.TotalGastado:C}";
            lbl_R3.Text = $"Total Descuento: {cli.TotalDescuento:C}";
            if (cli.UltimaCompra.HasValue)
            {
                lbl_R4.Text = $"Última Compra: {cli.UltimaCompra.Value:d}";
            }
            else
            {
                lbl_R4.Text = "Última Compra: N/A";
            }
        }

        public void cargarProveedor()
        {

            ProveedorNegocio proveedor = new ProveedorNegocio();
            VProveedor prov = proveedor.ObtenerProveedorPorCuit(cuit);
            proveedor.ObtenerResumenProveedor(cuit);
            if (prov == null)
            {
                MessageBox.Show("No se encontró el proveedor");
                return;
            }
            txt_cuit.Text = prov.Cuit;
            txt_nombre.Text = prov.Nombre;
            txt_entidad.Text = prov.Empresa;
            txt_telefono.Text = prov.Telefono;
            txt_mail.Text = prov.Mail;


            lbl_R1.Text = $"Cantidad de Ventas: {prov.CantidadCompras}";
            lbl_R2.Text = $"Total Gastado: {prov.TotalGastado:C}";
            lbl_R3.Text = $"Total Descuento: {prov.TotalDescuento:C}";
            if (prov.UltimaCompra.HasValue)
            {
                lbl_R4.Text = $"Última Compra: {prov.UltimaCompra.Value:d}";
            }
            else
            {
                lbl_R4.Text = "Última Compra: N/A";
            }
        }
        private void lbl_R3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_R4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //VERIFICACION DE EXISTENCIA DE CLIENTE
        public int VerificarCuitCliente(string cuit)
        {
            string consulta = "SELECT Estado FROM Cliente WHERE Cuit = @cuit";

            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@Cuit", cuit);

                conn.Open();
                object resultado = cmd.ExecuteScalar();

                if (resultado == null)
                    return -1; // no existe

                return Convert.ToInt32(resultado); // devuelve 0 o 1
            }
        }

        //VERIFICACION DE EXISTENCIA DE PROVEEDOR

        public int VerificarCuitProveedor(string cuit)
        {
            string consulta = "SELECT Estado FROM Proveedor WHERE Cuit = @cuit";

            using (SqlConnection conn = new SqlConnection(Decla.cnn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@Cuit", cuit);

                conn.Open();
                object resultado = cmd.ExecuteScalar();

                if (resultado == null)
                    return -1; // no existe

                return Convert.ToInt32(resultado); // devuelve 0 o 1
            }
        }

        private void txt_cuit_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_cuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_cuit_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_telefono_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
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

       
    }
}
