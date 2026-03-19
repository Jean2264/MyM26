namespace MyM26.screens
{
    partial class añadirCyP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(añadirCyP));
            panel1 = new Panel();
            label_title = new Label();
            btn_salir = new Button();
            label1 = new Label();
            txt_cuit = new TextBox();
            label2 = new Label();
            txt_nombre = new TextBox();
            lbl_EM_EN = new Label();
            txt_entidad = new TextBox();
            label3 = new Label();
            txt_telefono = new TextBox();
            label4 = new Label();
            txt_mail = new TextBox();
            btn_alta_modi = new Button();
            panel2 = new Panel();
            cmb_entidad = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            panel7 = new Panel();
            lbl_R4 = new Label();
            panel5 = new Panel();
            lbl_R2 = new Label();
            panel6 = new Panel();
            lbl_R3 = new Label();
            panel4 = new Panel();
            lbl_R1 = new Label();
            label6 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(364, 25);
            panel1.TabIndex = 0;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(8, 5);
            label_title.Name = "label_title";
            label_title.Size = new Size(0, 15);
            label_title.TabIndex = 29;
            // 
            // btn_salir
            // 
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Location = new Point(342, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(15, 15);
            btn_salir.TabIndex = 1;
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 68);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 17;
            label1.Text = "Cuit";
            // 
            // txt_cuit
            // 
            txt_cuit.BackColor = Color.White;
            txt_cuit.Location = new Point(18, 86);
            txt_cuit.MaxLength = 11;
            txt_cuit.Multiline = true;
            txt_cuit.Name = "txt_cuit";
            txt_cuit.Size = new Size(153, 27);
            txt_cuit.TabIndex = 16;
            txt_cuit.DragEnter += txt_cuit_DragEnter;
            txt_cuit.KeyDown += txt_cuit_KeyDown;
            txt_cuit.KeyPress += txt_cuit_KeyPress;
            txt_cuit.MouseDown += txt_telefono_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 68);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.White;
            txt_nombre.Location = new Point(188, 86);
            txt_nombre.MaxLength = 100;
            txt_nombre.Multiline = true;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(153, 27);
            txt_nombre.TabIndex = 18;
            txt_nombre.DragEnter += txt_cuit_DragEnter;
            txt_nombre.KeyDown += txt_nombre_KeyDown;
            txt_nombre.KeyPress += txt_nombre_KeyPress;
            txt_nombre.MouseDown += txt_telefono_MouseDown;
            // 
            // lbl_EM_EN
            // 
            lbl_EM_EN.AutoSize = true;
            lbl_EM_EN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_EM_EN.Location = new Point(18, 129);
            lbl_EM_EN.Name = "lbl_EM_EN";
            lbl_EM_EN.Size = new Size(0, 15);
            lbl_EM_EN.TabIndex = 21;
            // 
            // txt_entidad
            // 
            txt_entidad.BackColor = Color.White;
            txt_entidad.Location = new Point(9, 115);
            txt_entidad.MaxLength = 100;
            txt_entidad.Multiline = true;
            txt_entidad.Name = "txt_entidad";
            txt_entidad.Size = new Size(153, 27);
            txt_entidad.TabIndex = 20;
            txt_entidad.Visible = false;
            txt_entidad.DragEnter += txt_cuit_DragEnter;
            txt_entidad.KeyDown += txt_nombre_KeyDown;
            txt_entidad.KeyPress += txt_nombre_KeyPress;
            txt_entidad.MouseDown += txt_telefono_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(188, 129);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 23;
            label3.Text = "Telefono";
            // 
            // txt_telefono
            // 
            txt_telefono.BackColor = Color.White;
            txt_telefono.Location = new Point(188, 147);
            txt_telefono.MaxLength = 15;
            txt_telefono.Multiline = true;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(153, 27);
            txt_telefono.TabIndex = 22;
            txt_telefono.DragEnter += txt_cuit_DragEnter;
            txt_telefono.KeyDown += txt_cuit_KeyDown;
            txt_telefono.KeyPress += txt_cuit_KeyPress;
            txt_telefono.MouseDown += txt_telefono_MouseDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 189);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 25;
            label4.Text = "Mail";
            // 
            // txt_mail
            // 
            txt_mail.BackColor = Color.White;
            txt_mail.Location = new Point(18, 207);
            txt_mail.MaxLength = 100;
            txt_mail.Multiline = true;
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(191, 27);
            txt_mail.TabIndex = 24;
            txt_mail.DragEnter += txt_cuit_DragEnter;
            txt_mail.KeyDown += txt_mail_KeyDown;
            txt_mail.KeyPress += txt_mail_KeyPress;
            txt_mail.MouseDown += txt_telefono_MouseDown;
            // 
            // btn_alta_modi
            // 
            btn_alta_modi.BackColor = Color.Transparent;
            btn_alta_modi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_alta_modi.FlatAppearance.BorderSize = 0;
            btn_alta_modi.FlatStyle = FlatStyle.Flat;
            btn_alta_modi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_alta_modi.ForeColor = Color.White;
            btn_alta_modi.Location = new Point(100, 220);
            btn_alta_modi.Name = "btn_alta_modi";
            btn_alta_modi.Size = new Size(135, 35);
            btn_alta_modi.TabIndex = 26;
            btn_alta_modi.UseVisualStyleBackColor = false;
            btn_alta_modi.Click += btn_alta_modi_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cmb_entidad);
            panel2.Controls.Add(btn_alta_modi);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_entidad);
            panel2.Location = new Point(8, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 266);
            panel2.TabIndex = 27;
            panel2.Paint += panel2_Paint;
            // 
            // cmb_entidad
            // 
            cmb_entidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_entidad.FormattingEnabled = true;
            cmb_entidad.Location = new Point(9, 115);
            cmb_entidad.Name = "cmb_entidad";
            cmb_entidad.Size = new Size(153, 23);
            cmb_entidad.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(113, 6);
            label5.Name = "label5";
            label5.Size = new Size(141, 21);
            label5.TabIndex = 28;
            label5.Text = "Información basica";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(8, 304);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 182);
            panel3.TabIndex = 28;
            panel3.Paint += panel3_Paint;
            // 
            // panel7
            // 
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Controls.Add(lbl_R4);
            panel7.Location = new Point(8, 143);
            panel7.Name = "panel7";
            panel7.Size = new Size(323, 29);
            panel7.TabIndex = 32;
            // 
            // lbl_R4
            // 
            lbl_R4.AutoSize = true;
            lbl_R4.BackColor = Color.Transparent;
            lbl_R4.Font = new Font("Segoe UI", 11.25F);
            lbl_R4.ForeColor = Color.White;
            lbl_R4.Location = new Point(5, 3);
            lbl_R4.Name = "lbl_R4";
            lbl_R4.Size = new Size(48, 20);
            lbl_R4.TabIndex = 32;
            lbl_R4.Text = " vvvvv";
            lbl_R4.Click += lbl_R4_Click;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(lbl_R2);
            panel5.Location = new Point(8, 77);
            panel5.Name = "panel5";
            panel5.Size = new Size(323, 29);
            panel5.TabIndex = 30;
            // 
            // lbl_R2
            // 
            lbl_R2.AutoSize = true;
            lbl_R2.BackColor = Color.Transparent;
            lbl_R2.Font = new Font("Segoe UI", 11.25F);
            lbl_R2.ForeColor = Color.White;
            lbl_R2.Location = new Point(4, 3);
            lbl_R2.Name = "lbl_R2";
            lbl_R2.Size = new Size(48, 20);
            lbl_R2.TabIndex = 30;
            lbl_R2.Text = " vvvvv";
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Controls.Add(lbl_R3);
            panel6.Location = new Point(8, 110);
            panel6.Name = "panel6";
            panel6.Size = new Size(323, 29);
            panel6.TabIndex = 30;
            // 
            // lbl_R3
            // 
            lbl_R3.AutoSize = true;
            lbl_R3.BackColor = Color.Transparent;
            lbl_R3.Font = new Font("Segoe UI", 11.25F);
            lbl_R3.ForeColor = Color.White;
            lbl_R3.Location = new Point(4, 3);
            lbl_R3.Name = "lbl_R3";
            lbl_R3.Size = new Size(48, 20);
            lbl_R3.TabIndex = 31;
            lbl_R3.Text = " vvvvv";
            lbl_R3.Click += lbl_R3_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(lbl_R1);
            panel4.Location = new Point(8, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(323, 29);
            panel4.TabIndex = 29;
            // 
            // lbl_R1
            // 
            lbl_R1.AutoSize = true;
            lbl_R1.BackColor = Color.Transparent;
            lbl_R1.Font = new Font("Segoe UI", 11.25F);
            lbl_R1.ForeColor = Color.White;
            lbl_R1.Location = new Point(4, 3);
            lbl_R1.Name = "lbl_R1";
            lbl_R1.Size = new Size(48, 20);
            lbl_R1.TabIndex = 29;
            lbl_R1.Text = " vvvvv";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(113, 9);
            label6.Name = "label6";
            label6.Size = new Size(139, 21);
            label6.TabIndex = 29;
            label6.Text = "Resumen historico";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // añadirCyP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(364, 301);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(txt_mail);
            Controls.Add(label3);
            Controls.Add(txt_telefono);
            Controls.Add(lbl_EM_EN);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Controls.Add(txt_cuit);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "añadirCyP";
            StartPosition = FormStartPosition.CenterParent;
            Text = "añadirCyP";
            Load += añadirCyP_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_salir;
        private Label label1;
        private TextBox txt_cuit;
        private Label label2;
        private TextBox txt_nombre;
        private Label lbl_EM_EN;
        private TextBox txt_entidad;
        private Label label3;
        private TextBox txt_telefono;
        private Label label4;
        private TextBox txt_mail;
        private Button btn_alta_modi;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label_title;
        private Label lbl_R3;
        private Label lbl_R2;
        private Label lbl_R1;
        private Label label6;
        private ErrorProvider errorProvider1;
        private ComboBox cmb_entidad;
        private Label lbl_R4;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
    }
}