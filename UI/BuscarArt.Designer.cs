namespace MyM26.UI
{
    partial class BuscarArt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarArt));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btn_salir = new Button();
            btn_buscar = new Button();
            dtg_caja = new DataGridView();
            CodigoBarra = new DataGridViewTextBoxColumn();
            CodigoArticulo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioUnit = new DataGridViewTextBoxColumn();
            PrecioMayor = new DataGridViewTextBoxColumn();
            CantMinMayor = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            txt_buscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_caja).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_salir
            // 
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Location = new Point(887, 7);
            btn_salir.Margin = new Padding(3, 4, 3, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(17, 20);
            btn_salir.TabIndex = 4;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_buscar.Dock = DockStyle.Right;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Location = new Point(383, 0);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(34, 41);
            btn_buscar.TabIndex = 33;
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
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
            dtg_caja.EditMode = DataGridViewEditMode.EditOnEnter;
            dtg_caja.EnableHeadersVisualStyles = false;
            dtg_caja.ImeMode = ImeMode.On;
            dtg_caja.Location = new Point(2, 83);
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
            dtg_caja.Size = new Size(910, 515);
            dtg_caja.TabIndex = 35;
            dtg_caja.CellContentClick += dtg_caja_CellContentClick;
            dtg_caja.CellContentDoubleClick += dtg_caja_CellContentDoubleClick;
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(btn_buscar);
            panel1.Location = new Point(9, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 43);
            panel1.TabIndex = 36;
            // 
            // txt_buscar
            // 
            txt_buscar.BorderStyle = BorderStyle.None;
            txt_buscar.Dock = DockStyle.Fill;
            txt_buscar.Location = new Point(0, 0);
            txt_buscar.Multiline = true;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(383, 41);
            txt_buscar.TabIndex = 37;
            txt_buscar.KeyDown += txt_buscar_KeyDown;
            // 
            // BuscarArt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(dtg_caja);
            Controls.Add(btn_salir);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BuscarArt";
            Text = "BuscarArt";
            Load += BuscarArt_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_caja).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_salir;
        private Button btn_buscar;
        private DataGridView dtg_caja;
        private DataGridViewTextBoxColumn CodigoBarra;
        private DataGridViewTextBoxColumn CodigoArticulo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioUnit;
        private DataGridViewTextBoxColumn PrecioMayor;
        private DataGridViewTextBoxColumn CantMinMayor;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private Panel panel1;
        private TextBox txt_buscar;
    }
}