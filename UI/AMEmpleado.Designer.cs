namespace MyM26.UI
{
    partial class AMEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMEmpleado));
            panel1 = new Panel();
            label_title = new Label();
            btn_salir = new Button();
            txt_apellido = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_telefono = new TextBox();
            txt_nombre = new TextBox();
            label6 = new Label();
            txt_mail = new TextBox();
            label7 = new Label();
            cmb_seccion = new ComboBox();
            button1 = new Button();
            txt_dni = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 23);
            panel1.TabIndex = 1;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(3, 3);
            label_title.Name = "label_title";
            label_title.Size = new Size(0, 15);
            label_title.TabIndex = 16;
            // 
            // btn_salir
            // 
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Location = new Point(363, 3);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(15, 15);
            btn_salir.TabIndex = 1;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.White;
            txt_apellido.Location = new Point(210, 80);
            txt_apellido.MaxLength = 100;
            txt_apellido.Multiline = true;
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(167, 27);
            txt_apellido.TabIndex = 20;
            txt_apellido.TextChanged += txt_nombre_TextChanged;
            txt_apellido.DragEnter += txt_dni_DragEnter;
            txt_apellido.KeyDown += txt_apellido_KeyDown;
            txt_apellido.KeyPress += txt_apellido_KeyPress;
            txt_apellido.MouseDown += txt_apellido_MouseDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(129, 28);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 31;
            label5.Text = "Información basica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 30;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 62);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 29;
            label1.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(210, 116);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 35;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 116);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 34;
            label4.Text = "Nombre";
            // 
            // txt_telefono
            // 
            txt_telefono.BackColor = Color.White;
            txt_telefono.Location = new Point(210, 134);
            txt_telefono.MaxLength = 15;
            txt_telefono.Multiline = true;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(167, 27);
            txt_telefono.TabIndex = 33;
            txt_telefono.DragEnter += txt_dni_DragEnter;
            txt_telefono.KeyDown += txt_dni_KeyDown;
            txt_telefono.KeyPress += txt_dni_KeyPress;
            txt_telefono.MouseDown += txt_dni_MouseDown;
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.White;
            txt_nombre.Location = new Point(17, 134);
            txt_nombre.MaxLength = 11;
            txt_nombre.Multiline = true;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(167, 27);
            txt_nombre.TabIndex = 32;
            txt_nombre.DragEnter += txt_dni_DragEnter;
            txt_nombre.KeyDown += txt_apellido_KeyDown;
            txt_nombre.KeyPress += txt_apellido_KeyPress;
            txt_nombre.MouseDown += txt_apellido_MouseDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 179);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 37;
            label6.Text = "Mail";
            // 
            // txt_mail
            // 
            txt_mail.BackColor = Color.White;
            txt_mail.Location = new Point(17, 197);
            txt_mail.MaxLength = 200;
            txt_mail.Multiline = true;
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(167, 27);
            txt_mail.TabIndex = 36;
            txt_mail.DragEnter += txt_dni_DragEnter;
            txt_mail.KeyDown += txt_mail_KeyDown;
            txt_mail.KeyPress += txt_mail_KeyPress;
            txt_mail.MouseDown += txt_mail_MouseDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(210, 179);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 38;
            label7.Text = "Sección";
            // 
            // cmb_seccion
            // 
            cmb_seccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_seccion.FormattingEnabled = true;
            cmb_seccion.Location = new Point(210, 197);
            cmb_seccion.Name = "cmb_seccion";
            cmb_seccion.Size = new Size(167, 23);
            cmb_seccion.TabIndex = 39;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(125, 254);
            button1.Name = "button1";
            button1.Size = new Size(135, 35);
            button1.TabIndex = 40;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_dni
            // 
            txt_dni.BackColor = Color.White;
            txt_dni.Location = new Point(17, 80);
            txt_dni.MaxLength = 8;
            txt_dni.Multiline = true;
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(167, 27);
            txt_dni.TabIndex = 42;
            txt_dni.DragEnter += txt_dni_DragEnter;
            txt_dni.KeyDown += txt_dni_KeyDown;
            txt_dni.KeyPress += txt_dni_KeyPress;
            txt_dni.MouseDown += txt_dni_MouseDown;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AMEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(391, 301);
            Controls.Add(txt_dni);
            Controls.Add(button1);
            Controls.Add(cmb_seccion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txt_mail);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txt_telefono);
            Controls.Add(txt_nombre);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_apellido);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AMEmpleado";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "AMEmpleado";
            Load += AMEmpleado_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label_title;
        private Button btn_salir;
        private TextBox txt_apellido;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txt_telefono;
        private TextBox txt_nombre;
        private Label label6;
        private TextBox txt_mail;
        private Label label7;
        private ComboBox cmb_seccion;
        private Button button1;
        private TextBox txt_dni;
        private ErrorProvider errorProvider1;
    }
}