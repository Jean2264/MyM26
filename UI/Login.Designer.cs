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
            errorProvider1 = new ErrorProvider(components);
            btn_QA = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_ver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_mini
            // 
            btn_mini.BackColor = Color.Transparent;
            btn_mini.BackgroundImageLayout = ImageLayout.Zoom;
            btn_mini.FlatAppearance.BorderSize = 0;
            btn_mini.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 178, 178);
            btn_mini.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 178, 178);
            btn_mini.FlatStyle = FlatStyle.Flat;
            btn_mini.Image = (Image)resources.GetObject("btn_mini.Image");
            btn_mini.Location = new Point(524, 0);
            btn_mini.Margin = new Padding(3, 4, 3, 4);
            btn_mini.Name = "btn_mini";
            btn_mini.Size = new Size(27, 48);
            btn_mini.TabIndex = 0;
            btn_mini.UseVisualStyleBackColor = false;
            btn_mini.Click += btn_mini_Click;
            btn_mini.MouseEnter += btn_mini_MouseEnter;
            btn_mini.MouseLeave += btn_mini_MouseLeave;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Transparent;
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatAppearance.MouseDownBackColor = Color.FromArgb(215, 10, 60);
            btn_salir.FlatAppearance.MouseOverBackColor = Color.FromArgb(215, 10, 60);
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Image = (Image)resources.GetObject("btn_salir.Image");
            btn_salir.Location = new Point(553, 0);
            btn_salir.Margin = new Padding(3, 4, 3, 4);
            btn_salir.Name = "btn_salir";
            btn_salir.RightToLeft = RightToLeft.No;
            btn_salir.Size = new Size(29, 48);
            btn_salir.TabIndex = 2;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            btn_salir.MouseEnter += btn_salir_MouseEnter;
            btn_salir.MouseLeave += btn_salir_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lbl_error);
            panel1.Controls.Add(pcb_ver);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btn_salir);
            panel1.Controls.Add(btn_mini);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_contra);
            panel1.Controls.Add(txt_user);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(729, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 933);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_error.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_error.Location = new Point(156, 493);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(239, 40);
            lbl_error.TabIndex = 13;
            lbl_error.Text = "Usuario no encontrado, por favor\r\nrevisa los campos\r\n";
            lbl_error.Visible = false;
            // 
            // pcb_ver
            // 
            pcb_ver.BackgroundImage = (Image)resources.GetObject("pcb_ver.BackgroundImage");
            pcb_ver.BackgroundImageLayout = ImageLayout.Stretch;
            pcb_ver.Location = new Point(424, 455);
            pcb_ver.Margin = new Padding(3, 4, 3, 4);
            pcb_ver.Name = "pcb_ver";
            pcb_ver.Size = new Size(29, 33);
            pcb_ver.TabIndex = 12;
            pcb_ver.TabStop = false;
            pcb_ver.Click += pcb_ver_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(39, 33, 250);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(89, 83, 200);
            linkLabel1.Location = new Point(165, 757);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(255, 28);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste tu contraseña?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(185, 648);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(203, 52);
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
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 7.8F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(161, 463);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 9;
            label4.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Enabled = false;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(158, 404);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 6;
            label2.Text = "Usuario o DNI";
            // 
            // txt_contra
            // 
            txt_contra.Location = new Point(156, 458);
            txt_contra.Margin = new Padding(3, 4, 3, 4);
            txt_contra.Name = "txt_contra";
            txt_contra.Size = new Size(257, 27);
            txt_contra.TabIndex = 7;
            txt_contra.DragEnter += txt_user_DragEnter;
            txt_contra.Enter += txt_contra_Enter;
            txt_contra.KeyDown += txt_contra_KeyDown;
            txt_contra.KeyPress += txt_user_KeyPress;
            txt_contra.Leave += txt_contra_Leave;
            txt_contra.MouseDown += txt_user_MouseDown;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(156, 399);
            txt_user.Margin = new Padding(3, 4, 3, 4);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(257, 27);
            txt_user.TabIndex = 6;
            txt_user.TextChanged += txt_user_TextChanged;
            txt_user.DragEnter += txt_user_DragEnter;
            txt_user.Enter += txt_user_Enter;
            txt_user.KeyDown += txt_user_KeyDown;
            txt_user.KeyPress += txt_user_KeyPress;
            txt_user.Leave += txt_user_Leave;
            txt_user.MouseDown += txt_user_MouseDown;
            txt_user.MouseEnter += txt_user_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(11, 0, 57);
            label1.Location = new Point(137, 291);
            label1.Name = "label1";
            label1.Size = new Size(293, 38);
            label1.TabIndex = 6;
            label1.Text = "Bienvenido de nuevo";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btn_QA
            // 
            btn_QA.Location = new Point(262, 781);
            btn_QA.Name = "btn_QA";
            btn_QA.Size = new Size(217, 47);
            btn_QA.TabIndex = 7;
            btn_QA.Text = "Boton QA";
            btn_QA.UseVisualStyleBackColor = true;
            btn_QA.Click += btn_QA_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(85, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 459);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(30, 471);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(577, 123);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 0, 146);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1312, 931);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_QA);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = SystemColors.InactiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_mini;
        private Button btn_salir;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private Label label4;
        private Label label2;
        private TextBox txt_contra;
        private TextBox txt_user;
        private LinkLabel linkLabel1;
        private PictureBox pcb_ver;
        private ErrorProvider errorProvider1;
        private Label lbl_error;
        private Button btn_QA;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}