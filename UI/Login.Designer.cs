namespace MyM26.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btn_mini = new Button();
            btn_salir = new Button();
            panel1 = new Panel();
            lbl_error = new Label();
            pcb_ver = new PictureBox();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            label4 = new Label();
            label2 = new Label();
            txt_contra = new TextBox();
            txt_user = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_ver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
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
            btn_mini.Location = new Point(1088, 1);
            btn_mini.Name = "btn_mini";
            btn_mini.Size = new Size(20, 32);
            btn_mini.TabIndex = 0;
            btn_mini.UseVisualStyleBackColor = false;
            btn_mini.Click += btn_mini_Click;
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
            btn_salir.Location = new Point(1113, 1);
            btn_salir.Name = "btn_salir";
            btn_salir.RightToLeft = RightToLeft.No;
            btn_salir.Size = new Size(20, 32);
            btn_salir.TabIndex = 2;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lbl_error);
            panel1.Controls.Add(pcb_ver);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_contra);
            panel1.Controls.Add(txt_user);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(638, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 509);
            panel1.TabIndex = 4;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_error.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_error.Location = new Point(71, 291);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(182, 30);
            lbl_error.TabIndex = 13;
            lbl_error.Text = "Usuario no encontrado, por favor\r\nrevisa los campos\r\n";
            lbl_error.Visible = false;
            // 
            // pcb_ver
            // 
            pcb_ver.BackgroundImage = (Image)resources.GetObject("pcb_ver.BackgroundImage");
            pcb_ver.BackgroundImageLayout = ImageLayout.Stretch;
            pcb_ver.Location = new Point(266, 265);
            pcb_ver.Name = "pcb_ver";
            pcb_ver.Size = new Size(25, 25);
            pcb_ver.TabIndex = 12;
            pcb_ver.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(39, 33, 250);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(89, 83, 200);
            linkLabel1.Location = new Point(79, 468);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(166, 17);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste tu contraseña?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
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
            button2.Location = new Point(73, 396);
            button2.Name = "button2";
            button2.Size = new Size(178, 39);
            button2.TabIndex = 10;
            button2.TabStop = false;
            button2.Text = "  Iniciar sesión";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseDown += button2_MouseDown;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseUp += button2_MouseUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 245);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 9;
            label4.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 155);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 6;
            label2.Text = "Usuario o DNI";
            // 
            // txt_contra
            // 
            txt_contra.Location = new Point(71, 265);
            txt_contra.Name = "txt_contra";
            txt_contra.Size = new Size(179, 23);
            txt_contra.TabIndex = 7;
            txt_contra.DragEnter += txt_user_DragEnter;
            txt_contra.KeyDown += txt_contra_KeyDown;
            txt_contra.KeyPress += txt_user_KeyPress;
            txt_contra.MouseDown += txt_user_MouseDown;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(71, 175);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(179, 23);
            txt_user.TabIndex = 6;
            txt_user.DragEnter += txt_user_DragEnter;
            txt_user.KeyDown += txt_user_KeyDown;
            txt_user.KeyPress += txt_user_KeyPress;
            txt_user.MouseDown += txt_user_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 45);
            label1.Name = "label1";
            label1.Size = new Size(286, 37);
            label1.TabIndex = 6;
            label1.Text = "Bienvenido de nuevo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(111, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 312);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(84, 468);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 46);
            panel3.TabIndex = 6;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1148, 698);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_salir);
            Controls.Add(btn_mini);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_ver).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_mini;
        private Button btn_salir;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button2;
        private Label label4;
        private Label label2;
        private TextBox txt_contra;
        private TextBox txt_user;
        private LinkLabel linkLabel1;
        private PictureBox pcb_ver;
        private Panel panel3;
        private ErrorProvider errorProvider1;
        private Label lbl_error;
    }
}