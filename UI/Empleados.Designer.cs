namespace MyM26.UI
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_eliminar = new Button();
            btn_editar = new Button();
            btn_añadir = new Button();
            txt_buscar = new TextBox();
            btn_buscar = new Button();
            btn_bajas = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_anterior = new Button();
            btn_siguente = new Button();
            lbl_paginas = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 197F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btn_eliminar, 5, 0);
            tableLayoutPanel1.Controls.Add(btn_editar, 4, 0);
            tableLayoutPanel1.Controls.Add(btn_añadir, 3, 0);
            tableLayoutPanel1.Controls.Add(txt_buscar, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_buscar, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_bajas, 6, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1148, 40);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(30, 40, 134);
            btn_eliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_eliminar.Dock = DockStyle.Fill;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Image = (Image)resources.GetObject("btn_eliminar.Image");
            btn_eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eliminar.Location = new Point(867, 3);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(152, 34);
            btn_eliminar.TabIndex = 3;
            btn_eliminar.Text = "Eliminar empleado";
            btn_eliminar.TextAlign = ContentAlignment.MiddleRight;
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.FromArgb(235, 129, 10);
            btn_editar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_editar.Dock = DockStyle.Fill;
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar.ForeColor = Color.White;
            btn_editar.Image = (Image)resources.GetObject("btn_editar.Image");
            btn_editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_editar.Location = new Point(728, 3);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(133, 34);
            btn_editar.TabIndex = 4;
            btn_editar.Text = "Editar empleado";
            btn_editar.TextAlign = ContentAlignment.MiddleRight;
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_añadir
            // 
            btn_añadir.BackColor = Color.FromArgb(20, 100, 134);
            btn_añadir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_añadir.Dock = DockStyle.Fill;
            btn_añadir.FlatStyle = FlatStyle.Flat;
            btn_añadir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_añadir.ForeColor = Color.White;
            btn_añadir.Image = (Image)resources.GetObject("btn_añadir.Image");
            btn_añadir.ImageAlign = ContentAlignment.MiddleLeft;
            btn_añadir.Location = new Point(581, 3);
            btn_añadir.Name = "btn_añadir";
            btn_añadir.Size = new Size(141, 34);
            btn_añadir.TabIndex = 1;
            btn_añadir.Text = "Añadir empleado";
            btn_añadir.TextAlign = ContentAlignment.MiddleRight;
            btn_añadir.UseVisualStyleBackColor = false;
            btn_añadir.Click += btn_añadir_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Dock = DockStyle.Fill;
            txt_buscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_buscar.Location = new Point(3, 3);
            txt_buscar.Multiline = true;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(340, 34);
            txt_buscar.TabIndex = 5;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
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
            btn_buscar.Location = new Point(349, 3);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(29, 34);
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
            btn_bajas.Location = new Point(1025, 3);
            btn_bajas.Name = "btn_bajas";
            btn_bajas.Size = new Size(120, 34);
            btn_bajas.TabIndex = 2;
            btn_bajas.Text = "Ver bajas";
            btn_bajas.TextAlign = ContentAlignment.MiddleRight;
            btn_bajas.UseVisualStyleBackColor = false;
            btn_bajas.Click += btn_bajas_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 299F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163F));
            tableLayoutPanel2.Controls.Add(btn_anterior, 1, 0);
            tableLayoutPanel2.Controls.Add(btn_siguente, 3, 0);
            tableLayoutPanel2.Controls.Add(lbl_paginas, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 5, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(0, 654);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(1148, 44);
            tableLayoutPanel2.TabIndex = 4;
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
            btn_anterior.Location = new Point(351, 3);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(101, 30);
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
            btn_siguente.Location = new Point(582, 3);
            btn_siguente.Name = "btn_siguente";
            btn_siguente.Size = new Size(101, 30);
            btn_siguente.TabIndex = 1;
            btn_siguente.Text = "Siguente";
            btn_siguente.UseVisualStyleBackColor = false;
            btn_siguente.Click += btn_siguente_Click;
            // 
            // lbl_paginas
            // 
            lbl_paginas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_paginas.AutoSize = true;
            lbl_paginas.Location = new Point(498, 0);
            lbl_paginas.Name = "lbl_paginas";
            lbl_paginas.Size = new Size(37, 36);
            lbl_paginas.TabIndex = 2;
            lbl_paginas.Text = "\r\nlabel1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(988, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 36);
            label1.TabIndex = 3;
            label1.Text = "\r\nlabel1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(61, 100, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ImeMode = ImeMode.On;
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 125, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1148, 614);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Empleados";
            Size = new Size(1148, 698);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_añadir;
        private TextBox txt_buscar;
        private Button btn_buscar;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_anterior;
        private Button btn_siguente;
        private Label lbl_paginas;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btn_bajas;
    }
}
