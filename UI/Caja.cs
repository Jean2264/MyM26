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
        public Caja()
        {
            InitializeComponent();
            Conexion.Conectar();
            dtg_caja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Load += new EventHandler(Caja_Load);
            // En el constructor:
            this.Enter += (s, e) => {
                dtg_caja.Focus();
                if (dtg_caja.CurrentCell == null && dtg_caja.Rows.Count > 0)
                    dtg_caja.CurrentCell = dtg_caja.Rows[0].Cells[0];
            };
            cmbs();
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

        }

        private void dtg_caja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            CalcularTotalGeneral(); // <--- Suma todos los subtotales del grid
        }

        public void ActualizarSubtotal(DataGridViewRow row)
        {
            int cant = Convert.ToInt32(row.Cells["Cantidad"].Value);
            int minMayor = Convert.ToInt32(row.Cells["CantMinMayor"].Value);
            decimal pUnit = Convert.ToDecimal(row.Cells["PrecioUnit"].Value);
            decimal pMayor = Convert.ToDecimal(row.Cells["PrecioMayor"].Value);

            if (cant >= minMayor && minMayor!=0)
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
            decimal total = 0;
            foreach (DataGridViewRow row in dtg_caja.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }
            txt_subtotal.Text = "Subtotal: "+total.ToString("N2"); // "N2" para 2 decimales
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
    }
}
