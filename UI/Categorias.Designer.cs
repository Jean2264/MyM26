namespace MyM26.screens
{
    partial class Categorias
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            btn_salir = new Button();
            tabControl1 = new TabControl();
            tabcategoria = new TabPage();
            lbl_total_cat = new Label();
            btn_sig_cat = new Button();
            lbl_pag_cat = new Label();
            lbl_ant_cat = new Button();
            dtg_Cate = new DataGridView();
            label2 = new Label();
            btn_eliminarCate = new Button();
            btn_añadirCate = new Button();
            txt_cate = new TextBox();
            tabSub = new TabPage();
            lbl_total = new Label();
            btn_siguente = new Button();
            lbl_paginas = new Label();
            btn_anterior = new Button();
            label4 = new Label();
            cmb_cate = new ComboBox();
            dtg_Subcate = new DataGridView();
            label3 = new Label();
            btn_eliminarSub = new Button();
            btn_añadirSub = new Button();
            txt_sub = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabcategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Cate).BeginInit();
            tabSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Subcate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_salir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 26);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 24;
            label1.Text = "Categorias y subcategorias";
            // 
            // btn_salir
            // 
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Location = new Point(340, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(15, 15);
            btn_salir.TabIndex = 3;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabcategoria);
            tabControl1.Controls.Add(tabSub);
            tabControl1.Location = new Point(5, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(350, 358);
            tabControl1.TabIndex = 4;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabcategoria
            // 
            tabcategoria.BackColor = Color.White;
            tabcategoria.Controls.Add(lbl_total_cat);
            tabcategoria.Controls.Add(btn_sig_cat);
            tabcategoria.Controls.Add(lbl_pag_cat);
            tabcategoria.Controls.Add(lbl_ant_cat);
            tabcategoria.Controls.Add(dtg_Cate);
            tabcategoria.Controls.Add(label2);
            tabcategoria.Controls.Add(btn_eliminarCate);
            tabcategoria.Controls.Add(btn_añadirCate);
            tabcategoria.Controls.Add(txt_cate);
            tabcategoria.Location = new Point(4, 24);
            tabcategoria.Name = "tabcategoria";
            tabcategoria.Padding = new Padding(3);
            tabcategoria.Size = new Size(342, 330);
            tabcategoria.TabIndex = 0;
            tabcategoria.Text = "Categoria";
            // 
            // lbl_total_cat
            // 
            lbl_total_cat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_total_cat.AutoSize = true;
            lbl_total_cat.Location = new Point(204, 293);
            lbl_total_cat.Name = "lbl_total_cat";
            lbl_total_cat.Size = new Size(38, 30);
            lbl_total_cat.TabIndex = 40;
            lbl_total_cat.Text = "\r\nlabel1";
            // 
            // btn_sig_cat
            // 
            btn_sig_cat.BackColor = Color.Transparent;
            btn_sig_cat.BackgroundImage = (Image)resources.GetObject("btn_sig_cat.BackgroundImage");
            btn_sig_cat.BackgroundImageLayout = ImageLayout.Stretch;
            btn_sig_cat.FlatAppearance.BorderSize = 0;
            btn_sig_cat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_sig_cat.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_sig_cat.FlatStyle = FlatStyle.Flat;
            btn_sig_cat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_sig_cat.ForeColor = Color.White;
            btn_sig_cat.Location = new Point(121, 293);
            btn_sig_cat.Name = "btn_sig_cat";
            btn_sig_cat.Size = new Size(29, 30);
            btn_sig_cat.TabIndex = 39;
            btn_sig_cat.UseVisualStyleBackColor = false;
            btn_sig_cat.Click += btn_sig_cat_Click;
            // 
            // lbl_pag_cat
            // 
            lbl_pag_cat.Anchor = AnchorStyles.None;
            lbl_pag_cat.AutoSize = true;
            lbl_pag_cat.Location = new Point(56, 293);
            lbl_pag_cat.Name = "lbl_pag_cat";
            lbl_pag_cat.Size = new Size(38, 30);
            lbl_pag_cat.TabIndex = 38;
            lbl_pag_cat.Text = "\r\nlabel1";
            // 
            // lbl_ant_cat
            // 
            lbl_ant_cat.BackColor = Color.Transparent;
            lbl_ant_cat.BackgroundImage = (Image)resources.GetObject("lbl_ant_cat.BackgroundImage");
            lbl_ant_cat.BackgroundImageLayout = ImageLayout.Stretch;
            lbl_ant_cat.FlatAppearance.BorderSize = 0;
            lbl_ant_cat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            lbl_ant_cat.FlatAppearance.MouseOverBackColor = Color.Transparent;
            lbl_ant_cat.FlatStyle = FlatStyle.Flat;
            lbl_ant_cat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_ant_cat.ForeColor = Color.White;
            lbl_ant_cat.Location = new Point(4, 293);
            lbl_ant_cat.Name = "lbl_ant_cat";
            lbl_ant_cat.Size = new Size(29, 30);
            lbl_ant_cat.TabIndex = 37;
            lbl_ant_cat.UseVisualStyleBackColor = false;
            lbl_ant_cat.Click += lbl_ant_cat_Click;
            // 
            // dtg_Cate
            // 
            dtg_Cate.AllowUserToResizeColumns = false;
            dtg_Cate.AllowUserToResizeRows = false;
            dtg_Cate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Cate.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(61, 100, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_Cate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_Cate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Cate.EnableHeadersVisualStyles = false;
            dtg_Cate.ImeMode = ImeMode.On;
            dtg_Cate.Location = new Point(3, 59);
            dtg_Cate.Name = "dtg_Cate";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 125, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtg_Cate.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtg_Cate.RowHeadersVisible = false;
            dtg_Cate.Size = new Size(333, 228);
            dtg_Cate.TabIndex = 25;
            dtg_Cate.CellContentClick += dtg_Cate_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 24;
            label2.Text = "Nombre categoria";
            // 
            // btn_eliminarCate
            // 
            btn_eliminarCate.BackColor = Color.FromArgb(200, 20, 20);
            btn_eliminarCate.FlatStyle = FlatStyle.Flat;
            btn_eliminarCate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminarCate.ForeColor = Color.White;
            btn_eliminarCate.Location = new Point(269, 25);
            btn_eliminarCate.Name = "btn_eliminarCate";
            btn_eliminarCate.Size = new Size(70, 28);
            btn_eliminarCate.TabIndex = 2;
            btn_eliminarCate.Text = "Eliminar";
            btn_eliminarCate.UseVisualStyleBackColor = false;
            btn_eliminarCate.Click += btn_eliminarCate_Click;
            // 
            // btn_añadirCate
            // 
            btn_añadirCate.BackColor = Color.FromArgb(20, 134, 223);
            btn_añadirCate.FlatStyle = FlatStyle.Flat;
            btn_añadirCate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_añadirCate.ForeColor = Color.White;
            btn_añadirCate.Location = new Point(193, 25);
            btn_añadirCate.Name = "btn_añadirCate";
            btn_añadirCate.Size = new Size(70, 28);
            btn_añadirCate.TabIndex = 1;
            btn_añadirCate.Text = "Añadir";
            btn_añadirCate.UseVisualStyleBackColor = false;
            btn_añadirCate.Click += btn_añadirCate_Click;
            // 
            // txt_cate
            // 
            txt_cate.Location = new Point(6, 27);
            txt_cate.Multiline = true;
            txt_cate.Name = "txt_cate";
            txt_cate.Size = new Size(161, 24);
            txt_cate.TabIndex = 0;
            // 
            // tabSub
            // 
            tabSub.BackColor = Color.White;
            tabSub.Controls.Add(lbl_total);
            tabSub.Controls.Add(btn_siguente);
            tabSub.Controls.Add(lbl_paginas);
            tabSub.Controls.Add(btn_anterior);
            tabSub.Controls.Add(label4);
            tabSub.Controls.Add(cmb_cate);
            tabSub.Controls.Add(dtg_Subcate);
            tabSub.Controls.Add(label3);
            tabSub.Controls.Add(btn_eliminarSub);
            tabSub.Controls.Add(btn_añadirSub);
            tabSub.Controls.Add(txt_sub);
            tabSub.Location = new Point(4, 24);
            tabSub.Name = "tabSub";
            tabSub.Padding = new Padding(3);
            tabSub.Size = new Size(342, 330);
            tabSub.TabIndex = 1;
            tabSub.Text = "Subcategoria";
            // 
            // lbl_total
            // 
            lbl_total.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(206, 293);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(38, 30);
            lbl_total.TabIndex = 36;
            lbl_total.Text = "\r\nlabel1";
            // 
            // btn_siguente
            // 
            btn_siguente.BackColor = Color.Transparent;
            btn_siguente.BackgroundImage = (Image)resources.GetObject("btn_siguente.BackgroundImage");
            btn_siguente.BackgroundImageLayout = ImageLayout.Stretch;
            btn_siguente.FlatAppearance.BorderSize = 0;
            btn_siguente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_siguente.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_siguente.FlatStyle = FlatStyle.Flat;
            btn_siguente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_siguente.ForeColor = Color.White;
            btn_siguente.Location = new Point(123, 293);
            btn_siguente.Name = "btn_siguente";
            btn_siguente.Size = new Size(29, 30);
            btn_siguente.TabIndex = 35;
            btn_siguente.UseVisualStyleBackColor = false;
            // 
            // lbl_paginas
            // 
            lbl_paginas.Anchor = AnchorStyles.None;
            lbl_paginas.AutoSize = true;
            lbl_paginas.Location = new Point(58, 293);
            lbl_paginas.Name = "lbl_paginas";
            lbl_paginas.Size = new Size(38, 30);
            lbl_paginas.TabIndex = 34;
            lbl_paginas.Text = "\r\nlabel1";
            // 
            // btn_anterior
            // 
            btn_anterior.BackColor = Color.Transparent;
            btn_anterior.BackgroundImage = (Image)resources.GetObject("btn_anterior.BackgroundImage");
            btn_anterior.BackgroundImageLayout = ImageLayout.Stretch;
            btn_anterior.FlatAppearance.BorderSize = 0;
            btn_anterior.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_anterior.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_anterior.FlatStyle = FlatStyle.Flat;
            btn_anterior.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_anterior.ForeColor = Color.White;
            btn_anterior.Location = new Point(6, 293);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(29, 30);
            btn_anterior.TabIndex = 33;
            btn_anterior.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 6);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 32;
            label4.Text = "Categoria";
            // 
            // cmb_cate
            // 
            cmb_cate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_cate.FormattingEnabled = true;
            cmb_cate.Location = new Point(6, 24);
            cmb_cate.Name = "cmb_cate";
            cmb_cate.Size = new Size(161, 23);
            cmb_cate.TabIndex = 31;
            // 
            // dtg_Subcate
            // 
            dtg_Subcate.AllowUserToResizeColumns = false;
            dtg_Subcate.AllowUserToResizeRows = false;
            dtg_Subcate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Subcate.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(61, 100, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtg_Subcate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtg_Subcate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Subcate.EnableHeadersVisualStyles = false;
            dtg_Subcate.ImeMode = ImeMode.On;
            dtg_Subcate.Location = new Point(3, 108);
            dtg_Subcate.Name = "dtg_Subcate";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 125, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtg_Subcate.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtg_Subcate.RowHeadersVisible = false;
            dtg_Subcate.Size = new Size(333, 179);
            dtg_Subcate.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 59);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 29;
            label3.Text = "Nombre subcategoria";
            // 
            // btn_eliminarSub
            // 
            btn_eliminarSub.BackColor = Color.FromArgb(200, 20, 20);
            btn_eliminarSub.FlatStyle = FlatStyle.Flat;
            btn_eliminarSub.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_eliminarSub.ForeColor = Color.White;
            btn_eliminarSub.Location = new Point(266, 77);
            btn_eliminarSub.Name = "btn_eliminarSub";
            btn_eliminarSub.Size = new Size(70, 28);
            btn_eliminarSub.TabIndex = 28;
            btn_eliminarSub.Text = "Eliminar";
            btn_eliminarSub.UseVisualStyleBackColor = false;
            btn_eliminarSub.Click += btn_eliminarSub_Click;
            // 
            // btn_añadirSub
            // 
            btn_añadirSub.BackColor = Color.FromArgb(20, 134, 223);
            btn_añadirSub.FlatStyle = FlatStyle.Flat;
            btn_añadirSub.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_añadirSub.ForeColor = Color.White;
            btn_añadirSub.Location = new Point(190, 77);
            btn_añadirSub.Name = "btn_añadirSub";
            btn_añadirSub.Size = new Size(70, 28);
            btn_añadirSub.TabIndex = 27;
            btn_añadirSub.Text = "Añadir";
            btn_añadirSub.UseVisualStyleBackColor = false;
            btn_añadirSub.Click += btn_añadirSub_Click;
            // 
            // txt_sub
            // 
            txt_sub.Location = new Point(6, 77);
            txt_sub.Multiline = true;
            txt_sub.Name = "txt_sub";
            txt_sub.Size = new Size(161, 24);
            txt_sub.TabIndex = 26;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(360, 386);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categorias";
            Text = "Categorias";
            Load += Categorias_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabcategoria.ResumeLayout(false);
            tabcategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Cate).EndInit();
            tabSub.ResumeLayout(false);
            tabSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Subcate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_salir;
        private TabControl tabControl1;
        private TabPage tabcategoria;
        private TabPage tabSub;
        private Label label1;
        private TextBox txt_cate;
        private Button btn_añadirCate;
        private Button btn_eliminarCate;
        private Label label2;
        private DataGridView dtg_Cate;
        private Label label4;
        private ComboBox cmb_cate;
        private DataGridView dtg_Subcate;
        private Label label3;
        private Button btn_eliminarSub;
        private Button btn_añadirSub;
        private TextBox txt_sub;
        private ErrorProvider errorProvider1;
        private Button btn_anterior;
        private Label lbl_paginas;
        private Button btn_siguente;
        private Label lbl_total;
        private Label lbl_total_cat;
        private Button btn_sig_cat;
        private Label lbl_pag_cat;
        private Button lbl_ant_cat;
    }
}