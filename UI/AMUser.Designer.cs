namespace MyM26.screens
{
    partial class AMUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMUser));
            panel1 = new Panel();
            label_title = new Label();
            btn_salir = new Button();
            txt_dni = new TextBox();
            label1 = new Label();
            txt_nombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_repit = new TextBox();
            label4 = new Label();
            txt_contraseña = new TextBox();
            label5 = new Label();
            txt_telefono = new TextBox();
            label6 = new Label();
            txt_fechaAlta = new TextBox();
            label7 = new Label();
            txt_mail = new TextBox();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            btn_cambiar = new Button();
            cmb_tipo = new ComboBox();
            label10 = new Label();
            btn_buscar = new Button();
            pic_usu = new PictureBox();
            panel3 = new Panel();
            empleados = new CheckBox();
            Usuarios = new CheckBox();
            Contable = new CheckBox();
            Proveedores = new CheckBox();
            Clientes = new CheckBox();
            Ventas = new CheckBox();
            compras = new CheckBox();
            articulos = new CheckBox();
            cajas = new CheckBox();
            btn_AM = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_usu).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label_title);
            panel1.Controls.Add(btn_salir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 31);
            panel1.TabIndex = 0;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(3, 4);
            label_title.Name = "label_title";
            label_title.Size = new Size(0, 20);
            label_title.TabIndex = 16;
            // 
            // btn_salir
            // 
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Location = new Point(394, 4);
            btn_salir.Margin = new Padding(3, 4, 3, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(17, 20);
            btn_salir.TabIndex = 1;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(14, 249);
            txt_dni.Margin = new Padding(3, 4, 3, 4);
            txt_dni.MaxLength = 8;
            txt_dni.Multiline = true;
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(174, 35);
            txt_dni.TabIndex = 1;
            txt_dni.DragEnter += txt_dni_DragEnter;
            txt_dni.KeyDown += txt_dni_KeyDown;
            txt_dni.KeyPress += txt_dni_KeyPress;
            txt_dni.MouseDown += txt_dni_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 225);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "DNI";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(222, 249);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.MaxLength = 16;
            txt_nombre.Multiline = true;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(174, 35);
            txt_nombre.TabIndex = 3;
            txt_nombre.DragEnter += txt_dni_DragEnter;
            txt_nombre.KeyDown += txt_nombre_KeyDown;
            txt_nombre.KeyPress += txt_nombre_KeyPress;
            txt_nombre.MouseDown += txt_dni_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(222, 225);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre de usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(222, 295);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 8;
            label3.Text = "Repetir contraseña";
            // 
            // txt_repit
            // 
            txt_repit.Location = new Point(212, 277);
            txt_repit.Margin = new Padding(3, 4, 3, 4);
            txt_repit.MaxLength = 16;
            txt_repit.Multiline = true;
            txt_repit.Name = "txt_repit";
            txt_repit.Size = new Size(174, 35);
            txt_repit.TabIndex = 7;
            txt_repit.DragEnter += txt_dni_DragEnter;
            txt_repit.KeyDown += txt_nombre_KeyDown;
            txt_repit.KeyPress += txt_nombre_KeyPress;
            txt_repit.MouseDown += txt_dni_MouseDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 295);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // txt_contraseña
            // 
            txt_contraseña.Location = new Point(14, 319);
            txt_contraseña.Margin = new Padding(3, 4, 3, 4);
            txt_contraseña.MaxLength = 16;
            txt_contraseña.Multiline = true;
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(174, 35);
            txt_contraseña.TabIndex = 5;
            txt_contraseña.DragEnter += txt_dni_DragEnter;
            txt_contraseña.KeyDown += txt_nombre_KeyDown;
            txt_contraseña.KeyPress += txt_nombre_KeyPress;
            txt_contraseña.MouseDown += txt_dni_MouseDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(222, 371);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 12;
            label5.Text = "Telefono";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(222, 395);
            txt_telefono.Margin = new Padding(3, 4, 3, 4);
            txt_telefono.MaxLength = 15;
            txt_telefono.Multiline = true;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(174, 35);
            txt_telefono.TabIndex = 11;
            txt_telefono.DragEnter += txt_dni_DragEnter;
            txt_telefono.KeyDown += txt_dni_KeyDown;
            txt_telefono.KeyPress += txt_dni_KeyPress;
            txt_telefono.MouseDown += txt_dni_MouseDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 371);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 10;
            label6.Text = "Fecha de alta";
            // 
            // txt_fechaAlta
            // 
            txt_fechaAlta.BackColor = Color.White;
            txt_fechaAlta.Location = new Point(14, 395);
            txt_fechaAlta.Margin = new Padding(3, 4, 3, 4);
            txt_fechaAlta.Multiline = true;
            txt_fechaAlta.Name = "txt_fechaAlta";
            txt_fechaAlta.ReadOnly = true;
            txt_fechaAlta.Size = new Size(174, 35);
            txt_fechaAlta.TabIndex = 9;
            txt_fechaAlta.DragEnter += txt_dni_DragEnter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 445);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 14;
            label7.Text = "Mail";
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(14, 469);
            txt_mail.Margin = new Padding(3, 4, 3, 4);
            txt_mail.MaxLength = 200;
            txt_mail.Multiline = true;
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(212, 35);
            txt_mail.TabIndex = 13;
            txt_mail.DragEnter += txt_dni_DragEnter;
            txt_mail.KeyDown += txt_mail_KeyDown;
            txt_mail.KeyPress += txt_mail_KeyPress;
            txt_mail.MouseDown += txt_dni_MouseDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(90, 15);
            label8.Name = "label8";
            label8.Size = new Size(218, 20);
            label8.TabIndex = 15;
            label8.Text = "Información basica del usuario";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(115, 16);
            label9.Name = "label9";
            label9.Size = new Size(149, 20);
            label9.TabIndex = 16;
            label9.Text = "Permisos del usuario";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_cambiar);
            panel2.Controls.Add(cmb_tipo);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btn_buscar);
            panel2.Controls.Add(pic_usu);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_repit);
            panel2.Location = new Point(9, 41);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 486);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint;
            // 
            // btn_cambiar
            // 
            btn_cambiar.BackColor = Color.FromArgb(100, 82, 255);
            btn_cambiar.FlatStyle = FlatStyle.Flat;
            btn_cambiar.ForeColor = Color.White;
            btn_cambiar.Location = new Point(211, 276);
            btn_cambiar.Name = "btn_cambiar";
            btn_cambiar.Size = new Size(173, 35);
            btn_cambiar.TabIndex = 22;
            btn_cambiar.Text = "Actualizar contraseña";
            btn_cambiar.UseVisualStyleBackColor = false;
            btn_cambiar.Visible = false;
            btn_cambiar.Click += btn_cambiar_Click;
            // 
            // cmb_tipo
            // 
            cmb_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_tipo.FormattingEnabled = true;
            cmb_tipo.Location = new Point(223, 427);
            cmb_tipo.Margin = new Padding(3, 4, 3, 4);
            cmb_tipo.Name = "cmb_tipo";
            cmb_tipo.Size = new Size(163, 28);
            cmb_tipo.TabIndex = 21;
            cmb_tipo.SelectedIndexChanged += cmb_tipo_SelectedIndexChanged;
            cmb_tipo.DragEnter += txt_dni_DragEnter;
            cmb_tipo.MouseDown += txt_dni_MouseDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(225, 403);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 20;
            label10.Text = "Tipo";
            // 
            // btn_buscar
            // 
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Location = new Point(237, 115);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(35, 35);
            btn_buscar.TabIndex = 17;
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // pic_usu
            // 
            pic_usu.BackColor = Color.Transparent;
            pic_usu.BackgroundImageLayout = ImageLayout.Zoom;
            pic_usu.Location = new Point(133, 51);
            pic_usu.Margin = new Padding(3, 4, 3, 4);
            pic_usu.Name = "pic_usu";
            pic_usu.Size = new Size(96, 99);
            pic_usu.TabIndex = 16;
            pic_usu.TabStop = false;
            pic_usu.DragEnter += txt_dni_DragEnter;
            pic_usu.MouseDown += txt_dni_MouseDown;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(empleados);
            panel3.Controls.Add(Usuarios);
            panel3.Controls.Add(Contable);
            panel3.Controls.Add(Proveedores);
            panel3.Controls.Add(Clientes);
            panel3.Controls.Add(Ventas);
            panel3.Controls.Add(compras);
            panel3.Controls.Add(articulos);
            panel3.Controls.Add(cajas);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(9, 536);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 161);
            panel3.TabIndex = 18;
            panel3.Paint += panel3_Paint;
            // 
            // empleados
            // 
            empleados.AutoSize = true;
            empleados.FlatStyle = FlatStyle.Flat;
            empleados.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            empleados.Location = new Point(7, 124);
            empleados.Margin = new Padding(3, 4, 3, 4);
            empleados.Name = "empleados";
            empleados.Size = new Size(101, 24);
            empleados.TabIndex = 25;
            empleados.Text = "Empleados";
            empleados.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            Usuarios.AutoSize = true;
            Usuarios.FlatStyle = FlatStyle.Flat;
            Usuarios.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Usuarios.Location = new Point(312, 91);
            Usuarios.Margin = new Padding(3, 4, 3, 4);
            Usuarios.Name = "Usuarios";
            Usuarios.Size = new Size(86, 24);
            Usuarios.TabIndex = 24;
            Usuarios.Text = "Usuarios";
            Usuarios.UseVisualStyleBackColor = true;
            // 
            // Contable
            // 
            Contable.AutoSize = true;
            Contable.FlatStyle = FlatStyle.Flat;
            Contable.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Contable.Location = new Point(211, 91);
            Contable.Margin = new Padding(3, 4, 3, 4);
            Contable.Name = "Contable";
            Contable.Size = new Size(88, 24);
            Contable.TabIndex = 23;
            Contable.Text = "Contable";
            Contable.UseVisualStyleBackColor = true;
            // 
            // Proveedores
            // 
            Proveedores.AutoSize = true;
            Proveedores.FlatStyle = FlatStyle.Flat;
            Proveedores.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Proveedores.Location = new Point(97, 91);
            Proveedores.Margin = new Padding(3, 4, 3, 4);
            Proveedores.Name = "Proveedores";
            Proveedores.Size = new Size(113, 24);
            Proveedores.TabIndex = 22;
            Proveedores.Text = "Proveedores";
            Proveedores.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.FlatStyle = FlatStyle.Flat;
            Clientes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Clientes.Location = new Point(7, 91);
            Clientes.Margin = new Padding(3, 4, 3, 4);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(80, 24);
            Clientes.TabIndex = 21;
            Clientes.Text = "Clientes";
            Clientes.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            Ventas.AutoSize = true;
            Ventas.FlatStyle = FlatStyle.Flat;
            Ventas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Ventas.Location = new Point(312, 49);
            Ventas.Margin = new Padding(3, 4, 3, 4);
            Ventas.Name = "Ventas";
            Ventas.Size = new Size(72, 24);
            Ventas.TabIndex = 20;
            Ventas.Text = "Ventas";
            Ventas.UseVisualStyleBackColor = true;
            // 
            // compras
            // 
            compras.AutoSize = true;
            compras.FlatStyle = FlatStyle.Flat;
            compras.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            compras.Location = new Point(211, 49);
            compras.Margin = new Padding(3, 4, 3, 4);
            compras.Name = "compras";
            compras.Size = new Size(87, 24);
            compras.TabIndex = 19;
            compras.Text = "Compras";
            compras.UseVisualStyleBackColor = true;
            // 
            // articulos
            // 
            articulos.AutoSize = true;
            articulos.FlatStyle = FlatStyle.Flat;
            articulos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            articulos.Location = new Point(97, 49);
            articulos.Margin = new Padding(3, 4, 3, 4);
            articulos.Name = "articulos";
            articulos.Size = new Size(87, 24);
            articulos.TabIndex = 18;
            articulos.Text = "Articulos";
            articulos.UseVisualStyleBackColor = true;
            // 
            // cajas
            // 
            cajas.AutoSize = true;
            cajas.FlatStyle = FlatStyle.Flat;
            cajas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cajas.Location = new Point(7, 49);
            cajas.Margin = new Padding(3, 4, 3, 4);
            cajas.Name = "cajas";
            cajas.Size = new Size(62, 24);
            cajas.TabIndex = 17;
            cajas.Text = "Cajas";
            cajas.UseVisualStyleBackColor = true;
            // 
            // btn_AM
            // 
            btn_AM.BackColor = Color.Transparent;
            btn_AM.BackgroundImageLayout = ImageLayout.Stretch;
            btn_AM.FlatAppearance.BorderSize = 0;
            btn_AM.FlatStyle = FlatStyle.Flat;
            btn_AM.ForeColor = Color.White;
            btn_AM.Location = new Point(121, 705);
            btn_AM.Margin = new Padding(3, 4, 3, 4);
            btn_AM.Name = "btn_AM";
            btn_AM.Size = new Size(170, 45);
            btn_AM.TabIndex = 19;
            btn_AM.UseVisualStyleBackColor = false;
            btn_AM.Click += btn_AM_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AMUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(416, 765);
            Controls.Add(btn_AM);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(txt_mail);
            Controls.Add(label5);
            Controls.Add(txt_telefono);
            Controls.Add(label6);
            Controls.Add(txt_fechaAlta);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txt_contraseña);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Controls.Add(txt_dni);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AMUser";
            Text = "AMUser";
            Load += AMUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_usu).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_salir;
        private TextBox txt_dni;
        private Label label1;
        private TextBox txt_nombre;
        private Label label2;
        private Label label3;
        private TextBox txt_repit;
        private Label label4;
        private TextBox txt_contraseña;
        private Label label5;
        private TextBox txt_telefono;
        private Label label6;
        private TextBox txt_fechaAlta;
        private Label label7;
        private TextBox txt_mail;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private Panel panel3;
        private CheckBox cajas;
        private CheckBox Usuarios;
        private CheckBox Contable;
        private CheckBox Proveedores;
        private CheckBox Clientes;
        private CheckBox Ventas;
        private CheckBox compras;
        private CheckBox articulos;
        private Button btn_AM;
        private Label label_title;
        public PictureBox pic_usu;
        private Button btn_buscar;
        private ComboBox cmb_tipo;
        private Label label10;
        private ErrorProvider errorProvider1;
        private CheckBox empleados;
        private Button btn_cambiar;
    }
}