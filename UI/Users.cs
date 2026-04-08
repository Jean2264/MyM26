using MyM26.BLL;
using MyM26.DAL;
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
        int registrosPorPagina = 50;
        int TotalPaginas = 0;
        public Users()
        {
            InitializeComponent();
            Conexion.Conectar();
            llenarUser();
            CalcularTotalPaginas();
        }

        private void Users_Load(object sender, EventArgs e)
        {


        }
        public void llenarUser()
        {
            flowLayoutPanel1.Controls.Clear();
            UsuarioDatos db = new UsuarioDatos();



            db.LlenarContenedor(flowLayoutPanel1, AbrirEdicionUsuario, this, paginaActual, registrosPorPagina);

            /*db.LlenarContenedor(
                flowLayoutPanel1,
                AbrirEdicionUsuario, 
                this
            );

            TargetaUsuario targeta = new TargetaUsuario();

            targeta.DatoEliminado += () =>
            {
              llenarUser(); 
            };*/
        }

        public void BuscarUser(string dni)
        {

            flowLayoutPanel1.Controls.Clear();
            UsuarioDatos DB = new UsuarioDatos();
            DB.FiltrarUser(
                flowLayoutPanel1,
                dni

                );

        }
        private void btn_añadirUsrr_Click(object sender, EventArgs e)
        {
            AMUser an = new AMUser(this);
            an.StartPosition = FormStartPosition.CenterParent;
            an.Modo = "Alta";
            an.ShowDialog();
        }
        /*private void usuario()
         {
             Variables.User = QueryUser.mostrarUser();
             dataGridView1.DataSource = Variables.User;
         }*/

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
                llenarUser(); // 🔥 refresca
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string dni = txt_buscar.Text;
            BuscarUser(dni);
        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {

            /*if (paginaActual < TotalPaginas)
            {
                paginaActual++;
                llenar();
            }
*/
           if(paginaActual < TotalPaginas)
            {
                paginaActual++;
                llenarUser();
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
           
            if (paginaActual > 1)
            {
                paginaActual--;
               llenarUser();
            }
        }

        private void CalcularTotalPaginas()
        {
            UsuarioDatos db = new UsuarioDatos();
            int totalRegistros = db.ObtenerTotalUsuarios();
            TotalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);
            lbl_paginas.Text = $"Página {paginaActual} / {TotalPaginas}";
            label1.Text = $"Total de usuarios: " + totalRegistros.ToString();
            btn_siguente.Enabled = paginaActual < TotalPaginas;
            btn_anterior.Enabled = paginaActual > 1;

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
        }

        private void txt_buscar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }
    }
    }

