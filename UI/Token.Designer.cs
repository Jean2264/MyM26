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
            txt_token = new TextBox();
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
            btn_verifi.Location = new Point(112, 447);
            btn_verifi.Margin = new Padding(3, 4, 3, 4);
            btn_verifi.Name = "btn_verifi";
            btn_verifi.Size = new Size(169, 53);
            btn_verifi.TabIndex = 5;
            btn_verifi.Text = "Verificar correo";
            btn_verifi.UseVisualStyleBackColor = true;
            btn_verifi.Click += btn_verifi_Click;
            // 
            // txt_token
            // 
            txt_token.Location = new Point(75, 281);
            txt_token.Margin = new Padding(3, 4, 3, 4);
            txt_token.Name = "txt_token";
            txt_token.Size = new Size(236, 27);
            txt_token.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 177);
            label1.Name = "label1";
            label1.Size = new Size(289, 56);
            label1.TabIndex = 3;
            label1.Text = "Por favor ingrese el token que\r\nse ha enviado a su correo";
            label1.Click += label1_Click;
            // 
            // Token
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btn_verifi);
            Controls.Add(txt_token);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Token";
            Size = new Size(391, 679);
            Load += Token_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_verifi;
        private TextBox txt_token;
        private Label label1;
    }
}
