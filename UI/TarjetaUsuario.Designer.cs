namespace MyM26.screens
{
    partial class TarjetaUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarjetaUsuario));
            lbl_nombre = new Label();
            lbl_tipo = new Label();
            lbl_dni = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            btn_editar = new Button();
            panel2 = new Panel();
            pic_usu = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_usu).BeginInit();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombre.ForeColor = Color.Black;
            lbl_nombre.Location = new Point(3, 134);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Padding = new Padding(10, 0, 0, 0);
            lbl_nombre.Size = new Size(80, 23);
            lbl_nombre.TabIndex = 7;
            lbl_nombre.Text = "nombre";
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tipo.ForeColor = Color.Black;
            lbl_tipo.Location = new Point(3, 162);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Padding = new Padding(10, 0, 0, 0);
            lbl_tipo.Size = new Size(50, 23);
            lbl_tipo.TabIndex = 9;
            lbl_tipo.Text = "tipo";
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dni.ForeColor = Color.Black;
            lbl_dni.Location = new Point(3, 194);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Padding = new Padding(10, 0, 0, 0);
            lbl_dni.Size = new Size(44, 23);
            lbl_dni.TabIndex = 8;
            lbl_dni.Text = "dni";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(0, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 303);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 5);
            tableLayoutPanel1.Controls.Add(lbl_dni, 0, 3);
            tableLayoutPanel1.Controls.Add(lbl_nombre, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_tipo, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.71605F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.28395F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(179, 303);
            tableLayoutPanel1.TabIndex = 11;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
            tableLayoutPanel2.Controls.Add(button2, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 2, 0);
            tableLayoutPanel2.Controls.Add(btn_editar, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 235);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(173, 42);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(13, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(32, 34);
            button2.TabIndex = 13;
            toolTip1.SetToolTip(button2, "Inspeccionar usuario");
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(129, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(32, 34);
            button1.TabIndex = 11;
            toolTip1.SetToolTip(button1, "Eliminar usuario");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.None;
            btn_editar.BackgroundImage = (Image)resources.GetObject("btn_editar.BackgroundImage");
            btn_editar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.FlatAppearance.BorderSize = 0;
            btn_editar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btn_editar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_editar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Location = new Point(72, 4);
            btn_editar.Margin = new Padding(3, 4, 3, 4);
            btn_editar.Name = "btn_editar";
            btn_editar.Padding = new Padding(10, 0, 0, 0);
            btn_editar.Size = new Size(32, 34);
            btn_editar.TabIndex = 12;
            btn_editar.Tag = "";
            toolTip1.SetToolTip(btn_editar, "Modificar usuario");
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pic_usu);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 128);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // pic_usu
            // 
            pic_usu.BackColor = Color.Transparent;
            pic_usu.BackgroundImageLayout = ImageLayout.Zoom;
            pic_usu.Location = new Point(33, 7);
            pic_usu.Margin = new Padding(3, 4, 3, 4);
            pic_usu.Name = "pic_usu";
            pic_usu.Size = new Size(107, 108);
            pic_usu.TabIndex = 7;
            pic_usu.TabStop = false;
            // 
            // TarjetaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TarjetaUsuario";
            Size = new Size(179, 303);
            Load += TargetaUsuario_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_usu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public Label lbl_nombre;
        public Label lbl_tipo;
        public Label lbl_dni;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button2;
        private Button button1;
        private Button btn_editar;
        private Panel panel2;
        public PictureBox pic_usu;
        private ToolTip toolTip1;
    }
}
