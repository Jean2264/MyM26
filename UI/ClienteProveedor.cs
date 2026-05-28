using MyM26.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using MyM26.Entidades.Usuario;
using System.Windows.Forms;
using MyM26.Entidades.Cliente;
using MyM26.BLL;
using MyM26.UI;
using MyM26.Entidades.Proveedor;

namespace MyM26.screens
{
    public partial class ClienteProveedor : UserControl
    {
        public string Modal;
        public string cda2;
        public string nombre;
        public string m;

        bool filtroCliente = false;
        bool filtroProveedor = false;
        int paginaActual = 1;
        int registrosPorPagina = 50;
        int TotalPaginas = 0;
        public event Action<string> EditarCliente;
        public ClienteProveedor()
        {
            InitializeComponent();

            Conexion.Conectar();
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_ver.Enabled = false;

        }

        private void ClienteProveedor_Load(object sender, EventArgs e)
        {
            if (Modal == "Clientes")
            {
                btn_añadir.Text = "Añadir Cliente";
                btn_editar.Text = "Editar Cliente";
                btn_eliminar.Text = "Eliminar Cliente";
                btn_ver.Text = "Ver vista";
                btn_bajas.Text = "Ver bajas";
                MostrarCliente();
            }
            if (Modal == "Proveedor")
            {
                btn_añadir.Text = "Añadir Proveedor";
                btn_editar.Text = "Editar Proveedor";
                btn_eliminar.Text = "Eliminar Proveedor";
                btn_ver.Text = "Ver vista";
                btn_bajas.Text = "Ver bajas";

                mostrarProveedor();

            }
        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            if (Modal == "Clientes")
            {
                añadirCyP ac = new añadirCyP(this);
                ac.Modo = "Alta-Cliente";
                ac.StartPosition = FormStartPosition.CenterParent;
                ac.ShowDialog();
            }
            else if (Modal == "Proveedor")
            {
                añadirCyP ac = new añadirCyP(this);
                ac.Modo = "Alta-Proveedor";
                ac.StartPosition = FormStartPosition.CenterParent;
                ac.ShowDialog();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (Modal == "Clientes")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    cda2 = dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString();


                }
                añadirCyP añ = new añadirCyP(this);
                añ.cuit = cda2;
                añ.Modo = "Editar-Cliente";
                añ.StartPosition = FormStartPosition.CenterParent;
                añ.ShowDialog();

            }
            else if (Modal == "Proveedor")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    cda2 = dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString();


                }
                añadirCyP ac = new añadirCyP(this);
                ac.cuit = cda2;
                ac.Modo = "Editar-Proveedor";
                ac.StartPosition = FormStartPosition.CenterParent;
                ac.ShowDialog();
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            if (Modal == "Clientes")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    cda2 = dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString();


                }
                añadirCyP añ = new añadirCyP(this);
                añ.cuit = cda2;
                añ.Modo = "Vista-Cliente";
                añ.StartPosition = FormStartPosition.CenterParent;
                añ.ShowDialog();
            }
            else if (Modal == "Proveedor")
            {
                if (dataGridView1.CurrentRow != null)
                {
                    cda2 = dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString();


                }
                añadirCyP ac = new añadirCyP(this);
                ac.cuit = cda2;
                ac.Modo = "Vista-Proveedor";
                ac.StartPosition = FormStartPosition.CenterParent;
                ac.ShowDialog();
            }
        }

        //CLIENTES
        public void MostrarCliente()
        {
            ClienteDatos db= new ClienteDatos();
            var result = db.MostrarCliente(paginaActual, registrosPorPagina);

            if (result == null) return;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.Data;
            TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
            lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguente.Enabled = paginaActual < TotalPaginas;
            label1.Text = $"Total registros: {result.Total}";
            filtroCliente = false;
        }

        public void MostrarClienteFiltro(string cuit)
        {
            ClienteDatos db = new ClienteDatos();
            var result = db.MostrarClienteFiltro(paginaActual, registrosPorPagina, cuit);
            if (result.Total == 0)
            {
                MostrarCliente();
                MessageBox.Show("No se encontraron resultados para el filtro ingresado.");
                return;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.Data;
            TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
            lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguente.Enabled = paginaActual < TotalPaginas;
            label1.Text = $"Total registros: {result.Total}";
            filtroCliente = true;
        }


        //PROVEEDORES
        public void MostrarProveedor()
        {
            ProveedorDatos db = new ProveedorDatos();
            var result = db.GetProveedor(paginaActual, registrosPorPagina);
            if (result == null) return;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.Data;
            TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
            lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguente.Enabled = paginaActual < TotalPaginas;
            label1.Text = $"Total registros: {result.Total}";
            filtroProveedor = false;
        }

        public void MostrarProveedorFiltro(string cuit)
        {
            ProveedorDatos db = new ProveedorDatos();
            var result = db.GetProveedorFiltro(paginaActual, registrosPorPagina, cuit);
            if (result.Total == 0)
            {
                MostrarProveedor();
                MessageBox.Show("No se encontraron resultados para el filtro ingresado.");
                return;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result.Data;
            TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
            lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
            btn_anterior.Enabled = paginaActual > 1;
            btn_siguente.Enabled = paginaActual < TotalPaginas;
            label1.Text = $"Total registros: {result.Total}";
            filtroProveedor = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_ver.Enabled = true;
            cda2 = dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            btn_eliminar.Enabled = true;
            btn_editar.Enabled = true;
            if (dataGridView1.CurrentRow != null)
            {
                cda2 = dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString();


            }
            if (Modal == "Clientes")
            {
                añadirCyP añ = new añadirCyP(this);
                añ.cuit = cda2;
                añ.Modo = "Editar-Cliente";
                añ.StartPosition = FormStartPosition.CenterParent;
                añ.ShowDialog();
            }
            if (Modal == "Proveedor")
            {
                añadirCyP añ = new añadirCyP(this);
                añ.cuit = cda2;
                añ.Modo = "Editar-Proveedor";
                añ.StartPosition = FormStartPosition.CenterParent;
                añ.ShowDialog();
            }



        }

        public void ElimianrCliente()
        {
            if (dataGridView1.CurrentRow != null)
            {
                cda2 = dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString();
                nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            DialogResult resultado = MessageBox.Show("¿Esta seguro de eliminar a este cliente?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes)
                return;

            ClienteNegocio cn = new ClienteNegocio();
            VCliente cliente = cn.eliminarCliente(cda2);


            if (cliente == null) cliente = new VCliente { Cuit = cda2 };
            if (UsuarioActivo.Datos == null)
            {
                MessageBox.Show("Sesión expirada");
                return;
            }
            cliente.TipoMovimiento = "Baja de cliente";
            cliente.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                            " (DNI: " + UsuarioActivo.Datos.DNIAc +
                            " ) ha dado de baja a: " + nombre +
                            " ( CUIT: " + cda2 + ")";
            ClienteDatos datos = new ClienteDatos();
            datos.AltaHistoricoCompleto(cliente);
           MostrarCliente();
        }

        public void EliminarProveedor()
        {
            if (dataGridView1.CurrentRow != null)
            {
                cda2 = dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString();
                nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            DialogResult resultado = MessageBox.Show("¿Esta seguro de eliminar a este Proveedor?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes)
                return;
            ProveedorNegocio pn = new ProveedorNegocio();
            VProveedor proveedor = pn.EliminarProveedor(cda2);

            if (proveedor == null) proveedor = new VProveedor { Cuit = cda2 };
            if (UsuarioActivo.Datos == null)
            {
                MessageBox.Show("Sesión expirada");
                return;
            }
            proveedor.TipoMovimiento = "Baja de proveedor";
            proveedor.DetalleMovimiento = "el usuario " + UsuarioActivo.Datos.NombreAc +
                            " (DNI: " + UsuarioActivo.Datos.DNIAc +
                            " ) ha dado de baja a: " + nombre +
                            " ( CUIT: " + cda2 + ")";
            ProveedorDatos datos = new ProveedorDatos();
            datos.AltaHistoricoCompleto(proveedor);
            mostrarProveedor();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Modal == "Clientes")
            {
                ElimianrCliente();
            }
            if (Modal == "Proveedor")
            {
                EliminarProveedor();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

     




        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string cuit = txt_buscar.Text.Trim();
            if (Modal == "Clientes")
            {
               MostrarClienteFiltro(cuit);
            }
            if (Modal == "Proveedor")
            {
                MostrarProveedorFiltro(cuit);
            }

        }

        private void btn_bajas_Click(object sender, EventArgs e)
        {
            if (Modal == "Clientes")
            {
                Bajas b = new Bajas();
                b.Modo = "Cliente";
                b.StartPosition = FormStartPosition.CenterParent;
                b.ShowDialog();
            }
            if (Modal == "Proveedor")
            {
                Bajas b = new Bajas();
                b.Modo = "Proveedor";
                b.StartPosition = FormStartPosition.CenterParent;
                b.ShowDialog();
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {

            /* UsuarioDatos db = new UsuarioDatos();
            paginaActual++;

            db.LlenarContenedor(flowLayoutPanel1, AbrirEdicionUsuario, this, paginaActual, registrosPorPagina);*/
            if (Modal == "Clientes")
            {

                if (paginaActual < TotalPaginas)
                {
                    paginaActual++;
                    if (!filtroCliente)
                    {
                        MostrarCliente();
                    }
                    else if (filtroCliente)
                    {
                        if (!string.IsNullOrWhiteSpace(txt_buscar.Text))
                        {
                            MostrarClienteFiltro(txt_buscar.Text.Trim());
                        }
                    }
                }
                else if (Modal == "Proveedor")
                {
                    if (paginaActual < TotalPaginas)
                    {
                        paginaActual++;
                        if (!filtroProveedor)
                        {
                            mostrarProveedor();
                        }
                        else if (filtroProveedor)
                        {
                            if (!string.IsNullOrWhiteSpace(txt_buscar.Text))
                            {
                                MostrarProveedorFiltro(txt_buscar.Text.Trim());
                            }
                        }
                    }

                }
            }
        }
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (Modal == "Clientes")
            {
                if (paginaActual > 1)
                {
                    paginaActual--;
                    if(!filtroCliente)
                    {
                        MostrarCliente();
                    }
                    else if (filtroCliente)
                    {
                        if (!string.IsNullOrWhiteSpace(txt_buscar.Text))
                        {
                            MostrarClienteFiltro(txt_buscar.Text.Trim());
                        }
                    }
                }
            }
            else if (Modal == "Proveedor")
            {
                if (paginaActual > 1)
                {
                    paginaActual--;
                    if (!filtroProveedor)
                    { mostrarProveedor(); }
                    else if (filtroProveedor)
                    {
                        if (!string.IsNullOrWhiteSpace(txt_buscar.Text))
                        {
                            BuscarProveedor(txt_buscar.Text.Trim());
                        }
                    }

                }
            }
        }

        private void txt_buscar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_buscar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
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

            if(e.KeyCode == Keys.Enter)
            {
                btn_buscar.PerformClick();
                e.SuppressKeyPress=true;
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

        //DE PROVEEDORES

        public void mostrarProveedor()
        {
            try
            {
                ProveedorDatos db = new ProveedorDatos();
                var result = db.GetProveedor(paginaActual, registrosPorPagina);
                if (result == null) return;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = result.Data;

                TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
                lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
                btn_anterior.Enabled = paginaActual > 1;
                btn_anterior.Enabled = paginaActual < TotalPaginas;

                label1.Text = $"Total registros: {result.Total}";
                filtroProveedor = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
            }
        }

        public void BuscarProveedor(string filtro)
        {
            try
            {
                //llamo al dal
                ProveedorDatos db = new ProveedorDatos();
                var result = db.GetProveedorFiltro(paginaActual, registrosPorPagina, filtro);

                if (result.Total == 0)
                {
                    mostrarProveedor();
                    MessageBox.Show("No se encontraron resultados para el filtro ingresado.");
                    return;
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = result.Data;

                TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
                lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
                btn_anterior.Enabled = paginaActual > 1;
                btn_siguente.Enabled = paginaActual < TotalPaginas;

                label1.Text = $"Total registros: {result.Total}";
                filtroProveedor = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
            }
        }


        //DE CLIENTES
        public void MostrarClientes()
        {
            try
            {
                ClienteDatos db = new ClienteDatos();
                var result = db.MostrarCliente(paginaActual, registrosPorPagina);

                if (result == null) return;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = result.Data;
                TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);
                lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
                btn_anterior.Enabled = paginaActual > 1;
                btn_siguente.Enabled = paginaActual < TotalPaginas;
                label1.Text = $"Total registros: {result.Total}";
                filtroCliente = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }
    }
}
