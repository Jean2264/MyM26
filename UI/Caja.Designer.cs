namespace MyM26.screens
{
    partial class Caja
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btn_añadir_desc = new Button();
            btn_reem_desc = new Button();
            txt_desc = new TextBox();
            btn_desc = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            btn_cancelarVenta = new Button();
            btn_confiVenta = new Button();
            panel5 = new Panel();
            btn_vuelto = new Button();
            txt_vuelto = new TextBox();
            btn_mostrar_vuelto = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            btn_buscar = new Button();
            txt_buscar = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            label3 = new Label();
            cmb_cliente = new ComboBox();
            label2 = new Label();
            cmb_pago = new ComboBox();
            label1 = new Label();
            cmb_factura = new ComboBox();
            label4 = new Label();
            cmb_comprobante = new ComboBox();
            panel4 = new Panel();
            pcb_art = new PictureBox();
            txt_subtotal = new TextBox();
            txt_descuento = new TextBox();
            txt_total = new TextBox();
            dtg_caja = new DataGridView();
            CodigoBarra = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioUnit = new DataGridViewTextBoxColumn();
            PrecioMayor = new DataGridViewTextBoxColumn();
            CantMinMayor = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_art).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_caja).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 4, 0);
            tableLayoutPanel1.Controls.Add(panel5, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 547);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1148, 151);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_añadir_desc);
            panel1.Controls.Add(btn_reem_desc);
            panel1.Controls.Add(txt_desc);
            panel1.Controls.Add(btn_desc);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(461, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 145);
            panel1.TabIndex = 0;
            // 
            // btn_añadir_desc
            // 
            btn_añadir_desc.BackColor = Color.FromArgb(190, 43, 80);
            btn_añadir_desc.Dock = DockStyle.Top;
            btn_añadir_desc.FlatStyle = FlatStyle.Flat;
            btn_añadir_desc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_añadir_desc.ForeColor = Color.White;
            btn_añadir_desc.Location = new Point(0, 69);
            btn_añadir_desc.Name = "btn_añadir_desc";
            btn_añadir_desc.Size = new Size(223, 36);
            btn_añadir_desc.TabIndex = 2;
            btn_añadir_desc.Text = "Añadir descuento";
            btn_añadir_desc.UseVisualStyleBackColor = false;
            btn_añadir_desc.Visible = false;
            btn_añadir_desc.Click += btn_añadir_desc_Click;
            // 
            // btn_reem_desc
            // 
            btn_reem_desc.BackColor = Color.FromArgb(180, 130, 20);
            btn_reem_desc.Dock = DockStyle.Bottom;
            btn_reem_desc.FlatStyle = FlatStyle.Flat;
            btn_reem_desc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_reem_desc.ForeColor = Color.White;
            btn_reem_desc.Location = new Point(0, 109);
            btn_reem_desc.Name = "btn_reem_desc";
            btn_reem_desc.Size = new Size(223, 36);
            btn_reem_desc.TabIndex = 3;
            btn_reem_desc.Text = "Reemplazar descuento";
            btn_reem_desc.UseVisualStyleBackColor = false;
            btn_reem_desc.Visible = false;
            // 
            // txt_desc
            // 
            txt_desc.BorderStyle = BorderStyle.FixedSingle;
            txt_desc.Dock = DockStyle.Top;
            txt_desc.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_desc.Location = new Point(0, 36);
            txt_desc.Multiline = true;
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(223, 33);
            txt_desc.TabIndex = 1;
            txt_desc.Visible = false;
            // 
            // btn_desc
            // 
            btn_desc.BackColor = Color.FromArgb(70, 83, 180);
            btn_desc.BackgroundImageLayout = ImageLayout.Stretch;
            btn_desc.Dock = DockStyle.Top;
            btn_desc.FlatStyle = FlatStyle.Flat;
            btn_desc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_desc.ForeColor = Color.White;
            btn_desc.Location = new Point(0, 0);
            btn_desc.Name = "btn_desc";
            btn_desc.Size = new Size(223, 36);
            btn_desc.TabIndex = 0;
            btn_desc.Text = "Agregar descuento";
            btn_desc.UseVisualStyleBackColor = false;
            btn_desc.Click += btn_desc_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(180, 15, 20);
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(232, 3);
            button2.Name = "button2";
            button2.Size = new Size(223, 36);
            button2.TabIndex = 2;
            button2.Text = "Eliminar articulo";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(220, 120, 20);
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(223, 36);
            button3.TabIndex = 3;
            button3.Text = "Modificar articulo";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_cancelarVenta);
            panel2.Controls.Add(btn_confiVenta);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(919, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 145);
            panel2.TabIndex = 1;
            // 
            // btn_cancelarVenta
            // 
            btn_cancelarVenta.BackColor = Color.FromArgb(100, 10, 56);
            btn_cancelarVenta.Dock = DockStyle.Top;
            btn_cancelarVenta.FlatStyle = FlatStyle.Flat;
            btn_cancelarVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_cancelarVenta.ForeColor = Color.White;
            btn_cancelarVenta.Location = new Point(0, 36);
            btn_cancelarVenta.Name = "btn_cancelarVenta";
            btn_cancelarVenta.Size = new Size(226, 36);
            btn_cancelarVenta.TabIndex = 1;
            btn_cancelarVenta.Text = "Cancelar venta";
            btn_cancelarVenta.UseVisualStyleBackColor = false;
            // 
            // btn_confiVenta
            // 
            btn_confiVenta.BackColor = Color.FromArgb(10, 100, 56);
            btn_confiVenta.Dock = DockStyle.Top;
            btn_confiVenta.FlatStyle = FlatStyle.Flat;
            btn_confiVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_confiVenta.ForeColor = Color.White;
            btn_confiVenta.Location = new Point(0, 0);
            btn_confiVenta.Name = "btn_confiVenta";
            btn_confiVenta.Size = new Size(226, 36);
            btn_confiVenta.TabIndex = 0;
            btn_confiVenta.Text = "Confirmar venta";
            btn_confiVenta.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_vuelto);
            panel5.Controls.Add(txt_vuelto);
            panel5.Controls.Add(btn_mostrar_vuelto);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(690, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(223, 145);
            panel5.TabIndex = 4;
            // 
            // btn_vuelto
            // 
            btn_vuelto.BackColor = Color.FromArgb(10, 90, 153);
            btn_vuelto.Dock = DockStyle.Top;
            btn_vuelto.FlatStyle = FlatStyle.Flat;
            btn_vuelto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_vuelto.ForeColor = Color.White;
            btn_vuelto.Location = new Point(0, 72);
            btn_vuelto.Name = "btn_vuelto";
            btn_vuelto.Size = new Size(223, 36);
            btn_vuelto.TabIndex = 2;
            btn_vuelto.Text = "Calcular";
            btn_vuelto.UseVisualStyleBackColor = false;
            btn_vuelto.Visible = false;
            // 
            // txt_vuelto
            // 
            txt_vuelto.BorderStyle = BorderStyle.FixedSingle;
            txt_vuelto.Dock = DockStyle.Top;
            txt_vuelto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txt_vuelto.Location = new Point(0, 36);
            txt_vuelto.Multiline = true;
            txt_vuelto.Name = "txt_vuelto";
            txt_vuelto.Size = new Size(223, 36);
            txt_vuelto.TabIndex = 1;
            txt_vuelto.Visible = false;
            // 
            // btn_mostrar_vuelto
            // 
            btn_mostrar_vuelto.BackColor = Color.FromArgb(20, 100, 123);
            btn_mostrar_vuelto.Dock = DockStyle.Top;
            btn_mostrar_vuelto.FlatStyle = FlatStyle.Flat;
            btn_mostrar_vuelto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_mostrar_vuelto.ForeColor = Color.White;
            btn_mostrar_vuelto.Location = new Point(0, 0);
            btn_mostrar_vuelto.Name = "btn_mostrar_vuelto";
            btn_mostrar_vuelto.Size = new Size(223, 36);
            btn_mostrar_vuelto.TabIndex = 0;
            btn_mostrar_vuelto.Text = "Calcular vuelto";
            btn_mostrar_vuelto.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9940872F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.60278F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.0698051F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(btn_buscar, 1, 0);
            tableLayoutPanel4.Controls.Add(txt_buscar, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1148, 38);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // btn_buscar
            // 
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_buscar.Dock = DockStyle.Fill;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Location = new Point(232, 3);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(23, 32);
            btn_buscar.TabIndex = 7;
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            txt_buscar.Dock = DockStyle.Fill;
            txt_buscar.Location = new Point(3, 3);
            txt_buscar.Multiline = true;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(223, 32);
            txt_buscar.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(dtg_caja, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 38);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1148, 509);
            tableLayoutPanel2.TabIndex = 4;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Controls.Add(panel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(921, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6958237F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3041763F));
            tableLayoutPanel3.Size = new Size(223, 501);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cmb_cliente);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cmb_pago);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cmb_factura);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cmb_comprobante);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(217, 247);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 165);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 35;
            label3.Text = "Cliente";
            // 
            // cmb_cliente
            // 
            cmb_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmb_cliente.BackColor = Color.WhiteSmoke;
            cmb_cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_cliente.FormattingEnabled = true;
            cmb_cliente.Location = new Point(3, 183);
            cmb_cliente.Name = "cmb_cliente";
            cmb_cliente.Size = new Size(209, 23);
            cmb_cliente.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 115);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 33;
            label2.Text = "Forma de pago";
            // 
            // cmb_pago
            // 
            cmb_pago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmb_pago.BackColor = Color.WhiteSmoke;
            cmb_pago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_pago.FormattingEnabled = true;
            cmb_pago.Location = new Point(3, 133);
            cmb_pago.Name = "cmb_pago";
            cmb_pago.Size = new Size(209, 23);
            cmb_pago.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 62);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 31;
            label1.Text = "Tipo de factura";
            // 
            // cmb_factura
            // 
            cmb_factura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmb_factura.BackColor = Color.WhiteSmoke;
            cmb_factura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_factura.FormattingEnabled = true;
            cmb_factura.Location = new Point(3, 80);
            cmb_factura.Name = "cmb_factura";
            cmb_factura.Size = new Size(209, 23);
            cmb_factura.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 29;
            label4.Text = "Tipo de comprobante";
            // 
            // cmb_comprobante
            // 
            cmb_comprobante.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmb_comprobante.BackColor = Color.WhiteSmoke;
            cmb_comprobante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_comprobante.FormattingEnabled = true;
            cmb_comprobante.Location = new Point(1, 30);
            cmb_comprobante.Name = "cmb_comprobante";
            cmb_comprobante.Size = new Size(211, 23);
            cmb_comprobante.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.Controls.Add(pcb_art);
            panel4.Controls.Add(txt_subtotal);
            panel4.Controls.Add(txt_descuento);
            panel4.Controls.Add(txt_total);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 256);
            panel4.Name = "panel4";
            panel4.Size = new Size(217, 242);
            panel4.TabIndex = 1;
            // 
            // pcb_art
            // 
            pcb_art.Anchor = AnchorStyles.Top;
            pcb_art.BorderStyle = BorderStyle.FixedSingle;
            pcb_art.Location = new Point(37, 2);
            pcb_art.Name = "pcb_art";
            pcb_art.Size = new Size(151, 128);
            pcb_art.TabIndex = 4;
            pcb_art.TabStop = false;
            // 
            // txt_subtotal
            // 
            txt_subtotal.BorderStyle = BorderStyle.FixedSingle;
            txt_subtotal.Dock = DockStyle.Bottom;
            txt_subtotal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txt_subtotal.Location = new Point(0, 134);
            txt_subtotal.Multiline = true;
            txt_subtotal.Name = "txt_subtotal";
            txt_subtotal.Size = new Size(217, 36);
            txt_subtotal.TabIndex = 3;
            // 
            // txt_descuento
            // 
            txt_descuento.BorderStyle = BorderStyle.FixedSingle;
            txt_descuento.Dock = DockStyle.Bottom;
            txt_descuento.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txt_descuento.Location = new Point(0, 170);
            txt_descuento.Multiline = true;
            txt_descuento.Name = "txt_descuento";
            txt_descuento.Size = new Size(217, 36);
            txt_descuento.TabIndex = 2;
            // 
            // txt_total
            // 
            txt_total.BorderStyle = BorderStyle.FixedSingle;
            txt_total.Dock = DockStyle.Bottom;
            txt_total.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txt_total.Location = new Point(0, 206);
            txt_total.Multiline = true;
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(217, 36);
            txt_total.TabIndex = 1;
            // 
            // dtg_caja
            // 
            dtg_caja.AllowUserToResizeColumns = false;
            dtg_caja.AllowUserToResizeRows = false;
            dtg_caja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_caja.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(61, 100, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_caja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_caja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_caja.Columns.AddRange(new DataGridViewColumn[] { CodigoBarra, Nombre, PrecioUnit, PrecioMayor, CantMinMayor, Cantidad, Subtotal });
            dtg_caja.Dock = DockStyle.Fill;
            dtg_caja.EditMode = DataGridViewEditMode.EditOnEnter;
            dtg_caja.EnableHeadersVisualStyles = false;
            dtg_caja.ImeMode = ImeMode.On;
            dtg_caja.Location = new Point(4, 4);
            dtg_caja.MultiSelect = false;
            dtg_caja.Name = "dtg_caja";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 125, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtg_caja.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtg_caja.RowHeadersVisible = false;
            dtg_caja.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtg_caja.Size = new Size(910, 501);
            dtg_caja.TabIndex = 31;
            dtg_caja.CellContentClick += dtg_caja_CellContentClick;
            dtg_caja.CellEndEdit += dtg_caja_CellEndEdit;
            // 
            // CodigoBarra
            // 
            CodigoBarra.HeaderText = "CodigoBarra";
            CodigoBarra.Name = "CodigoBarra";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // PrecioUnit
            // 
            PrecioUnit.HeaderText = "PrecioUnit";
            PrecioUnit.Name = "PrecioUnit";
            // 
            // PrecioMayor
            // 
            PrecioMayor.HeaderText = "PrecioMayor";
            PrecioMayor.Name = "PrecioMayor";
            // 
            // CantMinMayor
            // 
            CantMinMayor.HeaderText = "CantMinMayor";
            CantMinMayor.Name = "CantMinMayor";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel1);
            Name = "Caja";
            Size = new Size(1148, 698);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_art).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_caja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btn_buscar;
        private TextBox txt_buscar;
        private Panel panel1;
        private Button btn_añadir_desc;
        private TextBox txt_desc;
        private Button btn_desc;
        private Button btn_reem_desc;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Button btn_cancelarVenta;
        private Button btn_confiVenta;
        private Button button2;
        private Button button3;
        private DataGridView dtg_caja;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private Label label3;
        private ComboBox cmb_cliente;
        private Label label2;
        private ComboBox cmb_pago;
        private Label label1;
        private ComboBox cmb_factura;
        private Label label4;
        private ComboBox cmb_comprobante;
        private Panel panel4;
        private TextBox txt_subtotal;
        private TextBox txt_descuento;
        private TextBox txt_total;
        private Button btn_mostrar_vuelto;
        private Panel panel5;
        private Button btn_vuelto;
        private TextBox txt_vuelto;
        private PictureBox pcb_art;
        private DataGridViewTextBoxColumn CodigoBarra;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnit;
        private DataGridViewTextBoxColumn PrecioMayor;
        private DataGridViewTextBoxColumn CantMinMayor;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
    }
}
