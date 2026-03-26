namespace MyM26.UI
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_anterior = new Button();
            btn_siguente = new Button();
            lbl_paginas = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txt_buscar = new TextBox();
            btn_buscar = new Button();
            btn_añadirUsrr = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            tableLayoutPanel2.TabIndex = 5;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 472F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136F));
            tableLayoutPanel1.Controls.Add(txt_buscar, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_buscar, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_añadirUsrr, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1148, 40);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // txt_buscar
            // 
            txt_buscar.Dock = DockStyle.Fill;
            txt_buscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_buscar.Location = new Point(3, 3);
            txt_buscar.Multiline = true;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(328, 34);
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
            btn_buscar.Location = new Point(337, 3);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(33, 34);
            btn_buscar.TabIndex = 6;
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
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
            btn_añadirUsrr.Location = new Point(1015, 3);
            btn_añadirUsrr.Name = "btn_añadirUsrr";
            btn_añadirUsrr.Size = new Size(130, 34);
            btn_añadirUsrr.TabIndex = 1;
            btn_añadirUsrr.Text = "Agregar compra";
            btn_añadirUsrr.TextAlign = ContentAlignment.MiddleRight;
            btn_añadirUsrr.UseVisualStyleBackColor = false;
            btn_añadirUsrr.Click += btn_añadirUsrr_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(61, 100, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ImeMode = ImeMode.On;
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 125, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1148, 614);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "Compras";
            Size = new Size(1148, 698);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_anterior;
        private Button btn_siguente;
        private Label lbl_paginas;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_añadirUsrr;
        private TextBox txt_buscar;
        private Button btn_buscar;
        private DataGridView dataGridView1;
    }
}
