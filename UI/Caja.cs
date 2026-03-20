using MyM26.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MyM26.Entidades;
using MyM26.DAL;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyM26.Entidades.Caja;

namespace MyM26.screens
{
    public partial class Caja : UserControl
    {
        decimal Descuento;
        decimal Total;
        public Caja()
        {
            InitializeComponent();
            Conexion.Conectar();
            dtg_caja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Load += new EventHandler(Caja_Load);

            this.Enter += (s, e) =>
            {
                dtg_caja.Focus();
                if (dtg_caja.CurrentCell == null && dtg_caja.Rows.Count > 0)
                    dtg_caja.CurrentCell = dtg_caja.Rows[0].Cells[0];
            };
            cmbs();
            CalcularTotalGeneral();
            button2.Enabled = false;
            button3.Enabled = false;
            numericUpDown1.Visible = false;
            button1.Visible = false;

        }

        private void btn_desc_Click(object sender, EventArgs e)
        {
            btn_añadir_desc.Visible = true;
            txt_desc.Visible = true;

            if (txt_descuento.Text != "")
            {
                btn_reem_desc.Visible = true;
            }
        }

        private void btn_añadir_desc_Click(object sender, EventArgs e)
        {
            Descuento += Convert.ToDecimal(txt_desc.Text);
            CalcularTotalGeneral();
            txt_desc.Visible = false;
            txt_desc.Text = "";
            btn_añadir_desc.Visible = false;
            btn_reem_desc.Visible = false;
        }

        private void dtg_caja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void dtg_caja_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Solo actuamos si es la columna del código (índice 0)
            if (e.ColumnIndex == 0)
            {
                string codigoEscaneado = dtg_caja.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (string.IsNullOrEmpty(codigoEscaneado)) return;

                // Paso 1: Verificar duplicados
                foreach (DataGridViewRow fila in dtg_caja.Rows)
                {
                    if (!fila.IsNewRow && fila.Index != e.RowIndex && fila.Cells[0].Value?.ToString() == codigoEscaneado)
                    {
                        SumarCantidadExistente(fila);

                        // !!! IMPORTANTE: Si es duplicado, limpiamos la celda actual y no saltamos de fila
                        // para que el usuario pueda volver a escanear ahí mismo.
                        BeginInvoke(new MethodInvoker(() =>
                        {
                            dtg_caja.Rows[e.RowIndex].Cells[0].Value = "";
                            dtg_caja.CurrentCell = dtg_caja.Rows[e.RowIndex].Cells[0];
                        }));
                        return;
                        CalcularTotalGeneral();
                    }
                }

                // Paso 2: Buscar en la DB
                CajaNegocio neg = new CajaNegocio();
                VCaja cj = neg.tomarInfo(codigoEscaneado);

                if (cj == null)
                {
                    MessageBox.Show("Artículo no encontrado");
                    dtg_caja.Rows[e.RowIndex].Cells[0].Value = "";
                    return;
                }

                // Paso 3: Validar Stock (usamos StockDisponible que viene de tu entidad)
                if (cj.StockDisponible <= 0)
                {
                    MessageBox.Show("No hay stock disponible");
                    dtg_caja.Rows[e.RowIndex].Cells[0].Value = "";
                    return;
                }

                // Paso 4: Cargar datos
                LlenarFila(e.RowIndex, cj);

                // Paso 5: Saltar a la siguiente línea
                IrSiguienteFila(); // Corregí el nombre a Siguiente
            }
        }

        private void cmbs()
        {
            //Tipo de comprobante
            cmb_comprobante.Items.Add("Remito");
            cmb_comprobante.Items.Add("Presupuesto");
            cmb_comprobante.SelectedItem = "Remito";

            //Tipo de factura
            cmb_factura.Items.Add("FA");
            cmb_factura.Items.Add("FB");
            cmb_factura.Items.Add("FC");
            cmb_factura.Items.Add("FE");
            cmb_factura.Items.Add("FM");
            cmb_factura.SelectedItem = "FC";

            //Forma de pago
            cmb_pago.Items.Add("Efectivo");
            cmb_pago.Items.Add("Credito");
            cmb_pago.Items.Add("Debito");
            cmb_pago.Items.Add("QR");
            cmb_pago.Items.Add("Transferencia");
            cmb_pago.SelectedItem = "Efectivo";

            //cliente
            cmb_cliente.DataSource = CajaDatos.ClienteCaja();
            cmb_cliente.DisplayMember = "NombreCompleto";
            cmb_cliente.ValueMember = "Cuit";
            cmb_cliente.SelectedValue = "00000000000";

        }
        public void SumarCantidadExistente(DataGridViewRow fila)
        {
            int CantActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
            int StockMax = Convert.ToInt32(fila.Tag);//guardamos el stock en el tag al buscar

            if (CantActual + 1 > StockMax)
            {
                MessageBox.Show($"Límite alcanzado. Solo hay {StockMax} en stock.");

            }
            else
            {
                fila.Cells["Cantidad"].Value = CantActual + 1;
                ActualizarSubtotal(fila);
                CalcularTotalGeneral();
            }
        }

        public void LlenarFila(int index, VCaja cj)
        {
            var row = dtg_caja.Rows[index];
            row.Cells["Nombre"].Value = cj.Nombre;
            row.Cells["PrecioUnit"].Value = cj.PrecioUnitario;
            row.Cells["PrecioMayor"].Value = cj.PrecioMayorista;
            row.Cells["CantMinMayor"].Value = cj.CantidadMinimaMayor;
            row.Cells["Cantidad"].Value = 1;
            row.Tag = cj.StockDisponible; // Guardamos el stock real para comparar luego

            if (cj.Imagen != null)
            {
                using (MemoryStream ms = new MemoryStream(cj.Imagen))
                {
                    pcb_art.Image = Image.FromStream(ms);
                    pcb_art.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            ActualizarSubtotal(row);
            CalcularTotalGeneral(); // Suma todos los subtotales del grid
        }

        public void ActualizarSubtotal(DataGridViewRow row)
        {
            int cant = Convert.ToInt32(row.Cells["Cantidad"].Value);
            int minMayor = Convert.ToInt32(row.Cells["CantMinMayor"].Value);
            decimal pUnit = Convert.ToDecimal(row.Cells["PrecioUnit"].Value);
            decimal pMayor = Convert.ToDecimal(row.Cells["PrecioMayor"].Value);

            if (cant >= minMayor && minMayor != 0)
                row.Cells["Subtotal"].Value = cant * pMayor;
            else
                row.Cells["Subtotal"].Value = cant * pUnit;
        }
        public void IrSiguienteFila()
        {
            BeginInvoke(new MethodInvoker(() =>
            {
                int filaActual = dtg_caja.CurrentCell.RowIndex;
                // Si hay una fila abajo, vamos a ella, sino, el Enter creará una
                if (filaActual < dtg_caja.RowCount - 1)
                {
                    dtg_caja.CurrentCell = dtg_caja.Rows[filaActual + 1].Cells[0];
                }
                else
                {
                    SendKeys.Send("{ENTER}");
                }
                dtg_caja.BeginEdit(true);
            }));
        }

        private void CalcularTotalGeneral()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dtg_caja.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }
            txt_subtotal.Text = "Subtotal: " + subtotal.ToString("N2"); // "N2" para 2 decimales
            txt_descuento.Text = "Descuento: " + Descuento.ToString("N2");
            Total = (subtotal - Descuento);
            txt_total.Text = "Total: " + Total.ToString("N2");

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Caja_Load(object sender, EventArgs e)
        {
            // Forzamos el foco al DataGridView
            dtg_caja.Focus();

            if (dtg_caja.Rows.Count > 0)
            {
                dtg_caja.CurrentCell = dtg_caja.Rows[0].Cells[0];
                dtg_caja.BeginEdit(true);
            }
        }

        private void btn_reem_desc_Click(object sender, EventArgs e)
        {
            Descuento = Convert.ToDecimal(txt_desc.Text);
            CalcularTotalGeneral();

            txt_desc.Visible = false;
            txt_desc.Text = "";
            btn_añadir_desc.Visible = false;
            btn_reem_desc.Visible = false;
        }

        private void btn_vuelto_Click(object sender, EventArgs e)
        {
            decimal billete = Convert.ToDecimal(txt_vuelto.Text);
            decimal vuelto = billete - Total;

            txt_vuelto.Text = "Vuelto: " + vuelto.ToString("N2");

            btn_vuelto.Visible = false;
            btn_cerrar_vuelto.Visible = true;
            panel5.Controls.SetChildIndex(btn_mostrar_vuelto, 3);
            panel5.Controls.SetChildIndex(txt_vuelto, 1);
            panel5.Controls.SetChildIndex(btn_vuelto, 2);
            panel5.Controls.SetChildIndex(btn_cerrar_vuelto, 0);
        }

        private void btn_mostrar_vuelto_Click(object sender, EventArgs e)
        {

            btn_vuelto.Visible = true;
            txt_vuelto.Visible = true;
        }

        private void btn_cerrar_vuelto_Click(object sender, EventArgs e)
        {

            btn_vuelto.Visible = false;
            txt_vuelto.Text = "";
            txt_vuelto.Visible = false;
            btn_cerrar_vuelto.Visible = false;
            panel5.Controls.SetChildIndex(btn_mostrar_vuelto, 2);
            panel5.Controls.SetChildIndex(txt_vuelto, 1);
            panel5.Controls.SetChildIndex(btn_vuelto, 0);
            panel5.Controls.SetChildIndex(btn_cerrar_vuelto, 3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtg_caja.CurrentRow != null) // Verifica que haya una fila seleccionada
            {
                // Pregunta al usuario si está seguro
                DialogResult resultado = MessageBox.Show(
                    "¿Desea eliminar el producto seleccionado?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Elimina la fila seleccionada del DataGridView
                    dtg_caja.Rows.Remove(dtg_caja.CurrentRow);

                    CalcularTotalGeneral();

                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            numericUpDown1.Visible = true;
            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
