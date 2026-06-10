using MyM26.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyM26.UI
{
    public partial class Proveedor : Form
    {
        int pagina = 1;
        int limite = 10;
        int totalPaginas = 0;
        public string nombre;
        public string cuit;
        public Proveedor()
        {
            InitializeComponent();
        }

        private void txt_buscar_sub_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txt_buscar_sub_KeyDown(object sender, KeyEventArgs e)
        {
            bool ALTGR = e.Control && e.Alt;
            if (
                (e.Control && e.KeyCode == Keys.C) ||
                (e.Control && e.KeyCode == Keys.V) ||
                (e.Control && e.KeyCode == Keys.X) ||
                (e.Shift && e.KeyCode == Keys.C) ||
                (e.Shift && e.KeyCode == Keys.Insert) ||
                (e.Control && e.KeyCode == Keys.Insert) ||
                (e.Shift && e.KeyCode == Keys.Delete)
                )
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                btn_buscar.PerformClick();
            }
        }

        private void txt_buscar_sub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsAsciiLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_buscar_sub_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        public void mostrar()
        {

            string filtro = txt_buscar_sub.Text;
            ArticuloDatos db = new ArticuloDatos();

            var result = db.MostrarProvBox(pagina, limite, filtro);

            if (result == null) return;

            dtg_Subcate.DataSource = null;
            dtg_Subcate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Subcate.DataSource = result.Data;
            btn_anterior.Visible = true;
            lbl_paginas.Visible = true;
            btn_siguente.Visible = true;
            totalPaginas = (int)Math.Ceiling((double)result.Total / limite);
            lbl_paginas.Text = $"{pagina} / {totalPaginas}";
        }
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (pagina > 1)
            {
                pagina--;
                mostrar();
            }
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void btn_siguente_Click(object sender, EventArgs e)
        {
            if (pagina < totalPaginas)
            {
                pagina++;
                mostrar();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_Subcate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dtg_Subcate_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = dtg_Subcate.CurrentRow.Cells["Nombre"].Value.ToString();
            cuit = dtg_Subcate.CurrentRow.Cells["Cuit"].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
