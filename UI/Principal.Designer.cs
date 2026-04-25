namespace MyM26
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btn_mini = new Button();
            btn_salir = new Button();
            btn_maxi = new Button();
            btn_cajas = new Button();
            btn_principal = new Button();
            btn_art = new Button();
            btn_compras = new Button();
            btn_ventas = new Button();
            panel_perfil = new Panel();
            lbl_tipo = new Label();
            lbl_name = new Label();
            pcb_perfil = new PictureBox();
            button6 = new Button();
            btn_usurios = new Button();
            panel1 = new Panel();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            btn_contables = new Button();
            panelprincipal = new Panel();
            panel_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_perfil).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_mini
            // 
            btn_mini.BackColor = Color.Transparent;
            btn_mini.BackgroundImage = (Image)resources.GetObject("btn_mini.BackgroundImage");
            btn_mini.BackgroundImageLayout = ImageLayout.Stretch;
            btn_mini.Dock = DockStyle.Fill;
            btn_mini.FlatAppearance.BorderSize = 0;
            btn_mini.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 30, 130);
            btn_mini.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 30, 130);
            btn_mini.FlatStyle = FlatStyle.Flat;
            btn_mini.ImageAlign = ContentAlignment.BottomCenter;
            btn_mini.Location = new Point(1458, 4);
            btn_mini.Margin = new Padding(3, 4, 3, 4);
            btn_mini.Name = "btn_mini";
            btn_mini.Size = new Size(14, 29);
            btn_mini.TabIndex = 3;
            btn_mini.UseVisualStyleBackColor = false;
            btn_mini.Click += btn_mini_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Transparent;
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Dock = DockStyle.Fill;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btn_salir.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Image = (Image)resources.GetObject("btn_salir.Image");
            btn_salir.Location = new Point(1512, 4);
            btn_salir.Margin = new Padding(3, 4, 3, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(18, 29);
            btn_salir.TabIndex = 1;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_maxi
            // 
            btn_maxi.BackColor = Color.Transparent;
            btn_maxi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_maxi.Dock = DockStyle.Fill;
            btn_maxi.FlatAppearance.BorderSize = 0;
            btn_maxi.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 30, 130);
            btn_maxi.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 30, 130);
            btn_maxi.FlatStyle = FlatStyle.Flat;
            btn_maxi.Image = Properties.Resources.tNormal;
            btn_maxi.Location = new Point(1478, 4);
            btn_maxi.Margin = new Padding(3, 4, 3, 4);
            btn_maxi.Name = "btn_maxi";
            btn_maxi.Size = new Size(28, 29);
            btn_maxi.TabIndex = 2;
            btn_maxi.UseVisualStyleBackColor = false;
            btn_maxi.Click += btn_maxi_Click;
            // 
            // btn_cajas
            // 
            btn_cajas.BackColor = Color.Transparent;
            btn_cajas.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 75, 145);
            btn_cajas.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 75, 145);
            btn_cajas.FlatStyle = FlatStyle.Flat;
            btn_cajas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_cajas.ForeColor = Color.White;
            btn_cajas.Image = (Image)resources.GetObject("btn_cajas.Image");
            btn_cajas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cajas.Location = new Point(3, 246);
            btn_cajas.Margin = new Padding(3, 4, 3, 4);
            btn_cajas.Name = "btn_cajas";
            btn_cajas.Size = new Size(213, 59);
            btn_cajas.TabIndex = 13;
            btn_cajas.Text = "Cajas";
            btn_cajas.UseVisualStyleBackColor = false;
            btn_cajas.Click += btn_cajas_Click;
            // 
            // btn_principal
            // 
            btn_principal.BackColor = Color.Transparent;
            btn_principal.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 75, 145);
            btn_principal.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 75, 145);
            btn_principal.FlatStyle = FlatStyle.Flat;
            btn_principal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_principal.ForeColor = Color.White;
            btn_principal.Image = (Image)resources.GetObject("btn_principal.Image");
            btn_principal.ImageAlign = ContentAlignment.MiddleLeft;
            btn_principal.Location = new Point(3, 179);
            btn_principal.Margin = new Padding(3, 4, 3, 4);
            btn_principal.Name = "btn_principal";
            btn_principal.Size = new Size(213, 59);
            btn_principal.TabIndex = 14;
            btn_principal.Text = "Inicio";
            btn_principal.UseVisualStyleBackColor = false;
            btn_principal.Click += btn_principal_Click;
            // 
            // btn_art
            // 
            btn_art.BackColor = Color.Transparent;
            btn_art.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 75, 145);
            btn_art.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 75, 145);
            btn_art.FlatStyle = FlatStyle.Flat;
            btn_art.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_art.ForeColor = Color.White;
            btn_art.Image = (Image)resources.GetObject("btn_art.Image");
            btn_art.ImageAlign = ContentAlignment.MiddleLeft;
            btn_art.Location = new Point(3, 313);
            btn_art.Margin = new Padding(3, 4, 3, 4);
            btn_art.Name = "btn_art";
            btn_art.Size = new Size(213, 59);
            btn_art.TabIndex = 15;
            btn_art.Text = "Articulos";
            btn_art.UseVisualStyleBackColor = false;
            btn_art.Click += btn_art_Click;
            // 
            // btn_compras
            // 
            btn_compras.BackColor = Color.Transparent;
            btn_compras.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 75, 145);
            btn_compras.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 75, 145);
            btn_compras.FlatStyle = FlatStyle.Flat;
            btn_compras.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_compras.ForeColor = Color.White;
            btn_compras.Image = (Image)resources.GetObject("btn_compras.Image");
            btn_compras.ImageAlign = ContentAlignment.MiddleLeft;
            btn_compras.Location = new Point(3, 447);
            btn_compras.Margin = new Padding(3, 4, 3, 4);
            btn_compras.Name = "btn_compras";
            btn_compras.Size = new Size(213, 59);
            btn_compras.TabIndex = 17;
            btn_compras.Text = "Compras";
            btn_compras.UseVisualStyleBackColor = false;
            btn_compras.Click += btn_compras_Click;
            // 
            // btn_ventas
            // 
            btn_ventas.BackColor = Color.Transparent;
            btn_ventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 75, 145);
            btn_ventas.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 75, 145);
            btn_ventas.FlatStyle = FlatStyle.Flat;
            btn_ventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_ventas.ForeColor = Color.White;
            btn_ventas.Image = (Image)resources.GetObject("btn_ventas.Image");
            btn_ventas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ventas.Location = new Point(3, 380);
            btn_ventas.Margin = new Padding(3, 4, 3, 4);
            btn_ventas.Name = "btn_ventas";
            btn_ventas.Size = new Size(213, 59);
            btn_ventas.TabIndex = 2;
            btn_ventas.Text = "Ventas";
            btn_ventas.UseVisualStyleBackColor = false;
            btn_ventas.Click += btn_ventas_Click;
            // 
            // panel_perfil
            // 
            panel_perfil.BackColor = Color.Transparent;
            panel_perfil.BorderStyle = BorderStyle.FixedSingle;
            panel_perfil.Controls.Add(lbl_tipo);
            panel_perfil.Controls.Add(lbl_name);
            panel_perfil.Controls.Add(pcb_perfil);
            panel_perfil.Location = new Point(3, 4);
            panel_perfil.Margin = new Padding(3, 4, 3, 4);
            panel_perfil.Name = "panel_perfil";
            panel_perfil.Size = new Size(212, 79);
            panel_perfil.TabIndex = 2;
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tipo.ForeColor = Color.White;
            lbl_tipo.Location = new Point(74, 48);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(48, 20);
            lbl_tipo.TabIndex = 2;
            lbl_tipo.Text = "label1";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.ForeColor = Color.White;
            lbl_name.Location = new Point(74, 13);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(48, 20);
            lbl_name.TabIndex = 1;
            lbl_name.Text = "label1";
            // 
            // pcb_perfil
            // 
            pcb_perfil.BackgroundImageLayout = ImageLayout.Stretch;
            pcb_perfil.Location = new Point(10, 9);
            pcb_perfil.Margin = new Padding(3, 4, 3, 4);
            pcb_perfil.Name = "pcb_perfil";
            pcb_perfil.Size = new Size(57, 59);
            pcb_perfil.TabIndex = 0;
            pcb_perfil.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 75, 145);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 75, 145);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 514);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(213, 59);
            button6.TabIndex = 19;
            button6.Text = "Clientes";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // btn_usurios
            // 
            btn_usurios.BackColor = Color.Transparent;
            btn_usurios.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 75, 145);
            btn_usurios.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 75, 145);
            btn_usurios.FlatStyle = FlatStyle.Flat;
            btn_usurios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_usurios.ForeColor = Color.White;
            btn_usurios.Image = (Image)resources.GetObject("btn_usurios.Image");
            btn_usurios.ImageAlign = ContentAlignment.MiddleLeft;
            btn_usurios.Location = new Point(3, 648);
            btn_usurios.Margin = new Padding(3, 4, 3, 4);
            btn_usurios.Name = "btn_usurios";
            btn_usurios.Size = new Size(213, 59);
            btn_usurios.TabIndex = 20;
            btn_usurios.Text = "Usuarios";
            btn_usurios.UseVisualStyleBackColor = false;
            btn_usurios.Click += btn_usurios_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(3, 91);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 80);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 75, 145);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 75, 145);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 581);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(213, 59);
            button1.TabIndex = 11;
            button1.Text = "Proveedores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(10, 30, 70);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.35052F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.64948452F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.Controls.Add(btn_salir, 4, 0);
            tableLayoutPanel1.Controls.Add(btn_maxi, 3, 0);
            tableLayoutPanel1.Controls.Add(btn_mini, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1533, 37);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(10, 40, 100);
            flowLayoutPanel1.Controls.Add(panel_perfil);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btn_principal);
            flowLayoutPanel1.Controls.Add(btn_cajas);
            flowLayoutPanel1.Controls.Add(btn_art);
            flowLayoutPanel1.Controls.Add(btn_ventas);
            flowLayoutPanel1.Controls.Add(btn_compras);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(btn_usurios);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(btn_contables);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 37);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(219, 924);
            flowLayoutPanel1.TabIndex = 25;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 75, 145);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 75, 145);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 715);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(213, 59);
            button2.TabIndex = 21;
            button2.Text = "Empleados";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_contables
            // 
            btn_contables.BackColor = Color.Transparent;
            btn_contables.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 75, 145);
            btn_contables.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 75, 145);
            btn_contables.FlatStyle = FlatStyle.Flat;
            btn_contables.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_contables.ForeColor = Color.White;
            btn_contables.Image = (Image)resources.GetObject("btn_contables.Image");
            btn_contables.ImageAlign = ContentAlignment.MiddleLeft;
            btn_contables.Location = new Point(3, 782);
            btn_contables.Margin = new Padding(3, 4, 3, 4);
            btn_contables.Name = "btn_contables";
            btn_contables.Size = new Size(213, 59);
            btn_contables.TabIndex = 12;
            btn_contables.Text = "Contable";
            btn_contables.UseVisualStyleBackColor = false;
            btn_contables.Click += btn_contables_Click;
            // 
            // panelprincipal
            // 
            panelprincipal.BorderStyle = BorderStyle.FixedSingle;
            panelprincipal.Dock = DockStyle.Fill;
            panelprincipal.Location = new Point(219, 37);
            panelprincipal.Margin = new Padding(3, 4, 3, 4);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(1314, 924);
            panelprincipal.TabIndex = 26;
            panelprincipal.Paint += panelprincipal_Paint;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1533, 961);
            Controls.Add(panelprincipal);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Principal_Load;
            panel_perfil.ResumeLayout(false);
            panel_perfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_perfil).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_mini;
        private Button btn_salir;
        private Button btn_maxi;
        private Button btn_cajas;
        private Button btn_principal;
        private Button btn_art;
        private Button btn_compras;
        private Button btn_ventas;
        private Button button6;
        private Panel panel_perfil;
        private Button btn_usurios;
        private Panel panel1;
        private Button button1;       
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelprincipal;
        private Button btn_contables;
        private Button button2;
        private Label lbl_tipo;
        private Label lbl_name;
        private PictureBox pcb_perfil;
    }
}
