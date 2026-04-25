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
            panel2 = new Panel();
            btn_cancelarVenta = new Button();
            btn_confiVenta = new Button();
            panel5 = new Panel();
            btn_cerrar_vuelto = new Button();
            btn_vuelto = new Button();
            txt_vuelto = new TextBox();
            btn_mostrar_vuelto = new Button();
            panel6 = new Panel();
            btn_sumar = new Button();
            btn_restar = new Button();
            numeric_restar = new NumericUpDown();
            button3 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            btn_buscar = new Button();
            txt_buscar = new TextBox();
            btn_modo = new Button();
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
            CodigoArticulo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioUnit = new DataGridViewTextBoxColumn();
            PrecioMayor = new DataGridViewTextBoxColumn();
            CantMinMayor = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            pdComprobante = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_restar).BeginInit();
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
            tableLayoutPanel1.Controls.Add(panel2, 4, 0);
            tableLayoutPanel1.Controls.Add(panel5, 3, 0);
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 730);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 201F));
            tableLayoutPanel1.Size = new Size(1312, 201);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_añadir_desc);
            panel1.Controls.Add(btn_reem_desc);
            panel1.Controls.Add(txt_desc);
            panel1.Controls.Add(btn_desc);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(527, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 193);
            panel1.TabIndex = 0;
            // 
            // btn_añadir_desc
            // 
            btn_añadir_desc.BackColor = Color.FromArgb(190, 43, 80);
            btn_añadir_desc.Dock = DockStyle.Top;
            btn_añadir_desc.FlatStyle = FlatStyle.Flat;
            btn_añadir_desc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_añadir_desc.ForeColor = Color.White;
            btn_añadir_desc.Location = new Point(0, 91);
            btn_añadir_desc.Margin = new Padding(3, 4, 3, 4);
            btn_añadir_desc.Name = "btn_añadir_desc";
            btn_añadir_desc.Size = new Size(256, 48);
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
            btn_reem_desc.Location = new Point(0, 145);
            btn_reem_desc.Margin = new Padding(3, 4, 3, 4);
            btn_reem_desc.Name = "btn_reem_desc";
            btn_reem_desc.Size = new Size(256, 48);
            btn_reem_desc.TabIndex = 3;
            btn_reem_desc.Text = "Reemplazar descuento";
            btn_reem_desc.UseVisualStyleBackColor = false;
            btn_reem_desc.Visible = false;
            btn_reem_desc.Click += btn_reem_desc_Click;
            // 
            // txt_desc
            // 
            txt_desc.BorderStyle = BorderStyle.FixedSingle;
            txt_desc.Dock = DockStyle.Top;
            txt_desc.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_desc.Location = new Point(0, 48);
            txt_desc.Margin = new Padding(3, 4, 3, 4);
            txt_desc.Multiline = true;
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(256, 43);
            txt_desc.TabIndex = 1;
            txt_desc.Visible = false;
            txt_desc.KeyDown += txt_buscar_KeyDown;
            txt_desc.KeyPress += txt_vuelto_KeyPress;
            txt_desc.MouseDown += txt_desc_MouseDown;
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
            btn_desc.Margin = new Padding(3, 4, 3, 4);
            btn_desc.Name = "btn_desc";
            btn_desc.Size = new Size(256, 48);
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
            button2.Location = new Point(265, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(256, 48);
            button2.TabIndex = 2;
            button2.Text = "Eliminar articulo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_cancelarVenta);
            panel2.Controls.Add(btn_confiVenta);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1051, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 193);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btn_cancelarVenta
            // 
            btn_cancelarVenta.BackColor = Color.FromArgb(100, 10, 56);
            btn_cancelarVenta.Dock = DockStyle.Top;
            btn_cancelarVenta.FlatStyle = FlatStyle.Flat;
            btn_cancelarVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_cancelarVenta.ForeColor = Color.White;
            btn_cancelarVenta.Location = new Point(0, 48);
            btn_cancelarVenta.Margin = new Padding(3, 4, 3, 4);
            btn_cancelarVenta.Name = "btn_cancelarVenta";
            btn_cancelarVenta.Size = new Size(258, 48);
            btn_cancelarVenta.TabIndex = 1;
            btn_cancelarVenta.Text = "Cancelar venta";
            btn_cancelarVenta.UseVisualStyleBackColor = false;
            btn_cancelarVenta.Click += btn_cancelarVenta_Click;
            // 
            // btn_confiVenta
            // 
            btn_confiVenta.BackColor = Color.FromArgb(10, 100, 56);
            btn_confiVenta.Dock = DockStyle.Top;
            btn_confiVenta.FlatStyle = FlatStyle.Flat;
            btn_confiVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_confiVenta.ForeColor = Color.White;
            btn_confiVenta.Location = new Point(0, 0);
            btn_confiVenta.Margin = new Padding(3, 4, 3, 4);
            btn_confiVenta.Name = "btn_confiVenta";
            btn_confiVenta.Size = new Size(258, 48);
            btn_confiVenta.TabIndex = 0;
            btn_confiVenta.Text = "Confirmar venta";
            btn_confiVenta.UseVisualStyleBackColor = false;
            btn_confiVenta.Click += btn_confiVenta_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_cerrar_vuelto);
            panel5.Controls.Add(btn_vuelto);
            panel5.Controls.Add(txt_vuelto);
            panel5.Controls.Add(btn_mostrar_vuelto);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(789, 4);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(256, 193);
            panel5.TabIndex = 4;
            // 
            // btn_cerrar_vuelto
            // 
            btn_cerrar_vuelto.BackColor = Color.FromArgb(10, 90, 153);
            btn_cerrar_vuelto.Dock = DockStyle.Top;
            btn_cerrar_vuelto.FlatStyle = FlatStyle.Flat;
            btn_cerrar_vuelto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_cerrar_vuelto.ForeColor = Color.White;
            btn_cerrar_vuelto.Location = new Point(0, 143);
            btn_cerrar_vuelto.Margin = new Padding(3, 4, 3, 4);
            btn_cerrar_vuelto.Name = "btn_cerrar_vuelto";
            btn_cerrar_vuelto.Size = new Size(256, 48);
            btn_cerrar_vuelto.TabIndex = 3;
            btn_cerrar_vuelto.Text = "Cerrar vuelto";
            btn_cerrar_vuelto.UseVisualStyleBackColor = false;
            btn_cerrar_vuelto.Visible = false;
            btn_cerrar_vuelto.Click += btn_cerrar_vuelto_Click;
            // 
            // btn_vuelto
            // 
            btn_vuelto.BackColor = Color.FromArgb(10, 90, 153);
            btn_vuelto.Dock = DockStyle.Top;
            btn_vuelto.FlatStyle = FlatStyle.Flat;
            btn_vuelto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_vuelto.ForeColor = Color.White;
            btn_vuelto.Location = new Point(0, 95);
            btn_vuelto.Margin = new Padding(3, 4, 3, 4);
            btn_vuelto.Name = "btn_vuelto";
            btn_vuelto.Size = new Size(256, 48);
            btn_vuelto.TabIndex = 2;
            btn_vuelto.Text = "Calcular";
            btn_vuelto.UseVisualStyleBackColor = false;
            btn_vuelto.Visible = false;
            btn_vuelto.Click += btn_vuelto_Click;
            // 
            // txt_vuelto
            // 
            txt_vuelto.BorderStyle = BorderStyle.FixedSingle;
            txt_vuelto.Dock = DockStyle.Top;
            txt_vuelto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txt_vuelto.Location = new Point(0, 48);
            txt_vuelto.Margin = new Padding(3, 4, 3, 4);
            txt_vuelto.Multiline = true;
            txt_vuelto.Name = "txt_vuelto";
            txt_vuelto.Size = new Size(256, 47);
            txt_vuelto.TabIndex = 1;
            txt_vuelto.Visible = false;
            txt_vuelto.DragEnter += txt_buscar_DragEnter;
            txt_vuelto.KeyPress += txt_vuelto_KeyPress;
            txt_vuelto.MouseDown += txt_desc_MouseDown;
            // 
            // btn_mostrar_vuelto
            // 
            btn_mostrar_vuelto.BackColor = Color.FromArgb(20, 100, 123);
            btn_mostrar_vuelto.Dock = DockStyle.Top;
            btn_mostrar_vuelto.FlatStyle = FlatStyle.Flat;
            btn_mostrar_vuelto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_mostrar_vuelto.ForeColor = Color.White;
            btn_mostrar_vuelto.Location = new Point(0, 0);
            btn_mostrar_vuelto.Margin = new Padding(3, 4, 3, 4);
            btn_mostrar_vuelto.Name = "btn_mostrar_vuelto";
            btn_mostrar_vuelto.Size = new Size(256, 48);
            btn_mostrar_vuelto.TabIndex = 0;
            btn_mostrar_vuelto.Text = "Calcular vuelto";
            btn_mostrar_vuelto.UseVisualStyleBackColor = false;
            btn_mostrar_vuelto.Click += btn_mostrar_vuelto_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btn_sumar);
            panel6.Controls.Add(btn_restar);
            panel6.Controls.Add(numeric_restar);
            panel6.Controls.Add(button3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 4);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(256, 193);
            panel6.TabIndex = 5;
            // 
            // btn_sumar
            // 
            btn_sumar.BackColor = Color.FromArgb(90, 43, 80);
            btn_sumar.Dock = DockStyle.Top;
            btn_sumar.FlatAppearance.BorderColor = Color.White;
            btn_sumar.FlatStyle = FlatStyle.Flat;
            btn_sumar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_sumar.ForeColor = Color.White;
            btn_sumar.Location = new Point(0, 123);
            btn_sumar.Margin = new Padding(3, 4, 3, 4);
            btn_sumar.Name = "btn_sumar";
            btn_sumar.Size = new Size(256, 48);
            btn_sumar.TabIndex = 6;
            btn_sumar.Text = "Sumar";
            btn_sumar.UseVisualStyleBackColor = false;
            btn_sumar.Visible = false;
            btn_sumar.Click += btn_sumar_Click;
            // 
            // btn_restar
            // 
            btn_restar.BackColor = Color.FromArgb(190, 43, 80);
            btn_restar.Dock = DockStyle.Top;
            btn_restar.FlatAppearance.BorderColor = Color.White;
            btn_restar.FlatStyle = FlatStyle.Flat;
            btn_restar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_restar.ForeColor = Color.White;
            btn_restar.Location = new Point(0, 75);
            btn_restar.Margin = new Padding(3, 4, 3, 4);
            btn_restar.Name = "btn_restar";
            btn_restar.Size = new Size(256, 48);
            btn_restar.TabIndex = 5;
            btn_restar.Text = "Restar";
            btn_restar.UseVisualStyleBackColor = false;
            btn_restar.Click += btn_restar_Click;
            // 
            // numeric_restar
            // 
            numeric_restar.Dock = DockStyle.Top;
            numeric_restar.Location = new Point(0, 48);
            numeric_restar.Margin = new Padding(3, 4, 3, 4);
            numeric_restar.Name = "numeric_restar";
            numeric_restar.Size = new Size(256, 27);
            numeric_restar.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(220, 120, 20);
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 0);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(256, 48);
            button3.TabIndex = 3;
            button3.Text = "Modificar articulo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.4898548F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.65358567F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.5142059F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3423538F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tableLayoutPanel4.Controls.Add(btn_buscar, 1, 0);
            tableLayoutPanel4.Controls.Add(txt_buscar, 0, 0);
            tableLayoutPanel4.Controls.Add(btn_modo, 4, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1312, 51);
            tableLayoutPanel4.TabIndex = 3;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // btn_buscar
            // 
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_buscar.Dock = DockStyle.Fill;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Location = new Point(287, 4);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(40, 43);
            btn_buscar.TabIndex = 7;
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.BorderStyle = BorderStyle.FixedSingle;
            txt_buscar.Dock = DockStyle.Fill;
            txt_buscar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_buscar.Location = new Point(3, 4);
            txt_buscar.Margin = new Padding(3, 4, 3, 4);
            txt_buscar.Multiline = true;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(278, 43);
            txt_buscar.TabIndex = 8;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            txt_buscar.DragEnter += txt_buscar_DragEnter;
            txt_buscar.KeyDown += txt_buscar_KeyDown;
            txt_buscar.KeyPress += txt_buscar_KeyPress;
            txt_buscar.MouseDown += txt_buscar_MouseDown;
            // 
            // btn_modo
            // 
            btn_modo.BackgroundImage = Properties.Resources.modo_claro;
            btn_modo.BackgroundImageLayout = ImageLayout.Stretch;
            btn_modo.Dock = DockStyle.Fill;
            btn_modo.FlatAppearance.BorderSize = 0;
            btn_modo.FlatStyle = FlatStyle.Flat;
            btn_modo.Location = new Point(1265, 3);
            btn_modo.Name = "btn_modo";
            btn_modo.Size = new Size(44, 45);
            btn_modo.TabIndex = 9;
            btn_modo.UseVisualStyleBackColor = true;
            btn_modo.Click += btn_modo_Click;
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
            tableLayoutPanel2.Location = new Point(0, 51);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1312, 679);
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
            tableLayoutPanel3.Location = new Point(1052, 5);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6958237F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3041763F));
            tableLayoutPanel3.Size = new Size(256, 669);
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
            panel3.Location = new Point(3, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 331);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 220);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 35;
            label3.Text = "Cliente";
            // 
            // cmb_cliente
            // 
            cmb_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmb_cliente.BackColor = Color.WhiteSmoke;
            cmb_cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_cliente.FormattingEnabled = true;
            cmb_cliente.Location = new Point(3, 244);
            cmb_cliente.Margin = new Padding(3, 4, 3, 4);
            cmb_cliente.Name = "cmb_cliente";
            cmb_cliente.Size = new Size(240, 28);
            cmb_cliente.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 153);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 33;
            label2.Text = "Forma de pago";
            // 
            // cmb_pago
            // 
            cmb_pago.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmb_pago.BackColor = Color.WhiteSmoke;
            cmb_pago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_pago.FormattingEnabled = true;
            cmb_pago.Location = new Point(3, 177);
            cmb_pago.Margin = new Padding(3, 4, 3, 4);
            cmb_pago.Name = "cmb_pago";
            cmb_pago.Size = new Size(240, 28);
            cmb_pago.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 83);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 31;
            label1.Text = "Tipo de factura";
            // 
            // cmb_factura
            // 
            cmb_factura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmb_factura.BackColor = Color.WhiteSmoke;
            cmb_factura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_factura.FormattingEnabled = true;
            cmb_factura.Location = new Point(3, 107);
            cmb_factura.Margin = new Padding(3, 4, 3, 4);
            cmb_factura.Name = "cmb_factura";
            cmb_factura.Size = new Size(240, 28);
            cmb_factura.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 29;
            label4.Text = "Tipo de comprobante";
            // 
            // cmb_comprobante
            // 
            cmb_comprobante.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmb_comprobante.BackColor = Color.WhiteSmoke;
            cmb_comprobante.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_comprobante.FormattingEnabled = true;
            cmb_comprobante.Location = new Point(1, 40);
            cmb_comprobante.Margin = new Padding(3, 4, 3, 4);
            cmb_comprobante.Name = "cmb_comprobante";
            cmb_comprobante.Size = new Size(243, 28);
            cmb_comprobante.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.Controls.Add(pcb_art);
            panel4.Controls.Add(txt_subtotal);
            panel4.Controls.Add(txt_descuento);
            panel4.Controls.Add(txt_total);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 343);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 322);
            panel4.TabIndex = 1;
            // 
            // pcb_art
            // 
            pcb_art.Anchor = AnchorStyles.Top;
            pcb_art.BorderStyle = BorderStyle.FixedSingle;
            pcb_art.Location = new Point(40, 3);
            pcb_art.Margin = new Padding(3, 4, 3, 4);
            pcb_art.Name = "pcb_art";
            pcb_art.Size = new Size(172, 170);
            pcb_art.TabIndex = 4;
            pcb_art.TabStop = false;
            // 
            // txt_subtotal
            // 
            txt_subtotal.BackColor = Color.White;
            txt_subtotal.BorderStyle = BorderStyle.FixedSingle;
            txt_subtotal.Dock = DockStyle.Bottom;
            txt_subtotal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txt_subtotal.Location = new Point(0, 181);
            txt_subtotal.Margin = new Padding(3, 4, 3, 4);
            txt_subtotal.Multiline = true;
            txt_subtotal.Name = "txt_subtotal";
            txt_subtotal.ReadOnly = true;
            txt_subtotal.Size = new Size(250, 47);
            txt_subtotal.TabIndex = 3;
            // 
            // txt_descuento
            // 
            txt_descuento.BackColor = Color.White;
            txt_descuento.BorderStyle = BorderStyle.FixedSingle;
            txt_descuento.Dock = DockStyle.Bottom;
            txt_descuento.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txt_descuento.Location = new Point(0, 228);
            txt_descuento.Margin = new Padding(3, 4, 3, 4);
            txt_descuento.Multiline = true;
            txt_descuento.Name = "txt_descuento";
            txt_descuento.ReadOnly = true;
            txt_descuento.Size = new Size(250, 47);
            txt_descuento.TabIndex = 2;
            // 
            // txt_total
            // 
            txt_total.BackColor = Color.White;
            txt_total.BorderStyle = BorderStyle.FixedSingle;
            txt_total.Dock = DockStyle.Bottom;
            txt_total.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txt_total.Location = new Point(0, 275);
            txt_total.Margin = new Padding(3, 4, 3, 4);
            txt_total.Multiline = true;
            txt_total.Name = "txt_total";
            txt_total.ReadOnly = true;
            txt_total.Size = new Size(250, 47);
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
            dtg_caja.Columns.AddRange(new DataGridViewColumn[] { CodigoBarra, CodigoArticulo, Nombre, PrecioUnit, PrecioMayor, CantMinMayor, Cantidad, Subtotal });
            dtg_caja.Dock = DockStyle.Fill;
            dtg_caja.EditMode = DataGridViewEditMode.EditOnEnter;
            dtg_caja.EnableHeadersVisualStyles = false;
            dtg_caja.ImeMode = ImeMode.On;
            dtg_caja.Location = new Point(4, 5);
            dtg_caja.Margin = new Padding(3, 4, 3, 4);
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
            dtg_caja.RowHeadersWidth = 51;
            dtg_caja.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtg_caja.Size = new Size(1041, 669);
            dtg_caja.TabIndex = 31;
            dtg_caja.CellContentClick += dtg_caja_CellContentClick;
            dtg_caja.CellContentDoubleClick += dtg_caja_CellContentDoubleClick;
            dtg_caja.CellEndEdit += dtg_caja_CellEndEdit;
            // 
            // CodigoBarra
            // 
            CodigoBarra.HeaderText = "CodigoBarra";
            CodigoBarra.MinimumWidth = 6;
            CodigoBarra.Name = "CodigoBarra";
            // 
            // CodigoArticulo
            // 
            CodigoArticulo.HeaderText = "CodigoArticulo";
            CodigoArticulo.MinimumWidth = 6;
            CodigoArticulo.Name = "CodigoArticulo";
            CodigoArticulo.ReadOnly = true;
            CodigoArticulo.Visible = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // PrecioUnit
            // 
            PrecioUnit.HeaderText = "PrecioUnit";
            PrecioUnit.MinimumWidth = 6;
            PrecioUnit.Name = "PrecioUnit";
            PrecioUnit.ReadOnly = true;
            // 
            // PrecioMayor
            // 
            PrecioMayor.HeaderText = "PrecioMayor";
            PrecioMayor.MinimumWidth = 6;
            PrecioMayor.Name = "PrecioMayor";
            PrecioMayor.ReadOnly = true;
            // 
            // CantMinMayor
            // 
            CantMinMayor.HeaderText = "CantMinMayor";
            CantMinMayor.MinimumWidth = 6;
            CantMinMayor.Name = "CantMinMayor";
            CantMinMayor.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Caja";
            Size = new Size(1312, 931);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numeric_restar).EndInit();
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
        
        private TextBox txt_vuelto;
        private Button btn_vuelto;
        private PictureBox pcb_art;
        private Button btn_cerrar_vuelto;
        private Panel panel6;
        private Button btn_sumar;
        private Button btn_restar;
        private NumericUpDown numeric_restar;
        private DataGridViewTextBoxColumn CodigoBarra;
        private DataGridViewTextBoxColumn CodigoArticulo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnit;
        private DataGridViewTextBoxColumn PrecioMayor;
        private DataGridViewTextBoxColumn CantMinMayor;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private System.Drawing.Printing.PrintDocument pdComprobante;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btn_modo;
    }
}
