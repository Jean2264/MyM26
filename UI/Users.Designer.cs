namespace MyM26.screens
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_añadirUsrr = new Button();
            txt_buscar = new TextBox();
            btn_buscar = new Button();
            btn_bajas = new Button();
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
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 430F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            tableLayoutPanel1.Controls.Add(btn_añadirUsrr, 3, 0);
            tableLayoutPanel1.Controls.Add(txt_buscar, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_buscar, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_bajas, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1341, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_añadirUsrr
            // 
            btn_añadirUsrr.BackColor = Color.FromArgb(20, 100, 134);
            btn_añadirUsrr.BackgroundImageLayout = ImageLayout.Stretch;
            btn_añadirUsrr.Dock = DockStyle.Fill;
            btn_añadirUsrr.FlatStyle = FlatStyle.Flat;
            btn_añadirUsrr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_añadirUsrr.ForeColor = Color.White;
            btn_añadirUsrr.Image = (Image)resources.GetObject("btn_añadirUsrr.Image");
            btn_añadirUsrr.ImageAlign = ContentAlignment.MiddleLeft;
            btn_añadirUsrr.Location = new Point(1082, 3);
            btn_añadirUsrr.Name = "btn_añadirUsrr";
            btn_añadirUsrr.Size = new Size(133, 34);
            btn_añadirUsrr.TabIndex = 1;
            btn_añadirUsrr.Text = "Agregar usuario";
            btn_añadirUsrr.TextAlign = ContentAlignment.MiddleRight;
            btn_añadirUsrr.UseVisualStyleBackColor = false;
            btn_añadirUsrr.Click += btn_añadirUsrr_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Dock = DockStyle.Fill;
            txt_buscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_buscar.Location = new Point(3, 3);
            txt_buscar.Multiline = true;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(604, 34);
            txt_buscar.TabIndex = 5;
            txt_buscar.DragEnter += txt_buscar_DragEnter;
            txt_buscar.KeyDown += txt_buscar_KeyDown;
            txt_buscar.KeyPress += txt_buscar_KeyPress;
            txt_buscar.MouseDown += txt_buscar_MouseDown;
            // 
            // btn_buscar
            // 
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_buscar.Dock = DockStyle.Fill;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Location = new Point(613, 3);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(33, 34);
            btn_buscar.TabIndex = 6;
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_bajas
            // 
            btn_bajas.BackColor = Color.FromArgb(70, 40, 134);
            btn_bajas.BackgroundImageLayout = ImageLayout.Stretch;
            btn_bajas.Dock = DockStyle.Fill;
            btn_bajas.FlatStyle = FlatStyle.Flat;
            btn_bajas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_bajas.ForeColor = Color.White;
            btn_bajas.Image = (Image)resources.GetObject("btn_bajas.Image");
            btn_bajas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bajas.Location = new Point(1221, 3);
            btn_bajas.Name = "btn_bajas";
            btn_bajas.Size = new Size(117, 34);
            btn_bajas.TabIndex = 2;
            btn_bajas.Text = "Ver bajas";
            btn_bajas.TextAlign = ContentAlignment.MiddleRight;
            btn_bajas.UseVisualStyleBackColor = false;
            btn_bajas.Click += button1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableLayoutPanel2.Controls.Add(btn_anterior, 1, 0);
            tableLayoutPanel2.Controls.Add(btn_siguente, 3, 0);
            tableLayoutPanel2.Controls.Add(lbl_paginas, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 5, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(0, 681);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(1341, 40);
            tableLayoutPanel2.TabIndex = 2;
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
            btn_anterior.Location = new Point(611, 3);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(92, 26);
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
            btn_siguente.Location = new Point(807, 3);
            btn_siguente.Name = "btn_siguente";
            btn_siguente.Size = new Size(92, 26);
            btn_siguente.TabIndex = 1;
            btn_siguente.Text = "Siguente";
            btn_siguente.UseVisualStyleBackColor = false;
            btn_siguente.Click += btn_siguente_Click;
            // 
            // lbl_paginas
            // 
            lbl_paginas.Anchor = AnchorStyles.None;
            lbl_paginas.AutoSize = true;
            lbl_paginas.Location = new Point(736, 8);
            lbl_paginas.Name = "lbl_paginas";
            lbl_paginas.Size = new Size(37, 15);
            lbl_paginas.TabIndex = 2;
            lbl_paginas.Text = "label1";
            lbl_paginas.Click += lbl_paginas_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(1209, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 4;
            label1.Text = "\r\nlabel1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1341, 641);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Users";
            Size = new Size(1341, 721);
            Load += Users_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_añadirUsrr;
        private TextBox txt_buscar;
        private Button btn_buscar;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_bajas;
        private Button btn_anterior;
        private Button btn_siguente;
        private Label lbl_paginas;
        private Label label1;
    }
}
