namespace MyM26.UI
{
    partial class registroDeUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registroDeUser));
            btn_salir = new Button();
            btn_mini = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            txt_mail = new TextBox();
            label5 = new Label();
            txt_telefono = new TextBox();
            label6 = new Label();
            txt_fechaAlta = new TextBox();
            label3 = new Label();
            txt_repit = new TextBox();
            label4 = new Label();
            txt_contraseña = new TextBox();
            label2 = new Label();
            txt_nombre = new TextBox();
            label8 = new Label();
            txt_dni = new TextBox();
            btn_buscar = new Button();
            pic_usu = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_usu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Transparent;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Zoom;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatAppearance.MouseDownBackColor = Color.FromArgb(215, 10, 60);
            btn_salir.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 10, 60);
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Location = new Point(1272, 1);
            btn_salir.Margin = new Padding(3, 4, 3, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.RightToLeft = RightToLeft.No;
            btn_salir.Size = new Size(23, 43);
            btn_salir.TabIndex = 4;
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // btn_mini
            // 
            btn_mini.BackColor = Color.Transparent;
            btn_mini.BackgroundImage = (Image)resources.GetObject("btn_mini.BackgroundImage");
            btn_mini.BackgroundImageLayout = ImageLayout.Zoom;
            btn_mini.FlatAppearance.BorderSize = 0;
            btn_mini.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 82, 160);
            btn_mini.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 82, 160);
            btn_mini.FlatStyle = FlatStyle.Flat;
            btn_mini.Location = new Point(1243, 1);
            btn_mini.Margin = new Padding(3, 4, 3, 4);
            btn_mini.Name = "btn_mini";
            btn_mini.Size = new Size(23, 43);
            btn_mini.TabIndex = 3;
            btn_mini.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(96, 624);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(456, 61);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(127, 221);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 416);
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_mail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_telefono);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_fechaAlta);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_repit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_contraseña);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_nombre);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_dni);
            panel1.Controls.Add(btn_buscar);
            panel1.Controls.Add(pic_usu);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(664, 122);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 679);
            panel1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(66, 424);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 33;
            label7.Text = "Mail";
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(66, 448);
            txt_mail.Margin = new Padding(3, 4, 3, 4);
            txt_mail.MaxLength = 200;
            txt_mail.Multiline = true;
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(212, 35);
            txt_mail.TabIndex = 32;
            txt_mail.DragEnter += txt_dni_DragEnter;
            txt_mail.KeyDown += txt_mail_KeyDown;
            txt_mail.KeyPress += txt_mail_KeyPress;
            txt_mail.MouseDown += txt_dni_MouseDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(274, 350);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 31;
            label5.Text = "Telefono";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(274, 374);
            txt_telefono.Margin = new Padding(3, 4, 3, 4);
            txt_telefono.MaxLength = 15;
            txt_telefono.Multiline = true;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(174, 35);
            txt_telefono.TabIndex = 30;
            txt_telefono.DragEnter += txt_dni_DragEnter;
            txt_telefono.KeyDown += txt_dni_KeyDown;
            txt_telefono.KeyPress += txt_dni_KeyPress;
            txt_telefono.MouseDown += txt_dni_MouseDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 350);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 29;
            label6.Text = "Fecha de alta";
            // 
            // txt_fechaAlta
            // 
            txt_fechaAlta.BackColor = Color.White;
            txt_fechaAlta.Location = new Point(66, 374);
            txt_fechaAlta.Margin = new Padding(3, 4, 3, 4);
            txt_fechaAlta.Multiline = true;
            txt_fechaAlta.Name = "txt_fechaAlta";
            txt_fechaAlta.ReadOnly = true;
            txt_fechaAlta.Size = new Size(174, 35);
            txt_fechaAlta.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(274, 274);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 27;
            label3.Text = "Repetir contraseña";
            // 
            // txt_repit
            // 
            txt_repit.Location = new Point(274, 298);
            txt_repit.Margin = new Padding(3, 4, 3, 4);
            txt_repit.MaxLength = 16;
            txt_repit.Multiline = true;
            txt_repit.Name = "txt_repit";
            txt_repit.Size = new Size(174, 35);
            txt_repit.TabIndex = 26;
            txt_repit.DragEnter += txt_dni_DragEnter;
            txt_repit.KeyDown += txt_nombre_KeyDown;
            txt_repit.KeyPress += txt_nombre_KeyPress;
            txt_repit.MouseDown += txt_dni_MouseDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 274);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 25;
            label4.Text = "Contraseña";
            // 
            // txt_contraseña
            // 
            txt_contraseña.Location = new Point(66, 298);
            txt_contraseña.Margin = new Padding(3, 4, 3, 4);
            txt_contraseña.MaxLength = 16;
            txt_contraseña.Multiline = true;
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(174, 35);
            txt_contraseña.TabIndex = 24;
            txt_contraseña.DragEnter += txt_dni_DragEnter;
            txt_contraseña.KeyDown += txt_nombre_KeyDown;
            txt_contraseña.KeyPress += txt_nombre_KeyPress;
            txt_contraseña.MouseDown += txt_dni_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(274, 204);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 23;
            label2.Text = "Nombre de usuario";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(274, 228);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.MaxLength = 16;
            txt_nombre.Multiline = true;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(174, 35);
            txt_nombre.TabIndex = 22;
            txt_nombre.DragEnter += txt_dni_DragEnter;
            txt_nombre.KeyDown += txt_nombre_KeyDown;
            txt_nombre.KeyPress += txt_nombre_KeyPress;
            txt_nombre.MouseDown += txt_dni_MouseDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(66, 204);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 21;
            label8.Text = "DNI";
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(66, 228);
            txt_dni.Margin = new Padding(3, 4, 3, 4);
            txt_dni.MaxLength = 8;
            txt_dni.Multiline = true;
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(174, 35);
            txt_dni.TabIndex = 20;
            txt_dni.DragEnter += txt_dni_DragEnter;
            txt_dni.KeyDown += txt_dni_KeyDown;
            txt_dni.KeyPress += txt_dni_KeyPress;
            txt_dni.MouseDown += txt_dni_MouseDown;
            // 
            // btn_buscar
            // 
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Location = new Point(297, 145);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(35, 35);
            btn_buscar.TabIndex = 19;
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // pic_usu
            // 
            pic_usu.BackColor = Color.Transparent;
            pic_usu.BackgroundImageLayout = ImageLayout.Zoom;
            pic_usu.Location = new Point(198, 81);
            pic_usu.Margin = new Padding(3, 4, 3, 4);
            pic_usu.Name = "pic_usu";
            pic_usu.Size = new Size(91, 99);
            pic_usu.TabIndex = 18;
            pic_usu.TabStop = false;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(146, 563);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(203, 52);
            button2.TabIndex = 10;
            button2.TabStop = false;
            button2.Text = "Crear usuario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(135, 24);
            label1.Name = "label1";
            label1.Size = new Size(233, 38);
            label1.TabIndex = 6;
            label1.Text = "Crear un usuario";
            label1.Click += label1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // registroDeUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1312, 931);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btn_salir);
            Controls.Add(btn_mini);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registroDeUser";
            Text = "registroDeUser";
            Load += registroDeUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_usu).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_salir;
        private Button btn_mini;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button button2;
        private Label label1;
        private Button btn_buscar;
        public PictureBox pic_usu;
        private Label label7;
        private TextBox txt_mail;
        private Label label5;
        private TextBox txt_telefono;
        private Label label6;
        private TextBox txt_fechaAlta;
        private Label label3;
        private TextBox txt_repit;
        private Label label4;
        private TextBox txt_contraseña;
        private Label label2;
        private TextBox txt_nombre;
        private Label label8;
        private TextBox txt_dni;
        private ErrorProvider errorProvider1;
    }
}