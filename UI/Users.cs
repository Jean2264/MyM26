using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades;
using MyM26.Entidades.Usuario;
using MyM26.Querys;
using MyM26.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
namespace MyM26.screens
{
    public partial class Users : UserControl
    {
        int paginaActual = 1;
        int registrosPorPagina = 24;
        int TotalPaginas = 0;
        string filtro;
        bool modoFiltro = false;
        public Users()
        {
            InitializeComponent();
            Conexion.Conectar();
            // llenarUser();
            //CalcularTotalPaginas();
            LLenarFlow();
        }

        private void Users_Load(object sender, EventArgs e)
        {


        }
        //Mostrar contenido paginado
        public void LLenarFlow()
        {
            //vacio el flow para que no se dupliquen los datos
            flowLayoutPanel1.Controls.Clear();

            //llamo al dal
            UsuarioDatos db = new UsuarioDatos();

            //guardo el dato y total en una variable Var
            var result = db.GetUsuario(paginaActual, registrosPorPagina);
            //recorro la lista de usuarios y los agrego al flow

            foreach (var item in result.Data)
            {
                TarjetaUsuario u = new TarjetaUsuario();
                u.SetDta(item);

                //asigno los eventos de editar y ver usuario
                u.EditarUsuario += AbrirEdicionUsuario;

                u.VerUsuario += AbrirVerUsuario;

                u.DatoEliminado += () =>
                { 
                LLenarFlow();
                };

                flowLayoutPanel1.Controls.Add(u);
            }

            TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);

            lbl_paginas.Text =
       $"Página {paginaActual} / {TotalPaginas}";

            label1.Text =
                $"Total usuarios: {result.Total}";

            btn_siguente.Enabled =
                paginaActual < TotalPaginas;

            btn_anterior.Enabled =
                paginaActual > 1;

            modoFiltro = false;
        }

        //Mostrar contenido paginado y filtrado
        public void LLenarFlowFiltrado(string filtro)
        {
            //vacio el flow para que no se dupliquen los datos
            flowLayoutPanel1.Controls.Clear();
            
            //llamo al dal
            UsuarioDatos db = new UsuarioDatos();

            //guardo el dato y total en una variable Var
            var result = db.GetUsuarioFiltro(paginaActual, registrosPorPagina, filtro);

            //consulto si el resultado tiene datos
            if(result.Total == 0)
            {
                LLenarFlow();
                MessageBox.Show("No se encontraron resultados para el filtro ingresado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                return;
            }

            //recorro la lista de usuarios y los agrego al flow

            foreach (var item in result.Data)
            {
                TarjetaUsuario u = new TarjetaUsuario();
                u.SetDta(item);

                //asigno los eventos de editar y ver usuario
                u.EditarUsuario += AbrirEdicionUsuario;

                u.VerUsuario += AbrirVerUsuario;

                u.DatoEliminado += () =>
                {
                    LLenarFlow();
                };

                flowLayoutPanel1.Controls.Add(u);
            }

            TotalPaginas = (int)Math.Ceiling((double)result.Total / registrosPorPagina);

            lbl_paginas.Text =
       $"Página {paginaActual} / {TotalPaginas}";

            label1.Text =
                $"Total usuarios: {result.Total}";

            btn_siguente.Enabled =
                paginaActual < TotalPaginas;

            btn_anterior.Enabled =
                paginaActual > 1;

            modoFiltro = true;
        }
      
        private void btn_añadirUsrr_Click(object sender, EventArgs e)
        {
            AMUser an = new AMUser(this);
            an.StartPosition = FormStartPosition.CenterParent;
            an.Modo = "Alta";
            an.ShowDialog();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Bajas b = new Bajas();
            b.StartPosition = FormStartPosition.CenterParent;
            b.Modo = "Usuario";
            b.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirEdicionUsuario(string dni)
        {
            UsuarioNegocio un = new UsuarioNegocio();
            un.Tomarinfo(dni);

            AMUser us = new AMUser(this);
            us.DNI = dni;
            us.Modo = "Modificar";
            us.StartPosition = FormStartPosition.CenterParent;

            if (us.ShowDialog() == DialogResult.OK)
            {
                LLenarFlow();
            }
        }
        public void AbrirVerUsuario(string dni)
        {
            UsuarioNegocio un = new UsuarioNegocio();
            un.Tomarinfo(dni);
            AMUser us = new AMUser(this);
            us.DNI = dni;
            us.Modo = "Ver usuario";
            us.StartPosition = FormStartPosition.CenterParent;

            if (us.ShowDialog() == DialogResult.OK)
            {
                LLenarFlow();
            }

        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string dni = txt_buscar.Text;
           LLenarFlowFiltrado(dni);
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            filtro = txt_buscar.Text;

            if (paginaActual < TotalPaginas)
            {
                paginaActual++;
                if (modoFiltro)
                {
                    LLenarFlowFiltrado(filtro);

                }
                else
                {
                    LLenarFlow();
                }
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {

            if (paginaActual > 1)
            {
                paginaActual--;
                if (modoFiltro)
                {
                    LLenarFlowFiltrado(filtro);
                }
                else
                {
                    LLenarFlow();
                }
            }
        }

       

        private void lbl_paginas_Click(object sender, EventArgs e)
        {

        }

        private void txt_buscar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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

            if(e.KeyCode== Keys.Enter)
            {
                btn_buscar.PerformClick();
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

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

