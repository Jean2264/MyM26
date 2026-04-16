namespace MyM26.UI
{
    partial class Contrasenia
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contrasenia));
            btn_verifi = new Button();
            txt_contra = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbl_error = new Label();
            lbl_user = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btn_verifi
            // 
            btn_verifi.BackgroundImage = Properties.Resources.verde;
            btn_verifi.BackgroundImageLayout = ImageLayout.Stretch;
            btn_verifi.FlatAppearance.BorderSize = 0;
            btn_verifi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_verifi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_verifi.FlatStyle = FlatStyle.Flat;
            btn_verifi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_verifi.ForeColor = Color.White;
            btn_verifi.Location = new Point(91, 436);
            btn_verifi.Margin = new Padding(3, 4, 3, 4);
            btn_verifi.Name = "btn_verifi";
            btn_verifi.Size = new Size(169, 34);
            btn_verifi.TabIndex = 8;
            btn_verifi.Text = "Actualizar Contraseña";
            btn_verifi.UseVisualStyleBackColor = true;
            btn_verifi.Click += btn_verifi_Click;
            // 
            // txt_contra
            // 
            txt_contra.Location = new Point(65, 281);
            txt_contra.Margin = new Padding(3, 4, 3, 4);
            txt_contra.Name = "txt_contra";
            txt_contra.Size = new Size(236, 27);
            txt_contra.TabIndex = 7;
            txt_contra.UseSystemPasswordChar = true;
            txt_contra.DragEnter += txt_contra_DragEnter;
            txt_contra.KeyDown += txt_contra_KeyDown;
            txt_contra.KeyPress += txt_contra_KeyPress;
            txt_contra.MouseDown += txt_contra_MouseDown;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 347);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 27);
            textBox2.TabIndex = 9;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.DragEnter += txt_contra_DragEnter;
            textBox2.KeyDown += txt_contra_KeyDown;
            textBox2.KeyPress += txt_contra_KeyPress;
            textBox2.MouseDown += txt_contra_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 257);
            label1.Name = "label1";
            label1.Size = new Size(225, 23);
            label1.TabIndex = 10;
            label1.Text = "Ingrese la nueva contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 320);
            label2.Name = "label2";
            label2.Size = new Size(218, 23);
            label2.TabIndex = 11;
            label2.Text = "Repita la nueva contraseña";
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_error.Location = new Point(66, 387);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(219, 20);
            lbl_error.TabIndex = 12;
            lbl_error.Text = "Las contraseñas deben coincidir";
            lbl_error.Visible = false;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_user.Location = new Point(62, 127);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(82, 20);
            lbl_user.TabIndex = 13;
            lbl_user.Text = "Tu usuario";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Contrasenia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lbl_user);
            Controls.Add(lbl_error);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(btn_verifi);
            Controls.Add(txt_contra);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Contrasenia";
            Size = new Size(391, 679);
            Load += Contrasenia_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_verifi;
        private TextBox txt_contra;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label lbl_error;
        private Label lbl_user;
        private ErrorProvider errorProvider1;
    }
}
