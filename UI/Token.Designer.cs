namespace MyM26.UI
{
    partial class Token
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Token));
            btn_verifi = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
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
            btn_verifi.Location = new Point(98, 335);
            btn_verifi.Name = "btn_verifi";
            btn_verifi.Size = new Size(148, 40);
            btn_verifi.TabIndex = 5;
            btn_verifi.Text = "Verificar correo";
            btn_verifi.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 133);
            label1.Name = "label1";
            label1.Size = new Size(229, 42);
            label1.TabIndex = 3;
            label1.Text = "Por favor ingrese el token que\r\nse ha enviado a su correo";
            label1.Click += label1_Click;
            // 
            // Token
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btn_verifi);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Token";
            Size = new Size(342, 509);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_verifi;
        private TextBox textBox1;
        private Label label1;
    }
}
