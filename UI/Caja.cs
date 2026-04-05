using iTextSharp.text;
using iTextSharp.text.pdf;

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Rectangle = iTextSharp.text.Rectangle;
using MyM26.BLL;
using MyM26.DAL;
using MyM26.Entidades;
using MyM26.Entidades.Caja;
using MyM26.UI;
using MyM26.Querys;
using MyM26.Entidades.Usuario;

namespace MyM26.screens
{
    public partial class Caja : UserControl
    {
        decimal Descuento;
        decimal subtotal = 0;
        decimal Total;
        string codRemi;
        int alto;
        int cantidadProductos;
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
            numeric_restar.Visible = false;
            btn_restar.Visible = false;

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
            if(txt_desc.Text == "")
            {
                MessageBox.Show("Ingrese un valor de descuento válido.");
                return;
            }
            Descuento += Convert.ToDecimal(txt_desc.Text);
            CalcularTotalGeneral();
            txt_desc.Visible = false;
            txt_desc.Text = "";
            btn_añadir_desc.Visible = false;
            btn_reem_desc.Visible = false;
        }

        private void dtg_caja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_caja_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != 0) return;


            var cellValue = dtg_caja.Rows[e.RowIndex].Cells[0].Value;
            string codigoEscaneado = cellValue?.ToString();

            if (string.IsNullOrWhiteSpace(codigoEscaneado)) return;


            if (dtg_caja.Rows[e.RowIndex].Cells["Nombre"].Value != null &&
                !string.IsNullOrEmpty(dtg_caja.Rows[e.RowIndex].Cells["Nombre"].Value.ToString()))
            {
                return;
            }


            foreach (DataGridViewRow fila in dtg_caja.Rows)
            {
                if (!fila.IsNewRow && fila.Index != e.RowIndex && fila.Cells[0].Value?.ToString() == codigoEscaneado)
                {
                    SumarCantidadExistente(fila);
                    BeginInvoke(new MethodInvoker(() =>
                    {
                        if (dtg_caja.Rows.Count > e.RowIndex)
                            dtg_caja.Rows.RemoveAt(e.RowIndex);
                    }));
                    CalcularTotalGeneral();
                    return;
                }
            }


            CajaNegocio neg = new CajaNegocio();
            VCaja cj = neg.tomarInfo(codigoEscaneado);

            if (cj == null) { return; }

          
            if (cj.StockDisponible <= 0)
            {
                MessageBox.Show($"El artículo '{cj.Nombre}' no tiene stock disponible (Stock: 0).",
                                "Sin Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               
                BeginInvoke(new MethodInvoker(() => {
                    dtg_caja.Rows[e.RowIndex].Cells[0].Value = "";
                }));
                return; 
            }
            // ---------------------------------

            LlenarFila(e.RowIndex, cj);
            IrSiguienteFila();
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
            int StockMax = Convert.ToInt32(fila.Tag);

            if (CantActual + 1 > StockMax)
            {
                MessageBox.Show($"Límite alcanzado. Solo hay {StockMax} en stock.");

            }
            else
            {
                fila.Cells["Cantidad"].Value = CantActual + 1;

                ActualizarSubtotal(fila);
                CalcularTotalGeneral();
                dtg_caja.RefreshEdit();
            }
        }

        public void LlenarFila(int index, VCaja cj)
        {
            var row = dtg_caja.Rows[index];
            row.Cells["Nombre"].Value = cj.Nombre;
            row.Cells["PrecioUnit"].Value = cj.PrecioUnitario;
            row.Cells["PrecioMayor"].Value = cj.PrecioMayorista;
            row.Cells["CantMinMayor"].Value = cj.CantidadMinimaMayor;
            row.Cells["CodigoArticulo"].Value = cj.codigoArticulo;
            row.Cells["Cantidad"].Value = 1;
            row.Tag = cj.StockDisponible;

            if (cj.Imagen != null)
            {
                using (MemoryStream ms = new MemoryStream(cj.Imagen))
                {
                    pcb_art.Image =  System.Drawing.Image.FromStream(ms);
                    pcb_art.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            ActualizarSubtotal(row);
            CalcularTotalGeneral();
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
            subtotal = 0;

            foreach (DataGridViewRow row in dtg_caja.Rows)
            {
                if (!row.IsNewRow && row.Cells["Subtotal"].Value != null && row.Cells["Cantidad"].Value != null)
                {
                    decimal valorSubtotal = 0;
                    if (decimal.TryParse(row.Cells["Subtotal"].Value.ToString(), out valorSubtotal))
                    {
                        subtotal += valorSubtotal;
                    }
                }
            }

            txt_subtotal.Text = "Subtotal: " + subtotal.ToString("N2");
            txt_descuento.Text = "Descuento: " + Descuento.ToString("N2");
            Total = (subtotal - Descuento);
            txt_total.Text = "Total: " + Total.ToString("N2");
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Caja_Load(object sender, EventArgs e)
        {

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
            if (dtg_caja.CurrentRow != null)
            {

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
            btn_sumar.Visible = true;
            btn_restar.Visible = true;
            numeric_restar.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            if (dtg_caja.CurrentRow == null)
            {
                MessageBox.Show("Por favor seleccione un articulo");
                return;
            }

            int cantidadActual = Convert.ToInt32(dtg_caja.CurrentRow.Cells["Cantidad"].Value);
            int cantidadRestar = (int)numeric_restar.Value;

            if (cantidadRestar <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }

            if (cantidadRestar >= cantidadActual)
            {
                dtg_caja.Rows.Remove(dtg_caja.CurrentRow);
                pcb_art.Image = null;
            }
            else
            {
                int cantidadNueva = cantidadActual - cantidadRestar;
                dtg_caja.CurrentRow.Cells["Cantidad"].Value = cantidadNueva;
            }

            CalcularTotalGeneral();

            numeric_restar.Value = 0;
            numeric_restar.Visible = false;
            btn_restar.Visible = false;
            btn_sumar.Visible = false;
            button3.Enabled = false;
            btn_desc.Enabled = false;
            button2.Enabled = false;



        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string filtro = txt_buscar.Text;
            BuscarArt ar = new BuscarArt(filtro);
            ar.StartPosition = FormStartPosition.CenterParent;
            if (ar.ShowDialog() == DialogResult.OK)
            {
                string cb = ar.cb;
                string nombre = ar.nombre;
                decimal PU = ar.PU;
                decimal PM = ar.PM;
                int CM = ar.CM;
                int stock = ar.stock;
                string cd = ar.cd;
                byte[] imagen = ar.imagen;

                foreach (DataGridViewRow fila in dtg_caja.Rows)
                {
                    if (!fila.IsNewRow && fila.Cells[0].Value?.ToString() == cb)
                    {
                        SumarCantidadExistente(fila);
                        return;
                    }
                }

                VCaja cj = new VCaja()
                {
                    codigoArticulo = cd,
                    CodigoBarra = cb,
                    Nombre = nombre,
                    PrecioUnitario = PU,
                    PrecioMayorista = PM,
                    CantidadMinimaMayor = CM,
                    StockDisponible = stock,
                    Imagen = imagen
                };
                if (stock <= 0) 
                {
                    MessageBox.Show("No se puede añadir el producto porque no tiene stock disponible.");
                    return;
                }
                int index = dtg_caja.Rows.Add();
                LlenarFila(index, cj);
                MessageBox.Show(cd);

            }

        }

        private void btn_sumar_Click(object sender, EventArgs e)
        {

            if (dtg_caja.CurrentRow == null)
            {
                MessageBox.Show("Por favor seleccione un articulo");
                return;
            }

            int cantidadActual = Convert.ToInt32(dtg_caja.CurrentRow.Cells["Cantidad"].Value);
            int cantidadSumar = (int)numeric_restar.Value;

            if (cantidadSumar <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }
            int stockDisponible = Convert.ToInt32(dtg_caja.CurrentRow.Tag);

            if (cantidadActual + cantidadSumar > stockDisponible)
            {
                MessageBox.Show($"SUMA---Stock insuficiente. Solo hay {stockDisponible} unidades disponibles.");
                return;
            }
            int cantidadNueva = cantidadActual + cantidadSumar;
            dtg_caja.CurrentRow.Cells["Cantidad"].Value = cantidadNueva;
            ActualizarSubtotal(dtg_caja.CurrentRow);
            CalcularTotalGeneral();

            numeric_restar.Value = 0;
            numeric_restar.Visible = false;
            btn_restar.Visible = false;
            btn_sumar.Visible = false;
            button3.Enabled = false;
            btn_desc.Enabled = false;
            button2.Enabled = false;

        }

        //
        //
        //
        //
        //
        private void btn_confiVenta_Click(object sender, EventArgs e)
        {
            CalcularTotalGeneral();
            //Armamos HVenta

            if (dtg_caja.Rows == null)
            {
                MessageBox.Show("Por favor agrega al menos un articulo a la grid");
                return;
            }
            HVenta venta = new HVenta();
            venta.Total = Total;
            venta.Descuento = Descuento;
            venta.SubtotalV = subtotal;
            venta.FormaPago = cmb_pago.Text;
            venta.Factura = cmb_factura.Text;
            venta.TipoComprobante = cmb_comprobante.Text;
            venta.Cuit = cmb_cliente.SelectedValue?.ToString();
            venta.TipoMovimiento = "Alta venta";
            venta.DetalleMovimiento = $"el usuario: " + UsuarioActivo.Datos.NombreAc+ " (DNI:  "+UsuarioActivo.Datos.DNIAc +") "+" a generado una venta por un total de"+ Total.ToString("N2");

            //Armamos Detalle
            List<HVentaDetalle> listaDetalle = new List<HVentaDetalle>();

            foreach (DataGridViewRow row in dtg_caja.Rows)
            {
                if (row.IsNewRow) continue;


                if (row.Cells["CodigoArticulo"].Value != null)
                {
                    HVentaDetalle det = new HVentaDetalle();
                    det.CodigoArticulo = row.Cells["CodigoArticulo"].Value.ToString();
                    det.Descripcion = row.Cells["Nombre"].Value?.ToString() ?? "";
                    det.PU = Convert.ToDecimal(row.Cells["PrecioUnit"].Value ?? 0);
                    det.CantidadV = Convert.ToInt32(row.Cells["Cantidad"].Value ?? 0);
                    det.PXC = Convert.ToDecimal(row.Cells["Subtotal"].Value ?? 0);

                    listaDetalle.Add(det);
                }
            }
            if (cmb_comprobante.Text == "Presupuesto")
            {
                
                codRemi = "PRES-" + DateTime.Now.ToString("yyyyMMddHHmmss");

                int cantidadProductos = dtg_caja.Rows
                    .Cast<DataGridViewRow>()
                    .Count(r => !r.IsNewRow);

                alto =
                    100 +
                    80 +
                    (cantidadProductos * 16) +
                    80 +
                    40;

                GenerarTicketPDF();
                CajaDatos dt= new CajaDatos();
                dt.AltaHistoricoCompleto(venta);
                MessageBox.Show($"Presupuesto generado correctamente");
                ResetCampos();
                return;
            }
            else if(cmb_comprobante.Text == "Remito")
            {
                CajaDatos dt = new CajaDatos();
                dt.altacompletoVenta(venta, listaDetalle);
                venta.TipoMovimiento = "Alta remito";
                venta.DetalleMovimiento = $"el usuario: " + UsuarioActivo.Datos.NombreAc + " (DNI:  " + UsuarioActivo.Datos.DNIAc + ") " + " a generado un remito por un total de" + Total.ToString("N2");
                dt.AltaHistoricoCompleto(venta);
                codRemi = venta.CodRemito;



                cantidadProductos = dtg_caja.Rows
             .Cast<DataGridViewRow>()
             .Count(r => !r.IsNewRow);

                alto =
               100 +                        // logo
               80 +                         // cabecera
               (cantidadProductos * 16) +   // productos
               80 +                         // totales
               40;
                // IMPRIMIR
                GenerarTicketPDF();

                MessageBox.Show($"Comprobante guardado");
                ResetCampos();
            }
          
        }




        public void ResetCampos()
        {
            subtotal = 0;
            Total = 0;
            Descuento = 0;

            cmb_comprobante.SelectedItem = "Remito";
            cmb_factura.SelectedItem = "FC";
            cmb_pago.SelectedItem = "Efectivo";
            cmb_cliente.SelectedValue = "00000000000";

            txt_buscar.Clear();
            txt_desc.Clear();
            pcb_art.Image = null;

            dtg_caja.Rows.Clear();

            CalcularTotalGeneral();
        }

        private void btn_cancelarVenta_Click(object sender, EventArgs e)
        {
            ResetCampos();
        }

        private void dtg_caja_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
        }

     

        private void GenerarTicketPDF()
        {
            string rutaCarpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Tickets");

            if (!Directory.Exists(rutaCarpeta))
                Directory.CreateDirectory(rutaCarpeta);

            string archivo = Path.Combine(rutaCarpeta, codRemi + ".pdf");

            var pageSize = new iTextSharp.text.Rectangle(210, alto);
            Document doc = new Document(pageSize, 5, 5, 5, 5);

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(archivo, FileMode.Create));
                doc.Open();


                var fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 8);
                var fontBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9);
                var fontTotal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);


                using (MemoryStream ms = new MemoryStream())
                {
                    Properties.Resources.logo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    var logo = iTextSharp.text.Image.GetInstance(ms.ToArray());

                    logo.ScaleToFit(90f, 90f);
                    logo.Alignment = Element.ALIGN_CENTER;
                    logo.SpacingAfter = 5f;

                    doc.Add(logo);
                }


                Paragraph titulo = new Paragraph("COMPROBANTE DE VENTA\n",
                    fontBold);
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);


                doc.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}", fontNormal));
                doc.Add(new Paragraph($"N°: {codRemi}", fontNormal));
                doc.Add(new Paragraph($"Tipo: {cmb_comprobante.Text}\n", fontNormal));


                doc.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator()));


                PdfPTable tabla = new PdfPTable(3);
                tabla.WidthPercentage = 100;
                tabla.SetWidths(new float[] { 75f, 25f, 50f });


                PdfPCell h1 = new PdfPCell(new Phrase("Producto", fontBold));
                PdfPCell h2 = new PdfPCell(new Phrase("Cant.", fontBold));
                PdfPCell h3 = new PdfPCell(new Phrase("Total", fontBold));

                h1.Border = Rectangle.NO_BORDER;
                h2.Border = Rectangle.NO_BORDER;
                h3.Border = Rectangle.NO_BORDER;

                h2.HorizontalAlignment = Element.ALIGN_CENTER;
                h3.HorizontalAlignment = Element.ALIGN_RIGHT;

                tabla.AddCell(h1);
                tabla.AddCell(h2);
                tabla.AddCell(h3);


                foreach (DataGridViewRow row in dtg_caja.Rows)
                {
                    if (row.IsNewRow) continue;

                    string nom = row.Cells["Nombre"].Value?.ToString() ?? "";
                    string cant = row.Cells["Cantidad"].Value?.ToString() ?? "0";
                    decimal subt = Convert.ToDecimal(row.Cells["Subtotal"].Value ?? 0);

                    PdfPCell c1 = new PdfPCell(new Phrase(nom, fontNormal));
                    PdfPCell c2 = new PdfPCell(new Phrase(cant, fontNormal));
                    PdfPCell c3 = new PdfPCell(new Phrase("$ " + subt.ToString("N2"), fontNormal));

                    c1.Border = 0;
                    c2.Border = 0;
                    c3.Border = 0;

                    c2.HorizontalAlignment = Element.ALIGN_CENTER;
                    c3.HorizontalAlignment = Element.ALIGN_RIGHT;
                    c3.NoWrap = true;

                    tabla.AddCell(c1);
                    tabla.AddCell(c2);
                    tabla.AddCell(c3);
                }

                doc.Add(tabla);


                doc.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator()));

                PdfPTable totales = new PdfPTable(2);
                totales.WidthPercentage = 100;
                totales.SetWidths(new float[] { 60f, 40f });

                totales.AddCell(new PdfPCell(new Phrase("SUBTOTAL:", fontBold)) { Border = 0 });
                totales.AddCell(new PdfPCell(new Phrase("$ " + subtotal.ToString("N2"), fontNormal))
                {
                    Border = 0,
                    HorizontalAlignment = Element.ALIGN_RIGHT
                });

                totales.AddCell(new PdfPCell(new Phrase("TOTAL:", fontTotal)) { Border = 0 });
                totales.AddCell(new PdfPCell(new Phrase("$ " + Total.ToString("N2"), fontTotal))
                {
                    Border = 0,
                    HorizontalAlignment = Element.ALIGN_RIGHT
                });

                doc.Add(totales);


                doc.Add(new Paragraph("\nGracias por su compra!",
                    fontBold)
                { Alignment = Element.ALIGN_CENTER });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }
    }
}
