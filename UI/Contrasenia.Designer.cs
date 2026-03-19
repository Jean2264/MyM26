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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contrasenia));
            btn_verifi = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbl_error = new Label();
            lbl_user = new Label();
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
            btn_verifi.Location = new Point(80, 327);
            btn_verifi.Name = "btn_verifi";
            btn_verifi.Size = new Size(148, 40);
            btn_verifi.TabIndex = 8;
            btn_verifi.Text = "Actualizar Contraseña";
            btn_verifi.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 260);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 193);
            label1.Name = "label1";
            label1.Size = new Size(179, 17);
            label1.TabIndex = 10;
            label1.Text = "Ingrese la nueva contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 240);
            label2.Name = "label2";
            label2.Size = new Size(172, 17);
            label2.TabIndex = 11;
            label2.Text = "Repita la nueva contraseña";
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_error.Location = new Point(58, 290);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(175, 15);
            lbl_error.TabIndex = 12;
            lbl_error.Text = "Las contraseñas deben coincidir";
            lbl_error.Visible = false;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new Point(54, 95);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(63, 15);
            lbl_user.TabIndex = 13;
            lbl_user.Text = "Tu usuario";
            // 
            // Contrasenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Controls.Add(textBox1);
            Name = "Contrasenia";
            Size = new Size(342, 509);
       
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_verifi;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label lbl_error;
        private Label lbl_user;
    }
}
