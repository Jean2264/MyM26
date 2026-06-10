namespace MyM26.UI
{
    partial class Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel3 = new Panel();
            txt_buscar_sub = new TextBox();
            btn_buscar = new Button();
            label6 = new Label();
            dtg_Subcate = new DataGridView();
            btn_siguente = new Button();
            lbl_paginas = new Label();
            btn_anterior = new Button();
            panel1 = new Panel();
            btn_salir = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Subcate).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txt_buscar_sub);
            panel3.Controls.Add(btn_buscar);
            panel3.Location = new Point(11, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 38);
            panel3.TabIndex = 44;
            // 
            // txt_buscar_sub
            // 
            txt_buscar_sub.BorderStyle = BorderStyle.None;
            txt_buscar_sub.Dock = DockStyle.Fill;
            txt_buscar_sub.Font = new Font("Segoe UI", 14F);
            txt_buscar_sub.Location = new Point(0, 0);
            txt_buscar_sub.Multiline = true;
            txt_buscar_sub.Name = "txt_buscar_sub";
            txt_buscar_sub.Size = new Size(228, 36);
            txt_buscar_sub.TabIndex = 7;
            txt_buscar_sub.DragEnter += txt_buscar_sub_DragEnter;
            txt_buscar_sub.KeyDown += txt_buscar_sub_KeyDown;
            txt_buscar_sub.KeyPress += txt_buscar_sub_KeyPress;
            txt_buscar_sub.MouseDown += txt_buscar_sub_MouseDown;
            // 
            // btn_buscar
            // 
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_buscar.Dock = DockStyle.Right;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Location = new Point(228, 0);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(29, 36);
            btn_buscar.TabIndex = 6;
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 55);
            label6.Name = "label6";
            label6.Size = new Size(191, 20);
            label6.TabIndex = 45;
            label6.Text = "Buscar proveedor deseado";
            // 
            // dtg_Subcate
            // 
            dtg_Subcate.AllowUserToResizeColumns = false;
            dtg_Subcate.AllowUserToResizeRows = false;
            dtg_Subcate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Subcate.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(61, 100, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_Subcate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_Subcate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Subcate.EnableHeadersVisualStyles = false;
            dtg_Subcate.ImeMode = ImeMode.On;
            dtg_Subcate.Location = new Point(10, 121);
            dtg_Subcate.Margin = new Padding(3, 4, 3, 4);
            dtg_Subcate.Name = "dtg_Subcate";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 125, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtg_Subcate.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtg_Subcate.RowHeadersVisible = false;
            dtg_Subcate.RowHeadersWidth = 51;
            dtg_Subcate.Size = new Size(258, 262);
            dtg_Subcate.TabIndex = 46;
            dtg_Subcate.CellContentDoubleClick += dtg_Subcate_CellContentDoubleClick;
            dtg_Subcate.CellDoubleClick += dtg_Subcate_CellDoubleClick;
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
            btn_siguente.Location = new Point(174, 393);
            btn_siguente.Margin = new Padding(3, 4, 3, 4);
            btn_siguente.Name = "btn_siguente";
            btn_siguente.Size = new Size(33, 40);
            btn_siguente.TabIndex = 49;
            btn_siguente.UseVisualStyleBackColor = false;
            btn_siguente.Visible = false;
            btn_siguente.Click += btn_siguente_Click;
            // 
            // lbl_paginas
            // 
            lbl_paginas.Anchor = AnchorStyles.Bottom;
            lbl_paginas.AutoSize = true;
            lbl_paginas.Location = new Point(108, 403);
            lbl_paginas.Name = "lbl_paginas";
            lbl_paginas.Size = new Size(0, 20);
            lbl_paginas.TabIndex = 48;
            lbl_paginas.TextAlign = ContentAlignment.BottomCenter;
            lbl_paginas.Visible = false;
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
            btn_anterior.Location = new Point(63, 391);
            btn_anterior.Margin = new Padding(3, 4, 3, 4);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(33, 40);
            btn_anterior.TabIndex = 47;
            btn_anterior.UseVisualStyleBackColor = false;
            btn_anterior.Visible = false;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 10, 150);
            panel1.Controls.Add(btn_salir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 24);
            panel1.TabIndex = 50;
            // 
            // btn_salir
            // 
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatAppearance.MouseDownBackColor = Color.Red;
            btn_salir.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Location = new Point(262, 2);
            btn_salir.Margin = new Padding(3, 4, 3, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(17, 20);
            btn_salir.TabIndex = 51;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(282, 450);
            Controls.Add(panel1);
            Controls.Add(btn_siguente);
            Controls.Add(lbl_paginas);
            Controls.Add(btn_anterior);
            Controls.Add(dtg_Subcate);
            Controls.Add(label6);
            Controls.Add(panel3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Proveedor";
            Text = "Proveedor";
            Load += Proveedor_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Subcate).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private TextBox txt_buscar_sub;
        private Button btn_buscar;
        private Label label6;
        private DataGridView dtg_Subcate;
        private Button btn_siguente;
        private Label lbl_paginas;
        private Button btn_anterior;
        private Panel panel1;
        private Button btn_salir;
    }
}