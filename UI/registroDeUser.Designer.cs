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
            btn_buscar = new Button();
            pic_usu = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btn_QA = new Button();
            panel2 = new Panel();
            button1 = new Button();
            button3 = new Button();
            txt_dni = new TextBox();
            label8 = new Label();
            txt_nombre = new TextBox();
            label2 = new Label();
            txt_contraseña = new TextBox();
            label4 = new Label();
            txt_repit = new TextBox();
            label3 = new Label();
            txt_fechaAlta = new TextBox();
            label6 = new Label();
            txt_telefono = new TextBox();
            label5 = new Label();
            txt_mail = new TextBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_usu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_buscar
            // 
            btn_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Location = new Point(292, 175);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(31, 26);
            btn_buscar.TabIndex = 19;
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // pic_usu
            // 
            pic_usu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic_usu.BackColor = Color.Transparent;
            pic_usu.BackgroundImageLayout = ImageLayout.Zoom;
            pic_usu.Location = new Point(206, 127);
            pic_usu.Name = "pic_usu";
            pic_usu.Size = new Size(80, 74);
            pic_usu.TabIndex = 18;
            pic_usu.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackgroundImage = Properties.Resources.leave;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(158, 514);
            button2.Name = "button2";
            button2.Size = new Size(178, 39);
            button2.TabIndex = 10;
            button2.TabStop = false;
            button2.Text = "Crear usuario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(11, 0, 57);
            label1.Location = new Point(190, 75);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 6;
            label1.Text = "Registrarse";
            label1.Click += label1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_QA
            // 
            btn_QA.Location = new Point(173, 596);
            btn_QA.Margin = new Padding(3, 2, 3, 2);
            btn_QA.Name = "btn_QA";
            btn_QA.Size = new Size(190, 35);
            btn_QA.TabIndex = 10;
            btn_QA.Text = "Boton QA";
            btn_QA.UseVisualStyleBackColor = true;
            btn_QA.Click += btn_QA_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txt_mail);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_telefono);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pic_usu);
            panel2.Controls.Add(txt_fechaAlta);
            panel2.Controls.Add(btn_buscar);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_dni);
            panel2.Controls.Add(txt_repit);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(txt_contraseña);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(639, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 698);
            panel2.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(215, 10, 60);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 10, 60);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(482, 1);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(25, 36);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_salir_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 178, 178);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 178, 178);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(456, 1);
            button3.Name = "button3";
            button3.Size = new Size(24, 36);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btn_mini_Click;
            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;
            // 
            // txt_dni
            // 
            txt_dni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_dni.Location = new Point(101, 249);
            txt_dni.MaxLength = 8;
            txt_dni.Multiline = true;
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(153, 27);
            txt_dni.TabIndex = 20;
            txt_dni.DragEnter += txt_dni_DragEnter;
            txt_dni.KeyDown += txt_dni_KeyDown;
            txt_dni.KeyPress += txt_dni_KeyPress;
            txt_dni.MouseDown += txt_dni_MouseDown;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(101, 231);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 21;
            label8.Text = "DNI";
            // 
            // txt_nombre
            // 
            txt_nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_nombre.Location = new Point(283, 249);
            txt_nombre.MaxLength = 16;
            txt_nombre.Multiline = true;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(153, 27);
            txt_nombre.TabIndex = 22;
            txt_nombre.DragEnter += txt_dni_DragEnter;
            txt_nombre.KeyDown += txt_nombre_KeyDown;
            txt_nombre.KeyPress += txt_nombre_KeyPress;
            txt_nombre.MouseDown += txt_dni_MouseDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(283, 231);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 23;
            label2.Text = "Nombre de usuario";
            // 
            // txt_contraseña
            // 
            txt_contraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_contraseña.Location = new Point(101, 302);
            txt_contraseña.MaxLength = 16;
            txt_contraseña.Multiline = true;
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(153, 27);
            txt_contraseña.TabIndex = 24;
            txt_contraseña.DragEnter += txt_dni_DragEnter;
            txt_contraseña.KeyDown += txt_nombre_KeyDown;
            txt_contraseña.KeyPress += txt_nombre_KeyPress;
            txt_contraseña.MouseDown += txt_dni_MouseDown;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 284);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 25;
            label4.Text = "Contraseña";
            // 
            // txt_repit
            // 
            txt_repit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_repit.Location = new Point(283, 302);
            txt_repit.MaxLength = 16;
            txt_repit.Multiline = true;
            txt_repit.Name = "txt_repit";
            txt_repit.Size = new Size(153, 27);
            txt_repit.TabIndex = 26;
            txt_repit.DragEnter += txt_dni_DragEnter;
            txt_repit.KeyDown += txt_nombre_KeyDown;
            txt_repit.KeyPress += txt_nombre_KeyPress;
            txt_repit.MouseDown += txt_dni_MouseDown;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(283, 284);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 27;
            label3.Text = "Repetir contraseña";
            // 
            // txt_fechaAlta
            // 
            txt_fechaAlta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_fechaAlta.BackColor = Color.White;
            txt_fechaAlta.Location = new Point(101, 358);
            txt_fechaAlta.Multiline = true;
            txt_fechaAlta.Name = "txt_fechaAlta";
            txt_fechaAlta.ReadOnly = true;
            txt_fechaAlta.Size = new Size(153, 27);
            txt_fechaAlta.TabIndex = 28;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(101, 340);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 29;
            label6.Text = "Fecha de alta";
            // 
            // txt_telefono
            // 
            txt_telefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_telefono.Location = new Point(283, 358);
            txt_telefono.MaxLength = 15;
            txt_telefono.Multiline = true;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(153, 27);
            txt_telefono.TabIndex = 30;
            txt_telefono.DragEnter += txt_dni_DragEnter;
            txt_telefono.KeyDown += txt_dni_KeyDown;
            txt_telefono.KeyPress += txt_dni_KeyPress;
            txt_telefono.MouseDown += txt_dni_MouseDown;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(283, 340);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 31;
            label5.Text = "Telefono";
            // 
            // txt_mail
            // 
            txt_mail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_mail.Location = new Point(101, 414);
            txt_mail.MaxLength = 200;
            txt_mail.Multiline = true;
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(186, 27);
            txt_mail.TabIndex = 32;
            txt_mail.DragEnter += txt_dni_DragEnter;
            txt_mail.KeyDown += txt_mail_KeyDown;
            txt_mail.KeyPress += txt_mail_KeyPress;
            txt_mail.MouseDown += txt_dni_MouseDown;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(101, 396);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 33;
            label7.Text = "Mail";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(26, 353);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(505, 151);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(122, 115);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 344);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // registroDeUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 0, 146);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1148, 698);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(btn_QA);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "registroDeUser";
            Text = "registroDeUser";
            Load += registroDeUser_Load;
            ((System.ComponentModel.ISupportInitialize)pic_usu).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Label label1;
        private Button btn_buscar;
        public PictureBox pic_usu;
        private ErrorProvider errorProvider1;
        private Button btn_QA;
        private Panel panel2;
        private Button button1;
        private Button button3;
        private Label label7;
        private TextBox txt_mail;
        private Label label5;
        private TextBox txt_telefono;
        private Label label6;
        private TextBox txt_fechaAlta;
        private Label label3;
        private TextBox txt_dni;
        private TextBox txt_repit;
        private Label label8;
        private Label label4;
        private TextBox txt_nombre;
        private TextBox txt_contraseña;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}