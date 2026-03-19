namespace MyM26.screens
{
    partial class Articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulos));
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_menu = new Button();
            btn_buscar = new Button();
            txt_buscar = new TextBox();
            btn_bajas = new Button();
            btn_añadir = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_anterior = new Button();
            btn_siguente = new Button();
            lbl_paginas = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 276F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 517F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.Controls.Add(btn_menu, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_buscar, 2, 0);
            tableLayoutPanel1.Controls.Add(txt_buscar, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_bajas, 6, 0);
            tableLayoutPanel1.Controls.Add(btn_añadir, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1148, 40);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_menu
            // 
            btn_menu.BackColor = Color.White;
            btn_menu.BackgroundImage = (Image)resources.GetObject("btn_menu.BackgroundImage");
            btn_menu.BackgroundImageLayout = ImageLayout.Stretch;
            btn_menu.FlatAppearance.BorderSize = 0;
            btn_menu.FlatStyle = FlatStyle.Flat;
            btn_menu.Location = new Point(3, 3);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(30, 34);
            btn_menu.TabIndex = 4;
            btn_menu.UseVisualStyleBackColor = false;
            btn_menu.Click += btn_menu_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_buscar.Dock = DockStyle.Fill;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Location = new Point(315, 3);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(36, 34);
            btn_buscar.TabIndex = 6;
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Anchor = AnchorStyles.None;
            txt_buscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_buscar.Location = new Point(43, 3);
            txt_buscar.Multiline = true;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(262, 34);
            txt_buscar.TabIndex = 5;
            txt_buscar.DragEnter += txt_buscar_DragEnter;
            txt_buscar.KeyDown += txt_buscar_KeyDown;
            txt_buscar.KeyPress += txt_buscar_KeyPress;
            txt_buscar.MouseDown += txt_buscar_MouseDown;
            // 
            // btn_bajas
            // 
            btn_bajas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_bajas.BackColor = Color.FromArgb(70, 40, 134);
            btn_bajas.BackgroundImageLayout = ImageLayout.Stretch;
            btn_bajas.FlatStyle = FlatStyle.Flat;
            btn_bajas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_bajas.ForeColor = Color.White;
            btn_bajas.Image = (Image)resources.GetObject("btn_bajas.Image");
            btn_bajas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bajas.Location = new Point(1055, 3);
            btn_bajas.Name = "btn_bajas";
            btn_bajas.Size = new Size(90, 34);
            btn_bajas.TabIndex = 2;
            btn_bajas.Text = "Ver bajas";
            btn_bajas.TextAlign = ContentAlignment.MiddleRight;
            btn_bajas.UseVisualStyleBackColor = false;
            btn_bajas.Click += btn_bajas_Click;
            // 
            // btn_añadir
            // 
            btn_añadir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_añadir.BackColor = Color.FromArgb(20, 100, 134);
            btn_añadir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_añadir.FlatStyle = FlatStyle.Flat;
            btn_añadir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_añadir.ForeColor = Color.White;
            btn_añadir.Image = (Image)resources.GetObject("btn_añadir.Image");
            btn_añadir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_añadir.Location = new Point(927, 3);
            btn_añadir.Name = "btn_añadir";
            btn_añadir.Size = new Size(122, 34);
            btn_añadir.TabIndex = 1;
            btn_añadir.Text = "Añadir articulo";
            btn_añadir.TextAlign = ContentAlignment.MiddleRight;
            btn_añadir.UseVisualStyleBackColor = false;
            btn_añadir.Click += btn_añadir_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.14285F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8571472F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableLayoutPanel2.Controls.Add(btn_anterior, 1, 0);
            tableLayoutPanel2.Controls.Add(btn_siguente, 3, 0);
            tableLayoutPanel2.Controls.Add(lbl_paginas, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 5, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(0, 658);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(1148, 40);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btn_anterior
            // 
            btn_anterior.BackColor = Color.FromArgb(0, 150, 30);
            btn_anterior.BackgroundImageLayout = ImageLayout.None;
            btn_anterior.Dock = DockStyle.Fill;
            btn_anterior.FlatAppearance.BorderSize = 0;
            btn_anterior.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 170, 70);
            btn_anterior.FlatStyle = FlatStyle.Flat;
            btn_anterior.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_anterior.ForeColor = Color.White;
            btn_anterior.Location = new Point(396, 3);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(101, 26);
            btn_anterior.TabIndex = 0;
            btn_anterior.Text = "Anterior";
            btn_anterior.UseVisualStyleBackColor = false;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // btn_siguente
            // 
            btn_siguente.BackColor = Color.FromArgb(0, 150, 30);
            btn_siguente.BackgroundImageLayout = ImageLayout.None;
            btn_siguente.Dock = DockStyle.Fill;
            btn_siguente.FlatAppearance.BorderSize = 0;
            btn_siguente.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 170, 70);
            btn_siguente.FlatStyle = FlatStyle.Flat;
            btn_siguente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_siguente.ForeColor = Color.White;
            btn_siguente.Location = new Point(611, 3);
            btn_siguente.Name = "btn_siguente";
            btn_siguente.Size = new Size(105, 26);
            btn_siguente.TabIndex = 1;
            btn_siguente.Text = "Siguente";
            btn_siguente.UseVisualStyleBackColor = false;
            btn_siguente.Click += btn_siguente_Click;
            // 
            // lbl_paginas
            // 
            lbl_paginas.Anchor = AnchorStyles.None;
            lbl_paginas.AutoSize = true;
            lbl_paginas.Location = new Point(535, 8);
            lbl_paginas.Name = "lbl_paginas";
            lbl_paginas.Size = new Size(37, 15);
            lbl_paginas.TabIndex = 2;
            lbl_paginas.Text = "label1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(1016, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 4;
            label1.Text = "\r\nlabel1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(40, 5, 40, 5);
            flowLayoutPanel1.Size = new Size(1148, 618);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // Articulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Articulos";
            Size = new Size(1148, 698);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_añadir;
        private TextBox txt_buscar;
        private Button btn_buscar;
        private Button btn_bajas;
        private Button btn_menu;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_anterior;
        private Button btn_siguente;
        private Label lbl_paginas;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}
