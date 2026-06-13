namespace MyM26.screens
{
    partial class ABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM));
            btn_salir = new Button();
            pic_art = new PictureBox();
            label1 = new Label();
            txt_nombre = new TextBox();
            label3 = new Label();
            txt_cb = new TextBox();
            cmb_categoria = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cmb_Subcate = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txt_P_U = new TextBox();
            numeric_C_U = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            numeric_C_M = new NumericUpDown();
            label10 = new Label();
            txt_P_M = new TextBox();
            label11 = new Label();
            txt_P_P = new TextBox();
            label12 = new Label();
            txt_D_P = new TextBox();
            btn_añadir = new Button();
            btn_buscar = new Button();
            panel2 = new Panel();
            label_Title = new Label();
            errorProvider1 = new ErrorProvider(components);
            btn_AggCliente = new Button();
            txt_proveedor = new TextBox();
            label2 = new Label();
            txt_ganancia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pic_art).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_C_U).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_C_M).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btn_salir
            // 
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Zoom;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatAppearance.MouseDownBackColor = Color.FromArgb(215, 10, 60);
            btn_salir.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 10, 60);
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Location = new Point(447, 4);
            btn_salir.Margin = new Padding(3, 4, 3, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(17, 21);
            btn_salir.TabIndex = 2;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // pic_art
            // 
            pic_art.BackgroundImage = Properties.Resources.sjBackg;
            pic_art.BackgroundImageLayout = ImageLayout.Zoom;
            pic_art.Location = new Point(148, 45);
            pic_art.Margin = new Padding(3, 4, 3, 4);
            pic_art.Name = "pic_art";
            pic_art.Size = new Size(105, 110);
            pic_art.TabIndex = 3;
            pic_art.TabStop = false;
            pic_art.DragEnter += txt_nombre_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 174);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 23;
            label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.White;
            txt_nombre.Location = new Point(14, 198);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.MaxLength = 100;
            txt_nombre.Multiline = true;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(205, 35);
            txt_nombre.TabIndex = 22;
            txt_nombre.DragEnter += txt_nombre_DragEnter;
            txt_nombre.KeyDown += txt_nombre_KeyDown;
            txt_nombre.KeyPress += txt_nombre_KeyPress;
            txt_nombre.MouseDown += txt_nombre_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(244, 174);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 25;
            label3.Text = "Codigo de barra";
            // 
            // txt_cb
            // 
            txt_cb.BackColor = Color.White;
            txt_cb.Location = new Point(244, 198);
            txt_cb.Margin = new Padding(3, 4, 3, 4);
            txt_cb.MaxLength = 15;
            txt_cb.Multiline = true;
            txt_cb.Name = "txt_cb";
            txt_cb.Size = new Size(205, 35);
            txt_cb.TabIndex = 24;
            txt_cb.DragEnter += txt_nombre_DragEnter;
            txt_cb.KeyDown += txt_cb_KeyDown;
            txt_cb.KeyPress += txt_cb_KeyPress;
            txt_cb.MouseDown += txt_nombre_MouseDown;
            txt_cb.MouseEnter += txt_cb_MouseEnter;
            // 
            // cmb_categoria
            // 
            cmb_categoria.BackColor = Color.WhiteSmoke;
            cmb_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_categoria.FormattingEnabled = true;
            cmb_categoria.Location = new Point(14, 272);
            cmb_categoria.Margin = new Padding(3, 4, 3, 4);
            cmb_categoria.Name = "cmb_categoria";
            cmb_categoria.Size = new Size(205, 28);
            cmb_categoria.TabIndex = 26;
            cmb_categoria.SelectedIndexChanged += cmb_categoria_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 248);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 27;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(245, 248);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 29;
            label5.Text = "Sub categoria";
            // 
            // cmb_Subcate
            // 
            cmb_Subcate.BackColor = Color.WhiteSmoke;
            cmb_Subcate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Subcate.FormattingEnabled = true;
            cmb_Subcate.Location = new Point(245, 272);
            cmb_Subcate.Margin = new Padding(3, 4, 3, 4);
            cmb_Subcate.Name = "cmb_Subcate";
            cmb_Subcate.Size = new Size(205, 28);
            cmb_Subcate.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(244, 406);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 31;
            label6.Text = "Proveedor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 399);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 33;
            label7.Text = "Precio unitario";
            // 
            // txt_P_U
            // 
            txt_P_U.BackColor = Color.White;
            txt_P_U.Location = new Point(15, 423);
            txt_P_U.Margin = new Padding(3, 4, 3, 4);
            txt_P_U.MaxLength = 12;
            txt_P_U.Multiline = true;
            txt_P_U.Name = "txt_P_U";
            txt_P_U.ReadOnly = true;
            txt_P_U.Size = new Size(205, 35);
            txt_P_U.TabIndex = 32;
            txt_P_U.DragEnter += txt_nombre_DragEnter;
            txt_P_U.KeyDown += txt_cb_KeyDown;
            txt_P_U.KeyPress += txt_cb_KeyPress;
            txt_P_U.MouseDown += txt_nombre_MouseDown;
            // 
            // numeric_C_U
            // 
            numeric_C_U.BackColor = Color.White;
            numeric_C_U.Location = new Point(14, 534);
            numeric_C_U.Margin = new Padding(3, 4, 3, 4);
            numeric_C_U.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numeric_C_U.Name = "numeric_C_U";
            numeric_C_U.Size = new Size(205, 27);
            numeric_C_U.TabIndex = 34;
            numeric_C_U.DragEnter += txt_nombre_DragEnter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 510);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 35;
            label8.Text = "Cantidad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 604);
            label9.Name = "label9";
            label9.Size = new Size(196, 20);
            label9.TabIndex = 37;
            label9.Text = "Cantidad minima mayorista";
            // 
            // numeric_C_M
            // 
            numeric_C_M.BackColor = Color.White;
            numeric_C_M.Location = new Point(14, 628);
            numeric_C_M.Margin = new Padding(3, 4, 3, 4);
            numeric_C_M.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numeric_C_M.Name = "numeric_C_M";
            numeric_C_M.Size = new Size(205, 27);
            numeric_C_M.TabIndex = 36;
            numeric_C_M.DragEnter += txt_nombre_DragEnter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(244, 596);
            label10.Name = "label10";
            label10.Size = new Size(123, 20);
            label10.TabIndex = 39;
            label10.Text = "Precio mayorista";
            // 
            // txt_P_M
            // 
            txt_P_M.BackColor = Color.White;
            txt_P_M.Location = new Point(244, 620);
            txt_P_M.Margin = new Padding(3, 4, 3, 4);
            txt_P_M.MaxLength = 12;
            txt_P_M.Multiline = true;
            txt_P_M.Name = "txt_P_M";
            txt_P_M.Size = new Size(205, 35);
            txt_P_M.TabIndex = 38;
            txt_P_M.DragEnter += txt_nombre_DragEnter;
            txt_P_M.KeyDown += txt_cb_KeyDown;
            txt_P_M.KeyPress += txt_cb_KeyPress;
            txt_P_M.MouseDown += txt_nombre_MouseDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(15, 322);
            label11.Name = "label11";
            label11.Size = new Size(186, 20);
            label11.TabIndex = 41;
            label11.Text = "Precio unitario proveedor";
            // 
            // txt_P_P
            // 
            txt_P_P.BackColor = Color.White;
            txt_P_P.Location = new Point(15, 346);
            txt_P_P.Margin = new Padding(3, 4, 3, 4);
            txt_P_P.MaxLength = 12;
            txt_P_P.Multiline = true;
            txt_P_P.Name = "txt_P_P";
            txt_P_P.Size = new Size(205, 35);
            txt_P_P.TabIndex = 40;
            txt_P_P.TextChanged += txt_P_P_TextChanged;
            txt_P_P.DragEnter += txt_nombre_DragEnter;
            txt_P_P.KeyDown += txt_cb_KeyDown;
            txt_P_P.KeyPress += txt_P_P_KeyPress;
            txt_P_P.MouseDown += txt_nombre_MouseDown;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(245, 510);
            label12.Name = "label12";
            label12.Size = new Size(157, 20);
            label12.TabIndex = 43;
            label12.Text = "Descuento proveedor";
            // 
            // txt_D_P
            // 
            txt_D_P.BackColor = Color.White;
            txt_D_P.Location = new Point(245, 534);
            txt_D_P.Margin = new Padding(3, 4, 3, 4);
            txt_D_P.MaxLength = 12;
            txt_D_P.Multiline = true;
            txt_D_P.Name = "txt_D_P";
            txt_D_P.Size = new Size(205, 35);
            txt_D_P.TabIndex = 42;
            txt_D_P.DragEnter += txt_nombre_DragEnter;
            txt_D_P.KeyDown += txt_cb_KeyDown;
            txt_D_P.KeyPress += txt_cb_KeyPress;
            txt_D_P.MouseDown += txt_nombre_MouseDown;
            // 
            // btn_añadir
            // 
            btn_añadir.BackColor = Color.FromArgb(20, 134, 233);
            btn_añadir.FlatStyle = FlatStyle.Flat;
            btn_añadir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_añadir.ForeColor = Color.White;
            btn_añadir.Location = new Point(146, 708);
            btn_añadir.Margin = new Padding(3, 4, 3, 4);
            btn_añadir.Name = "btn_añadir";
            btn_añadir.Size = new Size(150, 49);
            btn_añadir.TabIndex = 44;
            btn_añadir.UseVisualStyleBackColor = false;
            btn_añadir.Click += btn_añadir_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Location = new Point(259, 120);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(35, 35);
            btn_buscar.TabIndex = 45;
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click_1;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label_Title);
            panel2.Controls.Add(btn_salir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 31);
            panel2.TabIndex = 46;
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Title.Location = new Point(3, 4);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(0, 20);
            label_Title.TabIndex = 16;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_AggCliente
            // 
            btn_AggCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_AggCliente.BackColor = Color.FromArgb(50, 10, 200);
            btn_AggCliente.FlatAppearance.BorderSize = 0;
            btn_AggCliente.FlatStyle = FlatStyle.Flat;
            btn_AggCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_AggCliente.ForeColor = Color.White;
            btn_AggCliente.Location = new Point(244, 429);
            btn_AggCliente.Name = "btn_AggCliente";
            btn_AggCliente.Size = new Size(205, 35);
            btn_AggCliente.TabIndex = 47;
            btn_AggCliente.Text = "Buscar proveedor";
            btn_AggCliente.UseVisualStyleBackColor = false;
            btn_AggCliente.Click += btn_AggCliente_Click;
            // 
            // txt_proveedor
            // 
            txt_proveedor.BackColor = Color.White;
            txt_proveedor.Location = new Point(244, 428);
            txt_proveedor.Margin = new Padding(3, 4, 3, 4);
            txt_proveedor.MaxLength = 12;
            txt_proveedor.Multiline = true;
            txt_proveedor.Name = "txt_proveedor";
            txt_proveedor.ReadOnly = true;
            txt_proveedor.Size = new Size(205, 35);
            txt_proveedor.TabIndex = 48;
            txt_proveedor.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 322);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 50;
            label2.Text = "Ganancia % deseada";
            // 
            // txt_ganancia
            // 
            txt_ganancia.BackColor = Color.White;
            txt_ganancia.Location = new Point(245, 346);
            txt_ganancia.Margin = new Padding(3, 4, 3, 4);
            txt_ganancia.MaxLength = 3;
            txt_ganancia.Multiline = true;
            txt_ganancia.Name = "txt_ganancia";
            txt_ganancia.Size = new Size(205, 35);
            txt_ganancia.TabIndex = 49;
            txt_ganancia.TextChanged += txt_ganancia_TextChanged;
            txt_ganancia.KeyDown += txt_nombre_KeyDown;
            txt_ganancia.KeyPress += textBox1_KeyPress;
            txt_ganancia.MouseDown += txt_nombre_MouseDown;
            // 
            // ABM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(470, 770);
            Controls.Add(label2);
            Controls.Add(txt_ganancia);
            Controls.Add(btn_AggCliente);
            Controls.Add(txt_proveedor);
            Controls.Add(panel2);
            Controls.Add(btn_buscar);
            Controls.Add(btn_añadir);
            Controls.Add(label12);
            Controls.Add(txt_D_P);
            Controls.Add(label11);
            Controls.Add(txt_P_P);
            Controls.Add(label10);
            Controls.Add(txt_P_M);
            Controls.Add(label9);
            Controls.Add(numeric_C_M);
            Controls.Add(label8);
            Controls.Add(numeric_C_U);
            Controls.Add(label7);
            Controls.Add(txt_P_U);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmb_Subcate);
            Controls.Add(label4);
            Controls.Add(cmb_categoria);
            Controls.Add(label3);
            Controls.Add(txt_cb);
            Controls.Add(label1);
            Controls.Add(txt_nombre);
            Controls.Add(pic_art);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ABM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AVM";
            Load += AVM_Load;
            ((System.ComponentModel.ISupportInitialize)pic_art).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_C_U).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_C_M).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_salir;
        private PictureBox pic_art;
        private Label label1;
        private TextBox txt_nombre;
        private Label label3;
        private TextBox txt_cb;
        private ComboBox cmb_categoria;
        private Label label4;
        private Label label5;
        private ComboBox cmb_Subcate;
        private Label label6;
        private Label label7;
        private TextBox txt_P_U;
        private NumericUpDown numeric_C_U;
        private Label label8;
        private Label label9;
        private NumericUpDown numeric_C_M;
        private Label label10;
        private TextBox txt_P_M;
        private Label label11;
        private TextBox txt_P_P;
        private Label label12;
        private TextBox txt_D_P;
        private Button btn_añadir;
        private Button btn_buscar;
        private Panel panel2;
        private Label label_Title;
        private ErrorProvider errorProvider1;
        private Button btn_AggCliente;
        private TextBox txt_proveedor;
        private Label label2;
        private TextBox txt_ganancia;
    }
}